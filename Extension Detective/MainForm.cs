using TrID;
using System.IO;
using System.Windows.Forms;
using Ookii.Dialogs.WinForms;
using System.Threading.Tasks;

namespace Extension_Detective
{
    public partial class MainForm : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;    
                return handleParam;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private async void chooseFilesButton_Click(object sender, System.EventArgs e)
        {
            using (VistaOpenFileDialog vofd = new VistaOpenFileDialog())
            {
                vofd.Title = "Select Files";
                vofd.Multiselect = true;

                if (vofd.ShowDialog() == DialogResult.OK)
                {
                    using (VistaFolderBrowserDialog vfbd = new VistaFolderBrowserDialog())
                    {
                        vfbd.UseDescriptionForTitle = true;
                        vfbd.Description = "Select Output Folder";

                        if (vfbd.ShowDialog() == DialogResult.OK)
                        {
                            await BeginFileConversionAsync(vofd.FileNames, vfbd.SelectedPath);
                        }
                    }
                }
            }
        }

        private async Task BeginFileConversionAsync(string[] files, string outputFolder)
        {
            SetControlsState(true);
            string correctExtension, fileName = string.Empty;

            foreach (string file in files)
            {
                try
                {
                    await Task.Run(() =>
                    {
                        fileName = Path.GetFileNameWithoutExtension(file);
                        correctExtension = TrIDEngine.GetExtensionByFileContent(file);
                        correctExtension = correctExtension == null ? ".txt" : correctExtension;

                        File.Copy(file, $@"{outputFolder}\{fileName}{correctExtension.ToLower()}");
                    });
                    statusLabel.Text = $"Successfully corrected extension for file: {fileName}";
                }
                catch
                {
                    statusLabel.Text = $"Failed to correct extension for file: {fileName}";
                    continue;
                }
            }
            statusLabel.Text = "Waiting...";
            SetControlsState(false);
        }

        private void SetControlsState(bool conversion)
        {
            switch (conversion)
            {
                case true:
                    chooseFilesButton.Enabled = false;
                    break;
                case false:
                    chooseFilesButton.Enabled = true;
                    statusLabel.Text = "Waiting...";
                    MessageBox.Show("Correction finished successfully.", "Done!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
            }
        }
    }
}
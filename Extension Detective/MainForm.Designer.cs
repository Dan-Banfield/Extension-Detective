namespace Extension_Detective
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.netSealTheme = new NSTheme();
            this.statusLabel = new System.Windows.Forms.Label();
            this.nsLabel1 = new NSLabel();
            this.fileSelectionGroupBox = new NSGroupBox();
            this.chooseFilesButton = new NSButton();
            this.closeButton = new NSControlButton();
            this.netSealTheme.SuspendLayout();
            this.fileSelectionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // netSealTheme
            // 
            this.netSealTheme.AccentOffset = 0;
            this.netSealTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.netSealTheme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.netSealTheme.Colors = new Bloom[0];
            this.netSealTheme.Controls.Add(this.statusLabel);
            this.netSealTheme.Controls.Add(this.nsLabel1);
            this.netSealTheme.Controls.Add(this.fileSelectionGroupBox);
            this.netSealTheme.Controls.Add(this.closeButton);
            this.netSealTheme.Customization = "";
            this.netSealTheme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.netSealTheme.Font = new System.Drawing.Font("Verdana", 8F);
            this.netSealTheme.Image = null;
            this.netSealTheme.Location = new System.Drawing.Point(0, 0);
            this.netSealTheme.Movable = true;
            this.netSealTheme.Name = "netSealTheme";
            this.netSealTheme.NoRounding = false;
            this.netSealTheme.Sizable = false;
            this.netSealTheme.Size = new System.Drawing.Size(684, 194);
            this.netSealTheme.SmartBounds = true;
            this.netSealTheme.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.netSealTheme.TabIndex = 0;
            this.netSealTheme.Text = "Extension Detective - v1.0";
            this.netSealTheme.TransparencyKey = System.Drawing.Color.Empty;
            this.netSealTheme.Transparent = false;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.White;
            this.statusLabel.Location = new System.Drawing.Point(91, 164);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(70, 16);
            this.statusLabel.TabIndex = 3;
            this.statusLabel.Text = "Waiting...";
            // 
            // nsLabel1
            // 
            this.nsLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.nsLabel1.Location = new System.Drawing.Point(17, 160);
            this.nsLabel1.Name = "nsLabel1";
            this.nsLabel1.Size = new System.Drawing.Size(68, 23);
            this.nsLabel1.TabIndex = 2;
            this.nsLabel1.Value1 = "STATUS:";
            this.nsLabel1.Value2 = "";
            // 
            // fileSelectionGroupBox
            // 
            this.fileSelectionGroupBox.Controls.Add(this.chooseFilesButton);
            this.fileSelectionGroupBox.DrawSeperator = false;
            this.fileSelectionGroupBox.Location = new System.Drawing.Point(17, 44);
            this.fileSelectionGroupBox.Name = "fileSelectionGroupBox";
            this.fileSelectionGroupBox.Size = new System.Drawing.Size(651, 107);
            this.fileSelectionGroupBox.SubTitle = "Select the files to correct the extensions for.";
            this.fileSelectionGroupBox.TabIndex = 1;
            this.fileSelectionGroupBox.Text = "nsGroupBox1";
            this.fileSelectionGroupBox.Title = "File Selection";
            // 
            // chooseFilesButton
            // 
            this.chooseFilesButton.Location = new System.Drawing.Point(14, 45);
            this.chooseFilesButton.Name = "chooseFilesButton";
            this.chooseFilesButton.Size = new System.Drawing.Size(622, 45);
            this.chooseFilesButton.TabIndex = 0;
            this.chooseFilesButton.Text = "Choose Files for Extension Correction";
            this.chooseFilesButton.Click += new System.EventHandler(this.chooseFilesButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.ControlButton = NSControlButton.Button.Close;
            this.closeButton.Location = new System.Drawing.Point(659, 5);
            this.closeButton.Margin = new System.Windows.Forms.Padding(0);
            this.closeButton.MaximumSize = new System.Drawing.Size(18, 20);
            this.closeButton.MinimumSize = new System.Drawing.Size(18, 20);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(18, 20);
            this.closeButton.TabIndex = 0;
            this.closeButton.Text = "nsControlButton1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(684, 194);
            this.Controls.Add(this.netSealTheme);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extension Detective - v1.0";
            this.netSealTheme.ResumeLayout(false);
            this.netSealTheme.PerformLayout();
            this.fileSelectionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private NSTheme netSealTheme;
        private NSControlButton closeButton;
        private NSGroupBox fileSelectionGroupBox;
        private NSButton chooseFilesButton;
        private NSLabel nsLabel1;
        private System.Windows.Forms.Label statusLabel;
    }
}


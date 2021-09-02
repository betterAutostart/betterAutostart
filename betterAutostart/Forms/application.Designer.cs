
namespace betterAutostart
{
    partial class application
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_createNewProfile = new System.Windows.Forms.Button();
            this.btn_editProfiles = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_startProfile = new System.Windows.Forms.Button();
            this.btn_stopProfile = new System.Windows.Forms.Button();
            this.btn_addNewPath = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_demoProfile_name = new System.Windows.Forms.Label();
            this.lstBx_demoProfile = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn_createNewProfile
            // 
            this.btn_createNewProfile.Location = new System.Drawing.Point(12, 606);
            this.btn_createNewProfile.Name = "btn_createNewProfile";
            this.btn_createNewProfile.Size = new System.Drawing.Size(398, 46);
            this.btn_createNewProfile.TabIndex = 0;
            this.btn_createNewProfile.Text = "btn_createNewProfile";
            this.btn_createNewProfile.UseVisualStyleBackColor = true;
            this.btn_createNewProfile.Click += new System.EventHandler(this.btn_createNewProfile_Click);
            // 
            // btn_editProfiles
            // 
            this.btn_editProfiles.Location = new System.Drawing.Point(591, 606);
            this.btn_editProfiles.Name = "btn_editProfiles";
            this.btn_editProfiles.Size = new System.Drawing.Size(398, 46);
            this.btn_editProfiles.TabIndex = 1;
            this.btn_editProfiles.Text = "btn_editProfiles";
            this.btn_editProfiles.UseVisualStyleBackColor = true;
            this.btn_editProfiles.Click += new System.EventHandler(this.btn_editProfiles_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(891, 12);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(98, 46);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "btn_settings";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_startProfile
            // 
            this.btn_startProfile.Location = new System.Drawing.Point(260, 443);
            this.btn_startProfile.Name = "btn_startProfile";
            this.btn_startProfile.Size = new System.Drawing.Size(177, 40);
            this.btn_startProfile.TabIndex = 3;
            this.btn_startProfile.Text = "btn_startProfile";
            this.btn_startProfile.UseVisualStyleBackColor = true;
            this.btn_startProfile.Click += new System.EventHandler(this.btn_startProfile_Click);
            // 
            // btn_stopProfile
            // 
            this.btn_stopProfile.Location = new System.Drawing.Point(443, 443);
            this.btn_stopProfile.Name = "btn_stopProfile";
            this.btn_stopProfile.Size = new System.Drawing.Size(177, 40);
            this.btn_stopProfile.TabIndex = 4;
            this.btn_stopProfile.Text = "btn_stopProfile";
            this.btn_stopProfile.UseVisualStyleBackColor = true;
            this.btn_stopProfile.Click += new System.EventHandler(this.btn_stopProfile_Click);
            // 
            // btn_addNewPath
            // 
            this.btn_addNewPath.Location = new System.Drawing.Point(361, 366);
            this.btn_addNewPath.Name = "btn_addNewPath";
            this.btn_addNewPath.Size = new System.Drawing.Size(159, 40);
            this.btn_addNewPath.TabIndex = 7;
            this.btn_addNewPath.Text = "btn_addNewPath";
            this.btn_addNewPath.UseVisualStyleBackColor = true;
            this.btn_addNewPath.Click += new System.EventHandler(this.btn_addNewPath_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(416, 605);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(169, 47);
            this.btn_save.TabIndex = 8;
            this.btn_save.Text = "btn_save";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // lbl_demoProfile_name
            // 
            this.lbl_demoProfile_name.AutoSize = true;
            this.lbl_demoProfile_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demoProfile_name.Location = new System.Drawing.Point(255, 140);
            this.lbl_demoProfile_name.Name = "lbl_demoProfile_name";
            this.lbl_demoProfile_name.Size = new System.Drawing.Size(185, 26);
            this.lbl_demoProfile_name.TabIndex = 9;
            this.lbl_demoProfile_name.Text = "Demo profil name";
            // 
            // lstBx_demoProfile
            // 
            this.lstBx_demoProfile.FormattingEnabled = true;
            this.lstBx_demoProfile.Location = new System.Drawing.Point(260, 183);
            this.lstBx_demoProfile.Name = "lstBx_demoProfile";
            this.lstBx_demoProfile.Size = new System.Drawing.Size(360, 160);
            this.lstBx_demoProfile.TabIndex = 10;
            this.lstBx_demoProfile.SelectedIndexChanged += new System.EventHandler(this.lstBx_demoProfile_SelectedIndexChanged);
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 664);
            this.Controls.Add(this.lstBx_demoProfile);
            this.Controls.Add(this.lbl_demoProfile_name);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_addNewPath);
            this.Controls.Add(this.btn_stopProfile);
            this.Controls.Add(this.btn_startProfile);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_editProfiles);
            this.Controls.Add(this.btn_createNewProfile);
            this.Name = "application";
            this.Text = "betterAutostart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Button btn_addNewPath;

        private System.Windows.Forms.Button btn_startProfile;
        private System.Windows.Forms.Button btn_stopProfile;
        private System.Windows.Forms.ListView listView1;

        #endregion

        private System.Windows.Forms.Button btn_createNewProfile;
        private System.Windows.Forms.Button btn_editProfiles;
        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_demoProfile_name;
        private System.Windows.Forms.ListBox lstBx_demoProfile;
    }
}


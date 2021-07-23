
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
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_createNewProfile = new System.Windows.Forms.Button();
            this.btn_editProfiles = new System.Windows.Forms.Button();
            this.btn_settings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_createNewProfile
            // 
            this.btn_createNewProfile.Location = new System.Drawing.Point(12, 606);
            this.btn_createNewProfile.Name = "btn_createNewProfile";
            this.btn_createNewProfile.Size = new System.Drawing.Size(398, 46);
            this.btn_createNewProfile.TabIndex = 0;
            this.btn_createNewProfile.Text = "Profil Erstellen";
            this.btn_createNewProfile.UseVisualStyleBackColor = true;
            this.btn_createNewProfile.Click += new System.EventHandler(this.btn_createNewProfile_Click);
            // 
            // btn_editProfiles
            // 
            this.btn_editProfiles.Location = new System.Drawing.Point(591, 606);
            this.btn_editProfiles.Name = "btn_editProfiles";
            this.btn_editProfiles.Size = new System.Drawing.Size(398, 46);
            this.btn_editProfiles.TabIndex = 1;
            this.btn_editProfiles.Text = "Profile Editieren";
            this.btn_editProfiles.UseVisualStyleBackColor = true;
            this.btn_editProfiles.Click += new System.EventHandler(this.btn_editProfiles_Click);
            // 
            // btn_settings
            // 
            this.btn_settings.Location = new System.Drawing.Point(891, 12);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(98, 46);
            this.btn_settings.TabIndex = 2;
            this.btn_settings.Text = "Einstellungen";
            this.btn_settings.UseVisualStyleBackColor = true;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 664);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_editProfiles);
            this.Controls.Add(this.btn_createNewProfile);
            this.Name = "application";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_createNewProfile;
        private System.Windows.Forms.Button btn_editProfiles;
        private System.Windows.Forms.Button btn_settings;
    }
}


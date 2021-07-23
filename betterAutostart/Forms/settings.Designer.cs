
namespace betterAutostart
{
    partial class settings
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
            this.drpD_languages = new System.Windows.Forms.ComboBox();
            this.lbl_settings_languages = new System.Windows.Forms.Label();
            this.btn_settings_applySettingsAndClose = new System.Windows.Forms.Button();
            this.btn_settings_applySettings = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // drpD_languages
            // 
            this.drpD_languages.FormattingEnabled = true;
            this.drpD_languages.Location = new System.Drawing.Point(12, 32);
            this.drpD_languages.Name = "drpD_languages";
            this.drpD_languages.Size = new System.Drawing.Size(144, 21);
            this.drpD_languages.TabIndex = 0;
            // 
            // lbl_settings_languages
            // 
            this.lbl_settings_languages.AutoSize = true;
            this.lbl_settings_languages.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_settings_languages.Location = new System.Drawing.Point(9, 9);
            this.lbl_settings_languages.Name = "lbl_settings_languages";
            this.lbl_settings_languages.Size = new System.Drawing.Size(76, 20);
            this.lbl_settings_languages.TabIndex = 1;
            this.lbl_settings_languages.Text = "Sprache";
            // 
            // btn_settings_applySettingsAndClose
            // 
            this.btn_settings_applySettingsAndClose.Location = new System.Drawing.Point(661, 398);
            this.btn_settings_applySettingsAndClose.Name = "btn_settings_applySettingsAndClose";
            this.btn_settings_applySettingsAndClose.Size = new System.Drawing.Size(127, 40);
            this.btn_settings_applySettingsAndClose.TabIndex = 2;
            this.btn_settings_applySettingsAndClose.Text = "Speichern und Schließen";
            this.btn_settings_applySettingsAndClose.UseVisualStyleBackColor = true;
            this.btn_settings_applySettingsAndClose.Click += new System.EventHandler(this.btn_settings_applySettingsClickAndClose);
            // 
            // btn_settings_applySettings
            // 
            this.btn_settings_applySettings.Location = new System.Drawing.Point(528, 398);
            this.btn_settings_applySettings.Name = "btn_settings_applySettings";
            this.btn_settings_applySettings.Size = new System.Drawing.Size(127, 40);
            this.btn_settings_applySettings.TabIndex = 3;
            this.btn_settings_applySettings.Text = "Speichern";
            this.btn_settings_applySettings.UseVisualStyleBackColor = true;
            this.btn_settings_applySettings.Click += new System.EventHandler(this.btn_settings_applySettingsClick);
            // 
            // settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_settings_applySettings);
            this.Controls.Add(this.btn_settings_applySettingsAndClose);
            this.Controls.Add(this.lbl_settings_languages);
            this.Controls.Add(this.drpD_languages);
            this.Name = "settings";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox drpD_languages;
        private System.Windows.Forms.Label lbl_settings_languages;
        private System.Windows.Forms.Button btn_settings_applySettingsAndClose;
        private System.Windows.Forms.Button btn_settings_applySettings;
    }
}
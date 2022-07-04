
namespace betterAutostart.Application
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(application));
            this.pnl_sideMenu = new System.Windows.Forms.Panel();
            this.pnl_navBarHighlight = new System.Windows.Forms.Panel();
            this.btn_sideMenu_settings = new System.Windows.Forms.Button();
            this.btn_sideMenu_srccode = new System.Windows.Forms.Button();
            this.btn_sideMenu_wiki = new System.Windows.Forms.Button();
            this.btn_sideMenu_website = new System.Windows.Forms.Button();
            this.btn_sideMenu_profiles = new System.Windows.Forms.Button();
            this.pnl_sideMenu_logo = new System.Windows.Forms.Panel();
            this.lbl_sideMenuTitle = new System.Windows.Forms.Label();
            this.pnl_childForm = new System.Windows.Forms.Panel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_childFormHeader = new System.Windows.Forms.Label();
            this.pnl_sideMenu.SuspendLayout();
            this.pnl_sideMenu_logo.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_sideMenu
            // 
            this.pnl_sideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.pnl_sideMenu.Controls.Add(this.pnl_navBarHighlight);
            this.pnl_sideMenu.Controls.Add(this.btn_sideMenu_settings);
            this.pnl_sideMenu.Controls.Add(this.btn_sideMenu_srccode);
            this.pnl_sideMenu.Controls.Add(this.btn_sideMenu_wiki);
            this.pnl_sideMenu.Controls.Add(this.btn_sideMenu_website);
            this.pnl_sideMenu.Controls.Add(this.btn_sideMenu_profiles);
            this.pnl_sideMenu.Controls.Add(this.pnl_sideMenu_logo);
            resources.ApplyResources(this.pnl_sideMenu, "pnl_sideMenu");
            this.pnl_sideMenu.Name = "pnl_sideMenu";
            // 
            // pnl_navBarHighlight
            // 
            this.pnl_navBarHighlight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            resources.ApplyResources(this.pnl_navBarHighlight, "pnl_navBarHighlight");
            this.pnl_navBarHighlight.Name = "pnl_navBarHighlight";
            // 
            // btn_sideMenu_settings
            // 
            resources.ApplyResources(this.btn_sideMenu_settings, "btn_sideMenu_settings");
            this.btn_sideMenu_settings.FlatAppearance.BorderSize = 0;
            this.btn_sideMenu_settings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_sideMenu_settings.Name = "btn_sideMenu_settings";
            this.btn_sideMenu_settings.UseVisualStyleBackColor = true;
            this.btn_sideMenu_settings.Click += new System.EventHandler(this.btn_sideMenu_settings_Click);
            // 
            // btn_sideMenu_srccode
            // 
            resources.ApplyResources(this.btn_sideMenu_srccode, "btn_sideMenu_srccode");
            this.btn_sideMenu_srccode.FlatAppearance.BorderSize = 0;
            this.btn_sideMenu_srccode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_sideMenu_srccode.Name = "btn_sideMenu_srccode";
            this.btn_sideMenu_srccode.UseVisualStyleBackColor = true;
            this.btn_sideMenu_srccode.Click += new System.EventHandler(this.btn_sideMenu_srccode_Click);
            // 
            // btn_sideMenu_wiki
            // 
            resources.ApplyResources(this.btn_sideMenu_wiki, "btn_sideMenu_wiki");
            this.btn_sideMenu_wiki.FlatAppearance.BorderSize = 0;
            this.btn_sideMenu_wiki.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_sideMenu_wiki.Name = "btn_sideMenu_wiki";
            this.btn_sideMenu_wiki.UseVisualStyleBackColor = true;
            this.btn_sideMenu_wiki.Click += new System.EventHandler(this.btn_sideMenu_wiki_Click);
            // 
            // btn_sideMenu_website
            // 
            resources.ApplyResources(this.btn_sideMenu_website, "btn_sideMenu_website");
            this.btn_sideMenu_website.FlatAppearance.BorderSize = 0;
            this.btn_sideMenu_website.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_sideMenu_website.Name = "btn_sideMenu_website";
            this.btn_sideMenu_website.UseVisualStyleBackColor = true;
            this.btn_sideMenu_website.Click += new System.EventHandler(this.btn_sideMenu_website_Click);
            // 
            // btn_sideMenu_profiles
            // 
            resources.ApplyResources(this.btn_sideMenu_profiles, "btn_sideMenu_profiles");
            this.btn_sideMenu_profiles.FlatAppearance.BorderSize = 0;
            this.btn_sideMenu_profiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.btn_sideMenu_profiles.Name = "btn_sideMenu_profiles";
            this.btn_sideMenu_profiles.UseVisualStyleBackColor = true;
            this.btn_sideMenu_profiles.Click += new System.EventHandler(this.btn_sideMenu_profiles_Click);
            // 
            // pnl_sideMenu_logo
            // 
            this.pnl_sideMenu_logo.Controls.Add(this.lbl_sideMenuTitle);
            resources.ApplyResources(this.pnl_sideMenu_logo, "pnl_sideMenu_logo");
            this.pnl_sideMenu_logo.Name = "pnl_sideMenu_logo";
            // 
            // lbl_sideMenuTitle
            // 
            resources.ApplyResources(this.lbl_sideMenuTitle, "lbl_sideMenuTitle");
            this.lbl_sideMenuTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.lbl_sideMenuTitle.Name = "lbl_sideMenuTitle";
            // 
            // pnl_childForm
            // 
            this.pnl_childForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.pnl_childForm, "pnl_childForm");
            this.pnl_childForm.Name = "pnl_childForm";
            // 
            // btn_exit
            // 
            this.btn_exit.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btn_exit, "btn_exit");
            this.btn_exit.ForeColor = System.Drawing.Color.White;
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_childFormHeader
            // 
            resources.ApplyResources(this.lbl_childFormHeader, "lbl_childFormHeader");
            this.lbl_childFormHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.lbl_childFormHeader.Name = "lbl_childFormHeader";
            // 
            // application
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_childFormHeader);
            this.Controls.Add(this.pnl_childForm);
            this.Controls.Add(this.pnl_sideMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "application";
            this.Load += new System.EventHandler(this.application_Load);
            this.pnl_sideMenu.ResumeLayout(false);
            this.pnl_sideMenu_logo.ResumeLayout(false);
            this.pnl_sideMenu_logo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnl_sideMenu;
        private System.Windows.Forms.Button btn_sideMenu_profiles;
        private System.Windows.Forms.Panel pnl_sideMenu_logo;
        private System.Windows.Forms.Panel pnl_childForm;
        private System.Windows.Forms.Button btn_sideMenu_settings;
        private System.Windows.Forms.Button btn_sideMenu_srccode;
        private System.Windows.Forms.Button btn_sideMenu_wiki;
        private System.Windows.Forms.Button btn_sideMenu_website;
        private System.Windows.Forms.Panel pnl_navBarHighlight;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_sideMenuTitle;
        private System.Windows.Forms.Label lbl_childFormHeader;
    }
}


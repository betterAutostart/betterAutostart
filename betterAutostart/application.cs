using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using NHotkey.WindowsForms;
using NHotkey;

namespace betterAutostart
{
    public partial class application : Form
    {

        public application()
        {
            #if DEBUG
            Utility.DesignMode = true;
            #endif

            Config.ApplyConfig();
            Config.ApplicationForm = this;
            InitializeComponent();
            this.Text = "BetterAutostart";

            this.UpdateTranslation();
            Region = Region.FromHrgn(Utility.CreateRoundRectRgn(0, 0, Width, Height, 6, 6));
            this.btn_sideMenu_profiles_Click((this.btn_sideMenu_profiles as object), null);
        }


        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case 0x84:
                    base.WndProc(ref m);
                    if ((int)m.Result == 0x1)
                        m.Result = (IntPtr)0x2;
                    return;
            }

            base.WndProc(ref m);
        }

        public void UpdateTranslation() 
        {
            btn_sideMenu_profiles.Text = Utility.GetTranslation("SIDEMENU_PROFILES");
            btn_sideMenu_website.Text = Utility.GetTranslation("SIDEMENU_WEBSITE");
            btn_sideMenu_wiki.Text = Utility.GetTranslation("SIDEMENU_WIKI");
            btn_sideMenu_srccode.Text = Utility.GetTranslation("SIDEMENU_SOURCECODE");

            btn_sideMenu_settings.Text = Utility.GetTranslation("SIDEMENU_SETTINGS");
        }

        private void btn_sideMenu_profiles_Click(object sender, EventArgs e)
        {
            this.HighlightNav(sender);
            this.OpenChildForm(new profilePanel());
            this.lbl_childFormHeader.Text = Utility.GetTranslation("SIDEMENU_PROFILES");
        }

        private void btn_sideMenu_website_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://betterautostart.com");
        }

        private void btn_sideMenu_wiki_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://betterautostart.com/wiki");
        }

        private void btn_sideMenu_srccode_Click(object sender, EventArgs e)
        {
            Utility.OpenWebsite("https://betterautostart.com/sourcecode");
        }

        private void btn_sideMenu_settings_Click(object sender, EventArgs e)
        {
            this.HighlightNav(sender);
            this.OpenChildForm(new settings());
            this.lbl_childFormHeader.Text = Utility.GetTranslation("SIDEMENU_SETTINGS");
        }

        public void OpenAutostartProfilePanel()
        {
            this.btn_sideMenu_profiles_Click((this.btn_sideMenu_profiles as object), null);
        }

        public void HighlightNav(object entry)
        {
            if(entry == null)
            {
                pnl_navBarHighlight.Height = 0;
                pnl_navBarHighlight.Top = 700;
                pnl_navBarHighlight.Left = 0;
            }
            else
            {
                pnl_navBarHighlight.Height = (entry as Button).Height;
                pnl_navBarHighlight.Top = (entry as Button).Top;
                pnl_navBarHighlight.Left = (entry as Button).Left;
            }
        }

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null && activeForm.GetType() == childForm.GetType())
            {
                return;
            }

            if(activeForm != null)
            {
                activeForm.Hide();
            }

            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnl_childForm.Controls.Add(childForm);
            pnl_childForm.Tag = childForm;
            childForm.Show();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void application_Load(object sender, EventArgs e)
        {
            Utility.SetIcon(this);
        }
    }
}

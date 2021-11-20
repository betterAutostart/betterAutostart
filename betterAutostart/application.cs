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
            Config.ApplyConfig();
            Config.ApplicationForm = this;
            InitializeComponent();
            this.Text = "BetterAutostart";

            this.updateTranslation();
            Region = Region.FromHrgn(Utility.CreateRoundRectRgn(0, 0, Width, Height, 12, 12));
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

        public void updateTranslation() 
        {
            btn_sideMenu_profiles.Text = Utility.GetTranslation("SIDEMENU_PROFILES");
            btn_sideMenu_placeholder1.Text = Utility.GetTranslation("PLACEHOLDER");
            btn_sideMenu_placeholder2.Text = Utility.GetTranslation("PLACEHOLDER");
            btn_sideMenu_placeholder3.Text = Utility.GetTranslation("PLACEHOLDER");

            btn_sideMenu_settings.Text = Utility.GetTranslation("SIDEMENU_SETTINGS");
        }

        private void btn_sideMenu_profiles_Click(object sender, EventArgs e)
        {
            this.HighlightNav(sender);
            this.OpenChildForm(new profilePanel());
            this.lbl_childFormHeader.Text = Utility.GetTranslation("SIDEMENU_PROFILES");
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
            Utility.CheckDebugMode();
            Utility.SetIcon(this);
        }
    }
}

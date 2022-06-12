using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using betterAutostart.Common.ProfileClasses;
using Timer = System.Timers;

namespace betterAutostart
{
    public partial class profilePanel : Form
    {
        private List<Panel> panels;
        private Timer.Timer interval;
        public profilePanel()
        {
            InitializeComponent();

            panels = new List<Panel>();
            this.LoadAllProfilesToPanel();
            
            interval = new Timer.Timer();
            this.interval.Elapsed += new ElapsedEventHandler(ElapsedTimerEvent);
            this.interval.Interval = 1000; // 5sec
            this.interval.Start();
        }

        private void btn_editProfile_Click(object sender, EventArgs e)
        {
            int index = this.getIndexFromButtonName(sender);
            Profile accessedProfile = Config.PHandler.GetProfiles()[index];
            this.Close();
            editProfilePanel editPnl = new editProfilePanel(accessedProfile);
        }

        private void btn_startProfile_Click(object sender, EventArgs e)
        {
            int index = this.getIndexFromButtonName(sender);
            Profile accessedProfile = Config.PHandler.GetProfiles()[index];
            accessedProfile.ExecuteAllApps();
        }

        private void btn_stopProfile_Click(object sender, EventArgs e)
        {
            int index = this.getIndexFromButtonName(sender);
            Profile accessedProfile = Config.PHandler.GetProfiles()[index];
            accessedProfile.StopProfile();
        }
        private void btn_addBlankProfile_Click(object sender, EventArgs e)
        {
            Config.PHandler.AddNewProfile();

            List<Profile> profiles = Config.PHandler.GetProfiles();
            this.CreateProfilePanel(profiles.Count()-1, profiles[profiles.Count() - 1].Name,
                profiles[profiles.Count() - 1].GetCustomExecutablesList().ToArray());
        }
        private void lstBx_executables_doubleClick(object sender, EventArgs e)
        {
            int lstBxIndex = this.getIndexFromListBoxName(sender);
            int index = (sender as ListBox).IndexFromPoint((e as MouseEventArgs).Location);
            if (index != ListBox.NoMatches)
            {
                List<Profile> profiles = Config.PHandler.GetProfiles();
                ExecutableApp eApp = profiles[lstBxIndex].GetExecutableByIndex(index);
                Utility.ExploreFile(eApp.Path);
            }
        }

        private int getIndexFromButtonName(object sender)
        {
            return int.Parse((sender as Button).Name.Split('_')[2]);
        }

        private int getIndexFromListBoxName(object sender)
        {
            return int.Parse((sender as ListBox).Name.Split('_')[2]);
        }

        private void LoadAllProfilesToPanel()
        {
            List<Profile> profiles = Config.PHandler.GetProfiles();
            for (int i = 0; i < profiles.Count; i++)
            {
                this.CreateProfilePanel(i, profiles[i].Name, profiles[i].GetCustomExecutablesList().ToArray());
            }
        }
        
        private void UpdateExecutablesRunning()
        {
            for (int i = 0; i < this.panels.Count(); i++)
            {
                string runningExecutableString = 
                    Config.ActiveLanguage.Strings.ProfilePRunning + 
                    ": " + 
                    Config.PHandler.GetProfiles()[i].GetNumberOfRunningExecutables().ToString() + 
                    "/" + 
                    Config.PHandler.GetProfiles()[i].GetExecutableList().Count().ToString();

                Label lbl = (Label) this.panels[i].Controls["lbl_runningExec_" + i];
                lbl.Invoke((Func<Label, string, bool>)SetLabelText, lbl, runningExecutableString);
            }
        }
        
        private bool SetLabelText(Label lbl, string text)
        {
            lbl.Text = text;
            return true;
        }
        
        public void ElapsedTimerEvent(object source, ElapsedEventArgs e)
        {
            this.UpdateExecutablesRunning();
        }

        private void CreateProfilePanel(int index, String profileName, String[] executables)
        {
            int fixedLeftOffset = 360;
            int fixedTopOffset = 320;
            int leftOffset = 0;
            int topOffset = 0;

            if ((index % 2) == 0 || ((index-1) % 2) == 0)
            {
                topOffset = ((int)(index / 2)) * fixedTopOffset;
            }

            if(index % 2 != 0)
            {
                leftOffset = fixedLeftOffset;
            }

            Panel pnl_background = new Panel();
            Label lbl_title = new Label();
            Label lbl_runningExec = new Label();
            Button btn_startAll = new Button();
            Button btn_stopAll = new Button();
            Button btn_editProfile = new Button();
            ListBox lstBx_executables = new ListBox();
            

            pnl_background.SuspendLayout();
            this.SuspendLayout();

            

            // BACKGROUND PANEL
            pnl_background.BackColor = Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            pnl_background.Controls.Add(lbl_title);
            pnl_background.Controls.Add(lbl_runningExec);
            pnl_background.Controls.Add(btn_startAll);
            pnl_background.Controls.Add(btn_stopAll);
            pnl_background.Controls.Add(btn_editProfile);
            pnl_background.Controls.Add(lstBx_executables);
            pnl_background.Location = new Point((12 + leftOffset), (36 + topOffset));
            pnl_background.Name = "pnl_main_" + index;
            pnl_background.Size = new Size(335, 299);
            pnl_background.TabIndex = 2;
            this.Controls.Add(pnl_background);


            // TITLE LABLE
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Nirmala UI", 14F, FontStyle.Bold);
            lbl_title.ForeColor = Color.White;
            lbl_title.ImeMode = ImeMode.NoControl;
            lbl_title.Location = new Point(17, 16);
            lbl_title.Name = "lbl_title_" + index;
            lbl_title.Size = new Size(128, 25);
            lbl_title.TabIndex = 0;
            lbl_title.Text = profileName;
            pnl_background.Controls.Add(lbl_title);


            // EXECUTABLES RUNNING LABLE
            lbl_runningExec.AutoSize = true;
            lbl_runningExec.Font = new Font("Nirmala UI", 14F);
            lbl_runningExec.ForeColor = Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            lbl_runningExec.ImeMode = ImeMode.NoControl;
            lbl_runningExec.Location = new Point(112, 263);
            lbl_runningExec.Name = "lbl_runningExec_" + index;
            lbl_runningExec.Size = new Size(74, 25);
            lbl_runningExec.TabIndex = 5;
            lbl_runningExec.Text = "";
            lbl_runningExec.TextAlign = ContentAlignment.MiddleCenter;
            pnl_background.Controls.Add(lbl_runningExec);


            // START ALL BUTTON
            btn_startAll.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            btn_startAll.FlatAppearance.BorderSize = 0;
            btn_startAll.FlatStyle = FlatStyle.Flat;
            btn_startAll.Font = new Font("Nirmala UI", 14F);
            btn_startAll.ForeColor = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            btn_startAll.ImeMode = ImeMode.NoControl;
            btn_startAll.Location = new Point(22, 221);
            btn_startAll.Name = "btn_startAll_" + index;
            btn_startAll.Size = new Size(142, 39);
            btn_startAll.TabIndex = 2;
            btn_startAll.Text = Config.ActiveLanguage.Strings.ProfilePStartProfile;
            btn_startAll.UseVisualStyleBackColor = false;
            btn_startAll.Click += new EventHandler(this.btn_startProfile_Click);
            pnl_background.Controls.Add(btn_startAll);


            // STOP ALL BUTTON
            btn_stopAll.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            btn_stopAll.FlatAppearance.BorderSize = 0;
            btn_stopAll.FlatStyle = FlatStyle.Flat;
            btn_stopAll.Font = new Font("Nirmala UI", 14F);
            btn_stopAll.ForeColor = Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            btn_stopAll.ImeMode = ImeMode.NoControl;
            btn_stopAll.Location = new Point(174, 221);
            btn_stopAll.Name = "btn_stopAll_" + index;
            btn_stopAll.Size = new Size(142, 39);
            btn_stopAll.TabIndex = 3;
            btn_stopAll.Text = Config.ActiveLanguage.Strings.ProfilePStopProfile;
            btn_stopAll.UseVisualStyleBackColor = false;
            btn_stopAll.Click += new EventHandler(this.btn_stopProfile_Click);
            pnl_background.Controls.Add(btn_stopAll);


            // EDIT PROFILE BUTTON
            btn_editProfile.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            btn_editProfile.FlatAppearance.BorderSize = 0;
            btn_editProfile.FlatStyle = FlatStyle.Flat;
            btn_editProfile.Font = new Font("Nirmala UI", 11F);
            btn_editProfile.ForeColor = Color.White;
            btn_editProfile.ImeMode = ImeMode.NoControl;
            btn_editProfile.Location = new Point(225, 12);
            btn_editProfile.Name= "btn_editProfile_" + index;
            btn_editProfile.Size = new Size(91, 29);
            btn_editProfile.TabIndex = 4;
            btn_editProfile.Text = Config.ActiveLanguage.Strings.ProfilePEditProfile;
            btn_editProfile.UseVisualStyleBackColor = false;
            btn_editProfile.Click += new EventHandler(this.btn_editProfile_Click);
            pnl_background.Controls.Add(btn_editProfile);


            // EXECUTABLES LIST BOX
            lstBx_executables.BackColor = Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            lstBx_executables.BorderStyle = BorderStyle.None;
            lstBx_executables.Font = new Font("Nirmala UI", 14F);
            lstBx_executables.ForeColor = Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            lstBx_executables.FormattingEnabled = true;
            lstBx_executables.ItemHeight = 25;
            lstBx_executables.Location = new Point(22, 54);
            lstBx_executables.Name = "lstBx_executables_" + index;
            lstBx_executables.Size = new Size(294, 150);
            lstBx_executables.TabIndex = 1;

            lstBx_executables.Items.AddRange(executables);
            lstBx_executables.DoubleClick += new EventHandler(this.lstBx_executables_doubleClick);
            pnl_background.Controls.Add(lstBx_executables); 


            this.Controls.Add(pnl_background);
            pnl_background.ResumeLayout(false);
            pnl_background.PerformLayout();
            this.ResumeLayout(false);

            panels.Add(pnl_background);

            this.AutoScroll = true;
        }

        private void profilePanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.panels = null;
            this.interval.Stop();
            this.interval.Close();
        }
    }
}
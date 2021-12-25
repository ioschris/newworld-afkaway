using New_World___AFK_Away.Classes;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace New_World___AFK_Away
{
    public partial class Main : Form
    {
        // DLL libraries used to manage hotkeys
        [DllImport("user32.dll")]
        public static extern bool RegisterHotKey(IntPtr hWnd, int id, int fsModifiers, int vlc);
        [DllImport("user32.dll")]
        public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        //Set constant for the hotkey ID
        const int MYACTION_HOTKEY_ID = 1;

        //Constructor
        public Main()
        {
            //Register the hotkey based on the settings within the application
            RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, Properties.Settings.Default.HotkeyInt);
            InitializeComponent();
        }
        
        //Start auto clicker
        public void startClick()
        {
            tmrClick.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        //Stop auto clicker
        public void stopClick()
        {
            tmrClick.Stop();

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            //Resets the iterations so the application does not require a restart
            repeatIterations = 0;
        }

        //Listen for hotkey editing
        public void listenForHotkey()
        {
            tbSettingsHotkey.Text = "...";
            tbSettingsHotkey.Focus();
            tbSettingsHotkey.SelectAll();
        }

        //Class objects
        Game newWorld = new Game();
        Interval interval = new Interval();
        ClickType clickType = new ClickType();

        //Global variables
        int repeatIterations = 0;

        private void Main_Load(object sender, EventArgs e)
        {
            string hotkey = Properties.Settings.Default.Hotkey;

            //Initialize main form
            this.Text = this.Text + $" {Application.ProductVersion}";
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.SelectedIndex = 0;
            lbAboutVersion.Text = lbAboutVersion.Text + Application.ProductVersion;
            tbSettingsHotkey.Text = hotkey;
            btnStart.Text = $"Start ({hotkey})";
            btnStop.Text = $"Stop ({hotkey})";

            rbRepeatUntilStop.Checked = true;

            //Check if New World is running or not and update the UI accordingly
            if (newWorld.checkGameState() == "Running")
            {
                lbStatus.Text = "Running";
                lbStatus.ForeColor = Color.Green;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //Start auto clicker if the interval is greater than zero seconds
            if (numSeconds.Value != 0)
            {
                //Check options and add time for threading
                if (cbType.SelectedIndex == 0 || cbType.SelectedIndex == 1)
                    tmrClick.Interval = interval.convertTimeInterval(numHours.Value, numMinutes.Value, numSeconds.Value);
                else
                    tmrClick.Interval = interval.convertTimeInterval(numHours.Value, numMinutes.Value, (numSeconds.Value + 3));

                tmrClick.Enabled = true;
                startClick();
            }
            else
                MessageBox.Show("Please choose an interval greater than zero seconds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            //Stop auto clicker
            stopClick();
        }

        private void rbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            //Check for repeat options
            if (rbRepeat.Checked)
                numRepeat.Enabled = true;
            else
                numRepeat.Enabled = false;
        }

        private void tmrClick_Tick(object sender, EventArgs e)
        {
            //Check iteration and stop when the value is reached
            int repeatValue = (int)numRepeat.Value;

            if (rbRepeat.Checked)
            {
                repeatIterations++;
                if (repeatValue == repeatIterations)
                    stopClick();
            }

            //Otherwise, run it indefininetly
            clickType.selectedType(cbType.SelectedIndex);
        }

        private void lbSettingsHotkey_MouseClick(object sender, MouseEventArgs e)
        {
            //Enables edit mode for hotkey
            tbSettingsHotkey.Enabled = true;
            listenForHotkey();
        }

        private void tbSettingsHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            //If the hotkey selected is a function key, save the new hotkey
            if (e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F12)
            {
                tbSettingsHotkey.Text = e.KeyCode.ToString();
                tbSettingsHotkey.Enabled = false;

                Properties.Settings.Default.Hotkey = e.KeyCode.ToString();
                Properties.Settings.Default.HotkeyInt = (int)e.KeyCode;
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();

                //Register the new hotkey without restarting the application
                RegisterHotKey(this.Handle, MYACTION_HOTKEY_ID, 0, Properties.Settings.Default.HotkeyInt);
            }
            else
            {
                //Show error when a function key is not chosen
                MessageBox.Show("Please only use function keys as a hot key! (F1-F12)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listenForHotkey();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Check for new hotkey value and update the button text to reflect the changes
            btnStart.Text = $"Start ({Properties.Settings.Default.Hotkey})";
            btnStop.Text = $"Stop ({Properties.Settings.Default.Hotkey})";
        }

        private void btnInstructions_Click(object sender, EventArgs e)
        {
            //Instructions message box
            MessageBox.Show("How To Use:\n\n1.) Choose your time interval.\n2.) Select your click type.\n3.) Select whether you want it to repeat continuously or a specific number of times.\n4.) Click Start or use your hotkey.\n5.) Click back into New World and walk away!", "AFK Away - Instructions", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void llbGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Open source code repo
            Process.Start("https://github.com/ioschris/newworld-afkaway");
        }

        protected override void WndProc(ref Message m)
        {
            //If the hotkey is pressed then perform an action based on which button is enabled
            if (m.Msg == 0x0312 && m.WParam.ToInt32() == MYACTION_HOTKEY_ID)
            {
                if (btnStart.Enabled)
                    btnStart.PerformClick();
                else
                    btnStop.PerformClick();
            }
            base.WndProc(ref m);
        }
    }
}

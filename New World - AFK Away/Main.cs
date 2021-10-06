using New_World___AFK_Away.Classes;
using System;
using System.Configuration;
using System.Drawing;
using System.Windows.Forms;

namespace New_World___AFK_Away
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        public void startClick()
        {
            tmrClick.Start();

            btnStart.Enabled = false;
            btnStop.Enabled = true;
        }

        public void stopClick()
        {
            tmrClick.Stop();

            btnStart.Enabled = true;
            btnStop.Enabled = false;

            i = 0;
        }

        public void listenForHotkey()
        {
            tbSettingsHotkey.Text = "...";
            tbSettingsHotkey.Focus();
            tbSettingsHotkey.SelectAll();
        }

        Game newWorld = new Game();
        Interval interval = new Interval();
        ClickType clickType = new ClickType();

        int i = 0;

        private void Main_Load(object sender, EventArgs e)
        {
            string hotkey = Properties.Settings.Default.Hotkey;

            this.Text = this.Text + $" {Application.ProductVersion}";
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.SelectedIndex = 0;
            lbAboutVersion.Text = lbAboutVersion.Text + Application.ProductVersion;
            tbSettingsHotkey.Text = hotkey;
            btnStart.Text = $"Start ({hotkey})";
            btnStop.Text = $"Stop ({hotkey})";

            rbRepeatUntilStop.Checked = true;

            if (newWorld.checkGameState() == "Running")
            {
                lbStatus.Text = "Running";
                lbStatus.ForeColor = Color.Green;
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (numSeconds.Value != 0)
            {
                tmrClick.Interval = interval.convertTimeInterval(numHours.Value, numMinutes.Value, numSeconds.Value);
                tmrClick.Enabled = true;
                startClick();
            }
            else
                MessageBox.Show("Please choose an interval greater than zero seconds.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopClick();
        }

        private void rbRepeat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRepeat.Checked)
                numRepeat.Enabled = true;
            else
                numRepeat.Enabled = false;
        }

        private void tmrClick_Tick(object sender, EventArgs e)
        {
            int repeatValue = (int)numRepeat.Value;

            if (rbRepeat.Checked)
            {
                i++;
                if (repeatValue == i)
                    stopClick();
            }

            clickType.selectedType(cbType.SelectedIndex);
        }

        private void lbSettingsHotkey_MouseClick(object sender, MouseEventArgs e)
        {
            tbSettingsHotkey.Enabled = true;
            listenForHotkey();
        }

        private void tbSettingsHotkey_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.F1 && e.KeyCode <= Keys.F24)
            {
                tbSettingsHotkey.Text = e.KeyCode.ToString();
                tbSettingsHotkey.Enabled = false;

                Properties.Settings.Default.Hotkey = e.KeyCode.ToString();
                Properties.Settings.Default.Save();
                Properties.Settings.Default.Reload();
            }
            else
            {
                MessageBox.Show("Please only use function keys as a hot key! (F1-F24)", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                listenForHotkey();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnStart.Text = $"Start ({Properties.Settings.Default.Hotkey})";
            btnStop.Text = $"Stop ({Properties.Settings.Default.Hotkey})";
        }
    }
}

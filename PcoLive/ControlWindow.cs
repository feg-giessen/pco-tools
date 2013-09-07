using System;
using System.Linq;
using System.Windows.Forms;

namespace PcoLive
{
    public partial class ControlWindow : Form
    {
        private readonly Screen[] screens;

        private readonly PcoLiveWindow liveWindow;

        private bool liveWindowShown;

        public ControlWindow()
        {
            this.InitializeComponent();

            this.screens = Screen.AllScreens;

            this.cboFenster.Items.Clear();
            this.cboFenster.Items.AddRange(this.screens.Select(s => s.DeviceName).ToArray());

            this.liveWindow = new PcoLiveWindow();
            this.liveWindow.FormBorderStyle = FormBorderStyle.None;
        }

        private void btnLive_Click(object sender, EventArgs e)
        {
            Screen screen = this.screens.FirstOrDefault(s => s.DeviceName == cboFenster.SelectedItem) ?? this.screens.First();

            this.liveWindow.SetPlan(this.txbPlanId.Text);

            this.liveWindow.Left = screen.Bounds.Width;
            this.liveWindow.Top = screen.Bounds.Height;
            this.liveWindow.StartPosition = FormStartPosition.Manual;
            this.liveWindow.Location = screen.Bounds.Location;
            this.liveWindow.WindowState = FormWindowState.Maximized;
            this.liveWindow.Show();

            this.liveWindowShown = true;
        }

        private void btnHide_Click(object sender, EventArgs e)
        {
            if (this.liveWindowShown)
            {
                this.liveWindow.Hide();
                this.liveWindowShown = false;
            }
        }
    }
}

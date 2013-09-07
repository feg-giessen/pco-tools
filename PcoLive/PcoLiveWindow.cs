using System;
using System.Windows.Forms;

namespace PcoLive
{
    public partial class PcoLiveWindow : Form
    {
        public PcoLiveWindow()
        {
            this.InitializeComponent();
        }

        public void SetPlan(string planId)
        {
            int id = Convert.ToInt32(planId);

            string url = string.Format("https://planningcenteronline.com/live/{0}?style=_full_overview", id);
            if (url != this.webBrowser.Url.OriginalString)
            {
                this.webBrowser.Url = new Uri(url);
            }
        }
    }
}

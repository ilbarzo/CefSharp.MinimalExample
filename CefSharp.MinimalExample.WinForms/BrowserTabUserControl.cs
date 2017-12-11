using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CefSharp;
using CefSharp.WinForms;

namespace CefSharp.MinimalExample.WinForms
{
    public partial class BrowserTabUserControl : UserControl
    {
        public BrowserTabUserControl()
        {
            new BrowserTabUserControl("http://www.google.com");
        }
        public BrowserTabUserControl(string url)
        {
            InitializeComponent();

            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);

            var browser = new ChromiumWebBrowser(url)
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(browser);
        }
    }
}

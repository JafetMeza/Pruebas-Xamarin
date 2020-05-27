using BeautifulUI.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace BeautifulUI
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterPages();
        }

        private void RegisterPages()
        {
            Routing.RegisterRoute("sciodesk", typeof(SciodeskPage));
        }
    }
}

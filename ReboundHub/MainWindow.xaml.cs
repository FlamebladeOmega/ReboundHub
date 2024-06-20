using Microsoft.UI.Composition.SystemBackdrops;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace ReboundHub
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
            SystemBackdrop = new MicaBackdrop
            {
                Kind = MicaKind.BaseAlt,
            };

            ExtendsContentIntoTitleBar = true;
            Title = "Rebound Hub";
            this.InitializeComponent();
        }

        private void NavChange(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            var navItemTag = args.InvokedItemContainer.Tag.ToString();
            if (navItemTag.Equals("ControlPanel"))
            {
                ContentFrame.Navigate(typeof(Pages.ControlPanel));
            }
            if (navItemTag.Equals("CrimsonUI"))
            {
                ContentFrame.Navigate(typeof(Pages.CrimsonUI));
            }
            if (navItemTag.Equals("IvirusCommunity"))
            {
                ContentFrame.Navigate(typeof(Pages.IvirusCommunity));
            }
            if (navItemTag.Equals("Rebound11"))
            {
                ContentFrame.Navigate(typeof(Pages.Rebound11));
            }
            if (navItemTag.Equals("UIGallery"))
            {
                ContentFrame.Navigate(typeof(Pages.UIGallery));
            }
        }

    }
}

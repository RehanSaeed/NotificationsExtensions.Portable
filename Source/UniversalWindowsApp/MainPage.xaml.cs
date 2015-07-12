using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using NotificationsExtensions.TileContent;
using Windows.Data.Xml.Dom;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Notifications;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UniversalWindowsApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            var tileContent = TileContentFactory.CreateTileSquare150x150Text01();

            tileContent.TextHeading.Text = "Hello!";
            tileContent.TextBody1.Text = "One";
            tileContent.TextBody2.Text = "Two";
            tileContent.TextBody3.Text = "Three";

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.LoadXml(tileContent.ToString());

            TileUpdater tileUpdater = TileUpdateManager.CreateTileUpdaterForApplication();
            tileUpdater.Update(
                new TileNotification(xmlDocument)
                {
                });
        }
    }
}

namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150ImageAndText02 : TileWide310x150Base, ITileWide310x150ImageAndText02, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150ImageAndText02() : base("TileWide310x150ImageAndText02", "TileWideImageAndText02", 1, 2)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextCaption1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextCaption2
        {
            get
            {
                return base.TextFields[1];
            }
        }
    }
}


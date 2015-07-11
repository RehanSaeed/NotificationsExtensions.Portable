namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150BlockAndText02 : TileWide310x150Base, ITileWide310x150BlockAndText02, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150BlockAndText02() : base("TileWide310x150BlockAndText02", "TileWideBlockAndText02", 0, 6)
        {
        }

        public INotificationContentText TextBlock
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextSubBlock
        {
            get
            {
                return base.TextFields[2];
            }
        }
    }
}


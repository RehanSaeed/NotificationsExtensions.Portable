namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150PeekImage05 : TileWide310x150Base, ITileWide310x150PeekImage05, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150PeekImage05() : base("TileWide310x150PeekImage05", "TileWidePeekImage05", 2, 2)
        {
        }

        public INotificationContentImage ImageMain
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentImage ImageSecondary
        {
            get
            {
                return base.Images[1];
            }
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextHeading
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


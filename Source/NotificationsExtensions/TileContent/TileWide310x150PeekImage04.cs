namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150PeekImage04 : TileWide310x150Base, ITileWide310x150PeekImage04, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150PeekImage04() : base("TileWide310x150PeekImage04", "TileWidePeekImage04", 1, 1)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


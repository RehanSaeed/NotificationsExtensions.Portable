namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150SmallImageAndText05 : TileWide310x150Base, ITileWide310x150SmallImageAndText05, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150SmallImageAndText05() : base("TileWide310x150SmallImageAndText05", "TileWideSmallImageAndText05", 1, 2)
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


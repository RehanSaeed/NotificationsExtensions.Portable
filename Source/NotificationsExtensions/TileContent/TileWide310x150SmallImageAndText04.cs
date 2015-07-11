namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150SmallImageAndText04 : TileWide310x150Base, ITileWide310x150SmallImageAndText04, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150SmallImageAndText04() : base("TileWide310x150SmallImageAndText04", "TileWideSmallImageAndText04", 1, 2)
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


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150ImageAndText01 : TileWide310x150Base, ITileWide310x150ImageAndText01, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150ImageAndText01() : base("TileWide310x150ImageAndText01", "TileWideImageAndText01", 1, 1)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextCaptionWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


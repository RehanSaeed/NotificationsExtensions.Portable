namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150Text03 : TileWide310x150Base, ITileWide310x150Text03, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150Text03() : base("TileWide310x150Text03", "TileWideText03", 0, 1)
        {
        }

        public INotificationContentText TextHeadingWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


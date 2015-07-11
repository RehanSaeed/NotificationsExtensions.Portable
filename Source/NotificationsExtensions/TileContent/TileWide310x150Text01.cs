namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150Text01 : TileWide310x150Base, ITileWide310x150Text01, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150Text01() : base("TileWide310x150Text01", "TileWideText01", 0, 5)
        {
        }

        public INotificationContentText TextBody1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextBody2
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextBody3
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextBody4
        {
            get
            {
                return base.TextFields[4];
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


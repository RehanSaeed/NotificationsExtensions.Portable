namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150BlockAndText01 : TileWide310x150Base, ITileWide310x150BlockAndText01, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150BlockAndText01() : base("TileWide310x150BlockAndText01", "TileWideBlockAndText01", 0, 6)
        {
        }

        public INotificationContentText TextBlock
        {
            get
            {
                return base.TextFields[4];
            }
        }

        public INotificationContentText TextBody1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextBody2
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextBody3
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextBody4
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextSubBlock
        {
            get
            {
                return base.TextFields[5];
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150PeekImageAndText02 : TileWide310x150Base, ITileWide310x150PeekImageAndText02, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150PeekImageAndText02() : base("TileWide310x150PeekImageAndText02", "TileWidePeekImageAndText02", 1, 5)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
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

        public INotificationContentText TextBody5
        {
            get
            {
                return base.TextFields[4];
            }
        }
    }
}


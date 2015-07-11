namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310BlockAndText02 : TileSquare310x310Base, ITileSquare310x310BlockAndText02, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310BlockAndText02() : base("TileSquare310x310BlockAndText02", null, 1, 7)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextBlock
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextBody1
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextBody2
        {
            get
            {
                return base.TextFields[4];
            }
        }

        public INotificationContentText TextBody3
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextBody4
        {
            get
            {
                return base.TextFields[6];
            }
        }

        public INotificationContentText TextHeading1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextHeading2
        {
            get
            {
                return base.TextFields[2];
            }
        }
    }
}


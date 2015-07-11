namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310Text01 : TileSquare310x310Base, ITileSquare310x310Text01, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310Text01() : base("TileSquare310x310Text01", null, 0, 10)
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

        public INotificationContentText TextBody5
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextBody6
        {
            get
            {
                return base.TextFields[6];
            }
        }

        public INotificationContentText TextBody7
        {
            get
            {
                return base.TextFields[7];
            }
        }

        public INotificationContentText TextBody8
        {
            get
            {
                return base.TextFields[8];
            }
        }

        public INotificationContentText TextBody9
        {
            get
            {
                return base.TextFields[9];
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


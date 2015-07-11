namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310BlockAndText01 : TileSquare310x310Base, ITileSquare310x310BlockAndText01, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310BlockAndText01() : base("TileSquare310x310BlockAndText01", null, 0, 9)
        {
        }

        public INotificationContentText TextBlock
        {
            get
            {
                return base.TextFields[7];
            }
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

        public INotificationContentText TextHeadingWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextSubBlock
        {
            get
            {
                return base.TextFields[8];
            }
        }
    }
}


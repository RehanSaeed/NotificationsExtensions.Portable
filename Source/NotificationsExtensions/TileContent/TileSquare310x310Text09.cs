namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310Text09 : TileSquare310x310Base, ITileSquare310x310Text09, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310Text09() : base("TileSquare310x310Text09", null, 0, 5)
        {
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

        public INotificationContentText TextHeadingWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


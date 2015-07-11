namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310TextList03 : TileSquare310x310Base, ITileSquare310x310TextList03, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310TextList03() : base("TileSquare310x310TextList03", null, 0, 6)
        {
        }

        public INotificationContentText TextHeading1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextHeading2
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextHeading3
        {
            get
            {
                return base.TextFields[4];
            }
        }

        public INotificationContentText TextWrap1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextWrap2
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextWrap3
        {
            get
            {
                return base.TextFields[5];
            }
        }
    }
}


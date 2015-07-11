namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310TextList02 : TileSquare310x310Base, ITileSquare310x310TextList02, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310TextList02() : base("TileSquare310x310TextList02", null, 0, 3)
        {
        }

        public INotificationContentText TextWrap1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextWrap2
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextWrap3
        {
            get
            {
                return base.TextFields[2];
            }
        }
    }
}


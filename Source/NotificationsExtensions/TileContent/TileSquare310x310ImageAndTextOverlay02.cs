namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310ImageAndTextOverlay02 : TileSquare310x310Base, ITileSquare310x310ImageAndTextOverlay02, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310ImageAndTextOverlay02() : base("TileSquare310x310ImageAndTextOverlay02", null, 1, 2)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[1];
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


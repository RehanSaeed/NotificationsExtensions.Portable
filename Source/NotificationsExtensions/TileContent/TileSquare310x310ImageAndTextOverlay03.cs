namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310ImageAndTextOverlay03 : TileSquare310x310Base, ITileSquare310x310ImageAndTextOverlay03, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310ImageAndTextOverlay03() : base("TileSquare310x310ImageAndTextOverlay03", null, 1, 4)
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

        public INotificationContentText TextHeadingWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


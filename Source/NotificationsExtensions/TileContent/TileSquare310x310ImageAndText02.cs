namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310ImageAndText02 : TileSquare310x310Base, ITileSquare310x310ImageAndText02, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310ImageAndText02() : base("TileSquare310x310ImageAndText02", null, 1, 2)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextCaption1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextCaption2
        {
            get
            {
                return base.TextFields[1];
            }
        }
    }
}


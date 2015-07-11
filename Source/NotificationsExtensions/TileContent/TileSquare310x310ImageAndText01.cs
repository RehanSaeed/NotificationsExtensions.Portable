namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310ImageAndText01 : TileSquare310x310Base, ITileSquare310x310ImageAndText01, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310ImageAndText01() : base("TileSquare310x310ImageAndText01", null, 1, 1)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextCaptionWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310ImageCollection : TileSquare310x310Base, ITileSquare310x310ImageCollection, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310ImageCollection() : base("TileSquare310x310ImageCollection", null, 5, 0)
        {
        }

        public INotificationContentImage ImageMain
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentImage ImageSmall1
        {
            get
            {
                return base.Images[1];
            }
        }

        public INotificationContentImage ImageSmall2
        {
            get
            {
                return base.Images[2];
            }
        }

        public INotificationContentImage ImageSmall3
        {
            get
            {
                return base.Images[3];
            }
        }

        public INotificationContentImage ImageSmall4
        {
            get
            {
                return base.Images[4];
            }
        }
    }
}


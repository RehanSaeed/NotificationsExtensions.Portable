namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare71x71IconWithBadge : TileSquare71x71Base, ITileSquare71x71IconWithBadge, ISquare71x71TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare71x71IconWithBadge() : base("TileSquare71x71IconWithBadge", null, 1, 0)
        {
        }

        public INotificationContentImage ImageIcon
        {
            get
            {
                return base.Images[0];
            }
        }
    }
}


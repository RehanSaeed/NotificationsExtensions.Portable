namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare150x150IconWithBadge : TileSquare150x150Base, ITileSquare150x150IconWithBadge, ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare150x150IconWithBadge() : base("TileSquare150x150IconWithBadge", null, 1, 0)
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


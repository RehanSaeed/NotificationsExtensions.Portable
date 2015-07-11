namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare71x71IconWithBadge : ISquare71x71TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage ImageIcon { get; }
    }
}


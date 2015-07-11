namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare150x150IconWithBadge : ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage ImageIcon { get; }
    }
}


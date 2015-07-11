namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310ImageCollection : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage ImageMain { get; }

        INotificationContentImage ImageSmall1 { get; }

        INotificationContentImage ImageSmall2 { get; }

        INotificationContentImage ImageSmall3 { get; }

        INotificationContentImage ImageSmall4 { get; }
    }
}


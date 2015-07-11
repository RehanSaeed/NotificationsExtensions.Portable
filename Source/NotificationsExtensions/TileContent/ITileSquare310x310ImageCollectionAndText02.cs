namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310ImageCollectionAndText02 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage ImageMain { get; }

        INotificationContentImage ImageSmall1 { get; }

        INotificationContentImage ImageSmall2 { get; }

        INotificationContentImage ImageSmall3 { get; }

        INotificationContentImage ImageSmall4 { get; }

        INotificationContentText TextCaption1 { get; }

        INotificationContentText TextCaption2 { get; }
    }
}


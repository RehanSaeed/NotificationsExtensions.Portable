namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310Image : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }
    }
}


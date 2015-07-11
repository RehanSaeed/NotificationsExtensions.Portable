namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare71x71Image : ISquare71x71TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }
    }
}


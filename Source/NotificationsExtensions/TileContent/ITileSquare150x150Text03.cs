namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare150x150Text03 : ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBody1 { get; }

        INotificationContentText TextBody2 { get; }

        INotificationContentText TextBody3 { get; }

        INotificationContentText TextBody4 { get; }
    }
}


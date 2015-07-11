namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150Text06 : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextColumn1Row1 { get; }

        INotificationContentText TextColumn1Row2 { get; }

        INotificationContentText TextColumn1Row3 { get; }

        INotificationContentText TextColumn1Row4 { get; }

        INotificationContentText TextColumn1Row5 { get; }

        INotificationContentText TextColumn2Row1 { get; }

        INotificationContentText TextColumn2Row2 { get; }

        INotificationContentText TextColumn2Row3 { get; }

        INotificationContentText TextColumn2Row4 { get; }

        INotificationContentText TextColumn2Row5 { get; }
    }
}


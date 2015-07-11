namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150Text08 : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextColumn2Row1 { get; }

        INotificationContentText TextColumn2Row2 { get; }

        INotificationContentText TextColumn2Row3 { get; }

        INotificationContentText TextColumn2Row4 { get; }

        INotificationContentText TextColumn2Row5 { get; }

        INotificationContentText TextShortColumn1Row1 { get; }

        INotificationContentText TextShortColumn1Row2 { get; }

        INotificationContentText TextShortColumn1Row3 { get; }

        INotificationContentText TextShortColumn1Row4 { get; }

        INotificationContentText TextShortColumn1Row5 { get; }
    }
}


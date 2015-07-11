namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileWide310x150ImageCollection : IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentImage ImageMain { get; }

        INotificationContentImage ImageSmallColumn1Row1 { get; }

        INotificationContentImage ImageSmallColumn1Row2 { get; }

        INotificationContentImage ImageSmallColumn2Row1 { get; }

        INotificationContentImage ImageSmallColumn2Row2 { get; }
    }
}


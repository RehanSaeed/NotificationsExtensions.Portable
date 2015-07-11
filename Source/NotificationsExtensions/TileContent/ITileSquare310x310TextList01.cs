namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    

        public interface ITileSquare310x310TextList01 : ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        INotificationContentText TextBodyGroup1Field1 { get; }

        INotificationContentText TextBodyGroup1Field2 { get; }

        INotificationContentText TextBodyGroup2Field1 { get; }

        INotificationContentText TextBodyGroup2Field2 { get; }

        INotificationContentText TextBodyGroup3Field1 { get; }

        INotificationContentText TextBodyGroup3Field2 { get; }

        INotificationContentText TextHeading1 { get; }

        INotificationContentText TextHeading2 { get; }

        INotificationContentText TextHeading3 { get; }
    }
}


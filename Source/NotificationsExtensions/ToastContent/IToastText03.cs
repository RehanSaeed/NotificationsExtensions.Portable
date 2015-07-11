namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

        public interface IToastText03 : IToastNotificationContent, INotificationContent
    {
        INotificationContentText TextBody { get; }

        INotificationContentText TextHeadingWrap { get; }
    }
}


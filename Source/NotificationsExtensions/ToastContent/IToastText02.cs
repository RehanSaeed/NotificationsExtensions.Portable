namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

        public interface IToastText02 : IToastNotificationContent, INotificationContent
    {
        INotificationContentText TextBodyWrap { get; }

        INotificationContentText TextHeading { get; }
    }
}


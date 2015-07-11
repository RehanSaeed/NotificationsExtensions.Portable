namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

        public interface IToastText01 : IToastNotificationContent, INotificationContent
    {
        INotificationContentText TextBodyWrap { get; }
    }
}


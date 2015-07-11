namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

        public interface IToastImageAndText01 : IToastNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextBodyWrap { get; }
    }
}


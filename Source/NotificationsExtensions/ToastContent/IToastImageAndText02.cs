namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

        public interface IToastImageAndText02 : IToastNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextBodyWrap { get; }

        INotificationContentText TextHeading { get; }
    }
}


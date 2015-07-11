namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

        public interface IToastImageAndText03 : IToastNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextBody { get; }

        INotificationContentText TextHeadingWrap { get; }
    }
}


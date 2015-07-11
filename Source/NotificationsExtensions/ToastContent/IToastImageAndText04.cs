namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

        public interface IToastImageAndText04 : IToastNotificationContent, INotificationContent
    {
        INotificationContentImage Image { get; }

        INotificationContentText TextBody1 { get; }

        INotificationContentText TextBody2 { get; }

        INotificationContentText TextHeading { get; }
    }
}


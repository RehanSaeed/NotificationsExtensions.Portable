namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    

    
    public interface IToastText04 : IToastNotificationContent, INotificationContent
    {
        INotificationContentText TextBody1 { get; }

        INotificationContentText TextBody2 { get; }

        INotificationContentText TextHeading { get; }
    }
}


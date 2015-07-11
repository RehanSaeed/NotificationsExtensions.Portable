namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;

    internal class ToastText01 : ToastNotificationBase, IToastText01, IToastNotificationContent, INotificationContent
    {
        public ToastText01() : base("ToastText01", 0, 1)
        {
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


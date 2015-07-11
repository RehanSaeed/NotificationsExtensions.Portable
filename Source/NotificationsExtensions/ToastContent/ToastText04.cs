namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;

    internal class ToastText04 : ToastNotificationBase, IToastText04, IToastNotificationContent, INotificationContent
    {
        public ToastText04() : base("ToastText04", 0, 3)
        {
        }

        public INotificationContentText TextBody1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextBody2
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextHeading
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;

    internal class ToastText02 : ToastNotificationBase, IToastText02, IToastNotificationContent, INotificationContent
    {
        public ToastText02() : base("ToastText02", 0, 2)
        {
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[1];
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


namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;

    internal class ToastText03 : ToastNotificationBase, IToastText03, IToastNotificationContent, INotificationContent
    {
        public ToastText03() : base("ToastText03", 0, 2)
        {
        }

        public INotificationContentText TextBody
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextHeadingWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


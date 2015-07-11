namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;

    internal class ToastImageAndText01 : ToastNotificationBase, IToastImageAndText01, IToastNotificationContent, INotificationContent
    {
        public ToastImageAndText01() : base("ToastImageAndText01", 1, 1)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
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


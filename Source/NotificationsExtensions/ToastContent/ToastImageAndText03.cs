namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;

    internal class ToastImageAndText03 : ToastNotificationBase, IToastImageAndText03, IToastNotificationContent, INotificationContent
    {
        public ToastImageAndText03() : base("ToastImageAndText03", 1, 2)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
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


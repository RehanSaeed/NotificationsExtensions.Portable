namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;

    internal class ToastImageAndText04 : ToastNotificationBase, IToastImageAndText04, IToastNotificationContent, INotificationContent
    {
        public ToastImageAndText04() : base("ToastImageAndText04", 1, 3)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
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


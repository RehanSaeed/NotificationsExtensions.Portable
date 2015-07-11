namespace NotificationsExtensions.ToastContent
{
    using System;
    

    public static class ToastContentFactory 
    {
        public static IToastImageAndText01 CreateToastImageAndText01()
        {
            return new ToastImageAndText01();
        }

        public static IToastImageAndText02 CreateToastImageAndText02()
        {
            return new ToastImageAndText02();
        }

        public static IToastImageAndText03 CreateToastImageAndText03()
        {
            return new ToastImageAndText03();
        }

        public static IToastImageAndText04 CreateToastImageAndText04()
        {
            return new ToastImageAndText04();
        }

        public static IToastText01 CreateToastText01()
        {
            return new ToastText01();
        }

        public static IToastText02 CreateToastText02()
        {
            return new ToastText02();
        }

        public static IToastText03 CreateToastText03()
        {
            return new ToastText03();
        }

        public static IToastText04 CreateToastText04()
        {
            return new ToastText04();
        }
    }
}


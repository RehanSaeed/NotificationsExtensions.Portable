namespace NotificationsExtensions
{
    using System;
    using System.Runtime.InteropServices;
    

        public interface INotificationContentImage
    {
        bool AddImageQuery { get; [param: In] set; }

        string Alt { get; [param: In] set; }

        string Src { get; [param: In] set; }
    }
}


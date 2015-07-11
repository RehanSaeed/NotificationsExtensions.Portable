namespace NotificationsExtensions.ToastContent
{
    using System;
    using System.Runtime.InteropServices;
    

        public interface IAlarmCommands
    {
        string DismissArgument { get; [param: In] set; }

        bool ShowDismissCommand { get; [param: In] set; }

        bool ShowSnoozeCommand { get; [param: In] set; }

        string SnoozeArgument { get; [param: In] set; }
    }
}


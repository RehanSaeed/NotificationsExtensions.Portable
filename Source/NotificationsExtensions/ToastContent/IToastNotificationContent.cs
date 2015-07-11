namespace NotificationsExtensions.ToastContent
{
    using NotificationsExtensions;
    using System;
    using System.Runtime.InteropServices;
    
    

        public interface IToastNotificationContent : INotificationContent
    {
        bool AddImageQuery { get; [param: In] set; }

        IAlarmCommands AlarmCommands { get; }

        IToastAudio Audio { get; }

        string BaseUri { get; [param: In] set; }

        ToastDuration Duration { get; [param: In] set; }

        IIncomingCallCommands IncomingCallCommands { get; }

        string Lang { get; [param: In] set; }

        string Launch { get; [param: In] set; }

        bool StrictValidation { get; [param: In] set; }
    }
}


namespace NotificationsExtensions.ToastContent
{
    using System;
    using System.Runtime.InteropServices;
    

        public interface IIncomingCallCommands
    {
        string DeclineArgument { get; [param: In] set; }

        bool ShowDeclineCommand { get; [param: In] set; }

        bool ShowVideoCommand { get; [param: In] set; }

        bool ShowVoiceCommand { get; [param: In] set; }

        string VideoArgument { get; [param: In] set; }

        string VoiceArgument { get; [param: In] set; }
    }
}


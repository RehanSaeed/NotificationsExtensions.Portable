namespace NotificationsExtensions.ToastContent
{
    using System;
    using System.Runtime.InteropServices;
    

        public interface IToastAudio
    {
        ToastAudioContent Content { get; [param: In] set; }

        bool Loop { get; [param: In] set; }
    }
}


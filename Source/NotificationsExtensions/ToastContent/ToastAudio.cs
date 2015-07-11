namespace NotificationsExtensions.ToastContent
{
    using System;

    internal sealed class ToastAudio : IToastAudio
    {
        private ToastAudioContent m_Content;
        private bool m_Loop;

        internal ToastAudio()
        {
        }

        public ToastAudioContent Content
        {
            get
            {
                return this.m_Content;
            }
            set
            {
                if (!Enum.IsDefined((Type) typeof(ToastAudioContent), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.m_Content = value;
            }
        }

        public bool Loop
        {
            get
            {
                return this.m_Loop;
            }
            set
            {
                this.m_Loop = value;
            }
        }
    }
}


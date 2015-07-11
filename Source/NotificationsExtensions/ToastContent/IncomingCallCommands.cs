namespace NotificationsExtensions.ToastContent
{
    using System;

    internal sealed class IncomingCallCommands : IIncomingCallCommands
    {
        private bool m_Decline;
        private string m_DeclineArgument = string.Empty;
        private bool m_Video;
        private string m_VideoArgument = string.Empty;
        private bool m_Voice;
        private string m_VoiceArgument = string.Empty;

        internal IncomingCallCommands()
        {
        }

        public string DeclineArgument
        {
            get
            {
                return this.m_DeclineArgument;
            }
            set
            {
                this.m_DeclineArgument = value;
            }
        }

        public bool ShowDeclineCommand
        {
            get
            {
                return this.m_Decline;
            }
            set
            {
                this.m_Decline = value;
            }
        }

        public bool ShowVideoCommand
        {
            get
            {
                return this.m_Video;
            }
            set
            {
                this.m_Video = value;
            }
        }

        public bool ShowVoiceCommand
        {
            get
            {
                return this.m_Voice;
            }
            set
            {
                this.m_Voice = value;
            }
        }

        public string VideoArgument
        {
            get
            {
                return this.m_VideoArgument;
            }
            set
            {
                this.m_VideoArgument = value;
            }
        }

        public string VoiceArgument
        {
            get
            {
                return this.m_VoiceArgument;
            }
            set
            {
                this.m_VoiceArgument = value;
            }
        }
    }
}


namespace NotificationsExtensions.ToastContent
{
    using System;

    internal sealed class AlarmCommands : IAlarmCommands
    {
        private bool m_Dismiss;
        private string m_DismissArgument = string.Empty;
        private bool m_Snooze;
        private string m_SnoozeArgument = string.Empty;

        internal AlarmCommands()
        {
        }

        public string DismissArgument
        {
            get
            {
                return this.m_DismissArgument;
            }
            set
            {
                this.m_DismissArgument = value;
            }
        }

        public bool ShowDismissCommand
        {
            get
            {
                return this.m_Dismiss;
            }
            set
            {
                this.m_Dismiss = value;
            }
        }

        public bool ShowSnoozeCommand
        {
            get
            {
                return this.m_Snooze;
            }
            set
            {
                this.m_Snooze = value;
            }
        }

        public string SnoozeArgument
        {
            get
            {
                return this.m_SnoozeArgument;
            }
            set
            {
                this.m_SnoozeArgument = value;
            }
        }
    }
}


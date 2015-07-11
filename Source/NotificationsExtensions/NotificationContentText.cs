namespace NotificationsExtensions
{
    using System;

    internal sealed class NotificationContentText : INotificationContentText
    {
        private string m_Lang;
        private string m_Text;

        internal NotificationContentText()
        {
        }

        public string Lang
        {
            get
            {
                return this.m_Lang;
            }
            set
            {
                this.m_Lang = value;
            }
        }

        public string Text
        {
            get
            {
                return this.m_Text;
            }
            set
            {
                this.m_Text = value;
            }
        }
    }
}


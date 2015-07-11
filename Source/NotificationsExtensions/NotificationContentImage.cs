namespace NotificationsExtensions
{
    using System;

    internal sealed class NotificationContentImage : INotificationContentImage
    {
        private bool? m_AddImageQueryNullable;
        private string m_Alt;
        private string m_Src;

        internal NotificationContentImage()
        {
        }

        public bool AddImageQuery
        {
            get
            {
                return (this.m_AddImageQueryNullable.HasValue && this.m_AddImageQueryNullable.Value);
            }
            set
            {
                this.m_AddImageQueryNullable = new bool?(value);
            }
        }

        public bool? AddImageQueryNullable
        {
            get
            {
                return this.m_AddImageQueryNullable;
            }
            set
            {
                this.m_AddImageQueryNullable = value;
            }
        }

        public string Alt
        {
            get
            {
                return this.m_Alt;
            }
            set
            {
                this.m_Alt = value;
            }
        }

        public string Src
        {
            get
            {
                return this.m_Src;
            }
            set
            {
                this.m_Src = value;
            }
        }
    }
}


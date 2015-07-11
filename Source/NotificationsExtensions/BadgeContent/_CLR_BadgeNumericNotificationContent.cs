namespace NotificationsExtensions.BadgeContent
{
    using NotificationsExtensions;
    using System;
    using System.Runtime.InteropServices;
    using System.Xml.Linq;
    
    internal sealed class BadgeNumericNotificationContent : IBadgeNotificationContent, INotificationContent
    {
        private uint m_Number;

        public BadgeNumericNotificationContent()
        {
        }

        public BadgeNumericNotificationContent([In] uint number)
        {
            this.m_Number = number;
        }

        public string GetContent()
        {
            return string.Format("<badge version='{0}' value='{1}'/>", (object[]) new object[] { ((int) 1), ((uint) this.m_Number) });
        }

        public XDocument GetXml()
        {
            return XDocument.Parse(this.GetContent());
        }

        public override string ToString()
        {
            return this.GetContent();
        }

        public uint Number
        {
            get
            {
                return this.m_Number;
            }
            set
            {
                this.m_Number = value;
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    
    

    internal abstract class TileNotificationBase : NotificationBase
    {
        private TileBranding m_Branding;
        private string m_ContentId;

        public TileNotificationBase(string templateName, string fallbackName, int imageCount, int textCount) : base(templateName, fallbackName, imageCount, textCount)
        {
            this.m_Branding = TileBranding.Logo;
        }

        public TileBranding Branding
        {
            get
            {
                return this.m_Branding;
            }
            set
            {
                if (!Enum.IsDefined((Type) typeof(TileBranding), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.m_Branding = value;
            }
        }

        public string ContentId
        {
            get
            {
                return this.m_ContentId;
            }
            set
            {
                this.m_ContentId = value;
            }
        }
    }
}


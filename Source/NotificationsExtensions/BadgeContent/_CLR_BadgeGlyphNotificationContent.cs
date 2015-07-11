namespace NotificationsExtensions.BadgeContent
{
    using NotificationsExtensions;
    using System;
    using System.Runtime.InteropServices;
    using System.Xml.Linq;
    
    internal sealed class BadgeGlyphNotificationContent : IBadgeNotificationContent, INotificationContent
    {
        private GlyphValue m_Glyph;

        public BadgeGlyphNotificationContent()
        {
            this.m_Glyph = ~GlyphValue.None;
        }

        public BadgeGlyphNotificationContent([In] GlyphValue glyph)
        {
            this.m_Glyph = ~GlyphValue.None;
            this.m_Glyph = glyph;
        }

        public string GetContent()
        {
            if (!Enum.IsDefined((Type) typeof(GlyphValue), this.m_Glyph))
            {
                throw new NotificationContentValidationException("The badge glyph property was left unset.");
            }
            string str = this.m_Glyph.ToString();
            str = string.Format("{0}{1}", (object[]) new object[] { ((char) char.ToLowerInvariant(str[0])), str.Substring(1) });
            return string.Format("<badge version='{0}' value='{1}'/>", (object[]) new object[] { ((int) 1), str });
        }

        public XDocument GetXml()
        {
            XDocument document = XDocument.Parse(this.GetContent());
            return document;
        }

        public override string ToString()
        {
            return this.GetContent();
        }

        public GlyphValue Glyph
        {
            get
            {
                return this.m_Glyph;
            }
            set
            {
                if (!Enum.IsDefined((Type) typeof(GlyphValue), value))
                {
                    throw new ArgumentOutOfRangeException("value");
                }
                this.m_Glyph = value;
            }
        }
    }
}


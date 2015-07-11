namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    using System.Text;

    internal class TileSquare310x310Base : TileNotificationBase
    {
        private bool m_RequireWide310x150Content;
        private IWide310x150TileNotificationContent m_Wide310x150Content;

        public TileSquare310x310Base(string templateName, string fallbackName, int imageCount, int textCount) : base(templateName, null, imageCount, textCount)
        {
            this.m_RequireWide310x150Content = true;
        }

        public override string GetContent()
        {
            if (this.RequireWide310x150Content && (this.Wide310x150Content == null))
            {
                throw new NotificationContentValidationException("Wide310x150 tile content should be included with each large tile. If this behavior is undesired, use the RequireWide310x150Content property.");
            }
            if (((this.Wide310x150Content != null) && this.Wide310x150Content.RequireSquare150x150Content) && (this.Wide310x150Content.Square150x150Content == null))
            {
                throw new NotificationContentValidationException("This tile's wide content requires square content. If this behavior is undesired, use the Wide310x150Content.RequireSquare150x150Content property.");
            }
            StringBuilder builder = new StringBuilder(string.Empty);
            builder.AppendFormat("<visual version='{0}'", (object[]) new object[] { ((int) 2) });
            if (!string.IsNullOrWhiteSpace(base.Lang))
            {
                builder.AppendFormat(" lang='{0}'", (object[]) new object[] { Util.HttpEncode(base.Lang) });
            }
            if (base.Branding != TileBranding.Logo)
            {
                builder.AppendFormat(" branding='{0}'", (object[]) new object[] { base.Branding.ToString().ToLowerInvariant() });
            }
            if (!string.IsNullOrWhiteSpace(base.BaseUri))
            {
                builder.AppendFormat(" baseUri='{0}'", (object[]) new object[] { Util.HttpEncode(base.BaseUri) });
            }
            if (base.AddImageQuery)
            {
                builder.AppendFormat(" addImageQuery='true'", (object[]) new object[0]);
            }
            builder.Append(">");
            StringBuilder builder2 = new StringBuilder(string.Empty);
            builder2.AppendFormat("<tile>{0}", (object[]) new object[] { builder });
            if (this.Wide310x150Content != null)
            {
                IWide310x150TileInternal internal2 = this.Wide310x150Content as IWide310x150TileInternal;
                if (internal2 == null)
                {
                    throw new NotificationContentValidationException("The provided wide tile content class is unsupported.");
                }
                builder2.Append(internal2.SerializeBindings(base.Lang, base.BaseUri, base.Branding, base.AddImageQuery));
            }
            builder2.AppendFormat("<binding template='{0}'", (object[]) new object[] { base.TemplateName });
            if (!string.IsNullOrWhiteSpace(base.FallbackName))
            {
                builder2.AppendFormat(" fallback='{0}'", (object[]) new object[] { base.FallbackName });
            }
            if (!string.IsNullOrWhiteSpace(base.ContentId))
            {
                builder2.AppendFormat(" contentId='{0}'", (object[]) new object[] { base.ContentId.ToLowerInvariant() });
            }
            builder2.AppendFormat(">{0}</binding></visual></tile>", (object[]) new object[] { base.SerializeProperties(base.Lang, base.BaseUri, base.AddImageQuery) });
            return builder2.ToString();
        }

        public bool RequireWide310x150Content
        {
            get
            {
                return this.m_RequireWide310x150Content;
            }
            set
            {
                this.m_RequireWide310x150Content = value;
            }
        }

        public IWide310x150TileNotificationContent Wide310x150Content
        {
            get
            {
                return this.m_Wide310x150Content;
            }
            set
            {
                this.m_Wide310x150Content = value;
            }
        }
    }
}


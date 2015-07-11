namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    using System.Text;

    internal class TileWide310x150Base : TileNotificationBase, IWide310x150TileInternal
    {
        private bool m_RequireSquare150x150Content;
        private ISquare150x150TileNotificationContent m_Square150x150Content;

        public TileWide310x150Base(string templateName, string fallbackName, int imageCount, int textCount) : base(templateName, fallbackName, imageCount, textCount)
        {
            this.m_RequireSquare150x150Content = true;
        }

        public override string GetContent()
        {
            if (this.RequireSquare150x150Content && (this.Square150x150Content == null))
            {
                throw new NotificationContentValidationException("Square150x150 tile content should be included with each wide tile. If this behavior is undesired, use the RequireSquare150x150Content property.");
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
            if (this.Square150x150Content != null)
            {
                ISquare150x150TileInternal internal2 = this.Square150x150Content as ISquare150x150TileInternal;
                if (internal2 == null)
                {
                    throw new NotificationContentValidationException("The provided square tile content class is unsupported.");
                }
                builder2.Append(internal2.SerializeBinding(base.Lang, base.BaseUri, base.Branding, base.AddImageQuery));
            }
            builder2.AppendFormat("<binding template='{0}'", (object[]) new object[] { base.TemplateName });
            if (!string.IsNullOrWhiteSpace(base.FallbackName))
            {
                builder2.AppendFormat(" fallback='{0}'", (object[]) new object[] { base.FallbackName });
            }
            builder2.AppendFormat(">{0}</binding></visual></tile>", (object[]) new object[] { base.SerializeProperties(base.Lang, base.BaseUri, base.AddImageQuery) });
            return builder2.ToString();
        }

        public string SerializeBindings(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery)
        {
            StringBuilder builder = new StringBuilder(string.Empty);
            if (this.Square150x150Content != null)
            {
                ISquare150x150TileInternal internal2 = this.Square150x150Content as ISquare150x150TileInternal;
                if (internal2 == null)
                {
                    throw new NotificationContentValidationException("The provided square tile content class is unsupported.");
                }
                builder.Append(internal2.SerializeBinding(base.Lang, base.BaseUri, base.Branding, base.AddImageQuery));
            }
            builder.AppendFormat("<binding template='{0}'", (object[]) new object[] { base.TemplateName });
            if (!string.IsNullOrWhiteSpace(base.FallbackName))
            {
                builder.AppendFormat(" fallback='{0}'", (object[]) new object[] { base.FallbackName });
            }
            if (!string.IsNullOrWhiteSpace(base.Lang) && !base.Lang.Equals(globalLang))
            {
                builder.AppendFormat(" lang='{0}'", (object[]) new object[] { Util.HttpEncode(base.Lang) });
                globalLang = base.Lang;
            }
            if ((base.Branding != TileBranding.Logo) && (base.Branding != globalBranding))
            {
                builder.AppendFormat(" branding='{0}'", (object[]) new object[] { base.Branding.ToString().ToLowerInvariant() });
            }
            if (!string.IsNullOrWhiteSpace(base.BaseUri) && !base.BaseUri.Equals(globalBaseUri))
            {
                builder.AppendFormat(" baseUri='{0}'", (object[]) new object[] { Util.HttpEncode(base.BaseUri) });
                globalBaseUri = base.BaseUri;
            }
            if (base.AddImageQueryNullable.HasValue)
            {
                bool? addImageQueryNullable = base.AddImageQueryNullable;
                bool flag = globalAddImageQuery;
                if ((addImageQueryNullable.GetValueOrDefault() != flag) || !addImageQueryNullable.HasValue)
                {
                    builder.AppendFormat(" addImageQuery='{0}'", (object[]) new object[] { base.AddImageQuery.ToString().ToLowerInvariant() });
                    globalAddImageQuery = base.AddImageQuery;
                }
            }
            if (!string.IsNullOrWhiteSpace(base.ContentId))
            {
                builder.AppendFormat(" contentId='{0}'", (object[]) new object[] { base.ContentId.ToLowerInvariant() });
            }
            builder.AppendFormat(">{0}</binding>", (object[]) new object[] { base.SerializeProperties(globalLang, globalBaseUri, globalAddImageQuery) });
            return builder.ToString();
        }

        public bool RequireSquare150x150Content
        {
            get
            {
                return this.m_RequireSquare150x150Content;
            }
            set
            {
                this.m_RequireSquare150x150Content = value;
            }
        }

        public ISquare150x150TileNotificationContent Square150x150Content
        {
            get
            {
                return this.m_Square150x150Content;
            }
            set
            {
                this.m_Square150x150Content = value;
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    using System.Text;

    internal class TileSquare71x71Base : TileNotificationBase, ISquare71x71TileInternal
    {
        public TileSquare71x71Base(string templateName, string fallbackName, int imageCount, int textCount) : base(templateName, fallbackName, imageCount, textCount)
        {
        }

        public override string GetContent()
        {
            StringBuilder builder = new StringBuilder(string.Empty);
            builder.AppendFormat("<tile><visual version='{0}'", (object[]) new object[] { ((int) 2) });
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
            builder.Append(this.SerializeBinding(base.Lang, base.BaseUri, base.Branding, base.AddImageQuery));
            builder.Append("</visual></tile>");
            return builder.ToString();
        }

        public string SerializeBinding(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery)
        {
            StringBuilder builder = new StringBuilder(string.Empty);
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
            builder.AppendFormat(">{0}</binding>", (object[]) new object[] { base.SerializeProperties(globalLang, globalBaseUri, globalAddImageQuery) });
            return builder.ToString();
        }
    }
}


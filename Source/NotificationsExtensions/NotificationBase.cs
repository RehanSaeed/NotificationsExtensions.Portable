namespace NotificationsExtensions
{
    using System;
    using System.Text;
    using System.Xml.Linq;
    

    internal abstract class NotificationBase
    {
        private bool? m_AddImageQueryNullable;
        private string m_BaseUri;
        private string m_FallbackName;
        private NotificationContentImage[] m_Images;
        private string m_Lang;
        private bool m_StrictValidation = true;
        private string m_TemplateName;
        private INotificationContentText[] m_TextFields;

        protected NotificationBase(string templateName, string fallbackName, int imageCount, int textCount)
        {
            this.m_TemplateName = templateName;
            this.m_FallbackName = fallbackName;
            this.m_Images = new NotificationContentImage[imageCount];
            for (int i = 0; i < this.m_Images.Length; i++)
            {
                this.m_Images[i] = new NotificationContentImage();
            }
            this.m_TextFields = new INotificationContentText[textCount];
            for (int j = 0; j < this.m_TextFields.Length; j++)
            {
                this.m_TextFields[j] = new NotificationContentText();
            }
        }

        public abstract string GetContent();
        public XDocument GetXml()
        {
            return XDocument.Parse(this.GetContent());
        }

        protected string SerializeProperties(string globalLang, string globalBaseUri, bool globalAddImageQuery)
        {
            globalLang = (globalLang != null) ? globalLang : string.Empty;
            globalBaseUri = string.IsNullOrWhiteSpace(globalBaseUri) ? null : globalBaseUri;
            StringBuilder builder = new StringBuilder(string.Empty);
            for (int i = 0; i < this.m_Images.Length; i++)
            {
                string str;
                string str2;
                if (!string.IsNullOrEmpty(this.m_Images[i].Src))
                {
                    str = Util.HttpEncode(this.m_Images[i].Src);
                    if (string.IsNullOrWhiteSpace(this.m_Images[i].Alt))
                    {
                        goto Label_0143;
                    }
                    str2 = Util.HttpEncode(this.m_Images[i].Alt);
                    if (this.m_Images[i].AddImageQueryNullable.HasValue)
                    {
                        bool? addImageQueryNullable = this.m_Images[i].AddImageQueryNullable;
                        bool flag = globalAddImageQuery;
                        if (!((addImageQueryNullable.GetValueOrDefault() == flag) && addImageQueryNullable.HasValue))
                        {
                            goto Label_00F3;
                        }
                    }
                    builder.AppendFormat("<image id='{0}' src='{1}' alt='{2}'/>", (object[]) new object[] { ((int) (i + 1)), str, str2 });
                }
                continue;
            Label_00F3:;
                builder.AppendFormat("<image addImageQuery='{0}' id='{1}' src='{2}' alt='{3}'/>", (object[]) new object[] { this.m_Images[i].AddImageQuery.ToString().ToLowerInvariant(), ((int) (i + 1)), str, str2 });
                continue;
            Label_0143:
                if (this.m_Images[i].AddImageQueryNullable.HasValue)
                {
                    bool? nullable4 = this.m_Images[i].AddImageQueryNullable;
                    bool flag3 = globalAddImageQuery;
                    if (!((nullable4.GetValueOrDefault() == flag3) && nullable4.HasValue))
                    {
                        goto Label_01AD;
                    }
                }
                builder.AppendFormat("<image id='{0}' src='{1}'/>", (object[]) new object[] { ((int) (i + 1)), str });
                continue;
            Label_01AD:;
                builder.AppendFormat("<image addImageQuery='{0}' id='{1}' src='{2}'/>", (object[]) new object[] { this.m_Images[i].AddImageQuery.ToString().ToLowerInvariant(), ((int) (i + 1)), str });
            }
            for (int j = 0; j < this.m_TextFields.Length; j++)
            {
                if (!string.IsNullOrWhiteSpace(this.m_TextFields[j].Text))
                {
                    string str3 = Util.HttpEncode(this.m_TextFields[j].Text);
                    if (!string.IsNullOrWhiteSpace(this.m_TextFields[j].Lang) && !this.m_TextFields[j].Lang.Equals(globalLang))
                    {
                        string str4 = Util.HttpEncode(this.m_TextFields[j].Lang);
                        builder.AppendFormat("<text id='{0}' lang='{1}'>{2}</text>", (object[]) new object[] { ((int) (j + 1)), str4, str3 });
                    }
                    else
                    {
                        builder.AppendFormat("<text id='{0}'>{1}</text>", (object[]) new object[] { ((int) (j + 1)), str3 });
                    }
                }
            }
            return builder.ToString();
        }

        public override string ToString()
        {
            return this.GetContent();
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

        public string BaseUri
        {
            get
            {
                return this.m_BaseUri;
            }
            set
            {
                if (this.StrictValidation && !string.IsNullOrEmpty(value))
                {
                    Uri uri;
                    try
                    {
                        uri = new Uri(value);
                    }
                    catch (Exception exception)
                    {
                        throw new ArgumentException("Invalid URI. Use a valid URI or turn off StrictValidation", exception);
                    }
                    if (((!uri.Scheme.Equals("http", (StringComparison) StringComparison.OrdinalIgnoreCase) && !uri.Scheme.Equals("https", (StringComparison) StringComparison.OrdinalIgnoreCase)) && !uri.Scheme.Equals("ms-appx", (StringComparison) StringComparison.OrdinalIgnoreCase)) && ((!uri.Scheme.Equals("ms-appdata", (StringComparison) StringComparison.OrdinalIgnoreCase) || !string.IsNullOrEmpty(uri.Authority)) || (!uri.AbsolutePath.StartsWith("/local/") && !uri.AbsolutePath.StartsWith("local/"))))
                    {
                        throw new ArgumentException("The BaseUri must begin with http://, https://, ms-appx:///, or ms-appdata:///local/.", "value");
                    }
                }
                this.m_BaseUri = value;
            }
        }

        public string FallbackName
        {
            get
            {
                return this.m_FallbackName;
            }
        }

        public INotificationContentImage[] Images
        {
            get
            {
                return this.m_Images;
            }
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

        public bool StrictValidation
        {
            get
            {
                return this.m_StrictValidation;
            }
            set
            {
                this.m_StrictValidation = value;
            }
        }

        public string TemplateName
        {
            get
            {
                return this.m_TemplateName;
            }
        }

        public INotificationContentText[] TextFields
        {
            get
            {
                return this.m_TextFields;
            }
        }
    }
}


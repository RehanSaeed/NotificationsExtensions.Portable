namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;
    using System.Runtime.InteropServices;
    
    

        public interface ITileNotificationContent : INotificationContent
    {
        bool AddImageQuery { get; [param: In] set; }

        string BaseUri { get; [param: In] set; }

        TileBranding Branding { get; [param: In] set; }

        string ContentId { get; [param: In] set; }

        string Lang { get; [param: In] set; }

        bool StrictValidation { get; [param: In] set; }
    }
}


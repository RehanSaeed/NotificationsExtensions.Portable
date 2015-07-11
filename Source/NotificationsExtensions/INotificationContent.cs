namespace NotificationsExtensions
{
    using System;
    using System.Xml.Linq;
    
    

        public interface INotificationContent
    {
        string GetContent();
        XDocument GetXml();
    }
}


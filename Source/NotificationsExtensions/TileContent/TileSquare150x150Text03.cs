namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare150x150Text03 : TileSquare150x150Base, ITileSquare150x150Text03, ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare150x150Text03() : base("TileSquare150x150Text03", "TileSquareText03", 0, 4)
        {
        }

        public INotificationContentText TextBody1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextBody2
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextBody3
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextBody4
        {
            get
            {
                return base.TextFields[3];
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare150x150Text02 : TileSquare150x150Base, ITileSquare150x150Text02, ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare150x150Text02() : base("TileSquare150x150Text02", "TileSquareText02", 0, 2)
        {
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextHeading
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare150x150Block : TileSquare150x150Base, ITileSquare150x150Block, ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare150x150Block() : base("TileSquare150x150Block", "TileSquareBlock", 0, 2)
        {
        }

        public INotificationContentText TextBlock
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextSubBlock
        {
            get
            {
                return base.TextFields[1];
            }
        }
    }
}


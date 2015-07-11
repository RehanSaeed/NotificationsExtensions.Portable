namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare150x150PeekImageAndText04 : TileSquare150x150Base, ITileSquare150x150PeekImageAndText04, ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare150x150PeekImageAndText04() : base("TileSquare150x150PeekImageAndText04", "TileSquarePeekImageAndText04", 1, 1)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentText TextBodyWrap
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare150x150Image : TileSquare150x150Base, ITileSquare150x150Image, ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare150x150Image() : base("TileSquare150x150Image", "TileSquareImage", 1, 0)
        {
        }

        public INotificationContentImage Image
        {
            get
            {
                return base.Images[0];
            }
        }
    }
}


namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150ImageCollection : TileWide310x150Base, ITileWide310x150ImageCollection, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150ImageCollection() : base("TileWide310x150ImageCollection", "TileWideImageCollection", 5, 0)
        {
        }

        public INotificationContentImage ImageMain
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentImage ImageSmallColumn1Row1
        {
            get
            {
                return base.Images[1];
            }
        }

        public INotificationContentImage ImageSmallColumn1Row2
        {
            get
            {
                return base.Images[3];
            }
        }

        public INotificationContentImage ImageSmallColumn2Row1
        {
            get
            {
                return base.Images[2];
            }
        }

        public INotificationContentImage ImageSmallColumn2Row2
        {
            get
            {
                return base.Images[4];
            }
        }
    }
}


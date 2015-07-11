namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150PeekImageCollection05 : TileWide310x150Base, ITileWide310x150PeekImageCollection05, ITileWide310x150ImageCollection, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150PeekImageCollection05() : base("TileWide310x150PeekImageCollection05", "TileWidePeekImageCollection05", 6, 2)
        {
        }

        public INotificationContentImage ImageMain
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentImage ImageSecondary
        {
            get
            {
                return base.Images[5];
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


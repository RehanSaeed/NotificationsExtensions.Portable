namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150PeekImageCollection02 : TileWide310x150Base, ITileWide310x150PeekImageCollection02, ITileWide310x150ImageCollection, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150PeekImageCollection02() : base("TileWide310x150PeekImageCollection02", "TileWidePeekImageCollection02", 5, 5)
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

        public INotificationContentText TextBody1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextBody2
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextBody3
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextBody4
        {
            get
            {
                return base.TextFields[4];
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


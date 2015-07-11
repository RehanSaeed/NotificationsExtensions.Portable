namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150Text10 : TileWide310x150Base, ITileWide310x150Text10, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150Text10() : base("TileWide310x150Text10", "TileWideText10", 0, 9)
        {
        }

        public INotificationContentText TextColumn2Row1
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextColumn2Row2
        {
            get
            {
                return base.TextFields[4];
            }
        }

        public INotificationContentText TextColumn2Row3
        {
            get
            {
                return base.TextFields[6];
            }
        }

        public INotificationContentText TextColumn2Row4
        {
            get
            {
                return base.TextFields[8];
            }
        }

        public INotificationContentText TextHeading
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextPrefixColumn1Row1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextPrefixColumn1Row2
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextPrefixColumn1Row3
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextPrefixColumn1Row4
        {
            get
            {
                return base.TextFields[7];
            }
        }
    }
}


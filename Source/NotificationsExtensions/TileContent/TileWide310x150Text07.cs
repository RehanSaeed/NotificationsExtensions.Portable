namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150Text07 : TileWide310x150Base, ITileWide310x150Text07, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150Text07() : base("TileWide310x150Text07", "TileWideText07", 0, 9)
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

        public INotificationContentText TextShortColumn1Row1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextShortColumn1Row2
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextShortColumn1Row3
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextShortColumn1Row4
        {
            get
            {
                return base.TextFields[7];
            }
        }
    }
}


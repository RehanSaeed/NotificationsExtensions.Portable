namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150Text08 : TileWide310x150Base, ITileWide310x150Text08, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150Text08() : base("TileWide310x150Text08", "TileWideText08", 0, 10)
        {
        }

        public INotificationContentText TextColumn2Row1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextColumn2Row2
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextColumn2Row3
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextColumn2Row4
        {
            get
            {
                return base.TextFields[7];
            }
        }

        public INotificationContentText TextColumn2Row5
        {
            get
            {
                return base.TextFields[9];
            }
        }

        public INotificationContentText TextShortColumn1Row1
        {
            get
            {
                return base.TextFields[0];
            }
        }

        public INotificationContentText TextShortColumn1Row2
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextShortColumn1Row3
        {
            get
            {
                return base.TextFields[4];
            }
        }

        public INotificationContentText TextShortColumn1Row4
        {
            get
            {
                return base.TextFields[6];
            }
        }

        public INotificationContentText TextShortColumn1Row5
        {
            get
            {
                return base.TextFields[8];
            }
        }
    }
}


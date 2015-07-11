namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310Text02 : TileSquare310x310Base, ITileSquare310x310Text02, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310Text02() : base("TileSquare310x310Text02", null, 0, 0x13)
        {
        }

        public INotificationContentText TextColumn1Row1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextColumn1Row2
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextColumn1Row3
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextColumn1Row4
        {
            get
            {
                return base.TextFields[7];
            }
        }

        public INotificationContentText TextColumn1Row5
        {
            get
            {
                return base.TextFields[9];
            }
        }

        public INotificationContentText TextColumn1Row6
        {
            get
            {
                return base.TextFields[11];
            }
        }

        public INotificationContentText TextColumn1Row7
        {
            get
            {
                return base.TextFields[13];
            }
        }

        public INotificationContentText TextColumn1Row8
        {
            get
            {
                return base.TextFields[15];
            }
        }

        public INotificationContentText TextColumn1Row9
        {
            get
            {
                return base.TextFields[0x11];
            }
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

        public INotificationContentText TextColumn2Row5
        {
            get
            {
                return base.TextFields[10];
            }
        }

        public INotificationContentText TextColumn2Row6
        {
            get
            {
                return base.TextFields[12];
            }
        }

        public INotificationContentText TextColumn2Row7
        {
            get
            {
                return base.TextFields[14];
            }
        }

        public INotificationContentText TextColumn2Row8
        {
            get
            {
                return base.TextFields[0x10];
            }
        }

        public INotificationContentText TextColumn2Row9
        {
            get
            {
                return base.TextFields[0x12];
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


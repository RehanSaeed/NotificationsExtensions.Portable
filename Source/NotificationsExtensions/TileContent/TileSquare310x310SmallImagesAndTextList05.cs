namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare310x310SmallImagesAndTextList05 : TileSquare310x310Base, ITileSquare310x310SmallImagesAndTextList05, ISquare310x310TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare310x310SmallImagesAndTextList05() : base("TileSquare310x310SmallImagesAndTextList05", null, 3, 7)
        {
        }

        public INotificationContentImage Image1
        {
            get
            {
                return base.Images[0];
            }
        }

        public INotificationContentImage Image2
        {
            get
            {
                return base.Images[1];
            }
        }

        public INotificationContentImage Image3
        {
            get
            {
                return base.Images[2];
            }
        }

        public INotificationContentText TextGroup1Field1
        {
            get
            {
                return base.TextFields[1];
            }
        }

        public INotificationContentText TextGroup1Field2
        {
            get
            {
                return base.TextFields[2];
            }
        }

        public INotificationContentText TextGroup2Field1
        {
            get
            {
                return base.TextFields[3];
            }
        }

        public INotificationContentText TextGroup2Field2
        {
            get
            {
                return base.TextFields[4];
            }
        }

        public INotificationContentText TextGroup3Field1
        {
            get
            {
                return base.TextFields[5];
            }
        }

        public INotificationContentText TextGroup3Field2
        {
            get
            {
                return base.TextFields[6];
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


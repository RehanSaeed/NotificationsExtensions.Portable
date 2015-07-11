﻿namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileWide310x150PeekImageAndText01 : TileWide310x150Base, ITileWide310x150PeekImageAndText01, IWide310x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileWide310x150PeekImageAndText01() : base("TileWide310x150PeekImageAndText01", "TileWidePeekImageAndText01", 1, 1)
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


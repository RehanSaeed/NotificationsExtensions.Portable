﻿namespace NotificationsExtensions.TileContent
{
    using NotificationsExtensions;
    using System;

    internal class TileSquare150x150Text01 : TileSquare150x150Base, ITileSquare150x150Text01, ISquare150x150TileNotificationContent, ITileNotificationContent, INotificationContent
    {
        public TileSquare150x150Text01() : base("TileSquare150x150Text01", "TileSquareText01", 0, 4)
        {
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

        public INotificationContentText TextHeading
        {
            get
            {
                return base.TextFields[0];
            }
        }
    }
}


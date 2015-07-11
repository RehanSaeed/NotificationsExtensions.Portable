namespace NotificationsExtensions.TileContent
{
    using System;

    public interface ISquare150x150TileInternal
    {
        string SerializeBinding(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery);
    }
}


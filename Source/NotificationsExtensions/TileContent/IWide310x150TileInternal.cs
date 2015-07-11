namespace NotificationsExtensions.TileContent
{
    using System;

    public interface IWide310x150TileInternal
    {
        string SerializeBindings(string globalLang, string globalBaseUri, TileBranding globalBranding, bool globalAddImageQuery);
    }
}


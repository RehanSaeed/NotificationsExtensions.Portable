# NotificationsExtensions.Portable

[Portable Class Library (PCL)](http://msdn.microsoft.com/en-us/library/gg597391%28v=vs.110%29.aspx) version of the NotificationsExtensions NuGet Packages. Used to Create Windows 8.1/10 or Windows Phone 8.1/10 Tile, Toast and Badge Notification XML. This package is intended for use, instead of the following NuGet packages:
- [NotificationsExtensions.WinRT](https://www.nuget.org/packages/NotificationsExtensions.WinRT/)
- [NotificationsExtensions.UniversalApps](https://www.nuget.org/packages/NotificationsExtensions.UniversalApps/)

# Tile, Toast and Badge Templates

This project helps to create XML representing Tile, Toast and Badge notifications on the Windows 8.1/10 and Windows Phone 8.1/10 platforms. You can take a look at the [template catalogue](http://msdn.microsoft.com/en-us/library/windows/apps/Hh761491.aspx) to see the types of templates available.

<img alt="Windows 8.1/10 and Windows Phone 8.1/10 Tile Templates"
     border="5"
     src="http://i.msdn.microsoft.com/dynimg/IC718860.png"/>

# Why is this Useful?

It's useful when trying to send notifications from the server side using Azure Mobile Services .NET Backend or some other .NET based push notification. When you want to create notification XML in a standard .NET project and not a WinRT project.

# NuGet

NotificationsExtensions.Portable is available on NuGet. Simply follow the instructions below:

- Click Tools Menu Item in Visual Studio
- Click NuGet Package Manager
- Click Package Manager Console
- Select Your Project in the Package Manager Console
- Execute the following command to install NotificationsExtensions.Portable:

```
PM> Install-Package NotificationsExtensions.Portable
```

# Attribution and Changes Made

All praise goes to the above two projects and the Microsoft developers who built them. The only changes I made to the code was to switch from XmlDocument to XDocument, remove a few WinRT specific references and stick it into a Portable Class Library (PCL).

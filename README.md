# ChitankaSharp
[![NuGet Badge](https://buildstats.info/nuget/ChitankaAPI)](https://www.nuget.org/packages/ChitankaAPI/)

ChitankaSharp is a easy to use wrapper of https://chitanka.info/api

## Example
    var result = CApi.SearchBooks("game of thrones");
    if (result.Books.Length > 0)
    {
        result.Books[0].DownloadAsFile("gameofthrones", CFileType.EPUB);
    }

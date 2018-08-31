# Multiple Nuget versions

This project is a proof of concept that shows how now you can use the same library, in this case newtonsoft, with different versions at the same time if they come from references. Unlike on the classic .NET Framework where this created conflicts with the packages.

![capture](https://raw.githubusercontent.com/AlexHart/NetStandardMultipleNugetVersions/master/Capture.PNG)

As can be seen on the library we have a **.net standard** library that consumer 2 libraries (.net standard too) with different versions of the nuget.

And here you can see the code referencing both libraries even on the same file:

```csharp
using NewLibConsumer;
using OldLibConsumer;
using System;

namespace LocalLibrariesConsumer
{
    public static class Serializer
    {

        /// <summary>
        /// Consume newtonsoft 9.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string OldSerializer(object obj) => OldVersionConsumer.Serialize(obj);

        /// <summary>
        /// Consume newtonsoft 11.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string NewSerializer(object obj) => NewVersionConsumer.Serialize(obj);

    }
}

```

And instead of compilling but failing like on .net framework, here it will compile and work properly as you can check on the unit tests project.

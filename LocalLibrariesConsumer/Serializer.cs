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

using Newtonsoft.Json;
using System;

namespace OldLibConsumer
{
    public static class OldVersionConsumer
    {

        /// <summary>
        /// Serialize an object using newtonsoft 9.0.1
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj) => JsonConvert.SerializeObject(obj);

    }
}

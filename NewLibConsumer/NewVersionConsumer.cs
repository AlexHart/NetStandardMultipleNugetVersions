using Newtonsoft.Json;
using System;

namespace NewLibConsumer
{
    public static class NewVersionConsumer
    {

        /// <summary>
        /// Serialize an object using newtonsoft 11.0.1
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string Serialize(object obj) => JsonConvert.SerializeObject(obj);

    }
}

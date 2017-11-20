using Glav.CacheAdapter.Core.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoStore.Web.Repository
{
    public class InMemoryAdapter
    {
        internal const int INTIME = 3;

        /// <summary>
        /// Get the data object with identifier
        /// </summary>
        /// <param name=”strKey”>identifier of the data</param>
        /// <returns>return the data</returns>
        public static object Get(string strKey)
        {
            var cacheProvider = AppServices.Cache;

            var data = cacheProvider.Get<object>(strKey, DateTime.Now.AddSeconds(INTIME), () => { return null; });

            return data;
        }

        /// <summary>
        /// Set in the cache server the value
        /// </summary>
        /// <typeparam name=”T”>Type of data to Set</typeparam>
        /// <param name=”strKey”>identifier of the data</param>
        /// <param name=”obj”>object data</param>
        /// <param name=”intTimeExpiry”>Time in seconds of Expiry data Defaul:86400 = one day</param>
        /// <returns></returns>
        public static bool Set<T>(string strKey, T obj, int intTimeExpiry = 86400)
        {
            try
            {
                var cacheProvider = AppServices.Cache;

                cacheProvider.Add(strKey, DateTime.Now.AddSeconds(intTimeExpiry), obj, null);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }
}
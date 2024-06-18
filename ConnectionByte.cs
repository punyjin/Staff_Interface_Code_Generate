using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RLCM_Staff_Interface
{
    public static class ConnectionByte
    {
        public static byte[] post(string url, NameValueCollection pair)
        {
            using (WebClient wc = new WebClient())
            {
                return wc.UploadValues(url, pair);
            }
        }
    }
}

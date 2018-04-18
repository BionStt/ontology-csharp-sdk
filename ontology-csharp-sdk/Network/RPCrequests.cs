using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;
using System.Collections.Generic;
using Common.Helpers;

namespace Network
{
    public class RPCrequests
    {

        /// <summary>
        /// Sends RPC request to an RPC node and returns response
        /// </summary>
        /// <param name="method"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public static JObject sendRPCrequest(string method, IList<object> parameters)
        {
            WebResponse RPCResponse = null;
            string jsonRequest = Helpers.jsonRequestBuilder(method, parameters);

            string TEST_NET       = "139.219.111.50";
            string PRIV_NET       = "192.168.99.100";
            string FAKE_NET       = "111.111.111.111";
            string HTTP_REST_PORT = "20334";
            string HTTP_WS_PORT   = "20335";
            string HTTP_JSON_PORT = "20336";

            HttpWebRequest ontRPCRequest = (HttpWebRequest)WebRequest.Create("http://" + TEST_NET + ":" + HTTP_JSON_PORT);

            ontRPCRequest.ContentType = "application/json-rpc";
            ontRPCRequest.Method = "POST";

            byte[] byteArray = Encoding.UTF8.GetBytes(jsonRequest);
            ontRPCRequest.ContentLength = byteArray.Length;

            // Send JSON request
            try
            {
                using (Stream ontRPCRequestStream = ontRPCRequest.GetRequestStream())
                {
                    ontRPCRequestStream.Write(byteArray, 0, byteArray.Length);
                }
            }
            catch (WebException)
            {
                throw;
            }

            //Receive response from RPC node
            try
            {
                using (RPCResponse = ontRPCRequest.GetResponse())
                {
                    using (Stream str = RPCResponse.GetResponseStream())
                    {
                        using (StreamReader sr = new StreamReader(str))
                        {

                            JObject response = JsonConvert.DeserializeObject<JObject>(sr.ReadToEnd());
                            return response;

                        }
                    }
                }
            }
            catch (WebException)
            {
                throw;
            }

        }
    }
}



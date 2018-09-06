using System;
using System.Collections.Generic;
using System.Text;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using Newtonsoft.Json;

namespace blackboarApp
{
    public class RestUser {
        HttpClient client;
        Token token { get; set; }
        public async Task<Token> Authorize()
        {
            client = new HttpClient();
            var authData = string.Format("{0}:{1}", Constants.KEY, Constants.SECRET);
            var authHeaderValue = Convert.ToBase64String(Encoding.UTF8.GetBytes(authData));
            var endpoint = new Uri(Constants.HOSTNAME + Constants.AUTH_PATH);
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", authHeaderValue);
            var postData = new List<KeyValuePair<string, string>>();
            postData.Add(new KeyValuePair<string, string>("grant_type", "client_credentials"));
            HttpContent body = new FormUrlEncodedContent(postData);
            HttpResponseMessage response;
            try
            {
                response = await client.PostAsync(endpoint, body);


                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    token = JsonConvert.DeserializeObject<Token>(content);
                }
                else
                {
                    response.EnsureSuccessStatusCode();
                }
            }
            catch
            {

            }
            return token;
        }
    }
}


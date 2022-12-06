using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace PontoAll_2810.Models
{
        public class GeoInfoProvider
    {
        private readonly HttpClient _httpClient;
        //create constructor and call HttpClient
        public GeoInfoProvider()
        {
            _httpClient = new HttpClient()
            {
                Timeout = TimeSpan.FromSeconds(5)
            };
        }
        public async Task<string> GetIPAddress()
        {
            var ipAddress = await _httpClient.GetAsync($"http://ipinfo.io/ip");
            if (ipAddress.IsSuccessStatusCode)
            {
                var json = await ipAddress.Content.ReadAsStringAsync();
                return json.ToString();
            }
            return "";
        }

        public async Task<string> GetGeoInfo()
        {
            //I have already created this function under GeoInfoProvider class.
            var ipAddress = await GetIPAddress();
            // When geting ipaddress, call this function and pass ipaddress as given below
            var response = await _httpClient.GetAsync($"http://api.ipstack.com/" + ipAddress + "?access_key=a688020bdef0d076bc93a04af90234ef");
            if (response.IsSuccessStatusCode)
            {
                var json = await response.Content.ReadAsStringAsync();
                return json;
            }
            return null;
        }
    }
}
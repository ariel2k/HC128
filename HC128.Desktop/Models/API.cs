using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HC128.Desktop.Models
{
    public static class API
    {
        public static async Task<string> GetImageName(string url)
        {
            var client = new HttpClient();
            var path = Path.Combine(url,"/api/Image/Names");
            HttpResponseMessage response = await client.GetAsync(path);
            
        }
    }
}

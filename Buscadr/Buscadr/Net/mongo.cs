using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;
using Windows.Web.Http.Headers;

namespace Buscadr.Net
{
    

   public class Mongo<T>
    {
       const String URL_BASE = "https://api.mongolab.com/api/1/databases/";

       HttpClient client;

       String url;
       String apiKey;

       public Mongo(String apiKey, String dbName, String collectionName) {
           client = new HttpClient();

           this.apiKey= "apiKey="+apiKey;
           url = URL_BASE + dbName + "/collections/" + collectionName + "?" + this.apiKey;
       
       }

       public async void insertDocument(T document)
       {
           JsonSerializerSettings property = new JsonSerializerSettings();
           property.NullValueHandling = NullValueHandling.Ignore;

           String json = JsonConvert.SerializeObject(document,Formatting.None, property);

           HttpStringContent content =new HttpStringContent(json);

           HttpMediaTypeHeaderValue contentType = new HttpMediaTypeHeaderValue("application/json");


           content.Headers.ContentType = contentType;

           await client.PostAsync(new Uri(url), content);




       }

    
    }
}

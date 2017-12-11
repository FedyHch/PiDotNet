
using Data.Infrastructure;
using Service.Pattern;
using System.Collections.Generic;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Data.Models;

namespace Service
{
    public   class TowService :Service<tow> , ITowService
    {
        private static DatabaseFactory Dbf = new DatabaseFactory();
    private static UnitOfWork utw = new UnitOfWork(Dbf);
    public TowService() : base(utw)
        {
        }
        public IEnumerable<tow> afficher()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create
            ("http://localhost:18080/cga-web/pi/tow/");
            request.Method = "GET";
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string content = string.Empty;
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader sr = new StreamReader(stream))
                {
                    content = sr.ReadToEnd();
                }
            }
            var objs = JsonConvert.DeserializeObject<List<tow>>(content);
            List<tow> liste = new List<tow>();
            foreach (tow r in objs)
            {
                tow rec = new tow(r.date_tow,r.status,r.tow_id, r.zone);

                liste.Add(rec);
            }
            return liste;
        }




    }
}

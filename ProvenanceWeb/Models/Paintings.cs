using System;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ProvenanceWeb.Models;
using FirebaseSharp.Portable;

namespace ProvenanceWeb.Models
{
    public class Painting
    {
        public string ID { get; set; }
        public string Artist { get; set; }
        public string ImageSource { get; set; }
        public decimal Price { get; set; }
        public string Title { get; set; }

        public string artist { get { return Artist; } }
        public string imgSrc { get { return ImageSource; } }
        public decimal price { get { return Price; } }
        public string title { get { return Title; } }


        public Painting()
        {

        }

        public Painting(IDataSnapshot data)
        {
            decimal tempPrice = 0m;
            this.ID = data.Key;
            this.Artist = data.Child("artist").Value();
            this.ImageSource = data.Child("imgSrc").Value();

            decimal.TryParse(data.Child("price").Value(), out tempPrice);
            this.Price = tempPrice;
            this.Title = data.Child("title").Value();
        }
    }

}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Webprojekt_1_Bauhandel.Models
{

    public enum Category
    {
        Akkuschrauber, Schlagbohrmaschine, Null
    }
    public enum Art
    {
        Kabel, Akku, Null
    }

    public class Shoparticle
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Art Art { get; set; }
        public Category Category { get; set; }

        public Shoparticle() : this(0, "", "", 0.0m, Art.Null, Category.Null) { }
        public Shoparticle(int id, string name, string description, decimal price, Art art , Category category)
        {
            this.ID = id;
            this.Name = Name;
            this.Price = price;
            this.Description = description;
            this.Art = art;
            this.Category = category;
        }

        // ToString() überschreiben
        public override string ToString()
        {
            return this.Name + " " + this.Price + " " + this.Description + " " +  this.Art + " " + this.Category;
        }
    }
}

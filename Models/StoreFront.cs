using System.Collections.Generic;

namespace Models
{
    public class StoreFront
    {
        public StoreFront() {}

        public string Name {get; set;}
        public string Location {get; set;}

        public List<Inventory> Inventories {get; set;}

        public override string ToString()
        {
            return $"Store Name: {this.Name} \nAddress: {this.Location}";
        }

    }
}
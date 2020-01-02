using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ch14.Code
{
    class Item
    {

        string itemId;

        public string ItemId
        {
            get { return itemId; }
            set { itemId = value; }
        }
        string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        DateTime startDate;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        string hoster;

        public string Hoster
        {
            get { return hoster; }
            set { hoster = value; }
        }

        public Item()
        {

        }
        public Item(string itemId, string itemName, string description, DateTime startDate, DateTime endDate, string hoster)
        {
            this.itemId = itemId;
            this.itemName = itemName;
            this.description = description;
            this.startDate = startDate;
            this.endDate = endDate;
            this.hoster = hoster;
        }
    }
}

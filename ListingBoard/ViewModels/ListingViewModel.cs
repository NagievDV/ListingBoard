using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingBoard.ViewModels
{
    public class ListingViewModel
    {
        public string ListingName { get; set; }
        public string ListingDescription { get; set; }
        public string ListingPrice { get; set; }
        public string Photo { get; set; }
        public string PublicationDate { get; set; }
        public int? CityID { get; set; }
        public int? CategoryID { get; set; }
        public int? TypeID { get; set; }
    }
}

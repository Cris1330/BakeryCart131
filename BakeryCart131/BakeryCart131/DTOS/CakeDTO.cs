using BakeryCart131.Models;

namespace BakeryCart131.DTOS
{
    public class CakeDTO
    {

        public string CakeId { get; set; }

        public string Type { get; set; }

        public string Size { get; set; }

        public string Form { get; set; }

        public string Flavor { get; set; }

        public Role Role { get; set; }

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multi_LocationsWin
{
    public class LocationModel
    {
        public int Id { get; set; }
        public DateTime DateLocation { get; set; }
        public DateTime? DatePaiement { get; set; }
        public decimal MontantMensuel { get; set; }
        public int? NombrePaiment { get; set; }
        public int IDVehicule { get; set; }
        public int IDClient { get; set; }
        public int IDTerme { get; set; }
        public decimal? KmInitial { get; set; }
        public decimal? KmFinal { get; set; }
    }
}

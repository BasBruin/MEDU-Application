using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MEDU_Application
{
    class Patiënt
    {
        public int Id { get; }
        public string Voornaam { get; }
        public string Achternaam { get; }
        public int Leeftijd { get; }
        public string Email { get; }
        public string Telefoonnummer { get; }
        public int Dokter_id { get; }
        public string Bsn { get; }
        public List<Patiënt> Allergiën = new List<Patiënt>();


    }
}

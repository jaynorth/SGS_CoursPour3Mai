using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Business.Model
{
    public class Etudiant
    {

        public Etudiant(string _nom, string _prenom, string _rue, string _num, string _npa, string _localite)
        {
            Nom = _nom;
            Prenom = _prenom;
            Rue = _rue;
            RueNum = _num;
            Npa = _npa;
            Localite = _localite;

        }

        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Rue { get; set; }
        public string RueNum { get; set; }
        public string Npa { get; set; }
        public string Localite { get; set; }


    }
}

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Presentation.ViewModel
{
    public class EtudiantListViewModel
    {
        private ObservableCollection<Etudiant> _etudiants;

        public EtudiantListViewModel()
        {
            _etudiants = new ObservableCollection<Etudiant>();
            _etudiants.Add(new Etudiant("Holmes", "Sherlock", "Baker Street", "121b", "1000", "London"));
            _etudiants.Add(new Etudiant("Newton", "Isaac", "Gravity Street", "12345", "1045", "Bagdad"));


     
        }

        public ObservableCollection<Etudiant> Etudiants
        {
            get { return _etudiants; }
            set
            {
                _etudiants.Clear();
                _etudiants = value;

            }

    }
}

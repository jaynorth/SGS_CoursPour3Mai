﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sgs.Persistance.EntityModel
{
    public partial class tbEtudiant
    {

        public override string ToString()
        {
            return string.Format("{0} {1}", Prenom, Nom);
        }
    }
}


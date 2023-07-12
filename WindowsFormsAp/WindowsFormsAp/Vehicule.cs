using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAp
{
    class Vehicule
    {
        public string nom;
        public int sexe;
        /// <summary>
        /// mon utilitii
        /// </summary>
        /// <param name="_nom"> 2 prm</param>
        /// <param name="_sexe"></param>
        public Vehicule(string _nom, int _sexe)
        {
            this.nom = _nom;
            this.sexe = _sexe;
        }
    }
}

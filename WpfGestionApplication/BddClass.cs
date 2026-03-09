using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfGestionApplication
{
    // ===== Table Agents Techniques =====
    public class AgentTechnique
    {
        public int Token { get; set; }        // PK NOT NULL
        public string Nom { get; set; }       // VARCHAR(20) NOT NULL
        public string Prenom { get; set; }    // VARCHAR(20) NOT NULL
        public string MDP { get; set; }       // VARCHAR(20) NOT NULL
    }

    // ===== Table Operations =====
    public class Operation
    {
        public int ID { get; set; }           // PK NOT NULL
        public int Mission { get; set; }      // NOT NULL
        public string Libelle { get; set; }   // VARCHAR(50) NOT NULL
        public string Contenu { get; set; }   // VARCHAR(200) NOT NULL
        public int Materiel { get; set; }     // INT. ID du materiel utiliser
        
        // Date x3 EXACTEMENT
        public DateTime DateCreation { get; set; }   // NOT NULL
        public DateTime DateLimite { get; set; }   // NOT NULL
        public DateTime DateFin { get; set; }   // NOT NULL

        public bool Etat { get; set; }        // BOOLEAN
        public string Details { get; set; }   // VARCHAR(100)
    }

    // ===== Table Missions =====
    public class Mission
    {
        public int ID { get; set; }           // PK NOT NULL
        public string Nom { get; set; } //Le nom dla missioon le sang
        public string Agent { get; set; }        // NOT NULL

        // Date x3 EXACTEMENT
        public DateTime DateCreation { get; set; }
        public DateTime DateLimite { get; set; }
        public DateTime DateFin { get; set; }
        public int Prioriter { get; set; }         // INT
        public bool Validite { get; set; }    // NOT NULL
    }

    // ===== Table Materiels =====
    public class Materiel
    {
        public int ID { get; set; }           // PK
        public string Batiment { get; set; }  // VARCHAR(50)
        public string Type { get; set; }      // VARCHAR(50)
        public int Numero { get; set; }      
    }

    // ===== Table Batiments =====
    public class Batiment
    {
        public int ID { get; set; }           // PK
        public string Nom { get; set; }       // VARCHAR(50)
        public string Description { get; set; } // VARCHAR(100)
    }
}

//DATE LIMITE,  PRIORITER MISSION ILS VAS FAIRE TT LES MISSIONS PR UNE OPERATION?
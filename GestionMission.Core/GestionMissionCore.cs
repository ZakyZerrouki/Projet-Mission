using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionMission.Core
{

    public class AgentTechnique
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Service { get; set; }

        public AgentTechnique(string nom, string prenom, string service)
        {
            Nom = nom;
            Prenom = prenom;
            Service = service;
        }
    }


    public class Materiel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Type { get; set; }
        public string Commentaire { get; set; }
        public string Localisation { get; set; }
        public string QrCode { get; set; }

        public Materiel(int id, string nom, string type, string localisation, string qrCode)
        {
            Id = id;
            Nom = nom;
            Type = type;
            Localisation = localisation;
            QrCode = qrCode;
        }
    }

    public class Operation
    {
        public int Id { get; set; }
        public string Libelle { get; set; }
        public string Description { get; set; }
        public bool Obligatoire { get; set; }

        public Operation(int id, string libelle, string description, bool obligatoire)
        {
            Id = id;
            Libelle = libelle;
            Description = description;
            Obligatoire = obligatoire;
        }
    }

    public class Mission
    {
        public int Id { get; set; }
        public DateTime DateCreation { get; set; }
        public DateTime DatePrevue { get; set; }
        public int AgentTechniqueId { get; set; }
        public string Statut { get; set; }

        public Mission(int id, DateTime dateCreation, DateTime datePrevue, int agentTechniqueId, string statut)
        {
            Id = id;
            DateCreation = dateCreation;
            DatePrevue = datePrevue;
            AgentTechniqueId = agentTechniqueId;
            Statut = statut;
        }
    }


    public class MissionMateriel
    {
        public int MissionId { get; set; }
        public int MaterielId { get; set; }

        public MissionMateriel(int missionId, int materielId)
        {
            MissionId = missionId;
            MaterielId = materielId;

        }
    }


    public class MissionOperation
    {
        public int MissionId { get; set; }
        public int OperationId { get; set; }
        public int Ordre { get; set; }

        public MissionOperation(int missionId, int operationId, int ordre)
        {
            MissionId = missionId;
            OperationId = operationId;
            Ordre = ordre;
        }
    }

    public class HistoriqueControle
    {
        public int Id { get; set; }
        public int MissionId { get; set; }
        public int MaterielId { get; set; }
        public DateTime DateControle { get; set; }
        public bool Conforme { get; set; }
        public string Commentaire { get; set; }

        public HistoriqueControle(int id, int missionId, int materielId, DateTime dateControle, bool conforme, string commentaire)
        {
            Id = id;
            MissionId = missionId;
            MaterielId = materielId;
            DateControle = dateControle;
            Conforme = conforme;
            Commentaire = commentaire;
        }
    }





}

using System;
using System.Collections.Generic;
using TESTHISTORIQUE;

var agents = new List<AgentTechnique>
{
    new AgentTechnique { Token = 1001, Nom = "Zerrouki", Prenom = "Anis",   MDP = "anis123" },
    new AgentTechnique { Token = 1002, Nom = "Dupont",  Prenom = "Lucas",  MDP = "lucas123" },
    new AgentTechnique { Token = 1003, Nom = "Martin",  Prenom = "Sarah",  MDP = "sarah123" },
};

var batiments = new List<Batiment>
{
    new Batiment { ID = 1, Nom = "Bâtiment A", Description = "Accueil / Administration" },
    new Batiment { ID = 2, Nom = "Bâtiment B", Description = "Atelier technique / Maintenance" },
    new Batiment { ID = 3, Nom = "Bâtiment C", Description = "Stockage / Local sécurité" },
};

var materiels = new List<Materiel>
{
    new Materiel { ID = 1, Batiment = "Bâtiment A", Type = "Extincteur",              Numero = 101 },
    new Materiel { ID = 2, Batiment = "Bâtiment B", Type = "Tableau électrique",      Numero = 202 },
    new Materiel { ID = 3, Batiment = "Bâtiment C", Type = "Caméra surveillance",     Numero = 303 },
    new Materiel { ID = 4, Batiment = "Bâtiment A", Type = "Éclairage de secours",    Numero = 104 },
    new Materiel { ID = 5, Batiment = "Bâtiment B", Type = "Générateur de secours",   Numero = 205 },
    new Materiel { ID = 6, Batiment = "Bâtiment C", Type = "Lecteur badge d'accès",   Numero = 306 },
};

var missions = new List<Mission>
{
    // Mission 1 (Janvier) -> Agent 1001
    new Mission
    {
        ID = 1,
        Agent = 1001,
        DateCreation = new DateTime(2025, 1, 10),
        DateLimite   = new DateTime(2025, 1, 20),
        DateFin      = new DateTime(2025, 1, 18),
        Validite = true
    },

    // Mission 2 (Février) -> Agent 1002
    new Mission
    {
        ID = 2,
        Agent = 1002,
        DateCreation = new DateTime(2025, 2, 12),
        DateLimite   = new DateTime(2025, 2, 22),
        DateFin      = new DateTime(2025, 2, 25),
        Validite = false // en retard / pas validée
    },

    // Mission 3 (Mars) -> Agent 1003
    new Mission
    {
        ID = 3,
        Agent = 1003,
        DateCreation = new DateTime(2025, 3, 15),
        DateLimite   = new DateTime(2025, 3, 28),
        DateFin      = new DateTime(2025, 3, 27),
        Validite = true
    },
};

var operations = new List<Operation>
{
    // ===== JANVIER : Mission 1 =====
    new Operation {
        ID = 1, Mission = 1, Materiel = 1,
        Libelle = "Vérifier extincteur",
        Contenu = "Contrôle pression, goupille, date de validité",
        DateCreation = new DateTime(2025, 1, 10),
        DateLimite   = new DateTime(2025, 1, 15),
        DateFin      = new DateTime(2025, 1, 14),
        Etat = true,
        Details = "Conforme",
        Prioriter = 1
    },
    new Operation {
        ID = 2, Mission = 1, Materiel = 4,
        Libelle = "Inspection éclairage de secours",
        Contenu = "Test autonomie 1 min + test voyant",
        DateCreation = new DateTime(2025, 1, 10),
        DateLimite   = new DateTime(2025, 1, 16),
        DateFin      = new DateTime(2025, 1, 16),
        Etat = true,
        Details = "OK - test validé",
        Prioriter = 2
    },
    new Operation {
        ID = 3, Mission = 1, Materiel = 3,
        Libelle = "Test caméras (check rapide)",
        Contenu = "Contrôle flux vidéo + angle caméra",
        DateCreation = new DateTime(2025, 1, 10),
        DateLimite   = new DateTime(2025, 1, 18),
        DateFin      = new DateTime(2025, 1, 17),
        Etat = true,
        Details = "Angle ajusté",
        Prioriter = 2
    },

    // ===== FEVRIER : Mission 2 =====
    new Operation {
        ID = 4, Mission = 2, Materiel = 1,
        Libelle = "Maintenance extincteur",
        Contenu = "Nettoyage + contrôle joint + étiquette",
        DateCreation = new DateTime(2025, 2, 12),
        DateLimite   = new DateTime(2025, 2, 18),
        DateFin      = new DateTime(2025, 2, 20),
        Etat = false,
        Details = '\"' + "Retard - joint à remplacer" + '\"',
        Prioriter = 3
    },
    new Operation {
        ID = 5, Mission = 2, Materiel = 2,
        Libelle = "Vérification tableau électrique",
        Contenu = "Contrôle disjoncteurs + serrage borniers",
        DateCreation = new DateTime(2025, 2, 12),
        DateLimite   = new DateTime(2025, 2, 17),
        DateFin      = new DateTime(2025, 2, 17),
        Etat = true,
        Details = "Conforme",
        Prioriter = 1
    },
    new Operation {
        ID = 6, Mission = 2, Materiel = 3,
        Libelle = "Test caméras sécurité",
        Contenu = "Contrôle enregistrement + vision nocturne",
        DateCreation = new DateTime(2025, 2, 12),
        DateLimite   = new DateTime(2025, 2, 19),
        DateFin      = new DateTime(2025, 2, 18),
        Etat = true,
        Details = "Caméra 303 recalibrée",
        Prioriter = 2
    },

    // ===== MARS : Mission 3 =====
    new Operation {
        ID = 7, Mission = 3, Materiel = 5,
        Libelle = "Test générateur de secours",
        Contenu = "Simulation coupure + mesure tension",
        DateCreation = new DateTime(2025, 3, 15),
        DateLimite   = new DateTime(2025, 3, 23),
        DateFin      = new DateTime(2025, 3, 25),
        Etat = false,
        Details = "Batterie faible - remplacement prévu",
        Prioriter = 1
    },
    new Operation {
        ID = 8, Mission = 3, Materiel = 6,
        Libelle = "Contrôle badge accès",
        Contenu = "Test lecteurs + désactivation badges obsolètes",
        DateCreation = new DateTime(2025, 3, 15),
        DateLimite   = new DateTime(2025, 3, 24),
        DateFin      = new DateTime(2025, 3, 24),
        Etat = true,
        Details = "2 badges désactivés",
        Prioriter = 2
    },
    new Operation {
        ID = 9, Mission = 3, Materiel = 4,
        Libelle = "Test éclairage secours (batterie)",
        Contenu = "Test autonomie 5 min + contrôle charge",
        DateCreation = new DateTime(2025, 3, 15),
        DateLimite   = new DateTime(2025, 3, 26),
        DateFin      = new DateTime(2025, 3, 26),
        Etat = true,
        Details = "Autonomie OK",
        Prioriter = 3
    }
};

static void AfficherTout(
    List<Mission> missions,
    List<Operation> operations,
    List<Materiel> materiels)
{
    foreach (var m in missions.OrderBy(x => x.ID))
    {
        Console.WriteLine($"===== Mission {m.ID} (Agent={m.Agent}) =====");
        Console.WriteLine($"Créée: {m.DateCreation:yyyy-MM-dd} | Limite: {m.DateLimite:yyyy-MM-dd} | Fin: {m.DateFin:yyyy-MM-dd} | Valide: {m.Validite}");
        Console.WriteLine();

        var opsMission = operations
            .Where(o => o.Mission == m.ID)
            .OrderBy(o => o.ID)
            .ToList();

        Console.WriteLine("  -- Opérations --");
        if (opsMission.Count == 0)
        {
            Console.WriteLine("  (Aucune)");
        }
        else
        {
            foreach (var o in opsMission)
            {
                Console.WriteLine($"  • Op {o.ID} | Matériel={o.Materiel} | {o.Libelle} | Etat={o.Etat} | Prio={o.Prioriter}");
                Console.WriteLine($"    Contenu: {o.Contenu}");
                Console.WriteLine($"    Dates: C={o.DateCreation:yyyy-MM-dd} L={o.DateLimite:yyyy-MM-dd} F={o.DateFin:yyyy-MM-dd}");
                if (!string.IsNullOrWhiteSpace(o.Details))
                    Console.WriteLine($"    Détails: {o.Details}");
            }
        }

        Console.WriteLine();

        var idsMateriels = opsMission
            .Select(o => o.Materiel)
            .Distinct()
            .ToList();

        var matsMission = materiels
            .Where(mat => idsMateriels.Contains(mat.ID))
            .OrderBy(mat => mat.ID)
            .ToList();

        Console.WriteLine("  -- Matériels utilisés --");
        if (matsMission.Count == 0)
        {
            Console.WriteLine("  (Aucun)");
        }
        else
        {
            foreach (var mat in matsMission)
                Console.WriteLine($"  • Mat {mat.ID} | {mat.Type} #{mat.Numero} | {mat.Batiment}");
        }

        Console.WriteLine("\n");
    }
}

// ✅ APPEL ICI (EN DEHORS DE LA MÉTHODE)
AfficherTout(missions, operations, materiels);
Console.ReadLine(); // pour garder la console ouverte


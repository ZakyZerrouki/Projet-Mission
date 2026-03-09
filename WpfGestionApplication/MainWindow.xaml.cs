using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using QRCoder;
using System.IO;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Windows.Controls.Primitives;


namespace WpfGestionApplication
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private ObservableCollection<Mission> missions = new ObservableCollection<Mission>();


        public MainWindow()
        {
            InitializeComponent();
            GridMissions.ItemsSource = missions;
            LoadFakeData();
            
         




        }


       




        private void LoadFakeData() {
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



            missions.Add(new Mission
            {
                ID = 1,
                Agent = "Zaky",
                DateCreation = new DateTime(2025, 1, 10),
                DateLimite = new DateTime(2025, 1, 20),
                DateFin = new DateTime(2025, 1, 18),
                Validite = true,
                Nom = "Verif Extincteur"
            });

            missions.Add(new Mission
            {
                ID = 2,
                Agent = "Bob",
                DateCreation = new DateTime(2025, 2, 12),
                DateLimite = new DateTime(2025, 2, 22),
                DateFin = new DateTime(2025, 2, 25),
                Validite = false,
                Nom = "Lumiere secours"
            });

            missions.Add(new Mission
            {
                ID = 3,
                Agent = "Fabrice",
                DateCreation = new DateTime(2025, 3, 15),
                DateLimite = new DateTime(2025, 3, 28),
                DateFin = new DateTime(2025, 3, 27),
                Validite = true,
                Nom = "Porte casser"
            });


            GridMissions.ItemsSource = missions;
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
        }
            };
            MessageBox.Show("LoadFakeData called: " + missions.Count);

        }





        private void Login_Click(object sender, RoutedEventArgs e)
        {
            bool isAuth = true; // ici tu mettras ta vraie vérification BDD

            if (isAuth)
            {
             
                Lecture.IsEnabled = true;
                Gestion.IsEnabled = true;

               
            }

            var fenetre = new Login();
            fenetre.Show();
        }


        //// GESTION
        ///

        private void GestionAjouterButton_Click(object sender, RoutedEventArgs e)
        {
            var fenetre = new Ajouter_Gestion();
            fenetre.Show();
            return;
        }


        private void ButtonQR_Click(object sender, RoutedEventArgs e)
        {
            string qrcode = "https://youtu.be/_Aeh_8X1RVo?list=RD_Aeh_8X1RVo";

            QRCodeGenerator generator = new QRCodeGenerator();
            QRCodeData data = generator.CreateQrCode(qrcode, QRCodeGenerator.ECCLevel.H);

            byte[] pngBytes = new PngByteQRCode(data).GetGraphic(20);

            BitmapImage bmp = new BitmapImage();

            using (MemoryStream ms = new MemoryStream(pngBytes))
            {
                bmp.BeginInit();
                bmp.StreamSource = ms;
                bmp.CacheOption = BitmapCacheOption.OnLoad;
                bmp.EndInit();
            }

            qrImageGestion.Source = bmp;
            ///QR CODE END
        }

        private void OpenQR_Click(object sender, RoutedEventArgs e)
        {
            var fenetre = new QR();
            fenetre.Show();
            return;
        }
        /// A COMPLETER THIS IS A TEST
        private void ButtonSupprimer_Click(object sender, RoutedEventArgs e)
        {
            Mission selected = GridMissions.SelectedItem as Mission;
    if (selected == null) 
            {
                MessageBox.Show("Selectionne une mission");
                return;
                    }
            MessageBoxResult result = MessageBox.Show("Etes-vous sur de vouloir supprimer cet objet ?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Warning);

            if (result == MessageBoxResult.Yes)
            {
                missions.Remove(selected);
                MessageBox.Show("Objet supprimé");
  
            }

            else { return; }
                
        }
    }
}

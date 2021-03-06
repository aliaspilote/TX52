///////////////////////////////////////////////////////////
//  Sauvegarde.cs
//  Implementation of the Class Sauvegarde
//  Generated by Enterprise Architect
//  Created on:      17-juin-2015 09:38:57
//  Original author: Quentin
///////////////////////////////////////////////////////////
using System;
using System.Timers;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Modelisator.Model;
using System.IO;

namespace Modelisator.Model {
	public class Sauvegarde {

        private string      m_Chemin;
        private DateTime    m_Date;
        private string      m_Nom;

		public Produit m_Produit;

		public Sauvegarde(){		}

		public string Chemin{
			get{
                return m_Chemin;
			}
			set{
                m_Chemin = value;
			}
		}

        public DateTime Date
        {
			get{
                return m_Date;
			}
			set{
                m_Date = value;
			}
		}

        public void export()
        {
            string text;


            StreamWriter sw = new StreamWriter(m_Chemin);//cr�ation du fichier
            sw.WriteLine("Indice de matrice;Grandeur Physique;Unit�;Valeur;Description;Calcule;Selectionnne;EstPremier");
            foreach (KeyValuePair<string, GrandeurPhysique> gp in Produit.GrandeurPhysiques)
            {

                text = gp.Value.iM + ";" + gp.Value.Nom + ";" + gp.Value.Unite + ";" + gp.Value.Valeur + ";" + gp.Value.Description + ";" + gp.Value.Calcule + ";" + gp.Value.Selectionne + ";" + gp.Value.EstPremier;
                sw.WriteLine("{0}", text);//enregistrement de la liste gp.Value.Value dans le fichier 
            }

            sw.Close();


        }

        public void import()
        {
            var reader = new StreamReader(File.OpenRead(m_Chemin));
            reader.ReadLine(); //On passe les headers du csv.
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(';');
                GrandeurPhysique gp = new GrandeurPhysique();
                gp.iM = Convert.ToInt16(values[0]);
                gp.Nom = values[1];
                gp.Unite = values[2];
                gp.Valeur = Convert.ToDouble(values[3]);
                gp.Description = values[4];
                gp.Calcule = Convert.ToBoolean(values[5]);
                gp.Selectionne = Convert.ToBoolean(values[6]);
                gp.EstPremier = Convert.ToBoolean(values[7]);
                Produit.GrandeurPhysiques.Add(gp.Nom, gp);
            }


        }

		public string Nom{
			get{
                return m_Nom;
			}
			set{
                m_Nom = value;
			}
		}

	}//end Sauvegarde

}//end namespace Modelisator.Model
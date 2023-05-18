/*
 * Created by SharpDevelop.
 * User: miros
 * Date: 18/05/2023
 * Time: 13:11
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Data;
using System.Linq;
using AppCRUD;
using MySql.Data.MySqlClient; // connexion via une BDD MySQL
using System.Collections.Generic;

namespace AppCRUD
{
	/// <summary>
	/// Description of Utilisateur.
	/// </summary>
	public class Utilisateur
	{
		
		private int idUtilisateur;
		private String nom;
		private String prenom;
		
		public Utilisateur(){}
		
		public Utilisateur(int idUtilisateur, String nom, String prenom){
			
			this.idUtilisateur = idUtilisateur;
			this.nom = nom;
			this.prenom = prenom;
		}
		
		//setter

		public void setidUtilisateur(int idUtilisateur){
			this.idUtilisateur = idUtilisateur;
		}
		public void setnom(String nom){
			this.nom = nom;
		}
		public void setprenom(String prenom){
			this.prenom = prenom;
		}
		
		//getter
		
		public int getidUtilisateur(){
			return this.idUtilisateur;
		}
		public String getnom(){
		return this.nom;
		}
		public String getprenom(){
		return this.prenom;
		}
		
		
		//méthodes CRUD
		
		//méthode d'insertion utilisateur
		
		public void insertUtilisateur(){
		 // Connexion à la base de données
		 BDD.connexion();
		 String req = "INSERT INTO utilisateur (idUtilisateur,nom,prenom) VALUES ('"+this.idUtilisateur+"','"+this.nom+"','"+this.prenom+"')"; //declaration de la requete SQL qui sera utiliser pour l'insertion
		 MySqlCommand cmd = new MySqlCommand(req, BDD.maconnexion);
		 cmd.ExecuteNonQuery( );
		
		}
		
		
		
		//méthode de selection d'un utilisateur
		
		public DataTable selectUtilisateur()
		{
		    DataTable dataTable = new DataTable();
		
		    // Connexion à la base de données
		    BDD.connexion();
		    string req = "SELECT `idUtilisateur`, `nom`, `prenom` FROM `utilisateur` WHERE idUtilisateur = '" + this.idUtilisateur + "'";
		    MySqlCommand cmd = new MySqlCommand(req, BDD.maconnexion);
		
		    using (MySqlDataAdapter adapter = new MySqlDataAdapter(cmd))
		    {
		        adapter.Fill(dataTable);
		    }
		
		    return dataTable;
		}

		
		//méthode de mise à jour d'un utilisateur
		
		public void updateUtilisateur(){
		 // Connexion à la base de données
		 BDD.connexion();
		 String req = "UPDATE `utilisateur` SET `nom`='"+this.nom+"',`prenom`='"+this.prenom+"'WHERE idUtilisateur = '"+this.idUtilisateur+"' "; //declaration de la requete SQL qui sera utiliser pour la mise à jour
		 MySqlCommand cmd = new MySqlCommand(req, BDD.maconnexion);
		 cmd.ExecuteNonQuery( );
		
		}
		
		//méthode de suppression d'un utilisateur
		
		public void deleteUtilisateur(){
		 // Connexion à la base de données
		 BDD.connexion();
		 String req = "DELETE FROM `utilisateur` WHERE idUtilisateur = '"+this.idUtilisateur+"' "; //declaration de la requete SQL qui sera utiliser pour la mise à jour
		 MySqlCommand cmd = new MySqlCommand(req, BDD.maconnexion);
		 cmd.ExecuteNonQuery( );
		
		}
		
		public List<Utilisateur> FindAllUtilisateur()
		{
		    List<Utilisateur> utilisateurs = new List<Utilisateur>();
		    
		    // Connexion à la base de données
		    BDD.connexion();
		    
		    string req = "SELECT * FROM utilisateur";
		    MySqlCommand cmd = new MySqlCommand(req, BDD.maconnexion);
		    MySqlDataReader dataReader = cmd.ExecuteReader();
		    
		    while (dataReader.Read())
		    {
		        // Récupérer les valeurs des colonnes pour chaque utilisateur
		        int id = Convert.ToInt32(dataReader["idUtilisateur"]);
		        string nom = dataReader["nom"].ToString();
		        string prenom = dataReader["prenom"].ToString();
		        // Ajouter un nouvel utilisateur à la liste
		        utilisateurs.Add(new Utilisateur(id, nom, prenom));
		    }
		    
		    dataReader.Close();
		    return utilisateurs;
		}

		
	}
}

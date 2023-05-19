/*
 * Crée par SharpDevelop.
 * Utilisateur: miros
 * Date: 19/05/2023
 * Heure: 11:04
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using MySql.Data.MySqlClient;

namespace Authentification
{
	/// <summary>
	/// Description of Authentification.
	/// </summary>
	public class Authentification
	{
		private String login;
		private String mdp;
		
		public Authentification(){}
		public Authentification(String login, String mdp){
		
			this.login = login;
			this.mdp = mdp;
		}
		
		//getter
			public void setLogin(String login){
			this.login = login;
		}
		
			public void setMdp(String mdp){
			this.mdp = mdp;
		}

		//setter
		public String getLogin(){
			return this.login;
		}	
		
		public String getMdp(){
			return this.mdp;
		}
		
		
		//methodes
		
		//methode d'authentification

		
		public void create() {
		    // Connexion à la base de données
		    BDD.connexion(); // appel de la classe BDD et de la méthode connexion
		    
		    // Génération du sel aléatoire pour Bcrypt
		    string salt = BCrypt.Net.BCrypt.GenerateSalt();
		    
		    // Hachage du mot de passe avec le sel généré
		    string hashedPassword = BCrypt.Net.BCrypt.HashPassword(this.mdp, salt);
		    
		    String req = "INSERT INTO authentification (login,mdp) VALUES ('" + this.login + "','" + hashedPassword + "')"; // déclaration de la requête SQL qui sera utilisée pour la création
		    MySqlCommand cmd = new MySqlCommand(req, BDD.maconnexion); // exécution de la requête et de la connexion
		    cmd.ExecuteNonQuery();
		}

		
		
		
		//methode de creation account
		

		public bool VerifyLogin(string login, string password)
		{
		    // Connexion à la base de données
		    BDD.connexion(); // appel de la classe BDD et de la méthode connexion
		    
		    // Récupération du mot de passe haché de l'utilisateur à partir de la base de données
		    string req = "SELECT mdp FROM authentification WHERE login = @login";
		    MySqlCommand cmd = new MySqlCommand(req, BDD.maconnexion);
		    cmd.Parameters.AddWithValue("@login", login);
		    MySqlDataReader reader = cmd.ExecuteReader();
		
		    if (reader.Read())
		    {
		        string hashedPassword = reader.GetString("mdp");
		
		        // Vérification du mot de passe
		        if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
		        {
		            // Le mot de passe correspond, rediriger vers une autre page
		            RedirectToAnotherPage();
		            reader.Close();
		            return true;
		        }
		    }
		
		    reader.Close();
		    System.Windows.Forms.MessageBox.Show("erreur authentification"); //message avertissant
		    return false;
		}
		
		private void RedirectToAnotherPage()
		{
		    // Logique pour rediriger l'utilisateur vers une autre page
		        // Créer une nouvelle instance de la fenêtre cible et de celle à fermer
		   MainForm auto = new MainForm();
		   Accueil autreForm = new Accueil();
		
		    // Afficher la nouvelle fenêtre
		    autreForm.Show();
		    
		        // Fermer la fenêtre principale
		    auto.Close();
		    
		
		}

		
	}
}

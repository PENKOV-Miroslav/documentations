/*
 * Crée par SharpDevelop.
 * Utilisateur: miros
 * Date: 19/05/2023
 * Heure: 11:03
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using MySql.Data.MySqlClient; // connexion via une BDD MySQL

namespace Authentification
{
	/// <summary>
	/// Description of BDD.
	/// </summary>
public static class BDD  {
		 public static MySqlConnection maconnexion;
			 public static void connexion( ) {
		 	String fichier = System.IO.File.ReadAllText ("connexHostIP.ini");
			 String chaineConnexion;
			 chaineConnexion = "data source="+fichier+"; initial catalog=auto;user id= root;password=;";
			 maconnexion = new MySqlConnection(chaineConnexion);
			 maconnexion.Open( );
			 } // Fin méthode connexion
	}
	}

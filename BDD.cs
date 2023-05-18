/*
 * Crée par SharpDevelop.
 * Utilisateur: m.penkov
 * Date: 14/06/2022
 * Heure: 14:50
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using MySql.Data.MySqlClient; // connexion via une BDD MySQL

namespace AppCRUD
{
	/// <summary>
	/// Description of BDD.
	/// </summary>
public static class BDD  {
		 public static MySqlConnection maconnexion;
			 public static void connexion( ) {
		 	String fichier = System.IO.File.ReadAllText ("connexHostIP.ini");
			 String chaineConnexion;
			 chaineConnexion = "data source="+fichier+"; initial catalog=testcrud;user id= root;password=;";
			 maconnexion = new MySqlConnection(chaineConnexion);
			 maconnexion.Open( );
			 } // Fin méthode connexion
	}
	}

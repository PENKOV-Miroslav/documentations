/*
 * Crée par SharpDevelop.
 * Utilisateur: miros
 * Date: 19/05/2023
 * Heure: 10:59
 * 
 * Pour changer ce modèle utiliser Outils | Options | Codage | Editer les en-têtes standards.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Authentification
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		Authentification auto = new Authentification();
		
		void BtnAuthentificationClick(object sender, EventArgs e)
		{
			string login = textBox1.Text;
			string password = textBox2.Text;
			auto.VerifyLogin(login,password);
	
		}
		void BtnAccountClick(object sender, EventArgs e)
		{
	 		auto.setLogin( textBox1.Text);
			auto.setMdp( textBox2.Text);
			auto.create();
			MessageBox.Show("l'account est créé");
		}
	}
}

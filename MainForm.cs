/*
 * Created by SharpDevelop.
 * User: miros
 * Date: 18/05/2023
 * Time: 12:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace AppCRUD
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
		
		Utilisateur util = new Utilisateur();
		
		
		void BtnInsertionClick(object sender, EventArgs e)
		{
			util.setidUtilisateur( int.Parse(textBox1.Text));
			util.setnom( textBox2.Text);
		 	util.setprenom( textBox3.Text);
		 	
		 	util.insertUtilisateur();
		 	textBox1.Text=String.Empty; //Efface le contenu des textBox
			textBox2.Text=String.Empty;
			textBox3.Text=String.Empty;
	
		}
		
		
		void BtnSelectionClick(object sender, EventArgs e)
		{
		
		    util.setidUtilisateur(int.Parse(textBox1.Text));
		
		    DataTable dataTable = util.selectUtilisateur();
		    dataGridView1.DataSource = dataTable;
		    textBox1.Text=String.Empty; //Efface le contenu des textBox

	
		}
		
		
		void BtnUpdateClick(object sender, EventArgs e)
		{
			util.setidUtilisateur( int.Parse(textBox1.Text));
			util.setnom( textBox2.Text);
		 	util.setprenom( textBox3.Text);
		 	
		 	util.updateUtilisateur();
		 	textBox1.Text=String.Empty; //Efface le contenu des textBox
			textBox2.Text=String.Empty;
			textBox3.Text=String.Empty;
	
		}
		
		
		void BtnDeleteClick(object sender, EventArgs e)
		{
			util.setidUtilisateur( int.Parse(textBox1.Text));
		 	
		 	BDD.connexion();
		 	util.deleteUtilisateur();
		 	textBox1.Text=String.Empty; //Efface le contenu des textBox

	
		}
		
		
		void BtnFindAllClick(object sender, EventArgs e)
		{
			dataGridView1.Rows.Clear();
			Utilisateur utilisateurRepository = new Utilisateur();
			List<Utilisateur> utilisateurs = utilisateurRepository.FindAllUtilisateur();
			foreach (Utilisateur utilisateur in utilisateurs)
			{
			    dataGridView1.Rows.Add(utilisateur.getidUtilisateur(), utilisateur.getnom(), utilisateur.getprenom());
			}

		}

	}
}

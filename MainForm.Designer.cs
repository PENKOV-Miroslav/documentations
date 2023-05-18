/*
 * Created by SharpDevelop.
 * User: miros
 * Date: 18/05/2023
 * Time: 12:58
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AppCRUD
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btnInsertion;
		private System.Windows.Forms.Button btnSelection;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Button btnFindAll;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idUtilisateur;
		private System.Windows.Forms.DataGridViewTextBoxColumn nom;
		private System.Windows.Forms.DataGridViewTextBoxColumn prenom;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnInsertion = new System.Windows.Forms.Button();
			this.btnSelection = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.btnFindAll = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.idUtilisateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// btnInsertion
			// 
			this.btnInsertion.Location = new System.Drawing.Point(49, 45);
			this.btnInsertion.Name = "btnInsertion";
			this.btnInsertion.Size = new System.Drawing.Size(75, 23);
			this.btnInsertion.TabIndex = 0;
			this.btnInsertion.Text = "insert";
			this.btnInsertion.UseVisualStyleBackColor = true;
			this.btnInsertion.Click += new System.EventHandler(this.BtnInsertionClick);
			// 
			// btnSelection
			// 
			this.btnSelection.Location = new System.Drawing.Point(156, 45);
			this.btnSelection.Name = "btnSelection";
			this.btnSelection.Size = new System.Drawing.Size(75, 23);
			this.btnSelection.TabIndex = 1;
			this.btnSelection.Text = "select";
			this.btnSelection.UseVisualStyleBackColor = true;
			this.btnSelection.Click += new System.EventHandler(this.BtnSelectionClick);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(274, 45);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(75, 23);
			this.btnUpdate.TabIndex = 2;
			this.btnUpdate.Text = "update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.BtnUpdateClick);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(389, 45);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(75, 23);
			this.btnDelete.TabIndex = 3;
			this.btnDelete.Text = "delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.BtnDeleteClick);
			// 
			// textBox1
			// 
			this.textBox1.AccessibleName = "";
			this.textBox1.Location = new System.Drawing.Point(49, 113);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 20);
			this.textBox1.TabIndex = 4;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(49, 140);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 20);
			this.textBox2.TabIndex = 5;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(49, 167);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(100, 20);
			this.textBox3.TabIndex = 6;
			// 
			// btnFindAll
			// 
			this.btnFindAll.Location = new System.Drawing.Point(505, 45);
			this.btnFindAll.Name = "btnFindAll";
			this.btnFindAll.Size = new System.Drawing.Size(75, 23);
			this.btnFindAll.TabIndex = 7;
			this.btnFindAll.Text = "finAll";
			this.btnFindAll.UseVisualStyleBackColor = true;
			this.btnFindAll.Click += new System.EventHandler(this.BtnFindAllClick);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
			this.idUtilisateur,
			this.nom,
			this.prenom});
			this.dataGridView1.Location = new System.Drawing.Point(156, 128);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.Size = new System.Drawing.Size(631, 290);
			this.dataGridView1.TabIndex = 8;
			// 
			// idUtilisateur
			// 
			this.idUtilisateur.HeaderText = "idUtilisateur";
			this.idUtilisateur.Name = "idUtilisateur";
			this.idUtilisateur.ReadOnly = true;
			this.idUtilisateur.Width = 300;
			// 
			// nom
			// 
			this.nom.HeaderText = "nom";
			this.nom.Name = "nom";
			this.nom.ReadOnly = true;
			this.nom.Width = 300;
			// 
			// prenom
			// 
			this.prenom.HeaderText = "prenom";
			this.prenom.Name = "prenom";
			this.prenom.ReadOnly = true;
			this.prenom.Width = 300;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 110);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(31, 23);
			this.label1.TabIndex = 9;
			this.label1.Text = "label1";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 710);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.btnFindAll);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSelection);
			this.Controls.Add(this.btnInsertion);
			this.Name = "MainForm";
			this.Text = "AppCRUD";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}

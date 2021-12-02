
namespace IHM
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.flotsbleusDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.flotsbleusDataSet = new IHM.flotsbleusDataSet();
            this.marinTableAdapter = new IHM.flotsbleusDataSetTableAdapters.marinTableAdapter();
            this.bindingSourceMarin = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.rolemarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idVoilierInscritmarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telmarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailmarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressemarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpmarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.villemarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateNaissancemarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenommarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nommarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idmarinDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.flotsbleusDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotsbleusDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMarin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // flotsbleusDataSetBindingSource
            // 
            this.flotsbleusDataSetBindingSource.DataMember = "marin";
            this.flotsbleusDataSetBindingSource.DataSource = this.flotsbleusDataSet;
            // 
            // flotsbleusDataSet
            // 
            this.flotsbleusDataSet.DataSetName = "flotsbleusDataSet";
            this.flotsbleusDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // marinTableAdapter
            // 
            this.marinTableAdapter.ClearBeforeFill = true;
            // 
            // bindingSourceMarin
            // 
            this.bindingSourceMarin.DataMember = "marin";
            this.bindingSourceMarin.DataSource = this.flotsbleusDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bindingNavigator1.BindingSource = this.bindingSourceMarin;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButton1});
            this.bindingNavigator1.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem;
            this.bindingNavigator1.Size = new System.Drawing.Size(800, 25);
            this.bindingNavigator1.TabIndex = 1;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceMarin, "nom_marin", true));
            this.textBox1.Location = new System.Drawing.Point(185, 194);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 25);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // rolemarinDataGridViewTextBoxColumn
            // 
            this.rolemarinDataGridViewTextBoxColumn.DataPropertyName = "role_marin";
            this.rolemarinDataGridViewTextBoxColumn.HeaderText = "role_marin";
            this.rolemarinDataGridViewTextBoxColumn.Name = "rolemarinDataGridViewTextBoxColumn";
            // 
            // idVoilierInscritmarinDataGridViewTextBoxColumn
            // 
            this.idVoilierInscritmarinDataGridViewTextBoxColumn.DataPropertyName = "idVoilierInscrit_marin";
            this.idVoilierInscritmarinDataGridViewTextBoxColumn.HeaderText = "idVoilierInscrit_marin";
            this.idVoilierInscritmarinDataGridViewTextBoxColumn.Name = "idVoilierInscritmarinDataGridViewTextBoxColumn";
            // 
            // telmarinDataGridViewTextBoxColumn
            // 
            this.telmarinDataGridViewTextBoxColumn.DataPropertyName = "tel_marin";
            this.telmarinDataGridViewTextBoxColumn.HeaderText = "tel_marin";
            this.telmarinDataGridViewTextBoxColumn.Name = "telmarinDataGridViewTextBoxColumn";
            // 
            // mailmarinDataGridViewTextBoxColumn
            // 
            this.mailmarinDataGridViewTextBoxColumn.DataPropertyName = "mail_marin";
            this.mailmarinDataGridViewTextBoxColumn.HeaderText = "mail_marin";
            this.mailmarinDataGridViewTextBoxColumn.Name = "mailmarinDataGridViewTextBoxColumn";
            // 
            // adressemarinDataGridViewTextBoxColumn
            // 
            this.adressemarinDataGridViewTextBoxColumn.DataPropertyName = "adresse_marin";
            this.adressemarinDataGridViewTextBoxColumn.HeaderText = "adresse_marin";
            this.adressemarinDataGridViewTextBoxColumn.Name = "adressemarinDataGridViewTextBoxColumn";
            // 
            // cpmarinDataGridViewTextBoxColumn
            // 
            this.cpmarinDataGridViewTextBoxColumn.DataPropertyName = "cp_marin";
            this.cpmarinDataGridViewTextBoxColumn.HeaderText = "cp_marin";
            this.cpmarinDataGridViewTextBoxColumn.Name = "cpmarinDataGridViewTextBoxColumn";
            // 
            // villemarinDataGridViewTextBoxColumn
            // 
            this.villemarinDataGridViewTextBoxColumn.DataPropertyName = "ville_marin";
            this.villemarinDataGridViewTextBoxColumn.HeaderText = "ville_marin";
            this.villemarinDataGridViewTextBoxColumn.Name = "villemarinDataGridViewTextBoxColumn";
            // 
            // dateNaissancemarinDataGridViewTextBoxColumn
            // 
            this.dateNaissancemarinDataGridViewTextBoxColumn.DataPropertyName = "dateNaissance_marin";
            this.dateNaissancemarinDataGridViewTextBoxColumn.HeaderText = "dateNaissance_marin";
            this.dateNaissancemarinDataGridViewTextBoxColumn.Name = "dateNaissancemarinDataGridViewTextBoxColumn";
            // 
            // prenommarinDataGridViewTextBoxColumn
            // 
            this.prenommarinDataGridViewTextBoxColumn.DataPropertyName = "prenom_marin";
            this.prenommarinDataGridViewTextBoxColumn.HeaderText = "prenom_marin";
            this.prenommarinDataGridViewTextBoxColumn.Name = "prenommarinDataGridViewTextBoxColumn";
            // 
            // nommarinDataGridViewTextBoxColumn
            // 
            this.nommarinDataGridViewTextBoxColumn.DataPropertyName = "nom_marin";
            this.nommarinDataGridViewTextBoxColumn.HeaderText = "nom_marin";
            this.nommarinDataGridViewTextBoxColumn.Name = "nommarinDataGridViewTextBoxColumn";
            // 
            // idmarinDataGridViewTextBoxColumn
            // 
            this.idmarinDataGridViewTextBoxColumn.DataPropertyName = "id_marin";
            this.idmarinDataGridViewTextBoxColumn.HeaderText = "id_marin";
            this.idmarinDataGridViewTextBoxColumn.Name = "idmarinDataGridViewTextBoxColumn";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idmarinDataGridViewTextBoxColumn,
            this.nommarinDataGridViewTextBoxColumn,
            this.prenommarinDataGridViewTextBoxColumn,
            this.dateNaissancemarinDataGridViewTextBoxColumn,
            this.villemarinDataGridViewTextBoxColumn,
            this.cpmarinDataGridViewTextBoxColumn,
            this.adressemarinDataGridViewTextBoxColumn,
            this.mailmarinDataGridViewTextBoxColumn,
            this.telmarinDataGridViewTextBoxColumn,
            this.idVoilierInscritmarinDataGridViewTextBoxColumn,
            this.rolemarinDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.flotsbleusDataSetBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(129, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(211, 210);
            this.dataGridView1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.flotsbleusDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flotsbleusDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceMarin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource flotsbleusDataSetBindingSource;
        private flotsbleusDataSet flotsbleusDataSet;
        private flotsbleusDataSetTableAdapters.marinTableAdapter marinTableAdapter;
        private System.Windows.Forms.BindingSource bindingSourceMarin;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolemarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVoilierInscritmarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telmarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailmarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressemarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpmarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn villemarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateNaissancemarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenommarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nommarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idmarinDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}
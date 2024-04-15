namespace Biblioteca_Lexi
{
    partial class Lista_clientilor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_clientilor));
            System.Windows.Forms.Label nume_prenumeLabel;
            System.Windows.Forms.Label nr_cartiLabel;
            System.Windows.Forms.Label nr_telefonLabel;
            System.Windows.Forms.Label nr_buletinLabel;
            System.Windows.Forms.Label adresaLabel;
            this.iesireF3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.atestatDataSet = new Biblioteca_Lexi.atestatDataSet();
            this.clientiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientiTableAdapter = new Biblioteca_Lexi.atestatDataSetTableAdapters.ClientiTableAdapter();
            this.tableAdapterManager = new Biblioteca_Lexi.atestatDataSetTableAdapters.TableAdapterManager();
            this.clientiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.clientiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nume_prenumeTextBox = new System.Windows.Forms.TextBox();
            this.nr_cartiTextBox = new System.Windows.Forms.TextBox();
            this.nr_telefonTextBox = new System.Windows.Forms.TextBox();
            this.nr_buletinTextBox = new System.Windows.Forms.TextBox();
            this.adresaTextBox = new System.Windows.Forms.TextBox();
            this.clientiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            nume_prenumeLabel = new System.Windows.Forms.Label();
            nr_cartiLabel = new System.Windows.Forms.Label();
            nr_telefonLabel = new System.Windows.Forms.Label();
            nr_buletinLabel = new System.Windows.Forms.Label();
            adresaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atestatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).BeginInit();
            this.clientiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iesireF3
            // 
            this.iesireF3.BackColor = System.Drawing.Color.Black;
            this.iesireF3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iesireF3.BackgroundImage")));
            this.iesireF3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iesireF3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireF3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iesireF3.Location = new System.Drawing.Point(1136, 571);
            this.iesireF3.Name = "iesireF3";
            this.iesireF3.Size = new System.Drawing.Size(153, 106);
            this.iesireF3.TabIndex = 1;
            this.iesireF3.UseVisualStyleBackColor = false;
            this.iesireF3.Click += new System.EventHandler(this.iesireF3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(517, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 54);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lista clienților";
            // 
            // atestatDataSet
            // 
            this.atestatDataSet.DataSetName = "atestatDataSet";
            this.atestatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientiBindingSource
            // 
            this.clientiBindingSource.DataMember = "Clienti";
            this.clientiBindingSource.DataSource = this.atestatDataSet;
            // 
            // clientiTableAdapter
            // 
            this.clientiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartiTableAdapter = null;
            this.tableAdapterManager.ClientiTableAdapter = this.clientiTableAdapter;
            this.tableAdapterManager.ImprumuturiTableAdapter = null;
            this.tableAdapterManager.ProbaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca_Lexi.atestatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientiBindingNavigator
            // 
            this.clientiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientiBindingNavigator.BindingSource = this.clientiBindingSource;
            this.clientiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientiBindingNavigatorSaveItem});
            this.clientiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientiBindingNavigator.Name = "clientiBindingNavigator";
            this.clientiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientiBindingNavigator.Size = new System.Drawing.Size(1358, 25);
            this.clientiBindingNavigator.TabIndex = 4;
            this.clientiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
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
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // clientiBindingNavigatorSaveItem
            // 
            this.clientiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientiBindingNavigatorSaveItem.Image")));
            this.clientiBindingNavigatorSaveItem.Name = "clientiBindingNavigatorSaveItem";
            this.clientiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.clientiBindingNavigatorSaveItem.Text = "Save Data";
            this.clientiBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientiBindingNavigatorSaveItem_Click);
            // 
            // nume_prenumeLabel
            // 
            nume_prenumeLabel.AutoSize = true;
            nume_prenumeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nume_prenumeLabel.Location = new System.Drawing.Point(107, 145);
            nume_prenumeLabel.Name = "nume_prenumeLabel";
            nume_prenumeLabel.Size = new System.Drawing.Size(164, 25);
            nume_prenumeLabel.TabIndex = 4;
            nume_prenumeLabel.Text = "Nume prenume:";
            // 
            // nume_prenumeTextBox
            // 
            this.nume_prenumeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Nume_prenume", true));
            this.nume_prenumeTextBox.Location = new System.Drawing.Point(277, 136);
            this.nume_prenumeTextBox.Multiline = true;
            this.nume_prenumeTextBox.Name = "nume_prenumeTextBox";
            this.nume_prenumeTextBox.Size = new System.Drawing.Size(334, 51);
            this.nume_prenumeTextBox.TabIndex = 5;
            // 
            // nr_cartiLabel
            // 
            nr_cartiLabel.AutoSize = true;
            nr_cartiLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_cartiLabel.Location = new System.Drawing.Point(96, 244);
            nr_cartiLabel.Name = "nr_cartiLabel";
            nr_cartiLabel.Size = new System.Drawing.Size(175, 25);
            nr_cartiLabel.TabIndex = 5;
            nr_cartiLabel.Text = "Numărul de cărti:";
            // 
            // nr_cartiTextBox
            // 
            this.nr_cartiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Nr_carti", true));
            this.nr_cartiTextBox.Location = new System.Drawing.Point(277, 230);
            this.nr_cartiTextBox.Multiline = true;
            this.nr_cartiTextBox.Name = "nr_cartiTextBox";
            this.nr_cartiTextBox.Size = new System.Drawing.Size(334, 54);
            this.nr_cartiTextBox.TabIndex = 6;
            // 
            // nr_telefonLabel
            // 
            nr_telefonLabel.AutoSize = true;
            nr_telefonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_telefonLabel.Location = new System.Drawing.Point(89, 342);
            nr_telefonLabel.Name = "nr_telefonLabel";
            nr_telefonLabel.Size = new System.Drawing.Size(182, 25);
            nr_telefonLabel.TabIndex = 7;
            nr_telefonLabel.Text = "Număr de telefon:";
            // 
            // nr_telefonTextBox
            // 
            this.nr_telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Nr_telefon", true));
            this.nr_telefonTextBox.Location = new System.Drawing.Point(277, 329);
            this.nr_telefonTextBox.Multiline = true;
            this.nr_telefonTextBox.Name = "nr_telefonTextBox";
            this.nr_telefonTextBox.Size = new System.Drawing.Size(334, 56);
            this.nr_telefonTextBox.TabIndex = 8;
            // 
            // nr_buletinLabel
            // 
            nr_buletinLabel.AutoSize = true;
            nr_buletinLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_buletinLabel.Location = new System.Drawing.Point(694, 190);
            nr_buletinLabel.Name = "nr_buletinLabel";
            nr_buletinLabel.Size = new System.Drawing.Size(151, 25);
            nr_buletinLabel.TabIndex = 9;
            nr_buletinLabel.Text = "Număr buletin:";
            // 
            // nr_buletinTextBox
            // 
            this.nr_buletinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Nr_buletin", true));
            this.nr_buletinTextBox.Location = new System.Drawing.Point(851, 174);
            this.nr_buletinTextBox.Multiline = true;
            this.nr_buletinTextBox.Name = "nr_buletinTextBox";
            this.nr_buletinTextBox.Size = new System.Drawing.Size(295, 53);
            this.nr_buletinTextBox.TabIndex = 10;
            // 
            // adresaLabel
            // 
            adresaLabel.AutoSize = true;
            adresaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            adresaLabel.Location = new System.Drawing.Point(759, 299);
            adresaLabel.Name = "adresaLabel";
            adresaLabel.Size = new System.Drawing.Size(86, 25);
            adresaLabel.TabIndex = 11;
            adresaLabel.Text = "Adresa:";
            // 
            // adresaTextBox
            // 
            this.adresaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientiBindingSource, "Adresa", true));
            this.adresaTextBox.Location = new System.Drawing.Point(851, 275);
            this.adresaTextBox.Multiline = true;
            this.adresaTextBox.Name = "adresaTextBox";
            this.adresaTextBox.Size = new System.Drawing.Size(295, 60);
            this.adresaTextBox.TabIndex = 12;
            // 
            // clientiDataGridView
            // 
            this.clientiDataGridView.AutoGenerateColumns = false;
            this.clientiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.clientiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.clientiDataGridView.DataSource = this.clientiBindingSource;
            this.clientiDataGridView.Location = new System.Drawing.Point(92, 414);
            this.clientiDataGridView.Name = "clientiDataGridView";
            this.clientiDataGridView.Size = new System.Drawing.Size(842, 263);
            this.clientiDataGridView.TabIndex = 13;
            this.clientiDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.clientiDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nume_prenume";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nume_prenume";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Nr_carti";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nr_carti";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Nr_telefon";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nr_telefon";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Nr_buletin";
            this.dataGridViewTextBoxColumn5.HeaderText = "Nr_buletin";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Adresa";
            this.dataGridViewTextBoxColumn6.HeaderText = "Adresa";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Lista_clientilor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1358, 738);
            this.Controls.Add(this.clientiDataGridView);
            this.Controls.Add(adresaLabel);
            this.Controls.Add(this.adresaTextBox);
            this.Controls.Add(nr_buletinLabel);
            this.Controls.Add(this.nr_buletinTextBox);
            this.Controls.Add(nr_telefonLabel);
            this.Controls.Add(this.nr_telefonTextBox);
            this.Controls.Add(nr_cartiLabel);
            this.Controls.Add(this.nr_cartiTextBox);
            this.Controls.Add(nume_prenumeLabel);
            this.Controls.Add(this.nume_prenumeTextBox);
            this.Controls.Add(this.clientiBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iesireF3);
            this.Name = "Lista_clientilor";
            this.Text = "Lista_clientilor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lista_clientilor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atestatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientiBindingNavigator)).EndInit();
            this.clientiBindingNavigator.ResumeLayout(false);
            this.clientiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clientiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iesireF3;
        private System.Windows.Forms.Label label1;
        private atestatDataSet atestatDataSet;
        private System.Windows.Forms.BindingSource clientiBindingSource;
        private atestatDataSetTableAdapters.ClientiTableAdapter clientiTableAdapter;
        private atestatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nume_prenumeTextBox;
        private System.Windows.Forms.TextBox nr_cartiTextBox;
        private System.Windows.Forms.TextBox nr_telefonTextBox;
        private System.Windows.Forms.TextBox nr_buletinTextBox;
        private System.Windows.Forms.TextBox adresaTextBox;
        private System.Windows.Forms.DataGridView clientiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
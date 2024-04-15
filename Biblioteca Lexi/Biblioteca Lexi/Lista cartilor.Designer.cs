namespace Biblioteca_Lexi
{
    partial class Lista_cartilor
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
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label titluLabel;
            System.Windows.Forms.Label edituraLabel;
            System.Windows.Forms.Label an_aparitieLabel;
            System.Windows.Forms.Label nr_volumLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lista_cartilor));
            this.iesireF2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.atestatDataSet = new Biblioteca_Lexi.atestatDataSet();
            this.cartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartiTableAdapter = new Biblioteca_Lexi.atestatDataSetTableAdapters.CartiTableAdapter();
            this.tableAdapterManager = new Biblioteca_Lexi.atestatDataSetTableAdapters.TableAdapterManager();
            this.cartiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.cartiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.titluTextBox = new System.Windows.Forms.TextBox();
            this.edituraTextBox = new System.Windows.Forms.TextBox();
            this.an_aparitieTextBox = new System.Windows.Forms.TextBox();
            this.nr_volumTextBox = new System.Windows.Forms.TextBox();
            this.cartiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            autorLabel = new System.Windows.Forms.Label();
            titluLabel = new System.Windows.Forms.Label();
            edituraLabel = new System.Windows.Forms.Label();
            an_aparitieLabel = new System.Windows.Forms.Label();
            nr_volumLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atestatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingNavigator)).BeginInit();
            this.cartiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(111, 124);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(69, 25);
            autorLabel.TabIndex = 3;
            autorLabel.Text = "Autor:";
            // 
            // titluLabel
            // 
            titluLabel.AutoSize = true;
            titluLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            titluLabel.Location = new System.Drawing.Point(121, 202);
            titluLabel.Name = "titluLabel";
            titluLabel.Size = new System.Drawing.Size(59, 25);
            titluLabel.TabIndex = 5;
            titluLabel.Text = "Titlu:";
            // 
            // edituraLabel
            // 
            edituraLabel.AutoSize = true;
            edituraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            edituraLabel.Location = new System.Drawing.Point(94, 280);
            edituraLabel.Name = "edituraLabel";
            edituraLabel.Size = new System.Drawing.Size(86, 25);
            edituraLabel.TabIndex = 7;
            edituraLabel.Text = "Editura:";
            // 
            // an_aparitieLabel
            // 
            an_aparitieLabel.AutoSize = true;
            an_aparitieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            an_aparitieLabel.Location = new System.Drawing.Point(632, 162);
            an_aparitieLabel.Name = "an_aparitieLabel";
            an_aparitieLabel.Size = new System.Drawing.Size(138, 25);
            an_aparitieLabel.TabIndex = 9;
            an_aparitieLabel.Text = "Anul apariție:";
            an_aparitieLabel.Click += new System.EventHandler(this.an_aparitieLabel_Click);
            // 
            // nr_volumLabel
            // 
            nr_volumLabel.AutoSize = true;
            nr_volumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nr_volumLabel.Location = new System.Drawing.Point(575, 245);
            nr_volumLabel.Name = "nr_volumLabel";
            nr_volumLabel.Size = new System.Drawing.Size(195, 25);
            nr_volumLabel.TabIndex = 11;
            nr_volumLabel.Text = "Numărul volumului:";
            // 
            // iesireF2
            // 
            this.iesireF2.BackColor = System.Drawing.Color.Black;
            this.iesireF2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iesireF2.BackgroundImage")));
            this.iesireF2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iesireF2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireF2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iesireF2.Location = new System.Drawing.Point(1110, 560);
            this.iesireF2.Name = "iesireF2";
            this.iesireF2.Size = new System.Drawing.Size(153, 106);
            this.iesireF2.TabIndex = 0;
            this.iesireF2.UseVisualStyleBackColor = false;
            this.iesireF2.Click += new System.EventHandler(this.iesireF2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(539, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista cărților";
            // 
            // atestatDataSet
            // 
            this.atestatDataSet.DataSetName = "atestatDataSet";
            this.atestatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cartiBindingSource
            // 
            this.cartiBindingSource.DataMember = "Carti";
            this.cartiBindingSource.DataSource = this.atestatDataSet;
            // 
            // cartiTableAdapter
            // 
            this.cartiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartiTableAdapter = this.cartiTableAdapter;
            this.tableAdapterManager.ClientiTableAdapter = null;
            this.tableAdapterManager.ImprumuturiTableAdapter = null;
            this.tableAdapterManager.ProbaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca_Lexi.atestatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // cartiBindingNavigator
            // 
            this.cartiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.cartiBindingNavigator.BindingSource = this.cartiBindingSource;
            this.cartiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.cartiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.cartiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.cartiBindingNavigatorSaveItem});
            this.cartiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.cartiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.cartiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.cartiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.cartiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.cartiBindingNavigator.Name = "cartiBindingNavigator";
            this.cartiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.cartiBindingNavigator.Size = new System.Drawing.Size(1358, 25);
            this.cartiBindingNavigator.TabIndex = 2;
            this.cartiBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // cartiBindingNavigatorSaveItem
            // 
            this.cartiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cartiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("cartiBindingNavigatorSaveItem.Image")));
            this.cartiBindingNavigatorSaveItem.Name = "cartiBindingNavigatorSaveItem";
            this.cartiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.cartiBindingNavigatorSaveItem.Text = "Save Data";
            this.cartiBindingNavigatorSaveItem.Click += new System.EventHandler(this.cartiBindingNavigatorSaveItem_Click);
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartiBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(186, 110);
            this.autorTextBox.Multiline = true;
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(331, 50);
            this.autorTextBox.TabIndex = 4;
            // 
            // titluTextBox
            // 
            this.titluTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartiBindingSource, "Titlu", true));
            this.titluTextBox.Location = new System.Drawing.Point(186, 189);
            this.titluTextBox.Multiline = true;
            this.titluTextBox.Name = "titluTextBox";
            this.titluTextBox.Size = new System.Drawing.Size(331, 54);
            this.titluTextBox.TabIndex = 6;
            // 
            // edituraTextBox
            // 
            this.edituraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartiBindingSource, "Editura", true));
            this.edituraTextBox.Location = new System.Drawing.Point(186, 267);
            this.edituraTextBox.Multiline = true;
            this.edituraTextBox.Name = "edituraTextBox";
            this.edituraTextBox.Size = new System.Drawing.Size(331, 50);
            this.edituraTextBox.TabIndex = 8;
            // 
            // an_aparitieTextBox
            // 
            this.an_aparitieTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartiBindingSource, "An_aparitie", true));
            this.an_aparitieTextBox.Location = new System.Drawing.Point(776, 151);
            this.an_aparitieTextBox.Multiline = true;
            this.an_aparitieTextBox.Name = "an_aparitieTextBox";
            this.an_aparitieTextBox.Size = new System.Drawing.Size(264, 46);
            this.an_aparitieTextBox.TabIndex = 10;
            // 
            // nr_volumTextBox
            // 
            this.nr_volumTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartiBindingSource, "Nr_volum", true));
            this.nr_volumTextBox.Location = new System.Drawing.Point(776, 230);
            this.nr_volumTextBox.Multiline = true;
            this.nr_volumTextBox.Name = "nr_volumTextBox";
            this.nr_volumTextBox.Size = new System.Drawing.Size(264, 52);
            this.nr_volumTextBox.TabIndex = 12;
            // 
            // cartiDataGridView
            // 
            this.cartiDataGridView.AutoGenerateColumns = false;
            this.cartiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cartiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cartiDataGridView.DataSource = this.cartiBindingSource;
            this.cartiDataGridView.Location = new System.Drawing.Point(95, 362);
            this.cartiDataGridView.Name = "cartiDataGridView";
            this.cartiDataGridView.Size = new System.Drawing.Size(820, 304);
            this.cartiDataGridView.TabIndex = 13;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn2.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titlu";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titlu";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Editura";
            this.dataGridViewTextBoxColumn4.HeaderText = "Editura";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "An_aparitie";
            this.dataGridViewTextBoxColumn5.HeaderText = "An_aparitie";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Nr_volum";
            this.dataGridViewTextBoxColumn6.HeaderText = "Nr_volum";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // Lista_cartilor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1358, 686);
            this.Controls.Add(this.cartiDataGridView);
            this.Controls.Add(nr_volumLabel);
            this.Controls.Add(this.nr_volumTextBox);
            this.Controls.Add(an_aparitieLabel);
            this.Controls.Add(this.an_aparitieTextBox);
            this.Controls.Add(edituraLabel);
            this.Controls.Add(this.edituraTextBox);
            this.Controls.Add(titluLabel);
            this.Controls.Add(this.titluTextBox);
            this.Controls.Add(autorLabel);
            this.Controls.Add(this.autorTextBox);
            this.Controls.Add(this.cartiBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iesireF2);
            this.Name = "Lista_cartilor";
            this.Text = "Lista_cartilor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Lista_cartilor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atestatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingNavigator)).EndInit();
            this.cartiBindingNavigator.ResumeLayout(false);
            this.cartiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cartiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iesireF2;
        private System.Windows.Forms.Label label1;
        private atestatDataSet atestatDataSet;
        private System.Windows.Forms.BindingSource cartiBindingSource;
        private atestatDataSetTableAdapters.CartiTableAdapter cartiTableAdapter;
        private atestatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator cartiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton cartiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox titluTextBox;
        private System.Windows.Forms.TextBox edituraTextBox;
        private System.Windows.Forms.TextBox an_aparitieTextBox;
        private System.Windows.Forms.TextBox nr_volumTextBox;
        private System.Windows.Forms.DataGridView cartiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}
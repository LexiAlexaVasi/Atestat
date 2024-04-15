namespace Biblioteca_Lexi
{
    partial class Imprumuturi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imprumuturi));
            System.Windows.Forms.Label data_imprumutLabel;
            System.Windows.Forms.Label data_inapoiereLabel;
            System.Windows.Forms.Label id_carteLabel;
            System.Windows.Forms.Label id_clientLabel;
            this.iesireF4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.atestatDataSet = new Biblioteca_Lexi.atestatDataSet();
            this.imprumuturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imprumuturiTableAdapter = new Biblioteca_Lexi.atestatDataSetTableAdapters.ImprumuturiTableAdapter();
            this.tableAdapterManager = new Biblioteca_Lexi.atestatDataSetTableAdapters.TableAdapterManager();
            this.imprumuturiBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.imprumuturiBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.data_imprumutTextBox = new System.Windows.Forms.TextBox();
            this.data_inapoiereTextBox = new System.Windows.Forms.TextBox();
            this.id_carteTextBox = new System.Windows.Forms.TextBox();
            this.id_clientTextBox = new System.Windows.Forms.TextBox();
            this.imprumuturiDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            data_imprumutLabel = new System.Windows.Forms.Label();
            data_inapoiereLabel = new System.Windows.Forms.Label();
            id_carteLabel = new System.Windows.Forms.Label();
            id_clientLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.atestatDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingNavigator)).BeginInit();
            this.imprumuturiBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iesireF4
            // 
            this.iesireF4.BackColor = System.Drawing.Color.Black;
            this.iesireF4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("iesireF4.BackgroundImage")));
            this.iesireF4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.iesireF4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iesireF4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.iesireF4.Location = new System.Drawing.Point(1120, 522);
            this.iesireF4.Name = "iesireF4";
            this.iesireF4.Size = new System.Drawing.Size(153, 106);
            this.iesireF4.TabIndex = 1;
            this.iesireF4.UseVisualStyleBackColor = false;
            this.iesireF4.Click += new System.EventHandler(this.iesireF4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 33F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(469, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(402, 54);
            this.label1.TabIndex = 2;
            this.label1.Text = "Lista împrumuturilor";
            // 
            // atestatDataSet
            // 
            this.atestatDataSet.DataSetName = "atestatDataSet";
            this.atestatDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // imprumuturiBindingSource
            // 
            this.imprumuturiBindingSource.DataMember = "Imprumuturi";
            this.imprumuturiBindingSource.DataSource = this.atestatDataSet;
            // 
            // imprumuturiTableAdapter
            // 
            this.imprumuturiTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CartiTableAdapter = null;
            this.tableAdapterManager.ClientiTableAdapter = null;
            this.tableAdapterManager.ImprumuturiTableAdapter = this.imprumuturiTableAdapter;
            this.tableAdapterManager.ProbaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Biblioteca_Lexi.atestatDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // imprumuturiBindingNavigator
            // 
            this.imprumuturiBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.imprumuturiBindingNavigator.BindingSource = this.imprumuturiBindingSource;
            this.imprumuturiBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.imprumuturiBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.imprumuturiBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.imprumuturiBindingNavigatorSaveItem});
            this.imprumuturiBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.imprumuturiBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.imprumuturiBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.imprumuturiBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.imprumuturiBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.imprumuturiBindingNavigator.Name = "imprumuturiBindingNavigator";
            this.imprumuturiBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.imprumuturiBindingNavigator.Size = new System.Drawing.Size(1358, 25);
            this.imprumuturiBindingNavigator.TabIndex = 3;
            this.imprumuturiBindingNavigator.Text = "bindingNavigator1";
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
            // imprumuturiBindingNavigatorSaveItem
            // 
            this.imprumuturiBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.imprumuturiBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("imprumuturiBindingNavigatorSaveItem.Image")));
            this.imprumuturiBindingNavigatorSaveItem.Name = "imprumuturiBindingNavigatorSaveItem";
            this.imprumuturiBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.imprumuturiBindingNavigatorSaveItem.Text = "Save Data";
            this.imprumuturiBindingNavigatorSaveItem.Click += new System.EventHandler(this.imprumuturiBindingNavigatorSaveItem_Click);
            // 
            // data_imprumutLabel
            // 
            data_imprumutLabel.AutoSize = true;
            data_imprumutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_imprumutLabel.Location = new System.Drawing.Point(100, 153);
            data_imprumutLabel.Name = "data_imprumutLabel";
            data_imprumutLabel.Size = new System.Drawing.Size(191, 25);
            data_imprumutLabel.TabIndex = 3;
            data_imprumutLabel.Text = "Data împrumutului:";
            // 
            // data_imprumutTextBox
            // 
            this.data_imprumutTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imprumuturiBindingSource, "Data_imprumut", true));
            this.data_imprumutTextBox.Location = new System.Drawing.Point(297, 135);
            this.data_imprumutTextBox.Multiline = true;
            this.data_imprumutTextBox.Name = "data_imprumutTextBox";
            this.data_imprumutTextBox.Size = new System.Drawing.Size(326, 62);
            this.data_imprumutTextBox.TabIndex = 4;
            // 
            // data_inapoiereLabel
            // 
            data_inapoiereLabel.AutoSize = true;
            data_inapoiereLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_inapoiereLabel.Location = new System.Drawing.Point(135, 291);
            data_inapoiereLabel.Name = "data_inapoiereLabel";
            data_inapoiereLabel.Size = new System.Drawing.Size(156, 25);
            data_inapoiereLabel.TabIndex = 5;
            data_inapoiereLabel.Text = "Data înapoierii:";
            // 
            // data_inapoiereTextBox
            // 
            this.data_inapoiereTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imprumuturiBindingSource, "Data_inapoiere", true));
            this.data_inapoiereTextBox.Location = new System.Drawing.Point(297, 269);
            this.data_inapoiereTextBox.Multiline = true;
            this.data_inapoiereTextBox.Name = "data_inapoiereTextBox";
            this.data_inapoiereTextBox.Size = new System.Drawing.Size(326, 64);
            this.data_inapoiereTextBox.TabIndex = 6;
            // 
            // id_carteLabel
            // 
            id_carteLabel.AutoSize = true;
            id_carteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_carteLabel.Location = new System.Drawing.Point(711, 153);
            id_carteLabel.Name = "id_carteLabel";
            id_carteLabel.Size = new System.Drawing.Size(89, 25);
            id_carteLabel.TabIndex = 7;
            id_carteLabel.Text = "Id carte:";
            // 
            // id_carteTextBox
            // 
            this.id_carteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imprumuturiBindingSource, "Id_carte", true));
            this.id_carteTextBox.Location = new System.Drawing.Point(806, 135);
            this.id_carteTextBox.Multiline = true;
            this.id_carteTextBox.Name = "id_carteTextBox";
            this.id_carteTextBox.Size = new System.Drawing.Size(265, 62);
            this.id_carteTextBox.TabIndex = 8;
            // 
            // id_clientLabel
            // 
            id_clientLabel.AutoSize = true;
            id_clientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_clientLabel.Location = new System.Drawing.Point(711, 291);
            id_clientLabel.Name = "id_clientLabel";
            id_clientLabel.Size = new System.Drawing.Size(92, 25);
            id_clientLabel.TabIndex = 9;
            id_clientLabel.Text = "Id client:";
            // 
            // id_clientTextBox
            // 
            this.id_clientTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.imprumuturiBindingSource, "Id_client", true));
            this.id_clientTextBox.Location = new System.Drawing.Point(806, 266);
            this.id_clientTextBox.Multiline = true;
            this.id_clientTextBox.Name = "id_clientTextBox";
            this.id_clientTextBox.Size = new System.Drawing.Size(265, 67);
            this.id_clientTextBox.TabIndex = 10;
            // 
            // imprumuturiDataGridView
            // 
            this.imprumuturiDataGridView.AutoGenerateColumns = false;
            this.imprumuturiDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imprumuturiDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.imprumuturiDataGridView.DataSource = this.imprumuturiBindingSource;
            this.imprumuturiDataGridView.Location = new System.Drawing.Point(105, 436);
            this.imprumuturiDataGridView.Name = "imprumuturiDataGridView";
            this.imprumuturiDataGridView.Size = new System.Drawing.Size(746, 220);
            this.imprumuturiDataGridView.TabIndex = 11;
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Data_imprumut";
            this.dataGridViewTextBoxColumn2.HeaderText = "Data_imprumut";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Data_inapoiere";
            this.dataGridViewTextBoxColumn3.HeaderText = "Data_inapoiere";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Id_carte";
            this.dataGridViewTextBoxColumn4.HeaderText = "Id_carte";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Id_client";
            this.dataGridViewTextBoxColumn5.HeaderText = "Id_client";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // Imprumuturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1358, 683);
            this.Controls.Add(this.imprumuturiDataGridView);
            this.Controls.Add(id_clientLabel);
            this.Controls.Add(this.id_clientTextBox);
            this.Controls.Add(id_carteLabel);
            this.Controls.Add(this.id_carteTextBox);
            this.Controls.Add(data_inapoiereLabel);
            this.Controls.Add(this.data_inapoiereTextBox);
            this.Controls.Add(data_imprumutLabel);
            this.Controls.Add(this.data_imprumutTextBox);
            this.Controls.Add(this.imprumuturiBindingNavigator);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iesireF4);
            this.Name = "Imprumuturi";
            this.Text = "Imprumuturi";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Imprumuturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.atestatDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingNavigator)).EndInit();
            this.imprumuturiBindingNavigator.ResumeLayout(false);
            this.imprumuturiBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button iesireF4;
        private System.Windows.Forms.Label label1;
        private atestatDataSet atestatDataSet;
        private System.Windows.Forms.BindingSource imprumuturiBindingSource;
        private atestatDataSetTableAdapters.ImprumuturiTableAdapter imprumuturiTableAdapter;
        private atestatDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator imprumuturiBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton imprumuturiBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox data_imprumutTextBox;
        private System.Windows.Forms.TextBox data_inapoiereTextBox;
        private System.Windows.Forms.TextBox id_carteTextBox;
        private System.Windows.Forms.TextBox id_clientTextBox;
        private System.Windows.Forms.DataGridView imprumuturiDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}
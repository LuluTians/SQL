﻿namespace ASS2
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
            this.purchaseReportBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseReportBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adventureWorks2012DataSet = new ASS2.AdventureWorks2012DataSet();
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
            this.purchaseReportBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.purchaseReportDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.yearText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.monthText = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.purchaseReportTableAdapter = new ASS2.AdventureWorks2012DataSetTableAdapters.PurchaseReportTableAdapter();
            this.tableAdapterManager = new ASS2.AdventureWorks2012DataSetTableAdapters.TableAdapterManager();
            this.queriesTableAdapter1 = new ASS2.AdventureWorks2012DataSetTableAdapters.QueriesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportBindingNavigator)).BeginInit();
            this.purchaseReportBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2012DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // purchaseReportBindingNavigator
            // 
            this.purchaseReportBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.purchaseReportBindingNavigator.BindingSource = this.purchaseReportBindingSource;
            this.purchaseReportBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.purchaseReportBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.purchaseReportBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.purchaseReportBindingNavigatorSaveItem});
            this.purchaseReportBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.purchaseReportBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.purchaseReportBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.purchaseReportBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.purchaseReportBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.purchaseReportBindingNavigator.Name = "purchaseReportBindingNavigator";
            this.purchaseReportBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.purchaseReportBindingNavigator.Size = new System.Drawing.Size(1534, 25);
            this.purchaseReportBindingNavigator.TabIndex = 0;
            this.purchaseReportBindingNavigator.Text = "bindingNavigator1";
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
            // purchaseReportBindingSource
            // 
            this.purchaseReportBindingSource.DataMember = "PurchaseReport";
            this.purchaseReportBindingSource.DataSource = this.adventureWorks2012DataSet;
            // 
            // adventureWorks2012DataSet
            // 
            this.adventureWorks2012DataSet.DataSetName = "AdventureWorks2012DataSet";
            this.adventureWorks2012DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // purchaseReportBindingNavigatorSaveItem
            // 
            this.purchaseReportBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.purchaseReportBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("purchaseReportBindingNavigatorSaveItem.Image")));
            this.purchaseReportBindingNavigatorSaveItem.Name = "purchaseReportBindingNavigatorSaveItem";
            this.purchaseReportBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.purchaseReportBindingNavigatorSaveItem.Text = "Save Data";
            this.purchaseReportBindingNavigatorSaveItem.Click += new System.EventHandler(this.purchaseReportBindingNavigatorSaveItem_Click);
            // 
            // purchaseReportDataGridView
            // 
            this.purchaseReportDataGridView.AutoGenerateColumns = false;
            this.purchaseReportDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseReportDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.purchaseReportDataGridView.DataSource = this.purchaseReportBindingSource;
            this.purchaseReportDataGridView.Location = new System.Drawing.Point(89, 153);
            this.purchaseReportDataGridView.Name = "purchaseReportDataGridView";
            this.purchaseReportDataGridView.Size = new System.Drawing.Size(645, 259);
            this.purchaseReportDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PurchaseReportID";
            this.dataGridViewTextBoxColumn1.HeaderText = "PurchaseReportID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "PurchaseOrderID";
            this.dataGridViewTextBoxColumn2.HeaderText = "PurchaseOrderID";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ProductNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "ProductNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "OrderQty";
            this.dataGridViewTextBoxColumn4.HeaderText = "OrderQty";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "UnitPrice";
            this.dataGridViewTextBoxColumn5.HeaderText = "UnitPrice";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "LineTotal";
            this.dataGridViewTextBoxColumn6.HeaderText = "LineTotal";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(151, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Year";
            // 
            // yearText
            // 
            this.yearText.Location = new System.Drawing.Point(245, 63);
            this.yearText.Name = "yearText";
            this.yearText.Size = new System.Drawing.Size(100, 20);
            this.yearText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Enter Month";
            // 
            // monthText
            // 
            this.monthText.Location = new System.Drawing.Point(525, 63);
            this.monthText.Name = "monthText";
            this.monthText.Size = new System.Drawing.Size(100, 20);
            this.monthText.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(347, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Display Report";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // purchaseReportTableAdapter
            // 
            this.purchaseReportTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProductTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderDetailTableAdapter = null;
            this.tableAdapterManager.PurchaseOrderHeaderTableAdapter = null;
            this.tableAdapterManager.PurchaseReportTableAdapter = this.purchaseReportTableAdapter;
            this.tableAdapterManager.UpdateOrder = ASS2.AdventureWorks2012DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1534, 899);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.monthText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.yearText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.purchaseReportDataGridView);
            this.Controls.Add(this.purchaseReportBindingNavigator);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportBindingNavigator)).EndInit();
            this.purchaseReportBindingNavigator.ResumeLayout(false);
            this.purchaseReportBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adventureWorks2012DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseReportDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AdventureWorks2012DataSet adventureWorks2012DataSet;
        private System.Windows.Forms.BindingSource purchaseReportBindingSource;
        private AdventureWorks2012DataSetTableAdapters.PurchaseReportTableAdapter purchaseReportTableAdapter;
        private AdventureWorks2012DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator purchaseReportBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton purchaseReportBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView purchaseReportDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox yearText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox monthText;
        private System.Windows.Forms.Button button1;
        private AdventureWorks2012DataSetTableAdapters.QueriesTableAdapter queriesTableAdapter1;
    }
}


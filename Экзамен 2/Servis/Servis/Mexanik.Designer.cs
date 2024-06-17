namespace Servis
{
    partial class Mexanik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mexanik));
            this.avtoServis_databaseDataSet = new Servis.AvtoServis_databaseDataSet();
            this.orderuserlistBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.orderuserlistTableAdapter = new Servis.AvtoServis_databaseDataSetTableAdapters.orderuserlistTableAdapter();
            this.tableAdapterManager = new Servis.AvtoServis_databaseDataSetTableAdapters.TableAdapterManager();
            this.orderuserlistBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.orderuserlistBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel3 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.avtoServis_databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserlistBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserlistBindingNavigator)).BeginInit();
            this.orderuserlistBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // avtoServis_databaseDataSet
            // 
            this.avtoServis_databaseDataSet.DataSetName = "AvtoServis_databaseDataSet";
            this.avtoServis_databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // orderuserlistBindingSource
            // 
            this.orderuserlistBindingSource.DataMember = "orderuserlist";
            this.orderuserlistBindingSource.DataSource = this.avtoServis_databaseDataSet;
            // 
            // orderuserlistTableAdapter
            // 
            this.orderuserlistTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.orderTableAdapter = null;
            this.tableAdapterManager.orderuserlistTableAdapter = this.orderuserlistTableAdapter;
            this.tableAdapterManager.shiftTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Servis.AvtoServis_databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.userlistTableAdapter = null;
            this.tableAdapterManager.userroleTableAdapter = null;
            this.tableAdapterManager.userTableAdapter = null;
            // 
            // orderuserlistBindingNavigator
            // 
            this.orderuserlistBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderuserlistBindingNavigator.BindingSource = this.orderuserlistBindingSource;
            this.orderuserlistBindingNavigator.CountItem = null;
            this.orderuserlistBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderuserlistBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.orderuserlistBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.bindingNavigatorAddNewItem,
            this.toolStripSeparator2,
            this.toolStripLabel2,
            this.bindingNavigatorDeleteItem,
            this.toolStripSeparator1,
            this.toolStripLabel3,
            this.orderuserlistBindingNavigatorSaveItem});
            this.orderuserlistBindingNavigator.Location = new System.Drawing.Point(38, 8);
            this.orderuserlistBindingNavigator.MoveFirstItem = null;
            this.orderuserlistBindingNavigator.MoveLastItem = null;
            this.orderuserlistBindingNavigator.MoveNextItem = null;
            this.orderuserlistBindingNavigator.MovePreviousItem = null;
            this.orderuserlistBindingNavigator.Name = "orderuserlistBindingNavigator";
            this.orderuserlistBindingNavigator.PositionItem = null;
            this.orderuserlistBindingNavigator.Size = new System.Drawing.Size(300, 25);
            this.orderuserlistBindingNavigator.TabIndex = 0;
            this.orderuserlistBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // orderuserlistBindingNavigatorSaveItem
            // 
            this.orderuserlistBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderuserlistBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderuserlistBindingNavigatorSaveItem.Image")));
            this.orderuserlistBindingNavigatorSaveItem.Name = "orderuserlistBindingNavigatorSaveItem";
            this.orderuserlistBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.orderuserlistBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.orderuserlistBindingNavigatorSaveItem.Click += new System.EventHandler(this.orderuserlistBindingNavigatorSaveItem_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(59, 22);
            this.toolStripLabel1.Text = "Добавить";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(51, 22);
            this.toolStripLabel2.Text = "Удалить";
            // 
            // toolStripLabel3
            // 
            this.toolStripLabel3.Name = "toolStripLabel3";
            this.toolStripLabel3.Size = new System.Drawing.Size(66, 22);
            this.toolStripLabel3.Text = "Сохранить";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Mexanik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(375, 577);
            this.Controls.Add(this.orderuserlistBindingNavigator);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Mexanik";
            this.Text = "Mexanik";
            this.Load += new System.EventHandler(this.Mexanik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.avtoServis_databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserlistBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderuserlistBindingNavigator)).EndInit();
            this.orderuserlistBindingNavigator.ResumeLayout(false);
            this.orderuserlistBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AvtoServis_databaseDataSet avtoServis_databaseDataSet;
        private System.Windows.Forms.BindingSource orderuserlistBindingSource;
        private AvtoServis_databaseDataSetTableAdapters.orderuserlistTableAdapter orderuserlistTableAdapter;
        private AvtoServis_databaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator orderuserlistBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton orderuserlistBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel3;
    }
}
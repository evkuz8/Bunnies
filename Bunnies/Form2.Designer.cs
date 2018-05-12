namespace Bunnies
{
    partial class Form2
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
            System.Windows.Forms.Label someArticleLabel;
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.someImagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.someDBDataSet1 = new Bunnies.SomeDBDataSet1();
            this.rolesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rolesTableAdapter = new Bunnies.SomeDBDataSet1TableAdapters.RolesTableAdapter();
            this.someImagesTableAdapter = new Bunnies.SomeDBDataSet1TableAdapters.SomeImagesTableAdapter();
            this.someImagesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new Bunnies.SomeDBDataSet1TableAdapters.TableAdapterManager();
            this.someDBDataSet = new Bunnies.SomeDBDataSet();
            this.someDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.someDBDataSetBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.someDBDataSetBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.someImagesBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.someImagesTableAdapter1 = new Bunnies.SomeDBDataSetTableAdapters.SomeImagesTableAdapter();
            this.tableAdapterManager1 = new Bunnies.SomeDBDataSetTableAdapters.TableAdapterManager();
            this.someDBDataSet2 = new Bunnies.SomeDBDataSet2();
            this.someImagesBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.someImagesTableAdapter2 = new Bunnies.SomeDBDataSet2TableAdapters.SomeImagesTableAdapter();
            this.tableAdapterManager2 = new Bunnies.SomeDBDataSet2TableAdapters.TableAdapterManager();
            this.someArticleComboBox = new System.Windows.Forms.ComboBox();
            someArticleLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSetBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSetBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(32, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(337, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "LOAD IMAGES TO DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(310, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "show";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(32, 31);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(373, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // someImagesBindingSource
            // 
            this.someImagesBindingSource.DataMember = "SomeImages";
            this.someImagesBindingSource.DataSource = this.someDBDataSet1;
            // 
            // someDBDataSet1
            // 
            this.someDBDataSet1.DataSetName = "SomeDBDataSet1";
            this.someDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rolesBindingSource
            // 
            this.rolesBindingSource.DataMember = "Roles";
            this.rolesBindingSource.DataSource = this.someDBDataSet1;
            // 
            // rolesTableAdapter
            // 
            this.rolesTableAdapter.ClearBeforeFill = true;
            // 
            // someImagesTableAdapter
            // 
            this.someImagesTableAdapter.ClearBeforeFill = true;
            // 
            // someImagesBindingSource1
            // 
            this.someImagesBindingSource1.DataMember = "SomeImages";
            this.someImagesBindingSource1.DataSource = this.someDBDataSet1;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HeroesTableAdapter = null;
            this.tableAdapterManager.RacesTableAdapter = null;
            this.tableAdapterManager.RolesTableAdapter = this.rolesTableAdapter;
            this.tableAdapterManager.SomeImagesTableAdapter = this.someImagesTableAdapter;
            this.tableAdapterManager.UpdateOrder = Bunnies.SomeDBDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsersTableAdapter = null;
            // 
            // someDBDataSet
            // 
            this.someDBDataSet.DataSetName = "SomeDBDataSet";
            this.someDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // someDBDataSetBindingSource
            // 
            this.someDBDataSetBindingSource.DataSource = this.someDBDataSet;
            this.someDBDataSetBindingSource.Position = 0;
            // 
            // someDBDataSetBindingSource1
            // 
            this.someDBDataSetBindingSource1.DataSource = this.someDBDataSet;
            this.someDBDataSetBindingSource1.Position = 0;
            // 
            // someDBDataSetBindingSource2
            // 
            this.someDBDataSetBindingSource2.DataSource = this.someDBDataSet;
            this.someDBDataSetBindingSource2.Position = 0;
            // 
            // someImagesBindingSource2
            // 
            this.someImagesBindingSource2.DataMember = "SomeImages";
            this.someImagesBindingSource2.DataSource = this.someDBDataSet;
            // 
            // someImagesTableAdapter1
            // 
            this.someImagesTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.HeroesTableAdapter = null;
            this.tableAdapterManager1.RacesTableAdapter = null;
            this.tableAdapterManager1.RolesTableAdapter = null;
            this.tableAdapterManager1.SomeImagesTableAdapter = this.someImagesTableAdapter1;
            this.tableAdapterManager1.UpdateOrder = Bunnies.SomeDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.UsersTableAdapter = null;
            // 
            // someDBDataSet2
            // 
            this.someDBDataSet2.DataSetName = "SomeDBDataSet2";
            this.someDBDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // someImagesBindingSource3
            // 
            this.someImagesBindingSource3.DataMember = "SomeImages";
            this.someImagesBindingSource3.DataSource = this.someDBDataSet2;
            // 
            // someImagesTableAdapter2
            // 
            this.someImagesTableAdapter2.ClearBeforeFill = true;
            // 
            // tableAdapterManager2
            // 
            this.tableAdapterManager2.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager2.HeroesTableAdapter = null;
            this.tableAdapterManager2.RacesTableAdapter = null;
            this.tableAdapterManager2.RolesTableAdapter = null;
            this.tableAdapterManager2.SomeImagesTableAdapter = this.someImagesTableAdapter2;
            this.tableAdapterManager2.UpdateOrder = Bunnies.SomeDBDataSet2TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager2.UsersTableAdapter = null;
            // 
            // someArticleLabel
            // 
            someArticleLabel.AutoSize = true;
            someArticleLabel.Location = new System.Drawing.Point(49, 208);
            someArticleLabel.Name = "someArticleLabel";
            someArticleLabel.Size = new System.Drawing.Size(69, 13);
            someArticleLabel.TabIndex = 3;
            someArticleLabel.Text = "Some Article:";
            // 
            // someArticleComboBox
            // 
            this.someArticleComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.someImagesBindingSource3, "SomeArticle", true));
            this.someArticleComboBox.FormattingEnabled = true;
            this.someArticleComboBox.Location = new System.Drawing.Point(124, 205);
            this.someArticleComboBox.Name = "someArticleComboBox";
            this.someArticleComboBox.Size = new System.Drawing.Size(121, 21);
            this.someArticleComboBox.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 310);
            this.Controls.Add(someArticleLabel);
            this.Controls.Add(this.someArticleComboBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rolesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSetBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSetBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someDBDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.someImagesBindingSource3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource someDBDataSetBindingSource;
        private SomeDBDataSet someDBDataSet;
        private System.Windows.Forms.BindingSource someDBDataSetBindingSource1;
        private System.Windows.Forms.BindingSource someDBDataSetBindingSource2;
        private SomeDBDataSet1 someDBDataSet1;
        private System.Windows.Forms.BindingSource rolesBindingSource;
        private SomeDBDataSet1TableAdapters.RolesTableAdapter rolesTableAdapter;
        private System.Windows.Forms.BindingSource someImagesBindingSource;
        private SomeDBDataSet1TableAdapters.SomeImagesTableAdapter someImagesTableAdapter;
        private System.Windows.Forms.BindingSource someImagesBindingSource1;
        private SomeDBDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource someImagesBindingSource2;
        private SomeDBDataSetTableAdapters.SomeImagesTableAdapter someImagesTableAdapter1;
        private SomeDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private SomeDBDataSet2 someDBDataSet2;
        private System.Windows.Forms.BindingSource someImagesBindingSource3;
        private SomeDBDataSet2TableAdapters.SomeImagesTableAdapter someImagesTableAdapter2;
        private SomeDBDataSet2TableAdapters.TableAdapterManager tableAdapterManager2;
        private System.Windows.Forms.ComboBox someArticleComboBox;
    }
}
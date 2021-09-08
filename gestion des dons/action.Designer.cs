namespace gestion_des_dons
{
    partial class action
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donsDataSet5 = new gestion_des_dons.DonsDataSet5();
            this.vehiculeTableAdapter = new gestion_des_dons.DonsDataSet5TableAdapters.VehiculeTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroComboBox2 = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton3 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuDatepicker2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.metroComboBox4 = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.transporteurTableAdapter = new gestion_des_dons.DonsDataSet5TableAdapters.TransporteurTableAdapter();
            this.tableAdapterManager = new gestion_des_dons.DonsDataSet5TableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(56, 57);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel2.TabIndex = 9;
            this.bunifuCustomLabel2.Text = "ID Don:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.metroComboBox1.DropDownHeight = 90;
            this.metroComboBox1.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox1.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.IntegralHeight = false;
            this.metroComboBox1.ItemHeight = 19;
            this.metroComboBox1.Location = new System.Drawing.Point(195, 57);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(143, 25);
            this.metroComboBox1.TabIndex = 11;
            this.metroComboBox1.UseSelectable = true;
            // 
            // vehiculeBindingSource
            // 
            this.vehiculeBindingSource.DataMember = "Vehicule";
            this.vehiculeBindingSource.DataSource = this.donsDataSet5;
            // 
            // donsDataSet5
            // 
            this.donsDataSet5.DataSetName = "DonsDataSet5";
            this.donsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiculeTableAdapter
            // 
            this.vehiculeTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.metroComboBox2);
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.bunifuFlatButton3);
            this.panel1.Controls.Add(this.bunifuDatepicker2);
            this.panel1.Controls.Add(this.metroComboBox4);
            this.panel1.Controls.Add(this.metroComboBox3);
            this.panel1.Controls.Add(this.bunifuCustomLabel5);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Location = new System.Drawing.Point(36, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 279);
            this.panel1.TabIndex = 30;
            this.panel1.Visible = false;
            // 
            // metroComboBox2
            // 
            this.metroComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.metroComboBox2.DataSource = this.donsDataSet5;
            this.metroComboBox2.DisplayMember = "Transporteur.codeTransporteur";
            this.metroComboBox2.DropDownHeight = 90;
            this.metroComboBox2.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox2.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.metroComboBox2.FormattingEnabled = true;
            this.metroComboBox2.IntegralHeight = false;
            this.metroComboBox2.ItemHeight = 19;
            this.metroComboBox2.Location = new System.Drawing.Point(159, 143);
            this.metroComboBox2.Name = "metroComboBox2";
            this.metroComboBox2.Size = new System.Drawing.Size(143, 25);
            this.metroComboBox2.TabIndex = 39;
            this.metroComboBox2.UseSelectable = true;
            this.metroComboBox2.ValueMember = "Transporteur.codeTransporteur";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 144);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(95, 17);
            this.bunifuCustomLabel1.TabIndex = 38;
            this.bunifuCustomLabel1.Text = "Transporteur:";
            // 
            // bunifuFlatButton3
            // 
            this.bunifuFlatButton3.Activecolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton3.BorderRadius = 0;
            this.bunifuFlatButton3.ButtonText = "Ajouter";
            this.bunifuFlatButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton3.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton3.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton3.Iconimage = null;
            this.bunifuFlatButton3.Iconimage_right = null;
            this.bunifuFlatButton3.Iconimage_right_Selected = null;
            this.bunifuFlatButton3.Iconimage_Selected = null;
            this.bunifuFlatButton3.IconMarginLeft = 0;
            this.bunifuFlatButton3.IconMarginRight = 0;
            this.bunifuFlatButton3.IconRightVisible = true;
            this.bunifuFlatButton3.IconRightZoom = 0D;
            this.bunifuFlatButton3.IconVisible = true;
            this.bunifuFlatButton3.IconZoom = 90D;
            this.bunifuFlatButton3.IsTab = false;
            this.bunifuFlatButton3.Location = new System.Drawing.Point(506, 223);
            this.bunifuFlatButton3.Name = "bunifuFlatButton3";
            this.bunifuFlatButton3.Normalcolor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton3.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton3.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton3.selected = false;
            this.bunifuFlatButton3.Size = new System.Drawing.Size(118, 36);
            this.bunifuFlatButton3.TabIndex = 33;
            this.bunifuFlatButton3.Text = "Ajouter";
            this.bunifuFlatButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton3.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton3.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton3.Click += new System.EventHandler(this.bunifuFlatButton3_Click);
            // 
            // bunifuDatepicker2
            // 
            this.bunifuDatepicker2.BackColor = System.Drawing.Color.White;
            this.bunifuDatepicker2.BorderRadius = 0;
            this.bunifuDatepicker2.ForeColor = System.Drawing.Color.Gray;
            this.bunifuDatepicker2.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker2.FormatCustom = null;
            this.bunifuDatepicker2.Location = new System.Drawing.Point(159, 32);
            this.bunifuDatepicker2.Name = "bunifuDatepicker2";
            this.bunifuDatepicker2.Size = new System.Drawing.Size(278, 28);
            this.bunifuDatepicker2.TabIndex = 37;
            this.bunifuDatepicker2.Value = new System.DateTime(2018, 5, 22, 13, 51, 51, 689);
            // 
            // metroComboBox4
            // 
            this.metroComboBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.metroComboBox4.DropDownHeight = 90;
            this.metroComboBox4.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox4.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.metroComboBox4.FormattingEnabled = true;
            this.metroComboBox4.IntegralHeight = false;
            this.metroComboBox4.ItemHeight = 19;
            this.metroComboBox4.Items.AddRange(new object[] {
            "Garde Meuble",
            "Dépôt Vente"});
            this.metroComboBox4.Location = new System.Drawing.Point(159, 195);
            this.metroComboBox4.Name = "metroComboBox4";
            this.metroComboBox4.Size = new System.Drawing.Size(143, 25);
            this.metroComboBox4.TabIndex = 36;
            this.metroComboBox4.UseSelectable = true;
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.metroComboBox3.DataSource = this.vehiculeBindingSource;
            this.metroComboBox3.DisplayMember = "CodeVehicul";
            this.metroComboBox3.DropDownHeight = 90;
            this.metroComboBox3.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox3.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.IntegralHeight = false;
            this.metroComboBox3.ItemHeight = 19;
            this.metroComboBox3.Location = new System.Drawing.Point(159, 103);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(143, 25);
            this.metroComboBox3.TabIndex = 35;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.ValueMember = "CodeVehicul";
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(20, 195);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(115, 17);
            this.bunifuCustomLabel5.TabIndex = 34;
            this.bunifuCustomLabel5.Text = "lieu de stockage:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(20, 103);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(66, 17);
            this.bunifuCustomLabel4.TabIndex = 33;
            this.bunifuCustomLabel4.Text = "Véhicule:";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(20, 43);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(123, 17);
            this.bunifuCustomLabel3.TabIndex = 32;
            this.bunifuCustomLabel3.Text = "Date de transport:";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "accepter";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(469, 57);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(110, 25);
            this.bunifuFlatButton1.TabIndex = 31;
            this.bunifuFlatButton1.Text = "accepter";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "refuser";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(600, 57);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(110, 25);
            this.bunifuFlatButton2.TabIndex = 32;
            this.bunifuFlatButton2.Text = "refuser";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // transporteurTableAdapter
            // 
            this.transporteurTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdressTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DonateurTableAdapter = null;
            this.tableAdapterManager.MarqueVehiculeTableAdapter = null;
            this.tableAdapterManager.MembreTableAdapter = null;
            this.tableAdapterManager.OffreAcceptéTableAdapter = null;
            this.tableAdapterManager.offreTableAdapter = null;
            this.tableAdapterManager.TransporteurTableAdapter = this.transporteurTableAdapter;
            this.tableAdapterManager.UpdateOrder = gestion_des_dons.DonsDataSet5TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VehiculeTableAdapter = null;
            // 
            // action
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Name = "action";
            this.Size = new System.Drawing.Size(796, 368);
            this.Load += new System.EventHandler(this.action_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private DonsDataSet5 donsDataSet5;
        private DonsDataSet5TableAdapters.VehiculeTableAdapter vehiculeTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker2;
        private MetroFramework.Controls.MetroComboBox metroComboBox4;
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton3;
        private MetroFramework.Controls.MetroComboBox metroComboBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private DonsDataSet5TableAdapters.TransporteurTableAdapter transporteurTableAdapter;
        private DonsDataSet5TableAdapters.TableAdapterManager tableAdapterManager;
    }
}

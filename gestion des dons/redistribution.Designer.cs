namespace gestion_des_dons
{
    partial class redistribution
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
            this.metroComboBox3 = new MetroFramework.Controls.MetroComboBox();
            this.offreAcceptéBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donsDataSet5BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donsDataSet5 = new gestion_des_dons.DonsDataSet5();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.offreAcceptéTableAdapter = new gestion_des_dons.DonsDataSet5TableAdapters.OffreAcceptéTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.offreAcceptéBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox3
            // 
            this.metroComboBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.metroComboBox3.DataSource = this.offreAcceptéBindingSource;
            this.metroComboBox3.DisplayMember = "codeoffreaccept";
            this.metroComboBox3.DropDownHeight = 90;
            this.metroComboBox3.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.metroComboBox3.FontWeight = MetroFramework.MetroComboBoxWeight.Bold;
            this.metroComboBox3.FormattingEnabled = true;
            this.metroComboBox3.IntegralHeight = false;
            this.metroComboBox3.ItemHeight = 19;
            this.metroComboBox3.Location = new System.Drawing.Point(236, 23);
            this.metroComboBox3.Name = "metroComboBox3";
            this.metroComboBox3.Size = new System.Drawing.Size(143, 25);
            this.metroComboBox3.TabIndex = 40;
            this.metroComboBox3.UseSelectable = true;
            this.metroComboBox3.ValueMember = "codeoffreaccept";
            this.metroComboBox3.SelectedIndexChanged += new System.EventHandler(this.metroComboBox3_SelectedIndexChanged);
            // 
            // offreAcceptéBindingSource
            // 
            this.offreAcceptéBindingSource.DataMember = "OffreAccepté";
            this.offreAcceptéBindingSource.DataSource = this.donsDataSet5BindingSource;
            // 
            // donsDataSet5BindingSource
            // 
            this.donsDataSet5BindingSource.DataSource = this.donsDataSet5;
            this.donsDataSet5BindingSource.Position = 0;
            // 
            // donsDataSet5
            // 
            this.donsDataSet5.DataSetName = "DonsDataSet5";
            this.donsDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(137, 24);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(55, 17);
            this.bunifuCustomLabel4.TabIndex = 39;
            this.bunifuCustomLabel4.Text = "ID Don:";
            // 
            // offreAcceptéTableAdapter
            // 
            this.offreAcceptéTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(70, 106);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 348);
            this.panel1.TabIndex = 43;
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
            this.metroComboBox1.Items.AddRange(new object[] {
            "dépôt-vente",
            "vente bi-annuelle",
            "Don direct"});
            this.metroComboBox1.Location = new System.Drawing.Point(236, 66);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(143, 25);
            this.metroComboBox1.TabIndex = 45;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.SelectedIndexChanged += new System.EventHandler(this.metroComboBox1_SelectedIndexChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(137, 67);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(83, 17);
            this.bunifuCustomLabel1.TabIndex = 44;
            this.bunifuCustomLabel1.Text = "Destination:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // redistribution
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroComboBox1);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.metroComboBox3);
            this.Controls.Add(this.bunifuCustomLabel4);
            this.Name = "redistribution";
            this.Size = new System.Drawing.Size(1031, 473);
            this.Load += new System.EventHandler(this.redistribution_Load);
            ((System.ComponentModel.ISupportInitialize)(this.offreAcceptéBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroComboBox metroComboBox3;
        private System.Windows.Forms.BindingSource offreAcceptéBindingSource;
        private System.Windows.Forms.BindingSource donsDataSet5BindingSource;
        private DonsDataSet5 donsDataSet5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private DonsDataSet5TableAdapters.OffreAcceptéTableAdapter offreAcceptéTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}

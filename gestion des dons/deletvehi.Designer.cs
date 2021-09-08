namespace gestion_des_dons
{
    partial class deletvehi
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
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label1 = new System.Windows.Forms.Label();
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.vehiculeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donsDataSet5 = new gestion_des_dons.DonsDataSet5();
            this.vehiculeTableAdapter = new gestion_des_dons.DonsDataSet5TableAdapters.VehiculeTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "Supprimer";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(334, 187);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(110, 32);
            this.bunifuFlatButton1.TabIndex = 9;
            this.bunifuFlatButton1.Text = "Supprimer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 97);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "ID Véhicule:";
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.vehiculeBindingSource;
            this.metroComboBox1.DisplayMember = "CodeVehicul";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(213, 94);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 7;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "CodeVehicul";
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
            // deletvehi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "deletvehi";
            this.Size = new System.Drawing.Size(657, 291);
            this.Load += new System.EventHandler(this.deletvehi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehiculeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource vehiculeBindingSource;
        private DonsDataSet5 donsDataSet5;
        private DonsDataSet5TableAdapters.VehiculeTableAdapter vehiculeTableAdapter;
    }
}

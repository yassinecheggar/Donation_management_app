namespace gestion_des_dons
{
    partial class deletTrans
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
            this.metroComboBox1 = new MetroFramework.Controls.MetroComboBox();
            this.transporteurBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.donsDataSet3 = new gestion_des_dons.DonsDataSet3();
            this.transporteurTableAdapter = new gestion_des_dons.DonsDataSet3TableAdapters.TransporteurTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.transporteurBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // metroComboBox1
            // 
            this.metroComboBox1.DataSource = this.transporteurBindingSource;
            this.metroComboBox1.DisplayMember = "codeTransporteur";
            this.metroComboBox1.FormattingEnabled = true;
            this.metroComboBox1.ItemHeight = 23;
            this.metroComboBox1.Location = new System.Drawing.Point(157, 101);
            this.metroComboBox1.Name = "metroComboBox1";
            this.metroComboBox1.Size = new System.Drawing.Size(121, 29);
            this.metroComboBox1.TabIndex = 0;
            this.metroComboBox1.UseSelectable = true;
            this.metroComboBox1.ValueMember = "codeTransporteur";
            // 
            // transporteurBindingSource
            // 
            this.transporteurBindingSource.DataMember = "Transporteur";
            this.transporteurBindingSource.DataSource = this.donsDataSet3;
            // 
            // donsDataSet3
            // 
            this.donsDataSet3.DataSetName = "DonsDataSet3";
            this.donsDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transporteurTableAdapter
            // 
            this.transporteurTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Transporteur:";
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
            this.bunifuFlatButton1.Location = new System.Drawing.Point(278, 194);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.SystemColors.AppWorkspace;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(110, 32);
            this.bunifuFlatButton1.TabIndex = 6;
            this.bunifuFlatButton1.Text = "Supprimer";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // deletTrans
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.metroComboBox1);
            this.Name = "deletTrans";
            this.Size = new System.Drawing.Size(593, 254);
            this.Load += new System.EventHandler(this.deletTrans_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transporteurBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.donsDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroComboBox metroComboBox1;
        private System.Windows.Forms.BindingSource transporteurBindingSource;
        private DonsDataSet3 donsDataSet3;
        private DonsDataSet3TableAdapters.TransporteurTableAdapter transporteurTableAdapter;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
    }
}

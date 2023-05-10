
namespace Citizen_Finder_Application
{
    partial class policeprofile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(policeprofile));
            this.label1 = new System.Windows.Forms.Label();
            this.lOGIN_INFODataSet1 = new Citizen_Finder_Application.LOGIN_INFODataSet1();
            this.pOLICEPROFILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOLICE_PROFILETableAdapter = new Citizen_Finder_Application.LOGIN_INFODataSet1TableAdapters.POLICE_PROFILETableAdapter();
            this.lOGIN_INFODataSet4 = new Citizen_Finder_Application.LOGIN_INFODataSet4();
            this.pOLICEPROFILEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pOLICE_PROFILETableAdapter1 = new Citizen_Finder_Application.LOGIN_INFODataSet4TableAdapters.POLICE_PROFILETableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLICEPROFILEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lOGIN_INFODataSet5 = new Citizen_Finder_Application.LOGIN_INFODataSet5();
            this.pOLICE_PROFILETableAdapter2 = new Citizen_Finder_Application.LOGIN_INFODataSet5TableAdapters.POLICE_PROFILETableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(182, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(350, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Police Profile";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lOGIN_INFODataSet1
            // 
            this.lOGIN_INFODataSet1.DataSetName = "LOGIN_INFODataSet1";
            this.lOGIN_INFODataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOLICEPROFILEBindingSource
            // 
            this.pOLICEPROFILEBindingSource.DataMember = "POLICE_PROFILE";
            this.pOLICEPROFILEBindingSource.DataSource = this.lOGIN_INFODataSet1;
            // 
            // pOLICE_PROFILETableAdapter
            // 
            this.pOLICE_PROFILETableAdapter.ClearBeforeFill = true;
            // 
            // lOGIN_INFODataSet4
            // 
            this.lOGIN_INFODataSet4.DataSetName = "LOGIN_INFODataSet4";
            this.lOGIN_INFODataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOLICEPROFILEBindingSource1
            // 
            this.pOLICEPROFILEBindingSource1.DataMember = "POLICE_PROFILE";
            this.pOLICEPROFILEBindingSource1.DataSource = this.lOGIN_INFODataSet4;
            // 
            // pOLICE_PROFILETableAdapter1
            // 
            this.pOLICE_PROFILETableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pOLICEPROFILEBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(73, 196);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(551, 149);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.Width = 125;
            // 
            // nAMEDataGridViewTextBoxColumn
            // 
            this.nAMEDataGridViewTextBoxColumn.DataPropertyName = "NAME";
            this.nAMEDataGridViewTextBoxColumn.HeaderText = "NAME";
            this.nAMEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nAMEDataGridViewTextBoxColumn.Name = "nAMEDataGridViewTextBoxColumn";
            this.nAMEDataGridViewTextBoxColumn.Width = 125;
            // 
            // aGEDataGridViewTextBoxColumn
            // 
            this.aGEDataGridViewTextBoxColumn.DataPropertyName = "AGE";
            this.aGEDataGridViewTextBoxColumn.HeaderText = "AGE";
            this.aGEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.aGEDataGridViewTextBoxColumn.Name = "aGEDataGridViewTextBoxColumn";
            this.aGEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pHONEDataGridViewTextBoxColumn
            // 
            this.pHONEDataGridViewTextBoxColumn.DataPropertyName = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.HeaderText = "PHONE";
            this.pHONEDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.pHONEDataGridViewTextBoxColumn.Name = "pHONEDataGridViewTextBoxColumn";
            this.pHONEDataGridViewTextBoxColumn.Width = 125;
            // 
            // pOLICEPROFILEBindingSource2
            // 
            this.pOLICEPROFILEBindingSource2.DataMember = "POLICE_PROFILE";
            this.pOLICEPROFILEBindingSource2.DataSource = this.lOGIN_INFODataSet5;
            // 
            // lOGIN_INFODataSet5
            // 
            this.lOGIN_INFODataSet5.DataSetName = "LOGIN_INFODataSet5";
            this.lOGIN_INFODataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOLICE_PROFILETableAdapter2
            // 
            this.pOLICE_PROFILETableAdapter2.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FloralWhite;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = global::Citizen_Finder_Application.Properties.Resources.arrow_back_icon2;
            this.button6.Location = new System.Drawing.Point(197, 377);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(59, 69);
            this.button6.TabIndex = 9;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // policeprofile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(701, 487);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "policeprofile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "policeprofile";
            this.Load += new System.EventHandler(this.policeprofile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LOGIN_INFODataSet1 lOGIN_INFODataSet1;
        private System.Windows.Forms.BindingSource pOLICEPROFILEBindingSource;
        private LOGIN_INFODataSet1TableAdapters.POLICE_PROFILETableAdapter pOLICE_PROFILETableAdapter;
        private LOGIN_INFODataSet4 lOGIN_INFODataSet4;
        private System.Windows.Forms.BindingSource pOLICEPROFILEBindingSource1;
        private LOGIN_INFODataSet4TableAdapters.POLICE_PROFILETableAdapter pOLICE_PROFILETableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LOGIN_INFODataSet5 lOGIN_INFODataSet5;
        private System.Windows.Forms.BindingSource pOLICEPROFILEBindingSource2;
        private LOGIN_INFODataSet5TableAdapters.POLICE_PROFILETableAdapter pOLICE_PROFILETableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button6;
    }
}
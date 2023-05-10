
namespace Citizen_Finder_Application
{
    partial class findpolice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(findpolice));
            this.label1 = new System.Windows.Forms.Label();
            this.lOGIN_INFODataSet = new Citizen_Finder_Application.LOGIN_INFODataSet();
            this.pOLICEPROFILEBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pOLICE_PROFILETableAdapter = new Citizen_Finder_Application.LOGIN_INFODataSetTableAdapters.POLICE_PROFILETableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            this.lOGIN_INFODataSet2 = new Citizen_Finder_Application.LOGIN_INFODataSet2();
            this.pOLICEPROFILEBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pOLICE_PROFILETableAdapter1 = new Citizen_Finder_Application.LOGIN_INFODataSet2TableAdapters.POLICE_PROFILETableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nAMEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aGEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pHONEDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pOLICEPROFILEBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.lOGIN_INFODataSet3 = new Citizen_Finder_Application.LOGIN_INFODataSet3();
            this.pOLICE_PROFILETableAdapter2 = new Citizen_Finder_Application.LOGIN_INFODataSet3TableAdapters.POLICE_PROFILETableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(267, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "Police List";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lOGIN_INFODataSet
            // 
            this.lOGIN_INFODataSet.DataSetName = "LOGIN_INFODataSet";
            this.lOGIN_INFODataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOLICEPROFILEBindingSource
            // 
            this.pOLICEPROFILEBindingSource.DataMember = "POLICE_PROFILE";
            this.pOLICEPROFILEBindingSource.DataSource = this.lOGIN_INFODataSet;
            // 
            // pOLICE_PROFILETableAdapter
            // 
            this.pOLICE_PROFILETableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FloralWhite;
            this.button6.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button6.Image = global::Citizen_Finder_Application.Properties.Resources.arrow_back_icon1;
            this.button6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button6.Location = new System.Drawing.Point(167, 438);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(148, 63);
            this.button6.TabIndex = 8;
            this.button6.Text = "Back";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // lOGIN_INFODataSet2
            // 
            this.lOGIN_INFODataSet2.DataSetName = "LOGIN_INFODataSet2";
            this.lOGIN_INFODataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOLICEPROFILEBindingSource1
            // 
            this.pOLICEPROFILEBindingSource1.DataMember = "POLICE_PROFILE";
            this.pOLICEPROFILEBindingSource1.DataSource = this.lOGIN_INFODataSet2;
            // 
            // pOLICE_PROFILETableAdapter1
            // 
            this.pOLICE_PROFILETableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nAMEDataGridViewTextBoxColumn,
            this.aGEDataGridViewTextBoxColumn,
            this.pHONEDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.pOLICEPROFILEBindingSource2;
            this.dataGridView1.GridColor = System.Drawing.Color.Red;
            this.dataGridView1.Location = new System.Drawing.Point(53, 223);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(571, 150);
            this.dataGridView1.TabIndex = 9;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
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
            this.pOLICEPROFILEBindingSource2.DataSource = this.lOGIN_INFODataSet3;
            // 
            // lOGIN_INFODataSet3
            // 
            this.lOGIN_INFODataSet3.DataSetName = "LOGIN_INFODataSet3";
            this.lOGIN_INFODataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pOLICE_PROFILETableAdapter2
            // 
            this.pOLICE_PROFILETableAdapter2.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(141, 146);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(361, 30);
            this.textBox1.TabIndex = 10;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox2.Image = global::Citizen_Finder_Application.Properties.Resources.police_officer_colored_web_buttons_260nw_55748692;
            this.pictureBox2.Location = new System.Drawing.Point(201, 48);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(71, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pictureBox1.Image = global::Citizen_Finder_Application.Properties.Resources._592_5929003_search_button_magnifying_glass_logo_png_transparent_png;
            this.pictureBox1.Location = new System.Drawing.Point(53, 134);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(71, 53);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // findpolice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(764, 649);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "findpolice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "findpolice";
            this.Load += new System.EventHandler(this.findpolice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOLICEPROFILEBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lOGIN_INFODataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private LOGIN_INFODataSet lOGIN_INFODataSet;
        private System.Windows.Forms.BindingSource pOLICEPROFILEBindingSource;
        private LOGIN_INFODataSetTableAdapters.POLICE_PROFILETableAdapter pOLICE_PROFILETableAdapter;
        private System.Windows.Forms.Button button6;
        private LOGIN_INFODataSet2 lOGIN_INFODataSet2;
        private System.Windows.Forms.BindingSource pOLICEPROFILEBindingSource1;
        private LOGIN_INFODataSet2TableAdapters.POLICE_PROFILETableAdapter pOLICE_PROFILETableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private LOGIN_INFODataSet3 lOGIN_INFODataSet3;
        private System.Windows.Forms.BindingSource pOLICEPROFILEBindingSource2;
        private LOGIN_INFODataSet3TableAdapters.POLICE_PROFILETableAdapter pOLICE_PROFILETableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nAMEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aGEDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pHONEDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
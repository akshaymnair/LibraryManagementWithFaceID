namespace MultiFaceRec
{
    partial class logregister
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.uckLibMgrDataSet1 = new MultiFaceRec.UckLibMgrDataSet1();
            this.logRegistersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logRegistersTableAdapter = new MultiFaceRec.UckLibMgrDataSet1TableAdapters.LogRegistersTableAdapter();
            this.logRegistersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logoutTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uckLibMgrDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logRegistersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.logRegistersDataGridViewTextBoxColumn,
            this.loginTimeDataGridViewTextBoxColumn,
            this.logoutTimeDataGridViewTextBoxColumn,
            this.studentIdDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.logRegistersBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(446, 305);
            this.dataGridView1.TabIndex = 0;
            // 
            // uckLibMgrDataSet1
            // 
            this.uckLibMgrDataSet1.DataSetName = "UckLibMgrDataSet1";
            this.uckLibMgrDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // logRegistersBindingSource
            // 
            this.logRegistersBindingSource.DataMember = "LogRegisters";
            this.logRegistersBindingSource.DataSource = this.uckLibMgrDataSet1;
            // 
            // logRegistersTableAdapter
            // 
            this.logRegistersTableAdapter.ClearBeforeFill = true;
            // 
            // logRegistersDataGridViewTextBoxColumn
            // 
            this.logRegistersDataGridViewTextBoxColumn.DataPropertyName = "LogRegisters";
            this.logRegistersDataGridViewTextBoxColumn.HeaderText = "LogRegisters";
            this.logRegistersDataGridViewTextBoxColumn.Name = "logRegistersDataGridViewTextBoxColumn";
            this.logRegistersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginTimeDataGridViewTextBoxColumn
            // 
            this.loginTimeDataGridViewTextBoxColumn.DataPropertyName = "LoginTime";
            this.loginTimeDataGridViewTextBoxColumn.HeaderText = "LoginTime";
            this.loginTimeDataGridViewTextBoxColumn.Name = "loginTimeDataGridViewTextBoxColumn";
            this.loginTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logoutTimeDataGridViewTextBoxColumn
            // 
            this.logoutTimeDataGridViewTextBoxColumn.DataPropertyName = "LogoutTime";
            this.logoutTimeDataGridViewTextBoxColumn.HeaderText = "LogoutTime";
            this.logoutTimeDataGridViewTextBoxColumn.Name = "logoutTimeDataGridViewTextBoxColumn";
            this.logoutTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentIdDataGridViewTextBoxColumn
            // 
            this.studentIdDataGridViewTextBoxColumn.DataPropertyName = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.HeaderText = "StudentId";
            this.studentIdDataGridViewTextBoxColumn.Name = "studentIdDataGridViewTextBoxColumn";
            this.studentIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logregister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 305);
            this.Controls.Add(this.dataGridView1);
            this.Name = "logregister";
            this.Text = "logregister";
            this.Load += new System.EventHandler(this.logregister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uckLibMgrDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logRegistersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private UckLibMgrDataSet1 uckLibMgrDataSet1;
        private System.Windows.Forms.BindingSource logRegistersBindingSource;
        private UckLibMgrDataSet1TableAdapters.LogRegistersTableAdapter logRegistersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn logRegistersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logoutTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentIdDataGridViewTextBoxColumn;
    }
}
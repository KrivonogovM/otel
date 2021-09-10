namespace RainbowLight
{
    partial class UControl_InformationClients
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonPech = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvInfoClients = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.informationClientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_RainbowLightDataSetInfoClients = new RainbowLight.Database_RainbowLightDataSetInfoClients();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.informationClientsTableAdapter = new RainbowLight.Database_RainbowLightDataSetInfoClientsTableAdapters.InformationClientsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoClients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationClientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetInfoClients)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.buttonPech);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dgvInfoClients);
            this.panel1.Controls.Add(this.buttonDelete);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 640);
            this.panel1.TabIndex = 1;
            // 
            // buttonPech
            // 
            this.buttonPech.BackColor = System.Drawing.Color.Lavender;
            this.buttonPech.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonPech.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPech.Location = new System.Drawing.Point(3, 594);
            this.buttonPech.Name = "buttonPech";
            this.buttonPech.Size = new System.Drawing.Size(486, 43);
            this.buttonPech.TabIndex = 18;
            this.buttonPech.Text = "Экспорт в excel";
            this.buttonPech.UseVisualStyleBackColor = false;
            this.buttonPech.Click += new System.EventHandler(this.buttonPech_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(346, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 36);
            this.label12.TabIndex = 16;
            this.label12.Text = "Информация о клиентах";
            // 
            // dgvInfoClients
            // 
            this.dgvInfoClients.AllowUserToOrderColumns = true;
            this.dgvInfoClients.AutoGenerateColumns = false;
            this.dgvInfoClients.BackgroundColor = System.Drawing.Color.White;
            this.dgvInfoClients.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvInfoClients.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInfoClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInfoClients.ColumnHeadersHeight = 30;
            this.dgvInfoClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvInfoClients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            this.dgvInfoClients.DataSource = this.informationClientsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInfoClients.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInfoClients.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvInfoClients.Location = new System.Drawing.Point(59, 72);
            this.dgvInfoClients.Name = "dgvInfoClients";
            this.dgvInfoClients.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvInfoClients.RowHeadersWidth = 30;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.dgvInfoClients.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInfoClients.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvInfoClients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvInfoClients.Size = new System.Drawing.Size(867, 516);
            this.dgvInfoClients.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDГостя";
            this.dataGridViewTextBoxColumn2.HeaderText = "IDГостя";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Имя";
            this.dataGridViewTextBoxColumn3.HeaderText = "Имя";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Фамилия";
            this.dataGridViewTextBoxColumn4.HeaderText = "Фамилия";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "НомерТелефона";
            this.dataGridViewTextBoxColumn5.HeaderText = "НомерТелефона";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ТипКарты";
            this.dataGridViewTextBoxColumn6.HeaderText = "ТипКарты";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "НомерКарты";
            this.dataGridViewTextBoxColumn7.HeaderText = "НомерКарты";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "YM";
            this.dataGridViewTextBoxColumn8.HeaderText = "YM";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "CVC";
            this.dataGridViewTextBoxColumn9.HeaderText = "CVC";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // informationClientsBindingSource
            // 
            this.informationClientsBindingSource.DataMember = "InformationClients";
            this.informationClientsBindingSource.DataSource = this.database_RainbowLightDataSetInfoClients;
            // 
            // database_RainbowLightDataSetInfoClients
            // 
            this.database_RainbowLightDataSetInfoClients.DataSetName = "Database_RainbowLightDataSetInfoClients";
            this.database_RainbowLightDataSetInfoClients.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Lavender;
            this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDelete.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(499, 594);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(486, 43);
            this.buttonDelete.TabIndex = 17;
            this.buttonDelete.Text = "Убрать из списка";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // informationClientsTableAdapter
            // 
            this.informationClientsTableAdapter.ClearBeforeFill = true;
            // 
            // UControl_InformationClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.Controls.Add(this.panel1);
            this.Name = "UControl_InformationClients";
            this.Size = new System.Drawing.Size(988, 640);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInfoClients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.informationClientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetInfoClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dgvInfoClients;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonPech;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГостяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типКартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКартыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cVCDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.BindingSource informationClientsBindingSource;
        private Database_RainbowLightDataSetInfoClients database_RainbowLightDataSetInfoClients;
        private Database_RainbowLightDataSetInfoClientsTableAdapters.InformationClientsTableAdapter informationClientsTableAdapter;
    }
}

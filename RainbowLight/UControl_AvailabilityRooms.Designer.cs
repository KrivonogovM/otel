namespace RainbowLight
{
    partial class UControl_AvailabilityRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReservedRooms = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dgvCloseRooms = new System.Windows.Forms.DataGridView();
            this.closeRoomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_RainbowLightDataSetCloseRooms = new RainbowLight.Database_RainbowLightDataSetCloseRooms();
            this.closeRoomsTableAdapter = new RainbowLight.Database_RainbowLightDataSetCloseRoomsTableAdapters.CloseRoomsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типНомераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.этажDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDГостяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВъездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыездаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.database_RainbowLightDataSetReservedRooms = new RainbowLight.Database_RainbowLightDataSetReservedRooms();
            this.забронированныеНомераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.забронированныеНомераTableAdapter = new RainbowLight.Database_RainbowLightDataSetReservedRoomsTableAdapters.ЗабронированныеНомераTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВъездаResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыездаResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типНомераDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКомнатыDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloseRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeRoomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetCloseRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetReservedRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.забронированныеНомераBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.dgvReservedRooms);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.dgvCloseRooms);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 640);
            this.panel1.TabIndex = 0;
            // 
            // dgvReservedRooms
            // 
            this.dgvReservedRooms.AllowUserToOrderColumns = true;
            this.dgvReservedRooms.AutoGenerateColumns = false;
            this.dgvReservedRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservedRooms.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvReservedRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservedRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservedRooms.ColumnHeadersHeight = 30;
            this.dgvReservedRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservedRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.имяDataGridViewTextBoxColumn1,
            this.фамилияDataGridViewTextBoxColumn1,
            this.номерТелефонаDataGridViewTextBoxColumn1,
            this.датаВъездаResDataGridViewTextBoxColumn,
            this.датаВыездаResDataGridViewTextBoxColumn,
            this.типНомераDataGridViewTextBoxColumn1,
            this.номерКомнатыDataGridViewTextBoxColumn1});
            this.dgvReservedRooms.DataSource = this.забронированныеНомераBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservedRooms.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservedRooms.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvReservedRooms.Location = new System.Drawing.Point(495, 72);
            this.dgvReservedRooms.Name = "dgvReservedRooms";
            this.dgvReservedRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReservedRooms.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvReservedRooms.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservedRooms.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvReservedRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReservedRooms.Size = new System.Drawing.Size(490, 565);
            this.dgvReservedRooms.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(603, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 18;
            this.label1.Text = "Забронированные номера";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.Location = new System.Drawing.Point(145, 19);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(199, 36);
            this.label12.TabIndex = 16;
            this.label12.Text = "Занятые номера";
            // 
            // dgvCloseRooms
            // 
            this.dgvCloseRooms.AllowUserToOrderColumns = true;
            this.dgvCloseRooms.AutoGenerateColumns = false;
            this.dgvCloseRooms.BackgroundColor = System.Drawing.Color.White;
            this.dgvCloseRooms.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvCloseRooms.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCloseRooms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvCloseRooms.ColumnHeadersHeight = 30;
            this.dgvCloseRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvCloseRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.типНомераDataGridViewTextBoxColumn,
            this.номерКомнатыDataGridViewTextBoxColumn,
            this.этажDataGridViewTextBoxColumn,
            this.iDГостяDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.датаВъездаDataGridViewTextBoxColumn,
            this.датаВыездаDataGridViewTextBoxColumn});
            this.dgvCloseRooms.DataSource = this.closeRoomsBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCloseRooms.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCloseRooms.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvCloseRooms.Location = new System.Drawing.Point(-1, 72);
            this.dgvCloseRooms.Name = "dgvCloseRooms";
            this.dgvCloseRooms.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvCloseRooms.RowHeadersWidth = 30;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.dgvCloseRooms.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvCloseRooms.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvCloseRooms.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvCloseRooms.Size = new System.Drawing.Size(490, 565);
            this.dgvCloseRooms.TabIndex = 7;
            // 
            // closeRoomsBindingSource
            // 
            this.closeRoomsBindingSource.DataMember = "CloseRooms";
            this.closeRoomsBindingSource.DataSource = this.database_RainbowLightDataSetCloseRooms;
            // 
            // database_RainbowLightDataSetCloseRooms
            // 
            this.database_RainbowLightDataSetCloseRooms.DataSetName = "Database_RainbowLightDataSetCloseRooms";
            this.database_RainbowLightDataSetCloseRooms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // closeRoomsTableAdapter
            // 
            this.closeRoomsTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 80;
            // 
            // типНомераDataGridViewTextBoxColumn
            // 
            this.типНомераDataGridViewTextBoxColumn.DataPropertyName = "ТипНомера";
            this.типНомераDataGridViewTextBoxColumn.HeaderText = "Тип номера";
            this.типНомераDataGridViewTextBoxColumn.Name = "типНомераDataGridViewTextBoxColumn";
            this.типНомераDataGridViewTextBoxColumn.Width = 120;
            // 
            // номерКомнатыDataGridViewTextBoxColumn
            // 
            this.номерКомнатыDataGridViewTextBoxColumn.DataPropertyName = "НомерКомнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.Name = "номерКомнатыDataGridViewTextBoxColumn";
            this.номерКомнатыDataGridViewTextBoxColumn.Width = 138;
            // 
            // этажDataGridViewTextBoxColumn
            // 
            this.этажDataGridViewTextBoxColumn.DataPropertyName = "Этаж";
            this.этажDataGridViewTextBoxColumn.HeaderText = "Этаж";
            this.этажDataGridViewTextBoxColumn.Name = "этажDataGridViewTextBoxColumn";
            this.этажDataGridViewTextBoxColumn.Width = 105;
            // 
            // iDГостяDataGridViewTextBoxColumn
            // 
            this.iDГостяDataGridViewTextBoxColumn.DataPropertyName = "IDГостя";
            this.iDГостяDataGridViewTextBoxColumn.HeaderText = "ID гостя";
            this.iDГостяDataGridViewTextBoxColumn.Name = "iDГостяDataGridViewTextBoxColumn";
            // 
            // имяDataGridViewTextBoxColumn
            // 
            this.имяDataGridViewTextBoxColumn.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn.Name = "имяDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // номерТелефонаDataGridViewTextBoxColumn
            // 
            this.номерТелефонаDataGridViewTextBoxColumn.DataPropertyName = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn.Name = "номерТелефонаDataGridViewTextBoxColumn";
            this.номерТелефонаDataGridViewTextBoxColumn.Width = 138;
            // 
            // датаВъездаDataGridViewTextBoxColumn
            // 
            this.датаВъездаDataGridViewTextBoxColumn.DataPropertyName = "ДатаВъезда";
            this.датаВъездаDataGridViewTextBoxColumn.HeaderText = "Дата въезда";
            this.датаВъездаDataGridViewTextBoxColumn.Name = "датаВъездаDataGridViewTextBoxColumn";
            this.датаВъездаDataGridViewTextBoxColumn.Width = 120;
            // 
            // датаВыездаDataGridViewTextBoxColumn
            // 
            this.датаВыездаDataGridViewTextBoxColumn.DataPropertyName = "ДатаВыезда";
            this.датаВыездаDataGridViewTextBoxColumn.HeaderText = "Дата выезда";
            this.датаВыездаDataGridViewTextBoxColumn.Name = "датаВыездаDataGridViewTextBoxColumn";
            this.датаВыездаDataGridViewTextBoxColumn.Width = 120;
            // 
            // database_RainbowLightDataSetReservedRooms
            // 
            this.database_RainbowLightDataSetReservedRooms.DataSetName = "Database_RainbowLightDataSetReservedRooms";
            this.database_RainbowLightDataSetReservedRooms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // забронированныеНомераBindingSource
            // 
            this.забронированныеНомераBindingSource.DataMember = "ЗабронированныеНомера";
            this.забронированныеНомераBindingSource.DataSource = this.database_RainbowLightDataSetReservedRooms;
            // 
            // забронированныеНомераTableAdapter
            // 
            this.забронированныеНомераTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idDataGridViewTextBoxColumn1.Width = 80;
            // 
            // имяDataGridViewTextBoxColumn1
            // 
            this.имяDataGridViewTextBoxColumn1.DataPropertyName = "Имя";
            this.имяDataGridViewTextBoxColumn1.HeaderText = "Имя";
            this.имяDataGridViewTextBoxColumn1.Name = "имяDataGridViewTextBoxColumn1";
            this.имяDataGridViewTextBoxColumn1.Width = 110;
            // 
            // фамилияDataGridViewTextBoxColumn1
            // 
            this.фамилияDataGridViewTextBoxColumn1.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn1.Name = "фамилияDataGridViewTextBoxColumn1";
            this.фамилияDataGridViewTextBoxColumn1.Width = 120;
            // 
            // номерТелефонаDataGridViewTextBoxColumn1
            // 
            this.номерТелефонаDataGridViewTextBoxColumn1.DataPropertyName = "НомерТелефона";
            this.номерТелефонаDataGridViewTextBoxColumn1.HeaderText = "Номер телефона";
            this.номерТелефонаDataGridViewTextBoxColumn1.Name = "номерТелефонаDataGridViewTextBoxColumn1";
            this.номерТелефонаDataGridViewTextBoxColumn1.Width = 138;
            // 
            // датаВъездаResDataGridViewTextBoxColumn
            // 
            this.датаВъездаResDataGridViewTextBoxColumn.DataPropertyName = "ДатаВъездаRes";
            this.датаВъездаResDataGridViewTextBoxColumn.HeaderText = "Дата въезда";
            this.датаВъездаResDataGridViewTextBoxColumn.Name = "датаВъездаResDataGridViewTextBoxColumn";
            this.датаВъездаResDataGridViewTextBoxColumn.Width = 120;
            // 
            // датаВыездаResDataGridViewTextBoxColumn
            // 
            this.датаВыездаResDataGridViewTextBoxColumn.DataPropertyName = "ДатаВыездаRes";
            this.датаВыездаResDataGridViewTextBoxColumn.HeaderText = "Дата выезда";
            this.датаВыездаResDataGridViewTextBoxColumn.Name = "датаВыездаResDataGridViewTextBoxColumn";
            this.датаВыездаResDataGridViewTextBoxColumn.Width = 120;
            // 
            // типНомераDataGridViewTextBoxColumn1
            // 
            this.типНомераDataGridViewTextBoxColumn1.DataPropertyName = "ТипНомера";
            this.типНомераDataGridViewTextBoxColumn1.HeaderText = "Тип номера";
            this.типНомераDataGridViewTextBoxColumn1.Name = "типНомераDataGridViewTextBoxColumn1";
            this.типНомераDataGridViewTextBoxColumn1.Width = 120;
            // 
            // номерКомнатыDataGridViewTextBoxColumn1
            // 
            this.номерКомнатыDataGridViewTextBoxColumn1.DataPropertyName = "НомерКомнаты";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.номерКомнатыDataGridViewTextBoxColumn1.DefaultCellStyle = dataGridViewCellStyle2;
            this.номерКомнатыDataGridViewTextBoxColumn1.HeaderText = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn1.Name = "номерКомнатыDataGridViewTextBoxColumn1";
            this.номерКомнатыDataGridViewTextBoxColumn1.Width = 138;
            // 
            // UControl_AvailabilityRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UControl_AvailabilityRooms";
            this.Size = new System.Drawing.Size(988, 640);
            this.Load += new System.EventHandler(this.UControl_AvailabilityRooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCloseRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeRoomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetCloseRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetReservedRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.забронированныеНомераBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCloseRooms;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.DataGridView dgvReservedRooms;
        private System.Windows.Forms.BindingSource closeRoomsBindingSource;
        private Database_RainbowLightDataSetCloseRooms database_RainbowLightDataSetCloseRooms;
        private Database_RainbowLightDataSetCloseRoomsTableAdapters.CloseRoomsTableAdapter closeRoomsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНомераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn этажDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDГостяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВъездаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыездаDataGridViewTextBoxColumn;
        private Database_RainbowLightDataSetReservedRooms database_RainbowLightDataSetReservedRooms;
        private Database_RainbowLightDataSetReservedRoomsTableAdapters.ЗабронированныеНомераTableAdapter забронированныеНомераTableAdapter;
        public System.Windows.Forms.BindingSource забронированныеНомераBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВъездаResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыездаResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНомераDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn1;
    }
}

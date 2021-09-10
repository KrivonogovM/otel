namespace RainbowLight
{
    partial class UControl_ResRooms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvReservedRooms2 = new System.Windows.Forms.DataGridView();
            this.забронированныеНомераBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database_RainbowLightDataSetResRooms = new RainbowLight.Database_RainbowLightDataSetResRooms();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReserved = new System.Windows.Forms.Button();
            this.panelTop = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePickerEntry2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerDeperture2 = new System.Windows.Forms.DateTimePicker();
            this.labeDeperture = new System.Windows.Forms.Label();
            this.labelEntry = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBoxNumberRoom2 = new System.Windows.Forms.ComboBox();
            this.textBoxEmail2 = new System.Windows.Forms.TextBox();
            this.comboBoxTypeRoom2 = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBoxNumberPhone2 = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.comboBoxNumberGuests2 = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxGenderGuests2 = new System.Windows.Forms.ComboBox();
            this.textBoxPatronymicGuests2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxSurnameGuests2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNameGuests2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.забронированныеНомераTableAdapter = new RainbowLight.Database_RainbowLightDataSetResRoomsTableAdapters.ЗабронированныеНомераTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.имяDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерТелефонаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВъездаResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.датаВыездаResDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.типНомераDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.номерКомнатыDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedRooms2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.забронированныеНомераBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetResRooms)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Thistle;
            this.panel1.Controls.Add(this.dgvReservedRooms2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.buttonReserved);
            this.panel1.Controls.Add(this.panelTop);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 640);
            this.panel1.TabIndex = 1;
            // 
            // dgvReservedRooms2
            // 
            this.dgvReservedRooms2.AllowUserToOrderColumns = true;
            this.dgvReservedRooms2.AutoGenerateColumns = false;
            this.dgvReservedRooms2.BackgroundColor = System.Drawing.Color.White;
            this.dgvReservedRooms2.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            this.dgvReservedRooms2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReservedRooms2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvReservedRooms2.ColumnHeadersHeight = 30;
            this.dgvReservedRooms2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvReservedRooms2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.имяDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.номерТелефонаDataGridViewTextBoxColumn,
            this.датаВъездаResDataGridViewTextBoxColumn,
            this.датаВыездаResDataGridViewTextBoxColumn,
            this.типНомераDataGridViewTextBoxColumn,
            this.номерКомнатыDataGridViewTextBoxColumn});
            this.dgvReservedRooms2.DataSource = this.забронированныеНомераBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveBorder;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvReservedRooms2.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReservedRooms2.GridColor = System.Drawing.SystemColors.HotTrack;
            this.dgvReservedRooms2.Location = new System.Drawing.Point(413, 72);
            this.dgvReservedRooms2.Name = "dgvReservedRooms2";
            this.dgvReservedRooms2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvReservedRooms2.RowHeadersWidth = 30;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvReservedRooms2.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvReservedRooms2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.dgvReservedRooms2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvReservedRooms2.Size = new System.Drawing.Size(572, 565);
            this.dgvReservedRooms2.TabIndex = 21;
            // 
            // забронированныеНомераBindingSource
            // 
            this.забронированныеНомераBindingSource.DataMember = "ЗабронированныеНомера";
            this.забронированныеНомераBindingSource.DataSource = this.database_RainbowLightDataSetResRooms;
            // 
            // database_RainbowLightDataSetResRooms
            // 
            this.database_RainbowLightDataSetResRooms.DataSetName = "Database_RainbowLightDataSetResRooms";
            this.database_RainbowLightDataSetResRooms.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(561, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 36);
            this.label1.TabIndex = 20;
            this.label1.Text = "Забронированные номера";
            // 
            // buttonReserved
            // 
            this.buttonReserved.BackColor = System.Drawing.Color.Lavender;
            this.buttonReserved.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonReserved.Font = new System.Drawing.Font("Monotype Corsiva", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonReserved.Location = new System.Drawing.Point(13, 567);
            this.buttonReserved.Name = "buttonReserved";
            this.buttonReserved.Size = new System.Drawing.Size(394, 70);
            this.buttonReserved.TabIndex = 19;
            this.buttonReserved.Text = "Забронировать";
            this.buttonReserved.UseVisualStyleBackColor = false;
            this.buttonReserved.Click += new System.EventHandler(this.buttonReserved_Click);
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.Thistle;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Controls.Add(this.label5);
            this.panelTop.Controls.Add(this.dateTimePickerEntry2);
            this.panelTop.Controls.Add(this.dateTimePickerDeperture2);
            this.panelTop.Controls.Add(this.labeDeperture);
            this.panelTop.Controls.Add(this.labelEntry);
            this.panelTop.Controls.Add(this.label10);
            this.panelTop.Controls.Add(this.comboBoxNumberRoom2);
            this.panelTop.Controls.Add(this.textBoxEmail2);
            this.panelTop.Controls.Add(this.comboBoxTypeRoom2);
            this.panelTop.Controls.Add(this.label8);
            this.panelTop.Controls.Add(this.label16);
            this.panelTop.Controls.Add(this.textBoxNumberPhone2);
            this.panelTop.Controls.Add(this.label17);
            this.panelTop.Controls.Add(this.comboBoxNumberGuests2);
            this.panelTop.Controls.Add(this.label7);
            this.panelTop.Controls.Add(this.label6);
            this.panelTop.Controls.Add(this.comboBoxGenderGuests2);
            this.panelTop.Controls.Add(this.textBoxPatronymicGuests2);
            this.panelTop.Controls.Add(this.label4);
            this.panelTop.Controls.Add(this.textBoxSurnameGuests2);
            this.panelTop.Controls.Add(this.label3);
            this.panelTop.Controls.Add(this.textBoxNameGuests2);
            this.panelTop.Controls.Add(this.label2);
            this.panelTop.Location = new System.Drawing.Point(13, 72);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(394, 489);
            this.panelTop.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(108, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 36);
            this.label5.TabIndex = 22;
            this.label5.Text = "Запись клиента";
            // 
            // dateTimePickerEntry2
            // 
            this.dateTimePickerEntry2.CustomFormat = "";
            this.dateTimePickerEntry2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEntry2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEntry2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerEntry2.Location = new System.Drawing.Point(76, 384);
            this.dateTimePickerEntry2.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerEntry2.MinDate = new System.DateTime(2019, 6, 13, 0, 0, 0, 0);
            this.dateTimePickerEntry2.Name = "dateTimePickerEntry2";
            this.dateTimePickerEntry2.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerEntry2.TabIndex = 13;
            this.dateTimePickerEntry2.Value = new System.DateTime(2019, 6, 13, 0, 0, 0, 0);
            // 
            // dateTimePickerDeperture2
            // 
            this.dateTimePickerDeperture2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerDeperture2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerDeperture2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.dateTimePickerDeperture2.Location = new System.Drawing.Point(203, 384);
            this.dateTimePickerDeperture2.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerDeperture2.MinDate = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            this.dateTimePickerDeperture2.Name = "dateTimePickerDeperture2";
            this.dateTimePickerDeperture2.Size = new System.Drawing.Size(120, 22);
            this.dateTimePickerDeperture2.TabIndex = 14;
            this.dateTimePickerDeperture2.Value = new System.DateTime(2019, 6, 14, 0, 0, 0, 0);
            // 
            // labeDeperture
            // 
            this.labeDeperture.AutoSize = true;
            this.labeDeperture.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labeDeperture.Location = new System.Drawing.Point(199, 359);
            this.labeDeperture.Name = "labeDeperture";
            this.labeDeperture.Size = new System.Drawing.Size(104, 22);
            this.labeDeperture.TabIndex = 16;
            this.labeDeperture.Text = "Дата выезда";
            // 
            // labelEntry
            // 
            this.labelEntry.AutoSize = true;
            this.labelEntry.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEntry.Location = new System.Drawing.Point(71, 359);
            this.labelEntry.Name = "labelEntry";
            this.labelEntry.Size = new System.Drawing.Size(101, 22);
            this.labelEntry.TabIndex = 15;
            this.labelEntry.Text = "Дата въезда";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(72, 329);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(131, 22);
            this.label10.TabIndex = 12;
            this.label10.Text = "Номер комнаты";
            // 
            // comboBoxNumberRoom2
            // 
            this.comboBoxNumberRoom2.AccessibleName = "";
            this.comboBoxNumberRoom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberRoom2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNumberRoom2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNumberRoom2.FormattingEnabled = true;
            this.comboBoxNumberRoom2.Location = new System.Drawing.Point(203, 329);
            this.comboBoxNumberRoom2.Name = "comboBoxNumberRoom2";
            this.comboBoxNumberRoom2.Size = new System.Drawing.Size(68, 25);
            this.comboBoxNumberRoom2.TabIndex = 11;
            this.comboBoxNumberRoom2.Click += new System.EventHandler(this.comboBoxNumberRoom2_Click);
            // 
            // textBoxEmail2
            // 
            this.textBoxEmail2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEmail2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxEmail2.Location = new System.Drawing.Point(203, 235);
            this.textBoxEmail2.Name = "textBoxEmail2";
            this.textBoxEmail2.Size = new System.Drawing.Size(161, 24);
            this.textBoxEmail2.TabIndex = 16;
            this.textBoxEmail2.Text = "first.last@mail.ru";
            this.textBoxEmail2.Click += new System.EventHandler(this.textBoxEmail2_Click);
            // 
            // comboBoxTypeRoom2
            // 
            this.comboBoxTypeRoom2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTypeRoom2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxTypeRoom2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxTypeRoom2.FormattingEnabled = true;
            this.comboBoxTypeRoom2.Items.AddRange(new object[] {
            "Одноместный",
            "Люкс",
            "Апартаменты",
            "Дуплекс",
            "Семейный"});
            this.comboBoxTypeRoom2.Location = new System.Drawing.Point(203, 267);
            this.comboBoxTypeRoom2.Name = "comboBoxTypeRoom2";
            this.comboBoxTypeRoom2.Size = new System.Drawing.Size(122, 25);
            this.comboBoxTypeRoom2.TabIndex = 10;
            this.comboBoxTypeRoom2.SelectedIndexChanged += new System.EventHandler(this.comboBoxTypeRoom2_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(72, 235);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 22);
            this.label8.TabIndex = 15;
            this.label8.Text = "E-mail";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label16.Location = new System.Drawing.Point(72, 298);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 22);
            this.label16.TabIndex = 3;
            this.label16.Text = "Число гостей";
            // 
            // textBoxNumberPhone2
            // 
            this.textBoxNumberPhone2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNumberPhone2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNumberPhone2.Location = new System.Drawing.Point(203, 203);
            this.textBoxNumberPhone2.MaxLength = 10;
            this.textBoxNumberPhone2.Name = "textBoxNumberPhone2";
            this.textBoxNumberPhone2.Size = new System.Drawing.Size(105, 24);
            this.textBoxNumberPhone2.TabIndex = 14;
            this.textBoxNumberPhone2.Text = "(999)-999-99-99";
            this.textBoxNumberPhone2.Click += new System.EventHandler(this.textBoxNumberPhone2_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(72, 267);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 22);
            this.label17.TabIndex = 1;
            this.label17.Text = "Тип номера";
            // 
            // comboBoxNumberGuests2
            // 
            this.comboBoxNumberGuests2.AccessibleName = "";
            this.comboBoxNumberGuests2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNumberGuests2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxNumberGuests2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxNumberGuests2.FormattingEnabled = true;
            this.comboBoxNumberGuests2.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.comboBoxNumberGuests2.Location = new System.Drawing.Point(203, 299);
            this.comboBoxNumberGuests2.Name = "comboBoxNumberGuests2";
            this.comboBoxNumberGuests2.Size = new System.Drawing.Size(68, 25);
            this.comboBoxNumberGuests2.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(72, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 22);
            this.label7.TabIndex = 13;
            this.label7.Text = "Номер телефона";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(72, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "Пол";
            // 
            // comboBoxGenderGuests2
            // 
            this.comboBoxGenderGuests2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxGenderGuests2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxGenderGuests2.ForeColor = System.Drawing.Color.Black;
            this.comboBoxGenderGuests2.FormattingEnabled = true;
            this.comboBoxGenderGuests2.Items.AddRange(new object[] {
            "Мужчина",
            "Женщина"});
            this.comboBoxGenderGuests2.Location = new System.Drawing.Point(162, 166);
            this.comboBoxGenderGuests2.Name = "comboBoxGenderGuests2";
            this.comboBoxGenderGuests2.Size = new System.Drawing.Size(100, 25);
            this.comboBoxGenderGuests2.TabIndex = 10;
            // 
            // textBoxPatronymicGuests2
            // 
            this.textBoxPatronymicGuests2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPatronymicGuests2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxPatronymicGuests2.Location = new System.Drawing.Point(162, 137);
            this.textBoxPatronymicGuests2.Name = "textBoxPatronymicGuests2";
            this.textBoxPatronymicGuests2.Size = new System.Drawing.Size(100, 24);
            this.textBoxPatronymicGuests2.TabIndex = 6;
            this.textBoxPatronymicGuests2.Text = "Отчество";
            this.textBoxPatronymicGuests2.Click += new System.EventHandler(this.textBoxPatronymicGuests2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(72, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Отчество";
            // 
            // textBoxSurnameGuests2
            // 
            this.textBoxSurnameGuests2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSurnameGuests2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxSurnameGuests2.Location = new System.Drawing.Point(162, 111);
            this.textBoxSurnameGuests2.Name = "textBoxSurnameGuests2";
            this.textBoxSurnameGuests2.Size = new System.Drawing.Size(100, 24);
            this.textBoxSurnameGuests2.TabIndex = 4;
            this.textBoxSurnameGuests2.Text = "Фамилия";
            this.textBoxSurnameGuests2.Click += new System.EventHandler(this.textBoxSurnameGuests2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(72, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // textBoxNameGuests2
            // 
            this.textBoxNameGuests2.AccessibleName = "";
            this.textBoxNameGuests2.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNameGuests2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.textBoxNameGuests2.Location = new System.Drawing.Point(162, 85);
            this.textBoxNameGuests2.Name = "textBoxNameGuests2";
            this.textBoxNameGuests2.Size = new System.Drawing.Size(100, 24);
            this.textBoxNameGuests2.TabIndex = 2;
            this.textBoxNameGuests2.Text = "Имя";
            this.textBoxNameGuests2.Click += new System.EventHandler(this.textBoxNameGuests2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(72, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Имя";
            // 
            // забронированныеНомераTableAdapter
            // 
            this.забронированныеНомераTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 80;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.номерКомнатыDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.номерКомнатыDataGridViewTextBoxColumn.HeaderText = "Номер комнаты";
            this.номерКомнатыDataGridViewTextBoxColumn.Name = "номерКомнатыDataGridViewTextBoxColumn";
            this.номерКомнатыDataGridViewTextBoxColumn.Width = 138;
            // 
            // UControl_ResRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "UControl_ResRooms";
            this.Size = new System.Drawing.Size(988, 640);
            this.Load += new System.EventHandler(this.UControl_ResRooms_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservedRooms2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.забронированныеНомераBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database_RainbowLightDataSetResRooms)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonReserved;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.DateTimePicker dateTimePickerEntry2;
        private System.Windows.Forms.DateTimePicker dateTimePickerDeperture2;
        private System.Windows.Forms.Label labeDeperture;
        private System.Windows.Forms.Label labelEntry;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxNumberRoom2;
        public System.Windows.Forms.TextBox textBoxEmail2;
        public System.Windows.Forms.ComboBox comboBoxTypeRoom2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label16;
        public System.Windows.Forms.TextBox textBoxNumberPhone2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox comboBoxNumberGuests2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox comboBoxGenderGuests2;
        public System.Windows.Forms.TextBox textBoxPatronymicGuests2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox textBoxSurnameGuests2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox textBoxNameGuests2;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dgvReservedRooms2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource забронированныеНомераBindingSource;
        private Database_RainbowLightDataSetResRooms database_RainbowLightDataSetResRooms;
        private Database_RainbowLightDataSetResRoomsTableAdapters.ЗабронированныеНомераTableAdapter забронированныеНомераTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn имяDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерТелефонаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВъездаResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn датаВыездаResDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn типНомераDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn номерКомнатыDataGridViewTextBoxColumn;
    }
}

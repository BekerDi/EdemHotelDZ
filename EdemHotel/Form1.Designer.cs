namespace EdemHotel
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewGosti = new DataGridView();
            panel1 = new Panel();
            txtBoxPoisk = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            btnGostCard = new Button();
            txtBoxNumbOfRoom = new TextBox();
            label2 = new Label();
            Имя = new Label();
            panel3 = new Panel();
            radioBtoSvobodno = new RadioButton();
            radioBtnZanyato = new RadioButton();
            radioBtnZarezerv = new RadioButton();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewGosti).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewGosti
            // 
            dataGridViewGosti.BackgroundColor = Color.PaleGoldenrod;
            dataGridViewGosti.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGosti.GridColor = Color.Wheat;
            dataGridViewGosti.Location = new Point(166, 56);
            dataGridViewGosti.Name = "dataGridViewGosti";
            dataGridViewGosti.Size = new Size(532, 639);
            dataGridViewGosti.TabIndex = 0;
            dataGridViewGosti.CellContentClick += dataGridViewGosti_CellContentClick;
            dataGridViewGosti.CellDoubleClick += dataGridViewGosti_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DarkGoldenrod;
            panel1.Controls.Add(txtBoxPoisk);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(-1, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(946, 60);
            panel1.TabIndex = 1;
            // 
            // txtBoxPoisk
            // 
            txtBoxPoisk.Location = new Point(167, 19);
            txtBoxPoisk.Name = "txtBoxPoisk";
            txtBoxPoisk.Size = new Size(532, 23);
            txtBoxPoisk.TabIndex = 4;
            txtBoxPoisk.Text = "Поиск...";
            txtBoxPoisk.TextChanged += txtBoxPoisk_TextChanged;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Segoe UI Symbol", 14F, FontStyle.Bold);
            label1.Location = new Point(13, 13);
            label1.Name = "label1";
            label1.Size = new Size(95, 35);
            label1.TabIndex = 3;
            label1.Text = "label1";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkKhaki;
            panel2.Controls.Add(btnGostCard);
            panel2.Controls.Add(txtBoxNumbOfRoom);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(Имя);
            panel2.Location = new Point(696, 56);
            panel2.Name = "panel2";
            panel2.Size = new Size(249, 615);
            panel2.TabIndex = 2;
            // 
            // btnGostCard
            // 
            btnGostCard.BackColor = Color.LightGoldenrodYellow;
            btnGostCard.Location = new Point(59, 447);
            btnGostCard.Name = "btnGostCard";
            btnGostCard.Size = new Size(126, 43);
            btnGostCard.TabIndex = 3;
            btnGostCard.Text = "Карточка гостя";
            btnGostCard.UseVisualStyleBackColor = false;
            btnGostCard.Click += btnGostCard_Click;
            // 
            // txtBoxNumbOfRoom
            // 
            txtBoxNumbOfRoom.BackColor = Color.DarkKhaki;
            txtBoxNumbOfRoom.BorderStyle = BorderStyle.None;
            txtBoxNumbOfRoom.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            txtBoxNumbOfRoom.Location = new Point(25, 83);
            txtBoxNumbOfRoom.Name = "txtBoxNumbOfRoom";
            txtBoxNumbOfRoom.Size = new Size(137, 22);
            txtBoxNumbOfRoom.TabIndex = 2;
            txtBoxNumbOfRoom.Text = "Номер комнаты";
            txtBoxNumbOfRoom.TextChanged += txtBoxNumbOfRoom_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(168, 83);
            label2.Name = "label2";
            label2.Size = new Size(0, 21);
            label2.TabIndex = 1;
            label2.Click += label2_Click;
            // 
            // Имя
            // 
            Имя.AutoSize = true;
            Имя.Font = new Font("Segoe UI Black", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Имя.Location = new Point(59, 43);
            Имя.Name = "Имя";
            Имя.Size = new Size(138, 30);
            Имя.TabIndex = 0;
            Имя.Text = "Имя гостя ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.DarkKhaki;
            panel3.Controls.Add(radioBtoSvobodno);
            panel3.Controls.Add(radioBtnZanyato);
            panel3.Controls.Add(radioBtnZarezerv);
            panel3.Location = new Point(-1, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(167, 615);
            panel3.TabIndex = 3;
            // 
            // radioBtoSvobodno
            // 
            radioBtoSvobodno.AutoSize = true;
            radioBtoSvobodno.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            radioBtoSvobodno.Location = new Point(4, 124);
            radioBtoSvobodno.Name = "radioBtoSvobodno";
            radioBtoSvobodno.Size = new Size(98, 24);
            radioBtoSvobodno.TabIndex = 2;
            radioBtoSvobodno.TabStop = true;
            radioBtoSvobodno.Text = "Свободно";
            radioBtoSvobodno.UseVisualStyleBackColor = true;
            radioBtoSvobodno.CheckedChanged += radioBtoSvobodno_CheckedChanged;
            // 
            // radioBtnZanyato
            // 
            radioBtnZanyato.AutoSize = true;
            radioBtnZanyato.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold);
            radioBtnZanyato.Location = new Point(4, 84);
            radioBtnZanyato.Name = "radioBtnZanyato";
            radioBtnZanyato.Size = new Size(75, 24);
            radioBtnZanyato.TabIndex = 1;
            radioBtnZanyato.TabStop = true;
            radioBtnZanyato.Text = "Занято";
            radioBtnZanyato.UseVisualStyleBackColor = true;
            radioBtnZanyato.CheckedChanged += radioBtnZanyato_CheckedChanged;
            // 
            // radioBtnZarezerv
            // 
            radioBtnZarezerv.AutoSize = true;
            radioBtnZarezerv.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            radioBtnZarezerv.Location = new Point(4, 43);
            radioBtnZarezerv.Name = "radioBtnZarezerv";
            radioBtnZarezerv.Size = new Size(157, 24);
            radioBtnZarezerv.TabIndex = 0;
            radioBtnZarezerv.TabStop = true;
            radioBtnZarezerv.Text = "Зарезервировано ";
            radioBtnZarezerv.UseVisualStyleBackColor = true;
            radioBtnZarezerv.CheckedChanged += radioBtnZarezerv_CheckedChanged;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(944, 668);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(dataGridViewGosti);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewGosti).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewGosti;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private RadioButton radioBtnZanyato;
        private RadioButton radioBtnZarezerv;
        private RadioButton radioBtoSvobodno;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label Имя;
        private Label label2;
        private TextBox txtBoxNumbOfRoom;
        private Button btnGostCard;
        private TextBox txtBoxPoisk;
    }
}

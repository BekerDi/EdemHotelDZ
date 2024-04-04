using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Sqlite;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.WebSockets;
using System.Xml.Linq;

namespace EdemHotel
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
            timer1.Start();
            DBLoad();
            Guid guid = Guid.NewGuid();
            var gosti1 = new Gosti(Guid.NewGuid(), "Ли Дон Ук", true, new DateTime(2024, 04, 01), new DateTime(2024, 04, 07), 1, 2);
            var gosti2 = new Gosti(Guid.NewGuid(), "Ким Бом", false, new DateTime(2024, 03, 12), new DateTime(2024, 03, 20), 2, 1);
            var gosti3 = new Gosti(Guid.NewGuid(), "Ли Тхэ-ри", false, new DateTime(2024, 04, 09), new DateTime(2024, 04, 17), 3, 3);
            var gosti4 = new Gosti(Guid.NewGuid(), "Хван Хи", true, new DateTime(2024, 04, 01), new DateTime(2024, 04, 06), 4, 2);
            var gosti5 = new Gosti(Guid.NewGuid(), "Ан Гиль-Ган", true, new DateTime(2024, 03, 23), new DateTime(2024, 04, 04), 5, 2);
            /// db.Gosti.Add(gosti1);
            ///db.Gosti.Add(gosti2);
            // db.Gosti.Add(gosti3);
            // db.Gosti.Add(gosti4);
            //db.Gosti.Add(gosti5);
            db.SaveChanges();
            var status1 = new StatusNomera(1, "Свободен");
            var status2 = new StatusNomera(2, "Занят");
            var status3 = new StatusNomera(3, "Зарезервирован");
            // db.StatusNomera.Add(status1);
            //db.StatusNomera.Add(status2);
            // db.StatusNomera.Add(status3);
            LoadGostiInTable();
            dataGridViewGosti.CellDoubleClick += dataGridViewGosti_CellDoubleClick;
            this.txtBoxPoisk.Enter += new System.EventHandler(this.txtBoxPoisk_Enter);
            this.txtBoxPoisk.Leave += new System.EventHandler(this.txtBoxPoisk_Leave);


        }
        private void LoadGostiInTable()
        {
            dataGridViewGosti.DataSource = db.Gosti.ToList();
        }
        private EdemContext db = new EdemContext();

        private void DBLoad()
        {

            //  db.Database.EnsureDeleted();
            db.Database.EnsureCreated();
            db.Gosti.Load();
            db.StatusNomera.Load();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dataGridViewGosti_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioBtnZarezerv_CheckedChanged(object sender, EventArgs e)
        {
            var filteredGuests = db.Gosti.Where(g => g.Status == 3).ToList();
            dataGridViewGosti.DataSource = filteredGuests;
        }

        private void radioBtnZanyato_CheckedChanged(object sender, EventArgs e)
        {
            var filteredGuests = db.Gosti.Where(g => g.Status == 2).ToList();
            dataGridViewGosti.DataSource = filteredGuests;
        }

        private void radioBtoSvobodno_CheckedChanged(object sender, EventArgs e)
        {
            var filteredGuests = db.Gosti.Where(g => g.Status == 1).ToList();
            dataGridViewGosti.DataSource = filteredGuests;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewGosti_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var selectedRow = dataGridViewGosti.Rows[e.RowIndex];
                var guestName = selectedRow.Cells[1].Value.ToString();
                var guestNumber = selectedRow.Cells[5].Value.ToString();
                Имя.Text = guestName;
                label2.Text = guestNumber;

               

            }
        }

        private void txtBoxNumbOfRoom_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnGostCard_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();

        }

        private void txtBoxPoisk_TextChanged(object sender, EventArgs e)
        {
            var searchText = txtBoxPoisk.Text;
            var filteredGuests = db.Gosti.Where(g => g.Name.Contains(searchText)).ToList();
            dataGridViewGosti.DataSource = filteredGuests;
           
           
        }
        public void txtBoxPoisk_Enter(object sender, EventArgs e)
        {

            if (txtBoxPoisk.Text == "Поиск...")
            {
                txtBoxPoisk.Text = "";
                txtBoxPoisk.ForeColor = Color.Black;
            }
        }

        private void txtBoxPoisk_Leave(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtBoxPoisk.Text))
            {
                txtBoxPoisk.Text = "Поиск..."; 
                txtBoxPoisk.ForeColor = Color.Gray; 
            }
        }
        static public byte[] PictureToByteArr(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        static public Image ByteArrToPicture(byte[] bytesArr)
        {
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }


        
    }

}

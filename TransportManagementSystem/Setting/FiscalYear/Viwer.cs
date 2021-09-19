using System;
using System.Windows.Forms;
using System.Linq;
namespace TransportManagementSystem.FiscalYear
{
    public partial class Viwer : UserControl
    {
        public delegate void defaultChangeHandler();
        public event defaultChangeHandler defaultChange;

        Model.TransportManagementEntities db;
        bool loaded;
        public Model.fiscalyear Fiscalyear { get; set; }
        public Viwer()
        {
            InitializeComponent();
            db = DB.Instance;
        }

        public Viwer(int id)
        {
            InitializeComponent();
            
            this.Fiscalyear = db.fiscalyears.Find(id);
            betterTextBox_name.Text = this.Fiscalyear.title;
            nepaliCalender_startdate.Datestamp = this.Fiscalyear.startdate.Value;
            nepaliCalender_endate.Datestamp = this.Fiscalyear.enddate.Value;
            loaded = true;
        }



        private void materialButton_save_Click(object sender, EventArgs e)
        {
            if (betterTextBox_name.Text.Trim() == "")
            {
                INFO.ShowAlert("Ficial Years", "Please Add Ficial Year Name", 3000);
                return;
            }

            if (nepaliCalender_startdate.Datestamp >= nepaliCalender_endate.Datestamp)
            {
                INFO.ShowAlert("Ficial Years", "Starting Date Cannot Be Greater Than Ending Date", 3000);
                return;
            }
            if (loaded)
            {
                this.Fiscalyear.title = betterTextBox_name.Text;
                this.Fiscalyear.startdate = nepaliCalender_startdate.Datestamp;
                this.Fiscalyear.enddate = nepaliCalender_endate.Datestamp;
                this.Fiscalyear.updated_at = DateTime.Now;
                db.Entry(this.Fiscalyear).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
                INFO.ShowAlert("Ficial Years", "Ficial Year" + this.Fiscalyear.title + " Updated", 3000);

            }
            else
            {
                this.Fiscalyear = new Model.fiscalyear()
                {
                    title = betterTextBox_name.Text,
                    startdate = nepaliCalender_startdate.Datestamp,
                    enddate = nepaliCalender_endate.Datestamp,
                    created_at = DateTime.Now,
                    updated_at = DateTime.Now,
                    admin_id = INFO.admin_id
                };
                db.fiscalyears.Add(this.Fiscalyear);
                db.SaveChanges();
                loaded = true;
                INFO.ShowAlert("Ficial Years", "Ficial Year" + this.Fiscalyear.title + " Added", 3000);

            }


        }

        private void materialButton_setDefault_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (db.systemsettings.Count() > 0)
                {
                    var setting = db.systemsettings.First();
                    setting.fiscalyear_id = this.Fiscalyear.id;
                    db.Entry(setting).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                else
                {
                    var setting = new Model.systemsetting()
                    {
                        fiscalyear_id = this.Fiscalyear.id
                    };
                    db.systemsettings.Add(setting);
                    db.SaveChanges();
                }
                INFO.ShowAlert("", this.Fiscalyear.title + " set as current Fiscal Year", 3000);
                defaultChange?.Invoke();
            }
        }

        public void refreshDefault()
        {
            if (loaded)
            {
                if (db.systemsettings.Count() > 0)
                {
                    var setting = db.systemsettings.First();
                    db.Entry(setting).Reload();
                    if (setting.fiscalyear_id == this.Fiscalyear.id)
                    {
                        this.BackColor = System.Drawing.Color.FromArgb(235, 244, 255);
                    }
                    else
                    {
                        this.BackColor = System.Drawing.Color.White; 
                    }

                }
            }
        }
        private void Viwer_Load(object sender, EventArgs e)
        {
            if (loaded)
            {
                if (db.systemsettings.Count() > 0)
                {
                    var setting = db.systemsettings.First();
                    if (setting.fiscalyear_id == this.Fiscalyear.id)
                    {
                        this.BackColor = System.Drawing.Color.FromArgb(235, 244, 255);
                    }

                }
            }
        }

        
    }

}

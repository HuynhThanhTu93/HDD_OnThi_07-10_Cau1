namespace HDD_OnThi_07_10_Cau1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Car> ls_cars = new List<Car>();
        private void btn_them_Click(object sender, EventArgs e)
        {
            Car car = new Car(txt_hXe.Text, txt_nsXuat.Text, txt_bSo.Text, Int32.Parse(txt_gBan.Text));
            ls_cars.Add(car);
            dt_Car.DataSource = null;
            dt_Car.DataSource = ls_cars;
        }

        private void btn_Sua_Click(object sender, EventArgs e)
        {
            foreach (Car i in ls_cars)
            {
                if (txt_hXe.Text == i.HangXe)
                {
                    i.NamsanXuat = txt_nsXuat.Text;
                    i.GiaBan = Int32.Parse(txt_gBan.Text);
                    i.BienSo = txt_bSo.Text;

                }
            }
        }

        private void btn_Xoa_Click(object sender, EventArgs e)
        {

            foreach (Car i in ls_cars)
            {
                if (i.HangXe == txt_hXe.Text)
                {
                    ls_cars.Remove(i);
                }
                break;
            }
            dt_Car.DataSource = null;
            dt_Car.DataSource = ls_cars;
        }
        List<ElectricCar> ls_ECar = new List<ElectricCar>();
        private void btn_Them1_Click(object sender, EventArgs e)
        {
            ElectricCar ECar = new ElectricCar(txt_hXe1.Text, txt_nsXuat1.Text, txt_bSo1.Text, Int32.Parse(txt_gBan1.Text), Int32.Parse(txt_dlPin.Text));
            ls_ECar.Add(ECar);
            dt_ECar.DataSource = null;
            dt_ECar.DataSource = ls_ECar;
        }

        private void btn_Sua1_Click(object sender, EventArgs e)
        {
            foreach (ElectricCar i in ls_ECar)
            {
                if (txt_hXe1.Text == i.HangXe)
                {
                    i.NamsanXuat = txt_nsXuat1.Text;
                    i.GiaBan = Int32.Parse(txt_gBan1.Text);
                    i.BienSo = txt_bSo1.Text;
                    i.BatteryCapacity = Int32.Parse(txt_dlPin.Text);
                }
            }
        }

        private void btn_Xoa1_Click(object sender, EventArgs e)
        {
            foreach (ElectricCar i in ls_ECar)
            {
                if (i.HangXe == txt_hXe1.Text)
                {
                    ls_ECar.Remove(i);
                }
                break;
            }
            dt_ECar.DataSource = null;
            dt_ECar.DataSource = ls_ECar;
        }
    }
}

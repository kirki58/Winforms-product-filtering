using System.Diagnostics;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public struct Member
        {
            public String img_path;
            public String brand;
            public String cpu;
            public double price;
            public Member(String path, String b, double p, String c)
            {
                this.img_path = Path.Combine(Application.StartupPath, path);
                this.brand = b;
                this.price = p;
                this.cpu = c;
            }
        }
        // Don't forget to make images "Copy to output directory" property to "Copy always"
        public Member[] members = {
                new Member(@"images\hp_laptop.jpg", "HP",39999.99d, "Intel Core i7"),
                new Member(@"images\dell_laptop.jpg", "Dell", 34999.0d, "Intel Core i7"),
                new Member(@"images\msi_laptop.jpg", "MSI", 21189.99d, "Intel Core i5"),
                new Member(@"images\msi_laptop2.jpg", "MSI", 33399.0d, "Intel Core i7"),
                new Member(@"images\hp_laptop2.jpg", "HP", 9708.0d, "Intel Core i3"),
                new Member(@"images\dell_laptop2.jpg", "Dell", 14999.0d, "Intel Core i5"),
                new Member(@"images\asus_laptop.jpg", "Asus", 11731.55d, "Intel Core i3"),
                new Member(@"images\asus_laptop2.jpg", "Asus", 22999.0d, "Intel Core i5"),
                new Member(@"images\lenovo_laptop.jpg", "Lenovo", 29999.0d, "Intel Core i5"),
                new Member(@"images\lenovo_laptop2.jpg", "Lenovo", 44999.0d, "Intel Core i7")
        };
        public Form1()
        {
            InitializeComponent();

            //config datagridview
            dataGridView1.Columns["Image"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Brand"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridView1.Columns["Price"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.RowTemplate.Height = 400;

            foreach (Member member in members)
            {
                insert_into(member);
            }
        }
        public void insert_into(Member member)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(member.img_path);
            dataGridView1.Rows.Add(img, member.brand, member.price, member.cpu);
        }
        //returns lower and higher limits of a price interval such as "10.000-20.000"
        public int[] parse_price_interval(String price_interval)
        {
            String[] prices = price_interval.Split('-');
            int lower;
            int higher;

            lower = int.Parse(prices[0].Replace(".", ""));
            higher = int.Parse(prices[1].Replace(".", ""));
            return new int[] { lower, higher };
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //brands
            List<String> brands = new List<String>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
            {
                if (checkedListBox1.GetItemChecked(i))
                {
                    brands.Add(checkedListBox1.Items[i].ToString());
                }
            }

            //price
            List<String> prices = new List<String>();
            for(int i = 0;i < checkedListBox2.Items.Count; i++)
            {
                if (checkedListBox2.GetItemChecked(i))
                {
                    prices.Add(checkedListBox2.Items[i].ToString());
                }
            }

            //CPU
            List<String> cpus= new List<String>();
            for(int i = 0; i< checkedListBox3.Items.Count; i++)
            {
                if (checkedListBox3.GetItemChecked(i))
                {
                    cpus.Add(checkedListBox3.Items[i].ToString());
                }
            }
            
            List<Member> filteredMembers = new List<Member>();

            //if all checklists are empty reset the datagridview
            if(brands.Count == 0 && prices.Count == 0 && cpus.Count == 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Member member in members)
                {
                    insert_into(member);
                }
                return;
            }

            foreach (Member member in members)
            { 
                if((brands.Contains(member.brand) || brands.Count == 0) && (cpus.Contains(member.cpu) || cpus.Count == 0))
                {
                    if(prices.Count == 0)
                    {
                        filteredMembers.Add(member);
                    }
                    else
                    {
                        bool isValid = false;
                        foreach(String cr_price in prices)
                        {
                            int[] limits = parse_price_interval(cr_price);
                            if(member.price > limits[0] && member.price < limits[1])
                            {
                                isValid = true;
                                break;
                            }
                        }
                        if (isValid)
                        {
                            filteredMembers.Add(member);
                        }
                    }
                }
            }

            //Clear the datagridview and insert filtered
            dataGridView1.Rows.Clear();
            if(filteredMembers.Count > 0)
            {
                dataGridView1.Rows.Clear();
                foreach (Member member in filteredMembers)
                {
                    insert_into(member);
                }
                return;
            }
        }
    }
}

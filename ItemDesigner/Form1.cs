using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Unicode;
using System.Windows.Forms;

namespace ItemDesigner
{
    public partial class Form1 : Form
    {
        List<Item> items;
        int listIndex;
        Bitmap buffer;
        Pen mypen;
        Graphics g1, g2;
        public Form1()
        {
            items = new List<Item>();
            listIndex = 0;
            buffer = new Bitmap(32, 32);
            InitializeComponent();
            //采用双缓冲技术的控件必需的设置
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw | ControlStyles.AllPaintingInWmPaint, true);
            this.SetStyle(ControlStyles.Opaque, false);
            this.UpdateStyles();
            mypen = new Pen(Color.White, 3);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            int idx = 0;
            string path = Application.StartupPath + @"..\data\item\";
            while (File.Exists(path + @"item_" + idx.ToString() + ".json"))
            {
                string file = @"item_" + idx.ToString() + ".json";
                string jsonstr = System.IO.File.ReadAllText(path + file);
                Item tempitm = JsonSerializer.Deserialize<Item>(jsonstr);
                items.Add(tempitm);
                listBox1.Items.Add(idx.ToString().PadLeft(3, '0') + "：" + tempitm.name);
                ++idx;
            }
            if (items.Count == 0)
            {
                MessageBox.Show("未检测到物品数据！");
                Application.Exit();
                return;
            }
            listBox1.SelectedIndex = 0;
            textBox1.Text = items[0].name;
            textBox2.Text = items[0].description;
            pictureBox1.Image = Image.FromFile(@"..\graphics\character\" + items[0].file);
            textBox3.Text = items[0].price.ToString();
            checkBox1.Checked = items[0].usable;
            checkBox2.Checked = items[0].cost;
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            buffer = new Bitmap(32, 32);
            if (pictureBox1.Image == null)
            {
                if (pictureBox2.Image != null)
                {
                    pictureBox2.Image.Dispose();
                    pictureBox2.Image = null;
                }
                return;
            }
            g2 = Graphics.FromImage(buffer);
            g2.DrawImage(pictureBox1.Image, new Rectangle(0, 0, 32, 32), new Rectangle(32 * items[listIndex].pos[0], 32 * items[listIndex].pos[1], 32, 32), GraphicsUnit.Pixel);
            pictureBox2.Image = buffer;
            g2.Dispose();
            int picsiz = pictureBox1.Width / 4;
            e.Graphics.DrawRectangle(mypen, new Rectangle(items[listIndex].pos[0] * picsiz, items[listIndex].pos[1] * picsiz, picsiz, picsiz));
        }
        private void refreshList()
        {
            listBox1.Items.Clear();
            int idx = 0;
            foreach (Item itm in items)
            {
                listBox1.Items.Add(idx.ToString().PadLeft(3, '0') + "：" + itm.name);
                idx++;
            }
            listBox1.SelectedIndex = listIndex;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listIndex = listBox1.SelectedIndex;
            textBox1.Text = items[listIndex].name;
            textBox2.Text = items[listIndex].description;
            if (File.Exists(@"..\graphics\character\" + items[listIndex].file))
                pictureBox1.Image = Image.FromFile(@"..\graphics\character\" + items[listIndex].file);
            else
            {
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                    pictureBox1.Image = null;
                }
            }
            textBox3.Text = items[listIndex].price.ToString();
            checkBox1.Checked = items[listIndex].usable;
            checkBox2.Checked = items[listIndex].cost;
            GC.Collect();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            items[listIndex].name = textBox1.Text;
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            items[listIndex].description = textBox2.Text;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Point thispoint = pictureBox1.PointToClient(Control.MousePosition);
            int picsize = pictureBox1.Width / 4;
            if (me.Button == MouseButtons.Left)
            {
                items[listIndex].pos[0] = thispoint.X / picsize;
                items[listIndex].pos[1] = thispoint.Y / picsize;
            }
            else if (me.Button == MouseButtons.Right)
            {
                //创建对象
                OpenFileDialog ofg = new OpenFileDialog();
                //设置默认打开路径
                ofg.InitialDirectory = Path.GetDirectoryName(Path.GetDirectoryName(Application.ExecutablePath)) + "\\graphics\\character";
                ofg.RestoreDirectory = true;
                //设置打开标题、后缀
                ofg.Title = "请选择导入png文件";
                ofg.Filter = "png文件|*.png";
                string path = "";
                if (ofg.ShowDialog() == DialogResult.OK)
                {
                    //得到打开的文件路径（包括文件名）
                    string[] names = ofg.FileName.ToString().Split('\\');
                    items[listIndex].file = names[names.Length - 1];
                    pictureBox1.Image = Image.FromFile(@"..\graphics\character\" + items[listIndex].file);
                }
                else
                    MessageBox.Show("未选择打开文件！");
            }
            pictureBox1.Invalidate();
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (int.TryParse(textBox3.Text, out int intValue))
                items[listIndex].price = int.Parse(textBox3.Text);
            else
                items[listIndex].price = 0;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            items[listIndex].usable = checkBox1.Checked;
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            items[listIndex].cost = checkBox2.Checked;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            items.Add(new Item("新物品", "新物品描述", "item.png", new int[] { 0, 0 }, 0, false, false));
            refreshList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (items.Count == 1)
            {
                MessageBox.Show("不允许删除最后一个物品");
                return;
            }
            items.RemoveAt(listBox1.SelectedIndex);
            if (listIndex >= items.Count)
                listIndex = items.Count - 1;
            refreshList();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            int idx = 0;
            string path = Application.StartupPath + @"..\data\item\";
            foreach (Item itm in items)
            {
                string file = @"item_" + idx.ToString() + ".json";
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.All),
                    DefaultIgnoreCondition = JsonIgnoreCondition.Never,
                    WriteIndented = true
                };
                string jsonstr = JsonSerializer.Serialize(itm, options);
                System.IO.File.WriteAllText(path + file, jsonstr);
                ++idx;
            }
            while (File.Exists(path + @"item_" + idx.ToString() + ".json"))
            {
                System.IO.File.Delete(path + @"item_" + (idx++).ToString() + ".json");
            }
            MessageBox.Show("保存成功！");
        }
    }
}

public class Item
{
    public string name { get; set; }
    public string description { get; set; }
    public string file { get; set; }
    public int[] pos { get; set; }
    public int price { get; set; }
    public bool usable { get; set; }
    public bool cost { get; set; }
    public Item(string name, string description, string file, int[] pos, int price, bool usable, bool cost)
    {
        this.name = name;
        this.description = description;
        this.file = file;
        this.pos = pos;
        this.price = price;
        this.usable = usable;
        this.cost = cost;
    }
}
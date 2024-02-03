using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CP_Warning
{
    public partial class Form1 : Form
    {
        Bitmap inPutPhoto;
        string photoAdress;
        string photoWidth;
        string photoHeight;
        string CPText;

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Input_Click(object sender, EventArgs e)
        {
            //打开选择文件对话框
            OpenFileDialog openFileDialog1 = new OpenFileDialog
            {
                Filter = "JPG(*.jpg)|*.jpg|PNG(*.png)|*.png",
                FilterIndex = 0,
                RestoreDirectory = true,
                Multiselect = false,
            };
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //读取图片基本信息，写入缓存
                photoAdress = openFileDialog1.FileName;
                inPutPhoto = (Bitmap)System.Drawing.Image.FromFile(openFileDialog1.FileName);
                photoWidth = inPutPhoto.Width.ToString();
                photoHeight = inPutPhoto.Height.ToString();
                //显示图片和基本信息
                pictureBox_Input.Image = inPutPhoto;
                textBox_Width.Text = photoWidth;
                textBox_Height.Text = photoHeight;
            }
            else return;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            photoWidth = textBox_Width.Text;
            photoHeight = textBox_Height.Text;
            CPText = textBox_CPName.Text;
            //生成新图像;
            Bitmap outPutPhoto = new Bitmap(int.Parse(photoWidth), int.Parse(photoHeight));
            //全图填充白色
            for (int i = 0; i < int.Parse(photoWidth); i++)
            {
                for (int j = 0; j < int.Parse(photoHeight); j++)
                {
                    outPutPhoto.SetPixel(i, j, Color.White);
                }
            }
            //计算图像复制位置
            int dy = int.Parse(photoHeight) - pictureBox_Input.Image.Height;
            for (int i = 0; i < int.Parse(photoWidth); i++)
            {
                for (int j = dy; j < int.Parse(photoHeight); j++)
                {
                    Color pixel = inPutPhoto.GetPixel(i, j - dy);
                    outPutPhoto.SetPixel(i, j, pixel);
                }
            }
            //显示预览图
            pictureBox_Output.Image = outPutPhoto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Kakao ka = new Kakao("choonsik",1,100);
        }

        class Kakao
        {
            public string name;
            public int age;
            public int height;

            public Kakao(string name)
            {
                this.name = name;
                Console.WriteLine($"이름 :{this.name}");
            }

            public Kakao(string name, int age) : this(name)
            {
                this.age = age;
                Console.WriteLine($"이름 :{this.name} 나이 :{this.age}");
            }

            public Kakao(string name, int age, int height) : this(name, age)
            {
                this.height = height;
                Console.WriteLine($"이름 :{this.name} 나이 :{this.age} 키 :{this.height}");
            }
        }
    }
}

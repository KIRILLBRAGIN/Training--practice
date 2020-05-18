using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Esoft_Project

{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {

        }

        private void ButtonOpenClients_Click(object sender, EventArgs e)
        {
            //Задаём новую форму из класса Клиент и открываем её
            Form formClient = new FormClient();
            formClient.Show();
        }

        private void ButtonOpenAgents_Click(object sender, EventArgs e)
        {
            //Задаём новую форму из класса Риелтор и открываем её
            Form formAgent = new FormAgent();
            formAgent.Show();
        }

        private void ButtonOpenRealEstates_Click(object sender, EventArgs e)
        {
            //Задаём новую форму из класса Объекты недвижимости и открываем её
            Form formRealEstate = new FormRealEstate();
            formRealEstate.Show();
        }
    }
}

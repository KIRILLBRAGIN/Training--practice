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
    public partial class FormAgent : Form
    {
        public FormAgent()
        {
            InitializeComponent();
            ShowAgent();
        }

        void ShowAgent()
        {
            //предварительно очищаем listView
            listViewAgent.Items.Clear();
            //проходимся по коллекции риелторов, которые находятся в базе с помощью foreach
            foreach (AgentSet agentSet in Program.wftDb.AgentSet)
            {
                //создаём новый элемент в listView
                //для этого создаём новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                        //указываем необходимые поля
                        agentSet.Id.ToString(), agentSet.FirstName, agentSet.MiddleName,
                        agentSet.LastName, agentSet.DealShare.ToString()
            });
                //указываем по какому тегу будем брать элементы
                item.Tag = agentSet;
                //добавляем элементы в listView для отображения
                listViewAgent.Items.Add(item);
            }
            //выравниваем колонки в listView
            listViewAgent.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void FormAgent_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //создаём новый экземпляр класса Риелтор
                AgentSet agentSet = new AgentSet();
                //делаем ссылку на обьект, который хранится в textBox-ax
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                if (textBoxDealShare.Text != "")
                {
                    agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                }
                if (agentSet.FirstName == "" || agentSet.MiddleName == "" || agentSet.LastName == "") 
                {
                    throw new Exception("Поля ФИО обязательны для заполнения!");
                }
                if (agentSet.DealShare < 0 || agentSet.DealShare > 100)
                {
                    throw new Exception("Доля от комиссии должна составлять от 0 до 100 процентов!");
                }
                //добавляем в таблицу AgentSet нового риелтора agentSet
                Program.wftDb.AgentSet.Add(agentSet);
                //сохраням изменения в модели wftDb (экзэмпляр созданный ранее)
                Program.wftDb.SaveChanges();
                ShowAgent();
            }
            catch(Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            //условие, если в listView выбран 1 элемент
            if (listViewAgent.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                //указываем, что может быть изменено
                agentSet.FirstName = textBoxFirstName.Text;
                agentSet.MiddleName = textBoxMiddleName.Text;
                agentSet.LastName = textBoxLastName.Text;
                agentSet.DealShare = Convert.ToInt32(textBoxDealShare.Text);
                //сохраням изменения в модели wftDb (экзэмпляр созданный ранее)
                Program.wftDb.SaveChanges();
                //отображение в listView
                ShowAgent();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if (listViewAgent.SelectedItems.Count == 1)
                {
                    //ищем этот элемент, сверяем его
                    AgentSet agentSet = listViewAgent.SelectedItems[0].Tag as AgentSet;
                    //удаляем из модели и базы данных
                    Program.wftDb.AgentSet.Remove(agentSet);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновлённый список
                    ShowAgent();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxDealShare.Text = "";
            }
            //если возникнет какая-то ошибка, типа запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

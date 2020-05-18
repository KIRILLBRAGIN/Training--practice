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
    public partial class FormClient : Form
    {
        public FormClient()
        {
            InitializeComponent();
            ShowClient();
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            //создаём новый экземпляр класса Клиент
            ClientsSet clientSet = new ClientsSet();
            //делаем ссылку на обьект, который хранится в textBox-ax
            clientSet.FirstName = textBoxFirstName.Text;
            clientSet.MiddleName = textBoxMiddleName.Text;
            clientSet.LastName = textBoxLastName.Text;
            clientSet.Phone = textBoxPhone.Text;
            clientSet.Email = textBoxEmail.Text;
            //добавляем в таблицу ClientsSet нового клиента clientSet
            Program.wftDb.ClientsSet.Add(clientSet);
            //сохраням изменения в модели wftDb (экзэмпляр созданный ранее)
            Program.wftDb.SaveChanges();
            ShowClient();
        }

        private void ListViewClient_SelectedIndexChanged(object sender, EventArgs e)
        {
            //условие, если выбран 1 элемент
            if(listViewClient.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем,что может быть изменено
                textBoxFirstName.Text = clientSet.FirstName;
                textBoxMiddleName.Text = clientSet.MiddleName;
                textBoxLastName.Text = clientSet.LastName;
                textBoxPhone.Text = clientSet.Phone;
                textBoxEmail.Text = clientSet.Email;
            }
            else
            {
                //условие, иначе, если не выбран ни один элемент, то задаём пустые поля
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        void ShowClient()
        {
            //предварительно очищаем listView
            listViewClient.Items.Clear();
            //проходимся по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (ClientsSet clientsSet in Program.wftDb.ClientsSet)
            {
                //создаём новый элемент в listView
                //для этого создаём новый массив строк
                ListViewItem item = new ListViewItem(new string[]
                {
                        //указываем необходимые поля
                        clientsSet.Id.ToString(), clientsSet.FirstName, clientsSet.MiddleName,
                        clientsSet.LastName, clientsSet.Phone, clientsSet.Email
                });
                //указываем по какому тегу будем брать элементы
                item.Tag = clientsSet;
                //добавляем элементы в listView для отображения
                listViewClient.Items.Add(item);
            }
            //выравниваем колонки в listView
            listViewClient.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            //условие, если в listView выбран 1 элемент
            if (listViewClient.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                //указываем, что может быть изменено
                clientSet.FirstName = textBoxFirstName.Text;
                clientSet.MiddleName = textBoxMiddleName.Text;
                clientSet.LastName = textBoxLastName.Text;
                clientSet.Phone = textBoxPhone.Text;
                clientSet.Email = textBoxEmail.Text;
                //сохраням изменения в модели wftDb (экзэмпляр созданный ранее)
                Program.wftDb.SaveChanges();
                //отображение в listView
                ShowClient();
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            //пробуем совершить действие
            try
            {
                //если выбран 1 элемент из listView
                if(listViewClient.SelectedItems.Count ==1)
                {
                    //ищем этот элемент, сверяем его
                    ClientsSet clientSet = listViewClient.SelectedItems[0].Tag as ClientsSet;
                    //удаляем из модели и базы данных
                    Program.wftDb.ClientsSet.Remove(clientSet);
                    //сохраняем изменения
                    Program.wftDb.SaveChanges();
                    //отображаем обновлённый список
                    ShowClient();
                }
                //очищаем textBox-ы
                textBoxFirstName.Text = "";
                textBoxMiddleName.Text = "";
                textBoxLastName.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
            //если возникнет какая-то ошибка, типа запись используется, выводим всплывающее сообщение
            catch
            {
                //вызываем метод для всплывающего окна, в котором указываем текст, заголовок, кнопку и иконку
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void LabelFirstName_Click(object sender, EventArgs e)
        {

        }
    }
}


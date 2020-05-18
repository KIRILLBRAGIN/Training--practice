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
    public partial class FormRealEstate : Form
    {
        public FormRealEstate()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 0;
            ShowRealEstateSet();
        }

        void ShowRealEstateSet()
        { 
            //Предваительно очищаем все listView
            listViewRealEstateSet_Apartment.Items.Clear();
            listViewRealEstateSet_House.Items.Clear();
            listViewRealEstateSet_Land.Items.Clear();

            //Проходим по коллекции клиентов, которые находятся в базе с помощью foreach
            foreach (RealEstateSet realEstate in Program.wftDb.RealEstateSet)
            {
                //отображение квартир в listViewRealEstateSet_Apartment
                if (realEstate.Type == 0)
                {
                    //создадим новый элемент в listViewRealEstateSet_Apartment с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[] 
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(), realEstate.Coordinate_longitude.ToString(),
                        realEstate.TotalArea.ToString(), realEstate.Rooms.ToString(), realEstate.Floor.ToString()
                    } );
                    //указываем по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_Apartment для отображения
                    listViewRealEstateSet_Apartment.Items.Add(item);
                }
                //отображение домов в listViewRealEstateSet_House 
                else if (realEstate.Type == 1)
                {
                    //создадим новый элемент в listViewRealEstateSet_House с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(), realEstate.Coordinate_longitude.ToString(),
                        realEstate.TotalArea.ToString(), realEstate.TotalFloors.ToString()

                    });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_House для отображения
                    listViewRealEstateSet_House.Items.Add(item);
                }

                else
                {
                    //создадим новый элемент в listViewRealEstateSet_Land с помощью массива строк
                    ListViewItem item = new ListViewItem(new string[]
                    {
                        //указываем необходимые поля
                        realEstate.Address_City, realEstate.Address_Street, realEstate.Address_House,
                        realEstate.Address_Number, realEstate.Coordinate_latitude.ToString(),
                        realEstate.Coordinate_longitude.ToString(), realEstate.TotalArea.ToString()
                    });
                    //указываем по какому тегу выбраны элементы
                    item.Tag = realEstate;
                    //добавляем элементы в listViewRealEstateSet_Land для отображения
                    listViewRealEstateSet_Land.Items.Add(item);
                }
            }
            //выравниваем столбцы во всех listView
            listViewRealEstateSet_Apartment.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_House.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewRealEstateSet_Land.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Изменения формы, если выбрана строчка "Квартира" (индекс 0)
            if (comboBoxType.SelectedIndex == 0)
            {
                //Делаем видимыми нужные элементы
                listViewRealEstateSet_Apartment.Visible = true;
                labelFloor.Visible = true;
                textBoxFloor.Visible = true;
                labelRooms.Visible = true;
                textBoxRooms.Visible = true;

                //Скрывааем ненужные элементы
                listViewRealEstateSet_House.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                //Очищаем все видимые элементы
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }

            //Изменения формы, если выбрана строчка "Дом" (индекс 1)
            else if (comboBoxType.SelectedIndex == 1)
            {
                //Делаем видимыми нужные элементы
                listViewRealEstateSet_House.Visible = true;
                labelTotalFloors.Visible = true;
                textBoxTotalFloors.Visible = true;
                
                //Скрывааем ненужные элементы
                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_Land.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;

                //Очищаем все видимые элементы
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";
            }

            //Изменения формы, если выбрана строчка "Земля" (индекс 2)
            else if (comboBoxType.SelectedIndex == 2)
            {
                //Делаем видимыми нужные элементы
                listViewRealEstateSet_Land.Visible = true;
                
                //Скрывааем ненужные элементы
                listViewRealEstateSet_Apartment.Visible = false;
                listViewRealEstateSet_House.Visible = false;
                labelFloor.Visible = false;
                textBoxFloor.Visible = false;
                labelRooms.Visible = false;
                textBoxRooms.Visible = false;
                labelTotalFloors.Visible = false;
                textBoxTotalFloors.Visible = false;

                //Очищаем все видимые элементы
                textBoxAddress_City.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

       

        private void FormRealEstate_Load(object sender, EventArgs e)
        {

        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //создаём новый экзэмпляр класса Объект недвижимости 
                RealEstateSet realEstate = new RealEstateSet();
                //делаем ссылку на объект, который хранится в textBox-ах (сначала общие поля)
                realEstate.Address_City = textBoxAddress_City.Text;
                realEstate.Address_House = textBoxAddress_House.Text;
                realEstate.Address_Street = textBoxAddress_Street.Text;
                realEstate.Address_Number = textBoxAddress_Number.Text;
                realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);

                if (textBoxCoordinate_latitude.Text != "")
                {
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                }
                if (realEstate.Coordinate_latitude < -90 || realEstate.Coordinate_latitude > 90)
                {
                    throw new Exception("Введите широту в диапазоне от -90 до 90");
                }

                if (textBoxCoordinate_longitude.Text != "")
                {
                    realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                }
                if (realEstate.Coordinate_longitude < -180 || realEstate.Coordinate_longitude > 180)
                {
                    throw new Exception("Введите долготу в диапазоне от -180 до 180");
                }

                //доп. поля для типа "Квартира"
                if (comboBoxType.SelectedIndex == 0)
                {
                    realEstate.Type = 0;
                    realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                }
                //доп. поля для типа "Дом"
                else if (comboBoxType.SelectedIndex == 1)
                {
                    realEstate.Type = 1;
                    realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);
                }
                //доп. поля для типа "Земля"
                else
                {
                    realEstate.Type = 2;
                    realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                }
                //добавляем в таблицу RealEstateSet новый объект недвижимости realEstate
                Program.wftDb.RealEstateSet.Add(realEstate);
                //сохраняем изменения в модели wftDb
                Program.wftDb.SaveChanges();
                ShowRealEstateSet();
            }
            catch (Exception a)
            {
                MessageBox.Show("" + a.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ButtonEdit_Click(object sender, EventArgs e)
        {
            //Выбран тип "Квартира", работа с listViewRealEstateSet_Apartment
            if (comboBoxType.SelectedIndex == 0)
            {
                //Если в listView выбраен элемент
                if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                    //указываем что может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    if (textBoxTotalArea.Text != "")
                    {
                        realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    }
                    if (textBoxRooms.Text != "")
                    {
                        realEstate.Rooms = Convert.ToInt32(textBoxRooms.Text);
                    }
                    if (textBoxFloor.Text != "")
                    {
                        realEstate.Floor = Convert.ToInt32(textBoxFloor.Text);
                    }
                    //сохраняем изменения в модели wftDb
                    Program.wftDb.SaveChanges();
                    //ОТОБРАЖАЕМ В listViewRealEstateSet_Apartment
                    ShowRealEstateSet();
                }
            }
            //Выбран тип "Дом", работа с listViewRealEstateSet_House
            else if (comboBoxType.SelectedIndex == 1)
            {
                //Если в listView выбраен элемент
                if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                    //указываем что может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    if (textBoxCoordinate_latitude.Text != "")
                    {
                        realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    }
                    if (textBoxCoordinate_longitude.Text != "")
                    {
                        realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    }
                    if (textBoxTotalArea.Text != "")
                    {
                        realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    }
                    if (textBoxTotalFloors.Text != "")
                    {
                        realEstate.TotalFloors = Convert.ToInt32(textBoxTotalFloors.Text);
                    }
                    //сохраняем изменения в модели wftDb
                    Program.wftDb.SaveChanges();
                    //ОТОБРАЖАЕМ В listViewRealEstateSet_House
                    ShowRealEstateSet();
                }
            }
            //Выбран тип "Земля", работа с listViewRealEstateSet_Land
            else
            {
                //Если в listView выбраен элемент
                if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                {
                    //ищем элемент из таблицы по тегу
                    RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                    //указываем что может быть изменено
                    realEstate.Address_City = textBoxAddress_City.Text;
                    realEstate.Address_House = textBoxAddress_House.Text;
                    realEstate.Address_Street = textBoxAddress_Street.Text;
                    realEstate.Address_Number = textBoxAddress_Number.Text;
                    if (textBoxCoordinate_latitude.Text != "")
                    {
                        realEstate.Coordinate_latitude = Convert.ToDouble(textBoxCoordinate_latitude.Text);
                    }
                    if (textBoxCoordinate_longitude.Text != "")
                    {
                        realEstate.Coordinate_longitude = Convert.ToDouble(textBoxCoordinate_longitude.Text);
                    }
                    if (textBoxTotalArea.Text != "")
                    {
                        realEstate.TotalArea = Convert.ToDouble(textBoxTotalArea.Text);
                    }
                    //сохраняем изменения в модели wftDb
                    Program.wftDb.SaveChanges();
                    //ОТОБРАЖАЕМ В listViewRealEstateSet_Land
                    ShowRealEstateSet();
                }
            }
        }

        private void ListViewRealEstateSet_Apartment_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран 1 элемент
            if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                //указываем что может быть изменено
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxRooms.Text = realEstate.Rooms.ToString();
                textBoxFloor.Text = realEstate.Floor.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаём пустые поля
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxRooms.Text = "";
                textBoxFloor.Text = "";
            }
        }

        private void ListViewRealEstateSet_House_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран 1 элемент
            if (listViewRealEstateSet_House.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                //указываем что может быть изменено
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
                textBoxTotalFloors.Text = realEstate.TotalFloors.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаём пустые поля
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
                textBoxTotalFloors.Text = "";
            }
        }

        private void ListViewRealEstateSet_Land_SelectedIndexChanged(object sender, EventArgs e)
        {
            //если выбран 1 элемент
            if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
            {
                //ищем элемент из таблицы по тегу
                RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                //указываем что может быть изменено
                textBoxAddress_City.Text = realEstate.Address_City;
                textBoxAddress_Street.Text = realEstate.Address_Street;
                textBoxAddress_House.Text = realEstate.Address_House;
                textBoxAddress_Number.Text = realEstate.Address_Number;
                textBoxCoordinate_latitude.Text = realEstate.Coordinate_latitude.ToString();
                textBoxCoordinate_longitude.Text = realEstate.Coordinate_longitude.ToString();
                textBoxTotalArea.Text = realEstate.TotalArea.ToString();
            }
            else
            {
                //если не выбран ни один элемент, задаём пустые поля
                textBoxAddress_City.Text = "";
                textBoxAddress_Street.Text = "";
                textBoxAddress_House.Text = "";
                textBoxAddress_Number.Text = "";
                textBoxCoordinate_latitude.Text = "";
                textBoxCoordinate_longitude.Text = "";
                textBoxTotalArea.Text = "";
            }
        }

        private void ButtonDel_Click(object sender, EventArgs e)
        {
            //попробуем совершить действие
            try
            {
                //Выбран тип "Квартира", работа с listViewRealEstateSet_Apartment
                if (comboBoxType.SelectedIndex == 0)
                {
                    //если в listViwe выбран элемент 
                    if (listViewRealEstateSet_Apartment.SelectedItems.Count == 1)
                    {
                        //ищем этот элементв базе по тегу
                        RealEstateSet realEstate = listViewRealEstateSet_Apartment.SelectedItems[0].Tag as RealEstateSet;
                        //удаляем из модели базы данных
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        //сохраняем изменения
                        Program.wftDb.SaveChanges();
                        //отображаем обновлённый список
                        ShowRealEstateSet();
                    }
                    //очищаем текстовые поля
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxRooms.Text = "";
                    textBoxFloor.Text = "";
                }
                //Выбран тип "Дом", работа с listViewRealEstateSet_House
                else if (comboBoxType.SelectedIndex == 1)
                {
                    //если в listView выбран элемент
                    if (listViewRealEstateSet_House.SelectedItems.Count == 1)
                    {
                        //ищем этот элементв базе по тегу
                        RealEstateSet realEstate = listViewRealEstateSet_House.SelectedItems[0].Tag as RealEstateSet;
                        //удаляем из модели базы данных
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        //сохраняем изменения
                        Program.wftDb.SaveChanges();
                        //отображаем обновлённый список
                        ShowRealEstateSet();
                    }
                    //очищаем текстовые поля
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                    textBoxTotalFloors.Text = "";
                }
                //Выбран тип "Земля", работа с listViewRealEstateSet_Land
                else
                {
                    //если в listView выбран элемент
                    if (listViewRealEstateSet_Land.SelectedItems.Count == 1)
                    {
                        //ищем этот элементв базе по тегу
                        RealEstateSet realEstate = listViewRealEstateSet_Land.SelectedItems[0].Tag as RealEstateSet;
                        //удаляем из модели базы данных
                        Program.wftDb.RealEstateSet.Remove(realEstate);
                        //сохраняем изменения
                        Program.wftDb.SaveChanges();
                        //отображаем обновлённый список
                        ShowRealEstateSet();
                    }
                    //очищаем текстовые поля
                    textBoxAddress_City.Text = "";
                    textBoxAddress_House.Text = "";
                    textBoxAddress_Street.Text = "";
                    textBoxAddress_Number.Text = "";
                    textBoxCoordinate_latitude.Text = "";
                    textBoxCoordinate_longitude.Text = "";
                    textBoxTotalArea.Text = "";
                }
            }
            //если возникает какая то ошибка
            catch
            {
                MessageBox.Show("Не возможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TextBoxCoordinate_latitude_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextBoxAddress_Number_TextChanged(object sender, EventArgs e)
        {

        }

        private void LabelCoordinate_latitude_Click(object sender, EventArgs e)
        {

        }

        private void LabelTotalFloors_Click(object sender, EventArgs e)
        {

        }
    }
}

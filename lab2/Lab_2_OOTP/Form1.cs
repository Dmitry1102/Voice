using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_OOTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxType.SelectedIndex = 2;
        }
        List<Transport> Trans = new List<Transport>();

        //Обновление dataGridView
        private void dataGridAndAllListsUpdate()
        {
            listBoxInfo.Items.Clear();
            listBoxInfo.Items.Add("Выберите ТС.");
            dataGridView1.Rows.Clear();
            ClearTextBoxes();
            for (int i = 0; i < Trans.Count; i++)
                dataGridView1.Rows.Add(Trans[i].Name, Trans[i].Cost, $"Город.{Trans[i].Fact.City}, название.{Trans[i].Fact.Name1}", Trans[i].Engine);
        }



        private void buttonDelete_Click(object sender, EventArgs e)
        {
                 Trans.RemoveAt(dataGridView1.SelectedCells[0].RowIndex);
                   MessageBox.Show("Транспортное средство удалено");
            dataGridView1.Rows.Clear();
        }

        private void ClearTextBoxes()
        {
            textBoxName.Clear();
            textBoxEngine.Clear();
            textBoxCost.Clear();
            textBoxCategory.Clear();
            textBoxSurname.Clear();
           
            textBoxCity.Clear();
            textBoxFact.Clear();
            textBoxDriveName.Clear();
           
            textBox1.Clear();
          
            comboBoxType.SelectedIndex = 0;
        }

        private void FillTextBoxes()
        {
            textBoxName.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Name;

            textBoxEngine.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Cost.ToString();
            textBoxCity.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.City;
            textBoxFact.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.Name1;
            textBoxDriveName.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Name2;
            textBoxSurname.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Surname;
            textBoxCategory.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Category;
            textBoxCost.Text = Trans[dataGridView1.SelectedCells[0].RowIndex].Engine;

            comboBoxType.SelectedIndex = 0;
            if (Trans[dataGridView1.SelectedCells[0].RowIndex] is GroundTransport)
            {
                comboBoxType.SelectedIndex = 1;
                GroundTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as GroundTransport;
                textBox1.Text = curr.Transmission.ToString();
            }
            else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is WaterTransport)
            {
                comboBoxType.SelectedIndex = 2;
                WaterTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as WaterTransport;
                textBox1.Text = curr.CountDeck.ToString();
                textBox2.Text = curr.Crew.ToString();
            }
            else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is AirTransport)
            {
                comboBoxType.SelectedIndex = 3;
                AirTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as AirTransport;
                textBox1.Text = curr.Capacity.ToString();
                textBox2.Text = curr.Weight.ToString();
                
              
            }
            else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is WorkTransport)
            {
                comboBoxType.SelectedIndex = 4;
                WorkTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as WorkTransport;
                textBox1.Text = curr.Size.ToString();
                textBox2.Text = curr.Kind.ToString();
            }
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (inputtedValues())
                {
                   Trans[dataGridView1.SelectedCells[0].RowIndex].Name = textBoxName.Text;
                    
                    Trans[dataGridView1.SelectedCells[0].RowIndex].Cost = Convert.ToInt32(textBoxCost.Text);
                    Trans[dataGridView1.SelectedCells[0].RowIndex].Engine = textBoxEngine.Text;
                    Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.City = textBoxCity.Text;
                    Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.Name1 = textBoxFact.Text;
                    Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Name2 = textBoxDriveName.Text;
                    Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Surname = textBoxSurname.Text;


                    comboBoxType.SelectedIndex = 0;
                    if (Trans[dataGridView1.SelectedCells[0].RowIndex] is GroundTransport)
                    {
                        comboBoxType.SelectedIndex = 1;
                        GroundTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as GroundTransport;
                        curr.Transmission = Convert.ToInt32(textBox1.Text);
                        Trans[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is WaterTransport)
                    {
                        comboBoxType.SelectedIndex = 2;
                        WaterTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as WaterTransport;
                        curr.CountDeck = Convert.ToInt32(textBox1.Text);
                        curr.Crew = Convert.ToInt32(textBox2.Text);
                        Trans[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is AirTransport)
                    {
                        comboBoxType.SelectedIndex = 3;
                        AirTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as AirTransport;
                        curr.Capacity = Convert.ToInt32(textBox1.Text);
                        curr.Weight = Convert.ToInt32(textBox2.Text);
                        Trans[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is WorkTransport)
                    {
                        comboBoxType.SelectedIndex = 4;
                        WorkTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as WorkTransport;
                        curr.Size = Convert.ToInt32(textBox1.Text);
                        curr.Kind = Convert.ToInt32(textBox2.Text);
                        Trans[dataGridView1.SelectedCells[0].RowIndex] = curr;
                    }
                    dataGridAndAllListsUpdate();
                    ClearTextBoxes();
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Выберите ТС!");
            }
        }


        private void listBoxInfo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            listBoxInfo.Items.Clear();
            FillTextBoxes();
            try
            {
              
                listBoxInfo.Items.Add($"Название: { Trans[dataGridView1.SelectedCells[0].RowIndex].Name}");
                listBoxInfo.Items.Add($"Стоимость: { Trans[dataGridView1.SelectedCells[0].RowIndex].Cost}");
                listBoxInfo.Items.Add($"Двигатель: { Trans[dataGridView1.SelectedCells[0].RowIndex].Engine}");
                listBoxInfo.Items.Add($"Завод Изготовитель: город{Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.City}, название {Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.Name1}");
                listBoxInfo.Items.Add($"Водитель: Имя {Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Name2}, Фамилия {Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Surname}, Категория {Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Category}");



                if (Trans[dataGridView1.SelectedCells[0].RowIndex] is GroundTransport)
                {
                    GroundTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as GroundTransport;
                    listBoxInfo.Items.Add("Тип Транспортного средства: Наземный Транспорт");
                    listBoxInfo.Items.Add($"Тип коробки: {curr.Transmission}");
                }
                else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is WaterTransport)
                {
                    WaterTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as WaterTransport;
                    listBoxInfo.Items.Add("Тип Транспортного средства: Водный Транспорт");
                    listBoxInfo.Items.Add($"Количество Цилиндров: { curr.CountDeck}");
                    listBoxInfo.Items.Add($"Экипаж: { curr.Crew} кол-во человек");
                }
                else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is AirTransport)
                {
                    AirTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as AirTransport;
                    listBoxInfo.Items.Add("Тип Транспортного средства: Воздушный Транспорт");
                    listBoxInfo.Items.Add($"Вместимость: { curr.Capacity}");
                    listBoxInfo.Items.Add($"Вес: { curr.Weight}");

                }
                
                else if (Trans[dataGridView1.SelectedCells[0].RowIndex] is WorkTransport)
                {
                    WorkTransport curr = Trans[dataGridView1.SelectedCells[0].RowIndex] as WorkTransport;
                    listBoxInfo.Items.Add("Тип Транспортного средства: Рабочий Транспорт");
                    listBoxInfo.Items.Add($"Размер: { curr.Size}");
                    listBoxInfo.Items.Add($"Тип: { curr.Kind}");
                }
                else
                {
                    listBoxInfo.Items.Add("Тип Транспортного средства: Транспорт");
                }
            }
            catch
            {
                MessageBox.Show("Выберите Транспортное Средство!");
            }
        }

        private static Transport getWorkerTypeByString(string transChosen, string name, int cost, Factory fact,
            Driver driver,string engine, int firstParam, int secondParam)
        {
            if (transChosen.Equals("Не уточнено"))
                return new Transport(name, cost, fact, driver, engine);
            else if (transChosen.Equals("Наземный Транспорт"))
                return new GroundTransport(name, cost, fact, driver, engine, firstParam);
            else if (transChosen.Equals("Водный Транпорт"))
                return new WaterTransport(name, cost, fact, driver, engine, firstParam, secondParam);
            else if (transChosen.Equals("Воздушный Транспорт"))
                return new AirTransport( name, cost, fact, driver, engine, firstParam, secondParam);
            else if (transChosen.Equals("Рабочий Транспорт"))
                return new WorkTransport(name, cost, fact, driver, engine, firstParam, secondParam);
            else
                throw new Exception(transChosen + " не существует в списке назначений!");
        }

        private bool inputtedValues()
        {
            if (textBoxName.Text == "" || textBoxCost.Text == "" || textBoxEngine.Text == "" || textBoxCity.Text == "" || 
                textBoxFact.Text == "" || textBoxDriveName.Text == "")
                return false;
            else
                return true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (inputtedValues())
            {
                Factory currFact;
                Driver currDrive;


                    currFact = new Factory(textBoxCity.Text, textBoxFact.Text);
                    currDrive = new Driver(textBoxDriveName.Text,textBoxSurname.Text,textBoxCategory.Text);
                    
                int firstParam;
                int secondParam;
                try
                {
                    firstParam = Convert.ToInt32(textBox1.Text);
                    secondParam = Convert.ToInt32(textBox2.Text);
                }
                catch
                {
                    firstParam = 0;
                    secondParam = 0;
                }
                Transport transp = getWorkerTypeByString(comboBoxType.Text.ToString(),textBoxName.Text,  
                   Convert.ToInt32(textBoxCost.Text), currFact, currDrive,  textBoxEngine.Text, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                Trans.Add(transp);
                dataGridAndAllListsUpdate();

            }
            else
            {
                MessageBox.Show("Заполните все поля!");
            }

            
        }

        

        private void textBoxCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) == true || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
                return;
            e.Handled = true;
            return;
        }

        private void comboBoxProfession_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Visible = true;
            textBox2.Visible = true;
            

            labelFirst.Visible = true;
            labelSecond.Visible = true;
        
            if (comboBoxType.SelectedIndex == 0)
            {
                textBox1.Visible = false;
                textBox2.Visible = false;
               
                labelFirst.Visible = false;
                labelSecond.Visible = false;
            }
            else if (comboBoxType.SelectedIndex == 1)
            {
                textBox2.Visible = false;
                labelSecond.Visible = false;
                labelFirst.Text = "Коробка передач:";
            }
            else if (comboBoxType.SelectedIndex == 2)
            {
                
                labelFirst.Text = "Количество Цилиндров:";
                labelSecond.Text = "Количество Людей:";
            }
            else if (comboBoxType.SelectedIndex == 3)
            {
                
                labelFirst.Text = "Вместимость:";
                labelSecond.Text = "Вес:";
            }
            else if (comboBoxType.SelectedIndex == 4)
            {
                
                labelFirst.Text = "Размер:";
                labelSecond.Text = "Тип:";

            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

       
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using ZipInterface;
using System.Reflection;
using System.IO.Compression;

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
            listBox1.Items.Clear();
            FillTextBoxes();
            try
            {

                listBoxInfo.Items.Add($"Название: { Trans[dataGridView1.SelectedCells[0].RowIndex].Name}");
                listBoxInfo.Items.Add($"Стоимость: { Trans[dataGridView1.SelectedCells[0].RowIndex].Cost}");
                listBoxInfo.Items.Add($"Двигатель: { Trans[dataGridView1.SelectedCells[0].RowIndex].Engine}");
                listBoxInfo.Items.Add($"Завод Изготовитель: город{Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.City}, название {Trans[dataGridView1.SelectedCells[0].RowIndex].Fact.Name1}");
                listBox1.Items.Add($"Водитель: Имя{Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Name2}, Фамилия {Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Surname}, Категория {Trans[dataGridView1.SelectedCells[0].RowIndex].Driver.Surname}");


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
            Driver driver, string engine, int firstParam, int secondParam)
        {
            if (transChosen.Equals("Не уточнено"))
                return new Transport(name, cost, fact, driver, engine);
            else if (transChosen.Equals("Наземный Транспорт"))
                return new GroundTransport(name, cost, fact, driver, engine, firstParam);
            else if (transChosen.Equals("Водный Транпорт"))
                return new WaterTransport(name, cost, fact, driver, engine, firstParam, secondParam);
            else if (transChosen.Equals("Воздушный Транспорт"))
                return new AirTransport(name, cost, fact, driver, engine, firstParam, secondParam);
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
                currDrive = new Driver(textBoxDriveName.Text, textBoxSurname.Text, textBoxCategory.Text);

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
                Transport transp = getWorkerTypeByString(comboBoxType.Text.ToString(), textBoxName.Text,
                   Convert.ToInt32(textBoxCost.Text), currFact, currDrive, textBoxEngine.Text, Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
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

        private void EMPLButt_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBoxDriveName.Text + ' ' + textBoxSurname.Text + ' ' + textBoxCategory.Text);
        }


        private void ChooseYourFighter(string s, bool saving)
        {
            if (saving)
            {
                if (s.IndexOf(".dat") > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        formatter.Serialize(fs, Trans);
                    }
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".json") > 0)
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Transport>),
                        new Type[] { typeof(WorkTransport), typeof(WaterTransport), typeof(GroundTransport), typeof(AirTransport) });
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        jsonFormatter.WriteObject(fs, Trans);
                    }
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".txt") > 0)
                {
                    string text = "";
                    for (int i = 0; i < Trans.Count; i++)
                    {

                        if (Trans[i] is WorkTransport)
                        {
                            WorkTransport curr = Trans[i] as WorkTransport;
                            text += $"''|Рабочий Транспорт'{curr.Name}'|'{curr.Cost}'|'{curr.Fact.City}'|'{curr.Fact.Name1}'|'{curr.Driver.Name2}'|'" +
                                $"{curr.Driver.Surname}'|'{curr.Driver.Category}'|'{curr.Engine}'|'{curr.Size}'|'{curr.Kind}'\r\n";
                        }
                        else if (Trans[i] is WaterTransport)
                        {
                            WaterTransport curr = Trans[i] as WaterTransport;
                            text += $"'Водный Транспорт'|'{curr.Name}'|'{curr.Cost}'|'{curr.Fact.City}'|'{curr.Fact.Name1}'|'{curr.Driver.Name2}'|'" +
                                $"{curr.Driver.Surname}'|'{curr.Driver.Category}'|'{curr.Engine}'|'{curr.CountDeck}'|'{curr.Crew}'\r\n";
                        }
                        else if (Trans[i] is GroundTransport)
                        {
                            GroundTransport curr = Trans[i] as GroundTransport;
                            text += $"'Наземный Транспорт'|'{curr.Name}'|'{curr.Cost}'|'{curr.Fact.City}'|'{curr.Fact.Name1}'|'{curr.Driver.Name2}'|'" +
                                $"{curr.Driver.Surname}'|'{curr.Driver.Category}'|'{curr.Engine}'|'{curr.Transmission}'\r\n";
                        }
                        else if (Trans[i] is AirTransport)
                        {
                            AirTransport curr = Trans[i] as AirTransport;
                            text += $"'Воздушный Транспорт'|'{curr.Name}'|'{curr.Cost}'|'{curr.Fact.City}'|'{curr.Fact.Name1}'|'{curr.Driver.Name2}'|'" +
                                $"{curr.Driver.Surname}'|'{curr.Driver.Category}'|'{curr.Engine}'|'{curr.Capacity}'|'{curr.Weight}'\r\n";
                        }
                        else
                        {
                            Transport curr = Trans[i] as Transport;
                            text += $"'Не уточнено'|'{curr.Name}'|'{curr.Cost}'|'{curr.Fact.City}'|'{curr.Fact.Name1}'|'{curr.Driver.Name2}'|'" +
                                $"{curr.Driver.Surname}'|'{curr.Driver.Category}'|'{curr.Engine}'\r\n";
                        }
                    }
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        byte[] array = Encoding.Default.GetBytes(text);
                        fs.Write(array, 0, array.Length);
                    }
                    MessageBox.Show("Успешно!");
                }
                else
                    MessageBox.Show("Что-то пошло не так!");
            }
            else
            {
                if (s.IndexOf(".dat") > 0)
                {
                    BinaryFormatter formatter = new BinaryFormatter();
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        Trans = (List<Transport>)formatter.Deserialize(fs);
                    }
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".json") > 0)
                {
                    DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(List<Transport>),
                        new Type[] { typeof(WorkTransport), typeof(WaterTransport), typeof(GroundTransport), typeof(AirTransport) });
                    using (FileStream fs = new FileStream(s, FileMode.OpenOrCreate))
                    {
                        Trans = (List<Transport>)jsonFormatter.ReadObject(fs);
                    }
                    MessageBox.Show("Успешно!");
                }
                else if (s.IndexOf(".txt") > 0)
                {
                    using (StreamReader sr = new StreamReader(s, System.Text.Encoding.Default))
                    {
                        while (!sr.EndOfStream)
                        {
                            string[] line = sr.ReadLine().Split('|');
                            string clName = line[0].Substring(1, line[0].Length - 2);
                            string name = line[1].Substring(1, line[1].Length - 2);
                            int cost = Convert.ToInt32(line[2].Substring(1, line[2].Length - 2));
                            string engine = line[3].Substring(1, line[3].Length - 2);
                            string city = line[4].Substring(1, line[4].Length - 2);
                            string name1 = line[5].Substring(1, line[5].Length - 2);
                            string name2 = line[6].Substring(1, line[6].Length - 2);
                            string surname = line[7].Substring(1, line[7].Length - 2);
                            string category = line[8].Substring(1, line[8].Length - 2);
                            int firstParam = Convert.ToInt32(line[9].Substring(1, line[9].Length - 2));
                            int secondparam = Convert.ToInt32(line[10].Substring(1, line[10].Length - 2));


                            Driver currDrive = new Driver(name2, surname, category);
                            Factory currFact = new Factory(city, name1);
                            Transport trans1 = getWorkerTypeByString(clName, name, cost, currFact, currDrive, engine, firstParam, secondparam);
                            Trans.Add(trans1);
                        }
                    }
                    MessageBox.Show("Успешно!");
                }
                else
                    MessageBox.Show("Что-то пошло не так!");
            }
        }




        private void DESERIALButt_Click(object sender, EventArgs e)
        {

            Trans.Clear();

            string FileName;
            string FileExtension;
            string FileToDeserialize = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog1.FileName;
                FileExtension = Path.GetExtension(FileName);
            }
            else
                return;


            if (FileExtension == ".zip")
            {
                string DllName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "ZipArchive.dll");
                if (!File.Exists(DllName))
                {
                    Console.Write("Плагин " + DllName + " не найден.");
                    return;
                }

                Assembly AboutAssembly = Assembly.LoadFrom(DllName);

                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    if (t.IsClass && typeof(IZip).IsAssignableFrom(t))
                    {
                        IZip about = (IZip)Activator.CreateInstance(t);
                        FileToDeserialize = about.UnZip(FileName, Path.GetFileNameWithoutExtension(FileName));
                        break;
                    }
                }
            }
            else if (FileExtension == ".gz")
            {
                string DllName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "GzArchive.dll");
                if (!File.Exists(DllName))
                {
                    Console.Write("Плагин " + DllName + " не найден.");
                    return;
                }
                Assembly AboutAssembly = Assembly.LoadFrom(DllName);

                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    if (t.IsClass && typeof(IZip).IsAssignableFrom(t))
                    {
                        IZip about = (IZip)Activator.CreateInstance(t);
                        FileToDeserialize = about.UnZip(FileName, Path.GetFileNameWithoutExtension(FileName));
                        break;
                    }
                }
            }
            if (FileExtension == ".bz2")
            {

                string DllName = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Bz2Archive.dll");
                if (!File.Exists(DllName))
                {
                    Console.Write("Плагин " + DllName + " не найден.");
                    return;
                }
                Assembly AboutAssembly = Assembly.LoadFrom(DllName);

                foreach (Type t in AboutAssembly.GetExportedTypes())
                {
                    if (t.IsClass && typeof(IZip).IsAssignableFrom(t))
                    {
                        IZip about = (IZip)Activator.CreateInstance(t);
                        FileToDeserialize = about.UnZip(FileName, Path.GetFileNameWithoutExtension(FileName));
                        break;
                    }
                }
            }
            //if (filename.Contains("cipher_"))

            if (FileToDeserialize == "")
                ChooseYourFighter(FileName, false);
            else
            {
                ChooseYourFighter(FileToDeserialize, false);

            }


            dataGridAndAllListsUpdate();

        }

        private void SERIALButt_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;

            ChooseYourFighter(filename, true);

        }

        private void Zip(string FileToZip)
        {
            var data = File.ReadAllBytes(FileToZip);
            var newPathParts = FileToZip.Split('.');
            newPathParts[newPathParts.Length - 1] = "gz";
            var newPath = String.Join(".", newPathParts);

            using (var targetStream = new FileStream(FileToZip, FileMode.Create))
            using (var compressionStream = new GZipStream(targetStream, CompressionMode.Compress))
            {

                compressionStream.Write(data, 0, data.Count());


            }


            File.Delete(FileToZip);
        }

       
    }


    


}

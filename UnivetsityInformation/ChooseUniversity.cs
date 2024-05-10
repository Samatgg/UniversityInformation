using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;

namespace UnivetsityInformation
{
    public partial class ChooseUniversityForm : Form
    {
        private List<string> cities = new List<string>();
        private List<string> universities = new List<string>();
        public ChooseUniversityForm()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            string[] cityLines = File.ReadAllLines(@"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\City.txt");
            cities.AddRange(cityLines);

            string[] universityLines = File.ReadAllLines(@"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\University.txt");
            universities.AddRange(universityLines);

            foreach (string city in cities)
            {
                comboBoxCities.Items.Add(city);
            }

            foreach (string university in universities)
            {
                string[] universityInfo = university.Split(',');
                string[] universityDetails = universityInfo[0].Split('.');
                string universityNumber = universityDetails[universityDetails.Length - 1].Trim();
                string cityId = universityInfo[1].Trim();
                string cityName = cities[int.Parse(cityId) - 1];
                dataGridViewUniversities.Rows.Add( universityDetails[0], universityNumber, cityName);
            }
            dataGridViewUniversities.CellClick += dataGridViewUniversities_CellClick;
        }

        private void comboBoxCities_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCity = comboBoxCities.SelectedItem.ToString();
            dataGridViewUniversities.Rows.Clear();

            foreach (string university in universities)
            {
                string[] universityInfo = university.Split(',');
                string[] universityDetails = universityInfo[0].Split('.');
                string universityNumber = universityDetails[universityDetails.Length - 1].Trim();
                string cityId = universityInfo[1].Trim();
                string cityName = cities[int.Parse(cityId) - 1];
                if (cityName == selectedCity)
                {
                    dataGridViewUniversities.Rows.Add(universityDetails[0], universityNumber, cityName);
                }
            }
        }

        private void dataGridViewUniversities_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены, что хотите выйти из приложения?", "Выход", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void изменитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewUniversities.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewUniversities.SelectedRows[0].Index;

                string universityName = dataGridViewUniversities.Rows[selectedIndex].Cells[1].Value.ToString();
                string cityName = dataGridViewUniversities.Rows[selectedIndex].Cells[2].Value.ToString();
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для изменения.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewUniversities.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridViewUniversities.SelectedRows[0].Index;

                dataGridViewUniversities.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] row7 = new string[]{"7","КХТИ","Казань"};
            string[] row8 = new string[] { "8", "ВШЭ", "Москва" };
            object[] rows = new object[] { row7, row8};

            foreach (string[] rowArray in rows)
            {

                int universityId = dataGridViewUniversities.Rows.Add(rowArray); 
            }
        }
        
    private void dataGridViewUniversities_DoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewUniversities.Rows.Count)
            {
                string universityId = dataGridViewUniversities.Rows[e.RowIndex].Cells[0].Value.ToString();
                string universityName = dataGridViewUniversities.Rows[e.RowIndex].Cells[1].Value.ToString();
                string cityName = dataGridViewUniversities.Rows[e.RowIndex].Cells[2].Value.ToString();
                string imagePath = "";
                string infoFilePath = @"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\info\information.txt";

                string[] allLines = File.ReadAllLines(infoFilePath);
                string universityInfo = "";
                bool foundUniversity = false;

                if (universityName == "КФУ")
                {
                    imagePath = @"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\images\1 КФУ.jpg";
                }
                else if (universityName == "МГУ")
                {
                    imagePath = @"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\images\2 МГУ.jpg";
                }
                else if (universityName == "СПБГУ")
                {
                    imagePath = @"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\images\3 СПБГУ.jpg";
                }
                else if (universityName == "ИТМО")
                {
                    imagePath = @"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\images\4 ИТМО.jpg";
                }
                else if (universityName == "МФТИ")
                {
                    imagePath = @"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\images\5 МФТИ.jpg";
                }
                else if (universityName == "КАИ")
                {
                    imagePath = @"C:\Users\samat\source\repos\UnivetsityInformation\UnivetsityInformation\images\6 КАИ.jpg";
                }
                else if (universityName == "КХТИ") ;
                else if (universityName == "ВШЭ") ;

                else
                {
                    universityInfo = "Этого университета нет!";
                }
                
                foreach (string line in allLines)
                {
                    if (line.Contains($"Университет: {universityName}"))
                    {
                        foundUniversity = true;
                    }
                    else if (foundUniversity)
                    {
                        if (line.StartsWith("Университет:") && !string.IsNullOrEmpty(universityInfo))
                        {
                            break;
                        }
                        universityInfo += line + Environment.NewLine;
                    }
                }
                UniversityInfoForm infoForm = new UniversityInfoForm(universityName, cityName, universityInfo, imagePath);
                infoForm.Show();
            }
            
        }
    }
}

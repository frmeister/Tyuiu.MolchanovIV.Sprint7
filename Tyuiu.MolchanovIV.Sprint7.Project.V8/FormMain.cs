using System.Windows.Forms;
using Tyuiu.MolchanovIV.Sprint7.Project.V8.Lib;

namespace Tyuiu.MolchanovIV.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        static string openFilePath;

        static bool gridExists = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
            openFilePath = openFileDialogMain.FileName;

            buttonOutput_Car.Enabled = true;
            buttonOutput_Point.Enabled = true;
            buttonOutput_Driver.Enabled = true;
        }

        private void CopyGrid()
        {
            dataGridViewOutput_Previous.ColumnCount = dataGridViewOutput_Current.Columns.Count;
            dataGridViewOutput_Previous.RowCount = dataGridViewOutput_Current.Rows.Count;

            int prevColumns = dataGridViewOutput_Previous.Columns.Count;
            int prevRows = dataGridViewOutput_Previous.Rows.Count;

            for (int i = 0; i < prevRows; i++)
            {
                for (int j = 0; j < prevColumns; j++)
                {
                    dataGridViewOutput_Previous.Rows[i].Cells[j].Value = dataGridViewOutput_Current.Rows[i].Cells[j].Value;
                }
            }

            for (int i = 0; i < prevColumns; i++)
                dataGridViewOutput_Previous.Columns[i].HeaderText = dataGridViewOutput_Current.Columns[i].HeaderText;
        }

        private void buttonOutput_Car_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridExists)
                {
                    CopyGrid();
                }
                else gridExists = true;


                string[,] arrValues = ds.getInputCarInto(openFilePath);

                int rows = arrValues.GetLength(0);
                int columns = arrValues.GetLength(1);

                dataGridViewOutput_Current.ColumnCount = columns;
                dataGridViewOutput_Current.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOutput_Current.Rows[i].Cells[j].Value = arrValues[i, j];
                    }
                }

                dataGridViewOutput_Current.Columns[0].HeaderText = "Гос. номер";
                dataGridViewOutput_Current.Columns[1].HeaderText = "Марка";
                dataGridViewOutput_Current.Columns[2].HeaderText = "Тех. состояние";
                dataGridViewOutput_Current.Columns[3].HeaderText = "Местонахождение";
                dataGridViewOutput_Current.Columns[4].HeaderText = "Ср. скорость";
                dataGridViewOutput_Current.Columns[5].HeaderText = "Грузоподъемность";
                dataGridViewOutput_Current.Columns[6].HeaderText = "Расход";

                buttonOutput_Car.Enabled = false;
                buttonOutput_Driver.Enabled = true;
                buttonOutput_Point.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutput_Driver_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridExists)
                {
                    CopyGrid();
                }
                else gridExists = true;

                string[,] arrValues = ds.getInputDriverInto(openFilePath);

                int rows = arrValues.GetLength(0);
                int columns = arrValues.GetLength(1);

                dataGridViewOutput_Current.ColumnCount = columns;
                dataGridViewOutput_Current.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOutput_Current.Rows[i].Cells[j].Value = arrValues[i, j];
                    }
                }

                dataGridViewOutput_Current.Columns[0].HeaderText = "Табельный номер";
                dataGridViewOutput_Current.Columns[1].HeaderText = "Фамилия";
                dataGridViewOutput_Current.Columns[2].HeaderText = "Имя";
                dataGridViewOutput_Current.Columns[3].HeaderText = "Отчество";
                dataGridViewOutput_Current.Columns[4].HeaderText = "Дата рождения";
                dataGridViewOutput_Current.Columns[5].HeaderText = "Стаж";
                dataGridViewOutput_Current.Columns[6].HeaderText = "Оклад";

                buttonOutput_Car.Enabled = true;
                buttonOutput_Driver.Enabled = false;
                buttonOutput_Point.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutput_Point_Click(object sender, EventArgs e)
        {
            try
            {

                if (gridExists)
                {
                    CopyGrid();
                }
                else gridExists = true;

                string[,] arrValues = ds.getInputPointInto(openFilePath);

                int rows = arrValues.GetLength(0);
                int columns = arrValues.GetLength(1);

                dataGridViewOutput_Current.ColumnCount = columns;
                dataGridViewOutput_Current.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewOutput_Current.Rows[i].Cells[j].Value = arrValues[i, j];
                    }
                }

                dataGridViewOutput_Current.Columns[0].HeaderText = "Дата выезда";
                dataGridViewOutput_Current.Columns[1].HeaderText = "Дата прибытия";
                dataGridViewOutput_Current.Columns[2].HeaderText = "Место назначения";
                dataGridViewOutput_Current.Columns[3].HeaderText = "Расстояние";
                dataGridViewOutput_Current.Columns[4].HeaderText = "Расход горючего";
                dataGridViewOutput_Current.Columns[5].HeaderText = "Масса груза";

                buttonOutput_Car.Enabled = true;
                buttonOutput_Driver.Enabled = true;
                buttonOutput_Point.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            FormAbout formabout = new FormAbout();
            formabout.ShowDialog();
        }
    }
}

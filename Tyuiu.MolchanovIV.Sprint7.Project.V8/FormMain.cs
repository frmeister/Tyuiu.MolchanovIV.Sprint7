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

        }
    }
}

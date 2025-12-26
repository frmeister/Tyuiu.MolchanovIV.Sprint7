using Tyuiu.MolchanovIV.Sprint7.Project.V8.Lib;

namespace Tyuiu.MolchanovIV.Sprint7.Project.V8
{
    public partial class FormMain : Form
    {
        DataService ds = new DataService();

        static string openFilePath;

        private string[,] currentData;

        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {
            openFileDialogMain.ShowDialog();
            openFilePath = openFileDialogMain.FileName;

            buttonOutput_Car.Enabled = true;
            buttonOutput_City.Enabled = true;
            buttonOutput_Driver.Enabled = true;
        }

        private void buttonOutput_Car_Click(object sender, EventArgs e)
        {
            try
            {
                string[,] arrValues = ds.getInputCarInto(openFilePath);

                int rows = arrValues.GetLength(0);
                int columns = arrValues.GetLength(1);

                if (rows == 0 || columns == 0)
                {
                    MessageBox.Show("Файл не содержит данных", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                dataGridViewOutput_Current.ColumnCount = columns;
                dataGridViewOutput_Current.RowCount = rows;

                for (int i = 0; i < rows; i++)
                {
                  for (int j = 0; j < columns; j++)
                  {
                        dataGridViewOutput_Current.Rows[i].Cells[j].Value = arrValues[i, j];
                    }
                }
            }
            catch
            {
                MessageBox.Show("Что-то пошло не так", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

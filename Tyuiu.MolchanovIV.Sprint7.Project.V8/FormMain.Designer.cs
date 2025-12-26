namespace Tyuiu.MolchanovIV.Sprint7.Project.V8
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelInfo = new Panel();
            info_groupBoxGeneral = new GroupBox();
            info_textBoxGeneral = new TextBox();
            panelInteract = new Panel();
            buttonOutput_Car = new Button();
            buttonOutput_Driver = new Button();
            buttonAbout = new Button();
            buttonOutput_Point = new Button();
            buttonInput = new Button();
            splitContainerMain = new SplitContainer();
            groupBoxOutput_Current = new GroupBox();
            dataGridViewOutput_Current = new DataGridView();
            groupBoxOutput_Previous = new GroupBox();
            dataGridViewOutput_Previous = new DataGridView();
            openFileDialogMain = new OpenFileDialog();
            toolTipGeneral = new ToolTip(components);
            panelInfo.SuspendLayout();
            info_groupBoxGeneral.SuspendLayout();
            panelInteract.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).BeginInit();
            splitContainerMain.Panel1.SuspendLayout();
            splitContainerMain.Panel2.SuspendLayout();
            splitContainerMain.SuspendLayout();
            groupBoxOutput_Current.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_Current).BeginInit();
            groupBoxOutput_Previous.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_Previous).BeginInit();
            SuspendLayout();
            // 
            // panelInfo
            // 
            panelInfo.BackColor = SystemColors.Control;
            panelInfo.Controls.Add(info_groupBoxGeneral);
            panelInfo.Dock = DockStyle.Top;
            panelInfo.Location = new Point(0, 0);
            panelInfo.Name = "panelInfo";
            panelInfo.Size = new Size(784, 88);
            panelInfo.TabIndex = 0;
            // 
            // info_groupBoxGeneral
            // 
            info_groupBoxGeneral.Controls.Add(info_textBoxGeneral);
            info_groupBoxGeneral.Dock = DockStyle.Top;
            info_groupBoxGeneral.Location = new Point(0, 0);
            info_groupBoxGeneral.Name = "info_groupBoxGeneral";
            info_groupBoxGeneral.Size = new Size(784, 79);
            info_groupBoxGeneral.TabIndex = 0;
            info_groupBoxGeneral.TabStop = false;
            info_groupBoxGeneral.Text = "Информация";
            // 
            // info_textBoxGeneral
            // 
            info_textBoxGeneral.BackColor = SystemColors.Control;
            info_textBoxGeneral.BorderStyle = BorderStyle.None;
            info_textBoxGeneral.Dock = DockStyle.Top;
            info_textBoxGeneral.Enabled = false;
            info_textBoxGeneral.Location = new Point(3, 19);
            info_textBoxGeneral.Multiline = true;
            info_textBoxGeneral.Name = "info_textBoxGeneral";
            info_textBoxGeneral.Size = new Size(778, 51);
            info_textBoxGeneral.TabIndex = 0;
            info_textBoxGeneral.Text = "По открытому файлу составленна программа которая предоставляет, инфографику по представленным данным:";
            // 
            // panelInteract
            // 
            panelInteract.BackColor = SystemColors.Control;
            panelInteract.Controls.Add(buttonOutput_Car);
            panelInteract.Controls.Add(buttonOutput_Driver);
            panelInteract.Controls.Add(buttonAbout);
            panelInteract.Controls.Add(buttonOutput_Point);
            panelInteract.Controls.Add(buttonInput);
            panelInteract.Dock = DockStyle.Top;
            panelInteract.Location = new Point(0, 88);
            panelInteract.Name = "panelInteract";
            panelInteract.Size = new Size(784, 72);
            panelInteract.TabIndex = 1;
            // 
            // buttonOutput_Car
            // 
            buttonOutput_Car.Anchor = AnchorStyles.Top;
            buttonOutput_Car.Enabled = false;
            buttonOutput_Car.Image = (Image)resources.GetObject("buttonOutput_Car.Image");
            buttonOutput_Car.Location = new Point(285, 6);
            buttonOutput_Car.Name = "buttonOutput_Car";
            buttonOutput_Car.Size = new Size(60, 60);
            buttonOutput_Car.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonOutput_Car, "Вывести таблицу машин");
            buttonOutput_Car.UseVisualStyleBackColor = true;
            buttonOutput_Car.Click += buttonOutput_Car_Click;
            // 
            // buttonOutput_Driver
            // 
            buttonOutput_Driver.Anchor = AnchorStyles.Top;
            buttonOutput_Driver.Enabled = false;
            buttonOutput_Driver.Image = (Image)resources.GetObject("buttonOutput_Driver.Image");
            buttonOutput_Driver.Location = new Point(351, 6);
            buttonOutput_Driver.Name = "buttonOutput_Driver";
            buttonOutput_Driver.Size = new Size(60, 60);
            buttonOutput_Driver.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonOutput_Driver, "Вывести таблицу водителей");
            buttonOutput_Driver.UseVisualStyleBackColor = true;
            buttonOutput_Driver.Click += buttonOutput_Driver_Click;
            // 
            // buttonAbout
            // 
            buttonAbout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonAbout.Image = (Image)resources.GetObject("buttonAbout.Image");
            buttonAbout.Location = new Point(710, 6);
            buttonAbout.Name = "buttonAbout";
            buttonAbout.Size = new Size(60, 60);
            buttonAbout.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonAbout, "Информация о создателе приложения");
            buttonAbout.UseVisualStyleBackColor = true;
            buttonAbout.Click += buttonAbout_Click;
            // 
            // buttonOutput_Point
            // 
            buttonOutput_Point.Anchor = AnchorStyles.Top;
            buttonOutput_Point.Enabled = false;
            buttonOutput_Point.Image = (Image)resources.GetObject("buttonOutput_Point.Image");
            buttonOutput_Point.Location = new Point(417, 6);
            buttonOutput_Point.Name = "buttonOutput_Point";
            buttonOutput_Point.Size = new Size(60, 60);
            buttonOutput_Point.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonOutput_Point, "Вывести таблицу выездов");
            buttonOutput_Point.UseVisualStyleBackColor = true;
            buttonOutput_Point.Click += buttonOutput_Point_Click;
            // 
            // buttonInput
            // 
            buttonInput.Image = (Image)resources.GetObject("buttonInput.Image");
            buttonInput.Location = new Point(12, 6);
            buttonInput.Name = "buttonInput";
            buttonInput.Size = new Size(60, 60);
            buttonInput.TabIndex = 0;
            toolTipGeneral.SetToolTip(buttonInput, "Отрыть файл с исходнымми данными");
            buttonInput.UseVisualStyleBackColor = true;
            buttonInput.Click += buttonInput_Click;
            // 
            // splitContainerMain
            // 
            splitContainerMain.Dock = DockStyle.Fill;
            splitContainerMain.Location = new Point(0, 160);
            splitContainerMain.Name = "splitContainerMain";
            // 
            // splitContainerMain.Panel1
            // 
            splitContainerMain.Panel1.BackColor = SystemColors.Control;
            splitContainerMain.Panel1.Controls.Add(groupBoxOutput_Current);
            // 
            // splitContainerMain.Panel2
            // 
            splitContainerMain.Panel2.BackColor = SystemColors.Control;
            splitContainerMain.Panel2.Controls.Add(groupBoxOutput_Previous);
            splitContainerMain.Size = new Size(784, 201);
            splitContainerMain.SplitterDistance = 385;
            splitContainerMain.TabIndex = 2;
            // 
            // groupBoxOutput_Current
            // 
            groupBoxOutput_Current.Controls.Add(dataGridViewOutput_Current);
            groupBoxOutput_Current.Dock = DockStyle.Fill;
            groupBoxOutput_Current.Location = new Point(0, 0);
            groupBoxOutput_Current.Name = "groupBoxOutput_Current";
            groupBoxOutput_Current.Size = new Size(385, 201);
            groupBoxOutput_Current.TabIndex = 0;
            groupBoxOutput_Current.TabStop = false;
            groupBoxOutput_Current.Text = "Текущая таблица";
            // 
            // dataGridViewOutput_Current
            // 
            dataGridViewOutput_Current.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_Current.Dock = DockStyle.Fill;
            dataGridViewOutput_Current.Location = new Point(3, 19);
            dataGridViewOutput_Current.Name = "dataGridViewOutput_Current";
            dataGridViewOutput_Current.Size = new Size(379, 179);
            dataGridViewOutput_Current.TabIndex = 0;
            // 
            // groupBoxOutput_Previous
            // 
            groupBoxOutput_Previous.Controls.Add(dataGridViewOutput_Previous);
            groupBoxOutput_Previous.Dock = DockStyle.Fill;
            groupBoxOutput_Previous.Location = new Point(0, 0);
            groupBoxOutput_Previous.Name = "groupBoxOutput_Previous";
            groupBoxOutput_Previous.Size = new Size(395, 201);
            groupBoxOutput_Previous.TabIndex = 0;
            groupBoxOutput_Previous.TabStop = false;
            groupBoxOutput_Previous.Text = "Предыдущая таблица";
            // 
            // dataGridViewOutput_Previous
            // 
            dataGridViewOutput_Previous.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput_Previous.Dock = DockStyle.Fill;
            dataGridViewOutput_Previous.Location = new Point(3, 19);
            dataGridViewOutput_Previous.Name = "dataGridViewOutput_Previous";
            dataGridViewOutput_Previous.Size = new Size(389, 179);
            dataGridViewOutput_Previous.TabIndex = 0;
            // 
            // openFileDialogMain
            // 
            openFileDialogMain.FileName = "openFileDialog1";
            // 
            // toolTipGeneral
            // 
            toolTipGeneral.BackColor = SystemColors.Control;
            toolTipGeneral.ToolTipIcon = ToolTipIcon.Info;
            toolTipGeneral.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 361);
            Controls.Add(splitContainerMain);
            Controls.Add(panelInteract);
            Controls.Add(panelInfo);
            MinimumSize = new Size(800, 400);
            Name = "FormMain";
            Text = "Автотранспортное предприятие";
            panelInfo.ResumeLayout(false);
            info_groupBoxGeneral.ResumeLayout(false);
            info_groupBoxGeneral.PerformLayout();
            panelInteract.ResumeLayout(false);
            splitContainerMain.Panel1.ResumeLayout(false);
            splitContainerMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainerMain).EndInit();
            splitContainerMain.ResumeLayout(false);
            groupBoxOutput_Current.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_Current).EndInit();
            groupBoxOutput_Previous.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput_Previous).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelInfo;
        private Panel panelInteract;
        private SplitContainer splitContainerMain;
        private GroupBox info_groupBoxGeneral;
        private TextBox info_textBoxGeneral;
        private Button buttonOutput_Car;
        private Button buttonOutput_Driver;
        private Button buttonAbout;
        private Button buttonOutput_Point;
        private Button buttonInput;
        private GroupBox groupBoxOutput_Current;
        private DataGridView dataGridViewOutput_Current;
        private GroupBox groupBoxOutput_Previous;
        private DataGridView dataGridViewOutput_Previous;
        private OpenFileDialog openFileDialogMain;
        private ToolTip toolTipGeneral;
    }
}

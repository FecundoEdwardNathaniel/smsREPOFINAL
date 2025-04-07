namespace SMS.App
{
    partial class ProgramView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxProgramName = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBoxDescription = new TextBox();
            label3 = new Label();
            textBoxId = new TextBox();
            buttonCreate = new Button();
            buttonRead = new Button();
            buttonDelete = new Button();
            buttonUpdate = new Button();
            dataGridViewProgramList = new DataGridView();
            label4 = new Label();
            txtBoxSearch = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).BeginInit();
            SuspendLayout();
            // 
            // textBoxProgramName
            // 
            textBoxProgramName.Location = new Point(38, 91);
            textBoxProgramName.Margin = new Padding(3, 2, 3, 2);
            textBoxProgramName.Name = "textBoxProgramName";
            textBoxProgramName.Size = new Size(240, 23);
            textBoxProgramName.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 74);
            label1.Name = "label1";
            label1.Size = new Size(88, 15);
            label1.TabIndex = 1;
            label1.Text = "Program Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 114);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 3;
            label2.Text = "Description";
            // 
            // textBoxDescription
            // 
            textBoxDescription.Location = new Point(38, 131);
            textBoxDescription.Margin = new Padding(3, 2, 3, 2);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(240, 23);
            textBoxDescription.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(38, 34);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 5;
            label3.Text = "I.D.";
            // 
            // textBoxId
            // 
            textBoxId.Location = new Point(38, 51);
            textBoxId.Margin = new Padding(3, 2, 3, 2);
            textBoxId.Name = "textBoxId";
            textBoxId.Size = new Size(240, 23);
            textBoxId.TabIndex = 4;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(38, 171);
            buttonCreate.Margin = new Padding(3, 2, 3, 2);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(240, 22);
            buttonCreate.TabIndex = 6;
            buttonCreate.Text = "Create";
            buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonRead
            // 
            buttonRead.Location = new Point(38, 197);
            buttonRead.Margin = new Padding(3, 2, 3, 2);
            buttonRead.Name = "buttonRead";
            buttonRead.Size = new Size(240, 22);
            buttonRead.TabIndex = 7;
            buttonRead.Text = "Read";
            buttonRead.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(38, 250);
            buttonDelete.Margin = new Padding(3, 2, 3, 2);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(240, 22);
            buttonDelete.TabIndex = 9;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(38, 223);
            buttonUpdate.Margin = new Padding(3, 2, 3, 2);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(240, 22);
            buttonUpdate.TabIndex = 8;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewProgramList
            // 
            dataGridViewProgramList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProgramList.Location = new Point(327, 119);
            dataGridViewProgramList.Margin = new Padding(3, 2, 3, 2);
            dataGridViewProgramList.Name = "dataGridViewProgramList";
            dataGridViewProgramList.RowHeadersWidth = 51;
            dataGridViewProgramList.Size = new Size(466, 153);
            dataGridViewProgramList.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(341, 17);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 12;
            label4.Text = "Filter: ";
            // 
            // txtBoxSearch
            // 
            txtBoxSearch.Location = new Point(341, 34);
            txtBoxSearch.Margin = new Padding(3, 2, 3, 2);
            txtBoxSearch.Name = "txtBoxSearch";
            txtBoxSearch.Size = new Size(396, 23);
            txtBoxSearch.TabIndex = 11;
            // 
            // ProgramView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(815, 296);
            Controls.Add(label4);
            Controls.Add(txtBoxSearch);
            Controls.Add(dataGridViewProgramList);
            Controls.Add(buttonDelete);
            Controls.Add(buttonUpdate);
            Controls.Add(buttonRead);
            Controls.Add(buttonCreate);
            Controls.Add(label3);
            Controls.Add(textBoxId);
            Controls.Add(label2);
            Controls.Add(textBoxDescription);
            Controls.Add(label1);
            Controls.Add(textBoxProgramName);
            Margin = new Padding(3, 2, 3, 2);
            Name = "ProgramView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Program Management";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProgramList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxProgramName;
        private Label label1;
        private Label label2;
        private TextBox textBoxDescription;
        private Label label3;
        private TextBox textBoxId;
        private Button buttonCreate;
        private Button buttonRead;
        private Button buttonDelete;
        private Button buttonUpdate;
        private DataGridView dataGridViewProgramList;
        private Label label4;
        private TextBox txtBoxSearch;
    }
}
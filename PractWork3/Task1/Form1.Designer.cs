namespace Task1
{
    partial class CreateForm
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
            multilineTextBox = new TextBox();
            tasksTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            createButton = new Button();
            SuspendLayout();
            // 
            // multilineTextBox
            // 
            multilineTextBox.Location = new Point(12, 39);
            multilineTextBox.Multiline = true;
            multilineTextBox.Name = "multilineTextBox";
            multilineTextBox.Size = new Size(423, 110);
            multilineTextBox.TabIndex = 0;
            // 
            // tasksTextBox
            // 
            tasksTextBox.Location = new Point(111, 197);
            tasksTextBox.Name = "tasksTextBox";
            tasksTextBox.Size = new Size(220, 23);
            tasksTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 2;
            label1.Text = "Текст:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(119, 179);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 3;
            label2.Text = "Количество заданий:";
            // 
            // createButton
            // 
            createButton.Location = new Point(111, 240);
            createButton.Name = "createButton";
            createButton.Size = new Size(220, 63);
            createButton.TabIndex = 4;
            createButton.Text = "Создать документ:";
            createButton.UseVisualStyleBackColor = true;
            createButton.Click += CreateButton_Click;
            // 
            // CreateForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(500, 383);
            Controls.Add(createButton);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tasksTextBox);
            Controls.Add(multilineTextBox);
            Name = "CreateForm";
            Text = "Создание документа Word";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox multilineTextBox;
        private TextBox tasksTextBox;
        private Label label1;
        private Label label2;
        private Button createButton;
    }
}

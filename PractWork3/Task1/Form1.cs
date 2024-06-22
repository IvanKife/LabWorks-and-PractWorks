using Word = Microsoft.Office.Interop.Word;

namespace Task1
{
    public partial class CreateForm : Form
    {
        public CreateForm()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, EventArgs e)
        {            
            var wordApp = new Word.Application();
            wordApp.Visible = true;

            object template = Path.Combine(Environment.CurrentDirectory, "״אבכמםû", "״אבכמם.docx");
            var document = wordApp.Documents.Add(template);

            document.Content.Find.Execute(FindText: "ׂוךסעָחֿמכÿֲגמהא", ReplaceWith: multilineTextBox.Text, Replace: Word.WdReplace.wdReplaceAll);
            document.Content.Find.Execute(FindText: "הה.לל.דדדד קק:לל", ReplaceWith: DateTime.Now.ToString(), Replace: Word.WdReplace.wdReplaceAll);

            Word.Table table = document.Tables[1];
            int rows = Convert.ToInt32(tasksTextBox.Text);
            for (int i = 1; i < rows; i++)
            {
                table.Rows.Add();
                table.Cell(i + 1, 1).Range.Text = i.ToString();
            }
            table.Cell(rows + 2, 1).Range.Text = rows.ToString(); 
        }
    }
}

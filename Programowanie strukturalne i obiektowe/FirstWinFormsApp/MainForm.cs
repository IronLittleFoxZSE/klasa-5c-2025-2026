namespace FirstWinFormsApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            string name = textBoxName.Text;

            string schoolSubject = "Ulubione przedmioty:\n";
            if (checkBoxSchoolSubjectMathematics.Checked)
            {
                schoolSubject += "matematyka\n";
            }
            if (checkBoxSchoolSubjectGerman.Checked)
            {
                schoolSubject += "jêzyk niemiecki\n";
            }

            string pizzaWithPineapple = "";
            if (radioButtonPizzaQuestionYes.Checked)
            {
                pizzaWithPineapple = "Lubiê pizze z ananasem.";
            }
            else
            {
                pizzaWithPineapple = "Pizza z ananasem to nieporozumienie";
            }

            MessageBox.Show(
                $"Witaj {name} w pierwszym programie.\n {schoolSubject}"
                + $"\n{pizzaWithPineapple}",
                "Komunikat",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Information,
                MessageBoxDefaultButton.Button2);
        }

    }
}
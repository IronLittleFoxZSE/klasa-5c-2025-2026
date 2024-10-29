namespace ConverterMauiApp
{
    public partial class MainPage : ContentPage
    {
        private string grade;

        public string Grade
        {
            get { return grade; }
            set 
            { 
                grade = value;
                OnPropertyChanged();
                switch(Grade)
                {
                    case "1":
                        TextGrade = "Niedostateczny";
                        break;
                    case "2":
                        TextGrade = "Dopuszczający";
                        break;
                    default:
                        TextGrade = "Nieprawidłowe dane";
                        break;
                }
                //TextGrade = Grade;
            }
        }

        private string textGrade;
        public string TextGrade
        {
            get { return textGrade; }
            set 
            { 
                textGrade = value;
                OnPropertyChanged();

            }
        }



        public MainPage()
        {
            InitializeComponent();
        }
    }

}

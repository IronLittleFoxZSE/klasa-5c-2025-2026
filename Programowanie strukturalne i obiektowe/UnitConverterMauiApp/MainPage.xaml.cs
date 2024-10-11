namespace UnitConverterMauiApp
{
    public partial class MainPage : ContentPage
    {
        public List<Unit> Units { get; set; }
        public Unit UnitFrom { get; set; }
        public Unit UnitTo { get; set; }

        public string StrValue { get; set; }

        private string returnMessage;
        public string ReturnMessage
        {
            get { return returnMessage; }
            set { returnMessage = value; OnPropertyChanged(); }
        }


        public MainPage()
        {
            Units = new List<Unit>()
            {
                new(){ Name="mm", ConverterBaseValue = 1},
                new(){ Name="cm", ConverterBaseValue = 10},
                new(){ Name="dm", ConverterBaseValue = 100},
                new(){ Name="m", ConverterBaseValue = 1000},
                new(){ Name="km", ConverterBaseValue = 100000},
                new(){ Name="Mm", ConverterBaseValue = 100000000},
            };
            UnitFrom = Units.First();
            UnitTo = Units.First();

            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            double calculateValue = double.Parse(StrValue)
                * UnitFrom.ConverterBaseValue
                / UnitTo.ConverterBaseValue;

            ReturnMessage = $"{StrValue} {UnitFrom.Name} = {calculateValue} {UnitTo.Name}";
        }
    }

}

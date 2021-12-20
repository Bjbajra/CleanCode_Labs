namespace Lab1B_Mocking
{
    public class StringModifier
    {
        private readonly IStringDataProvider _dataProvider;
        private readonly IStringManipulator _stringManipulator;

        public StringModifier(IStringDataProvider dataProvider, IStringManipulator stringManipulator)
        {
            _dataProvider = dataProvider;
            _stringManipulator = stringManipulator;
        }

        public string Run()
        {
            string data = _dataProvider.Read();   
            string manipulatedString = _stringManipulator.Manipulate(data);
            return manipulatedString;
        }
    }
}

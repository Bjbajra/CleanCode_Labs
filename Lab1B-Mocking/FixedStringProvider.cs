namespace Lab1B_Mocking
{
    public class FixedStringProvider : IStringDataProvider
    {
        public string Read()
        {
            return "Nepal is small and beautiful country.";
        }
    }
}

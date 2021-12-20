namespace Lab1B_Mocking
{
    public class ReverseManipulator : IStringManipulator
    {
        public string Manipulate(string text)
        {
            return new StringHelpers().Reverse(text);
        }
    }
}

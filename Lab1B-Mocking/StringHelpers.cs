namespace Lab1B_Mocking
{
    public class StringHelpers
    {
        public string Reverse(string stringToReverse)
        {
            if (stringToReverse is null)
                throw new ArgumentNullException();

            char[] chars = stringToReverse.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}

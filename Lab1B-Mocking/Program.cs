using Lab1B_Mocking;

//IStringDataProvider stringDataProvider = new DataReader();
IStringDataProvider stringDataProvider = new FixedStringProvider();

IStringManipulator stringManipulator = new ReverseManipulator();
//IStringManipulator stringManipulator = new ToUpperCaseManipulator();



StringModifier stringReverser = new StringModifier(stringDataProvider, stringManipulator);

string reversedString = stringReverser.Run();

Console.WriteLine(reversedString);

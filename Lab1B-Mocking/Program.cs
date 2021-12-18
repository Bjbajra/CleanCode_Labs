using Lab1B_Mocking;

//IStringDataProvider stringDataProvider = new DataReader();
IStringDataProvider stringDataProvider = new FixedStringProvider();



StringModifier stringReverser = new StringModifier(stringDataProvider);

string reversedString = stringReverser.Run();

Console.WriteLine(reversedString);

using csharp_lista_indirizzi;

List<Address> address = new List<Address>();

try
{
	StreamReader addressesFile = File.OpenText("C:\\Users\\jorda\\Desktop\\Generation\\Esercizi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\data\\addresses.csv");
	int lineCounter = 0;

	while (!addressesFile.EndOfStream)
	{
		string textLinesRead = addressesFile.ReadLine();
		lineCounter++;

		if (lineCounter > 1)
		{
			string[] separatedLine = textLinesRead.Split(',');

			if (separatedLine.Length > 6)
			{
				Console.WriteLine("La riga " + lineCounter + " non rispetta il formato degli indirizzi");
			}
			else
			{
				int zipAddressRead = int.Parse(separatedLine[5]);
				Address AddressRead = new Address(separatedLine[0], separatedLine[1], separatedLine[2], separatedLine[3], separatedLine[4], zipAddressRead);
				address.Add(AddressRead);
				Console.WriteLine(AddressRead.ToString());
			}
		}
	}
} catch (Exception e)
{
	Console.WriteLine(e.Message);
}


using csharp_lista_indirizzi;

List<Address> address = new List<Address>();

StreamReader addressesFile = File.OpenText("C:\\Users\\jorda\\Desktop\\Generation\\Esercizi\\csharp-lista-indirizzi\\csharp-lista-indirizzi\\data\\addresses.csv");
int lineCounter = 0;

while (!addressesFile.EndOfStream)
{
	string textLinesRead = addressesFile.ReadLine();
	lineCounter++;
	
	if(lineCounter > 1)
	{
		string[] separatedLine = textLinesRead.Split(',');
		int zipAddressRead = int.Parse(separatedLine[6]);

		Address AddressRead = new Address(separatedLine[0], separatedLine[1], separatedLine[2], separatedLine[3], separatedLine[4], separatedLine[5], zipAddressRead);
		address.Add(AddressRead);
	}
}



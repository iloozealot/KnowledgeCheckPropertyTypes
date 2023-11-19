

using ConsoleUI;

AddressModel address = new AddressModel();

address.StreetNumber = 12007;
address.StreetName = "W Cora St";
address.City = "Wichita";
address.State = "KS";
address.PostalCode = 67205;

Console.WriteLine(address.FullAddress);

Console.ReadLine();
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_lista_indirizzi
{
	public class Address
	{
		//ATTRIBUTES + PROPERTIES
		private string name;
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				this.name = value;
			}
		}

		private string surname;
		public string Surname
		{
			get
			{
				return this.surname;
			}
			set
			{
				this.surname = value;
			}
		}

		private string street;
		public string Street
		{
			get
			{
				return this.street;
			}
		}

		private string city;
		public string City
		{
			get
			{
				return this.city;
			}
		}

		private string province;
		public string Province
		{
			get
			{
				return this.province;
			}
		}

		private string zip;
		public string Zip
		{
			get
			{
				return this.zip;
			}
		}

		//CONSTRUCTOR
		public Address(string name, string surname, string street, string city, string province, string zip)
		{
			if ((name == "") || (surname == "") || (street == ""))
			{
				string exceptionMessage = "Mancano i parametri ";
				if (name == "")
				{
					exceptionMessage += "nome ";
				}

				if (surname == "")
				{
					exceptionMessage += "cognome ";
				}

				if (street == "")
				{
					exceptionMessage += "indirizzo ";
				}

				throw new ArgumentException(exceptionMessage);
			}

			this.name = name;
			this.surname = surname;
			this.street = street;
			this.city = city;
			this.province = province;
			this.zip = zip;

		}

		//METHODS
		public override string ToString()
		{
			string stringToWrite;
			stringToWrite = "------------------------------------------- \n";
			stringToWrite += $"Name: {this.name} \n";
			stringToWrite += $"Surname: {this.surname} \n";
			stringToWrite += $"Street: {this.street } \n";
			stringToWrite += $"City: {this.city} \n";
			stringToWrite += $"Province: {this.province} \n";
			stringToWrite += $"Zip: {this.zip} \n";
			stringToWrite += "-------------------------------------------";

			return stringToWrite;
		}





	}

	
	
}

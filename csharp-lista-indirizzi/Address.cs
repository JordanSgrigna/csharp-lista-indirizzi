using System;
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
				return this.address;
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

		private string country;
		public string Country
		{
			get
			{
				return this.country;
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

		private int zip;
		public int Zip
		{
			get
			{
				return this.zip;
			}
		}

		//CONSTRUCTOR
		public Address(string name, string surname, string street, string city, string country, string province, int zip)
		{
			this.name = name;
			this.surname = surname;
			this.street = street;
			this.city = city;
			this.country = country;
			this.province = province;
			this.zip = zip;

		}





	}

	
	
}

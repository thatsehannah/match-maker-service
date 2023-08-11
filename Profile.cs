using System;
namespace MatchMakerService
{
	public class Profile
	{
        private string name;
		private int age;
		private string city;
		private string country;
		private string pronouns;
		private string[] hobbies;

        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
		{
			this.name = name;
			this.age = age;
			this.city = city;
			this.country = country;
			this.pronouns = pronouns;
			this.hobbies = new string[3];
		}

		public string ViewProfile()
		{
			return $"Name: {name}\nAge: {age}\nLocation: {city}, {country}\nPronouns: {pronouns}";
		}
	}
}


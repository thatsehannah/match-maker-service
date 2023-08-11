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
			this.hobbies = new string[4];
		}

		public string ViewProfile()
		{
			string info = $"Name: {name}\nAge: {age}\nLocation: {city}, {country}\nPronouns: {pronouns}\nHobbies: ";
			foreach (string hobby in hobbies)
			{
				if (hobby == hobbies[hobbies.Length - 1])
				{
					info += hobby;
				} else
				{
                    info += hobby + ", ";
                }
				
			}
			return info;
		}

		public void SetHobbies(string[] hobbies)
		{
			this.hobbies = hobbies;
		}
	}
}


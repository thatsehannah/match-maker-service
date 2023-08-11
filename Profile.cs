using System;
namespace MatchMakerService
{
	public class Profile
	{
		//Fields
		private int age;
		private bool isOfAge;

		//Properties
		public string? Name { get; set; }
		public int Age
		{
			get { return age; }
			set { if (value < 18)
				{
					isOfAge = false;
				}
				else {
					isOfAge = true;
					age = value;
				} }
		}
		public string? City { get; set; }
		public string? Country { get; set; }
		public string? Pronouns { get; set; }
		public string[]? Hobbies { get; set; }

		//Constructors
        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
		{
            Name = name;
            Age = age;
			City = city;
			Country = country;
			Pronouns = pronouns;
			Hobbies = new string[0];
		}

		//Methods
		public string ViewProfile()
		{
			if (this.isOfAge)
			{
                string info = $"Name: {Name}\nAge: {age}\nLocation: {City}, {Country}\nPronouns: {Pronouns}";
                if (Hobbies is not null && Hobbies.Length > 0)
                {
                    info += "\nHobbies: ";
                    foreach (string hobby in Hobbies)
                    {
                        if (hobby == Hobbies[Hobbies.Length - 1])
                        {
                            info += hobby;
                        }
                        else
                        {
                            info += hobby + ", ";
                        }
                    }
                }

                return info;
            }

			return "Not of age";
		}

		public void SetHobbies(string[] hobbies)
		{
			if (isOfAge )
			{
                Hobbies = hobbies;
            } else
			{
				Console.WriteLine("Cannot set hobbies. Too young for match making service");
			}

        }
	}
}


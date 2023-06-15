namespace H_m_lib
{
    public class Person
    {
        public bool jinsi{ get; set; }
        public bool Married { get; set; } = false;
        public string Name { get; set; }
        public Person? spouse { get; set; }

        public static void Marry(Person person1,Person person2)
        {
            if (person1.Married != true && person2.Married != true && person1.jinsi != person2.jinsi)
            {
                person1.Married = true;
                person1.spouse = person2;
                person2.Married = true;
                person2.spouse = person1;
                Console.WriteLine($"{person1.Name} va {person2.Name} lar turmush qurushti");
            }      
            else
                Console.WriteLine("Turmush qurush mumkun emas malumot uchun administraciaga uchrang!!!");
                            
        }

        public void Marry(Person person)
        {
            if (person.Married != true && this.Married != true)
            {
                this.spouse = person;
                this.Married = true;
                person.Married = true;
                person.spouse = this;
                Console.WriteLine($"{this.Name} va {person.Name} lar turmush qurushti");
            }
            else
                Console.WriteLine("Turmush qurush mumkun emas arizachilarni biri (Yoki ikovixam) turmush qurgan!!");

        }

        public static void divorse(Person person1,Person person2)
        {
            if (person1.Married && person2.Married && person2.spouse == person1)
            {
                person1.Married = false;
                person2.Married = false;
                person1.spouse = null;
                person2.spouse = null;
                Console.WriteLine($"{person1.Name} va {person2.Name} lar ajirashishti!");
            }
            else
                Console.WriteLine("Ajirashish uchun avval turmush qurush kerak)");
        }
    }
}
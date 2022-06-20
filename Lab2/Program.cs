using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2 {

    public class Animal {
        public string Kind {
            get;
        }
        public string Country {
            get;
        }

        public Animal(string kind, string country) {
            Kind = kind;
            Country = country;
        }
        public override bool Equals(object obj) {
            if (obj is Animal animal) return Kind == animal.Kind && animal.Country == Country;
            else return false;
        }
        public override string ToString() {
            return $"Тварина {Kind} {Country}";
        }
        public override int GetHashCode() {
            return (Kind, Country).GetHashCode();
        }
    }

    public class Dog : Animal {
        public string Breed {
            get;
        }
        public Dog(string kind, string country, string breed) : base(kind, country) {
            Breed = breed;
        }
        public override bool Equals(object obj) {
            if (obj is Dog dog)
                return Breed == dog.Breed;
            return false;
        }
        public override string ToString() {
            return $"Собака {Breed}";
        }
        public override int GetHashCode() {
            return Breed.GetHashCode();
        }
    }

    public class Sobaka : Dog {
        public int Age {
            get;
        }
        public string Name {
            get;
        }
        public Sobaka(string name, int age, string kind, string country, string breed) : base(kind, country, breed) {
            Name = name;
            Age = age;
        }

        public void Say() {
            Console.WriteLine("Собака говорить");
        }
        public void jumps() {
            Console.WriteLine("Собака стрибає");
        }    
        public void Run() {
            Console.WriteLine("Собака бiгає");
        }
        public void Bites() {
            Console.WriteLine("Собака кусає");
        }


        public override bool Equals(object obj) {
            if (obj is Sobaka sobaka)

                return Name == sobaka.Name && sobaka.Age == Age;
            return false;
        }
        public override string ToString() {
            return $"Dog{Name}\n{Age}\n{Kind}\n{Country}\n{Breed}\n";
        }
        public override int GetHashCode() {
            return (Name, Age).GetHashCode();
        }
    }



    class Program {
        static void Main(string[] args) {
            var sobaka = new Sobaka(" name: Anton", 9 ,"Kind: Police","Country: Ukraine","Breed: German Shepherd");
            Console.WriteLine(sobaka);

            sobaka.Say();
            sobaka.jumps();
            sobaka.Run();
            sobaka.Bites();
        }
    }
}

using System;
using static Programm;

class Programm
{
    static void Main(string[] args)
    {
        Console.WriteLine("Напишите имена для животных: рыбы, птицы, дельфина, пингвина (именно в таком порядке) ");
        IMove[] moves = new IMove[]
        {
            new Fish(Console.ReadLine()),
            new Bird(Console.ReadLine()),
            new Dolphin(Console.ReadLine()),
            new Penguin(Console.ReadLine())
        };

        foreach (var move in moves)
        {
            move.Move();
            move.Food();
            move.Birth();
            if (move is Animal animal)
            {
                Console.WriteLine($"Тип: {animal.GetType().Name}");
            }
            else if (move is Fish fish)
            {
                Console.WriteLine($"Тип: {fish.GetType().Name}");
            }
            Console.WriteLine();
        }
    }
}
public interface IMove
{
    public void Move();
    public void Birth();
    public void Food();
}
public abstract class Animal : IMove
{
    public string Name { get; set; }
    public Animal(string name)
    {
        Name = name;
    }
    public virtual void Move()
        {
            Console.WriteLine($"{Name} двигается");
        }
    public virtual void Birth()
    {
        Console.WriteLine($"{Name} создает потомство");
    }
    public virtual void Food()
    {
        Console.WriteLine($"{Name} ест пищу");
    }
        ~Animal()
        {
            Console.WriteLine($"{Name} не двигается");
        }
    }
    public abstract class Mammal : Animal
    {
        public Mammal(string name) : base(name) { }
        public override void Food()
    {
        base.Food();
        Console.WriteLine($"{Name} пьет молоко");
    }
    }
    public class Bird : Animal
    {
        public Bird(string name) : base(name) { }
        public override void Move()
        {
        
            Console.WriteLine($"{Name} летает");
        }
        public override void Birth()
        {
            
            Console.WriteLine($"{Name} откладывает яйца");
        }
    public override void Food()
    {
        Console.WriteLine($"{Name} кушает насекомых ");
    }
}
    class Fish : IMove
    {
        public string Name { get; set; }
        public Fish(string name)
        {
            Name = name;
        }
        public virtual void Move()
        {
            Console.WriteLine($"{Name} плавает");
        }
    public virtual void Birth()
    {
        Console.WriteLine($"{Name} откладывает икру");
    }

    public void Food()
    {
        Console.WriteLine($"{Name} не пьет молоко");
    }
}
    public class Penguin : Bird
    {
        public Penguin(string name) : base(name) { }
        public override void Birth()
        {
            Console.WriteLine($"{Name} откладывает яйца");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} ходит");
        }
    public override void Food()
    {
   
        Console.WriteLine($"{Name} ест рыбу") ;
    }
}
    class Dolphin : Mammal
    {
        public Dolphin(string name) : base(name) { }
        public override void Food()
        {
            Console.WriteLine($"{Name} кормит молоком");
        }
        public override void Move()
        {
            Console.WriteLine($"{Name} плавает");
        }
    }


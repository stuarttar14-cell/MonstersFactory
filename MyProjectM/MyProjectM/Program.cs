using MyProjectM;
using System;
using System.Security.Cryptography.X509Certificates;

public class Program
{
    public static void F()
    {
        Console.WriteLine("Mati");
    }
    public static void Main()
    {
        F();
        Console.WriteLine("How many monsters do you want");
        int monstersAmount=int.Parse(Console.ReadLine());
        MyMonster[] monsters = new MyMonster[monstersAmount];
        for (int i = 0; i < monstersAmount; i++)
        {
            Console.WriteLine("Enter name");
            string name=Console.ReadLine();
            Console.WriteLine("Enter power");
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter health");
            int health = int.Parse(Console.ReadLine());
            monsters[i] = new MyMonster(name, power, health);
        }
        for (int i = 0; i < monstersAmount; i++)
        {
            monsters[i].ShowMonster();
        }
        int monstersAlive=0;
        for (int i = 0; i < monstersAmount; i++)
        {
            if(monsters[i].IsAlive())
            {  
                monstersAlive++; 
            }
        }
        Console.WriteLine(monstersAlive);
        int maxPower = 0;
        for (int i = 1; i < monstersAmount; i++)
        {
            if (monsters[i].GetPower() > monsters[i-1].GetPower())
            {
                maxPower = i;
            }
        }
        Console.WriteLine(monsters[maxPower].GetName() + " is the strongest with the power of "+ monsters[maxPower].GetPower());
        for (int i = 0;i < monstersAmount; i++)
        {
            Console.WriteLine("Enter damage");
            int damage= int.Parse(Console.ReadLine());
            monsters[i].TakeDamage(damage);
        }
        for (int i = 0; i < monstersAmount; i++)
        {
            monsters[i].ShowMonster();
        }
        for (int i = 0; i < monstersAmount; i++)
        {
            if (monsters[i].GetHealth()<60)
            {
                Console.WriteLine(monsters[i].GetName()); 
            }
        }
        //thats what we changed
        Console.WriteLine("stuart the king");
        Console.WriteLine("Mati da GOAT");
        Console.WriteLine("...");
    }
}

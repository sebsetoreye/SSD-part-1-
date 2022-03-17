
//making the player strings
int p1_hight, p2_hight, p3_hight, p4_hight, p5_hight;

string p1_name, p2_name, p3_name, p4_name, p5_name;

int p1_age, p2_age, p3_age, p4_age, p5_age;

int p1 = 1, p2 = 2, p3 = 3, p4 = 4, p5 = 5;
//loops
int rngloop = 5;

//choices
string pick;

//person 1
Console.WriteLine("Please input your first person into the DataBase");
Console.WriteLine();
Console.Write("first persons name : ");
p1_name = Console.ReadLine();
Thread.Sleep(100);
Console.WriteLine();
Console.Write("first persons age : ");
p1_age = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.Write("first persons hight : ");
p1_hight = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.WriteLine("Thank you for adding them to the DataBase");
Thread.Sleep(2000);

// person 2
Console.Clear();
Console.WriteLine("Please input your second person into the DataBase");
Console.WriteLine();
Console.Write("second persons name : ");
p2_name = Console.ReadLine();
Thread.Sleep(100);
Console.WriteLine();
Console.Write("second persons age : ");
p2_age = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.Write("second persons hight : ");
p2_hight = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.WriteLine("Thank you for adding them to the DataBase");
Thread.Sleep(2000);

// person 3
Console.Clear();
Console.WriteLine("Please input your third person into the DataBase");
Console.WriteLine();
Console.Write("third persons name : ");
p3_name = Console.ReadLine();
Thread.Sleep(100);
Console.WriteLine();
Console.Write("third persons age : ");
p3_age = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.Write("third persons hight : ");
p3_hight = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.WriteLine("Thank you for adding them to the DataBase");
Thread.Sleep(2000);

// person 4
Console.Clear();
Console.WriteLine("Please input your fourth person into the DataBase");
Console.WriteLine();
Console.Write("fourth persons name : ");
p4_name = Console.ReadLine();
Thread.Sleep(100);
Console.WriteLine();
Console.Write("fourth persons age : ");
p4_age = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.Write("fourth persons hight : ");
p4_hight = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.WriteLine("Thank you for adding them to the DataBase");
Thread.Sleep(2000);

// person 5
Console.Clear();
Console.WriteLine("Please input your fifth person into the DataBase");
Console.WriteLine();
Console.Write("fifth persons name : ");
p5_name = Console.ReadLine();
Thread.Sleep(100);
Console.WriteLine();
Console.Write("fifth persons age : ");
p5_age = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.Write("fifth persons hight : ");
p5_hight = Convert.ToInt32(Console.ReadLine());
Thread.Sleep(100);
Console.WriteLine();
Console.WriteLine("Thank you for adding them to the DataBase");
Thread.Sleep(2000);

// looping to do RNG for people and making an exit command
rngloop:
while (rngloop > 0)
{
    Random player = new Random();
    int person = player.Next(1, 6);

    Convert.ToInt32(person);

    Console.Clear();
    Console.WriteLine("Every Person has been added to the Database");
    Console.Write("what do you want to do ( rng ) = picking random person from database, typing anything else = leaving the program: ");
    pick = Console.ReadLine();
    if (pick == "rng")
    {
            Console.WriteLine("picking person");
            Console.WriteLine();
            if (person == p1)
            {
                if (p1_hight < 160)
                {
                Console.WriteLine(p1_name);
                Console.WriteLine("is " + p1_age + " years old");
                Console.WriteLine("They are short");
                Thread.Sleep(5000);
                goto rngloop;
                }
                else if (p1_hight >= 160)
                {
                Console.WriteLine(p1_name);
                Console.WriteLine("is " + p1_age + " years old");
                Console.WriteLine("They are avrage hight");
                Thread.Sleep(5000);
                goto rngloop;
                }
                else if (p1_hight >= 179)
                {
                Console.WriteLine(p1_name);
                Console.WriteLine("is " + p1_age + " years old");
                Console.WriteLine("They are very tall hight");
                Thread.Sleep(5000);
                goto rngloop;
            }   }
            else if (person == p2)
            {
                if (p2_hight < 160)
                {
                    Console.WriteLine(p2_name);
                    Console.WriteLine("is " + p2_age + " years old");
                    Console.WriteLine("They are short");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
                else if (p2_hight >= 160)
                {
                    Console.WriteLine(p2_name);
                    Console.WriteLine("is " + p2_age + " years old");
                    Console.WriteLine("They are avrage hight");
                    Thread.Sleep(3000);
                    goto rngloop;
                }
                else if (p2_hight >= 179)
                {
                    Console.WriteLine(p2_name);
                    Console.WriteLine("is " + p2_age + " years old");
                    Console.WriteLine("They are very tall hight");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
            }
            else if (person == p3)
            {
                if (p3_hight < 160)
                {
                    Console.WriteLine(p3_name);
                    Console.WriteLine("is " + p3_age + " years old");
                    Console.WriteLine("They are short");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
                else if (p3_hight >= 160)
                {
                    Console.WriteLine(p3_name);
                    Console.WriteLine("is " + p3_age + " years old");
                    Console.WriteLine("They are avrage hight");
                    Thread.Sleep(3000);
                    goto rngloop;
                }
                else if (p3_hight >= 179)
                {
                    Console.WriteLine(p3_name);
                    Console.WriteLine("is " + p3_age + " years old");
                    Console.WriteLine("They are very tall hight");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
            }
            else if (person == p4)
            {
                if (p4_hight < 160)
                {
                    Console.WriteLine(p4_name);
                    Console.WriteLine("is " + p4_age + " years old");
                    Console.WriteLine("They are short");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
                else if (p4_hight >= 160)
                {
                    Console.WriteLine(p4_name);
                    Console.WriteLine("is " + p4_age + " years old");
                    Console.WriteLine("They are avrage hight");
                    Thread.Sleep(3000);
                    goto rngloop;
                }
                else if (p4_hight >= 179)
                {
                    Console.WriteLine(p4_name);
                    Console.WriteLine("is " + p4_age + " years old");
                    Console.WriteLine("They are very tall hight");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
            }
            else if (person == p5)
            {
                if (p5_hight < 160)
                {
                    Console.WriteLine(p5_name);
                    Console.WriteLine("is " + p5_age + " years old");
                    Console.WriteLine("They are short");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
                else if (p5_hight >= 160)
                {
                    Console.WriteLine(p5_name);
                    Console.WriteLine("is " + p5_age + " years old");
                    Console.WriteLine("They are avrage hight");
                    Thread.Sleep(3000);
                    goto rngloop;
                }
                else if (p5_hight >= 179)
                {
                    Console.WriteLine(p5_name);
                    Console.WriteLine("is " + p5_age + " years old");
                    Console.WriteLine("They are very tall hight");
                    Thread.Sleep(5000);
                    goto rngloop;
                }
            }
    }
    else if (pick == "exit")
    {
        System.Environment.Exit(0);
    }
}
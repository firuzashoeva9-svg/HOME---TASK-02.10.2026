///////                                     TASK 1

// DateTime dateTime = new DateTime(2010, 06, 05, 7, 40, 28, 11);
// System.Console.WriteLine($"year = {dateTime.Year}");
// System.Console.WriteLine($"month = {dateTime.Month}");
// System.Console.WriteLine($"day = {dateTime.Day}");
// System.Console.WriteLine($"hour = {dateTime.Hour}");
// System.Console.WriteLine($"minute = {dateTime.Minute}");
// System.Console.WriteLine($"second = {dateTime.Second}");
// System.Console.WriteLine($"millisecond = {dateTime.Millisecond}");


///////                                     TASK 2

// int cnt = 0;
// for (; ; )
// {
//     string a = Console.ReadLine();
//     if(a == "end")
//     {
//         break;
//     }
//     cnt++;
// }
// System.Console.WriteLine(cnt);


///////                                     TASK 3

// Gauge g = new Gauge();

// g.Increase();
// g.Increase();
// System.Console.WriteLine($"Value: {g.value}");

// for (int i = 0; i < 10; i++) g.Increase();
// System.Console.WriteLine($"Value: {g.value}, Full: {g.Full()}");

// g.Decrease();
// System.Console.WriteLine($"Value: {g.value}");


///////                                     TASK 4

// Counter c1 = new Counter(10);
// c1.Increase();
// c1.Increase(5);
// c1.Increase(-3);
// Console.WriteLine($"c1 value: {c1.Value}");


///////                                     TASK 5

PaymentTerminal unicafeTerminal = new PaymentTerminal();

double change = unicafeTerminal.EatAffordable(10.0);
Console.WriteLine($"Change: {change}"); 

PaymentCard annesCard = new PaymentCard(7.0);

bool wasSuccessful = unicafeTerminal.EatHearty(annesCard);
Console.WriteLine($"Card payment successful: {wasSuccessful}"); 
Console.WriteLine($"Anne's card balance: {annesCard.Balance}");   

unicafeTerminal.AddMoneyToCard(annesCard, 100.0);
Console.WriteLine($"Anne's new balance: {annesCard.Balance}"); 
Console.WriteLine($"Terminal cash: {unicafeTerminal.Money}");
using CAR;

Console.Write("Mashinaning modeli: ");
string model = Console.ReadLine();

Console.Write("Mashinaning ishlab chiqarilgan yili: ");
int year = int.Parse(Console.ReadLine());

Console.Write("Mashinaning narhi: ");
decimal price = decimal.Parse(Console.ReadLine());

Console.Write("Mashinaning tezligi: ");
decimal speed = decimal.Parse(Console.ReadLine());


Car mycar1 = new Car(model: "audi", year: 2024, price: 135000m, speed: 380m);
Console.WriteLine($"mashina nomi: {mycar1.getmodel}, mashina yili: {mycar1.getyear}, mashina narhi: {mycar1.getprice}, mashina tezligi: {mycar1.getspeed}");
mycar1.GetModel = "bmw";
mycar1.GetSpeed = 280;
Console.WriteLine($"mashina nomi: {mycar1.GetModel}, mashina yili: {mycar1.getyear}, mashina narhi: {mycar1.getprice}, mashina tezligi: {mycar1.GetSpeed}");
mycar1.getCarInfo(model, year, price, speed);
mycar1.CalculateDepreciation(years: year, prices: price);
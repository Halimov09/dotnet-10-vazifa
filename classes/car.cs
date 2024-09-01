namespace CAR
{
    public class Car
    {
        public string getmodel {get; set;}
        public int getyear {get; set;}
        public decimal getprice {get; set;}
        public decimal getspeed {get; set;}

        public Car (string model, int year, decimal price, decimal speed)
        {
            getmodel = model;
            getyear = year;
            getprice = price;
            getspeed = speed;
        }

        public string GetModel 
        {
            get {return getmodel;}
            set {getmodel = value;} 
        }

        public decimal GetSpeed 
        {
            get {return getspeed;}
            set {getspeed = value;} 
        }
        public void getCarInfo (string model, int year, decimal price, decimal speed)
        {
           Console.WriteLine($"mashina modeli: {model}, mashina ishlab chiqarilgan yil: {year}, mashinaning narhi {price}, mashina tealigi: {speed}");
        }

        public void CalculateDepreciation(int years, decimal prices)
        {
            int differentYear = 2024 - years;
            Console.WriteLine(differentYear);
            if (differentYear == 0)
            {
                Console.WriteLine($"mashinangiz narhi: {prices}");
            }else if(differentYear > 9){
                Console.WriteLine($"mashinangiz narhini hisoblay olmadik");
            }
            else{
                int differ = differentYear * 10;
                decimal priceDiffer = prices / 100 * (100 - differ);
                Console.WriteLine($"mashinangiz narhi: {priceDiffer}");
            }
        }
    }
}
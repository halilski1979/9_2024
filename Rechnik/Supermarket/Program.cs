namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string,List<double>>stoki= new Dictionary<string,List<double>>();
            var danni=Console.ReadLine().Split(' ').ToList();
            while (danni[0]!="stocked")
            {
                if (stoki.ContainsKey(danni[0]))
                {
                    var name = danni[0];
                    var price = double.Parse(danni[1]);
                    var quantity = double.Parse(danni[2]);
                    stoki[name][1] += quantity;
                    if (price != stoki[name][0])
                    {
                        stoki[name][0] = price;
                    }
                }
                else
                {
                    var name = danni[0];
                    var price = double.Parse(danni[1]);
                    var quantity = double.Parse(danni[2]);
                    var list=new List<double>();
                    list.Add(price);
                    list.Add(quantity);
                    stoki.Add(name, list);
                }
                danni = Console.ReadLine().Split(' ').ToList();
            }//end While
            double priceTotal = 0;
            foreach (var stoka in stoki)
            {
                Console.WriteLine($"{stoka.Key}: ${stoka.Value[0]:f2} * {stoka.Value[1]} = ${stoka.Value[0] * stoka.Value[1]:F2}");
                //priceTotal += stoka.Value[0] * stoka.Value[1];

            }
            Console.WriteLine(new string('-',30));
            var totalPrice = stoki.Sum(x => x.Value[0] * x.Value[1]);
            Console.WriteLine($"Grand Total: ${totalPrice:f2}");

        }
    }
}
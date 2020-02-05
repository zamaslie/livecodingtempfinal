using System;

namespace live_coding_temp_final
{
   public class Weather
    {
        public string Climate { get; set;}
        public string Temperature { get; set; }
    }

    public class MainClass
    {
        public static void Main()
        {
            Weather w1 = new Weather();
            Weather w2 = new Weather();
            Weather w3 = new Weather();
            Weather w4 = new Weather();

            w1.Climate = "Clear";
            w2.Climate = "Cloudy";
            w3.Climate = "Raining";
            w4.Climate = "Full Moon";

            Weather t1 = new Weather();
            Weather t2 = new Weather();
            Weather t3 = new Weather();
            Weather t4 = new Weather();

            t1.Temperature = "40s";
            t2.Temperature = "50s";
            t3.Temperature = "60s";
            t4.Temperature = "70s";

            Console.WriteLine("I just want to be a project manager :-(.");
        }
        
    }
}

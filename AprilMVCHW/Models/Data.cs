using System;

namespace AprilMVCHW.Models
{
    public class Data
    {
        public int id; //for行數
        public string type, dates;//類別、日期
        public int amount; //金額
        




        public static Random rmd = new Random();
        string[] typename = {"收入","支出"};
        

        public Data()
        {
            id=1;
            type = typename[rmd.Next(typename.Length)];
            dates = randomDay().ToString("yyyy-MM-dd");
            amount = rmd.Next(1000, 10000);
        }

        DateTime randomDay()
        {
            DateTime date = new DateTime(1995,1,1);
            int range = (DateTime.Today - date).Days;
            return date.AddDays(rmd.Next(range));
        }







    }
}
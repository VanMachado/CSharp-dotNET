namespace TopicosEspeciais {
    internal class OperacoesDateTime {        
        public static void Operacoes() {
            DateTime d = new DateTime(2001, 8, 15, 13, 45, 58, 275);
            Console.WriteLine(d);
            Console.WriteLine("1) Date: " + d.Date);
            Console.WriteLine("2) Day: " + d.Day);
            Console.WriteLine("3) DayOfWeek: " + d.DayOfWeek);
            Console.WriteLine("4) DayOfYear: " + d.DayOfYear);
            Console.WriteLine("5) Hour: " + d.Hour);
            Console.WriteLine("6) Kind: " + d.Kind);
            Console.WriteLine("7) Millisecond: " + d.Millisecond);
            Console.WriteLine("8) Minute: " + d.Minute);
            Console.WriteLine("9) Month: " + d.Month);
            Console.WriteLine("10) Second: " + d.Second);
            Console.WriteLine("11) Ticks: " + d.Ticks);
            Console.WriteLine("12) TimeOfDay: " + d.TimeOfDay);
            Console.WriteLine("13) Year: " + d.Year);

            DateTime d2 = new DateTime(2001, 8, 15, 13, 45, 58);
            string s1 = d2.ToLongDateString();
            string s2 = d2.ToLongTimeString();
            string s3 = d2.ToShortDateString();
            string s4 = d2.ToShortTimeString();
            string s5 = d2.ToString();
            string s6 = d2.ToString("yyyy-MM-dd HH:mm:ss");
            string s7 = d2.ToString("yyyy-MM-dd HH:mm:ss.fff");
            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            Console.WriteLine(s6);
            Console.WriteLine(s7);

            DateTime x = new DateTime(2001, 8, 15, 13, 45, 58);
            DateTime y8 = x.AddTicks(900000000L);
            DateTime y5 = x.AddMilliseconds(500);
            DateTime y7 = x.AddSeconds(30);
            DateTime y2 = x.AddMinutes(30);
            DateTime y1 = x.AddHours(2);
            DateTime y4 = x.AddDays(7);
            DateTime y6 = x.AddMonths(3);
            DateTime y9 = x.AddYears(2);
            TimeSpan t = x.Subtract(y4);
            DateTime y10 = x.Subtract(t);
            DateTime y3 = x.Add(t);
        }
    }
}

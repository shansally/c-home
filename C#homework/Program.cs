using System.Text.RegularExpressions;

namespace C_homework
{
    internal class Program
    {
        public static void hw6_1()
        {
            //輸入姓名，輸出 Hi~輸入的姓名，比如說輸入Justin，輸出Hi~Justin

            Console.WriteLine("請輸入姓名:");
            string name = Console.ReadLine();
            Console.WriteLine($"Hi~{name}");
            Console.ReadKey();
        }

        public static void hw6_2()
        {
            //請輸入任何一個字，是否出現在”人人為我，我為人人、饒人不癡漢，癡漢不饒人”這個字串裡

            string sentence = "人人為我，我為人人、饒人不癡漢，癡漢不饒人";
            Console.WriteLine("請輸入一字,檢查是否在\"人人為我，我為人人、饒人不癡漢，癡漢不饒人\"的句子中:");
            string word = Console.ReadLine();
            bool yesorno = sentence.Contains(word);
            Console.WriteLine(yesorno);
        }

        public static void hw6_3()
        {
            //輸入一段字，輸出每個之間多一個 -，如輸入apple ，輸出a - p - p - l - e

            Console.WriteLine("請輸入一段字:");
            string word = Console.ReadLine();

            string result = string.Join('-', word.ToCharArray());
            Console.WriteLine(result);
        }

        public static void hw6_4()
        {
            //輸入一個檔名輸出副檔名，如輸入apple.jpg，輸出jpg

            Console.WriteLine("請輸入檔名:");
            string word = Console.ReadLine();

            int file = word.IndexOf('.');          //使用 IndexOf 找到字串中第一個.
            string output = word.Substring(file + 1);     //使用 Substring擷取從這個位置+1開始到結尾的部分(+ 1是因為想要從.的下一個位置開始擷取，以避免包含.本身)
            Console.WriteLine(output);
        }

        public static void hw6_5()
        {
            //輸入一個大於五個字的單字，若小於五個字輸出長度不夠，若大於五個字，則輸出前三個字

            Console.WriteLine("請輸入一個單字:");
            string word = Console.ReadLine();

            if (word.Length < 5)
            {
                Console.WriteLine("長度不夠");
            }
            else
            {
                Console.WriteLine("前三個字為:" + word.Substring(0, 3));
            }

        }

        public static void hw6_6()
        {
            //輸入一段字，輸出把輸入的一段字裡面的我，改成小明，如輸入我在唱歌，輸出小明在唱歌

            Console.WriteLine("請輸入一段文字:");
            string word = Console.ReadLine();

            string newword = word.Replace("我", "小明");
            Console.WriteLine(newword);
        }

        public static void hw6_7()
        {
            //輸入一串字，顯示輸入幾個字

            Console.WriteLine("請輸入一串字:");
            string word = Console.ReadLine();
            Console.WriteLine("長度為" + word.Length);

        }

        public static void add6_1()
        {
            //連續輸入10組字，若沒輸入過，就顯示沒出現過，若輸入過，就顯示輸入過

            string[] array1 = new string[10];
            Console.WriteLine("請輸入10組字:");

            for (int i = 0; i < array1.Length; i++)
            {
                Console.WriteLine($"請輸入第{i + 1}組字:");
                string input = Console.ReadLine();

                bool yesorno;

                yesorno = array1.Contains(input);

                array1[i] = input;

                if (yesorno)
                { Console.WriteLine($"{input}輸入過"); }
                else
                { Console.WriteLine($"{input}未輸入過"); }
            }
            Console.ReadLine();
        }


        public static void add6_2()
        {
            //用字母大小寫來模擬波浪舞的動作後輸出，比如輸入FiFa，輸出 Fifa fIfa fiFa fifA

            Console.WriteLine("請輸入一串英文字母:");
            string input = Console.ReadLine().ToLower();

            for (int i = 0; i < input.Length; i++)
            {
                // 將當前字符轉换為大寫，並输出整個字符串
                Console.WriteLine(input.Substring(0, i) + char.ToUpper(input[i]) + input.Substring(i + 1));
            }
            Console.ReadLine();
        }


        public static void add6_3()
        {
            //輸入時間，顯示幾時幾分，例如輸入11: 30，輸出11點30分

            Console.WriteLine("請輸入時間(例:11:30):");
            string time = Console.ReadLine();
            string output = time.Replace(':', '點');
            Console.WriteLine(output + "分");
        }

        public static void add6_4()
        {
            //輸入的字，轉成HTML，例如輸入Justin,Amy,David 輸出
            //<ul>
            //< li > Justin<li>
            //< li > Amy<li>
            //< li > David<li>
            //</ ul >

            Console.WriteLine("請輸入字串(如:Justin,Amy,David):");
            string input = Console.ReadLine();
            string[] output = input.Split(',');

            Console.WriteLine("<ul>");
            for (int i = 0; i < output.Length; i++)
            { Console.WriteLine("<li>" + output[i] + "</li>"); }
            Console.WriteLine("</ul>");

        }

        public static void add6_5()
        {
            //輸入5處數字，用空白隔開，輸出結果。例如：輸入‘11 19 12 25 1 7 12，輸出總和是87

            double[] array = new double[5];
            Console.WriteLine("請輸入5個數字,並用空白間隔:");
            string input = Console.ReadLine();
            string[] number = input.Split(' ');

            double sum = 0;
            for (int i = 0; i < number.Length; i++)
            {
                sum += Convert.ToDouble(number[i]);

            }
            Console.WriteLine(sum);
        }



        public static void add6_6()
        {
            //輸入一串文字，倒著輸出，例如輸入：Justin，輸出nitsuJ

            Console.WriteLine("請輸入一串文字:");
            string input = Console.ReadLine();          //用戶輸入的值存為字串
            char[] output = input.ToCharArray();        //將用戶輸入的字串 轉為 陣列
            Array.Reverse(output);                      //將陣列反向
            Console.WriteLine(output);
        }

        public static void fun7_1()
        {
            //寫一個function 可以把一般對話框的文字轉成HTML。
            //> 轉成 & gt;
            //< 轉成 & lt;
            //\r\n 轉成<br>
            //| 轉成 & brvbar;
            //空白 轉成 &nbsp;

            Console.WriteLine("請輸入一段文字:");
            string input = Console.ReadLine();
            string output = input.Replace(">", "&gt").Replace("<", "glt").Replace(@"\r\n", "<br>").Replace("|", "brvbar").Replace(" ", "&nbsp");
            Console.WriteLine(output);
        }

        public static void fun7_2()
        {
            //寫一個function，回傳輸入的值是否數字

            Console.WriteLine("請輸入一個值,判斷是否為數字:");
            string input = Console.ReadLine();

            string pattern = @"^\d+$";         //@"^\d$"只能顯示單個數字
            Regex regex = new Regex(pattern);
            Console.WriteLine(regex.IsMatch(input));
        }

        public static void fun7_3()
        {
            // 寫一個function，回傳輸入的值是否符合Ｅ－ｍａｉｌ格式

            Console.WriteLine("請輸入E-mail,並判斷是否為E-mail格式:");
            string input = Console.ReadLine();

            string pattern = @"^\w+@\w+[.]\w+$";            //yahoo.com.tw不適合 
            Regex regex = new Regex(pattern);
            Console.Write(regex.IsMatch(input));
        }

        public static void fun7_4()
        {
            //寫一個function，回傳輸入的值是否符合手機格式

            Console.WriteLine("請輸入手機,並判斷是否為手機格式:");
            string input = Console.ReadLine();

            string pattern = @"^09+[-]\d{8}$";
            Regex regex = new Regex(pattern);
            Console.Write(regex.IsMatch(input));
        }


        public static void fun7_5()
        {
            //寫一個function，回傳輸入的值是否符合身分證字號格式

            Console.WriteLine("請輸入身分證字號, 並判斷是否為身分證格式:(首字母不論大小寫)");
            string id = Console.ReadLine();

            string pattern = @"^[a-zA-Z][12]\d{8}$";
            Regex regexid = new Regex(pattern);
            Console.WriteLine(regexid.IsMatch(id));
        }

        public static void fun7_6()
        {
            //寫一個function，若輸入的文字大於Ｎ個，則超過的字不要，變成點點點

            Console.WriteLine("若輸入的文字大於Ｎ個，則超過的字不要，變成點點點");
            Console.WriteLine("請輸入一段文字:");
            string input = Console.ReadLine();
            Console.WriteLine("請輸入N值:");
            int number = Convert.ToInt32(Console.ReadLine());

            if (input.Length > number)
            {
                //input = input.Remove(number);  或
                input = input.Substring(0, number);
                Console.WriteLine(input + "...");
            }
            else { Console.WriteLine(input); }
        }

        public static void fun7_7()
        {
            //寫一個function，輸入一個日期，把該日期轉成民國年.月.日格式

            Console.WriteLine("請輸入一個日期(例:2024/04/20):");
            string date = Console.ReadLine();

            string pattern = @"^\d{4}/\d{1,2}/\d{1,2}$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(date))
            {
                Console.WriteLine("輸入不符合格式");
                return;
            }

            string[] datesplit = date.Split('/');
            int[] dateint = datesplit.Select(int.Parse).ToArray();
            //==int[] dateint = { int.Parse(datesplit[0]), int.Parse(datesplit[1]), int.Parse(datesplit[2]) };
            Console.WriteLine($"民國{dateint[0] - 1911}年{dateint[1]}月{dateint[2]}日");
        }


        public static void fun7_8()
        {
            //寫一個function，輸入一個日期，把把該日期轉成民國XX年XX月XX日 星期X 格式

            Console.WriteLine("請輸入一個日期(例:2024/04/20):");
            string date = Console.ReadLine();

            string pattern = @"^\d{4}/\d{1,2}/\d{1,2}$";
            Regex regex = new Regex(pattern);
            if (!regex.IsMatch(date))
            {
                Console.WriteLine("輸入不符合格式");
                return;
            }
            string[] datesplit = date.Split("/");
            int[] dateint = datesplit.Select(int.Parse).ToArray();
            //==int[] dateint {int.Parse(datesplit[0]),int.Parse(datesplit[1]),int.Parse(datesplit[2])}
            DateTime dateTime = new DateTime(dateint[0], dateint[1], dateint[2]);
            string[] week = { "日", "一", "二", "三", "四", "五", "六" };
            string dateweek = week[(int)dateTime.DayOfWeek];
            Console.WriteLine($"民國{dateint[0] - 1911}年{dateint[1]}月{dateint[2]}日星期{dateweek}");

        }


        public static void fun7_9()
        {
            //寫一個function，回傳輸入的年是否閏年

            Console.WriteLine("請輸入西元年:");
            int year = Convert.ToInt32(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine($"{year}是閏年");
            }
            else
            { Console.WriteLine($"{year}是平年"); }
        }

        public static void fun7_10()
        {
            //寫一個function，輸入手機號碼，回傳今天運勢
            //(手機運勢算法：手機號碼的最後四位數除以80，再減去整數部分（只留小數），再乘以80，就會得到一個數，這就是代表吉凶的數字，印出結果。)

            Console.WriteLine("請輸入手機後四碼:");
            double number = Convert.ToInt32(Console.ReadLine());
            double dividedby = number / 80;
            double result = dividedby - Math.Truncate(dividedby);
            Console.WriteLine($"吉凶數字:{result * 80}");
        }

        static void Main(string[] args)
        {
            hw6_1();
            hw6_2();
            hw6_3();
            hw6_4();
            hw6_5();
            hw6_6();
            hw6_7();
            add6_1();
            add6_2();
            add6_3();
            add6_4();
            add6_5();
            add6_6();

            fun7_1();
            fun7_2();
            fun7_3();
            fun7_4();
            fun7_5();
            fun7_6();
            fun7_7();
            fun7_8();
            fun7_9();
            fun7_10();
        }

    }
}

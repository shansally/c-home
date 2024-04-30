using System.Data;
using System.Diagnostics;
using System.Runtime.Serialization.Formatters;
using System.Text;


namespace C_homework
{
    internal class Program
    {
        public static void file1_1()
        {
            //寫一篇中文歌的歌詞到到自己指定的文字檔(使用UTF-8編碼)。
            //並讀取1.txt 顯示在畫面上。
            string lyrics = "天青色等煙雨 而我在等你\r\n炊煙嫋嫋升起 隔江千萬裏\r\n在瓶底書漢隸仿前朝的飄逸\r\n就當我為遇見你伏筆";
            string path = @"C:\Users\user\Desktop\text.lyrics.txt";
            File.WriteAllText(path, lyrics, Encoding.UTF8);
            Console.WriteLine(lyrics);
        }

        public static void add_file_01()
        {
            //寫入九九乘法表資料到一個文字檔到自己指定的文字檔。
            string path = @"C:\Users\user\Desktop\file-practice\text.99.txt";
            string[] multiplie = new string[81];
            int index = 0;
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    multiplie[index] = ($"{i}*{j}={i * j}");
                    index++;
                }
            }
            File.WriteAllLines(path, multiplie);
            Console.WriteLine("成功寫入");
        }

        public static void add_file_02()
        {
            //讀取1.txt 顯示在畫面上，並將1.txt 裡的阿拉伯數字，轉換成中文數字(壹、貳、叁、肆…..)，並儲存到指定的路徑。(UTF-8)
            //string path = @"C:\Users\user\Desktop\file-practice\1.txt";
            //string num = File.ReadAllText(path);
            //Console.WriteLine(num);
            //string num_out = num;      //新宣告一string,將 num 的內容複製到 num_out 中，這樣後續的修改不會影響到原始檔案。

            //string[] array1 = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            //string[] array2 = { "零", "壹", "貳", "參", "肆", "伍", "陸", "柒", "捌", "玖" };
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    num_out = num_out.Replace(array1[i], array2[i]);
            //}
            //Console.WriteLine(Environment.NewLine + num_out);

            ////使用 for 迴圈來遍歷 array1 陣列，並使用 Replace 方法將 num_out 中的阿拉伯數字替換為對應的中文數字。

            //File.AppendAllText(path, num_out, Encoding.UTF8);



            ///其他寫法
            //string path = @"C:\Users\user\Desktop\file-practice\1.txt";
            //string num = File.ReadAllText(path);
            //num = num.Replace("0", "零");
            //num = num.Replace("1", "壹");
            //num = num.Replace("2", "貳");
            //num = num.Replace("3", "參");
            //num = num.Replace("4", "肆");
            //num = num.Replace("5", "伍");
            //num = num.Replace("6", "陸");
            //num = num.Replace("7", "柒");
            //num = num.Replace("8", "捌");
            //num = num.Replace("9", "玖");
            //Console.WriteLine(num);
        }

        public static void add_file_03()
        {
            //讀取fc4bb.csv，並將此資料轉成HTML TABLE 格式，並儲存到指定的HTML檔裡。
            string csvFlepath = @"C:\Users\user\Desktop\file-practice\fc4bb.csv";
            string htmlFilePath = @"C:\Users\user\Desktop\file-practice\output.html";
            string[] lines = File.ReadAllLines(csvFlepath, Encoding.UTF8);

            string html = "<html><head><title>CSV to HYML</title></head><//html><table border='1'>";
            foreach (string line in lines)
            {
                html += "<tr>";
                string[] cells = line.Split(',');
                foreach (string cell in cells)
                {
                    html += "<td>" + cell + "</td>";
                }
                html += "</tr>";
            }
            html += "</table></body><//html>";
            File.WriteAllText(htmlFilePath, html);
            Console.WriteLine("成功寫入");



            ////其他寫法
            //string csvFlepath = @"C:\Users\user\Desktop\file-practice\fc4bb.csv";
            //string htmlFilePath = @"C:\Users\user\Desktop\file-practice\output.html";
            //string[] lines = File.ReadAllLines(csvFlepath);

            //// 建立 StringBuilder 儲存 HTML 表格內容
            //StringBuilder htmlContent = new StringBuilder();

            //// 建立 HTML 內容
            //htmlContent.AppendLine("<!DOCTYPE html>");
            //htmlContent.AppendLine("<html>");
            //htmlContent.AppendLine("<head>");
            //htmlContent.AppendLine("<title> csv 轉換成 html table</title>");
            //htmlContent.AppendLine("<style>td{border:1px solid #000;}</style>");
            //htmlContent.AppendLine("</head>");
            //htmlContent.AppendLine("<body>");
            //htmlContent.AppendLine("<table>");

            //foreach (string line in lines)
            //{

            //    htmlContent.AppendLine("<tr>");
            //    string[] cells = line.Split(',');         ///以逗號分隔資料
            //    foreach (string cell in cells)
            //    {
            //        htmlContent.AppendLine($"<td>{cell}</td>");
            //    }
            //    htmlContent.AppendLine("</tr>");
            //}
            //htmlContent.AppendLine("</table>");
            //htmlContent.AppendLine("</body>");
            //htmlContent.AppendLine("</html>");
            //File.WriteAllText(htmlFilePath, htmlContent.ToString());
            //Console.WriteLine($"HTML 表格已儲存至 {htmlFilePath}");
        }



        public static void random1_1()
        {
            //請隨機由0~99產生一個數字輸出。

            Random num = new Random();         //亂數種子
            int i = num.Next(0, 100);           //回傳0-99的亂數
            Console.WriteLine(i);
        }
        public static void random1_2()
        {
            //請隨機由0~99產生10個數字輸出。

            Random num = new Random();

            for (int i = 0; i < 10; i++)
            {
                int a = num.Next(0, 99);
                Console.WriteLine($"第{i + 1}個亂數為{a}");
            }
        }

        public static void random1_3()
        {
            //隨機幫每位學員產生成績，並寫入文字檔(欄位之間用，分開，換行寫入下一筆)。

            string path = @"C:\Users\user\Desktop\file-practice\student.txt";                 //指定路徑
            string[] student = { "小一", "小二", "小三", "小四", "小五", "小六", "小七", "小八" };     //學生名字陣列
            Random num = new Random();                                                        //亂數
            int[] score = new int[student.Length];                                            //將亂數存入score陣列
            for (int i = 0; i < score.Length; i++)
            {
                score[i] = num.Next(0, 101);
            }                                   //使用 for 迴圈將每位學生的成績添加到 scores 中
                                                // 建立要寫入文字檔的內容
            string field = "姓名,成績\n";
            for (int i = 0; i < student.Length; i++)
            {
                field += $"{student[i]} : {score[i]}\n";
            }                                  //使用 for 迴圈將每位學生的名字及成績添加到 field 中

            File.AppendAllText(path, field);
            Console.WriteLine(field);
        }

        public static void add_random_01()
        {
            //請設計樂透開獎程式。
            int count = 6;
            int maxnum = 49;
            int[] number = new int[count + 1];
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                int randomNumber;
                randomNumber = random.Next(1, 50);
                while (Array.IndexOf(number, randomNumber) != -1)
                {
                    randomNumber = random.Next(1, 50);
                }
                number[i] = randomNumber;
            }
            int special = random.Next(1, 50);
            while (Array.IndexOf(number, special) != -1)
            {
                special = random.Next(1, 50);
            }
            number[count] = special;

            Console.WriteLine("樂透中獎6碼為:");
            for (int i = 0; i < count; i++)
            { Console.WriteLine($"{number[i]}"); }
            Console.WriteLine($"特別號為:{number[count]}");
        }

        public static void add_random_02()
        {
            //請在文字檔裡輸入所有午餐的店家，讀取文字檔，隨機抽出今天中午要吃哪一家。
            string path = @"C:\Users\user\Desktop\file-practice\lunch.txt";
            string[] lunch = File.ReadAllLines(path);
            Random choose = new Random();
            int store = choose.Next(0, lunch.Length);
            Console.WriteLine($"午餐吃{lunch[store]}");
        }


        public static void add_random_03()
        {
            //請在文字檔裡輸入所有教室裡的學員名字，讀取文字檔，
            //隨機抽出今天的值日生，抽過不能再被抽中，直到全部學員都被抽過，才可以再被抽。
            string path = @"C:\Users\user\Desktop\file-practice\duty.txt";
            string[] output = File.ReadAllLines(path);
            Random random = new Random();

            while (output.Length > 0)
            {
                int index = random.Next(0, output.Length);
                string student = output[index];
                Console.WriteLine($"今日值日生:{student}");

                List<string> list = new List<string>(output);
                list.RemoveAt(index);
                output = list.ToArray();

                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
            }
            Console.WriteLine("本次值日生已輪值完畢");



            ////其他解法
            //string path = @"C:\Users\user\Desktop\file-practice\duty.txt";
            //string[] output = File.ReadAllLines(path);

            //string[] student = new string[output.Length];            ////建立一個與 output 陣列同樣大小的新陣列 students，用來存放抽選出的值日生名單。
            //bool[] selected = new bool[output.Length];               //// 用來標記每個學生是否已經被抽選

            //Random random = new Random();
            //int i = 0;                                              ////初始化一個計數器 i，用來追蹤已經抽選的值日生數量。

            //while (true)
            //{
            //    int index = random.Next(0, output.Length);          //// 隨機生成一個值日生的索引


            //    if (selected[index])                               //// 檢查這個值日生是否已經被抽選過了，如果是，則繼續抽選下一位
            //    { continue; }
            //    // 將這個值日生加入到學生名單中
            //    student[i++] = output[index];                     //// 將這個值日生加入到學生名單中

            //    
            //    selected[index] = true;                           //// 標記這個值日生已經被抽選過了

            //    // 如果所有學生都已經被抽選過了，則跳出迴圈
            //    if (i == output.Length)
            //    {
            //        break;
            //    }
            //}
            //foreach (var item in student)
            //{
            //    Console.WriteLine(item);
            //}
            //for (int j = 0; j < student.Length; j++)
            //{
            //    if (student[j] != null)
            //    {
            //        Console.WriteLine(student[j]);
            //    }
        }



        public static void date1_1()
        {
            //顯示現在日期與時間。
            DateTime dt = DateTime.Now;
            Console.WriteLine($"現在時間為{dt}");
        }
        public static void date1_2()
        {
            //顯示再過30天為哪一天。
            DateTime today = DateTime.Now;
            DateTime addday = today.AddDays(30);
            Console.WriteLine($"30天後為:{addday}");

        }

        public static void date1_3()
        {
            //顯示24小時前的年月日時分秒。
            DateTime today = DateTime.Now;
            DateTime pasthour = today.AddHours(-24);
            Console.WriteLine($"24小時前為:{pasthour}");
        }

        public static void date1_4()
        {
            //取得目前是幾月。
            DateTime now = DateTime.Now;
            int month = now.Month;
            Console.WriteLine($"現在是{month}月");
        }

        public static void date1_5()
        {
            //取得明年是否為閏年。(可以試試民國)  DateTime.IsLeapYear

            DateTime now = DateTime.Now;                           //當前時間
            int nextyear = now.Year + 1;                           //明年年分
            int leapyear = nextyear - 1911;                        //將西元轉民國
            bool isleapyear = DateTime.IsLeapYear(nextyear);       //明年是否為閏年
            if (isleapyear)
            { Console.WriteLine($"民國{leapyear}年是閏年"); }
            else { Console.WriteLine($"民國{leapyear}年不是閏年"); }


        }

        public static void date1_6()
        {
            //取得離2025年1月1日還有幾天。
            DateTime now = DateTime.Now;
            DateTime happyday = new DateTime(2025, 01, 01);
            int lon = (int)(happyday - now).TotalDays;
            Console.WriteLine($"距離2025年1月1日還有{lon}天");
        }

        public static void add_date_01()
        {
            //星期一，猴子穿新衣;星期二，猴子肚子餓;星期三，猴子去爬山;星期四，猴子看電視;呈期五，猴子去跳舞;星期六，猴子去斗六;星期日，猴子過生日。
            //顯示今天猴子做甚麼事。

            DateTime today = DateTime.Today;             // 取得今天的日期
            DayOfWeek week = today.DayOfWeek;            // 判斷今天是星期幾
            switch (week)                                // 根據星期幾顯示猴子在做甚麼事情
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("今天星期一,猴子穿新衣");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("今天星期二,猴子肚子餓");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("今天星期三,猴子去爬山");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("今天星期四,猴子看電視");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("今天呈期五,猴子去跳舞");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("今天星期六,猴子去斗六");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("今天星期日,猴子過生日");
                    break;
            }
        }

        public static void add_date_02()
        {
            //輸入‘兩個日期，輸出兩個日期相差幾天。

            ///提示用戶輸入兩個日期
            Console.WriteLine("請輸入第一個日期(例:2024/04/25):");
            DateTime date1 = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("請輸入第二個日期(例:2024/06/25):");
            DateTime date2 = DateTime.Parse(Console.ReadLine());

            /// 計算兩個日期之間的差距（以天為單位）
            TimeSpan days = date2 - date1;
            int dayss = Math.Abs(days.Days);          ///由於這個值可能為負數，所以我們使用 Math.Abs 方法取得其絕對值。
            Console.WriteLine($"相差{dayss}天");

        }

        public static void add_date_03()
        {
            //兩光法師時常替人占卜，由於他算得又快有便宜，因此生意源源不絕，時常大排長龍，他想算 得更快一點，因此找了你這位電腦高手幫他用電腦來加快算命的速度。
            //他的占卜規則很簡單，規則是這樣的，隨機產生一個今年日期，然後依照下面的公式：
            //M =月
            //D = 日
            //S = (M * 2 + D) % 3
            //得到S 的值，再依照 S 的值從 0 到 2 分別給與 普通、吉、大吉 等三種不同的運勢，輸出運勢。

            Random date = new Random();
            int M = date.Next(1, 13);
            int D = date.Next(1, 32);
            int S = (M * 2 + D) % 3;

            switch (S)
            {
                case 0:
                    Console.WriteLine("運勢:普通");
                    break;
                case 1:
                    Console.WriteLine("運勢:吉");
                    break;
                case 2:
                    Console.WriteLine("運勢:大吉");
                    break;
            }
        }



        static void Main(string[] args)
        {
            file1_1();
            add_file_01();
            add_file_02();
            add_file_03();

            random1_1();
            random1_2();
            random1_3();
            add_random_01();
            add_random_02();
            add_random_03();

            date1_1();
            date1_2();
            date1_3();
            date1_4();
            date1_5();
            date1_6();
            add_date_01();
            add_date_02();
            add_date_03();
        }
    }
}
}

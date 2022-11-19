using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetBackEndFullStack
{
    internal class Program
    {
        int abc = 10;
        public int CongHaiSo(int a, int b)
        {
            if (a == 1 && b == 2)
            {
                //Nếu đúng thì vào Lệnh 1
            }
            else
            {
                //Nếu sai thì sẽ vào lệnh 2

            }

            switch (a)
            {
                case 1:
                    switch (b)
                    {
                        case -1: break;
                        default: break;
                    }
                    break;
                case 2: break;
                    //default:break;
            }

            return a / abc;

            var c = a == 1 ? 2 : 0;


        }

        public static void ThamChieuThamTri(int x)
        {
            int a = 0;
            int b = 100;
            try
            {
                Console.WriteLine(b / a);
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }

        }

        public static void ThamChieuThamChieu(ref int x)
        {
            x = x * x;
            Console.WriteLine(x);
        }

        public static void OutExample(out int x)
        {
            x = 1001;
        }

        public static void UserInput(string s)
        {
            if (s.Length > 10)
            {
                Exception e = new DataTooLongExeption();
                throw e;    // lỗi văng ra
            }
            //Other code - no exeption
        }

        struct StructName
        {
            public string Name { get; set; }
            public int Age { get; set; }
        }
        public struct Product
        {

            public string name;   // trường tên sản phẩm
            public decimal price; // trường giá sản phẩm

            // Phương thức sinh ra chuỗi thông tin
            public string PriceToString()
            {
                return price.ToString() + "vnd";
            }


        }
        enum HocLuc { Kem = 1, TrungBinh = 2, Kha = 3, Gioi = 4 };

        static void Main(string[] args)
        {
            int myVariable = 10;
            //ThamChieuThamChieu(ref myVariable);
            //Console.WriteLine(myVariable);


            //Console.WriteLine("Su dung tu khoa OUT");
            //int a;             // biến a chưa khởi tạo
            //OutExample(out a);
            //Console.WriteLine(a);

            //ThamChieuThamTri(10);

            //try
            //{
            //    UserInput("Đây là một chuỗi rất dài ...");
            //}
            //catch (DataTooLongExeption e)
            //{
            //    Console.WriteLine(e.Message);
            //}
            //catch (Exception otherExeption)
            //{
            //    Console.WriteLine(otherExeption.Message);
            //}

            //Product product = new Product();
            //product.name = "Khóa học aspnet Thầy Quân";
            //product.price = 10;
            //Console.WriteLine(product.ToString());
            //int[] bienMang = new int[5];
            //bienMang[0] = 10;
            //bienMang[1] = 100;
            //bienMang[2] = 1000;
            //bienMang[3] = 10000;
            //bienMang[4] = 100000;
            //string[] studentNames = new string[10];
            //for (int i = 0; i < bienMang.Length; i++)
            //{
            //    Console.WriteLine(bienMang[i]);
            //}
            //Console.WriteLine(bienMang.Min());
            //Console.WriteLine(bienMang.Max());

            //int[,] myvar = new int[3, 4];

            //var date = DateTime.Now;
            //Console.WriteLine(date.ToString("dd/MM/yyyy HH:mm:ss"));
            //var date_add = DateTime.Now.AddDays(2);
            //Console.WriteLine(date_add.ToString("dd/MM/yyyy HH:mm:ss"));


            //TimeSpan aInterval = new System.TimeSpan(0, 1, 1, 0);
            //// Thêm một khoảng thời gian.

            //DateTime newTime = date.Add(aInterval);
            //Console.WriteLine("After add 1 hour, 1 minute: " + newTime);

            //var createDateString = "23/11/2022 15:00:00";
            //var dateParseExact = DateTime.ParseExact(createDateString, "dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            //Console.WriteLine(dateParseExact.ToString("dd/MM/yyyy HH:mm:ss"));



            //var string_value = "Khóa học aspnet Thầy Quân";
            //Console.WriteLine("ToUpper: " + string_value.ToUpper());


            //GenericClass<int> intGenericClass = new GenericClass<int>(86);
            //intGenericClass.genericProperty = 2017;
            //int intVal = intGenericClass.genericMethod(2019);

            //GenericClass<string> strGenericClass = new GenericClass<string>("Welcome to");
            //strGenericClass.genericProperty = "WEB THAY QUÂN";
            //string strVal = strGenericClass.genericMethod("lop_aspnet thay Quan");

            //ArrayList arrList = new ArrayList() { 1, "5", 2.5, true };
            //arrList.Add("Web Thay Quan");
            //foreach (var item in arrList)
            //{
            //    Console.WriteLine("ITEM: " + item);
            //}

            //var bird = new Bird();
            //Console.WriteLine("bird: " + bird.Eat());

            //var cow = new Cow();
            //Console.WriteLine("cow: " + cow.Eat());
            //cow.Name = "Bò tót";

            var ps = new Person();
            ///ps.Name = "";
            //var animal = new Animal();
            //var dev = new Deverloper();
            //dev.Working();
            //Console.WriteLine(dev.checkAttendance(1));


            //var tester = new Tester();
            //tester.Working();
            //Console.WriteLine(tester.checkAttendance(0));

            //var cleaner = new Cleaner();
            //cleaner.Working();

            var list = DB.DataAccess.SqlDbHelper.GetStudents();
            if (list != null && list.Count > 0)
            {
                foreach (var item in list)
                {
                    Console.WriteLine(item.id + "\t");
                    Console.WriteLine(item.StudentName + "\t");
                    Console.WriteLine(item.StudentCode);
                }

            }

            Console.ReadLine();
        }
    }
}

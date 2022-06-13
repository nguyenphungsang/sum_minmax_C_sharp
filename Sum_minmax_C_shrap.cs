using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSN
{
    class Program
    {
        static void Main(string[] args)
        {
            //khởi tạo số lượng phần tử cần nhập từ bàn phím
            int n = 0;
            //TỔng các số đã nhập
            int tong = 0;
            //Tong các số nhỏ hơn 100 và lớn hơn 0
            int tongnew = 0;
            // đếm số lượng phần tử các số nhỏ hơn 100 và lớn hơn 0
            int mangnew = 0;
            // Mảng lưu các số nhập từ bàn phím
            int[] a;
            //mảng  mới lọc các số nhập từ bàn phím có giá trị nhỏ hơn 100 và lớn hơn 0
            int[] newArr;

            //Nhập số từ console
            Console.Write("Nhap so can tinh tong: ");
            n = int.Parse(Console.ReadLine());
            //khỏi tạo số lượng phần tử trong mảng
            a = new int[n];
          
            // nhập từ bàn phím số lượng phần tử đã khởi tạo
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap phan tu thu {0}: ", i + 1);
                a[i] = int.Parse(Console.ReadLine());
            }
            
            // Tổng các số nhập từ bàn phím
            for (int i = 0; i < n; i++)
            {
                tong += a[i];
            }

            // sắp xếp giá trị mảng nhập từ màn hình từ bé đến lớn
            for (int i = 0; i < n - 1; i++)
                for (int j = i; j < n; j++)
                    if (a[i] <= a[j])
                    {
                        int tg = a[i];
                        a[i] = a[j];
                        a[j] = tg;
                    }
            //Khởi tạo số lượng phần tử mảng mới lưu phần tử có giá trị nho hơn 100 và lơn hơn 0
            newArr = new int[n];

            //thêm giá trị cho mảng thỏa mãn điều kiện giá trị nho hơn 100 và lơn hơn 0
            for (int i = 0; i < n - 1; i++)
            {
                int sopt = a[i];
                if (sopt < 100 && sopt > 0)
                {
                    newArr[i] = sopt;
                    mangnew++;
                }
            }
             // Tính tổng mảng mới
            for (int i = 0; i < mangnew; i++)
            {
                tongnew += newArr[i];
            }
            //Xuất ra màn hình sau khi chưa có cồn
            Console.WriteLine("Tong cua {0} so nhap tu ban phim la: {1}", n, tong);
            Console.WriteLine("Tong cua {0} so nhap tu ban phim la nam trong doan 0 den 100: {1}", n, tongnew);
            Console.WriteLine("Gia tri lon nhat: {0}", a[0]);
            Console.WriteLine("Gia tri nho nhat: {0}", a[n - 1]);
            Console.WriteLine("So Phan tu nho hon hoac khong lơn hon 100 : {0}", mangnew,newArr[mangnew-1]);

            Console.ReadLine();

        }
    }
}

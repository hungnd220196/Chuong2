// See https://aka.ms/new-console-template for more information

//Console.WriteLine("Hello, World!");

//bt chương 1
// 1. Nền tảng .NET Framework là gì?

/*
 Là môi trường đa ngôn ngữ để xây dựng, triển khai và chạy các ứng dụng do hãng Microsoft phát triển.
.NET Framework cho phép phát triển các ứng dụng chạy trên nhiều môi trường khác nhau như thiết bị
di động, máy tính để bàn, điện thoại thông minh, dịch vụ web…
.NET Framework là thành phần được cài đặt sẵn khi cài đặt hệ điều hành windows. Nếu hệ điều hành
nào chưa có .NET Framework cài sẵn thì bạn hoàn toàn có thể tự cài đặt thêm.
 */

//2.2. Các công nghệ cốt lõi sử dụng trong .NET Framework là gì? 
// Microsoft Intermediate Language , Common Language Runtime

//3.  Liệt kê ra các thành phần của .NET Framework?

/*
 - Các ngôn ngữ lập trình
 - Thư viện các lớp(Framework Class Library - FCL)
 - The Common Language Runtime(CLR)
 */

// 4. .NET Framework hỗ trợ ngôn ngữ lập trình C/C++?
// có hỗ trợ 

//5.Có thể dùng ngôn ngữ C# viết các chương trình chạy trên các thiết bị di động?
// có thể 

//6. Mục đích của Common Language Runtime là gì?
// biên  dịch ngôn ngữ trung gian sang ngôn ngữ máy.

//7. ____________thực hiện các chức năng quản lý bộ nhớ, xử lý lỗi, dọn dẹp bộ nhớ?
//  Common Language Runtime 

//8. ____________cung cấp một tập các lớp để làm việc với cơ sở dữ liệu?
//-Entity Framework
// - ADO.NET
// - Dapper

//9. ____________cung cấp một tập các lớp để thiết kế các Form cho các trang web giống như Form HMTL?
//- ASP.NET Web Forms
//-ASP.NET MVC
//- Razor Pages

//10. ___________được sử dụng như là công cụ để phát triển các ứng dụng cho máy để bàn, dịch vụ web, ứng dụng mobile ứng dụng web có hiệu suất cao?
// - Visual Studio

//11. Trong một ứng dụng có thể có bao nhiêu phương thức Main?
// có 1 phương thức Main 

//12. Chương trình C# sẽ bắt ñầu thực thi từ đâu ?
// từ phương thức Main 


string ten = "Nguyen Duc Hung";
int age = 28;
float diem = 9.66f;
Console.WriteLine("ho va ten: "+ ten);

Console.WriteLine("Ten ban la: {0,2:s} \n Tuoi: {1,5:d} \n Diem: {2,2:f2}", ten, age, diem);

//Console.WriteLine("moi ban nhap ten");
//string name = Console.ReadLine();
//Console.WriteLine("ten ban la: "+ name);

//DateTime dateTime = DateTime.Now;
//Console.WriteLine("d fomat: {0:d}", dateTime);
//Console.WriteLine("D fomat: {0:D}", dateTime);
//Console.WriteLine("t fomat: {0:t}", dateTime);

//Câu hỏi và bài tập

//1. Sau khi viết xong chương trình bằng C#, nếu copy tệp tin *.exe đã viết sang máy khác để chạy,
//   chương trình ñó có chạy không? Giải thích.
// chương trình có chạy. 
// Sau khi biên dịch lần đầu tiên chạy chương trình, ngôn ngữ MSIL sẽ được biên dịch sang ngôn ngữ máy 
// Quá trình chuyển ñổi từ MSIL sang ngôn ngữ máy lúc thực thi chương trình được thực hiện bởi
// thành phần Just – in – time compiler nằm trong CLR(Common Language Runtime). 
//CLR là một máy ảo của .NET nó ñược dùng để chuyển đổi mã MSIL sang mã máy. Sau đó các
// đoạn mã được thực thi bởi CPU. 


// 2. Kí tự đầu tiên của tên biến có thể là kí số ? 
// - kí tự đầu tiên của tên biến không thể là kí tự số

//3 Tên biến có thể là từ khóa ? 
// Tên biến không đươc trùng với từ khóa

// 4.Lớp Console thuộc vào namespace nào ?
// Lớp Console thuộc namespace System 

// 5. Viết chương trình tính diện tích và chu vi hình chữ nhật. 

//Console.WriteLine("Mời bạn nhập chiều dài ");
//double length = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Mời bạn nhập chiều rộng ");
//double width  = Convert.ToDouble(Console.ReadLine());

//double perimeter = (length + width) * 2;

//double area = length * width;
//Console.WriteLine("diện tích hcn:{0:F2} " , area);
//Console.WriteLine("chu vi hcn:{0:F2} " , perimeter);

//6 Viết chương trình tính thể tích của một hình trụ (V = 3,14.r2.h)

//Console.WriteLine(" mời bạn nhập bán kính ");
//double radius = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine(" mới bạn nhập chiều cao ");
//double heigth = Convert.ToDouble(Console.ReadLine());

//double volume = Math.PI * radius * radius * heigth;
//Console.WriteLine(" thể tích hình trụ là: {0:f3} ", volume);

// 7  Viết chương trình tính lương thực lãnh của một nhân viên theo công thưc dưới đây :
// Lương cơ bản : $ 12000
// BHYT: 12 % lương cơ bản(Bảo hiểm y tế)
// BHXH: $150(Bảo hiểm xã hội)
// CD: $120(Tiền Công ñoàn)
// Thuế: 14 % lương cơ bản
// Lương thực lãnh = Lương cơ bản - BHYT - BHXH - CD


Console.WriteLine("moi ban nhap luong co ban ");
double basicSalary = Convert.ToDouble(Console.ReadLine()); 
double bhyt = 0.12* basicSalary;
int bhxh = 150;
int cd = 120;
double tax = 0.14 * basicSalary;

double  salary = basicSalary - bhyt - bhxh - cd;
Console.WriteLine("salary:  " + salary);











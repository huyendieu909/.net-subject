using System.Text;
using System.IO;
namespace phieu_bai_ve_nha
{
    internal class Program
    {
        public struct SinhVien
        {
            public int id;
            public string ten;
            public string gioiTinh;
            public int tuoi;
            public double diemToan;
            public double diemLy;
            public double diemHoa;
            public double diemTB;
            public string hocLuc;
        }
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.ForegroundColor = ConsoleColor.Cyan;
            try
            {

                StreamReader sr = new StreamReader("/student.txt");
                //StreamWriter sw = new StreamWriter("/student2.txt", false);
                SinhVien[] sv = new SinhVien[1000];
                int id = 0, n=0;
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    sv[id] = new SinhVien();
                    sv[id].id = id;
                    sv[id].ten = line;
                    sv[id].gioiTinh = sr.ReadLine();
                    sv[id].tuoi = Convert.ToInt32(sr.ReadLine());
                    sv[id].diemToan = Convert.ToInt32(sr.ReadLine());
                    sv[id].diemLy = Convert.ToInt32(sr.ReadLine());
                    sv[id].diemHoa = Convert.ToInt32(sr.ReadLine());
                    sv[id].diemTB = (sv[id].diemToan + sv[id].diemLy + sv[id].diemHoa) / 3;
                    sv[id].hocLuc = xetHocLuc(sv[id].diemTB);
                    id++;n++;
                }

                int choose;
                do
                {
                    menu();
                    csout("---Nhập lựa chọn của bạn: ");
                    choose = int.Parse(Console.ReadLine());
                    if (choose < 1 || choose > 9) csout("Vui lòng nhập chính xác lệnh! Nhập lại: ");
                    switch (choose)
                    {
                        //thêm sinh viên 
                        case 1:
                            sv[n] = new SinhVien();
                            sv[n] = nhapSinhVien();
                            n++;
                            sv[n-1].id = n-1;
                            csout("---Thêm sinh viên thành công!---\n\n");
                            break;
                        //Cập nhật theo id
                        case 2:
                            csout("Nhập id sinh viên cần cập nhật thông tin: ");
                            int nhapId = int.Parse(Console.ReadLine());
                            if (nhapId < n && nhapId >= 0)
                            {
                                sv[nhapId] = nhapSinhVien();
                                Console.WriteLine($"---Cập nhật thông tin cho sinh viên có id {nhapId} thành công!---");
                            }
                            else
                            {
                                csout("---id không hợp lệ!---\n");
                            }
                            break; 
                        //xóa theo id
                        case 3:
                            csout("Nhập id sinh viên cần xóa: ");
                            int idXoa = int.Parse(Console.ReadLine());
                            if (idXoa < n && idXoa >= 0)
                            {
                                for (int i = idXoa; i < n - 1; i++) sv[i] = sv[i + 1];
                                n--;
                                Console.WriteLine($"---Xóa sinh viên có id {idXoa} thành công!---");
                            }
                            else
                            {
                                csout("---id không hợp lệ!---\n");
                            }
                            break;
                        //tìm kiếm theo id
                        case 4:
                            csout("Nhập tên sinh viên cần tìm kiếm: ");
                            string timTheoTen = Console.ReadLine();
                            for (int i = 0; i < n; i++)
                            {
                                if (sv[i].ten.Contains(timTheoTen))
                                {
                                    csout(" ID_____________Họ và Tên______Giới tính_____Tuổi______Toán______Lý_____Hóa______TB_____Học lực\n");
                                    for (int j = i; j < n; j++)
                                    {
                                        if (sv[j].ten.Contains(timTheoTen))
                                            Console.WriteLine("{0,3}{1,26}{2,9}{3,11}{4,10:0.00}{5,8:0.00}{6,8:0.00}{7,8:0.00}{8,12}", sv[i].id, sv[i].ten, sv[i].gioiTinh, sv[i].tuoi, sv[i].diemToan, sv[i].diemLy, sv[i].diemHoa, sv[i].diemTB, sv[i].hocLuc);
                                    }
                                    break;
                                } 
                            }
                            break;
                        //sắp xếp theo điểm trung bình
                        case 5:
                            for (int i = 0;i < n-1; i++)
                            {
                                for (int j = i+1; j < n; j++)
                                {
                                    if (sv[i].diemTB > sv[j].diemTB)
                                    {
                                        SinhVien temp = sv[i];
                                        sv[i] = sv[j];
                                        sv[j] = temp;
                                    }
                                }
                            }
                            csout("---Đã sắp xếp sinh viên theo điểm trung bình tăng dần!---\n");
                            break;
                        //sắp xếp theo tên
                        case 6:
                            for (int i = 0; i < n - 1; i++)
                            {
                                string[] hoten1 = sv[i].ten.Split(" ");                   
                                for (int j = i + 1; j < n; j++)
                                {
                                    string[] hoten2 = sv[j].ten.Split(" ");
                                    int ss = string.Compare(hoten1[hoten1.Length-1], hoten2[hoten2.Length-1]);
                                    if (ss > 0)
                                    {
                                        SinhVien temp = sv[i];
                                        sv[i] = sv[j];
                                        sv[j] = temp;
                                    }
                                }
                            }
                            csout("---Sắp xếp theo tên thành công!---\n");
                            break;
                        case 7:
                            csout("\t\t\t---___Danh sách sinh viên___---\n");
                            csout(" ID_____________Họ và Tên______Giới tính_____Tuổi______Toán______Lý_____Hóa______TB_____Học lực\n");
                            for (int i = 0; i<n; i++)
                            {
                                Console.WriteLine("{0,3}{1,26}{2,9}{3,11}{4,10:0.00}{5,8:0.00}{6,8:0.00}{7,8:0.00}{8,12}", sv[i].id, sv[i].ten, sv[i].gioiTinh, sv[i].tuoi, sv[i].diemToan, sv[i].diemLy, sv[i].diemHoa, sv[i].diemTB, sv[i].hocLuc);
                            }
                            break;
                        case 8:
                            sr.Close();
                            StreamWriter sw = new StreamWriter("/student.txt", false);
                            for (int i = 0; i < n; i++)
                            {
                                sw.WriteLine(sv[i].ten);
                                sw.WriteLine(sv[i].gioiTinh);
                                sw.WriteLine(sv[i].tuoi);
                                sw.WriteLine(sv[i].diemToan);
                                sw.WriteLine(sv[i].diemLy);
                                sw.WriteLine(sv[i].diemHoa);
                            }
                            csout("---Ghi vào file thành công!---\n");
                            sw.Close();
                            sr = new StreamReader("/student.txt");
                            break;
                        case 9:
                            csout("====Chương trình kết thúc===\n");
                            Environment.Exit(0);
                            break; 
                    }
                } while (choose != 9);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        static SinhVien nhapSinhVien()
        {
            SinhVien x = new SinhVien();
            csout("Nhập thông tin cho sinh viên: \n");
            csout("Nhập tên sinh viên: ");
            x.ten = Console.ReadLine();
            csout("Nhập giới tính: ");
            x.gioiTinh = Console.ReadLine();
            csout("Nhập tuổi: ");
            x.tuoi = int.Parse(Console.ReadLine());
            csout("Điểm toán: ");
            x.diemToan = int.Parse(Console.ReadLine());
            csout("Điểm lý: ");
            x.diemLy = int.Parse(Console.ReadLine());
            csout("Điểm hóa: ");
            x.diemHoa = int.Parse(Console.ReadLine());
            x.diemTB = (x.diemToan + x.diemLy + x.diemHoa) / 3;
            x.hocLuc = xetHocLuc(x.diemTB);
            return x;
        }
        static string xetHocLuc(double a)
        {
            if (a >= 8) return "Giỏi";
            else if (a >= 6.5) return "Khá";
            else if (a >= 5) return "Trung bình";
            else return "Yếu";
        }
        /* đây là hàm Console.Write */
        static void csout(object o)
        {
            Console.Write(o);
        }
        static void menu()
        {
            csout("\n\n=====Menu=====\n");
            csout("1. Thêm sinh viên\n");
            csout("2. Cập nhật thông tin sinh viên bởi id\n");
            csout("3. Xóa sinh viên bởi id\n");
            csout("4. Tìm kiếm sinh viên theo tên\n");
            csout("5. Sắp xếp sinh viên theo điểm trung bình\n");
            csout("6. Sắp xếp thông tin sinh viên theo tên\n");
            csout("7. Hiển thị danh sách sinh viên\n");
            csout("8. Ghi danh sách sinh viên vào file student.txt\n");
            csout("9. Thoát chương trình\n");
        }
    }
}
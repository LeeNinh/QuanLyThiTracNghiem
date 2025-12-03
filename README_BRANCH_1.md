# NHÁNH 1: QUẢN LÝ HỌC SINH & ĐĂNG NHẬP

## 👤 Thành viên phụ trách: Bạn 1

---

## 🎯 NHIỆM VỤ

Xây dựng module quản lý học sinh và xác thực người dùng.

---

## 📋 CHỨC NĂNG CẦN LÀM

### 1. Đăng nhập học sinh
- Form đăng nhập với username/password
- Kiểm tra thông tin trong database
- Chuyển đến form thông tin sau khi đăng nhập thành công

### 2. Đăng ký tài khoản mới
- Form nhập thông tin: Mã TS, Họ tên, Địa chỉ, Ngày sinh, Trường, Lớp
- Tạo username/password
- Lưu vào database
- Validate dữ liệu đầu vào

### 3. Đổi mật khẩu
- Nhập mật khẩu cũ
- Nhập mật khẩu mới
- Xác nhận mật khẩu mới
- Cập nhật database

### 4. Lấy lại mật khẩu
- Nhập mã thí sinh + username
- Hiển thị mật khẩu nếu đúng

### 5. Xem thông tin cá nhân
- Hiển thị thông tin học sinh đã đăng nhập
- Cho phép cập nhật một số thông tin

---

## 📁 FILES CẦN LÀM VIỆC

### Presentation Layer (Forms):
```
quanly_cauhoi_tracnghiem/
├── Form1.cs                    # Form đăng nhập chính
├── Form1.Designer.cs
├── Form1.resx
├── Dangky.cs                   # Form đăng ký
├── Dangky.Designer.cs
├── Dangky.resx
├── ThongtinTS.cs              # Form thông tin thí sinh
├── ThongtinTS.Designer.cs
├── ThongtinTS.resx
├── Form_DoiMK.cs              # Form đổi mật khẩu
├── Form_DoiMK.Designer.cs
├── Form_DoiMK.resx
└── Form_CapMK.cs              # Form cấp/lấy lại mật khẩu
    Form_CapMK.Designer.cs
    Form_CapMK.resx
```

### Business Layer:
```
Tracnghiem_Business/
└── ThiSinhBS.cs               # Chỉ làm phần liên quan học sinh
    - dangki()
    - GetThiSinh()
    - DoiMatKhau()
    - GetThiSinhDN()
    - GetMatKhau()
    - GetThiSinhTen()
    - GetThiSinhMa()
```

### Data Access Layer:
```
Tracnghiem_DataAccess/
└── ThiSinhDA.cs               # Chỉ làm phần liên quan học sinh
    - dangki()
    - GetThiSinh()
    - DoiMatKhau()
    - GetThiSinhDN()
    - GetMatKhau()
    - GetThiSinh()
    - GetThiSinhTen()
    - GetThiSinhMa()
```

---

## 🗄️ DATABASE TABLES

### Table_ThiSinh
```sql
CREATE TABLE Table_ThiSinh (
    MaThiSinh NCHAR(10) PRIMARY KEY,
    HoTen NVARCHAR(50) NOT NULL,
    DiaChi NVARCHAR(50) NOT NULL,
    NgaySinh NCHAR(20) NOT NULL,
    TenDangNhap NCHAR(20) NOT NULL,
    MatKhau NCHAR(10) NOT NULL,
    Truong NVARCHAR(50) NOT NULL,
    Lop NVARCHAR(50) NOT NULL
)
```

---

## 🚀 CÁCH BẮT ĐẦU

### Bước 1: Checkout nhánh
```bash
git checkout feature/student-management
```

### Bước 2: Sửa Program.cs để test
```csharp
using System;
using System.Windows.Forms;

namespace Tracnghiem_Application
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // Bắt đầu từ form đăng nhập
            Application.Run(new Form_Dangnhap());
        }
    }
}
```

### Bước 3: Tạo dữ liệu test
Chạy SQL này để có dữ liệu test:
```sql
-- Thêm học sinh mẫu
INSERT INTO Table_ThiSinh VALUES 
('TS001', N'Nguyễn Văn A', N'Hà Nội', '01/01/2005', 'student1', '123456', N'THPT ABC', N'12A1'),
('TS002', N'Trần Thị B', N'Hà Nội', '02/02/2005', 'student2', '123456', N'THPT ABC', N'12A2');
```

### Bước 4: Build và chạy
```bash
# Trong Visual Studio: F5 hoặc Ctrl+F5
```

---

## ✅ CHECKLIST CÔNG VIỆC

### Giai đoạn 1: Setup (1 ngày)
- [ ] Checkout nhánh feature/student-management
- [ ] Chạy được project
- [ ] Tạo dữ liệu test trong database
- [ ] Hiểu rõ code hiện tại

### Giai đoạn 2: Phát triển (3-4 ngày)
- [ ] Form đăng nhập hoạt động
- [ ] Form đăng ký hoạt động
- [ ] Đổi mật khẩu hoạt động
- [ ] Lấy lại mật khẩu hoạt động
- [ ] Xem thông tin cá nhân hoạt động
- [ ] Validate dữ liệu đầu vào
- [ ] Xử lý lỗi (try-catch)
- [ ] Thông báo lỗi rõ ràng cho user

### Giai đoạn 3: Test (1 ngày)
- [ ] Test đăng nhập với user đúng
- [ ] Test đăng nhập với user sai
- [ ] Test đăng ký với dữ liệu hợp lệ
- [ ] Test đăng ký với dữ liệu trùng
- [ ] Test đổi mật khẩu
- [ ] Test lấy lại mật khẩu
- [ ] Test xem thông tin

### Giai đoạn 4: Hoàn thiện (1 ngày)
- [ ] Code sạch, có comment
- [ ] Không có lỗi compile
- [ ] Không có lỗi runtime
- [ ] UI đẹp, dễ sử dụng
- [ ] Viết báo cáo phần của mình

---

## 🔧 CODE MẪU

### Validate dữ liệu đăng ký:
```csharp
private bool ValidateInput()
{
    if (string.IsNullOrWhiteSpace(textBox_ma.Text))
    {
        MessageBox.Show("Vui lòng nhập mã thí sinh!");
        textBox_ma.Focus();
        return false;
    }
    
    if (string.IsNullOrWhiteSpace(textBox_hoten.Text))
    {
        MessageBox.Show("Vui lòng nhập họ tên!");
        textBox_hoten.Focus();
        return false;
    }
    
    // Kiểm tra mật khẩu
    if (textBox_mk.Text.Length < 6)
    {
        MessageBox.Show("Mật khẩu phải có ít nhất 6 ký tự!");
        textBox_mk.Focus();
        return false;
    }
    
    return true;
}
```

### Xử lý đăng nhập:
```csharp
private void button_dangnhap_Click(object sender, EventArgs e)
{
    try
    {
        if (string.IsNullOrWhiteSpace(textBox_username.Text) || 
            string.IsNullOrWhiteSpace(textBox_password.Text))
        {
            MessageBox.Show("Vui lòng nhập đầy đủ thông tin!");
            return;
        }
        
        ThiSinhBS tsbs = new ThiSinhBS();
        DataTable dt = tsbs.GetThiSinhDN(textBox_username.Text, textBox_password.Text).Tables[0];
        
        if (dt.Rows.Count > 0)
        {
            MessageBox.Show("Đăng nhập thành công!");
            // Chuyển sang form khác
            ThongtinTS form = new ThongtinTS();
            form.Show();
            this.Hide();
        }
        else
        {
            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!");
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show("Lỗi: " + ex.Message);
    }
}
```

---

## 📝 LƯU Ý

1. **Không được sửa các form khác** (Form_THI, Form_QLCH, Form_Dieuhanh...)
2. **Chỉ sửa phần liên quan học sinh** trong ThiSinhDA.cs và ThiSinhBS.cs
3. **Commit thường xuyên:**
   ```bash
   git add .
   git commit -m "Hoàn thành chức năng đăng nhập"
   ```
4. **Test kỹ trước khi commit**

---

## 🆘 GẶP VẤN ĐỀ?

### Lỗi kết nối database:
- Kiểm tra connection string trong App.config
- Đảm bảo SQL Server đang chạy
- Kiểm tra tên database

### Lỗi compile:
- Clean solution (Build > Clean Solution)
- Rebuild (Build > Rebuild Solution)

### Form không hiển thị:
- Kiểm tra InitializeComponent() trong constructor
- Kiểm tra file .Designer.cs

---

**Chúc bạn làm việc hiệu quả! 💪**

# ĐỒ ÁN QUẢN LÝ THI TRẮC NGHIỆM

**Môn học:** Lập trình trực quan IT09  
**Đề tài:** Đề 08 - Quản lý thi trắc nghiệm

---

## THÀNH VIÊN NHÓM

| STT | Họ và tên | Vai trò | Nhánh làm việc |
|-----|-----------|---------|----------------|
| 1 | **Lê Đức Ninh** | Nhóm trưởng, Tích hợp | `feature/student-management` |
| 2 | Bùi Văn Nguyên | Thành viên | `feature/question-management` |
| 3 | Nguyễn Hoàng Phong | Thành viên | `feature/exam-result` |
| 4 | Đỗ Trần Tuấn Hùng | Thành viên | `feature/admin-report` |

---

## PHÂN CÔNG NHIỆM VỤ

### 1. Lê Đức Ninh - Quản lý học sinh & Xác thực
**Nhánh:** `feature/student-management`

**Chức năng:**
- Đăng nhập học sinh
- Đăng ký tài khoản học sinh
- Đổi mật khẩu
- Quên mật khẩu
- Xem thông tin cá nhân học sinh

**Files phụ trách:**
- `Form1.cs` - Form đăng nhập
- `Dangky.cs` - Form đăng ký
- `ThongtinTS.cs` - Thông tin thí sinh
- `Form_DoiMK.cs` - Đổi mật khẩu
- `Form_CapMK.cs` - Cấp lại mật khẩu
- `ThiSinhDA.cs` - Data Access (phần học sinh)
- `ThiSinhBS.cs` - Business Logic (phần học sinh)

**Database:** `Table_ThiSinh`

**Nhiệm vụ thêm:** Merge tất cả nhánh vào master khi hoàn thành

---

### 2. Bùi Văn Nguyên - Quản lý câu hỏi & Ngân hàng đề
**Nhánh:** `feature/question-management`

**Chức năng:**
- Thêm câu hỏi mới
- Sửa câu hỏi
- Xóa câu hỏi
- Quản lý ngân hàng câu hỏi
- Quản lý môn thi
- Tìm kiếm câu hỏi

**Files phụ trách:**
- `Form_QLCH.cs` - Quản lý câu hỏi
- `Form_QLCHCS.cs` - Chỉnh sửa câu hỏi
- `Form_QLCHX.cs` - Xóa câu hỏi
- `Form_TTNHCH.cs` - Ngân hàng câu hỏi
- `Form_TKCH.cs` - Tìm kiếm câu hỏi
- `Form_QLMT.cs` - Quản lý môn thi
- `ThiSinhDA.cs` - Data Access (phần câu hỏi)
- `ThiSinhBS.cs` - Business Logic (phần câu hỏi)

**Database:** `Table_CauHoi`, `Table_DapAn`, `Table_MonThi`, `Table_LoaiCauHoi`

---

### 3. Nguyễn Hoàng Phong - Thi trắc nghiệm & Kết quả
**Nhánh:** `feature/exam-result`

**Chức năng:**
- Thi trắc nghiệm (random đề thi)
- Đếm ngược thời gian
- Chấm điểm tự động
- Hiển thị kết quả
- Lưu kết quả thi
- Xem danh sách kết quả

**Files phụ trách:**
- `Form_THI.cs` - Form thi
- `Form_KetQua.cs` - Hiển thị kết quả
- `Form_TTDSKQ.cs` - Danh sách kết quả
- `ThiSinhDA.cs` - Data Access (phần thi)
- `ThiSinhBS.cs` - Business Logic (phần thi)

**Database:** `Table_KetQua`

---

### 4. Đỗ Trần Tuấn Hùng - Quản trị hệ thống & Báo cáo
**Nhánh:** `feature/admin-report`

**Chức năng:**
- Đăng nhập giáo viên/quản trị
- Quản lý nhân viên
- Thêm/Xóa nhân viên
- Phân quyền (Điều hành, Quản lý, Nhân viên)
- Thống kê kết quả thi
- Báo cáo
- Xem danh sách học sinh, nhân viên

**Files phụ trách:**
- `Form_Dieuhanh.cs` - Form điều hành
- `Form_QLNV.cs` - Quản lý nhân viên
- `Form_XoaNV.cs` - Xóa nhân viên
- `Form_TKNV.cs` - Thống kê nhân viên
- `Form_TKTS.cs` - Thống kê thí sinh
- `Form_TTDSNV.cs` - Danh sách nhân viên
- `Form_TTDSTS.cs` - Danh sách thí sinh
- `Form_LienHe.cs` - Liên hệ
- `NhanvienDA.cs` - Data Access
- `NhanVienBS.cs` - Business Logic

**Database:** `Table_NhanVien`, `Table_NguoiDung`

---

## CẤU TRÚC DỰ ÁN

```
QuanLyThiTracNghiem/
├── quanly_cauhoi_tracnghiem/          # Presentation Layer (WinForms)
├── Tracnghiem_Business/                # Business Logic Layer
├── Tracnghiem_DataAccess/              # Data Access Layer
├── quanlycauhoitracnghiem.sql         # Database Script
└── quanly_thitracnghiem.sln           # Solution File
```

---

## QUY TRÌNH LÀM VIỆC

### Bước 1: Clone repository
```bash
git clone https://github.com/LeeNinh/QuanLyThiTracNghiem.git
cd QuanLyThiTracNghiem
```

### Bước 2: Checkout nhánh của mình
```bash
# Ninh
git checkout feature/student-management

# Nguyên
git checkout feature/question-management

# Phong
git checkout feature/exam-result

# Hùng
git checkout feature/admin-report
```

### Bước 3: Làm việc hàng ngày
```bash
# Sáng: Pull code mới
git pull origin TEN_NHANH_CUA_BAN

# Code...

# Tối: Push code lên
git add .
git commit -m "Mô tả công việc"
git push origin TEN_NHANH_CUA_BAN
```

### Bước 4: Merge (Ninh thực hiện)
```bash
git checkout master
git merge feature/student-management
git merge feature/question-management
git merge feature/exam-result
git merge feature/admin-report
git push origin master
```

---

## CÔNG NGHỆ SỬ DỤNG

- **Ngôn ngữ:** C# .NET Framework 4.8
- **IDE:** Visual Studio 2019/2022
- **Database:** SQL Server
- **UI:** Windows Forms, DevComponents DotNetBar
- **Version Control:** Git, GitHub

---

## CÀI ĐẶT

### 1. Cấu hình Database
Chạy file `quanlycauhoitracnghiem.sql` trong SQL Server Management Studio

### 2. Sửa Connection String
File `quanly_cauhoi_tracnghiem/App.config`:
```xml
<connectionStrings>
  <add name="connectionstring" 
       connectionString="Data Source=TEN_MAY;
                        Initial Catalog=quanlycauhoitracnghiem;
                        Integrated Security=True;
                        TrustServerCertificate=true"/>
</connectionStrings>
```

### 3. Build và chạy
Mở `quanly_thitracnghiem.sln` trong Visual Studio, nhấn F5

---

## LIÊN HỆ

**Repository:** https://github.com/LeeNinh/QuanLyThiTracNghiem  
**Nhóm trưởng:** Lê Đức Ninh

# BÀI TẬP LỚN QUẢN LÝ THI TRẮC NGHIỆM

**Môn học:** Lập trình hướng sự kiện - IT09.BTL.018
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

## CẤU TRÚC NHÁNH

```
master (production)
  ↑
develop (integration)
  ↑
  ├── feature/student-management (Ninh)
  ├── feature/question-management (Nguyên)
  ├── feature/exam-result (Phong)
  └── feature/admin-report (Hùng)
```

---

## QUY TRÌNH LÀM VIỆC

### Bước 1: Clone repository
```bash
git clone https://github.com/LeeNinh/QuanLyThiTracNghiem.git
cd QuanLyThiTracNghiem
```

### Bước 2: Checkout nhánh của mình từ develop
```bash
# Checkout develop trước
git checkout develop

# Tạo nhánh feature từ develop
# Ninh
git checkout feature/student-management
git merge develop

# Nguyên
git checkout feature/question-management
git merge develop

# Phong
git checkout feature/exam-result
git merge develop

# Hùng
git checkout feature/admin-report
git merge develop
```

### Bước 3: Làm việc hàng ngày
```bash
# Sáng: Pull code mới từ develop
git checkout develop
git pull origin develop
git checkout TEN_NHANH_CUA_BAN
git merge develop

# Code...

# Tối: Commit và push
git add .
git commit -m "Mô tả công việc cụ thể"
git push origin TEN_NHANH_CUA_BAN
```

### Bước 4: Tạo Pull Request (PR)
Khi hoàn thành một chức năng:

1. Push code lên nhánh của mình
2. Vào GitHub: https://github.com/LeeNinh/QuanLyThiTracNghiem
3. Click **"Pull requests"** → **"New pull request"**
4. Chọn:
   - **base:** `develop`
   - **compare:** `feature/TEN_NHANH_CUA_BAN`
5. Click **"Create pull request"**
6. Điền tiêu đề: `[Tên bạn] Hoàn thành [chức năng]`
7. Mô tả những gì đã làm
8. Click **"Create pull request"**
9. Thông báo cho Ninh review

### Bước 5: Review và Merge (Ninh thực hiện)
```bash
# Xem PR trên GitHub
# Review code
# Nếu OK: Click "Merge pull request" trên GitHub
# Hoặc merge bằng command line:

git checkout develop
git pull origin develop
git merge feature/student-management --no-ff -m "Merge: Hoàn thành quản lý học sinh"
git push origin develop
```

### Bước 6: Merge vào master (cuối cùng)
```bash
# Khi tất cả hoàn thành
git checkout master
git merge develop --no-ff -m "Release: Hoàn thành dự án"
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


---

## HƯỚNG DẪN TẠO PULL REQUEST

### Cho thành viên (Nguyên, Phong, Hùng):

**Bước 1:** Hoàn thành code và push lên nhánh của mình
```bash
git add .
git commit -m "Hoàn thành chức năng đăng nhập"
git push origin feature/question-management
```

**Bước 2:** Tạo Pull Request trên GitHub
1. Vào: https://github.com/LeeNinh/QuanLyThiTracNghiem/pulls
2. Click **"New pull request"**
3. Chọn:
   - base: `develop` ← compare: `feature/question-management`
4. Click **"Create pull request"**
5. Tiêu đề: `[Nguyên] Hoàn thành quản lý câu hỏi`
6. Mô tả:
   ```
   ## Đã hoàn thành:
   - Thêm câu hỏi
   - Sửa câu hỏi
   - Xóa câu hỏi
   - Quản lý môn thi
   
   ## Test:
   - Đã test tất cả chức năng
   - Không có lỗi
   ```
7. Click **"Create pull request"**
8. Tag @LeeNinh để review

**Bước 3:** Đợi Ninh review và merge

---

### Cho Ninh (Nhóm trưởng):

**Review Pull Request:**
1. Vào: https://github.com/LeeNinh/QuanLyThiTracNghiem/pulls
2. Click vào PR cần review
3. Click tab **"Files changed"** để xem code
4. Nếu OK: Click **"Merge pull request"**
5. Chọn **"Create a merge commit"** (để giữ lịch sử)
6. Click **"Confirm merge"**

**Hoặc merge bằng command line:**
```bash
git checkout develop
git pull origin develop
git merge feature/question-management --no-ff -m "Merge: [Nguyên] Hoàn thành quản lý câu hỏi"
git push origin develop
```

**Lưu ý:** Dùng `--no-ff` để tạo merge commit, giúp thầy thấy rõ lịch sử merge

---

## XEM LỊCH SỬ MERGE

```bash
# Xem lịch sử đầy đủ
git log --graph --oneline --all

# Xem lịch sử merge vào develop
git log --merges --oneline develop

# Xem ai đã merge gì
git log --merges --pretty=format:"%h - %an, %ar : %s" develop
```

Kết quả sẽ hiển thị:
```
abc1234 - Lê Đức Ninh, 2 days ago : Merge: [Nguyên] Hoàn thành quản lý câu hỏi
def5678 - Lê Đức Ninh, 3 days ago : Merge: [Phong] Hoàn thành thi trắc nghiệm
```

---

## LƯU Ý QUAN TRỌNG

### Cho tất cả thành viên:
-  **Luôn pull code từ develop** trước khi bắt đầu làm việc
-  **Commit message rõ ràng:** "Hoàn thành chức năng X"
-  **Tạo PR khi hoàn thành** một chức năng hoàn chỉnh
-  **Test kỹ** trước khi tạo PR
-  **Không merge trực tiếp** vào develop (chỉ Ninh mới merge)
-  **Không push trực tiếp** vào develop hoặc master

### Cho Ninh:
-  **Review code** trước khi merge
-  **Dùng `--no-ff`** khi merge để giữ lịch sử
-  **Viết message merge rõ ràng:** "Merge: [Tên] Hoàn thành [chức năng]"
-  **Test sau khi merge** để đảm bảo không conflict

---

## VÍ DỤ WORKFLOW HOÀN CHỈNH

### Nguyên làm việc:
```bash
# Ngày 1
git checkout develop
git pull origin develop
git checkout feature/question-management
git merge develop

# Code chức năng thêm câu hỏi
git add .
git commit -m "Thêm chức năng thêm câu hỏi"
git push origin feature/question-management

# Ngày 2
# Code chức năng sửa câu hỏi
git add .
git commit -m "Thêm chức năng sửa câu hỏi"
git push origin feature/question-management

# Ngày 3 - Hoàn thành
git add .
git commit -m "Hoàn thành quản lý câu hỏi"
git push origin feature/question-management

# Tạo PR trên GitHub
# Đợi Ninh merge
```

### Ninh review và merge:
```bash
# Xem PR trên GitHub
# Review code của Nguyên
# Nếu OK, merge:

git checkout develop
git pull origin develop
git merge feature/question-management --no-ff -m "Merge: [Nguyên] Hoàn thành quản lý câu hỏi"
git push origin develop

# Thông báo cho Nguyên đã merge
```

### Phong pull code mới:
```bash
# Sau khi Ninh merge code của Nguyên
git checkout develop
git pull origin develop
git checkout feature/exam-result
git merge develop

# Tiếp tục code...
```

---

## KHI NÀO MERGE VÀO MASTER?

**Chỉ merge vào master khi:**
-  Tất cả 4 người đã hoàn thành
-  Đã merge tất cả vào develop
-  Đã test toàn bộ hệ thống trên develop
-  Không còn lỗi
-  Sẵn sàng nộp bài

```bash
git checkout master
git merge develop --no-ff -m "Release v1.0: Hoàn thành dự án quản lý thi trắc nghiệm"
git push origin master
git tag -a v1.0 -m "Release version 1.0"
git push origin v1.0
```

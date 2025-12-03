# HƯỚNG DẪN LÀM VIỆC VỚI 4 NHÁNH ĐỘC LẬP

## 📋 TỔNG QUAN

Dự án đã được tạo 4 nhánh Git độc lập cho 4 thành viên:

1. **feature/student-management** - Quản lý học sinh & Đăng nhập
2. **feature/question-management** - Quản lý câu hỏi & Ngân hàng đề
3. **feature/exam-result** - Thi trắc nghiệm & Kết quả
4. **feature/admin-report** - Quản trị hệ thống & Báo cáo

---

## 🚀 CÁCH LÀM VIỆC

### **Bước 1: Mỗi bạn checkout nhánh của mình**

**Bạn 1 - Quản lý học sinh:**
```bash
git checkout feature/student-management
```

**Bạn 2 - Quản lý câu hỏi:**
```bash
git checkout feature/question-management
```

**Bạn 3 - Thi & Kết quả:**
```bash
git checkout feature/exam-result
```

**Bạn 4 - Quản trị & Báo cáo:**
```bash
git checkout feature/admin-report
```

---

### **Bước 2: Mỗi bạn làm việc trên nhánh của mình**

Sau khi checkout, bạn có thể:
- Sửa code
- Thêm file mới
- Test chức năng của mình

**Lưu thay đổi:**
```bash
git add .
git commit -m "Mô tả thay đổi của bạn"
```

---

### **Bước 3: Khi hoàn thành, merge vào master**

**Quay về nhánh master:**
```bash
git checkout master
```

**Merge từng nhánh vào master:**
```bash
git merge feature/student-management
git merge feature/question-management
git merge feature/exam-result
git merge feature/admin-report
```

---

## 📦 PHÂN CÔNG CHI TIẾT

### **NHÁNH 1: feature/student-management**
**Thành viên phụ trách:** Bạn 1

**Chức năng:**
- ✅ Đăng nhập học sinh
- ✅ Đăng ký tài khoản học sinh
- ✅ Đổi mật khẩu
- ✅ Lấy lại mật khẩu
- ✅ Xem thông tin cá nhân

**Files chính cần làm việc:**
- `quanly_cauhoi_tracnghiem/Form1.cs` (Đăng nhập)
- `quanly_cauhoi_tracnghiem/Dangky.cs` (Đăng ký)
- `quanly_cauhoi_tracnghiem/ThongtinTS.cs` (Thông tin)
- `quanly_cauhoi_tracnghiem/Form_DoiMK.cs` (Đổi MK)
- `Tracnghiem_DataAccess/ThiSinhDA.cs` (phần học sinh)
- `Tracnghiem_Business/ThiSinhBS.cs` (phần học sinh)

**Database tables:**
- `Table_ThiSinh`

**Cách test độc lập:**
Sửa `Program.cs`:
```csharp
Application.Run(new Form_Dangnhap());
```

---

### **NHÁNH 2: feature/question-management**
**Thành viên phụ trách:** Bạn 2

**Chức năng:**
- ✅ Thêm câu hỏi mới
- ✅ Sửa câu hỏi
- ✅ Xóa câu hỏi
- ✅ Quản lý ngân hàng câu hỏi
- ✅ Quản lý môn thi
- ✅ Tìm kiếm câu hỏi

**Files chính cần làm việc:**
- `quanly_cauhoi_tracnghiem/Form_QLCH.cs` (Quản lý câu hỏi)
- `quanly_cauhoi_tracnghiem/Form_QLCHCS.cs` (Chỉnh sửa)
- `quanly_cauhoi_tracnghiem/Form_QLCHX.cs` (Xóa)
- `quanly_cauhoi_tracnghiem/Form_TTNHCH.cs` (Ngân hàng)
- `quanly_cauhoi_tracnghiem/Form_TKCH.cs` (Tìm kiếm)
- `quanly_cauhoi_tracnghiem/Form_QLMT.cs` (Môn thi)
- `Tracnghiem_DataAccess/ThiSinhDA.cs` (phần câu hỏi)
- `Tracnghiem_Business/ThiSinhBS.cs` (phần câu hỏi)

**Database tables:**
- `Table_CauHoi`
- `Table_DapAn`
- `Table_MonThi`
- `Table_LoaiCauHoi`

**Cách test độc lập:**
Tạo form đơn giản để bypass đăng nhập, sửa `Program.cs`:
```csharp
// Giả lập đăng nhập
Application.Run(new Form_QLCH());
```

---

### **NHÁNH 3: feature/exam-result**
**Thành viên phụ trách:** Bạn 3

**Chức năng:**
- ✅ Thi trắc nghiệm (random đề)
- ✅ Đếm ngược thời gian
- ✅ Hiển thị kết quả
- ✅ Lưu kết quả thi
- ✅ Xem danh sách kết quả

**Files chính cần làm việc:**
- `quanly_cauhoi_tracnghiem/Form_THI.cs` (Thi)
- `quanly_cauhoi_tracnghiem/Form_KetQua.cs` (Kết quả)
- `quanly_cauhoi_tracnghiem/Form_TTDSKQ.cs` (Danh sách KQ)
- `Tracnghiem_DataAccess/ThiSinhDA.cs` (phần thi)
- `Tracnghiem_Business/ThiSinhBS.cs` (phần thi)

**Database tables:**
- `Table_KetQua`
- `Table_CauHoi` (read-only)
- `Table_DapAn` (read-only)
- `Table_ThiSinh` (read-only)
- `Table_MonThi` (read-only)

**Cách test độc lập:**
Tạo form chọn môn thi, sửa `Program.cs`:
```csharp
// Giả lập chọn môn thi
Application.Run(new Form_THI());
```

---

### **NHÁNH 4: feature/admin-report**
**Thành viên phụ trách:** Bạn 4

**Chức năng:**
- ✅ Đăng nhập giáo viên/admin
- ✅ Quản lý nhân viên
- ✅ Thêm/Xóa nhân viên
- ✅ Phân quyền (Điều hành, Quản lý, Nhân viên)
- ✅ Thống kê kết quả
- ✅ Báo cáo
- ✅ Xem danh sách

**Files chính cần làm việc:**
- `quanly_cauhoi_tracnghiem/Form_Dieuhanh.cs` (Điều hành)
- `quanly_cauhoi_tracnghiem/Form_QLNV.cs` (Quản lý NV)
- `quanly_cauhoi_tracnghiem/Form_XoaNV.cs` (Xóa NV)
- `quanly_cauhoi_tracnghiem/Form_TKNV.cs` (Thống kê NV)
- `quanly_cauhoi_tracnghiem/Form_TKTS.cs` (Thống kê TS)
- `quanly_cauhoi_tracnghiem/Form_TTDSNV.cs` (DS Nhân viên)
- `quanly_cauhoi_tracnghiem/Form_TTDSTS.cs` (DS Thí sinh)
- `quanly_cauhoi_tracnghiem/Form_LienHe.cs` (Liên hệ)
- `Tracnghiem_DataAccess/NhanvienDA.cs`
- `Tracnghiem_Business/NhanVienBS.cs`

**Database tables:**
- `Table_NhanVien`
- `Table_NguoiDung`
- Tất cả tables (read-only cho báo cáo)

**Cách test độc lập:**
Sửa `Program.cs`:
```csharp
Application.Run(new Form_Dieuhanh());
```

---

## ⚠️ QUY TẮC QUAN TRỌNG

### **1. KHÔNG được sửa database schema của người khác**
- Chỉ được thêm bảng/cột mới nếu cần
- Phải thông báo cho cả nhóm trước khi thêm

### **2. KHÔNG được sửa file của người khác**
- Mỗi người chỉ sửa file trong phần của mình
- Nếu cần sửa file chung, phải bàn bạc với nhóm

### **3. Commit thường xuyên**
```bash
git add .
git commit -m "Mô tả rõ ràng những gì đã làm"
```

### **4. Trước khi merge, test kỹ phần của mình**
- Đảm bảo code chạy được
- Không có lỗi compile
- Chức năng hoạt động đúng

---

## 🔄 QUY TRÌNH MERGE CUỐI CÙNG

**Bước 1:** Tất cả commit code của mình
```bash
git add .
git commit -m "Hoàn thành phần [tên phần]"
```

**Bước 2:** Một người (leader) thực hiện merge
```bash
git checkout master
git merge feature/student-management
git merge feature/question-management
git merge feature/exam-result
git merge feature/admin-report
```

**Bước 3:** Giải quyết conflicts (nếu có)
- Mở file bị conflict
- Chọn code đúng
- Commit lại

**Bước 4:** Test toàn bộ hệ thống
- Chạy từ đầu đến cuối
- Test tất cả chức năng
- Sửa lỗi nếu có

---

## 📞 HỖ TRỢ

Nếu gặp vấn đề:
1. Đọc kỹ hướng dẫn này
2. Hỏi trong nhóm
3. Google lỗi Git nếu cần

**Lệnh Git hữu ích:**
```bash
# Xem nhánh hiện tại
git branch

# Xem trạng thái
git status

# Xem lịch sử commit
git log --oneline

# Hủy thay đổi chưa commit
git checkout -- .

# Quay về commit trước
git reset --hard HEAD~1
```

---

## ✅ CHECKLIST TRƯỚC KHI NỘP

- [ ] Code chạy được trên nhánh của mình
- [ ] Đã commit tất cả thay đổi
- [ ] Đã test chức năng
- [ ] Đã viết báo cáo phần của mình
- [ ] Đã merge vào master thành công
- [ ] Toàn bộ hệ thống chạy được sau khi merge

---

**Chúc các bạn làm việc hiệu quả! 🎉**

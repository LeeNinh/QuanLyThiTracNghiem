# 🎯 HƯỚNG DẪN SỬ DỤNG 4 NHÁNH ĐỘC LẬP

## ✅ ĐÃ TẠO XONG

Dự án đã được setup với 4 nhánh Git độc lập:

```
master (nhánh chính - code gốc)
├── feature/student-management    (Bạn 1)
├── feature/question-management   (Bạn 2)
├── feature/exam-result          (Bạn 3)
└── feature/admin-report         (Bạn 4)
```

---

## 🚀 CÁCH MỖI BẠN BẮT ĐẦU

### **Bạn 1 - Quản lý học sinh:**
```bash
# 1. Checkout nhánh của bạn
git checkout feature/student-management

# 2. Xem file hướng dẫn
# Đọc file: README_BRANCH_1.md

# 3. Bắt đầu code
# Sửa các file trong phần của bạn

# 4. Lưu thay đổi
git add .
git commit -m "Hoàn thành đăng nhập"

# 5. Tiếp tục làm việc...
```

### **Bạn 2 - Quản lý câu hỏi:**
```bash
git checkout feature/question-management
# Làm tương tự bạn 1
```

### **Bạn 3 - Thi & Kết quả:**
```bash
git checkout feature/exam-result
# Làm tương tự bạn 1
```

### **Bạn 4 - Quản trị & Báo cáo:**
```bash
git checkout feature/admin-report
# Làm tương tự bạn 1
```

---

## 📊 PHÂN CÔNG CHI TIẾT

### **BẠNG 1: feature/student-management**
**Chức năng:**
- Đăng nhập học sinh
- Đăng ký tài khoản
- Đổi mật khẩu
- Lấy lại mật khẩu
- Xem thông tin cá nhân

**Files:**
- Form1.cs (Đăng nhập)
- Dangky.cs (Đăng ký)
- ThongtinTS.cs (Thông tin)
- Form_DoiMK.cs (Đổi MK)
- ThiSinhDA.cs (phần học sinh)
- ThiSinhBS.cs (phần học sinh)

**Database:** Table_ThiSinh

---

### **BẠNG 2: feature/question-management**
**Chức năng:**
- Thêm/Sửa/Xóa câu hỏi
- Quản lý ngân hàng câu hỏi
- Quản lý môn thi
- Tìm kiếm câu hỏi

**Files:**
- Form_QLCH.cs (Quản lý câu hỏi)
- Form_QLCHCS.cs (Chỉnh sửa)
- Form_QLCHX.cs (Xóa)
- Form_TTNHCH.cs (Ngân hàng)
- Form_TKCH.cs (Tìm kiếm)
- Form_QLMT.cs (Môn thi)
- ThiSinhDA.cs (phần câu hỏi)
- ThiSinhBS.cs (phần câu hỏi)

**Database:** Table_CauHoi, Table_DapAn, Table_MonThi

---

### **BẠNG 3: feature/exam-result**
**Chức năng:**
- Thi trắc nghiệm (random đề)
- Đếm ngược thời gian
- Hiển thị kết quả
- Lưu kết quả
- Xem danh sách kết quả

**Files:**
- Form_THI.cs (Thi)
- Form_KetQua.cs (Kết quả)
- Form_TTDSKQ.cs (Danh sách)
- ThiSinhDA.cs (phần thi)
- ThiSinhBS.cs (phần thi)

**Database:** Table_KetQua

---

### **BẠNG 4: feature/admin-report**
**Chức năng:**
- Đăng nhập giáo viên/admin
- Quản lý nhân viên
- Thêm/Xóa nhân viên
- Phân quyền
- Thống kê, báo cáo
- Xem danh sách

**Files:**
- Form_Dieuhanh.cs (Điều hành)
- Form_QLNV.cs (Quản lý NV)
- Form_XoaNV.cs (Xóa NV)
- Form_TKNV.cs, Form_TKTS.cs (Thống kê)
- Form_TTDSNV.cs, Form_TTDSTS.cs (Danh sách)
- NhanvienDA.cs
- NhanVienBS.cs

**Database:** Table_NhanVien, Table_NguoiDung

---

## 🔄 QUY TRÌNH LÀM VIỆC

### **Giai đoạn 1: Làm việc độc lập (1 tuần)**

Mỗi bạn:
1. Checkout nhánh của mình
2. Làm việc trên nhánh đó
3. Commit thường xuyên
4. Test chức năng của mình

```bash
# Mỗi ngày
git add .
git commit -m "Mô tả công việc hôm nay"
```

### **Giai đoạn 2: Merge lại (1 ngày)**

Một người (leader) thực hiện:

```bash
# 1. Đảm bảo tất cả đã commit
git checkout master

# 2. Merge từng nhánh
git merge feature/student-management
git merge feature/question-management
git merge feature/exam-result
git merge feature/admin-report

# 3. Giải quyết conflicts (nếu có)
# Mở file bị conflict, chọn code đúng

# 4. Commit kết quả merge
git add .
git commit -m "Merge all features"
```

### **Giai đoạn 3: Test tổng thể (1 ngày)**

Cả nhóm cùng:
1. Chạy toàn bộ hệ thống
2. Test từng chức năng
3. Sửa lỗi nếu có
4. Hoàn thiện báo cáo

---

## ⚠️ QUY TẮC QUAN TRỌNG

### ❌ KHÔNG ĐƯỢC:
1. Sửa file của người khác
2. Sửa database schema tùy tiện
3. Merge trước khi hỏi nhóm
4. Commit code lỗi

### ✅ NÊN:
1. Commit thường xuyên
2. Viết commit message rõ ràng
3. Test kỹ trước khi commit
4. Hỏi nhóm khi gặp vấn đề
5. Backup code thường xuyên

---

## 🛠️ LỆNH GIT CƠ BẢN

### Xem nhánh hiện tại:
```bash
git branch
```

### Chuyển nhánh:
```bash
git checkout feature/student-management
```

### Xem thay đổi:
```bash
git status
```

### Lưu thay đổi:
```bash
git add .
git commit -m "Mô tả thay đổi"
```

### Xem lịch sử:
```bash
git log --oneline
```

### Hủy thay đổi chưa commit:
```bash
git checkout -- .
```

### Quay về commit trước:
```bash
git reset --hard HEAD~1
```

---

## 📝 CÁCH TEST ĐỘC LẬP

Mỗi bạn cần sửa `Program.cs` để test phần của mình:

### Bạn 1:
```csharp
Application.Run(new Form_Dangnhap());
```

### Bạn 2:
```csharp
// Tạo form giả lập đăng nhập
Application.Run(new Form_QLCH());
```

### Bạn 3:
```csharp
// Tạo form chọn môn thi
Application.Run(new Form_THI());
```

### Bạn 4:
```csharp
// Tạo form đăng nhập admin
Application.Run(new Form_Dieuhanh());
```

---

## 🎓 VÍ DỤ WORKFLOW

### Ngày 1:
```bash
git checkout feature/student-management
# Code chức năng đăng nhập
git add .
git commit -m "Hoàn thành form đăng nhập"
```

### Ngày 2:
```bash
# Tiếp tục trên nhánh feature/student-management
# Code chức năng đăng ký
git add .
git commit -m "Hoàn thành form đăng ký"
```

### Ngày 3-5:
```bash
# Tiếp tục làm các chức năng còn lại
# Commit sau mỗi chức năng hoàn thành
```

### Ngày 6:
```bash
# Test tổng thể phần của mình
# Sửa lỗi
git add .
git commit -m "Fix bugs và hoàn thiện"
```

### Ngày 7:
```bash
# Cả nhóm họp, merge code
git checkout master
git merge feature/student-management
# ... merge các nhánh khác
```

---

## 📞 HỖ TRỢ

### Gặp lỗi Git:
1. Google lỗi
2. Hỏi trong nhóm
3. Xem lại hướng dẫn này

### Gặp lỗi code:
1. Đọc thông báo lỗi
2. Debug từng bước
3. Hỏi trong nhóm

### Không biết làm gì:
1. Đọc file BRANCH_GUIDE.md
2. Đọc file README_BRANCH_X.md (X là số nhánh của bạn)
3. Hỏi trong nhóm

---

## ✅ CHECKLIST CUỐI CÙNG

Trước khi nộp bài, đảm bảo:

- [ ] Tất cả đã commit code
- [ ] Code chạy được trên từng nhánh
- [ ] Đã merge tất cả vào master
- [ ] Toàn bộ hệ thống chạy được
- [ ] Không có lỗi compile
- [ ] Không có lỗi runtime
- [ ] Database có đủ dữ liệu test
- [ ] Báo cáo đã hoàn thành
- [ ] File SQL đã export
- [ ] Đã nén file theo yêu cầu

---

## 📦 NỘP BÀI

### Mỗi cá nhân nộp:
1. **Báo cáo cá nhân** (PDF) - Phần của mình
2. **Source code** (ZIP) - Nhánh của mình
3. **File SQL** - Phần tables của mình

### Nhóm nộp:
1. **Báo cáo chung** (PDF) - Toàn bộ dự án
2. **Source code hoàn chỉnh** (ZIP) - Nhánh master sau merge
3. **File SQL đầy đủ** - Toàn bộ database
4. **File hướng dẫn cài đặt**

---

**Chúc các bạn thành công! 🎉**

---

## 📚 TÀI LIỆU THAM KHẢO

- BRANCH_GUIDE.md - Hướng dẫn tổng quan
- README_BRANCH_1.md - Hướng dẫn chi tiết nhánh 1
- README_BRANCH_2.md - Hướng dẫn chi tiết nhánh 2 (sẽ tạo)
- README_BRANCH_3.md - Hướng dẫn chi tiết nhánh 3 (sẽ tạo)
- README_BRANCH_4.md - Hướng dẫn chi tiết nhánh 4 (sẽ tạo)

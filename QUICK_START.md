# ⚡ HƯỚNG DẪN NHANH - 4 NHÁNH ĐỘC LẬP

## 🎯 TÓM TẮT

Dự án đã được chia thành 4 nhánh Git, mỗi bạn làm 1 nhánh riêng.

---

## 👥 PHÂN CÔNG

| Bạn | Nhánh | Chức năng chính |
|-----|-------|-----------------|
| **Bạn 1** | `feature/student-management` | Đăng nhập, Đăng ký học sinh |
| **Bạn 2** | `feature/question-management` | Quản lý câu hỏi, Ngân hàng đề |
| **Bạn 3** | `feature/exam-result` | Thi trắc nghiệm, Kết quả |
| **Bạn 4** | `feature/admin-report` | Quản trị, Báo cáo, Thống kê |

---

## 🚀 BẮT ĐẦU NGAY

### **Bạn 1:**
```bash
git checkout feature/student-management
# Đọc file: README_BRANCH_1.md
# Bắt đầu code!
```

### **Bạn 2:**
```bash
git checkout feature/question-management
# Làm việc với Form_QLCH.cs và các form quản lý câu hỏi
```

### **Bạn 3:**
```bash
git checkout feature/exam-result
# Làm việc với Form_THI.cs và Form_KetQua.cs
```

### **Bạn 4:**
```bash
git checkout feature/admin-report
# Làm việc với Form_Dieuhanh.cs và các form quản trị
```

---

## 💾 LƯU THAY ĐỔI

Sau khi code xong một chức năng:
```bash
git add .
git commit -m "Hoàn thành [tên chức năng]"
```

---

## 🔄 MERGE CUỐI CÙNG

Khi tất cả hoàn thành, một người (leader) làm:
```bash
git checkout master
git merge feature/student-management
git merge feature/question-management
git merge feature/exam-result
git merge feature/admin-report
```

---

## 📚 TÀI LIỆU CHI TIẾT

- **HOW_TO_USE_BRANCHES.md** - Hướng dẫn đầy đủ
- **BRANCH_GUIDE.md** - Hướng dẫn chi tiết từng nhánh
- **README_BRANCH_1.md** - Hướng dẫn cụ thể cho Bạn 1

---

## ⚠️ LƯU Ý

1. ✅ Chỉ sửa file trong phần của mình
2. ✅ Commit thường xuyên
3. ✅ Test kỹ trước khi commit
4. ❌ Không sửa file của người khác
5. ❌ Không sửa database schema tùy tiện

---

## 🆘 CẦN GIÚP?

1. Đọc file **HOW_TO_USE_BRANCHES.md**
2. Hỏi trong nhóm
3. Google lỗi nếu gặp

---

**Chúc các bạn làm việc hiệu quả! 💪**

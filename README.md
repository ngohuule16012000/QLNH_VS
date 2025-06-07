# QLNH_VS
Phần mềm ứng dụng cho máy tính quản lý hệ thống nhà hàng

## Mô hình MVC (Model - View - Controller)

### Khái niệm

MVC là một mẫu thiết kế phần mềm (design pattern) giúp tách biệt rõ ràng giữa:
1. Giao diện người dùng (View)
2. Logic nghiệp vụ (Controller)
3. Quản lý dữ liệu (Model)

### Cấu trúc

* **Model**: Lưu trữ, xử lý, xác thực dữ liệu; tương tác với database hoặc DAO (quản lý việc truy xuất dữ liệu từ cơ sở dữ liệu CRUD). VD: `Product`, `User`...
* **View**: Giao diện hiển thị, trình bày dữ liệu từ Model cho người dùng. VD: WinForms
* **Controller**: Nhận tương tác từ View, gọi Model để xử lý và trả kết quả về View.

### Ưu điểm

* Phân tách rõ ràng.
* Dễ mở rộng, dễ test.
* Quản lý dự án lớn hiệu quả.

---

# Demo
![QLNH_VS_demo](https://github.com/ngohuule16012000/QLNH_VS/assets/83895221/2809d63c-5d18-436a-8640-ff1849dad1b4)

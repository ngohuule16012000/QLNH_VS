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

# Restaurant Management System – System Requirements Specification (SRS)

## 1. Giới thiệu
Hệ thống Quản lý Nhà hàng là một ứng dụng giúp quản lý hiệu quả hoạt động nhà hàng như: quản lý đơn hàng, menu, hóa đơn, kho, nhân viên, bàn ăn và doanh thu.

## 2. Mục đích
Tài liệu mô tả chi tiết các yêu cầu chức năng và phi chức năng của hệ thống nhằm đảm bảo cung cấp trải nghiệm tốt cho khách hàng và tối ưu hoạt động quản lý.

## 3. Phạm vi
Bao gồm yêu cầu chức năng, Use Case, các quy trình nghiệp vụ và kịch bản sử dụng trong hoạt động của nhà hàng.

## 4. Quy trình nghiệp vụ chính
- **Khách đến trực tiếp**: lễ tân kiểm tra đặt bàn, phục vụ hướng dẫn chỗ ngồi và nhận gọi món.
- **Đặt bàn trực tuyến**: qua điện thoại, hệ thống kiểm tra lịch và xác nhận.
- **Kiểm tra và nhập nguyên liệu**: quản lý kiểm tra tồn kho, tình trạng nguyên vật liệu, thiết bị.
  
## 5. Use Cases tiêu biểu
| ID   | Tên Use Case             | Tác nhân             | Mô tả                             |
|------|---------------------------|----------------------|-----------------------------------|
| UC01 | Đăng nhập                 | Nhân viên            | Truy cập hệ thống                 |
| UC06 | Xem thực đơn              | Quản lý, lễ tân, KH  | Xem menu món ăn hiện có          |
| UC09 | Thống kê doanh thu        | Quản lý              | Xem báo cáo doanh thu             |
| UC14 | Đặt bàn trước             | Tiếp tân, phục vụ    | Ghi nhận yêu cầu đặt bàn          |
| UC19 | Xem món order             | Đầu bếp              | Theo dõi món cần chế biến         |

## 6. Entity Relationship Diagram (ERD)
- Các thực thể chính: Nhân viên, Thực đơn, Đơn hàng, Món ăn, Bàn ăn, Thanh toán, Doanh thu, Khách hàng...

## 7. Yêu cầu chức năng chính
- Xem thực đơn, đặt bàn/món, tạo và xem hóa đơn.
- Quản lý nhân viên, bàn ăn, doanh thu, lịch đặt bàn, thực đơn.
- Giao diện đơn giản, trực quan, dễ sử dụng, thể hiện rõ món ăn.

## 8. Yêu cầu phi chức năng
- **Hiệu suất**: xử lý đồng thời, nhanh chóng.
- **Khả năng mở rộng**: hỗ trợ chuỗi nhà hàng.
- **Bảo mật**: xác thực và phân quyền.
- **Độ tin cậy**: hoạt động 24/7.
- **Giao diện**: phù hợp thương hiệu, dễ sử dụng.
- **Khả năng di động**: tương thích đa nền tảng.

## 9. Giao diện chính
- Giao diện đăng nhập, màn hình chính, gọi món, bếp, thanh toán, quản lý menu, quản lý doanh thu, đặt bàn, tài khoản...

---

# Restaurant Management – Test Plan

## 1. Giới thiệu
Kế hoạch kiểm thử hệ thống Quản lý Nhà hàng nhằm định hướng và tổ chức các hoạt động kiểm thử phần mềm, đảm bảo hệ thống đáp ứng đúng các yêu cầu chức năng và phi chức năng đã đề ra.

### 1.1 Mục đích
- Xác định phạm vi và yêu cầu kiểm thử.
- Đề xuất chiến lược kiểm thử.
- Xác định môi trường, công cụ và nguồn lực.
- Ước lượng thời gian, công sức thực hiện kiểm thử.

### 1.2 Từ viết tắt (ví dụ)
- UT: Unit Test
- ST: System Test
- TC: Test Case
- TR: Test Report

## 2. Phạm vi kiểm thử
Bao gồm các chức năng:
- Đăng nhập/Đăng xuất
- Đặt bàn / Đặt bàn trước
- Xem thực đơn
- Thanh toán
- Tạo phiếu gọi món
- Quản lý nhân viên, thống kê doanh thu

## 3. Danh sách rủi ro
| Rủi ro | Biện pháp |
|-------|-----------|
| Thiếu kỹ năng test | Đào tạo nâng cao |
| Môi trường lỗi | Kiểm tra sớm |
| Dữ liệu mất mát | Sao lưu định kỳ |
| Thiếu hợp tác | Khuyến khích và hỗ trợ nhóm |

## 4. Yêu cầu kiểm thử
- Tổng cộng ~74 test case cho 9 chức năng chính.
- Tiêu chí chấp nhận phần mềm:
  - Độ bao phủ testcase ≥ 80%
  - Testcase fail ≤ 10%
  - Hệ thống hoạt động ổn định

## 5. Chiến lược kiểm thử
### 5.1 Kiểm thử chức năng
- Mục tiêu: đảm bảo tính đúng đắn của chức năng theo đặc tả.
- Kỹ thuật: dữ liệu hợp lệ và không hợp lệ.

### 5.2 Kiểm thử giao diện
- Đảm bảo tính nhất quán, điều hướng và hiển thị đúng.

### 5.3 Kiểm thử bảo mật
- Kiểm tra phân quyền chức năng theo vai trò người dùng.

### 5.4 Giai đoạn kiểm thử
- Unit Test
- System Test
- User Interface Test
- Security Test

## 6. Nguồn lực & Quản lý
- Tester: Ngô Hữu Lễ, Võ Quang Huy
- Công cụ: Microsoft Excel, Word, Project (Office 365)
- Quản lý kiểm thử: lập kế hoạch, tổ chức, giám sát, đánh giá, báo cáo

## 7. Môi trường kiểm thử
- **Phần cứng**: Core i7, RAM 8GB, SSD 256–512GB
- **Phần mềm**: Windows 10/11, Microsoft Office 365
- **Công cụ**: Excel quản lý testcase, defect, checklist...

## 8. Cột mốc kiểm thử
| Nhiệm vụ | Ngày bắt đầu | Ngày kết thúc |
|----------|--------------|----------------|
| Lập Test Plan | 09/05/2023 | 09/05/2023 |
| Viết testcase | 10/05/2023 | 12/05/2023 |
| Thực thi kiểm thử | 10/05/2023 | 12/05/2023 |
| Báo cáo kết quả | 14/05/2023

---
# Demo
![QLNH_VS_demo](https://github.com/ngohuule16012000/QLNH_VS/assets/83895221/2809d63c-5d18-436a-8640-ff1849dad1b4)

## DEMO Project

![2](https://github.com/lychidung/POS/assets/122819884/ea14059e-7c90-4589-9e4d-da0cbdc0a18a)

![3](https://github.com/lychidung/POS/assets/122819884/3f38a0ba-b1cb-4bdb-9dfe-60c3b52021f9)

![4](https://github.com/lychidung/POS/assets/122819884/e605df6e-91a7-4a0a-9172-47ec7cc2844e)

![5](https://github.com/lychidung/POS/assets/122819884/e2531f17-04fc-464e-80f4-353f889acaad)

![6](https://github.com/lychidung/POS/assets/122819884/03b84766-6044-4c03-9cfc-44c2b5843381)

![7](https://github.com/lychidung/POS/assets/122819884/ec64e0c8-488f-4b16-90ca-220dd499592b)

![8](https://github.com/lychidung/POS/assets/122819884/c1698fac-6ea4-4e68-9038-fa6c20bff80b)

![9](https://github.com/lychidung/POS/assets/122819884/f9639dec-e8b8-4f82-854a-aa96404720a7)


Hãy cài SQLServer nếu bạn chưa có !!
Hãy cài MayPOS trong Folder được phép chỉnh sửa các tệp !!
Hãy cài MayPOS trong Folder được phép chỉnh sửa các tệp !!
Hãy cài MayPOS trong Folder được phép chỉnh sửa các tệp !!

Trước khi vào ứng dụng vui lòng thực hiện các bước sau:

# Tạo Database trong SQLServer
1. Tạo Database (để trống sau khi tạo)
2. Vào Folder có tên là Data (Folder nằm ở địa chỉ bạn cài đặt MayPOS)
3. Trong Folder Data có tệp Data.sql 
Vui lòng truy vấn tệp này đến Database của bạn vừa tạo !!

---------------------------------------------------------------------------------------

# Kết nối SQLServer 
1. Vào MayPOS.exe.config
2. Sửa kết nối tại địa chỉ này
connectionString="Data Source=localhost;Initial Catalog=MayPOS;Integrated Security=True" providerName="System.Data.SqlClient"

Note:
- Data Source = địa chỉ kết nối đến Server Name của bạn
- Catalog = tên Database cần kết nối của bạn

---------------------------------------------------------------------------------------
Sau khi thực hiện các bước trên, hãy mở tệp MayPOS.exe để sử dụng

Chúc bạn cài đặt thành công !!

Chú ý:
Tài khoản đăng nhập
- Quyền quản trị:

Username: lychidung
Password: 2005

- Quyền Staff:

Username: nguyendientriminh
Password: 2005

Username: tranthanhphat
Password: 2005

-------------------------
# Folder kiểm kê:
- BillLog: Lưu trữ Bill thống kê
- InvoiceLog: Lưu trữ các hóa đơn được xuất cho khách hàng

# Folder ảnh:
- avatar: Ảnh của các tài khoản Staff & Admin
- icon: Các icon có trong ứng dụng
- icon-theloai-mon: Các icon của danh mục món trong chức năng Order
- images: Ảnh thực đơn


# Liên hệ (3 người viết app):

https://www.facebook.com/chidung.ly.73/

https://www.facebook.com/nguyen.triminh.9889

https://www.facebook.com/trthphat


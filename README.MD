## DEMO Project
![image-003](https://github.com/lychidung/POS/assets/122819884/70b96249-fe9e-4ba5-8372-ae7711237529)
![image-005](https://github.com/lychidung/POS/assets/122819884/f911e169-f04c-474b-a59d-8e8c47189850)
![image-006](https://github.com/lychidung/POS/assets/122819884/9d15afd6-320e-4e9e-b12c-a08c087f1661)
![image-007](https://github.com/lychidung/POS/assets/122819884/530c06ab-dbdc-4378-b07a-cf364b0e6b46)
![image-008](https://github.com/lychidung/POS/assets/122819884/616a6cc7-0f5f-4594-b835-fcfdefd12503)
![image-009](https://github.com/lychidung/POS/assets/122819884/6cdeb3db-be33-472d-87be-fbe00bdaf9c7)
![image-010](https://github.com/lychidung/POS/assets/122819884/096f06ab-6114-4543-b754-81a12a215706)

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


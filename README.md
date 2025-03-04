<h2 align="center">QuanLyDoCongNghe</h2>
Besnik – Tech store là cửa hàng chuyên bán các sản phẩm về công nghệ, đồ gia dụng thông minh như máy lọc không khí, robot hút bụi lau nhà, ghế công thái học, kính thực tế ảo…   Hệ thống thông tin quản lý bán hàng của cửa hàng được mô tả như sau:
</br>- Khi khách hàng mua hàng, họ sẽ tìm kiếm thông tin sản phẩm trên trang điện tử của cửa hàng. Thông tin sản phẩm bao gồm: Mã sản phẩm, tên sản phẩm, mã loại hàng, đơn giá, hình ảnh sản phẩm, số lượng tồn và mô tả sản phẩm.
</br>- Nhân viên sẽ xác nhận đơn mua từ khách hàng nếu trong kho còn hàng, sau đó sẽ cập nhật thông tin đơn mua hàng của khách hàng, mỗi đơn mua bao gồm: Mã đơn mua, mã nhân viên đã tiếp nhận đơn, số lượng sản phẩm và ngày mua… Và mỗi đơn mua sẽ có nhiều sản phẩm khác nhau. Nhân viên lên hóa đơn và gửi cho khách hàng.
</br>- Đồng thời khi khách hàng mua hàng, các thông tin về khách hàng sẽ được lưu lại: mã khách hàng, họ và tên, số điện thoại để liên hệ và địa chỉ nhận hàng. Mỗi khách hàng có thể mua cùng lúc nhiều sản phẩm khác nhau, và cũng có nhiều hóa đơn qua nhiều ngày mua.
</br>- Khi sản phẩm được nhập về từ nhà cung cấp, nhân viên sẽ chịu trách nhiệm kiểm tra và thanh toán tiền cho nhà cung cấp. Quản lý sẽ viết phiếu chi – số tiền tạm ứng - giao cho nhân viên để thanh toán các hóa đơn với nhà cung cấp. Sau đó, viết phiếu nhập kho và tiến hành nhập các sản phẩm mới.
</br>- Các thông tin của nhà cung cấp và hóa đơn thanh toán với nhà cung cấp được lưu lại để tiến hành báo cáo doanh thu của cửa hàng, công nợ với nhà cung cấp và số tiền đã chi.
</br>- Khi sản phẩm xuất kho, nhân viên thủ kho có nhiệm vụ viết phiếu xuất kho, tiện cho việc thống kê số lượng hàng tồn và viết báo cáo.
</br>- Sau mỗi ngày kết ca, nhân viên có nhiệm vụ thực hiện thống kê sản phẩm trên hệ thống số lượng sản phẩm bán ra trong ngày, tổng tiền bán được trong ngày để làm báo cáo.
- Thống kê số lượng hàng tồn, doanh thu theo tháng, năm, tổng sản phẩm bán được trong tháng, trong năm và số lượng khách hàng
## Thời gian thực hiện

Hoàn thành: 
</br>⚡ Thời gian thực hiện **01/10/2023 -26/12/2023**

## Thành viên

- Nguyễn Trần Anh Tân
- Trần Xuân Thao
- Huỳnh Phạm Quỳnh Như
  
## Ngôn ngữ lập trình, công nghệ sử dụng

- Ngôn ngữ lập trình: C#
- Công nghệ sử dụng: Visual Studio 2022, SQL Server, Winform 
  
## Đóng góp

Nguyễn Trần Anh Tân: </br>
- Chức năng form quản lý sản phẩm, nhà cung cấp, kho hàng, nhân viên
- Chức năng đăng nhập, đăng kí, thống kê, trang chủ, phân quyền
- Thiết kế CSDL
- Back-End
  
Trần Xuân Thao: </br>
- Chức năng bán hàng, tạo đơn hàng, thanh toán
- Chức năng form tạo đơn
- Thiết kế CSDL
- Back-End
  
Huỳnh Phạm Quỳnh Như: </br>
- Phân tích nghiệp vụ, báo cáo 
- Thiết kế giao diện, CSDL
- Front-End

## Phân tích
- Biểu đồ phân rã chức năng (BFD - Business Function Diagram)
 ![image](https://github.com/user-attachments/assets/fedd05a8-5a35-4bb5-83de-686eeaf784a4)
- Biểu đồ luồng dữ liệu
  + Mức ngữ cảnh
    ![Picture3](https://github.com/user-attachments/assets/b35b395e-4e2d-4d98-bfed-62243dcab11e)

  + Mức đỉnh
    ![Picture2](https://github.com/user-attachments/assets/5fd3fe21-fa36-4f07-9514-5c14c12eecd0)

  + Mức dưới đỉnh
    
    a. Quản lý kho hàng
    ![image](https://github.com/user-attachments/assets/4335c87e-da4b-485f-a260-ad845ea40af3)

    b. Quản lý bán hàng
    ![image](https://github.com/user-attachments/assets/75dd596c-4736-4cc8-8b1c-463df392f178)

    c. Quản lý nhân viên
    ![image](https://github.com/user-attachments/assets/58dd3386-b865-4d37-8056-2b6ebafc84a7)

    d. Thống kê
    ![image](https://github.com/user-attachments/assets/d2ef6fb8-8e23-47be-aa48-fb09ad36c279)


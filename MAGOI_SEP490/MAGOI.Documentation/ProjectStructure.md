***
#PROJECT STRUCTURE
	
	Đây là phần BE của dự án, nằm trong 1 solution, trong đó có 8 projects bên trong:
	1. BusinessObjects
		* Là nơi chứa Models tương ứng với các thực thể trong cơ sở dữ liệu.
	2. Common
		* Ultilities: là folder chứa các tiện ích, hàm,... được tổng hợp lại trong dự án. (VD như những method validate định dạng của số điện thoại hoặc email)
		* DTOs
	3. DataAccess
		* DAO
		* Repository
		* IRepository
	4. Infrastructure
		* Configurations
		* Exception handlers
		* Constant/Enum
	5. Middleware
		* Chứa các middleware dùng để xử lý, xác thực quyền các request.
	6. UnitTest
		* Dùng xUnit để kiểm thử đơn vị(Unit test).
	7. API
		* Dự án chính để phát triển API.
		* Chứa các controller và logic xử lý của từng chức năng cụ thể.
	8. Documentation
		* Chứa các tài liệu về hoặc liên quan đến phần BE và ứng dụng như: mô tả về API; ghi chú về thay đổi, các phiên bản;...
***
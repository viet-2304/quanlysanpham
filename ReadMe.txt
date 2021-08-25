- Đề thi cuối học kì 4 (Quản lý sản phẩm C#)-

database have 3 table:
	- Địa chỉ: Mã tỉnh (khóa chính) , Tên tỉnh 
	- Nhà Cung Cấp: Mã nhà cung cấp(khóa chính), Tên nhà cung cấp, Mã Tỉnh ( khóa phụ)
	- Sản phẩm: Mã sản phẩm(khóa chính), tên sản phẩm, giá sản phẩm, Ngày nhập, Số lượng sản phẩm, Mã nhà cung cấp(khóa phụ)

-> Using code first entity framework C# and three layer
-> Have 6 function (add, edit, update, delete, sort and show)

error:
- relationship between "Tỉnh" and "nhà cung cấp" is 1->* ( 1 "tỉnh" have many "nhà cung cấp")
- When chosse data in combobox "tỉnh" data in combobox "nhà cung cấp" set value but must be reset by user ( can't automatic reset) => press button show will
have a exception "null" 

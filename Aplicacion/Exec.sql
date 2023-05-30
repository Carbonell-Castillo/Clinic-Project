/*Clinics*/
exec addClinic
@id = '323',
@name = 'Clinica 1',
@location= 'Ciudad de guatemala',
@sector= 'Salud';

exec viewClinics;

exec viewClinicById
@id= '323';

/*Role*/
exec addRole
@id =1,
@name= 'Administrador';

exec addRole
@id =2,
@name= 'Doctor';

exec viewRoles;

/*Users*/

exec addUser
@userId= '5678',
@clinicId='323',
@roleId= 1,
@username= 'Juarez87',
@name= 'Daniel Juarez',
@password='Daniel12';

exec addUser
@userId= '9827',
@clinicId='323',
@roleId= 2,
@username= 'Brucecastl',
@name= 'Bruce Castillo',
@password='castillo23';

exec viewUsers;

delete from users where userId='5678';

exec validateUser
@username= 'Juarez87',
@password= 'Daniel12';

/*Patient*/

/*Category*/
exec addCategory
@id='1',
@name= 'Medicina';

exec addCategory
@id='2',
@name= 'Medias';

exec viewCategories;

/*Inventory*/
exec addInventory
@id = '001',
@clinicId= '323',
@categoryId='1',
@name= 'Sukrol',
@quantity= 3,
@price= 87.50;

exec viewInventory;

exec viewInventoryByClinic
	@clinicId='323';

exec viewInventoryByCategory
	@clinicId='323',
	@categoryId='1';

exec searchInventoryById
	@id= '001';


use joinExDb
select * from Employee
select convert(nvarchar(50), Id)+'->'+Fname as 'ID->Fname' from Employee
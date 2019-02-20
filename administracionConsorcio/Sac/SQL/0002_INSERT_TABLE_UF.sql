USE [SAR]
GO
begin tran
INSERT INTO [dbo].[UF]
           ([dpto]
		   ,[coef]
           ,[descrip])
     VALUES
           ('1'  ,0.0603,'Dpto'),('1C' ,0.0023,'Cochera'),('2'  ,0.0645,'Dpto'),('3' ,0.0645 ,'Dpto'),('4' ,0.0631 ,'Dpto'),('5' ,0.0970 ,'Dpto'),('5B' ,0.0023,'Cochera')
GO
--commit
select * from uf


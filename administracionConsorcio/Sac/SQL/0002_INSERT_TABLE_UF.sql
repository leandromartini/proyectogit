USE [SAR]
GO
begin tran
INSERT INTO [dbo].[UF]
           ([dpto]
           ,[descrip])
     VALUES
           ('1'  ,'Dpto'),('1C' ,'Cochera'),('2'  ,'Dpto'),('3'  ,'Dpto'),('4'  ,'Dpto'),('5'  ,'Dpto'),('5B' ,'Cochera')
GO
--commit
select * from uf


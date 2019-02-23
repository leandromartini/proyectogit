USE [SAR]
GO
begin tran
INSERT INTO [dbo].[UF]
           ([dpto]
		   ,[coef]
           ,[descrip])
     VALUES
           ('1'  ,0.0603,'Dpto'),('1C' ,0.0023,'Cochera'),('2'  ,0.0645,'Dpto'),('3' ,0.0631 ,'Dpto'),('4' ,0.0629 ,'Dpto')
		   ,('5' ,0.0970 ,'Dpto'),('5B' ,0.0023,'Cochera'),
		   ('6' ,0.0868,'Dpto'),('6A' ,0.0023,'Cochera'),('7' ,0.0583,'Dpto'),('8' ,0.0589,'Dpto')
		   ,('9' ,0.0643 ,'Dpto'),('10' ,0.0645,'Cochera'),('10D' ,0.0023,'Cochera'),('11' ,0.0597 ,'Dpto'),('12' ,0.0667,'Cochera'),('13' ,0.0583 ,'Dpto'),('13E' ,0.0023,'Cochera')
		   ,('14' ,0.0589 ,'Dpto'),('15' ,0.0643,'Cochera')
GO
--commit rollback
select * from uf


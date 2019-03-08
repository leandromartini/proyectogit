USE [SAR]
GO
begin tran
INSERT INTO [dbo].[UF]
           ([dpto]
		   ,[coef]
           ,[descrip])
     VALUES
           ('1'  ,0.0603,'Dpto 1°'),('1C' ,0.0023,'Cochera 1° C'),('2'  ,0.0645,'Dpto 2°'),('3' ,0.0631 ,'Dpto 3°'),('4' ,0.0629 ,'Dpto 4°')
		   ,('5' ,0.0970 ,'Dpto 5°'),('5B' ,0.0023,'Cochera 5° B'),
		   ('6' ,0.0868,'Dpto 6°'),('6A' ,0.0023,'Cochera 6° A'),('7' ,0.0583,'Dpto 7°'),('8' ,0.0589,'Dpto 8°')
		   ,('9' ,0.0643 ,'Dpto 9°'),('10' ,0.0645,'Dpto 10°'),('10D' ,0.0023,'Cochera 10° D'),('11' ,0.0597 ,'Dpto 11°'),('12' ,0.0667,'Dpto 12°'),('13' ,0.0583 ,'Dpto 13°'),('13E' ,0.0023,'Cochera 13° E')
		   ,('14' ,0.0589 ,'Dpto 14°'),('15' ,0.0643,'Dpto 15°')
GO
--commit rollback
select * from uf




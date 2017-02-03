create database [CMTest] on primary
(name = [CMTest], filename='C:\Users\mazhe\Desktop\continuousMigrationTesting\ContinuousDeploymentMigrationTesting\ContinuousMigration\ContinuousMigration\App_Data\CMTest.mdf')
log on(name = [CMTest_log], filename='C:\Users\mazhe\Desktop\continuousMigrationTesting\ContinuousDeploymentMigrationTesting\ContinuousMigration\ContinuousMigration\App_Data\CMTest_log.ldf')

create table [dbo].[Students]
(
	id int not null identity(1,1),
	name nvarchar(50) not null,
	constraint [pk_dbo.Student] primary key clustered([id]asc)
)

insert into [dbo].[Students](name)values('adam');
insert into [dbo].[Students](name)values('zhendong');
drop table [dbo].[Students] if exists
-- creating database
CREATE DATABASE DB_API;

-- using the created database
USE[DB_API];

-- creting table issues
Create table issues(
	id int identity(1,1) primary key not null,
	title varchar(100) not null,
	description varchar(350) not null,
	status varchar(50) not null,
	createdAt datetime not null default current_timestamp,
);

-- insert statement 
Insert into issues (title, description, status) values ('Login button not responding', 'Tapping the login button does nothing on Android devices.', 'open');
Insert into issues (title, description, status) values ('Profile image not loading','App crashes immediately after splash screen on iOS 17','in-progress');

-- view records
Select * from issues;
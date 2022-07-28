use db_try
go

CREATE TABLE StudentsInfo
(
	[StudentID] INT NOT NULL IDENTITY (1,1),
	[Firstname] NVARCHAR(500) NOT NULL,
	[Middlename] NVARCHAR(500) NULL,
	[LastName] NVARCHAR (500) NOT NULL,
	[Birthdate] DATE NOT NULL,
	[CreatedDate] DATETIME NOT NULL default getdate(),
	CONSTRAINT PK_InfoStudents PRIMARY KEY CLUSTERED (StudentID),
)
go

INSERT INTO StudentsInfo(Firstname, Middlename, Lastname, Birthdate)
VALUES
('Sage','H','Maya','1999-12-24');

select * from StudentsInfo
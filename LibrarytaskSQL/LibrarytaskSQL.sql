CREATE DATABASE LibraryDB
USE LibraryDB
CREATE TABLE Authors
(
 Id INT PRIMARY KEY IDENTITY,
 Name NVARCHAR(20) NOT NULL,
 Surname NVARCHAR(20) NOT NULL
)
CREATE TABLE Books
(
 Id INT PRIMARY KEY IDENTITY,
 AuthorId INT REFERENCES Authors(id),
 Name NVARCHAR(100) NOT NULL Check(len(Name) BETWEEN 2 AND 100),
 PageCount INT NOT NULL CHECK(PageCount > 2)
)
INSERT INTO Authors (Name, Surname) VALUES ('Orhan', 'Pamuk');
INSERT INTO Authors (Name, Surname) VALUES ('Fyodor', 'Dostoyevsky');
INSERT INTO Authors (Name, Surname) VALUES ('George', 'Orwell');
INSERT INTO Authors (Name, Surname) VALUES ('Jane', 'Austen');
INSERT INTO Authors (Name, Surname) VALUES ('Haruki', 'Murakami');

INSERT INTO Books (AuthorId, Name, PageCount) VALUES (1, 'My Name is Red', 400);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (1, 'Snow', 426);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (2, 'Crime and Punishment', 430);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (2, 'The Brothers Karamazov', 824);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (3, '1984', 328);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (3, 'Animal Farm', 112);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (4, 'Pride and Prejudice', 279);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (4, 'Sense and Sensibility', 226);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (5, 'Norwegian Wood', 296);
INSERT INTO Books (AuthorId, Name, PageCount) VALUES (5, 'Kafka on the Shore', 505);





CREATE VIEW LibraryInfoVW
AS
SELECT 
	Books.Id,
	Books.Name,
	Books.PageCount,
	Authors.Name + ' ' + Authors.Surname AS AuthorFullName 
FROM 
	Books
INNER JOIN
	Authors ON Authors.Id = Books.AuthorId

SELECT * FROM LibraryInfoVW

CREATE PROCEDURE GetLibraryByName (@Name NVARCHAR(100))
AS
BEGIN
SELECT 
	Books.Id,
	Books.Name,
	Books.PageCount,
	Authors.Name + ' ' + Authors.Surname AS AuthorFullName 
FROM 
	Books
INNER JOIN
	Authors ON Authors.Id = Books.AuthorId
WHERE Books.Name LIKE '%' + @Name + '%' 
	  OR Authors.Name LIKE '%' + @Name + '%'
END

EXEC GetLibraryByName @Name = 'Crime and Punishment'
EXEC GetLibraryByName @Name = 'Crime'


CREATE FUNCTION GetBooksByPage (@MinPageCount INT = 10)
RETURNS INT
AS
BEGIN
	DECLARE @BookCount INT
	SELECT
		@BookCount = COUNT(*)
	FROM Books
	WHERE PageCount > @MinPageCount	
	RETURN @BookCount
END
SELECT dbo.GetBooksByPage(250)






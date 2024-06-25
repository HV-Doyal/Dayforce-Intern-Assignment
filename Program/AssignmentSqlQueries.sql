select
    'data source=' + @@servername +
    ';initial catalog=' + db_name() +
    case type_desc
        when 'WINDOWS_LOGIN' 
            then ';trusted_connection=true'
        else
            ';user id=' + suser_name() + ';password=<<YourPassword>>'
    end
    as ConnectionString
from sys.server_principals
where name = suser_name()



CREATE TABLE Course(
	Course VARCHAR(50) Primary Key,
	MinNumberOfPoints INT NOT NULL,
	NumberOfSeats INT NOT NULL,
	FulltimeCost INT NOT NULL,
	ParttimeCost INT NOT NUll,
	Prerequisites VARCHAR(MAX) NOT NULL,
	NumberOfAvailableSeats INT NOT NULL
);

CREATE TABLE Student(
	StudentId INT IDENTITY(1,1) PRIMARY KEY,
	FirstName VARCHAR(20) NOT NULL,
	LastName VARCHAR(20) NOT NULL,
	Email VARCHAR(40) NOT NULL,
	Address VARCHAR(75) NOT NULL,
	ContactNumber INT NOT NULL,
	Course VARCHAR(50) FOREIGN KEY REFERENCES Course(Course),
	CalculatedFees INT NOT NULL
);

--DROP TABLE Course
--DROP TABLE Student

INSERT INTO Course (Course, MinNumberOfPoints, NumberOfSeats, FulltimeCost, ParttimeCost, Prerequisites, NumberOfAvailableSeats)
Values ('BSc Computer Science', 40, 10, 25000, 30000, 'Computer Science', 10),
	   ('BSc Accounting', 35, 20, 25000, 30000, 'Maths, Accounts', 35),
	   ('BSc Software Engineering', 38, 25, 25000, 30000, 'Computer Science, Maths', 38),
	   ('BSc Law', 40, 5, 25000, 30000, 'English, French', 40),
	   ('BSc Mechanical Engineering', 36, 15, 25000, 30000, 'Maths, Physics', 36)
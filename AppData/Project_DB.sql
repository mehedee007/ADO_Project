Create TABLE Trainees
(
TraineeID INT PRIMARY KEY IDENTITY (127500, 1),
TraineeName NVARCHAR (50) NOT NULL,
DOB VARCHAR (MAX),
Gender NVARCHAR (20) SPARSE NULL,
TraineeContact VARCHAR (15) CHECK (TraineeContact LIKE '01%'),
Email VARCHAR (40) CHECK (Email LIKE '%@gmail.com' OR Email LIKE '%@yahoo.com' OR Email LIKE '@outlook.com'),
SelectedCourse NVARCHAR (30),
CourseID INT FOREIGN KEY REFERENCES CourseDetails(CourseID),
TraineeImage VARCHAR (MAX) SPARSE NULL,
TraineeStatus NVARCHAR (30) DEFAULT 'Active'
--RemainingSeats INT
);
GO

--Store Procedure
DROP PROC sp_TraineeSaveCourseUpdate
GO
CREATE PROC sp_TraineeSaveCourseUpdate
@traineeName NVARCHAR (50),
@dob VARCHAR (MAX),
@gender NVARCHAR(20),
@traineeContact VARCHAR (15),
@email VARCHAR (40),
@selectedCourse NVARCHAR (30),
@courseId INT,
@traineeImage VARCHAR (MAX)
AS
BEGIN
INSERT INTO Trainees(TraineeName,DOB, Gender,TraineeContact,Email,SelectedCourse,CourseID, TraineeImage) VALUES (@traineeName,@dob,@gender,@traineeContact,@email,@selectedCourse, @courseId, @traineeImage)
UPDATE CourseDetails SET SeatAvailability = SeatAvailability - 1
WHERE CourseID =@courseId
END
GO

EXEC sp_TraineeSaveCourseUpdate @traineeName, @dob, gender, trainneContact, email, selectedCourse, courseId, traineeImage

ALTER TABLE Trainees
DROP COLUMN RemainingSeats

DROP TABLE Trainees
DROP TABLE EnrollmentInfo

INSERT INTO Trainees (TraineeName, Gender, TraineeContact, Email) VALUES ('A', 'Male', '01718766666','a@yahoo.com' )
GO

SELECT * FROM Trainees
GO

CREATE TABLE TSPs
(
TSPID INT PRIMARY KEY IDENTITY (101, 1),
TSPName NVARCHAR (MAX),
TSPLocation NVARCHAR (200),
Manager NVARCHAR (50) SPARSE NULL,
ContactNumber VARCHAR (15) ,
Email VARCHAR (30)
);
GO

Create TABLE CourseDetails
(
CourseID INT PRIMARY KEY IDENTITY,
CourseName NVARCHAR (40) NOT NULL,
Duration NVARCHAR (30),
--TotalSeats INT NOT NULL,
SeatAvailability Int,
AssignedTSP NVARCHAR (MAX),
TSPID INT FOREIGN KEY REFERENCES TSPs(TSPID)
);
GO

ALTER TABLE CourseDetails
DROP COLUMN TotalSeats

CREATE TABLE TrainerList
(
TrainerID INT PRIMARY KEY IDENTITY (201, 1),
TrainerName NVARCHAR (50) NOT NULL,
TrainerContact VARCHAR (15),
TrainerEmail VARCHAR (60),
TSPName NVARCHAR (MAX),
TSPID INT FOREIGN KEY REFERENCES TSPs(TSPID),
AssignedCourse NVARCHAR (MAX) SPARSE NULL
);
GO

Create TABLE EnrollmentInfo
(
AdmissionSerial INT IDENTITY (20211,1) PRIMARY KEY,
CourseID INT FOREIGN KEY REFERENCES CourseDetails (CourseID) ,
TSPID INT FOREIGN KEY REFERENCES TSPs (TSPID),
TraineeID  INT UNIQUE FOREIGN KEY REFERENCES Trainees (TraineeID) ON UPDATE CASCADE ,
StartDate DATETIME DEFAULT SYSDATETIME ()
);
GO






--Experiment


SELECT * FROM TSPs
GO
SELECT * FROM Trainees
GO

SELECT * FROM TrainerList
GO

SELECT * FROM CourseDetails
GO

DROP TABLE CourseDetails

SELECT * FROM EnrollmentInfo
GO


DROP TABLE TrainerList
DROP TABLE EnrollmentInfo

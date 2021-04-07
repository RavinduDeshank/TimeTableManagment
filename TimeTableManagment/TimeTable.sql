CREATE TABLE "RoomAllocation" (
	"id"	INTEGER,
	"RoomName"	TEXT,
	"Subject"	TEXT,
	"Tag"	TEXT,
	"Lecturer"	TEXT,
	"GroupID"	TEXT,
	"SubGroup"	TEXT,
	"sessionID"	INTEGER,
	PRIMARY KEY("id")
)Å
CREATE TABLE "RoomAvailability" (
	"id"	INTEGER,
	"RoomName"	TEXT,
	"StartTime"	TEXT,
	"EndTime"	TEXT,
	PRIMARY KEY("id" )
)
CREATE TABLE "Overlap" (
	"OverlapID"	INTEGER NOT NULL UNIQUE,
	"Sessions"	TEXT,
	PRIMARY KEY("OverlapID" )
)
CREATE TABLE "Parallel" (
	"ParallelID"	INTEGER NOT NULL UNIQUE,
	"Sessions"	TEXT,
	PRIMARY KEY("ParallelID" )
)
CREATE TABLE "Availability" (
	"AvailabilityID"	INTEGER NOT NULL UNIQUE,
	"Type"	TEXT,
	"Name"	TEXT,
	"Day"	TEXT,
	"Froms"	TEXT,
	"Tos"	TEXT,
	PRIMARY KEY("AvailabilityID" )
)
CREATE TABLE "Consecative" (
	"ConsecativeID"	INTEGER NOT NULL UNIQUE,
	"Session1"	TEXT,
	"Session2"	TEXT,
	PRIMARY KEY("ConsecativeID" )
)
CREATE TABLE "Session" (
	"SessionID"	INTEGER NOT NULL UNIQUE,
	"Lecturer"	TEXT,
	"Subject"	TEXT,
	"SubjectCode"	TEXT,
	"Tag"	TEXT,
	"GroupID"	TEXT,
	"SubGID"	TEXT,
	"StudentCount"	TEXT,
	"Duration"	TEXT,
	"Description"	TEXT,
	PRIMARY KEY("SessionID" )
)
CREATE TABLE "Days" (
	"id"	INTEGER NOT NULL UNIQUE,
	"WorkingDays"	TEXT,
	"NoOfWorkingDays"	INTEGER,
	"NoOfWorkingHours"	NUMERIC,
	PRIMARY KEY("id" )
)
CREATE TABLE "Lecturer" (
	"No"	INTEGER NOT NULL UNIQUE,
	"EmployeeID"	TEXT NOT NULL,
	"Title"	TEXT,
	"Name"	TEXT,
	"Faculty"	TEXT,
	"Dept"	TEXT,
	"Building"	TEXT,
	"Center"	TEXT,
	"Rank"	TEXT,
	"Role"	TEXT,
	PRIMARY KEY("No" )
)

CREATE TABLE "Tag" (
	"TagID"	INTEGER NOT NULL UNIQUE,
	"TagName"	TEXT,
	PRIMARY KEY("TagID" )
)Å
CREATE TABLE "Rooms" (
	"id"	INTEGER,
	"RoomName"	TEXT,
	"RoomType"	TEXT,
	"RoomCapacity"	INTEGER,
	"BuildingName"	TEXT,
	PRIMARY KEY("id" ),
	FOREIGN KEY("BuildingName") REFERENCES "Location"("BuildingName")
)
CREATE TABLE "Hours" (
	"id"	INTEGER NOT NULL UNIQUE,
	"startTime"	TEXT,
	"endTime"	TEXT,
	PRIMARY KEY("id" )
)
CREATE TABLE "Student" (
	"StudentID"	INTEGER NOT NULL UNIQUE,
	"YearSem"	TEXT,
	"Programme"	TEXT,
	"Groups"	TEXT,
	"SubGroups"	TEXT,
	"GroupID"	TEXT,
	"SubGroupID"	TEXT,
	PRIMARY KEY("StudentID" )
)
CREATE TABLE "Subject" (
	"Code"	TEXT NOT NULL UNIQUE,
	"Subject"	TEXT,
	"Year"	TEXT,
	"Sem"	TEXT,
	"Lec"	INTEGER,
	"Lab"	INTEGER,
	"Tute"	INTEGER,
	"Evaluation"	INTEGER,
	PRIMARY KEY("Code")
)
CREATE TABLE "Location" (
	"BuildingID"	INTEGER NOT NULL UNIQUE,
	"BuildingName"	TEXT,
	PRIMARY KEY("BuildingID" )
)
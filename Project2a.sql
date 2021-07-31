/***********************************************
 * Name:       Karthik Umashankar
 * Class:      CIS-2510
 * Assignment: Project 2
 * File:       CreateBookings.sql
 * Purpose:    Create a dataset of upcoming bookings.
 **********************************************/
 
IF EXISTS (
	SELECT 1 
	  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' 
       AND TABLE_NAME='mod40Artist'
   ) 
   DROP TABLE mod40Artist
GO
IF EXISTS (
	SELECT 1 
	  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' 
       AND TABLE_NAME='mod40Bookings'
   ) 
   DROP TABLE mod40Bookings
GO

 IF EXISTS (
	SELECT 1 
	  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' 
       AND TABLE_NAME='mod40Genres'
   ) 
   DROP TABLE mod40Genres
GO

IF EXISTS (
	SELECT 1 
	  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' 
       AND TABLE_NAME='mod40Instruments'
   ) 
   DROP TABLE mod40Instruments
GO

IF EXISTS (
	SELECT 1 
	  FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE' 
       AND TABLE_NAME='mod40Venues'
   ) 
   DROP TABLE mod40Venues
GO

------------------------------------------CREATE GENRES LOOKUP TABLE----------------------------------------------


CREATE TABLE mod40Genres
(
    GenreCode VARCHAR(2) NOT NULL,
	GenreName VARCHAR(20) NOT NULL,
);

ALTER TABLE mod40Genres
	ADD CONSTRAINT pk_mod40Genres
	PRIMARY KEY (GenreCode);

ALTER TABLE mod40Genres
	ADD CONSTRAINT uc1_mod40Genres
	UNIQUE (GenreName);

	------------------------------
-- Genre Code must:
--    o) Contain only letters. 
--    o) Be exactly 2 letters.
--
ALTER TABLE mod40Genres
	ADD CONSTRAINT ck_mod40Genres_GenreCode
	CHECK
	(
		LEN(GenreCode) = 2
		AND(GenreCode NOT LIKE '%[^A-Z]%')
	);
	------------------------------
-- Genre Name must:
--    o) Contain only letters. 
--    o) Be longer than 2 letters.
--
ALTER TABLE mod40Genres
	ADD CONSTRAINT ck_mod40Genres_GenreName
	CHECK
	(
		LEN(GenreName) >= 2 
		AND(GenreName NOT LIKE '%[0-9]%')
	);



------------------------------------------CREATE INSTRUMENTS LOOKUP TABLE----------------------------------------------


CREATE TABLE mod40Instruments
(
    InstrumentCode VARCHAR(3) NOT NULL,
	InstrumentName VARCHAR(20) NOT NULL,
);

ALTER TABLE mod40Instruments
	ADD CONSTRAINT pk_mod40Instruments
	PRIMARY KEY (InstrumentCode);

ALTER TABLE mod40Instruments
	ADD CONSTRAINT uc1_mod40Instruments
	UNIQUE (InstrumentName);


	------------------------------
-- Instrument Code must:
--    o) Contain only letters. 
--    o) Be atleast 2 letters.
--
ALTER TABLE mod40Instruments
	ADD CONSTRAINT ck_mod40Instruments_InstrumentCode
	CHECK
	(
		LEN(InstrumentCode) >= 2
		AND(InstrumentCode NOT LIKE '%[^A-Z]%')
	);
	------------------------------
-- Instrument Name must: 
--    o) Be longer than 2 letters.
--
ALTER TABLE mod40Instruments
	ADD CONSTRAINT ck_mod40Instruments_InstrumentName
	CHECK
	(
		LEN(InstrumentName) >= 2 
	);


------------------------------------------CREATE VENUES LOOKUP TABLE----------------------------------------------



CREATE TABLE mod40Venues
(
    VenueCode VARCHAR(3) NOT NULL,
	VenueName VARCHAR(30) NOT NULL,
	VenueCity VARCHAR(30) NOT NULL,
	VenueCountry VARCHAR(30) NOT NULL,
	Capacity INT NOT NULL,
);

ALTER TABLE mod40Venues
	ADD CONSTRAINT pk_mod40Venues
	PRIMARY KEY (VenueCode);

ALTER TABLE mod40Venues
	ADD CONSTRAINT uc2_mod40Venues
	UNIQUE (VenueName);

	------------------------------
-- Venue Code must:
--    o) Contain only letters. 
--    o) Be atleast 2 letters, but not greater than 3.
--
ALTER TABLE mod40Venues
	ADD CONSTRAINT ck_mod40Venues_VenueCode
	CHECK
	(
		LEN(VenueCode) >= 2
		AND(VenueCode NOT LIKE '%[^A-Z]%')
	);

	------------------------------
-- Capacity must:
--    o) Be a positive integer.
--
ALTER TABLE mod40Venues
	ADD CONSTRAINT ck_mod40Venues_Capacity
	CHECK
	(
		Capacity > 0
	);
	
------------------------------
-- VenueCity must:
--    o) Contain only letters. 
--
ALTER TABLE mod40Venues
	ADD CONSTRAINT ck_mod40Venues_VenueCity
	CHECK
	(
	(VenueCity NOT LIKE '%[0-9]%')
	);	

------------------------------
-- VenueCountry must:
--    o) Contain only letters. 
--
ALTER TABLE mod40Venues
	ADD CONSTRAINT ck_mod40Venues_VenueCountry
	CHECK
	(
	(VenueCountry NOT LIKE '%[0-9]%')
	);	

------------------------------------------CREATE ARTIST TABLE----------------------------------------------


CREATE TABLE mod40Artist
(	
	ArtistId INT NOT NULL IDENTITY,
	ArtistName VARCHAR(30) NOT NULL,
	FirstName VARCHAR(30) NOT NULL,
	LastName VARCHAR(30) NOT NULL,
	BirthDate DATE,
	WorkPhone VARCHAR(12) NOT NULL,
	CellPhone VARCHAR(12),
	Email VARCHAR(50) NOT NULL,
	City VARCHAR(30) NOT NULL,
	States VARCHAR(30) NOT NULL,
	Country VARCHAR(30) NOT NULL,
	InstrumentCode VARCHAR(3) NOT NULL,
);

ALTER TABLE mod40Artist
	ADD CONSTRAINT pk_mod40Artist
	PRIMARY KEY (ArtistId);
	
ALTER TABLE mod40Artist ------------------> No duplicate records of the same artist.
	ADD CONSTRAINT uc4_mod40Artist
	UNIQUE(ArtistName,FirstName, LastName);

------------------------------
-- ArtistName must be:
--    o) At least two characters
--    o) Must not start or end in spaces
--

ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_ArtistName
	CHECK
	(
		LEN(ArtistName) >= 2 
		AND ArtistName = LTRIM(RTRIM(ArtistName))
	);
	
------------------------------
-- LastName must be:
--    o) At least two characters
--    o) First letter must be a capital
--    o) Second letter must be lowercase, an apostrophe, or a space
--    o) Must not start or end in spaces
--    o) Only contain English letters, hyphens, spaces, and apostrophes
--

ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_LastName
	CHECK
	(
		LEN(LastName) >= 2 
		AND ASCII(LEFT(LastName, 1)) BETWEEN 65 AND 90
		AND (ASCII(SUBSTRING(LastName, 2, 1)) BETWEEN 97 AND 122 OR ASCII(SUBSTRING(LastName, 2, 1)) IN (32, 39))
		AND LastName = LTRIM(RTRIM(LastName))
		AND LastName NOT LIKE '%[^-A-Z '']%'
	);

------------------------------
-- FirstName must be:
--    o) At least two characters
--    o) Second letter must be lowercase
--    o) First letter must be a capital
--    o) Must not start or end in spaces
--    o) Only contain English letters, hyphens, spaces, and apostrophes
--
ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_FirstName
	CHECK
	(
		LEN(FirstName) >= 2 
		AND ASCII(LEFT(FirstName, 1)) BETWEEN 65 AND 90
		AND (ASCII(SUBSTRING(FirstName, 2, 1)) BETWEEN 97 AND 122)
		AND FirstName = LTRIM(RTRIM(FirstName))
		AND FirstName NOT LIKE '%[^-A-Z '']%'
	);

------------------------------
-- WorkPhone must be:
--    o) Unique
--    o) In the form 999-999-9999, where '9' is any digit
--
ALTER TABLE mod40Artist
	ADD CONSTRAINT uc5_mod40Artist
	UNIQUE (WorkPhone);

ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_WorkPhone
	CHECK
	(
		WorkPhone LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'
	);
------------------------------
-- CellPhone must be:
--    o) In the form 999-999-9999, where '9' is any digit
--

ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_CellPhone
	CHECK
	(
		CellPhone LIKE '[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]'
	);	
	
------------------------------
-- Email must be:
--    o) Unique
--    o) Contain only letters, digits, at sign, periods, hyphens, and underscore
--    o) Must contain an at sign, and there must be a period after the at sign
--    o) Must not contain two (or more) at signs
--    o) Must not start with an at sign

ALTER TABLE mod40Artist
	ADD CONSTRAINT uc3_mod40Artist
	UNIQUE (Email);
--
ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_Email
	CHECK
	(
		Email NOT LIKE '%[^A-Z0-9@.-_]%'
		AND Email LIKE '%@%.%'
		AND Email NOT LIKE '%@%@%'
		AND Email NOT LIKE '@%'		
	);

------------------------------
-- City must:
--    o) Contain only letters. 
--
ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_City
	CHECK
	(
	(City NOT LIKE '%[0-9]%')
	);	

------------------------------
-- State must:
--    o) Contain only letters. 
--
ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_States
	CHECK
	(
	(States NOT LIKE '%[0-9]%')
	);	
	
------------------------------
-- Country must:
--    o) Contain only letters. 
--
ALTER TABLE mod40Artist
	ADD CONSTRAINT ck_mod40Artist_Country
	CHECK
	(
	(Country NOT LIKE '%[0-9]%')
	);	
	
	
------------------------------
-- InstrumentCode must be:
--    o) Must be in the mod40Instruments table
ALTER TABLE mod40Artist
	ADD CONSTRAINT fk_mod40Artist_mod40Instruments
	FOREIGN KEY (InstrumentCode)
	REFERENCES mod40Instruments (InstrumentCode);


-----------------------------------------CREATE BOOKINGS TABLE----------------------------------------------

CREATE TABLE mod40Bookings
(	
	BookingId INT NOT NULL IDENTITY,
	ArtistName VARCHAR(30) NOT NULL,
	GenreCode VARCHAR(2) NOT NULL,
	NumberOfMembers INT NOT NULL,
	YearsActive INT NOT NULL,
	MonthlyListeners INT NOT NULL,
	VenueCode VARCHAR(3) NOT NULL,
	SetStartDt DATETIME NOT NULL, 
	Duration DECIMAL(3,2) NOT NULL,
	Payout DECIMAL(9,2) NOT NULL,
);

ALTER TABLE mod40Bookings
	ADD CONSTRAINT pk_mod40Bookings
	PRIMARY KEY (BookingId);

ALTER TABLE mod40Bookings ------------------> An artist can't have multiple bookings at the same time
	ADD CONSTRAINT uc1_mod40Bookings
	UNIQUE(ArtistName, SetStartDt);

ALTER TABLE mod40Bookings ------------------> A venue can't have multiple bookings at the same time
	ADD CONSTRAINT uc2_mod40Bookings
	UNIQUE(VenueCode, SetStartDt);


------------------------------
-- GenreCode must be:
--    o) Must be in the mod40Genres table
ALTER TABLE mod40Bookings
	ADD CONSTRAINT fk_mod40Bookings_mod40Genres
	FOREIGN KEY (GenreCode)
	REFERENCES mod40Genres (GenreCode);
	
------------------------------
-- NumberOfMembers must be:
--    o) Between 0 and 10 (inclusive)
--
ALTER TABLE mod40Bookings
	ADD CONSTRAINT ck_mod40Bookings_NumberOfMembers
	CHECK
	(
		NumberOfMembers >= 1 AND NumberOfMembers <= 10
	);
	
------------------------------
-- YearsActive must be:
--    o) Between 0 and 100 (inclusive)
--
ALTER TABLE mod40Bookings
	ADD CONSTRAINT ck_mod40Bookings_YearsActive
	CHECK
	(
		YearsActive >= 0 AND YearsActive <= 100
	);
	
------------------------------
-- MonthlyListeners must be:
--    o) Be a positive number
--
ALTER TABLE mod40Bookings
	ADD CONSTRAINT ck_mod40Bookings_MonthlyListeners
	CHECK
	(
		MonthlyListeners >= 0
	);
	
------------------------------
-- VenueCode must be:
--    o) Must be in the mod40Venues table
ALTER TABLE mod40Bookings
	ADD CONSTRAINT fk_mod40Bookings_mod40Venues
	FOREIGN KEY (VenueCode)
	REFERENCES mod40Venues (VenueCode);
	
------------------------------
-- SetStartDt (Set Start Date and Time) must be:
--    o) A future time and date
--
ALTER TABLE mod40Bookings
	ADD CONSTRAINT ck_mod40Bookings_SetStartDt
	CHECK
	(
		SetStartDt > GETDATE()
	);
	

------------------------------
-- Duration must be:
--    o) Be a positive number (hours)
--
ALTER TABLE mod40Bookings
	ADD CONSTRAINT ck_mod40Bookings_Duration
	CHECK
	(
		Duration >= 0
	);
------------------------------
-- Payout must be:
--    o) Between 0 and 9,999,999.99 (inclusive)
--
ALTER TABLE mod40Bookings
	ADD CONSTRAINT ck_mod40Bookings_Payout
	CHECK
	(
		Payout >= 0.00 AND Payout <= 9999999.99
	);




--------------------------------------------------------------------INSERT VALUES-----------------------------------------------------------

INSERT INTO mod40Genres 
	(GenreCode, GenreName)
VALUES
	('AL', 'Alternative'),
	('BL', 'Blues'), 
	('CL', 'Classical'), 
	('CR', 'Classic Rock'),
	('CO', 'Country'),
	('DB', 'Dubstep'),
	('EL', 'Electronic'),
	('FO', 'Folk'),
	('HP', 'HipHop'),
	('HO', 'House'),
	('JZ', 'Jazz'),
	('ME', 'Metal'),
	('RE', 'Reggae'),
	('RO', 'Rock'),
	('TE', 'Techno');
	

INSERT INTO mod40Venues
	(VenueCode, VenueName, VenueCity, VenueCountry, Capacity)
VALUES
	('BA', 'The Bank', 'Las Vegas', 'United States', 1000),
	('SP', 'Space','Ibiza', 'Spain', 5000),
	('WO', 'Womb','Tokyo', 'Japan', 1000),
	('MOS', 'Ministry of Sound','London', 'UK', 1555),
	('US', 'Ushuaia','Playa dEn Bossa', 'Spain', 5000),
	('WD', 'White Dubai','Dubai', 'UAE', 3000),
	('BO', 'Bootshaus','Cologne', 'Germany', 1600),
	('EX', 'Exchange','Los Angeles', 'United States', 1700),
	('PR', 'PRYSM','Chicago', 'United States', 850),
	('RR', 'Red Rocks','Morrison', 'Colorado', 9525),
	('SC', 'Slane Castle','Slane', 'Ireland', 80000),
	('SOH', 'Sydney Opera House', 'Sydney', 'Australia', 5738),
	('HB', 'Hollywood Bowl','Los Angeles', 'United States', 17500),
	('MSG','Madison Square Garden','New York', 'United States', 20000);


INSERT INTO mod40Instruments
	(InstrumentCode, InstrumentName)
VALUES
	('AG', 'Acoustic Guitar'),
	('BA', 'Bass'),
	('BG', 'Bass Guitar'), 
	('BN', 'Banjo'),
	('CDJ', 'CDJ-NXS2'),
	('CE', 'Cello'),
	('CL', 'Clarinet'), 
	('DR', 'Drums'),
	('EG', 'Electric Guitar'),
	('FL', 'Flute'),
	('GU', 'Guitar'),
	('HA', 'Harp'),
	('KE', 'Keyboard'),
	('PI', 'Piano'),
	('SX', 'Saxophone'),
	('SY', 'Synthesizer'),
	('TRO', 'Trombone'),
	('TRU', 'Trumpet'),
	('VI', 'Violin'),
	('VOX', 'Vocal'),
	('XDJ', 'XDJ-RX2');                           


INSERT INTO mod40Artist
	(ArtistName, FirstName, LastName, BirthDate, WorkPhone, CellPhone, Email, City, States, Country, InstrumentCode)
VALUES
	('deadmau5', 'Joel', 'Zimmerman', '01/05/1981','377-544-9933', '439-130-1363', 'joel@deadmau5.com', 'Toronto', 'Ontario', 'Canada', 'SY'),
	('Rezz', 'Isabelle', 'Rezazadeh', '03/28/1995', '756-372-0209', '582-470-1109', 'itsIz@rezz.com', 'Niagara Falls', 'Ontario', 'Canada', 'CDJ'),
	('Griz', 'Grant', 'Kwiesinski', '05/31/1990', '672-364-4830', NULL, 'grant@griz.com', 'Southfield', 'Michigan', 'United States', 'SX' ),
	('Tchami', 'Martin', 'Bresso', '05/12/1985','103-262-5598', '430-823-0443', 'tchami@confession.com', 'Paris', 'Ile-de-France', 'France', 'CDJ'),
	('Pink Floyd', 'Roger', 'Waters', '09/06/1943','247-775-4545', '231-929-4961', 'roger@pinkfloyd.com', 'Great Bookham', 'Surrey', 'United Kingdom', 'VOX'),
	('Pink Floyd', 'David', 'Gilmour', '03/06/1946','447-882-1169', '906-853-5378', 'dgilmour@pinkfloyd.com', 'Cambridge', 'Cambridgeshire', 'United Kingdom', 'GU'),
	('Pink Floyd', 'Syd', 'Barret', '01/06/1946','662-347-3386', '789-235-1237', 'barret@pinkfloyd.com', 'Cambridge', 'Cambridgeshire', 'United Kingdom', 'VOX'),
	('Queen', 'Freddie', 'Mercury', '09/05/1946','576-521-4014', '903-438-5450', 'freddie@queen.com', 'London', 'Greater London', 'United Kingdom', 'VOX'),
	('Queen', 'Brian', 'May', '07/19/1947','990-626-7299', '338-736-2544', 'brian@queen.com' , 'Hampton', 'Greater London', 'United Kingdom', 'GU'),
    ('Queen', 'Roger', 'Taylor', '07/26/1949','895-963-3121', '915-295-4492', 'roger@queen.com', 'King''s Lynn', 'Norfolk', 'United Kingdom', 'DR'),
    ('Queen', 'Jon', 'Deacon', '08/19/1951','777-411-4235', '404-379-5826', 'jon@queen.com', 'Oadby', 'Leicestershire', 'United Kingdom', 'BG'),	
	('Lynyrd Skynyrd', 'Ronnie', 'Van Zant', '01/15/1948','841-389-8818', '155-759-1033', 'ronnie@lynyrd.com', 'Jacksonville', 'Florida', 'United States', 'VOX'),
	('Lynyrd Skynyrd', 'Gary', 'Rossington', '12/04/1951','745-648-8099', '736-963-3903', 'gary@lynyrd.com', 'Jacksonville', 'Florida', 'United States', 'EG'),
	('Lynyrd Skynyrd', 'Leon', 'Wilkenson', '04/02/1952','174-889-4824', '701-449-5382', 'leon@lynyrd.com', 'Ponte Vedra Beach', 'Florida', 'United States', 'BG'),
	('Aerosmith', 'Steven', 'Tyler', '03/26/1948','393-591-3058', '516-619-3565', 'steven@aerosmith.com', 'Manhattan', 'New York', 'United States', 'VOX'), 
	('Aerosmith', 'Joe', 'Perry', '09/10/1950','692-510-5133', '144-242-8063', 'joe@aerosmith.com' , 'Lawrence', 'Massachusetts', 'United States', 'EG'),
	('Aerosmith', 'Joey', 'Kramer', '06/21/1950','546-733-7141', '406-921-9168', 'kramer@aerosmith.com' , 'The Bronx', 'New York', 'United States', 'DR'),
	('Boston', 'Tom', 'Scholz', '03/10/1947','352-758-2677', '178-990-1658', 'tom@bostonmusic.com' , 'Toledo', 'Ohio', 'United States', 'GU'),
	('Boston', 'Barry', 'Goudreau', NULL, '454-613-4008', '820-770-6618', 'barry@bostonmusic.com',  'Boston', 'Massachusetts', 'United States', 'EG'),
	('Boston', 'Brad', 'Delp', '06/15/1951', '940-914-7837', '618-633-4940', 'brad@bostonmusic.com', 'Danvers', 'Massachusetts', 'United States', 'VOX');



INSERT INTO mod40Bookings
	(ArtistName, GenreCode, NumberOfMembers, YearsActive, MonthlyListeners, VenueCode, SetStartDt, Duration, Payout)
VALUES
	('Queen', 'CR', 7, 50, 32000000, 'SP', '2020-08-26 18:00:00', 2.00, 15000),
	('Pink Floyd', 'CR', 6, 33, 13088000, 'RR', '2020-09-24 22:00:00', 2.00, 500000),
	('Lynyrd Skynyrd', 'CR', 6, 47, 10300000, 'MSG', '2020-08-26 20:00:00', 2.00, 50000),
	('Boston', 'CR', 7, 45, 5800000, 'SOH', '2021-04-04 20:00:00', 2.00, 75000),
	('Aerosmith', 'CR', 6, 50, 13800000, 'SC', '2020-06-16 20:00:00', 2.00, 100000),
	('Griz', 'EL', 1, 9, 1340000, 'BA', '2020-11-12 22:30:00', 2.00, 75000),
	('Tchami', 'HO', 1, 7 , 2400000, 'BO', '2020-06-13 23:00:00', 2.00, 100000),
	('deadmau5', 'EL', 1, 22 , 3200000,'WO', '2020-08-27 22:00:00', 2.00, 500000),
	('Griz', 'EL', 1, 9, 1340000, 'HB', '2021-01-11 22:00:00', 2.00, 75000),
	('deadmau5', 'EL', 1, 22, 3200000, 'WD', '2020-06-24 21:00:00', 2.00, 100000),	
	('Lynyrd Skynyrd', 'CR', 6, 47, 10300000, 'SOH', '2021-01-05 18:00:00', 2.00, 50000),
	('Queen', 'CR', 7, 50, 32000000, 'SC', '2020-08-27 20:00:00', 2.00, 30000),
	('Pink Floyd', 'CR', 6, 33, 13088000, 'MOS','2020-08-27 22:00:00', 2.00, 500000),
	('Pink Floyd', 'CR', 6, 33, 13088000, 'MSG', '2020-06-16 21:00:00', 3.00, 100000),
	('Boston', 'CR', 7, 45, 5800000, 'RR', '2020-11-12 22:30:00', 2.00, 75000),	
	('Rezz', 'EL', 1, 5, 1240000, 'EX', '2020-06-24 18:00:00', 3.00, 50000),
	('Tchami', 'HO', 1, 7, 2400000, 'PR', '2021-01-11 20:00:00', 2.00, 100000),
	('Rezz', 'EL', 1, 5, 1240000, 'BA', '2021-06-05 22:00:00', 2.00, 50000),
	('Tchami', 'HO', 1, 7, 2400000, 'BA', '2021-01-07 22:00:00', 2.00, 100000),
	('deadmau5', 'EL', 1, 22, 3200000, 'US', '2020-10-25 23:00:00', 2.00, 500000);




SELECT * FROM mod40Artist;
SELECT * FROM mod40Bookings;
SELECT * FROM mod40Genres;
SELECT * FROM mod40Venues;
SELECT * FROM mod40Instruments;








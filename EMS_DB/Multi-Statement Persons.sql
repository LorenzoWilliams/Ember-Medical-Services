-- ================================================
-- Template generated from Template Explorer using:
-- Create Multi-Statement Function (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the function.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE FUNCTION AllPersons
(

)
RETURNS 
@Persons TABLE 
(
	-- Add the column definitions for the TABLE variable here
	FirstName nvarchar(30) NOT NULL,
	LastName nvarchar(50) NOT NULL,
	Email nvarchar(50) NOT NULL,
	[Phone] nvarchar(15) NOT NULL,
	Personnel_type nvarchar(50) NOT NULL,
)
AS
BEGIN
	-- Fill the table variable with the rows for your result set
	INSERT INTO @Persons
	SELECT 
	[FirstName],
	[LastName],
	[Email],
	[Phone],
	'Patient'
	From Patients

	INSERT INTO @Persons
	SELECT 
	[FirstName],
	[Last_Name],
	[Email],
	[Phone],
	'Physician'
	From Physicians

	INSERT INTO @Persons
	SELECT 
	[FirstName],
	[Last_Name],
	[Email],
	[Phone],
	'Nurse'
	From Nurses

	INSERT INTO @Persons
	SELECT 
	[FirstName],
	[Last_Name],
	[Email],
	[Phone],
	'Receptionist'
	From Receptionists
	RETURN 
END
GO
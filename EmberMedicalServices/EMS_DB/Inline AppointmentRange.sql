-- ================================================
-- Template generated from Template Explorer using:
-- Create Inline Function (New Menu).SQL
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
CREATE FUNCTION AppointmentRange
(
-- Add the parameters for the function here
@Appointment1 date,
@Appointment2 date
)
RETURNS TABLE
AS
RETURN
(
-- Add the SELECT statement with parameter references here
SELECT [Date] from Appointments
where [Date] BETWEEN @Appointment1 AND @Appointment2
)
GO
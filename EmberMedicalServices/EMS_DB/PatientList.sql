USE [Ember_medical_service_db]

GO
/****** Object:  StoredProcedure [dbo].[PatientsList]    Script Date: 12/15/2019 3:49:47 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[PatientsList]
AS
SELECT * FROM Patients
GO;


-- This procedure display a list of patients currently in the database
USE [Ember_medical_service_db]
GO
/****** Object:  Trigger [dbo].[no_delete_payments]    Script Date: 15/12/2019 11:43:05 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TRIGGER [dbo].[no_delete_payments]
ON [dbo].[Payments]
AFTER DELETE
AS
BEGIN
PRINT 'Deletion of Payment records is not Allowed'
ROLLBACK TRANSACTION 
INSERT INTO Attempted_delpayment(timestmp)
VALUES (getdate())
END 
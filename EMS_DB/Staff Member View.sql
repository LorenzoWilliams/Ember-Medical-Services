CREATE VIEW [staff_members] AS
select FirstName, Last_Name
from Receptionists
UNION
select FirstName, Last_Name
from Nurses
UNION
select FirstName, Last_Name
from Physicians

--use Ember_medical_service_db;
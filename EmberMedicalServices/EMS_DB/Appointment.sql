use Ember_medical_service_db;

select
id,
[Date],
Physician_id,
Patient_id,
convert(varchar(8),[start],0) As [Start],
Comments
from Appointments;

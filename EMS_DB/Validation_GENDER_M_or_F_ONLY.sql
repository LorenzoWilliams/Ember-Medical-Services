use Ember_medical_service_db;

alter table Patients
add constraint ck_gender_Gender CHECK(Gender = 'M' or Gender = 'F')

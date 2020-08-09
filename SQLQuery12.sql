
Create view REPORT_RECIPE AS
Select distinct ScanGetPatientByRecipeFAPARAL.FIO_Pacient, Lekarstvo.Name_Lekarstva, Lekarstvo.Dozirovka, Lekarstvo.Gruppa
                From Lekarstvo inner join ScanGetPatientByRecipeFAPARAL
                    on Lekarstvo.Cod_Lekarstva = ScanGetPatientByRecipeFAPARAL.Cod_Lekarstva


					SELECT * FROM REPORT_RECIPE 
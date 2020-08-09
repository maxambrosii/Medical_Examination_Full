
Create View REPORT_DIAGNOZ AS
Select ScanGetPatientByDiagnosisPATAP.FIO_Pacient, ScanGetPatientByDiagnosisPATAP.FIO_Doctor, ScanGetPatientByDiagnosisPATAP.Data_Priema, ScanGetPatientByDiagnosisPATAP.Diagnoz
                From ScanGetPatientByDiagnosisPATAP


				Select * From REPORT_DIAGNOZ
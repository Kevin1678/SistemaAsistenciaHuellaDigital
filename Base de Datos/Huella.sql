create database HuellaDigital;
GO

use HuellaDigital;
GO 

Create table AsistenciaPer
(
	Id_asis char(8) primary key not null,
	Id_Pernl char(10) not null,
	FechaAsis date null,
	Nombre_dia varchar(12) not null,
	HoIngreso varchar(10) not null,
	HoSalida varchar(10) not null,
	Tardanzas real null,
	Total_Hrsworked real null,
	Adelanto real null,
	Justificacion nvarchar(max) null,
	EstadoAsis varchar(20) null,
	Identificador varchar(12) null,
	Foreign key (Id_Pernl) References Personal(Id_Pernl)
);
GO

Create table Contrato_Per
(
	Id_Contrato nchar(8) primary key not null,
	Id_Pernl char(10) not null,
	Fecha_Emicon date not null,
	Fecha_Cese date not null,
	Tipo_Contrato varchar(30) null,
	Days_toWork varchar(50) null,
	Day_toRest varchar(30) null,
	Has_Vacation char(2) not null,
	Has_AsigFami char(2) not null,
	Has_Gratifi char(2) not null,
	Pay_5ta_Catg char(2) not null,
	Suedlo_Fijo real null,
	Acept_Terms char(2) not null,
	Estado_Contrato varchar(30) null,
	Id_Seg nchar(4) not null,
	Foreign key (Id_Pernl) References Personal(Id_Pernl),
	Foreign key (Id_Seg) references Seguros(Id_Seg)
);
GO
Create table Departamento
(
	Id_Depto char(10) primary key not null,
	Depto nvarchar(50) null
)
GO
Create table Detalle_BoletaPago
(
	IdPago char(8) not null,
	Id_Concepto char(4) not null,
	Detalle_Concepto varchar(100) not null,
	Importe_Pago real not null,
	Tipo_Det varchar(18) null
)
GO
Create table Empresa
(
	Id_Empre nchar(4) primary key not null,
	Nombre_Empresa varchar(250) not null,
	Direccion_Empre varchar(250) not null,
	Nro_Ruc nchar(20) not null,
	Nombre_Generate varchar(150) not null,
	Fecha_Creac date null
)
GO
Create table Horario
(
	Id_Hor nchar(4) primary key not null,
	HoEntrada datetime not null,
	MiTolrnciw datetime null,
	HoLimite datetime null,
	HoSalida datetime null
)
GO
Create table Justificacion
(
	Id_Justi char(8) primary key not null,
	Id_Pernl char(10) not null,
	PricipialMotivo nvarchar(50) null,
	Detalle_Justi nvarchar(max) null,
	FechaJusti date null,
	EstadoJusti nvarchar(50) null,
	FechaEmi date null,
	foreign key (Id_Pernl) references Personal(Id_Pernl),
);
GO

Create table Personal
(
	Id_Pernl char(10) primary key not null,
	Id_rol char(7) not null,
	Id_Depto char(10) not null,
	DOC char(15) not null,
	Nombre_Completo varchar(150) not null,
	Fec_Naci date null,
	Sexo char(1) null,
	Domicilio nvarchar(120) null,
	Correo varchar(50) null,
	Celular varchar(10) null,
	Foto nvarchar(10) null,
	FingurePrint varbinary(2500) null,
	Estado_Per varchar(20) null,
	FingerMask nvarchar(100) null
	Foreign key (Id_Rol) references ROL(Id_Rol),
	Foreign key (Id_Depto) references Departamento(Id_Depto)
);
GO
Create table Planilla
(
	Id_Plani nchar(8) primary key not null,
	Id_Pernl char(10) not null,
	Nro_CussPP nchar(20) null,
	Fecha_IngreTrabj date null,
	Asig_Familr char(2) not null,
	Sueldo_Basic real not null,
	Impor_Asig_Famlr real not null,
	Total_Ext25 real not null,
	Total_Ext35 real not null,
	Total_ExtDble real not null,
	Vacaciones real not null,
	Grafiti real not null,
	Total_Sueldo_Bruto real not null,
	ONP real not null,
	ComisionAFP real null,
	PrimaAFP real null,
	AporteAFP real null,
	Rnta_5ta_Catg real not null,
	Adelanto real not null,
	Tardanza real not null,
	Dsct_Falta real not null,
	Total_Dscto real not null,
	Neto_Pagar real not null,
	Essalud real null,
	SCTR real null,
	Total_Aporta_Empldr real not null,
	Fecha_Plani date null,
	Periodo_Plani varchar(20) null,
	Estado_Planilla varchar(20) not null,
	Suma_Total_SBasic real not null,
	Suma_Total_SlBruto real not null,
	Suma_Total_Dscto real not null,
	Suma_Total_NetPagr real not null,
	Suma_Total_Aportes real not null,
	foreign key (Id_Pernl) references Personal(Id_Pernl)
);
GO

Create table PUsuario
(
	Id_Usu char(8) primary key not null,
	Nombre_Completo nvarchar(150) not null,
	Avatar nvarchar(max) null,
	Nom_Usuario varchar(20) not null,
	Password nvarchar(12) not null,
	Estado_USu varchar(30) not null,
	Id_Rol char(7) not null,
	foreign key (Id_Rol) references Rol(Id_Rol)
);
GO

Create table Registro_BoletaPago
(
	IdPago char(8) primary key not null,
	Id_Pernl char(10) not null,
	NetoPagar real null,
	Total_Ingreso real not null,
	FechaP date not null,
	Total_Aporte real not null,
	Total_Dscto real not null,
	Inicio_Vaca varchar(15) null,
	Fin_Vaca varchar(2) null,
	Dias_Vaca varchar(2) null,
	Dias_Worked char(4) null,
	Hour_Ex25 real not null,
	Hour_Ex35 real not null,
	Days_NoWorked char(4) null,
	Import_Ex25 real not null,
	Import_Ex35 real not null
)
GO

Create table ROL
(
	Id_Rol char(7) primary key not null,
	NomRol varchar(50) null
)
GO

create table Seguros
(
	Id_Seg nchar(4) primary key not null,
	Nombre_Seguro varchar(50) null,
	Aporte_Obligatorio real null,
	Comision_RA real null,
	Prima_Seguro real null
)
GO

Create table Temporal
(
	Id_Tem int primary key not null,
	Dni_Tem char(10) null,
	Cod_Asis char(8) not null,
	Fecha_Tem date null,
	Tipo varchar(30) null
)
GO

Create table TipoDoc
(
	Idtipo int primary key not null,
	NombreTipo varchar(50) null,
	Serie varchar(2) null,
	Numero_T varchar(5) null
)
GO



CREATE DATABASE transporteUI_DB

USE transporteUI_DB

-- Tabla Estudiantes
CREATE TABLE estudiantes (
   id_estudiante INT IDENTITY(1,1) PRIMARY KEY,
   nombre VARCHAR(100),
   apellido VARCHAR(100),
   cedula INT, 
   edad VARCHAR(50),
   especialidad VARCHAR(100),
   semestre VARCHAR(50),
   fecha_Registro DATETIME DEFAULT GETDATE()
);

-- Tabla Reserva
CREATE TABLE reservas(
   id_reserva INT IDENTITY(1,1) PRIMARY KEY, 
   sur VARCHAR(10),
   centro VARCHAR(10),
   norte VARCHAR(10),
   id_estudiante INT,

   FOREIGN KEY(id_estudiante) REFERENCES estudiantes(id_estudiante)
);

-- Tabla Detalle Reserva  
CREATE TABLE detalles_reserva(
   id_detalle_reserva INT IDENTITY(1,1) PRIMARY KEY,
   barrio VARCHAR(100),
   calles VARCHAR(100),
   casa VARCHAR(100),
   referencia VARCHAR(100),
   telefono VARCHAR(100),
   id_reserva INT,  
   id_estudiante INT, 
    
   FOREIGN KEY(id_reserva) REFERENCES reservas(id_reserva),  
   FOREIGN KEY(id_estudiante) REFERENCES estudiantes(id_estudiante)
)
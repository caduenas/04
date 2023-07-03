# GymMasterProyectoFinalF
CREATE DATABASE GYMaster 
use GYMaster; 

CREATE TABLE admins ( id_admin integer not null IDENTITY(1,1) PRIMARY KEY, nombre_admin varchar(50), apellido_admin varchar(50), contrasena_admin varchar(50), correo_admin varchar(50), numero_admin varchar(10) );

CREATE TABLE entrenadores( id_entrenador integer not null IDENTITY(1,1) PRIMARY KEY, nombre_entrenador varchar(50), apellido_entrenador varchar(50), contrasena_entrenador varchar(50), correo_entrenador varchar(50), numero_entrenador varchar(10) );

CREATE TABLE admin_entrenador ( id_admin_entrenador integer not null IDENTITY(1,1) PRIMARY KEY, id_admin integer not null, id_entrenador integer not null, FOREIGN KEY (id_admin) REFERENCES admins(id_admin), FOREIGN KEY (id_entrenador) REFERENCES entrenadores(id_entrenador) );

CREATE TABLE alimentos( id_alimento integer not null IDENTITY(1,1) PRIMARY KEY, nombre_alimento varchar(50), Calorias_alimento varchar(50) );

CREATE TABLE dietas( id_dieta integer not null IDENTITY(1,1) PRIMARY KEY, objetivo varchar(50) );

CREATE TABLE alimentos_dieta ( id_alimnetos_dieta integer not null IDENTITY(1,1) PRIMARY KEY, calorias_dieta integer, id_alimento integer not null, id_dieta integer not null, FOREIGN KEY (id_alimento) REFERENCES alimentos(id_alimento), FOREIGN KEY (id_dieta) REFERENCES dietas(id_dieta) );

CREATE TABLE ejercicios ( id_ejercicio integer not null IDENTITY(1,1) PRIMARY KEY, nombre_ejercicio varchar(50), Repeticiones integer );

CREATE TABLE rutinas( id_rutina integer not null IDENTITY(1,1) PRIMARY KEY, nombre_rutina varchar(20), frecuencia integer );

CREATE TABLE ejercicios_rutina ( id_ejercicio_rutina integer not null IDENTITY(1,1) PRIMARY KEY, id_nombre_ejercicio_rutina varchar(50), id_ejercicio integer not null, id_rutina integer not null, FOREIGN KEY (id_ejercicio) REFERENCES ejercicios(id_ejercicio), FOREIGN KEY (id_rutina) REFERENCES rutinas(id_rutina) );

CREATE TABLE antropometrias ( id_antropometria integer not null IDENTITY(1,1) PRIMARY KEY, Bicep_derecho integer, Bicep_izquierdo integer, Cadera integer, Muslo_D integer, Muslo_I integer, Abdomen_bajo integer, Abdomen_medio integer, Abdomen_alto integer );

CREATE TABLE asesorados ( id_asesorados integer not null IDENTITY(1,1) PRIMARY KEY, contrasena_asesorado varchar(255), nombre_asesorado varchar(50), apellido_asesorado varchar(50), numero_asesorado varchar(10), correo_asesorado varchar(50), Meta_Lograr varchar(20), altura integer not null, peso integer not null, edad integer not null, id_entrenador integer null, id_rutina integer null, id_dieta integer null, id_antropometria integer null, FOREIGN KEY (id_entrenador) REFERENCES entrenadores(id_entrenador), FOREIGN KEY (id_rutina) REFERENCES rutinas(id_rutina), FOREIGN KEY (id_dieta) REFERENCES dietas(id_dieta), FOREIGN KEY (id_antropometria) REFERENCES antropometrias(id_antropometria) );

INSERT INTO admins (nombre_admin, apellido_admin, contrasena_admin, correo_admin, numero_admin) VALUES ('John', 'Doe', '123456', 'john.doe@example.com', '1234567890');

INSERT INTO admins (nombre_admin, apellido_admin, contrasena_admin, correo_admin, numero_admin) VALUES ('Jane', 'Smith', 'password123', 'jane.smith@example.com', '9876543210');

INSERT INTO admins (nombre_admin, apellido_admin, contrasena_admin, correo_admin, numero_admin) VALUES ('Michael', 'Johnson', 'admin123', 'michael.johnson@example.com', '5555555555');

INSERT INTO admins (nombre_admin, apellido_admin, contrasena_admin, correo_admin, numero_admin) VALUES ('Sarah', 'Williams', 'securepass', 'sarah.williams@example.com', '1111111111');

INSERT INTO admins (nombre_admin, apellido_admin, contrasena_admin, correo_admin, numero_admin) VALUES ('David', 'Brown', 'pass1234', 'david.brown@example.com', '9999999999');

-- Ejemplo 1 
INSERT INTO entrenadores (nombre_entrenador, apellido_entrenador, contrasena_entrenador, correo_entrenador, numero_entrenador) VALUES ('Juan', 'Pérez', 'password123', 'juan.perez@example.com', '1234567890');


-- Ejemplo 2 
INSERT INTO entrenadores (nombre_entrenador, apellido_entrenador, contrasena_entrenador, correo_entrenador, numero_entrenador) VALUES ('María', 'González', 'securepass', 'maria.gonzalez@example.com', '9876543210');


-- Ejemplo 3 
INSERT INTO entrenadores (nombre_entrenador, apellido_entrenador, contrasena_entrenador, correo_entrenador, numero_entrenador) VALUES ('Carlos', 'López', 'admin123', 'carlos.lopez@example.com', '5555555555');


-- Ejemplo 4 
INSERT INTO entrenadores (nombre_entrenador, apellido_entrenador, contrasena_entrenador, correo_entrenador, numero_entrenador) VALUES ('Ana', 'Martínez', 'pass1234', 'ana.martinez@example.com', '1111111111');


-- Ejemplo 5 
INSERT INTO entrenadores (nombre_entrenador, apellido_entrenador, contrasena_entrenador, correo_entrenador, numero_entrenador) VALUES ('Luis', 'Sánchez', 'luis123', 'luis.sanchez@example.com', '9999999999');


-- Ejemplo 1 
INSERT INTO admin_entrenador (id_admin, id_entrenador) VALUES (1, 1);


-- Ejemplo 2 
INSERT INTO admin_entrenador (id_admin, id_entrenador) VALUES (2, 1);


-- Ejemplo 3 
INSERT INTO admin_entrenador (id_admin, id_entrenador) VALUES (1, 2);


-- Ejemplo 4 
INSERT INTO admin_entrenador (id_admin, id_entrenador) VALUES (3, 2);


-- Ejemplo 5 
INSERT INTO admin_entrenador (id_admin, id_entrenador) VALUES (2, 3);


-- Ejemplo 1 
INSERT INTO alimentos (nombre_alimento, Calorias_alimento) VALUES ('Manzana', '52');


-- Ejemplo 2 
INSERT INTO alimentos (nombre_alimento, Calorias_alimento) VALUES ('Pollo a la parrilla', '165');


-- Ejemplo 3 
INSERT INTO alimentos (nombre_alimento, Calorias_alimento) VALUES ('Arroz integral', '111');


-- Ejemplo 4 
INSERT INTO alimentos (nombre_alimento, Calorias_alimento) VALUES ('Yogur griego', '150');


-- Ejemplo 5 
INSERT INTO alimentos (nombre_alimento, Calorias_alimento) VALUES ('Atún enlatado', '118');


-- Ejemplo 1 
INSERT INTO dietas (objetivo) VALUES ('Perder peso');


-- Ejemplo 2 
INSERT INTO dietas (objetivo) VALUES ('Ganar masa muscular');


-- Ejemplo 3 
INSERT INTO dietas (objetivo) VALUES ('Mantener peso');


-- Ejemplo 4 
INSERT INTO dietas (objetivo) VALUES ('Dieta vegetariana');


-- Ejemplo 5 
INSERT INTO dietas (objetivo) VALUES ('Dieta baja en carbohidratos');


-- Ejemplo 1 
INSERT INTO alimentos_dieta (calorias_dieta, id_alimento, id_dieta) VALUES (100, 1, 1);


-- Ejemplo 2 
INSERT INTO alimentos_dieta (calorias_dieta, id_alimento, id_dieta) VALUES (200, 2, 2);


-- Ejemplo 3 
INSERT INTO alimentos_dieta (calorias_dieta, id_alimento, id_dieta) VALUES (150, 3, 3);


-- Ejemplo 4 
INSERT INTO alimentos_dieta (calorias_dieta, id_alimento, id_dieta) VALUES (120, 4, 4);


-- Ejemplo 5 
INSERT INTO alimentos_dieta (calorias_dieta, id_alimento, id_dieta) VALUES (180, 5, 5);


SELECT ad.*, a.nombre_alimento, d.objetivo FROM alimentos_dieta ad INNER JOIN alimentos a ON ad.id_alimento = a.id_alimento INNER JOIN dietas d ON ad.id_dieta = d.id_dieta;


-- Ejemplo 1 
INSERT INTO ejercicios (nombre_ejercicio, Repeticiones) VALUES ('Sentadillas', 12);


-- Ejemplo 2 
INSERT INTO ejercicios (nombre_ejercicio, Repeticiones) VALUES ('Flexiones de brazos', 10);


-- Ejemplo 3 
INSERT INTO ejercicios (nombre_ejercicio, Repeticiones) VALUES ('Plancha', 30);


-- Ejemplo 4 
INSERT INTO ejercicios (nombre_ejercicio, Repeticiones) VALUES ('Zancadas', 15);


-- Ejemplo 5 
INSERT INTO ejercicios (nombre_ejercicio, Repeticiones) VALUES ('Abdominales', 20);


-- Ejemplo 1 
INSERT INTO rutinas (nombre_rutina, frecuencia) VALUES ('Rutina de fuerza', 4);


-- Ejemplo 2 
INSERT INTO rutinas (nombre_rutina, frecuencia) VALUES ('Rutina de cardio', 3);


-- Ejemplo 3 
INSERT INTO rutinas (nombre_rutina, frecuencia) VALUES ('Rutina de entrenamiento funcional', 5);


-- Ejemplo 4 
INSERT INTO rutinas (nombre_rutina, frecuencia) VALUES ('Rutina de flexibilidad', 2);


-- Ejemplo 5 
INSERT INTO rutinas (nombre_rutina, frecuencia) VALUES ('Rutina de alta intensidad', 6);


-- Ejemplo 1 
INSERT INTO ejercicios_rutina (id_nombre_ejercicio_rutina, id_ejercicio, id_rutina) VALUES ('Ejercicio 1', 1, 1);


-- Ejemplo 2 
INSERT INTO ejercicios_rutina (id_nombre_ejercicio_rutina, id_ejercicio, id_rutina) VALUES ('Ejercicio 2', 2, 2);


-- Ejemplo 3 
INSERT INTO ejercicios_rutina (id_nombre_ejercicio_rutina, id_ejercicio, id_rutina) VALUES ('Ejercicio 3', 3, 3);


-- Ejemplo 4 
INSERT INTO ejercicios_rutina (id_nombre_ejercicio_rutina, id_ejercicio, id_rutina) VALUES ('Ejercicio 4', 4, 4);


-- Ejemplo 5 
INSERT INTO ejercicios_rutina (id_nombre_ejercicio_rutina, id_ejercicio, id_rutina) VALUES ('Ejercicio 5', 5, 5);


-- Ejemplo 1 
INSERT INTO antropometrias (Bicep_derecho, Bicep_izquierdo, Cadera, Muslo_D, Muslo_I, Abdomen_bajo, Abdomen_medio, Abdomen_alto) VALUES (30, 28, 90, 55, 56, 80, 85, 90);


-- Ejemplo 2 
INSERT INTO antropometrias (Bicep_derecho, Bicep_izquierdo, Cadera, Muslo_D, Muslo_I, Abdomen_bajo, Abdomen_medio, Abdomen_alto) VALUES (32, 30, 92, 57, 58, 82, 87, 92);


-- Ejemplo 3 
INSERT INTO antropometrias (Bicep_derecho, Bicep_izquierdo, Cadera, Muslo_D, Muslo_I, Abdomen_bajo, Abdomen_medio, Abdomen_alto) VALUES (28, 26, 88, 53, 54, 78, 83, 88);


-- Ejemplo 4 
INSERT INTO antropometrias (Bicep_derecho, Bicep_izquierdo, Cadera, Muslo_D, Muslo_I, Abdomen_bajo, Abdomen_medio, Abdomen_alto) VALUES (33, 31, 94, 58, 59, 84, 89, 94);


-- Ejemplo 5 
INSERT INTO antropometrias (Bicep_derecho, Bicep_izquierdo, Cadera, Muslo_D, Muslo_I, Abdomen_bajo, Abdomen_medio, Abdomen_alto) VALUES (29, 27, 90, 54, 55, 80, 85, 90);


-- Ejemplo 1 
INSERT INTO asesorados (contrasena_asesorado, nombre_asesorado, apellido_asesorado, numero_asesorado, correo_asesorado, altura, peso, edad, id_entrenador, id_rutina, id_dieta, id_antropometria) VALUES ('contrasena1', 'Juan', 'Gómez', '1234567890', 'juangomez@example.com', 170, 70, 30, 1, 1, 1, 1);


-- Ejemplo 2 
INSERT INTO asesorados (contrasena_asesorado, nombre_asesorado, apellido_asesorado, numero_asesorado, correo_asesorado, altura, peso, edad, id_entrenador, id_rutina, id_dieta, id_antropometria) VALUES ('contrasena2', 'María', 'López', '0987654321', 'marialopez@example.com', 165, 60, 28, 2, 2, 2, 2);


-- Ejemplo 3 
INSERT INTO asesorados (contrasena_asesorado, nombre_asesorado, apellido_asesorado, numero_asesorado, correo_asesorado, altura, peso, edad, id_entrenador, id_rutina, id_dieta, id_antropometria) VALUES ('contrasena3', 'Pedro', 'Rodríguez', '9876543210', 'pedrorodriguez@example.com', 180, 80, 35, NULL, NULL, NULL, NULL);


-- Ejemplo 4 
INSERT INTO asesorados (contrasena_asesorado, nombre_asesorado, apellido_asesorado, numero_asesorado, correo_asesorado, altura, peso, edad, id_entrenador, id_rutina, id_dieta, id_antropometria) VALUES ('contrasena4', 'Laura', 'Martínez', '5678901234', 'lauramartinez@example.com', 160, 55, 25, 3, NULL, 3, 3);


-- Ejemplo 5 
INSERT INTO asesorados (contrasena_asesorado, nombre_asesorado, apellido_asesorado, numero_asesorado, correo_asesorado, altura, peso, edad, id_entrenador, id_rutina, id_dieta, id_antropometria) VALUES ('contrasena5', 'Carlos', 'García', '0123456789', 'carlosgarcia@example.com', 175, 75, 32, NULL, 4, 4, NULL);
# 04

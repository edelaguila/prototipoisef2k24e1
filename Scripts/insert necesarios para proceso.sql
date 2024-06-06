use siu;

-- Insertar datos en la tabla maestros
INSERT INTO maestros (codigo_maestro, nombre_maestro, direccion_maestro, telefono_maetro, email_maestro, estatus_maestro)
VALUES ('1', 'Juan Perez', 'Av. Siempre Viva 123', '555-1234', 'juan@example.com', 'A');

INSERT INTO maestros (codigo_maestro, nombre_maestro, direccion_maestro, telefono_maetro, email_maestro, estatus_maestro)
VALUES ('2', 'Maria Lopez', 'Calle Falsa 456', '555-5678', 'maria@example.com', 'A');

-- Insertar datos en la tabla facultades
INSERT INTO facultades (codigo_facultad, nombre_facultad, estatus_facultad)
VALUES ('1', 'Ingeniería', 'A');

INSERT INTO facultades (codigo_facultad, nombre_facultad, estatus_facultad)
VALUES ('2', 'Ciencias Sociales', 'A');

-- Insertar datos en la tabla carreras
INSERT INTO carreras (codigo_carrera, nombre_carrera, codigo_facultad, estatus_carrera)
VALUES ('1', 'Ingeniería de Sistemas', '1', 'A');

INSERT INTO carreras (codigo_carrera, nombre_carrera, codigo_facultad, estatus_carrera)
VALUES ('2', 'Psicología', '2', 'A');

-- Insertar datos en la tabla secciones
INSERT INTO secciones (codigo_seccion, nombre_seccion, estatus_seccion)
VALUES ('1', 'Sección A', 'A');

INSERT INTO secciones (codigo_seccion, nombre_seccion, estatus_seccion)
VALUES ('2', 'Sección B', 'A');

-- Insertar datos en la tabla sedes
INSERT INTO sedes (codigo_sede, nombre_sede, estatus_sede)
VALUES ('1', 'Sede Central', 'A');

INSERT INTO sedes (codigo_sede, nombre_sede, estatus_sede)
VALUES ('2', 'Sede Norte', 'A');

-- Insertar datos en la tabla aulas
INSERT INTO aulas (codigo_aula, nombre_aula, estatus_aula)
VALUES ('1', 'Aula 101', 'A');

INSERT INTO aulas (codigo_aula, nombre_aula, estatus_aula)
VALUES ('2', 'Aula 102', 'A');

-- Insertar datos en la tabla jornadas
INSERT INTO jornadas (codigo_jornada, nombre_jornada, estatus_jornada)
VALUES ('1', 'Matutina', 'A');

INSERT INTO jornadas (codigo_jornada, nombre_jornada, estatus_jornada)
VALUES ('2', 'Verpertina', 'A');




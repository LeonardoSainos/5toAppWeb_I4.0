 
Create table Maestro(
clave_maestro int NOT NULL IDENTITY ,
nombre varchar (30),
carrera varchar (30),
CONSTRAINT PK_maestro PRIMARY KEY(clave_maestro)
);

Create table Materia(
clave_materia varchar (5),
nombre_materia varchar (20),
no_horas int not null
CONSTRAINT PK_Materia PRIMARY KEY(clave_materia)
);
Create table imparte(
id_maestro int not null ,
id_materia varchar (5)
  CONSTRAINT FK_clav_maestro FOREIGN KEY(id_maestro) REFERENCES Maestro(clave_maestro) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT FK_clav_materia FOREIGN KEY(id_materia) REFERENCES Materia(clave_materia) ON DELETE NO ACTION ON UPDATE NO ACTION
);




Create table Grupo(
id_grupo varchar (3),
salon varchar (5),
no_alumnos int not null,
turno varchar (10),
CONSTRAINT PK_grupo PRIMARY KEY(id_grupo)
);

Create table Enseñar(
id_grupo varchar (3),
id_maestro int not null,
  CONSTRAINT FK_clav_grupo FOREIGN KEY(id_grupo) REFERENCES grupo(id_grupo) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT FK_clav_maest FOREIGN KEY(id_maestro) REFERENCES Maestro (clave_maestro) ON DELETE NO ACTION ON UPDATE NO ACTION
);



Create table Alumno(
no_control int not null  IDENTITY ,
nombre varchar (30),
edad int not null,
sexo char (1),
redsocial varchar (20),
id_grupo varchar (3),
foto image,
CONSTRAINT PK_alumno PRIMARY KEY(no_control),
CONSTRAINT FK_clav_alumno FOREIGN KEY(id_grupo) REFERENCES Grupo (id_grupo ) ON DELETE NO ACTION ON UPDATE NO ACTION
);

Create table toma(
clave_alumnoT int not null ,
clave_materiaT varchar(5) not null,

CONSTRAINT FK_clav_materias FOREIGN KEY(clave_materiaT) REFERENCES Materia(clave_materia) ON DELETE NO ACTION ON UPDATE NO ACTION,
 CONSTRAINT FK_clav_alumnos FOREIGN KEY(clave_alumnoT) REFERENCES Alumno(no_control) ON DELETE NO ACTION ON UPDATE NO ACTION
);
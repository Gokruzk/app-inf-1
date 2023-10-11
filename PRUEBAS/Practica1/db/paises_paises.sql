CREATE DATABASE `paises2`

CREATE TABLE `paises` (
  `idpaises` int NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) DEFAULT NULL,
  `alineacion` varchar(100) DEFAULT NULL,
  PRIMARY KEY (`idpaises`),
  UNIQUE KEY `nombre_UNIQUE` (`nombre`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

LOCK TABLES `paises` WRITE;
INSERT INTO `paises` VALUES (1,'ECUADOR','UNASUR'),(2,'Puerto Rico',''),(3,'Perú','');

UNLOCK TABLES;

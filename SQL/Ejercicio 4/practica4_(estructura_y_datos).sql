CREATE DATABASE IF NOT EXISTS `practica4` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `practica4`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: practica4
-- ------------------------------------------------------
-- Server version	5.5.5-10.1.13-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `cientifico`
--

DROP TABLE IF EXISTS `cientifico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cientifico` (
  `dni` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`dni`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cientifico`
--

LOCK TABLES `cientifico` WRITE;
/*!40000 ALTER TABLE `cientifico` DISABLE KEYS */;
INSERT INTO `cientifico` VALUES 
(12345678,'Dr. García López'),
(23456789,'Dra. Martínez Ruiz'),
(34567890,'Dr. Fernández Silva'),
(45678901,'Dra. González Pérez'),
(56789012,'Dr. Rodríguez Díaz'),
(67890123,'Dra. López Sánchez'),
(78901234,'Dr. Hernández Torres'),
(89012345,'Dra. Jiménez Moreno');
/*!40000 ALTER TABLE `cientifico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `proyecto`
--

DROP TABLE IF EXISTS `proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proyecto` (
  `id` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `horas` int(11) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proyecto`
--

LOCK TABLES `proyecto` WRITE;
/*!40000 ALTER TABLE `proyecto` DISABLE KEYS */;
INSERT INTO `proyecto` VALUES 
(1,'Investigación Genética',500),
(2,'Desarrollo de Vacunas',800),
(3,'Nanotecnología Médica',600),
(4,'Inteligencia Artificial',1000),
(5,'Energías Renovables',750),
(6,'Cambio Climático',900);
/*!40000 ALTER TABLE `proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cientifico_x_proyecto`
--

DROP TABLE IF EXISTS `cientifico_x_proyecto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cientifico_x_proyecto` (
  `idcientificoF` int(11) NOT NULL,
  `idproyectoF` int(11) NOT NULL,
  `horas` int(11) DEFAULT NULL,
  PRIMARY KEY (`idcientificoF`,`idproyectoF`),
  KEY `proyectoFK_idx` (`idproyectoF`),
  CONSTRAINT `cientificoFK` FOREIGN KEY (`idcientificoF`) REFERENCES `cientifico` (`dni`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `proyectoFK` FOREIGN KEY (`idproyectoF`) REFERENCES `proyecto` (`id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cientifico_x_proyecto`
--

LOCK TABLES `cientifico_x_proyecto` WRITE;
/*!40000 ALTER TABLE `cientifico_x_proyecto` DISABLE KEYS */;
INSERT INTO `cientifico_x_proyecto` VALUES 
(12345678,1,120),
(12345678,2,95),
(12345678,3,85),
(23456789,1,150),
(23456789,4,110),
(34567890,2,200),
(45678901,3,180),
(45678901,4,90),
(45678901,5,85),
(56789012,4,250),
(67890123,5,160),
(67890123,6,140),
(78901234,1,100),
(78901234,6,220),
(89012345,2,180),
(89012345,3,75),
(89012345,5,130);
/*!40000 ALTER TABLE `cientifico_x_proyecto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'practica4'
--

--
-- Dumping routines for database 'practica4'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-11  17:30:00
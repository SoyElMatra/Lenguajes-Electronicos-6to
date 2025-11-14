CREATE DATABASE IF NOT EXISTS `practica2` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `practica2`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: practica2
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
-- Table structure for table `proveedor`
--

DROP TABLE IF EXISTS `proveedor`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `proveedor` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(100) DEFAULT NULL,
  `ciudad` varchar(45) DEFAULT NULL,
  `telefono` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `proveedor`
--

LOCK TABLES `proveedor` WRITE;
/*!40000 ALTER TABLE `proveedor` DISABLE KEYS */;
INSERT INTO `proveedor` VALUES 
(1,'SICA','Calle Principal 123','Madrid','911234567'),
(2,'FERCOM','Av. Industrial 456','Barcelona','931234567'),
(3,'METALES DEL SUR','Polígono Norte 789','Sevilla','951234567'),
(4,'SUMINISTROS TECH','Calle Comercio 321','Valencia','961234567'),
(5,'DISTRIBUCIONES LOPEZ','Av. Europa 654','Bilbao','941234567');
/*!40000 ALTER TABLE `proveedor` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pieza`
--

DROP TABLE IF EXISTS `pieza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pieza` (
  `codigo` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `descripcion` varchar(100) DEFAULT NULL,
  `peso` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`codigo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pieza`
--

LOCK TABLES `pieza` WRITE;
/*!40000 ALTER TABLE `pieza` DISABLE KEYS */;
INSERT INTO `pieza` VALUES 
(10,'Tornillo M6','Tornillo métrico de 6mm',0.05),
(15,'Tuerca M6','Tuerca métrica de 6mm',0.03),
(20,'Arandela','Arandela plana 6mm',0.01),
(25,'Perno','Perno de acero inoxidable',0.15),
(30,'Clavo','Clavo de construcción',0.02),
(35,'Bisagra','Bisagra de puerta estándar',0.25),
(40,'Cerradura','Cerradura de seguridad',0.80),
(45,'Rodamiento','Rodamiento de bolas',0.12);
/*!40000 ALTER TABLE `pieza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suministro`
--

DROP TABLE IF EXISTS `suministro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `suministro` (
  `codigo_proveedor` int(11) NOT NULL,
  `codigo_pieza` int(11) NOT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  PRIMARY KEY (`codigo_proveedor`,`codigo_pieza`),
  KEY `piezaFK_idx` (`codigo_pieza`),
  CONSTRAINT `proveedorFK` FOREIGN KEY (`codigo_proveedor`) REFERENCES `proveedor` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `piezaFK` FOREIGN KEY (`codigo_pieza`) REFERENCES `pieza` (`codigo`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suministro`
--

LOCK TABLES `suministro` WRITE;
/*!40000 ALTER TABLE `suministro` DISABLE KEYS */;
INSERT INTO `suministro` VALUES 
(1,10,0.15,5000),
(1,15,0.12,3000),
(1,20,0.05,8000),
(1,30,0.08,4000),
(2,10,0.18,4500),
(2,25,0.45,2000),
(2,35,2.50,1500),
(2,45,3.80,800),
(3,10,0.12,6000),
(3,15,0.10,5000),
(3,40,15.50,500),
(4,20,0.06,7000),
(4,25,0.50,1800),
(4,30,0.09,3500),
(4,35,2.75,1200),
(5,10,0.14,5500),
(5,40,16.00,450),
(5,45,4.20,750);
/*!40000 ALTER TABLE `suministro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'practica2'
--

--
-- Dumping routines for database 'practica2'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-11  15:45:00
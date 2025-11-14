CREATE DATABASE IF NOT EXISTS `practica3` /*!40100 DEFAULT CHARACTER SET utf8 */;
USE `practica3`;
-- MySQL dump 10.13  Distrib 5.7.9, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: practica3
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
-- Table structure for table `zona`
--

DROP TABLE IF EXISTS `zona`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `zona` (
  `idZona` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`idZona`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `zona`
--

LOCK TABLES `zona` WRITE;
/*!40000 ALTER TABLE `zona` DISABLE KEYS */;
INSERT INTO `zona` VALUES 
(1,'Zona1'),
(2,'Zona2'),
(3,'Zona3'),
(4,'Zona4');
/*!40000 ALTER TABLE `zona` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `codCliente` int(11) NOT NULL,
  `nombre` varchar(45) DEFAULT NULL,
  `direccion` varchar(45) DEFAULT NULL,
  `codPostal` int(11) DEFAULT NULL,
  `telefono` varchar(45) DEFAULT NULL,
  `descuento` float DEFAULT NULL,
  `idZonaF` int(11) DEFAULT NULL,
  PRIMARY KEY (`codCliente`),
  KEY `zonaFK_idx` (`idZonaF`),
  CONSTRAINT `zonaFK` FOREIGN KEY (`idZonaF`) REFERENCES `zona` (`idZona`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES 
(1,'Pedro','Calle Mayor 45',28001,'911234567',5.0,1),
(2,'María','Av. Libertad 123',8002,'931234567',10.0,2),
(3,'Juan','Plaza España 67',41001,'951234567',5.0,1),
(4,'Ana','Calle Sol 89',46001,'961234567',15.0,3),
(5,'Luis','Av. Constitución 234',48001,'941234567',10.0,2),
(6,'Carmen','Calle Luna 12',28015,'911345678',5.0,1),
(7,'José','Av. Gran Vía 456',50001,'976234567',15.0,3),
(8,'Laura','Calle Flores 78',29001,'952234567',20.0,4),
(9,'Carlos','Plaza Mayor 34',28013,'911456789',5.0,1),
(10,'Elena','Av. del Mar 567',3001,'965234567',15.0,3);
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `articulo`
--

DROP TABLE IF EXISTS `articulo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `articulo` (
  `codArt` int(11) NOT NULL,
  `descripcion` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`codArt`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `articulo`
--

LOCK TABLES `articulo` WRITE;
/*!40000 ALTER TABLE `articulo` DISABLE KEYS */;
INSERT INTO `articulo` VALUES 
(100,'Laptop HP 15 pulgadas'),
(101,'Mouse Logitech inalámbrico'),
(102,'Teclado mecánico RGB'),
(103,'Monitor Samsung 24 pulgadas'),
(104,'Auriculares Sony inalámbricos'),
(105,'Webcam Logitech HD 1080p'),
(106,'Impresora Canon multifunción'),
(107,'Disco duro externo 1TB'),
(108,'Memoria USB 64GB'),
(109,'Router WiFi 6 TP-Link');
/*!40000 ALTER TABLE `articulo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido` (
  `numPedido` int(11) NOT NULL,
  `codClienteF` int(11) DEFAULT NULL,
  `codArtF` int(11) DEFAULT NULL,
  `unidades` int(11) DEFAULT NULL,
  `fechaPedido` date DEFAULT NULL,
  PRIMARY KEY (`numPedido`),
  KEY `clientePedidoFK_idx` (`codClienteF`),
  KEY `articuloPedidoFK_idx` (`codArtF`),
  CONSTRAINT `clientePedidoFK` FOREIGN KEY (`codClienteF`) REFERENCES `cliente` (`codCliente`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `articuloPedidoFK` FOREIGN KEY (`codArtF`) REFERENCES `articulo` (`codArt`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES 
(1001,1,100,1,'2024-01-15'),
(1002,1,101,2,'2024-01-15'),
(1003,1,108,3,'2024-02-20'),
(1004,3,103,2,'2024-02-25'),
(1005,3,106,1,'2024-03-10'),
(1006,1,102,1,'2024-03-18'),
(1007,4,104,3,'2024-04-05'),
(1008,2,103,1,'2024-04-22'),
(1009,1,104,1,'2024-05-08'),
(1010,6,100,1,'2024-06-12'),
(1011,7,102,2,'2024-06-25'),
(1012,7,107,5,'2024-07-10'),
(1013,3,101,4,'2024-07-22'),
(1014,9,103,2,'2024-08-15'),
(1015,9,106,1,'2024-08-15'),
(1016,1,107,3,'2024-09-05'),
(1017,4,101,5,'2024-09-20'),
(1018,1,109,2,'2024-10-12'),
(1019,9,108,10,'2024-10-25');
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Dumping events for database 'practica3'
--

--
-- Dumping routines for database 'practica3'
--
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-11-11  17:00:00
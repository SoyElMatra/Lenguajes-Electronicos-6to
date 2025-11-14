CREATE DATABASE  IF NOT EXISTS `le_tienda_en_linea` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */;
USE `le_tienda_en_linea`;
-- MariaDB dump 10.19  Distrib 10.4.20-MariaDB, for Win64 (AMD64)
--
-- Host: 127.0.0.1    Database: le_tienda_en_linea
-- ------------------------------------------------------
-- Server version	10.4.20-MariaDB

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
-- Table structure for table `cliente`
--

DROP TABLE IF EXISTS `cliente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `cliente` (
  `cliente_id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `apellido` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `correo` varchar(100) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `direccion` varchar(255) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `telefono` varchar(15) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `fecha_registro` timestamp NOT NULL DEFAULT current_timestamp(),
  PRIMARY KEY (`cliente_id`),
  UNIQUE KEY `correo` (`correo`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `cliente`
--

LOCK TABLES `cliente` WRITE;
/*!40000 ALTER TABLE `cliente` DISABLE KEYS */;
INSERT INTO `cliente` VALUES (1,'Juan','Pérez','juanperez@example.com','Calle Ficticia 123','123456789','2024-11-21 18:59:22'),(2,'Ana','Gómez','anagomez@example.com','Avenida Siempre Viva 456','987654321','2024-11-21 18:59:22'),(3,'Carlos','Martínez','carlosm@example.com','Calle Real 789','456123789','2024-11-21 18:59:22'),(4,'Laura','Fernández','lauraf@example.com','Calle Luna 321','123321456','2024-11-21 18:59:22'),(5,'Pedro','Gutiérrez','pedrog@example.com','Calle Sol 654','234567890','2024-11-21 18:59:22'),(6,'Marta','Ruiz','martar@example.com','Avenida de las Flores 111','345678901','2024-11-21 18:59:22'),(7,'Luis','Rodríguez','luisr@example.com','Calle del Mar 222','456789012','2024-11-21 18:59:22'),(8,'Sofía','Vega','sofia.vega@example.com','Calle Los Olivos 333','567890123','2024-11-21 18:59:22'),(9,'José','Hernández','joseh@example.com','Calle del Sol 444','678901234','2024-11-21 18:59:22'),(10,'María','Díaz','mariad@example.com','Avenida Pino 555','789012345','2024-11-21 18:59:22'),(11,'Clara','Moreno','claram@example.com','Calle de la Luna 999','890123456','2024-11-21 18:59:22'),(12,'Ricardo','Sánchez','ricardos@example.com','Avenida Los Pinos 777','901234567','2024-11-21 18:59:22'),(13,'Victor','Jiménez','victorj@example.com','Calle de las Palmas 888','102345678','2024-11-21 18:59:22'),(14,'Elena','Torres','elenat@example.com','Calle Mayor 666','113456789','2024-11-21 18:59:22'),(15,'Esteban','García','estebang@example.com','Avenida Central 123','124567890','2024-11-21 18:59:22'),(16,'Rosa','López','rosal@example.com','Calle Nueva 456','135678901','2024-11-21 18:59:22'),(17,'Pablo','Méndez','pablom@example.com','Calle del Árbol 789','146789012','2024-11-21 18:59:22'),(18,'Natalia','Suárez','natalias@example.com','Calle Verde 101','157890123','2024-11-21 18:59:22'),(19,'Fernando','Ruiz','fernando.r@example.com','Calle de las Flores 100','198765432','2024-11-21 18:59:22');
/*!40000 ALTER TABLE `cliente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `detalle_pedido`
--

DROP TABLE IF EXISTS `detalle_pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `detalle_pedido` (
  `detalle_id` int(11) NOT NULL AUTO_INCREMENT,
  `pedido_id` int(11) DEFAULT NULL,
  `producto_id` int(11) DEFAULT NULL,
  `cantidad` int(11) DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `subtotal` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`detalle_id`),
  KEY `pedido_id` (`pedido_id`),
  KEY `producto_id` (`producto_id`),
  CONSTRAINT `detalle_pedido_ibfk_1` FOREIGN KEY (`pedido_id`) REFERENCES `pedido` (`pedido_id`),
  CONSTRAINT `detalle_pedido_ibfk_2` FOREIGN KEY (`producto_id`) REFERENCES `producto` (`producto_id`)
) ENGINE=InnoDB AUTO_INCREMENT=21 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalle_pedido`
--

LOCK TABLES `detalle_pedido` WRITE;
/*!40000 ALTER TABLE `detalle_pedido` DISABLE KEYS */;
INSERT INTO `detalle_pedido` VALUES (1,1,1,1,1200.50,1200.50),(2,1,2,1,75.99,75.99),(3,2,3,2,20.75,41.50),(4,3,4,1,799.99,799.99),(5,4,5,2,329.99,659.98),(6,5,6,1,549.99,549.99),(7,6,7,2,299.99,599.98),(8,7,8,1,450.00,450.00),(9,8,9,1,150.00,150.00),(10,9,10,2,25.50,51.00),(11,10,11,1,350.00,350.00),(12,11,12,1,40.00,40.00),(13,12,13,2,119.99,239.98),(14,13,14,1,89.99,89.99),(15,14,15,1,45.00,45.00),(16,15,16,3,15.00,45.00),(17,16,17,2,129.99,259.98),(18,17,1,1,1305.00,1305.00),(19,18,2,1,1025.50,1025.50),(20,19,8,2,890.00,1780.00);
/*!40000 ALTER TABLE `detalle_pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pedido`
--

DROP TABLE IF EXISTS `pedido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `pedido` (
  `pedido_id` int(11) NOT NULL AUTO_INCREMENT,
  `cliente_id` int(11) DEFAULT NULL,
  `fecha` timestamp NOT NULL DEFAULT current_timestamp(),
  `estado` enum('pendiente','enviado','entregado','cancelado') COLLATE utf8mb4_unicode_ci DEFAULT 'pendiente',
  `total` decimal(10,2) DEFAULT NULL,
  PRIMARY KEY (`pedido_id`),
  KEY `cliente_id` (`cliente_id`),
  CONSTRAINT `pedido_ibfk_1` FOREIGN KEY (`cliente_id`) REFERENCES `cliente` (`cliente_id`)
) ENGINE=InnoDB AUTO_INCREMENT=20 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pedido`
--

LOCK TABLES `pedido` WRITE;
/*!40000 ALTER TABLE `pedido` DISABLE KEYS */;
INSERT INTO `pedido` VALUES (1,1,'2024-11-21 18:59:49','pendiente',1300.00),(2,2,'2024-11-21 18:59:49','pendiente',300.00),(3,3,'2024-11-21 18:59:49','pendiente',850.00),(4,4,'2024-11-21 18:59:49','pendiente',500.00),(5,5,'2024-11-21 18:59:49','pendiente',750.50),(6,6,'2024-11-21 18:59:49','pendiente',1150.25),(7,7,'2024-11-21 18:59:49','pendiente',1300.75),(8,8,'2024-11-21 18:59:49','pendiente',1050.00),(9,9,'2024-11-21 18:59:49','pendiente',625.50),(10,10,'2024-11-21 18:59:49','pendiente',850.00),(11,11,'2024-11-21 18:59:49','pendiente',950.00),(12,12,'2024-11-21 18:59:49','pendiente',420.25),(13,13,'2024-11-21 18:59:49','pendiente',1320.99),(14,14,'2024-11-21 18:59:49','pendiente',200.75),(15,15,'2024-11-21 18:59:49','pendiente',775.00),(16,16,'2024-11-21 18:59:49','pendiente',1190.10),(17,17,'2024-11-21 18:59:49','pendiente',600.00),(18,18,'2024-11-21 18:59:49','pendiente',1025.50),(19,19,'2024-11-21 18:59:49','pendiente',1305.00);
/*!40000 ALTER TABLE `pedido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `producto`
--

DROP TABLE IF EXISTS `producto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!40101 SET character_set_client = utf8 */;
CREATE TABLE `producto` (
  `producto_id` int(11) NOT NULL AUTO_INCREMENT,
  `nombre` varchar(150) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `descripcion` text COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  `precio` decimal(10,2) DEFAULT NULL,
  `stock` int(11) DEFAULT NULL,
  `categoria` varchar(50) COLLATE utf8mb4_unicode_ci DEFAULT NULL,
  PRIMARY KEY (`producto_id`)
) ENGINE=InnoDB AUTO_INCREMENT=18 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `producto`
--

LOCK TABLES `producto` WRITE;
/*!40000 ALTER TABLE `producto` DISABLE KEYS */;
INSERT INTO `producto` VALUES (1,'Laptop HP','Laptop HP de 15 pulgadas',1200.50,20,'Electrónica'),(2,'Teclado Mecánico','Teclado mecánico con retroiluminación RGB',75.99,50,'Accesorios'),(3,'Mouse Óptico','Mouse óptico ergonómico',20.75,100,'Accesorios'),(4,'Smartphone Samsung','Smartphone Samsung Galaxy',799.99,30,'Electrónica'),(5,'Tablet Apple','Tablet Apple iPad 10.2',329.99,40,'Electrónica'),(6,'Cámara Digital Sony','Cámara digital Sony Alpha 6000',549.99,15,'Electrónica'),(7,'Auriculares Bose','Auriculares Bose QC35',299.99,60,'Accesorios'),(8,'Monitor Dell','Monitor Dell UltraSharp 27',450.00,25,'Electrónica'),(9,'Silla Ergonómica','Silla ergonómica para oficina',150.00,40,'Mobiliario'),(10,'Soporte para Laptop','Soporte ajustable para laptop',25.50,70,'Accesorios'),(11,'Proyector Epson','Proyector Epson XGA',350.00,18,'Electrónica'),(12,'Mochila Gaming','Mochila para laptop gaming',40.00,85,'Accesorios'),(13,'Parlante JBL','Parlante bluetooth JBL Flip 5',119.99,55,'Accesorios'),(14,'Estabilizador','Estabilizador de voltaje',89.99,20,'Electrónica'),(15,'Disco Duro SSD','Disco duro SSD Kingston 500GB',45.00,110,'Electrónica'),(16,'Cargador Rápido','Cargador rápido para teléfonos',15.00,150,'Accesorios'),(17,'Teclado Logitech','Teclado mecánico Logitech G Pro',129.99,30,'Accesorios');
/*!40000 ALTER TABLE `producto` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-21 16:16:03

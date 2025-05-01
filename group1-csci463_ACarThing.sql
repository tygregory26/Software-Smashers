-- MySQL dump 10.13  Distrib 8.0.39, for Linux (x86_64)
--
-- Host: localhost    Database: group1-csci463_ACarThing
-- ------------------------------------------------------
-- Server version	8.0.39-0ubuntu0.22.04.1

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `Logs`
--

DROP TABLE IF EXISTS `Logs`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `Logs` (
  `logID` int NOT NULL AUTO_INCREMENT,
  `vehicleID` int DEFAULT NULL,
  `logEntry` varchar(255) DEFAULT NULL,
  `logType` varchar(50) DEFAULT NULL,
  `timeStamp` datetime DEFAULT CURRENT_TIMESTAMP,
  `notificationAllowed` tinyint(1) DEFAULT '1',
  PRIMARY KEY (`logID`),
  KEY `vehicleID` (`vehicleID`),
  CONSTRAINT `Logs_ibfk_1` FOREIGN KEY (`vehicleID`) REFERENCES `vehicle` (`carID`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `Logs`
--

LOCK TABLES `Logs` WRITE;
/*!40000 ALTER TABLE `Logs` DISABLE KEYS */;
/*!40000 ALTER TABLE `Logs` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `drivers`
--

DROP TABLE IF EXISTS `drivers`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `drivers` (
  `driverID` int NOT NULL AUTO_INCREMENT,
  `driverLink` int NOT NULL,
  `vehicleLink` int NOT NULL,
  PRIMARY KEY (`driverID`),
  UNIQUE KEY `driverID_UNIQUE` (`driverID`),
  KEY `DriverUser_idx` (`driverLink`),
  KEY `DriverVehicle_idx` (`vehicleLink`),
  CONSTRAINT `DriverUser` FOREIGN KEY (`driverLink`) REFERENCES `user` (`userID`),
  CONSTRAINT `DriverVehicle` FOREIGN KEY (`vehicleLink`) REFERENCES `vehicle` (`carID`)
) ENGINE=InnoDB AUTO_INCREMENT=6 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `drivers`
--

LOCK TABLES `drivers` WRITE;
/*!40000 ALTER TABLE `drivers` DISABLE KEYS */;
INSERT INTO `drivers` VALUES (1,1,1),(2,2,1),(4,1,1),(5,1,5);
/*!40000 ALTER TABLE `drivers` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `firstName` varchar(10) NOT NULL,
  `lastName` varchar(20) NOT NULL,
  `userID` int NOT NULL AUTO_INCREMENT,
  `email` varchar(50) NOT NULL,
  `phoneNumber` varchar(11) NOT NULL,
  `password` varchar(20) NOT NULL,
  `timeZone` varchar(50) DEFAULT 'UTC',
  `notificationsEnabled` tinyint(1) DEFAULT '1',
  `unitOfMeasurement` varchar(10) DEFAULT 'metric',
  `theme` varchar(20) DEFAULT 'light',
  PRIMARY KEY (`userID`),
  UNIQUE KEY `userID_UNIQUE` (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES ('Test','Testing',1,'test@test.com','17012345678','password','UTC',1,'metric','light'),('Johnny','Test',2,'mctest@test.com','17015557357','password','UTC',1,'metric','light'),('Ty','Gregory',3,'ty.com','701','imcool','UTC',1,'metric','light'),('Daisy','Codenys',6,'Daisy.Hensrud@und.edu','7012223333','pass','UTC',1,'metric','light'),('Fred','Frederson',7,'Fred427@email.com','7014279999','password','UTC',1,'metric','light'),('Test','McGee',8,'email.email.com','7012223333','','UTC',1,'metric','light');
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle` (
  `carID` int NOT NULL AUTO_INCREMENT,
  `make` varchar(30) NOT NULL,
  `model` varchar(30) NOT NULL,
  `year` varchar(4) NOT NULL,
  `vin` varchar(17) NOT NULL,
  `vehicleType` int NOT NULL,
  `batteryLevel` float DEFAULT NULL,
  `fuelLevel` float DEFAULT NULL,
  `oilLevel` float DEFAULT NULL,
  `engineTemp` float DEFAULT NULL,
  `ownerID` int DEFAULT NULL,
  `carName` varchar(30) DEFAULT NULL,
  `windowsUp` tinyint(1) DEFAULT '1',
  `isStarted` tinyint(1) DEFAULT '0',
  `doorsLocked` tinyint(1) DEFAULT '1',
  `alarmArmed` tinyint(1) DEFAULT '0',
  PRIMARY KEY (`carID`,`vin`),
  UNIQUE KEY `carID_UNIQUE` (`carID`),
  UNIQUE KEY `vin_UNIQUE` (`vin`),
  KEY `ownerID_idx` (`ownerID`),
  CONSTRAINT `vehicleOwner` FOREIGN KEY (`ownerID`) REFERENCES `user` (`userID`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=latin1;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES (1,'Jeep','Wrangler','2022','1234567891234567',0,NULL,0.67,0.82,82,1,'NewCarName',1,1,1,1),(2,'Ford','F150','2020','1FTFW1EF1EKE11111',1,75,50,0.8,190,1,'Ty’s Truck',1,0,1,0),(3,'Honda','Accord','2005','WhateverIWant',1,75,50,0.8,190,1,'Ty’s Car',1,0,1,0),(4,'Ford','Escape','2018','1234567890234576',2,86,74,0.93,87,2,'Testmobile',1,0,1,0),(5,'Bus','Magic','1994','withthefrizznoway',2,0.42,0.34,0.45,0.98,1,'Magic School Bus',1,0,1,1);
/*!40000 ALTER TABLE `vehicle` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2025-05-01  9:16:47

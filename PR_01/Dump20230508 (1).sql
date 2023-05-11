-- MySQL dump 10.13  Distrib 8.0.33, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: ws_014
-- ------------------------------------------------------
-- Server version	5.7.24

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `category`
--

DROP TABLE IF EXISTS `category`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `category` (
  `idProductCategory` int(11) NOT NULL AUTO_INCREMENT,
  `Category` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idProductCategory`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `category`
--

LOCK TABLES `category` WRITE;
/*!40000 ALTER TABLE `category` DISABLE KEYS */;
INSERT INTO `category` VALUES (1,'Постельные ткани'),(2,'Детские ткани'),(3,'Ткани для изделий');
/*!40000 ALTER TABLE `category` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `manufacturer`
--

DROP TABLE IF EXISTS `manufacturer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `manufacturer` (
  `idProductManufacturer` int(11) NOT NULL AUTO_INCREMENT,
  `ProductManufacturer` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idProductManufacturer`)
) ENGINE=InnoDB AUTO_INCREMENT=5 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `manufacturer`
--

LOCK TABLES `manufacturer` WRITE;
/*!40000 ALTER TABLE `manufacturer` DISABLE KEYS */;
INSERT INTO `manufacturer` VALUES (1,'БТК Текстиль'),(2,'Комильфо'),(3,'Май Фабрик'),(4,'Империя ткани');
/*!40000 ALTER TABLE `manufacturer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orderproduct`
--

DROP TABLE IF EXISTS `orderproduct`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orderproduct` (
  `OrderProductID` int(11) NOT NULL AUTO_INCREMENT,
  `ProductName` varchar(25) COLLATE utf8_unicode_ci NOT NULL,
  `ClientsName` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `Count` int(11) NOT NULL,
  `OrderPosts` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`OrderProductID`),
  KEY `ProductArticleNumber` (`ClientsName`),
  KEY `orderp_order` (`ProductName`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orderproduct`
--

LOCK TABLES `orderproduct` WRITE;
/*!40000 ALTER TABLE `orderproduct` DISABLE KEYS */;
INSERT INTO `orderproduct` VALUES (1,'1','2',32,''),(2,'1','3',2,''),(3,'sdfghnjm','qswedrtyhr',2,'3'),(4,'Ткань поплин «Натурель»','2',2,'ул., Комсомольская, 26'),(5,'Поплин Мокко','Емельянова Алина Алексеевна',1,'ул., Набережная, 30'),(6,'Поплин Мокко','Емельянова Алина Алексеевна',1,'ул., Набережная, 30'),(7,'Плюш розовый гладкий','Дьяконова Елена Ивановна',4,'ул., Комсомольская, 26'),(8,'Фланель черная','Мировнова Анастасия Ивановна',3,'ул., Партизанская, 49'),(9,'Поплин Морская волна','Мезенцева Мария Ивановна',2,'ул.,Садовая, 4');
/*!40000 ALTER TABLE `orderproduct` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `OrderID` int(11) NOT NULL AUTO_INCREMENT,
  `OrderDeliveryDate` datetime NOT NULL,
  `OrderPickupPoint` int(11) NOT NULL,
  `OrderBookingDate` datetime NOT NULL,
  `OrderReciveCode` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `OrderUserId` int(11) DEFAULT NULL,
  PRIMARY KEY (`OrderID`),
  KEY `order_posts_idx` (`OrderPickupPoint`),
  KEY `order_user_idx` (`OrderUserId`),
  CONSTRAINT `order_USER` FOREIGN KEY (`OrderUserId`) REFERENCES `user` (`UserID`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `order_posts` FOREIGN KEY (`OrderPickupPoint`) REFERENCES `posts` (`idposts`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=12 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (1,'2013-05-20 22:00:00',1,'2013-05-20 22:00:00','123',1),(2,'2013-05-20 22:00:00',1,'2013-05-20 22:00:00','124',1),(3,'2013-05-20 22:00:00',1,'2013-05-20 22:00:00','121',1),(4,'2013-05-20 22:00:00',1,'2013-05-20 22:00:00','121',1),(11,'2013-05-20 22:00:00',1,'2013-05-20 22:00:00','121',1);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `posts`
--

DROP TABLE IF EXISTS `posts`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `posts` (
  `idposts` int(11) NOT NULL AUTO_INCREMENT,
  `City` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  `House` int(11) NOT NULL,
  `Street` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `IndexCity` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idposts`)
) ENGINE=InnoDB AUTO_INCREMENT=37 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `posts`
--

LOCK TABLES `posts` WRITE;
/*!40000 ALTER TABLE `posts` DISABLE KEYS */;
INSERT INTO `posts` VALUES (1,'Кропоткин',1,'Чехова','344288'),(2,'Кропоткин',30,'Степная','614164'),(3,'Кропоткин',43,'Коммунистическая','394242'),(4,'Кропоткин',25,'Солнечная','660540'),(5,'Кропоткин',40,'Шоссейная','125837'),(6,'Кропоткин',49,'Партизанская','125703'),(7,'Кропоткин',46,'Победы','625283'),(8,'Кропоткин',50,'Молодежная','614611'),(9,'Кропоткин',19,'Новая','454311'),(10,'Кропоткин',19,'Октябрьская','660007'),(11,'Кропоткин',4,'Садовая','603036'),(12,'Кропоткин',26,'Комсомольская','450983'),(13,'Кропоткин',3,'Чехова','394782'),(14,'Кропоткин',28,'Дзержинского','603002'),(15,'Кропоткин',30,'Набережная','450558'),(16,'Кропоткин',43,'Фрунзе','394060'),(17,'Кропоткин',50,' Школьная','410661'),(18,'Кропоткин',3,'Коммунистическая','625590'),(19,'Кропоткин',32,'8 Марта','625683'),(20,'Кропоткин',47,'Зеленая','400562'),(21,'Кропоткин',46,'Маяковского','614510'),(22,'Кропоткин',8,'Светлая','410542 '),(23,'Кропоткин',1,'Цветочная','620839'),(24,'Кропоткин',46,'Коммунистическая','443890'),(25,'Кропоткин',41,'Спортивная','603379'),(26,'Кропоткин',13,'Гоголя','603721'),(27,'Кропоткин',32,' Северная','410172'),(28,'Кропоткин',8,'Вишневая','420151'),(29,'Кропоткин',24,'Подгорная','125061'),(30,'Кропоткин',35,'Шоссейная','630370'),(31,'Кропоткин',44,'Полевая','614753'),(32,'Кропоткин',44,'Маяковского','426030'),(33,'Кропоткин',12,'Клубная','450375'),(34,'Кропоткин',17,'Некрасова','625560'),(35,'Кропоткин',26,'Комсомольская','630201'),(36,'Кропоткин',5,'Мичурина','190949');
/*!40000 ALTER TABLE `posts` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `product`
--

DROP TABLE IF EXISTS `product`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `product` (
  `ProductArticleNumber` varchar(100) CHARACTER SET utf8 NOT NULL,
  `ProductName` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductDescription` text COLLATE utf8_unicode_ci NOT NULL,
  `ProductCategory` int(11) NOT NULL,
  `ProductPhoto` varchar(50) COLLATE utf8_unicode_ci DEFAULT NULL,
  `ProductManufacturer` int(11) NOT NULL,
  `ProductCost` decimal(19,4) NOT NULL,
  `ProductDiscountAmount` tinyint(4) NOT NULL,
  `ProductQuantityInStock` int(11) NOT NULL,
  `UnitOfMeasurement` int(11) NOT NULL,
  `ProductSupplier` int(11) NOT NULL,
  `ProductMaxDiscountAmount` tinyint(4) NOT NULL,
  `ProductID` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`ProductID`),
  KEY `Prod_category_idx` (`ProductCategory`),
  KEY `Prod_manufacturer_idx` (`ProductManufacturer`),
  KEY `Prod_supplier_idx` (`ProductSupplier`),
  KEY `Prod_unitofmeasurement_idx` (`UnitOfMeasurement`),
  CONSTRAINT `Prod_category` FOREIGN KEY (`ProductCategory`) REFERENCES `category` (`idProductCategory`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prod_manufacturer` FOREIGN KEY (`ProductManufacturer`) REFERENCES `manufacturer` (`idProductManufacturer`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prod_supplier` FOREIGN KEY (`ProductSupplier`) REFERENCES `supplier` (`idSupplier`) ON DELETE NO ACTION ON UPDATE NO ACTION,
  CONSTRAINT `Prod_unitofmeasurement` FOREIGN KEY (`UnitOfMeasurement`) REFERENCES `unitofmeasurement` (`idUnitOfMeasurement`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB AUTO_INCREMENT=32 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `product`
--

LOCK TABLES `product` WRITE;
/*!40000 ALTER TABLE `product` DISABLE KEYS */;
INSERT INTO `product` VALUES ('B111C5','Поплин «Розовый жемчуг»','Поплин «Розовый жемчуг» шириной 220 см с изображением на ткани — крупные цветы, чайная роза; цветовая гамма: бледно-розовая.',1,'B111C5.JPEG',1,8500.0000,4,6,1,1,5,2),('E112C6','Муслин «Bej»','Муслин «Bej» однотонный шириной 140+/-5 см с изображением на ткани — однотонный; цветовая гамма: кофе с молоком.',2,'E112C6.JPG',4,10500.0000,3,13,1,2,15,3),('T238C7','Муслин «Gri»','Муслин «Gri» однотонный шириной 140+/-5 см с изображением на ткани — однотонный; цветовая гамма: серая.',2,'T238C7.JPG',1,6500.0000,2,12,1,2,15,4),('M112C8','Бязь детская «Совята»','Бязь детская «Совята» шириной 150 см с изображением на ткани — совы; цветовая гамма: бордо, желтая, салатовая.',2,'M112C8.JPG',4,26000.0000,2,14,1,1,20,5),('M294G9','Полотно вафельное «8 марта»','Полотно вафельное «8 марта» шириной 50 см с изображением на ткани — белые розы; цветовая гамма: розовая.',3,'M294G9.JPG',4,5130.0000,2,1,1,1,5,6),('N283K3','Сатин «Миндальный» однотонный','Сатин «Миндальный» однотонный шириной 250 см с изображением на ткани цветовая гамма: миндаль. ',1,'N283K3.JPG',2,6500.0000,3,7,1,1,5,7),('L293S9','Плюш розовый гладкий','Плюш розовый гладкий шириной 180 см с изображением на ткани — однотонный; цветовая гамма: однотонная, розовая.',2,'L293S9.JPG',2,30000.0000,3,2,1,1,40,8),('M398S9','Поплин Мокко','Поплин Мокко 220 см шириной 220 см с изображением на ткани — однотонное; цветовая гамма: коричневая, кофе, шоколад.',1,'M398S9.JPG',3,1800.0000,2,6,1,3,15,9),('S384K2','Фланель черная','Фланель черная оптом шириной 90 см с изображением на ткани — однотонное; цветовая гамма: черная.',3,'S384K2.JPG',1,69000.0000,4,2,1,3,40,10),('K839K3','Плюш белый в клетку','Плюш белый в клетку шириной 180 см с изображением на ткани — клетка, однотонный; цветовая гамма: белая, однотонная.',2,'K839K3.JPG ',4,765.0000,2,3,1,3,5,11),('D938K3','Фланель однотонная светлая','Фланель однотонная светлая оптом шириной 90 см с изображением на ткани — однотонное; цветовая гамма: голубая, желтая, розовая, сирень, фисташка.',3,'',3,1300.0000,4,10,1,3,10,12),('R748K3','Поплин Морская волна','Поплин Морская волна 220 см шириной 220 см с изображением на ткани — однотонное; цветовая гамма: аквамарин, бирюзовая.',1,'',3,2300.0000,2,6,1,3,15,13),('C384D8','Сатин «Дымчатая роза» однотонный','Сатин «Дымчатая роза» однотонный шириной 250 см с изображением на ткани цветовая гамма: розовый зефир.',1,'',4,1133.0000,3,4,1,1,10,14),('F374S8','Фланель рубашечная','Фланель рубашечная шириной 150 см с изображением на ткани — клетка; цветовая гамма: светло-коричневая, синий-королевский.',3,'',1,2100.0000,2,5,1,1,5,15),('W874J3','Ткань поплин «Натурель»','Ткань поплин «Натурель» шириной 220 см с изображением на ткани — мелкие цветы; цветовая гамма: пепельная, розовая. ',1,'',1,1600.0000,3,9,1,3,5,16),('Z937S2','Поплин Голубой','Поплин Голубой 220 см шириной 220 см с изображением на ткани — однотонное; цветовая гамма: голубая.',1,'',1,9000.0000,2,15,1,1,10,17),('Q836H4','Фланель рубашечная','Фланель арт 535 рубашечная шириной 150 см с изображением на ткани — клетка; цветовая гамма: светло-коричневая, синий-королевский.',3,'',3,1350.0000,4,7,1,1,5,18),('H483D9','Фланель детская H483D9','Фланель детская 21212-2 шириной 90 см с изображением на ткани — россыпь звездочек; цветовая гамма: баклажан, оранжевый, розовая.',2,'',2,318.0000,2,18,1,2,5,19),('O947D8','Ткань для скатертей под рогожку','Ткань для скатертей под рогожку «рис 18825» шириной 150 см с изображением на ткани — ромашки, россыпь цветов; цветовая гамма: красная, синяя.',3,'',3,3550.0000,3,9,1,2,10,20),('R983K4','Сатин «Серо-бежевый» однотонный','Сатин «Серо-бежевый» однотонный шириной 250 см с изображением на ткани цветовая гамма: серо-бежевая.',1,'',4,1645.0000,2,13,1,2,15,21),('U947E9','Муслин белый горошек на однотонном фоне','Муслин белый горошек на однотонном фоне шириной 150 см с изображением на ткани — мелкий горошек; цветовая гамма: желтая.',2,'',4,3411.0000,3,4,1,3,10,22),('H497J3','Ситец детский','Ситец детский шириной 95 см с изображением на ткани — котята, сердечки; цветовая гамма: белоземельная, оранжевый.',2,'',1,523.0000,2,8,1,3,5,23),('N394K2','Ткань поплин «Лакшери»','Ткань поплин «Лакшери» шириной 220 см с изображением на ткани — надписи, сердечки; цветовая гамма: белая, красная, черная. ',1,'',4,30660.0000,4,15,1,2,10,24),('P495H8','Поплин «Густав»','Поплин «Густав» шириной 220 см с изображением на ткани — листья, папортник; цветовая гамма: зеленая, светло-серая.',1,'',2,1000.0000,2,14,1,1,15,25),('X846D3','Ситец детский','Ситец детский шириной 95 см с изображением на ткани — жираф, полумесяц, пчелки; цветовая гамма: темно-фиолетовая.',2,'',4,9300.0000,3,5,1,1,25,26),('N385L2','Сатин «Фисташковый» однотонный','Сатин «Фисташковый» однотонный шириной 250 см с изображением на ткани цветовая гамма: фисташка.',1,'',1,7000.0000,2,2,1,3,20,27),('V378J3','Ситец детский','Ситец детский шириной 95 см с изображением на ткани — котенок, облака, полумесяц, радуга; цветовая гамма: бледно-розовая, голубая, салатовая, серо-бежевая.',2,'',2,2400.0000,3,14,1,3,15,28),('K284U8','Бязь детская «Самолеты»','Бязь детская «Самолеты» шириной 150 см с изображением на ткани — игрушки, самолетики; цветовая гамма: белая, зеленая, синяя. ',2,'',4,5100.0000,3,2,1,3,25,29),('N387I8','Полотно вафельное «Кухня»','Полотно вафельное «Кухня» шириной 50 см с изображением на ткани — кухня; цветовая гамма: желтая, малина. ',3,'',1,1000.0000,3,5,1,2,15,30),('I483H3','Ткань поплин «Вивьен»','Ткань поплин «Вивьен» шириной 220 см с изображением на ткани — горошек; цветовая гамма: синяя, фисташка.',1,'',1,11300.0000,2,5,1,2,10,31);
/*!40000 ALTER TABLE `product` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `role`
--

DROP TABLE IF EXISTS `role`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `role` (
  `RoleID` int(11) NOT NULL AUTO_INCREMENT,
  `RoleName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `role`
--

LOCK TABLES `role` WRITE;
/*!40000 ALTER TABLE `role` DISABLE KEYS */;
INSERT INTO `role` VALUES (1,'Admin'),(2,'Meneger'),(3,'Client');
/*!40000 ALTER TABLE `role` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `supplier`
--

DROP TABLE IF EXISTS `supplier`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `supplier` (
  `idSupplier` int(11) NOT NULL AUTO_INCREMENT,
  `Supplier` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idSupplier`)
) ENGINE=InnoDB AUTO_INCREMENT=4 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `supplier`
--

LOCK TABLES `supplier` WRITE;
/*!40000 ALTER TABLE `supplier` DISABLE KEYS */;
INSERT INTO `supplier` VALUES (1,'Раута '),(2,'ООО Афо-Тек'),(3,'ГК Петров');
/*!40000 ALTER TABLE `supplier` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `unitofmeasurement`
--

DROP TABLE IF EXISTS `unitofmeasurement`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `unitofmeasurement` (
  `idUnitOfMeasurement` int(11) NOT NULL AUTO_INCREMENT,
  `UnitOfMeasurement` varchar(45) COLLATE utf8_unicode_ci NOT NULL,
  PRIMARY KEY (`idUnitOfMeasurement`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `unitofmeasurement`
--

LOCK TABLES `unitofmeasurement` WRITE;
/*!40000 ALTER TABLE `unitofmeasurement` DISABLE KEYS */;
INSERT INTO `unitofmeasurement` VALUES (1,'Рулоны');
/*!40000 ALTER TABLE `unitofmeasurement` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `user`
--

DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
  `UserID` int(11) NOT NULL AUTO_INCREMENT,
  `UserSurname` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `UserName` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `UserPatronymic` varchar(100) COLLATE utf8_unicode_ci NOT NULL,
  `UserLogin` text COLLATE utf8_unicode_ci NOT NULL,
  `UserPassword` text COLLATE utf8_unicode_ci NOT NULL,
  `UserRole` int(11) NOT NULL,
  PRIMARY KEY (`UserID`),
  KEY `UserRole` (`UserRole`),
  CONSTRAINT `user_ibfk_1` FOREIGN KEY (`UserRole`) REFERENCES `role` (`RoleID`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (1,'Лавров','Богдан','Львович','8lf0g@yandex.ru','2L6KZG',1),(2,'Смирнова','Полина','Фёдоровна','1zx8@yandex.ru','uzWC67',1),(3,'Полякова','София','Данииловна','x@mail.ru','8ntwUp',1),(4,'Чеботарева',' Марина','Данииловна','34d@gmail.com','YOyhfR',2),(5,'Ермолов','Адам','Иванович','pxacl@mail.ru','RSbvHv',2),(6,'Васильев','Андрей','Кириллович','7o1@gmail.com','rwVDh9',2),(7,'Маслов','Максим','Иванович','1@gmail.com','LdNyos',3),(8,'Симонов','Михаил','Тимурович','iut@gmail.com','gynQMT',3),(9,'Павлова','Ксения','Михайловна','e3t@outlook.com','AtnDjr',3),(10,'Трифонов','Григорий','Юрьевич','41clb6o2g@yandex.ru','JlFRCZ',3),(11,'1','1','1','1','1',1),(12,'sdfg','dfgh','sdfgh','2','2',2),(13,'sdfghjh','asdfghjuhytr','sdfgds','3','3',3);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2023-05-08 20:43:19

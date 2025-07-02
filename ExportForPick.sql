-- MySQL dump 10.13  Distrib 8.0.36, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: pizza_proj
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.32-MariaDB

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
-- Table structure for table `addr`
--

DROP TABLE IF EXISTS `addr`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `addr` (
  `addr_id` int(11) NOT NULL,
  `road` varchar(45) DEFAULT NULL,
  `place` varchar(45) DEFAULT NULL,
  `city` varchar(45) DEFAULT NULL,
  `zipcode` varchar(6) DEFAULT NULL,
  `tel` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`addr_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `addr`
--

LOCK TABLES `addr` WRITE;
/*!40000 ALTER TABLE `addr` DISABLE KEYS */;
INSERT INTO `addr` VALUES (1,'ถนนราชสีมา','ศาลากลางจังหวัดนครราชสีมา','นครราชสีมา','30000','0454854846'),(2,'ถนนมุขรม','สวนสัตว์นครราชสีมา','นครราชสีมา','30000','0541485416'),(3,'ถนนเจริญเมือง','ตลาดเซ็นทรัลพลาซ่าโคราช','นครราชสีมา','30000','0985516616'),(4,'ถนนสืบสิริ','โรงพยาบาลมหาราชนครราชสีมา','นครราชสีมา','30000','0954516513'),(5,'ถนนสุรนารายณ์','มหาวิทยาลัยเทคโนโลยีสุรนารายณ์โรจน์','นครราชสีมา','30000','0615159596'),(6,'ถนนมุขรม','สวนสัตว์โคราชเปิดเขาเขียว','นครราชสีมา','30280','0915156123'),(7,'ถนนมิตรภาพ','ห้างสรรพสินค้าเดอะมอลล์โคราช','นครราชสีมา','30000','0811564848'),(8,'ถนนธนพล','สนามบินนครราชสีมา','นครราชสีมา','30000','0816559562'),(9,'ถนนประสานมิตร','วัดพระศรีมหาธาตุ','นครราชสีมา','30000','0951515152'),(10,'ถนนจอหอ','สวนสสาธารณะทุ่งสัมฤทธิ์','นครราชสีมา','30000','0626226591'),(11,'ถนนมุขรม','สถานีรถไฟนครราชสีมา','นครราชสีมา','30000','0926561515'),(12,'ถนนช้างเผือก','โรงเรียนสุรนารีวิทยาลัย','นครราชสีมา','30000','0915615152'),(13,'ถนนสืบสิริ','ห้างสรรพสินค้าเซ็นทรัลเฟสติวัลโคราช','นครราชสีมา','30000','0915165185'),(14,'ถนนสรรพสิทธิ์','วิทยาลัยการอาชีพนครราชสีมา 2','นครราชสีมา','30280','0915154615'),(15,'ถนนสุรนารายณ์','มหาวิทยาลัยราชภัฏนครราชสีมา','นครราชสีมา','30310','0821616622'),(16,'ถนนสืบสิริ','โรงพยาบาลมหาวิทยาลัยเทคโนโลยีสุรนารายณ์โรจน์','นครราชสีมา','30310','0865262626'),(17,'ถนนมุขรม','ห้างสรรพสินค้าเทอร์มินอล 21 โคราช','นครราชสีมา','30320','0648599599'),(18,'ถนนราชสีมา','ห้างสรรพสินค้าโลตัสโคราช','นครราชสีมา','30000','0648184126'),(19,'ถนนสุรนารายณ์','มหาวิทยาลัยขอนแก่น วิทยาเขตนครราชสีมา','นครราชสีมา','30000','0942757678'),(20,'ถนนเจริญเมือง','ตลาดไนท์บาซาร์โคราช','นครราชสีมา','30000','0915498456'),(21,'ราชสีมา','333/234','korat','30000','0985853581');
/*!40000 ALTER TABLE `addr` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `customer`
--

DROP TABLE IF EXISTS `customer`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `customer` (
  `customer_id` int(11) NOT NULL AUTO_INCREMENT,
  `username` varchar(45) NOT NULL,
  `addr_id` int(11) DEFAULT NULL,
  `password` varchar(45) NOT NULL,
  `firstname` varchar(45) DEFAULT NULL,
  `lastname` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`customer_id`),
  KEY `addr_id_idx` (`addr_id`),
  CONSTRAINT `addr_id` FOREIGN KEY (`addr_id`) REFERENCES `addr` (`addr_id`)
) ENGINE=InnoDB AUTO_INCREMENT=22 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `customer`
--

LOCK TABLES `customer` WRITE;
/*!40000 ALTER TABLE `customer` DISABLE KEYS */;
INSERT INTO `customer` VALUES (1,'user1',1,'password1','ประวิทย์ ','ศรีสุข'),(2,'user2',2,'password2','วิภาดา ','สุขสันต์'),(3,'user3',3,'password3','สุวิจักษณ์ ','สุขใจ'),(4,'user4',4,'password4','วิภาวดี ','สุขสวัสดิ์'),(5,'user5',5,'password5','ประวิตร ','สุขภาพ'),(6,'user6',6,'password6','วิภาวี ','สุขสม'),(7,'user7',7,'password7','วิภาวัฒน์ ','สุขภา'),(8,'user8',8,'password8','สุวิทย์ ','สุขใจ'),(9,'user9',9,'password9','วิภาวัณย์ ','สุขสวัสดิ์'),(10,'user10',10,'password10','สมร','สุขสม'),(11,'user11',11,'password11','สุภาวัณย์ ','สุขสวัสดิ์'),(12,'user12',12,'password12','วัณย์ภพ ','เบื่อโลก'),(13,'user13',13,'password13','กังวาล ','ดอมดม'),(14,'user14',14,'password14','พงษ์ภพ ','ดีทอง'),(15,'user15',15,'password15','อนาจรย์ ','สุงสิงห์'),(16,'user16',16,'password16','โชคดี ','มันหวาน'),(17,'user17',17,'password17','สดศรี ','ฟันฟอง'),(18,'user18',18,'password18','ไพรพร ','บันชิต'),(19,'user19',19,'password19','ลาวัลย์ ','พอเพียง'),(20,'user20',20,'password20','กรณ์วิทย์ ','ชินจัง'),(21,'Lee',21,'111111','Sippakorn','Bunyu');
/*!40000 ALTER TABLE `customer` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `employee`
--

DROP TABLE IF EXISTS `employee`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `employee` (
  `e_id` int(11) NOT NULL,
  `e_firstname` varchar(45) DEFAULT NULL,
  `e_lastname` varchar(45) DEFAULT NULL,
  `tel` varchar(45) DEFAULT NULL,
  `position` varchar(45) DEFAULT NULL,
  `salary` decimal(8,2) DEFAULT NULL,
  `status` varchar(10) DEFAULT NULL,
  PRIMARY KEY (`e_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `employee`
--

LOCK TABLES `employee` WRITE;
/*!40000 ALTER TABLE `employee` DISABLE KEYS */;
INSERT INTO `employee` VALUES (1,'สิปปกร','บุญอยู่','0956441652','chef',35000.00,'active'),(2,'จีรพล','เดชโฮม','0909115354','admin',20000.00,'active'),(3,'บูรณาการ','เมืองรี','0985461524','driver',20000.00,'active'),(4,'ปณิสรา','ควรดี','0854625632','driver',15000.00,'active'),(5,'เสกสรร','แอ้นแคน','0642747954','driver',15000.00,'active'),(6,'ง่วง','มากมาก','0694206912','driver',15000.00,'active'),(7,'เบื่อโปรเจ็ค','สุด','0987833','driver',3000.00,'active');
/*!40000 ALTER TABLE `employee` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `in_basket`
--

DROP TABLE IF EXISTS `in_basket`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `in_basket` (
  `b_id` int(11) NOT NULL AUTO_INCREMENT,
  `quantity` int(11) DEFAULT NULL,
  `o_id` int(11) DEFAULT NULL,
  `menu_id` int(11) NOT NULL,
  PRIMARY KEY (`b_id`),
  KEY `o_id_idx` (`o_id`),
  KEY `menu_id_idx` (`menu_id`),
  CONSTRAINT `menu_id` FOREIGN KEY (`menu_id`) REFERENCES `menu` (`menu_id`),
  CONSTRAINT `o_id` FOREIGN KEY (`o_id`) REFERENCES `orders` (`o_id`)
) ENGINE=InnoDB AUTO_INCREMENT=299 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `in_basket`
--

LOCK TABLES `in_basket` WRITE;
/*!40000 ALTER TABLE `in_basket` DISABLE KEYS */;
INSERT INTO `in_basket` VALUES (277,6,149,1),(278,3,NULL,1),(280,3,153,1),(281,6,154,1),(282,6,154,4),(283,3,155,31),(284,3,155,37),(291,9,158,13),(294,6,160,7),(295,12,160,11),(296,9,161,25),(297,6,161,31),(298,6,161,35);
/*!40000 ALTER TABLE `in_basket` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `menu`
--

DROP TABLE IF EXISTS `menu`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `menu` (
  `menu_id` int(11) NOT NULL,
  `menu_name` varchar(45) NOT NULL,
  `size` varchar(45) DEFAULT NULL,
  `price` decimal(8,2) DEFAULT NULL,
  PRIMARY KEY (`menu_id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `menu`
--

LOCK TABLES `menu` WRITE;
/*!40000 ALTER TABLE `menu` DISABLE KEYS */;
INSERT INTO `menu` VALUES (1,'Pizza Lovers Supreme     s','s',120.00),(2,'Pizza Lovers Supreme     m','m',150.00),(3,'Pizza Lovers Supreme     s','l',175.00),(4,'Pizza Ka Prao Chicken     s','s',120.00),(5,'Pizza Ka Prao Chicken     m','m',158.00),(6,'Pizza Ka Prao Chicken     l','l',180.00),(7,'Pizza Chicken Duo           s','s',125.00),(8,'Pizza Chicken Duo           m','m',154.00),(9,'Pizza Chicken Duo            l','l',189.00),(10,'Pizza Sausage Island       s','s',125.00),(11,'Pizza Sausage Island       m','m',155.00),(12,'Pizza Sausage Island       l','l',185.00),(13,'Pizza Seafood                  s','s',126.00),(14,'Pizza Seafood                  m','m',156.00),(15,'Pizza Seafood                  l','l',186.00),(16,'Pizza Tomyum Seafood    s','s',127.00),(17,'Pizza Tomyum Seafood    m','m',157.00),(18,'Pizza Tomyum Seafood    l','l',187.00),(19,'Pizza Spinach Cheese      s','s',119.00),(20,'Pizza Spinach Cheese      m','m',149.00),(21,'Pizza Spinach Cheese      l','l',175.00),(22,'Pizza Pork Parade            s','s',125.00),(23,'Pizza Pork Parade            m','m',157.00),(24,'Pizza Pork Parade            l','l',185.00),(25,'Pizza Massaman               s','s',126.00),(26,'Pizza Massaman               m','m',156.00),(27,'Pizza Massaman               l','l',186.00),(28,'Pizza Hawaiian                 s','s',124.00),(29,'Pizza Hawaiian                 m','m',157.00),(30,'Pizza Hawaiian                 l','l',186.00),(31,'french fries                      s','s',35.00),(32,'french fries                      m','m',55.00),(33,'french fries                      l','l',75.00),(34,'pepsi 1 L                         ',NULL,30.00),(35,'pepsi 410 ml.',NULL,15.00),(36,'Pepsi can 245 ml.',NULL,14.00),(37,'spaghetti',NULL,75.00),(38,'New Orleans Fried Chicken',NULL,120.00),(39,'vegetable salad	',NULL,79.00),(40,'water',NULL,10.00);
/*!40000 ALTER TABLE `menu` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `orders`
--

DROP TABLE IF EXISTS `orders`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `orders` (
  `o_id` int(11) NOT NULL AUTO_INCREMENT,
  `customer_id` int(11) DEFAULT NULL,
  `total_price` decimal(10,2) DEFAULT NULL,
  `employee_id` int(11) DEFAULT NULL,
  `vehicle_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`o_id`),
  KEY `customer_id_idx` (`customer_id`),
  KEY `employee_id_idx` (`employee_id`),
  KEY `vehicle_id_idx` (`vehicle_id`),
  CONSTRAINT `customer_id` FOREIGN KEY (`customer_id`) REFERENCES `customer` (`customer_id`) ON DELETE CASCADE,
  CONSTRAINT `employee_id` FOREIGN KEY (`employee_id`) REFERENCES `employee` (`e_id`),
  CONSTRAINT `vehicle_id` FOREIGN KEY (`vehicle_id`) REFERENCES `vehicle` (`v_id`)
) ENGINE=InnoDB AUTO_INCREMENT=162 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `orders`
--

LOCK TABLES `orders` WRITE;
/*!40000 ALTER TABLE `orders` DISABLE KEYS */;
INSERT INTO `orders` VALUES (149,21,720.00,2,4),(150,21,NULL,NULL,NULL),(151,21,NULL,NULL,NULL),(152,21,NULL,NULL,NULL),(153,21,360.00,2,1),(154,21,1440.00,2,3),(155,21,330.00,NULL,NULL),(158,21,1134.00,2,4),(160,21,2610.00,2,3),(161,21,1434.00,2,2);
/*!40000 ALTER TABLE `orders` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `vehicle`
--

DROP TABLE IF EXISTS `vehicle`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `vehicle` (
  `v_id` int(11) NOT NULL,
  `type` varchar(45) DEFAULT NULL,
  `licence` varchar(45) DEFAULT NULL,
  `e_id` int(11) DEFAULT NULL,
  PRIMARY KEY (`v_id`),
  KEY `e_id_idx` (`e_id`),
  CONSTRAINT `e_id` FOREIGN KEY (`e_id`) REFERENCES `employee` (`e_id`) ON DELETE NO ACTION ON UPDATE NO ACTION
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `vehicle`
--

LOCK TABLES `vehicle` WRITE;
/*!40000 ALTER TABLE `vehicle` DISABLE KEYS */;
INSERT INTO `vehicle` VALUES (1,'motorcycle','กข  ,นครราชศรีมา ,11   ',3),(2,'motorcycle','นน   ,นครราชศรีมา ,88 ',4),(3,'motorcycle','1 กก  ,นครราชศรีมา ,648  ',5),(4,'motorcycle','งง  ,นครราชศรีมา  ,116',6),(5,'motorcycle','งง  ,นครราชศรีมา  ,155',7);
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

-- Dump completed on 2024-06-04  1:23:33

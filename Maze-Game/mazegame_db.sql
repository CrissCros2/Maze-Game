-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 27, 2021 at 01:13 PM
-- Server version: 5.7.31
-- PHP Version: 7.3.21

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `mazegame_db`
--

-- --------------------------------------------------------

--
-- Table structure for table `fivegamescores_tbl`
--

DROP TABLE IF EXISTS `fivegamescores_tbl`;
CREATE TABLE IF NOT EXISTS `fivegamescores_tbl` (
  `scoreid` int(20) NOT NULL AUTO_INCREMENT,
  `userid` int(20) NOT NULL,
  `score` int(20) NOT NULL,
  `scoredate` date NOT NULL,
  PRIMARY KEY (`scoreid`),
  KEY `userid` (`userid`)
) ENGINE=MyISAM AUTO_INCREMENT=58 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `fivegamescores_tbl`
--

INSERT INTO `fivegamescores_tbl` (`scoreid`, `userid`, `score`, `scoredate`) VALUES
(1, 2, 170, '2021-03-12'),
(2, 2, 23, '2021-03-16'),
(49, 1, 2, '2021-03-23'),
(4, 2, 26, '2021-03-16'),
(5, 2, 109, '2021-03-16'),
(6, 2, 21, '2021-03-16'),
(7, 2, 45, '2021-03-16'),
(8, 2, 87, '2021-03-16'),
(9, 2, 2, '2021-03-16'),
(10, 2, 1, '2021-03-16'),
(11, 2, 0, '2021-03-16'),
(12, 2, 0, '2021-03-16'),
(13, 2, 65, '2021-03-16'),
(14, 2, 78, '2021-03-16'),
(15, 2, 1, '2021-03-16'),
(16, 2, 0, '2021-03-16'),
(17, 2, 3, '2021-03-16'),
(18, 2, 67, '2021-03-16'),
(19, 2, 234, '2021-03-16'),
(20, 2, 65, '2021-03-16'),
(21, 2, 89, '2021-03-16'),
(22, 2, 2, '2021-03-16'),
(23, 2, 65, '2021-03-16'),
(24, 2, 27, '2021-03-16'),
(25, 2, 39, '2021-03-16'),
(26, 2, 12, '2021-03-16'),
(27, 2, 10, '2021-03-16'),
(28, 2, 9, '2021-03-16'),
(29, 2, 103, '2021-03-16'),
(48, 1, 1, '2021-03-23'),
(35, 7, 28, '2021-03-18'),
(47, 1, 0, '2021-03-23'),
(33, 2, 12, '2021-03-16'),
(34, 2, 56, '2021-03-16'),
(36, 7, 7, '2021-03-18'),
(37, 7, 2, '2021-03-18'),
(38, 7, 5, '2021-03-18'),
(39, 7, 9, '2021-03-18'),
(40, 7, 69, '2021-03-18'),
(51, 1, 4, '2021-03-23'),
(50, 1, 3, '2021-03-23'),
(43, 7, 200, '2021-03-18'),
(44, 7, 13, '2021-03-18'),
(45, 7, 199, '2021-03-18'),
(46, 7, 23, '2021-03-18'),
(52, 1, 5, '2021-03-23'),
(53, 1, 6, '2021-03-23'),
(54, 1, 7, '2021-03-23'),
(55, 1, 8, '2021-03-23'),
(56, 1, 9, '2021-03-23'),
(57, 1, 10, '2021-03-23');

-- --------------------------------------------------------

--
-- Table structure for table `tengamescores_tbl`
--

DROP TABLE IF EXISTS `tengamescores_tbl`;
CREATE TABLE IF NOT EXISTS `tengamescores_tbl` (
  `scoreid` int(20) NOT NULL AUTO_INCREMENT,
  `userid` int(20) NOT NULL,
  `score` int(20) NOT NULL,
  `scoredate` date NOT NULL,
  PRIMARY KEY (`scoreid`),
  KEY `userid` (`userid`)
) ENGINE=MyISAM AUTO_INCREMENT=23 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `tengamescores_tbl`
--

INSERT INTO `tengamescores_tbl` (`scoreid`, `userid`, `score`, `scoredate`) VALUES
(1, 3, 34, '2021-03-16'),
(2, 3, 205, '2021-03-16'),
(4, 3, 12, '2021-03-16'),
(5, 3, 34, '2021-03-16'),
(6, 3, 0, '2021-03-16'),
(7, 3, 2, '2021-03-16'),
(8, 3, 67, '2021-03-16'),
(9, 3, 32, '2021-03-16'),
(11, 3, 23, '2021-03-16'),
(12, 3, 23, '2021-03-16'),
(13, 3, 76, '2021-03-16'),
(14, 3, 123, '2021-03-16'),
(15, 3, 245, '2021-03-16'),
(16, 3, 1, '2021-03-16'),
(17, 3, 0, '2021-03-16'),
(18, 3, 0, '2021-03-16'),
(19, 3, 34, '2021-03-16'),
(20, 3, 2, '2021-03-16'),
(21, 3, 7, '2021-03-16'),
(22, 3, 1, '2021-03-16');

-- --------------------------------------------------------

--
-- Table structure for table `threegamescores_tbl`
--

DROP TABLE IF EXISTS `threegamescores_tbl`;
CREATE TABLE IF NOT EXISTS `threegamescores_tbl` (
  `scoreid` int(20) NOT NULL AUTO_INCREMENT,
  `userid` int(20) NOT NULL,
  `score` int(20) NOT NULL,
  `scoredate` date NOT NULL,
  PRIMARY KEY (`scoreid`),
  KEY `userid` (`userid`)
) ENGINE=MyISAM AUTO_INCREMENT=72 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `threegamescores_tbl`
--

INSERT INTO `threegamescores_tbl` (`scoreid`, `userid`, `score`, `scoredate`) VALUES
(1, 1, 0, '2021-03-12'),
(2, 2, 108, '2021-03-12'),
(3, 3, 2, '2021-03-12'),
(4, 2, 12, '2021-03-05'),
(5, 3, 16, '2021-03-12'),
(6, 5, 96, '2021-03-16'),
(7, 1, 4, '2021-03-16'),
(40, 1, 2, '2021-03-16'),
(39, 1, 3, '2021-03-16'),
(52, 1, 116, '2021-03-18'),
(37, 1, 45, '2021-03-16'),
(36, 1, 23, '2021-03-16'),
(35, 1, 3, '2021-03-16'),
(34, 1, 7, '2021-03-16'),
(33, 1, 3, '2021-03-16'),
(32, 1, 56, '2021-03-16'),
(31, 1, 1, '2021-03-16'),
(30, 1, 43, '2021-03-16'),
(19, 1, 2, '2021-03-16'),
(20, 1, 3, '2021-03-16'),
(21, 1, 6, '2021-03-16'),
(22, 1, 23, '2021-03-16'),
(23, 1, 56, '2021-03-16'),
(24, 1, 1, '2021-03-16'),
(25, 1, 34, '2021-03-16'),
(26, 1, 0, '2021-03-16'),
(27, 1, 23, '2021-03-16'),
(28, 1, 54, '2021-03-16'),
(29, 1, 3, '2021-03-16'),
(41, 7, 0, '2021-03-18'),
(42, 7, 0, '2021-03-18'),
(43, 7, 5, '2021-03-18'),
(44, 7, 23, '2021-03-18'),
(45, 7, 1, '2021-03-18'),
(46, 7, 67, '2021-03-18'),
(47, 7, 23, '2021-03-18'),
(48, 7, 4, '2021-03-18'),
(49, 7, 0, '2021-03-18'),
(50, 7, 1, '2021-03-18'),
(51, 7, 2, '2021-03-18'),
(53, 1, 110, '2021-03-19'),
(54, 1, 0, '2021-03-19'),
(55, 1, 2, '2021-03-23'),
(56, 1, 0, '2021-03-23'),
(57, 1, 12, '2021-03-23'),
(58, 1, 1, '2021-03-23'),
(59, 1, 2, '2021-03-23'),
(60, 1, 3, '2021-03-23'),
(61, 1, 4, '2021-03-23'),
(62, 1, 5, '2021-03-23'),
(63, 1, 6, '2021-03-23'),
(64, 1, 7, '2021-03-23'),
(65, 1, 8, '2021-03-23'),
(66, 1, 9, '2021-03-23'),
(67, 1, 24, '2021-03-23'),
(68, 1, 26, '2021-03-23'),
(69, 1, 0, '2021-04-27');

-- --------------------------------------------------------

--
-- Table structure for table `users_tbl`
--

DROP TABLE IF EXISTS `users_tbl`;
CREATE TABLE IF NOT EXISTS `users_tbl` (
  `userid` int(20) NOT NULL AUTO_INCREMENT,
  `username` varchar(20) NOT NULL,
  `password` varchar(64) NOT NULL,
  `firstname` varchar(20) NOT NULL,
  `email` varchar(40) NOT NULL,
  `passwordreset` varchar(20) DEFAULT NULL,
  `salt` varchar(64) NOT NULL,
  PRIMARY KEY (`userid`)
) ENGINE=MyISAM AUTO_INCREMENT=12 DEFAULT CHARSET=latin1;

--
-- Dumping data for table `users_tbl`
--

INSERT INTO `users_tbl` (`userid`, `username`, `password`, `firstname`, `email`, `passwordreset`, `salt`) VALUES
(1, 'Chris', '434B509E57CA9882032BB0E9030CBDA8F415256F77AF470F67A2E848252B66ED', 'Chris', 'chrisroberts1080@gmail.com', NULL, 'EAC41FE933E875B27CC97416D3A25F9DB9FB8D62C6E7B6A39EE3AB6F6EF3A61D'),
(2, 'Emerana', '9ADA6CE62305646FE13AAD6E8DE2B316D64284BD082A12F2625325AFA248D7E6', 'Oana', 'littlejimmy123@gmail.com', NULL, '59427231C4E1F28288C60EEB08A04FBE6C2C7F746BF10232D1E6E0D1E8DF6F4A'),
(3, 'ThePizza', '4479E1CB0D6212980799CAD17E095EFE73CC24A48F3B486526B519484956804D', 'Aaron', 'aaron.syposz@gmail.com', NULL, '77F9A836F68DCA99EDBAA63125D16B4C23543396CFFBEC44E31F478D44192191'),
(7, 'GannersJr', '35A85603FF34809AAD522FD893884DED4F18E0E4B0C85D05E7454F0C23BA74F3', 'Dylan', 'dylangannaway@outlook.com', NULL, '06C66D72AACCB7F1DF1712A40CB83538B285434EA7EDED6B5DC4A117A691E39B'),
(5, 'Echo', 'DAE78801396A159897B6300357A239A19BD4DA05F4D65F31E422D9CEBF41FBC4', 'Isabelle', 'izzydanquah99@gmail.com', NULL, '63699CEDD12B38483D23546F26A2F6F6A36347C61AEACA2AA3FEE0F0BB6E2703'),
(6, 'simmonne', 'CA2CD9FDEF69B3545F17287A04FF42385387F9416CF06C7F6C05C42A54EF3A89', 'Nomis', 'simon.mydliar@outlook.com', NULL, '3709AE3C59A40A040A26B4113D05D3C13F7C67B154A642F4E0552F4EF257AE70'),
(8, 'JohnSmith', 'CC97822AEFAC7FDAA42838E7EA7B365F421B973D4BD3DC2FA3B8CEB77F1958D3', 'John', 'robertschr@denbigh.net', NULL, 'CA456B523E4A8B0896BA703D485D1301BB3E97C519CEA8D1E540F24D20734089'),
(11, 'Test1', '9186E192CD2701DA896BA9D8B94DBE071D4C85CDCA6354814A7E5A12E4A4BBAF', 'Test', 'robertschr@denbigh.net', '451219622812643', 'D85DC53F8C0E7DDF249385C6BB5F56DA5D871C2B49381B9DA096236A1F64C963');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

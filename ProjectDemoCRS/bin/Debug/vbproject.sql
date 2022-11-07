-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3306
-- Generation Time: Oct 26, 2022 at 12:30 PM
-- Server version: 5.7.36
-- PHP Version: 7.4.26

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `vbproject`
--

-- --------------------------------------------------------

--
-- Table structure for table `student`
--

DROP TABLE IF EXISTS `student`;
CREATE TABLE IF NOT EXISTS `student` (
  `matricNumber` varchar(20) NOT NULL,
  `icNumber` varchar(20) NOT NULL,
  `name` varchar(100) NOT NULL,
  `course` varchar(100) NOT NULL,
  `dateOfBirth` varchar(100) NOT NULL,
  `gender` varchar(100) NOT NULL,
  `email` varchar(100) NOT NULL,
  `phoneNumber` varchar(100) NOT NULL,
  `address1` varchar(100) NOT NULL,
  `address2` varchar(100) NOT NULL,
  `city` varchar(100) NOT NULL,
  `district` varchar(100) NOT NULL,
  `state` varchar(100) NOT NULL,
  `groupId` varchar(100) NOT NULL,
  PRIMARY KEY (`matricNumber`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `studentgrouptbl`
--

DROP TABLE IF EXISTS `studentgrouptbl`;
CREATE TABLE IF NOT EXISTS `studentgrouptbl` (
  `groupId` varchar(100) NOT NULL,
  `groupName` varchar(100) NOT NULL,
  `groupLevel` varchar(100) NOT NULL,
  `maximumStudent` varchar(100) NOT NULL,
  PRIMARY KEY (`groupId`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `subject`
--

DROP TABLE IF EXISTS `subject`;
CREATE TABLE IF NOT EXISTS `subject` (
  `subjectCode` varchar(100) NOT NULL,
  `subjectName` varchar(100) NOT NULL,
  `credit` int(100) NOT NULL,
  PRIMARY KEY (`subjectCode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `subject`
--

INSERT INTO `subject` (`subjectCode`, `subjectName`, `credit`) VALUES
('DDWD3908', 'LATIHAN INDUSTRI', 8),
('DDWD3914', 'LAPORAN LATIHAN INDUSTRI', 4);

-- --------------------------------------------------------

--
-- Table structure for table `subjectregister`
--

DROP TABLE IF EXISTS `subjectregister`;
CREATE TABLE IF NOT EXISTS `subjectregister` (
  `subjectCode` varchar(100) NOT NULL,
  `matricNumber` varchar(100) NOT NULL,
  PRIMARY KEY (`subjectCode`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `usertbl`
--

DROP TABLE IF EXISTS `usertbl`;
CREATE TABLE IF NOT EXISTS `usertbl` (
  `userName` varchar(100) NOT NULL,
  `password` varchar(100) NOT NULL,
  `userLevel` varchar(100) NOT NULL,
  PRIMARY KEY (`userName`)
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `usertbl`
--

INSERT INTO `usertbl` (`userName`, `password`, `userLevel`) VALUES
('tancheesen', '123456', 'student'),
('yapdehkai', '12345', 'student'),
('shaza', '12345', 'student'),
('amirah', '12345', 'student');
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 3.5.2.2
-- http://www.phpmyadmin.net
--
-- Host: 127.0.0.1
-- Generation Time: Mar 11, 2013 at 03:05 PM
-- Server version: 5.5.27
-- PHP Version: 5.4.7

SET SQL_MODE="NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Database: `movieDB`
--

-- --------------------------------------------------------

--
-- Table structure for table `actor`
--

CREATE TABLE IF NOT EXISTS `actor` (
  `SSN` int(10) unsigned NOT NULL,
  `filmID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`SSN`,`filmID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `director`
--

CREATE TABLE IF NOT EXISTS `director` (
  `SSN` int(10) unsigned NOT NULL,
  `filmID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`SSN`,`filmID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `genre`
--

CREATE TABLE IF NOT EXISTS `genre` (
  `filmID` int(10) unsigned NOT NULL,
  `genre` enum('Action','Adventure','Animation','Biography','Comedy','Crime','Documentary','Drama','Fantasy','Horror','Musical','Romance','Sci-Fi','Sport','Thriller','War') NOT NULL,
  PRIMARY KEY (`filmID`,`genre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `likes`
--

CREATE TABLE IF NOT EXISTS `likes` (
  `SSN` int(10) unsigned NOT NULL,
  `genre` enum('Action','Adventure','Animation','Biography','Comedy','Crime','Documentary','Drama','Fantasy','Horror','Musical','Romance','Sci-Fi','Sport','Thriller','War') NOT NULL,
  PRIMARY KEY (`SSN`,`genre`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `movie`
--

CREATE TABLE IF NOT EXISTS `movie` (
  `filmID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Title` varchar(50) NOT NULL,
  `year` year(4) NOT NULL,
  `Avg_rating` float NOT NULL DEFAULT '0',
  `Description` varchar(100) NOT NULL DEFAULT 'No description',
  PRIMARY KEY (`filmID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `movie_review`
--

CREATE TABLE IF NOT EXISTS `movie_review` (
  `filmID` int(10) unsigned NOT NULL,
  `SSN` int(10) unsigned NOT NULL,
  `Text` varchar(100) DEFAULT 'Review not present',
  `Rating` float unsigned DEFAULT '0',
  PRIMARY KEY (`filmID`,`SSN`),
  KEY `SSN` (`SSN`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `now_playing`
--

CREATE TABLE IF NOT EXISTS `now_playing` (
  `TID` int(10) unsigned NOT NULL,
  `filmID` int(10) unsigned NOT NULL,
  `date` date NOT NULL,
  `time` time NOT NULL,
  PRIMARY KEY (`TID`,`filmID`),
  KEY `filmID` (`filmID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `person`
--

CREATE TABLE IF NOT EXISTS `person` (
  `SSN` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Fname` varchar(20) NOT NULL,
  `Lname` varchar(20) NOT NULL,
  `gender` enum('male','female') DEFAULT NULL,
  PRIMARY KEY (`SSN`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `recommend`
--

CREATE TABLE IF NOT EXISTS `recommend` (
  `SSN` int(10) unsigned NOT NULL,
  `filmID` int(10) unsigned NOT NULL,
  PRIMARY KEY (`SSN`,`filmID`),
  KEY `filmID` (`filmID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `theater`
--

CREATE TABLE IF NOT EXISTS `theater` (
  `TID` int(10) unsigned NOT NULL AUTO_INCREMENT,
  `Name` varchar(30) NOT NULL,
  `City` varchar(20) NOT NULL,
  PRIMARY KEY (`TID`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1 AUTO_INCREMENT=1 ;

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE IF NOT EXISTS `user` (
  `SSN` int(10) unsigned NOT NULL,
  `Username` varchar(15) NOT NULL,
  `Password` varchar(100) NOT NULL,
  PRIMARY KEY (`SSN`,`Username`),
  UNIQUE KEY `Username` (`Username`)
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `actor`
--
ALTER TABLE `actor`
  ADD CONSTRAINT `actor_ibfk_1` FOREIGN KEY (`SSN`) REFERENCES `person` (`SSN`) ON UPDATE CASCADE;

--
-- Constraints for table `director`
--
ALTER TABLE `director`
  ADD CONSTRAINT `director_ibfk_1` FOREIGN KEY (`SSN`) REFERENCES `person` (`SSN`) ON UPDATE CASCADE;

--
-- Constraints for table `genre`
--
ALTER TABLE `genre`
  ADD CONSTRAINT `genre_ibfk_1` FOREIGN KEY (`filmID`) REFERENCES `movie` (`filmID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `likes`
--
ALTER TABLE `likes`
  ADD CONSTRAINT `likes_ibfk_1` FOREIGN KEY (`SSN`) REFERENCES `user` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `movie_review`
--
ALTER TABLE `movie_review`
  ADD CONSTRAINT `movie_review_ibfk_2` FOREIGN KEY (`SSN`) REFERENCES `user` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `movie_review_ibfk_1` FOREIGN KEY (`filmID`) REFERENCES `movie` (`filmID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `now_playing`
--
ALTER TABLE `now_playing`
  ADD CONSTRAINT `now_playing_ibfk_2` FOREIGN KEY (`filmID`) REFERENCES `movie` (`filmID`) ON UPDATE CASCADE,
  ADD CONSTRAINT `now_playing_ibfk_1` FOREIGN KEY (`TID`) REFERENCES `theater` (`TID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `recommend`
--
ALTER TABLE `recommend`
  ADD CONSTRAINT `recommend_ibfk_1` FOREIGN KEY (`SSN`) REFERENCES `user` (`SSN`) ON DELETE CASCADE ON UPDATE CASCADE,
  ADD CONSTRAINT `recommend_ibfk_2` FOREIGN KEY (`filmID`) REFERENCES `movie` (`filmID`) ON DELETE CASCADE ON UPDATE CASCADE;

--
-- Constraints for table `user`
--
ALTER TABLE `user`
  ADD CONSTRAINT `user_ibfk_1` FOREIGN KEY (`SSN`) REFERENCES `person` (`SSN`) ON UPDATE CASCADE;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

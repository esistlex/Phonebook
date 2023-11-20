-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 20, 2023 at 05:43 PM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.2.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `phonebook`
--

-- --------------------------------------------------------

--
-- Table structure for table `contactlist`
--

CREATE TABLE `contactlist` (
  `USERID` int(11) NOT NULL,
  `USER_NAME` varchar(128) NOT NULL,
  `USER_ADDRESS` varchar(128) NOT NULL,
  `USER_STATE` varchar(32) NOT NULL,
  `USER_ZIPCODE` int(4) NOT NULL,
  `USER_COUNTRY` varchar(32) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `contactlist`
--

INSERT INTO `contactlist` (`USERID`, `USER_NAME`, `USER_ADDRESS`, `USER_STATE`, `USER_ZIPCODE`, `USER_COUNTRY`) VALUES
(1, 'sample', 'sample', 'sample', 1400, 'sample'),
(12, 'sample2', 'sample2', 'sample2', 123, 'sample2'),
(13, 'sample3', 'sample3', 'sample3', 123, 'sample3'),
(14, 'sample4', 'sample4', 'sample4', 123, 'sample4'),
(15, 'sample5nainiba', 'sample5nainiba', 'sample5nainiba', 123123, 'sample5nainiba'),
(16, 'sample6', 'sample6', 'sample6', 123, 'sample6');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `contactlist`
--
ALTER TABLE `contactlist`
  ADD PRIMARY KEY (`USERID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `contactlist`
--
ALTER TABLE `contactlist`
  MODIFY `USERID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

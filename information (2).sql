-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Sep 03, 2025 at 06:54 AM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `atmdb`
--

-- --------------------------------------------------------

--
-- Table structure for table `information`
--

CREATE TABLE `information` (
  `UserID` int(255) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `AccountNumber` int(10) NOT NULL,
  `PIN` int(6) NOT NULL,
  `Balance` int(250) NOT NULL,
  `Access` enum('Admin','Customer') NOT NULL,
  `Attempts` int(3) NOT NULL,
  `Status` enum('Active','Deactivated') NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `information`
--

INSERT INTO `information` (`UserID`, `Username`, `AccountNumber`, `PIN`, `Balance`, `Access`, `Attempts`, `Status`) VALUES
(1, 'Taniega', 1000000001, 456987, 0, 'Admin', 3, 'Active'),
(2, 'Hans', 1696969692, 993467, 0, 'Admin', 3, 'Active'),
(3, 'Rydner', 101010101, 897948, 0, 'Admin', 3, 'Active'),
(4, 'Joshua', 1234567891, 123456, 10000, 'Customer', 3, 'Active'),
(5, 'Caleb ', 1000000002, 123825, 200, 'Customer', 3, 'Active');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `information`
--
ALTER TABLE `information`
  ADD PRIMARY KEY (`UserID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `information`
--
ALTER TABLE `information`
  MODIFY `UserID` int(255) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

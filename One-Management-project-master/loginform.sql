-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 24, 2023 at 05:37 PM
-- Server version: 10.4.27-MariaDB
-- PHP Version: 8.1.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `loginform`
--

-- --------------------------------------------------------

--
-- Table structure for table `acompanyinfo`
--

CREATE TABLE `acompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` varchar(10) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `acompanyinfo`
--

INSERT INTO `acompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `LastLogin`) VALUES
(1, 'Mahesh', 'Vistara', 'Vistara@gmail.com', '7778882220', '15-Dec-22 5:59:56 PM'),
(2, 'Tanay', 'Tanay', 'Tanay@gmail.com', '1234567890', '25-Dec-22 6:05:48 PM'),
(3, 'Swati', 'BlueBird', 'BlueBird@gmail.com', '9876543201', '');

-- --------------------------------------------------------

--
-- Table structure for table `bcompanyinfo`
--

CREATE TABLE `bcompanyinfo` (
  `ID` int(11) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `bcompanyinfo`
--

INSERT INTO `bcompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `LastLogin`) VALUES
(1, 'MSRTC', 'MSRTC', 'MSRTC@gmail.com', 2147483647, '18-Dec-22 12:19:09 PM'),
(2, 'Tanay Puranik', 'Ruta Ltd', 'Ruta@gmail.com', 1234509875, '');

-- --------------------------------------------------------

--
-- Table structure for table `customer`
--

CREATE TABLE `customer` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `customer`
--

INSERT INTO `customer` (`ID`, `Name`, `Gender`, `Email`, `Password`, `LastLogin`) VALUES
(1, 'Tanay', 'Male', 'tanay.puranik2002@gmail.com', 'Tanay', '08-Jan-23 8:39:21 PM'),
(2, 'vinay', 'Male', 'vinay@gmail.com', '12345', '');

-- --------------------------------------------------------

--
-- Table structure for table `gcompanyinfo`
--

CREATE TABLE `gcompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `gcompanyinfo`
--

INSERT INTO `gcompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `LastLogin`) VALUES
(1, 'JCB', 'JCB', 'JCB@gmail.com', 1234598760, '17-Jan-23 9:52:39 AM'),
(2, 'Swati', 'Priya Private Ltd', 'Priya@gmail.com', 2147483647, '');

-- --------------------------------------------------------

--
-- Table structure for table `rcompanyinfo`
--

CREATE TABLE `rcompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `rcompanyinfo`
--

INSERT INTO `rcompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `LastLogin`) VALUES
(1, 'Tanay Puranik', 'TanayP', 'Tanay@gmail.com', 12345789, '17-Dec-22 11:20:22 AM'),
(2, 'TanayP', 'Monk', 'Tanay1@gmail.com', 2147483647, '15-Dec-22 12:12:28 PM'),
(3, 'TMP', 'TMP', 'TMP@gmail.com', 2147483647, '15-Dec-22 11:16:19 AM'),
(4, 'Tan', 'Tan', 'Tan@gmail.com', 2147483647, '17-Jan-23 9:49:47 AM');

-- --------------------------------------------------------

--
-- Table structure for table `scompanyinfo`
--

CREATE TABLE `scompanyinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `CompanyName` varchar(100) NOT NULL,
  `Email` varchar(100) NOT NULL,
  `Phone` int(10) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `scompanyinfo`
--

INSERT INTO `scompanyinfo` (`ID`, `Name`, `CompanyName`, `Email`, `Phone`, `LastLogin`) VALUES
(1, 'Tanay', 'Tas', 'Tanay@gmail.com', 123456789, '15-Dec-22 6:00:30 PM'),
(2, 'Tan', 'Tan', 'Tan@gmail.com', 1234567890, '23-Dec-22 6:01:46 PM');

-- --------------------------------------------------------

--
-- Table structure for table `userinfo`
--

CREATE TABLE `userinfo` (
  `ID` int(100) NOT NULL,
  `Name` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `UserName` varchar(100) NOT NULL,
  `Email` varchar(50) NOT NULL,
  `Password` varchar(50) NOT NULL,
  `LastLogin` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `userinfo`
--

INSERT INTO `userinfo` (`ID`, `Name`, `Gender`, `UserName`, `Email`, `Password`, `LastLogin`) VALUES
(1, 'Tanay', 'Male', 'Tanay', 'Tanay@gmail.com', '0', '27-Dec-22 9:07:46 AM'),
(2, 'Tanay1', 'Female', 'Tanay1', 'Tanay1@gmail.com', '0', '18-Dec-22 12:14:54 PM'),
(3, 'Tanay2', 'Male', 'Tanay2', 'Tanay2@gmail.com', 'Tanay2', '15-Dec-22 12:08:34 PM'),
(4, 'Mahesh', 'Male', 'Mahesh', 'Mahesh@gmail.com', 'Mahesh', '20-Dec-22 6:22:56 PM'),
(5, 'Swati', 'Female', 'Swati', 'Swati@gmail.com', 'Swati', ''),
(6, 'vinay', 'Male', 'vinay24', 'vinay@gmail.com', '12345', '');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `acompanyinfo`
--
ALTER TABLE `acompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `bcompanyinfo`
--
ALTER TABLE `bcompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `customer`
--
ALTER TABLE `customer`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `gcompanyinfo`
--
ALTER TABLE `gcompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `rcompanyinfo`
--
ALTER TABLE `rcompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `scompanyinfo`
--
ALTER TABLE `scompanyinfo`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `userinfo`
--
ALTER TABLE `userinfo`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `acompanyinfo`
--
ALTER TABLE `acompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `bcompanyinfo`
--
ALTER TABLE `bcompanyinfo`
  MODIFY `ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `customer`
--
ALTER TABLE `customer`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `gcompanyinfo`
--
ALTER TABLE `gcompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `rcompanyinfo`
--
ALTER TABLE `rcompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `scompanyinfo`
--
ALTER TABLE `scompanyinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `userinfo`
--
ALTER TABLE `userinfo`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

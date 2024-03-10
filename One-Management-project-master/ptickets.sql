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
-- Database: `ptickets`
--

-- --------------------------------------------------------

--
-- Table structure for table `patickets`
--

CREATE TABLE `patickets` (
  `ID` int(100) NOT NULL,
  `PassengerName` varchar(100) NOT NULL,
  `PassengerAge` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `NoOfSeats` int(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `JourneyDate` varchar(100) NOT NULL,
  `TicketCost` int(100) NOT NULL,
  `UserMobile` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `patickets`
--

INSERT INTO `patickets` (`ID`, `PassengerName`, `PassengerAge`, `Gender`, `NoOfSeats`, `Source`, `Destination`, `JourneyDate`, `TicketCost`, `UserMobile`) VALUES
(1, 'Tanay', '19', 'Male', 1, 'Mumbai', 'Delhi', '26-Dec-22 12:00:00 AM', 1300, 1234567890),
(2, 'Tanay', '20', 'Male', 1, 'Chhatrapati Shivaji International Airport – BOM	Mumbai, Maharashtra', 'Kansai                          Japan', '26-Dec-22 12:00:00 AM', 21344, 98765321);

-- --------------------------------------------------------

--
-- Table structure for table `pbtickets`
--

CREATE TABLE `pbtickets` (
  `ID` int(100) NOT NULL,
  `PassengerName` varchar(100) NOT NULL,
  `PassengerAge` varchar(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `NoOfSeats` int(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `JourneyDate` varchar(100) NOT NULL,
  `TicketCost` int(100) NOT NULL,
  `UserMobile` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `pbtickets`
--

INSERT INTO `pbtickets` (`ID`, `PassengerName`, `PassengerAge`, `Gender`, `NoOfSeats`, `Source`, `Destination`, `JourneyDate`, `TicketCost`, `UserMobile`) VALUES
(1, 'Tanay', '19', 'Male', 1, 'Mumbai', 'Delhi', '26-Dec-22 12:00:00 AM', 1300, 1234567890);

-- --------------------------------------------------------

--
-- Table structure for table `prtickets`
--

CREATE TABLE `prtickets` (
  `ID` int(100) NOT NULL,
  `PassengerName` varchar(100) NOT NULL,
  `PassengerAge` int(100) NOT NULL,
  `Gender` varchar(100) NOT NULL,
  `NoOfSeats` int(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `JourneyDate` varchar(100) NOT NULL,
  `TicketCost` varchar(100) NOT NULL,
  `UserMobile` int(10) NOT NULL,
  `TrainNameandNumber` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `prtickets`
--

INSERT INTO `prtickets` (`ID`, `PassengerName`, `PassengerAge`, `Gender`, `NoOfSeats`, `Source`, `Destination`, `JourneyDate`, `TicketCost`, `UserMobile`, `TrainNameandNumber`) VALUES
(1, 'Tanay Puranik', 21, 'Male', 1, 'Kalyan', 'Pune', '27-Dec-22 12:00:00 AM', '100', 0, 'System.Data.DataRowView'),
(2, 'Tana', 24, 'Male', 1, 'Bikaner', 'Nashik', '28-Dec-22 12:00:00 AM', '800', 1234567889, 'System.Data.DataRowView'),
(3, 'Swati', 15, 'Female', 1, 'Bikaner', 'Pune', '28-Dec-22 12:00:00 AM', '760', 1234567890, 'System.Data.DataRowView'),
(4, 'Mahesh', 23, 'Male', 4, 'Mumbai', 'Pune', '27-Dec-22 12:00:00 AM', '190', 2147483647, 'System.Data.DataRowView'),
(5, 'Alpha', 19, 'Other', 2, 'Mumbai', 'Nagpur', '27-Dec-22 12:00:00 AM', '190', 2147483647, 'System.Data.DataRowView'),
(6, 'Swati', 43, 'Female', 1, 'Mumbai', 'Delhi', '07-Jan-23 12:00:00 AM', '* Before submit please print using print button', 2147483647, 'System.Data.DataRowView'),
(7, 'vinay', 24, 'Male', 5, 'Mumbai', 'Delhi', '20-Jan-23 12:00:00 AM', '* Before SUBMIT please PRINT the Ticket', 1234567890, 'System.Data.DataRowView');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `patickets`
--
ALTER TABLE `patickets`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `pbtickets`
--
ALTER TABLE `pbtickets`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `prtickets`
--
ALTER TABLE `prtickets`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `patickets`
--
ALTER TABLE `patickets`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `pbtickets`
--
ALTER TABLE `pbtickets`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `prtickets`
--
ALTER TABLE `prtickets`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

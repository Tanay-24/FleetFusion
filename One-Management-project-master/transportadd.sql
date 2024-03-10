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
-- Database: `transportadd`
--

-- --------------------------------------------------------

--
-- Table structure for table `busadd`
--

CREATE TABLE `busadd` (
  `ID` int(100) NOT NULL,
  `BusNumber` varchar(100) NOT NULL,
  `BusType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `SHour` int(100) NOT NULL,
  `SMinute` int(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `DHour` int(100) NOT NULL,
  `DMinute` int(100) NOT NULL,
  `NoOfDaysRunning` varchar(50) NOT NULL,
  `BusLunchDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `busadd`
--

INSERT INTO `busadd` (`ID`, `BusNumber`, `BusType`, `Source`, `SHour`, `SMinute`, `Destination`, `DHour`, `DMinute`, `NoOfDaysRunning`, `BusLunchDate`) VALUES
(1, 'MH01AA1234', 'Inter-City', 'Mumbai', 0, 0, 'Pune', 0, 0, 'All Days', '0000-00-00'),
(2, 'MH01AA1234', '2x2 Seater', 'Nagpur', 6, 10, 'Kolapur', 14, 20, 'All Days', '28-Dec-22 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `flightadd`
--

CREATE TABLE `flightadd` (
  `ID` int(100) NOT NULL,
  `FlightNumber` varchar(100) NOT NULL,
  `AircraftType` varchar(100) NOT NULL,
  `FlightType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `SHour` int(100) NOT NULL,
  `SMinute` int(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `DHour` int(100) NOT NULL,
  `DMinute` int(100) NOT NULL,
  `No.Days Flying` varchar(50) NOT NULL,
  `FlightLaunchDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `flightadd`
--

INSERT INTO `flightadd` (`ID`, `FlightNumber`, `AircraftType`, `FlightType`, `Source`, `SHour`, `SMinute`, `Destination`, `DHour`, `DMinute`, `No.Days Flying`, `FlightLaunchDate`) VALUES
(1, '1', 'Jumbo Jets', 'Passenger', 'Chhatrapati Shivaji International Airport – BOM	Mumbai, Maharashtra', 0, 0, 'Indira Gandhi International Airport – DEL	Delhi', 0, 0, '', '0000-00-00'),
(2, 'SW-01', 'Jets', 'Regional', 'Chhatrapati Shivaji International Airport – BOM	Mumbai, Maharashtra', 9, 20, 'Vadodara Airport	Gujarat', 12, 28, '', '31-Dec-22 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `goodsadd`
--

CREATE TABLE `goodsadd` (
  `ID` int(100) NOT NULL,
  `VehicleNumber` varchar(100) NOT NULL,
  `VehicleType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `StateSource` varchar(100) NOT NULL,
  `StateDestination` varchar(100) NOT NULL,
  `VehicleRollOutDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `goodsadd`
--

INSERT INTO `goodsadd` (`ID`, `VehicleNumber`, `VehicleType`, `Source`, `Destination`, `StateSource`, `StateDestination`, `VehicleRollOutDate`) VALUES
(1, 'MH01AA0001', 'Mail Truck', 'Thane', 'Hubli', 'Maharashtra', 'Karnataka', '22-Dec-22 12:00:00 AM'),
(2, 'MH09WZ0978', 'SUV', 'Dombilvli', 'Vadodra', 'Maharashtra', 'Gujarat', '24-Dec-22 12:00:00 AM'),
(3, 'MH04AB1222', 'Tanker Truck', 'Kamothe', 'JLPT', 'Madhya Pradesh', 'Maharashtra', '17-Jan-23 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `shipadd`
--

CREATE TABLE `shipadd` (
  `ID` int(100) NOT NULL,
  `ShipNumber` varchar(100) NOT NULL,
  `ShipType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `ShipLaunchDate` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shipadd`
--

INSERT INTO `shipadd` (`ID`, `ShipNumber`, `ShipType`, `Source`, `Destination`, `ShipLaunchDate`) VALUES
(1, 'AZ1516', 'Container', 'Mumbai,Maharashtra', 'Kochi,Kerala', '0000-00-00'),
(2, 'AA1234', 'Bulk Carrier', 'Tuticorin,Tamil Nadu', 'Mo’orea, French Polynesia', '28-Dec-22 12:00:00 AM');

-- --------------------------------------------------------

--
-- Table structure for table `trainadd`
--

CREATE TABLE `trainadd` (
  `ID` int(100) NOT NULL,
  `TrainNumberAndName` varchar(100) NOT NULL,
  `TrainType` varchar(100) NOT NULL,
  `Source` varchar(100) NOT NULL,
  `SHour` int(100) NOT NULL,
  `SMinute` int(100) NOT NULL,
  `Destination` varchar(100) NOT NULL,
  `DHour` int(100) NOT NULL,
  `DMinute` int(100) NOT NULL,
  `No.OfCoches` int(100) NOT NULL,
  `TrainLaunchDate` varchar(100) NOT NULL,
  `NoOfDaysRunning` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `trainadd`
--

INSERT INTO `trainadd` (`ID`, `TrainNumberAndName`, `TrainType`, `Source`, `SHour`, `SMinute`, `Destination`, `DHour`, `DMinute`, `No.OfCoches`, `TrainLaunchDate`, `NoOfDaysRunning`) VALUES
(1, '1', 'Goods', 'Mumbai', 0, 0, 'Delhi', 0, 0, 20, '0000-00-00', ''),
(2, '00001 Mumbai Nagpur Inercity Express', 'Inter-City', 'Mumbai', 16, 31, 'Nagpur', 20, 27, 20, '24-Dec-22 12:00:00 AM', 'All Days'),
(3, '12127 Pune Mumbai Deccan Express', 'Express', 'Mumbai', 9, 5, 'Pune', 12, 21, 24, '24-Dec-22 12:00:00 AM', 'All Days'),
(4, '11227 Pun mumbai deccan queen express', 'Express', 'Pune', 7, 20, 'Mumbai', 11, 20, 21, '11-Jan-23 12:00:00 AM', 'All Days');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `busadd`
--
ALTER TABLE `busadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `flightadd`
--
ALTER TABLE `flightadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `goodsadd`
--
ALTER TABLE `goodsadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `shipadd`
--
ALTER TABLE `shipadd`
  ADD PRIMARY KEY (`ID`);

--
-- Indexes for table `trainadd`
--
ALTER TABLE `trainadd`
  ADD PRIMARY KEY (`ID`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `busadd`
--
ALTER TABLE `busadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `flightadd`
--
ALTER TABLE `flightadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `goodsadd`
--
ALTER TABLE `goodsadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `shipadd`
--
ALTER TABLE `shipadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `trainadd`
--
ALTER TABLE `trainadd`
  MODIFY `ID` int(100) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

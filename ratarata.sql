-- phpMyAdmin SQL Dump
-- version 5.1.3
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jun 09, 2022 at 12:00 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.3.16

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `ratarata`
--

-- --------------------------------------------------------

--
-- Table structure for table `data_mhs`
--

CREATE TABLE `data_mhs` (
  `Id` int(5) NOT NULL,
  `Nama` varchar(100) NOT NULL,
  `Nim` int(9) NOT NULL,
  `TanggalLahir` varchar(50) NOT NULL,
  `JenisKelamin` varchar(50) NOT NULL,
  `Alamat` varchar(100) NOT NULL,
  `JlhSKS` int(5) NOT NULL,
  `TotalNilai` int(10) NOT NULL,
  `Rata` float NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `data_mhs`
--

INSERT INTO `data_mhs` (`Id`, `Nama`, `Nim`, `TanggalLahir`, `JenisKelamin`, `Alamat`, `JlhSKS`, `TotalNilai`, `Rata`) VALUES
(1, 'Belintawati Zelda Br Ginting', 201401003, '21 Agustus 2002', 'WANITA', 'Desa Kidupen', 24, 2280, 95);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `data_mhs`
--
ALTER TABLE `data_mhs`
  ADD PRIMARY KEY (`Nim`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

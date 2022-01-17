-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Aug 31, 2019 at 12:38 AM
-- Server version: 10.4.6-MariaDB
-- PHP Version: 7.3.8

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `votaciones`
--
CREATE DATABASE IF NOT EXISTS `votaciones` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `votaciones`;

-- --------------------------------------------------------

--
-- Table structure for table `blancos`
--

CREATE TABLE `blancos` (
  `id` int(1) NOT NULL,
  `blancos_votantes` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `institucion`
--

CREATE TABLE `institucion` (
  `id` int(1) NOT NULL,
  `nombre` varchar(70) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Dumping data for table `institucion`
--

INSERT INTO `institucion` (`id`, `nombre`) VALUES
(0, '5 DE AGOSTO');

-- --------------------------------------------------------

--
-- Table structure for table `lista`
--

CREATE TABLE `lista` (
  `id` int(1) NOT NULL,
  `numa_votantes` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `listb`
--

CREATE TABLE `listb` (
  `id` int(1) NOT NULL,
  `numb_votantes` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `listc`
--

CREATE TABLE `listc` (
  `id` int(1) NOT NULL,
  `numc_votantes` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `nulos`
--

CREATE TABLE `nulos` (
  `id` int(1) NOT NULL,
  `null_votantes` int(11) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

-- --------------------------------------------------------

--
-- Table structure for table `votantes`
--

CREATE TABLE `votantes` (
  `CEDULA` varchar(10) NOT NULL,
  `NOMBRES` varchar(30) DEFAULT 'NULL',
  `APELLIDOS` varchar(30) DEFAULT 'NULL',
  `ESTADO` varchar(9) DEFAULT NULL
) ENGINE=MyISAM DEFAULT CHARSET=latin1;

--
-- Dumping data for table `votantes`
--

INSERT INTO `votantes` (`CEDULA`, `NOMBRES`, `APELLIDOS`, `ESTADO`) VALUES
('0850106188', 'Nigell Marcel', 'Jama Oyarvide', 'sin votar'),
('0800454183', 'Marcel River', 'Jama Navia', 'sin votar'),
('0803721299', 'Luis Dali', 'Alcivar Parraga', 'sin votar'),
('0800000000', 'Ricardo Rosendo', 'Barret Caicedo', 'sin votar'),
('0850106190', 'Videka Beatriz', 'Oyarvide Calderón', 'sin votar'),
('000', '000', '000', 'sin votar');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `blancos`
--
ALTER TABLE `blancos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `institucion`
--
ALTER TABLE `institucion`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `lista`
--
ALTER TABLE `lista`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `listb`
--
ALTER TABLE `listb`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `listc`
--
ALTER TABLE `listc`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `nulos`
--
ALTER TABLE `nulos`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `votantes`
--
ALTER TABLE `votantes`
  ADD PRIMARY KEY (`CEDULA`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `blancos`
--
ALTER TABLE `blancos`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `lista`
--
ALTER TABLE `lista`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `listb`
--
ALTER TABLE `listb`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `listc`
--
ALTER TABLE `listc`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `nulos`
--
ALTER TABLE `nulos`
  MODIFY `id` int(1) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Waktu pembuatan: 24 Jun 2024 pada 02.40
-- Versi server: 10.4.32-MariaDB
-- Versi PHP: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `karyawan`
--

DELIMITER $$
--
-- Prosedur
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `stok_barang` (IN `masuk` INT, IN `keluar` INT)   BEGIN
  SET @query = CONCAT(
    'SELECT g.kode_gudang, g.nama_gudang,g.alamat, b.kode_barang, b.nama_barang, b.harga_barang, b.jumlah_barang, b.expired_barang ',
    'FROM tbl_gudang g ',
    'JOIN tbl_barang b ON g.kode_gudang = b.gudang_id ',
    'ORDER BY g.kode_gudang, b.kode_barang ',
    'LIMIT ', masuk, ', ', keluar
  );

  PREPARE cek FROM @query;
  EXECUTE cek;
  DEALLOCATE PREPARE cek;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `kode_barang` int(11) NOT NULL,
  `nama_barang` varchar(50) DEFAULT NULL,
  `harga_barang` int(11) DEFAULT NULL,
  `jumlah_barang` int(11) DEFAULT NULL,
  `expired_barang` date DEFAULT NULL,
  `gudang_id` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_barang`
--

INSERT INTO `tbl_barang` (`kode_barang`, `nama_barang`, `harga_barang`, `jumlah_barang`, `expired_barang`, `gudang_id`) VALUES
(1, 'bangku sekolah', 10000, 5, '2024-01-01', 1),
(2, 'Penggaris', 1000, 1, '2025-01-01', 1);

--
-- Trigger `tbl_barang`
--
DELIMITER $$
CREATE TRIGGER `cek_kadaluarsa` AFTER INSERT ON `tbl_barang` FOR EACH ROW BEGIN
  IF (NEW.expired_barang < CURDATE()) THEN
    SIGNAL SQLSTATE '45000'
    SET MESSAGE_TEXT = 'Barang telah kadaluarsa';
  END IF;
END
$$
DELIMITER ;

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_gudang`
--

CREATE TABLE `tbl_gudang` (
  `kode_gudang` int(11) NOT NULL,
  `nama_gudang` varchar(50) DEFAULT NULL,
  `Alamat` varchar(200) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_gudang`
--

INSERT INTO `tbl_gudang` (`kode_gudang`, `nama_gudang`, `Alamat`) VALUES
(1, 'gudang_a', 'periuk'),
(2, 'gudang_b', 'surabaya');

-- --------------------------------------------------------

--
-- Struktur dari tabel `tbl_user`
--

CREATE TABLE `tbl_user` (
  `username` varchar(20) DEFAULT NULL,
  `password` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data untuk tabel `tbl_user`
--

INSERT INTO `tbl_user` (`username`, `password`) VALUES
('admin', 'admin');

--
-- Indexes for dumped tables
--

--
-- Indeks untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`kode_barang`),
  ADD KEY `gudang_id` (`gudang_id`),
  ADD KEY `expired_barang` (`expired_barang`);

--
-- Indeks untuk tabel `tbl_gudang`
--
ALTER TABLE `tbl_gudang`
  ADD PRIMARY KEY (`kode_gudang`);

--
-- Ketidakleluasaan untuk tabel pelimpahan (Dumped Tables)
--

--
-- Ketidakleluasaan untuk tabel `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD CONSTRAINT `tbl_barang_ibfk_1` FOREIGN KEY (`gudang_id`) REFERENCES `tbl_gudang` (`kode_gudang`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

-- phpMyAdmin SQL Dump
-- version 4.9.0.1
-- https://www.phpmyadmin.net/
--
-- Anamakine: 127.0.0.1
-- Üretim Zamanı: 03 Tem 2019, 23:55:47
-- Sunucu sürümü: 10.3.16-MariaDB
-- PHP Sürümü: 7.3.6

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Veritabanı: `rtc`
--

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `message`
--

CREATE TABLE `message` (
  `id` int(11) NOT NULL,
  `time` text NOT NULL,
  `fullname` text NOT NULL,
  `msg` text NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `message`
--

INSERT INTO `message` (`id`, `time`, `fullname`, `msg`) VALUES
(1, '23:55:24', 'd', 'sa'),
(2, '23:55:58', 'd', 'as'),
(3, '23:56:00', 'd', 'as'),
(4, '23:56:03', 'd', 'as dene'),
(5, '23:56:15', 'd', 'test'),
(6, '23:56:15', 'd', 'test'),
(7, '00:01:17', 'd', 'baba'),
(8, '00:01:54', 'd', 'test'),
(9, '00:03:54', 'd', 'merhaba'),
(10, '00:06:00', 'd', 'lan'),
(11, '00:07:48', 'd', 'test'),
(12, '00:07:55', 'd', 'sahgasha'),
(13, '00:07:56', 'd', 'sahash'),
(14, '00:07:57', 'd', 'ashas'),
(15, '00:09:44', 'Can Asik', 'kanka naber'),
(16, '00:09:51', 'd', 'iyi senden naber :D ?'),
(17, '00:10:11', 'Can Asik', 'adam gitti rizabababa'),
(18, '23:39:58', 'd', 'a'),
(19, '23:40:08', 'd', 'abaruuuuuuuuu'),
(20, '00:51:55', 'Can Asik', 'hello world'),
(21, '00:52:00', 'Codeffe Company', 'whats up'),
(22, '23:52:03', 'd', 'lalalala'),
(23, '23:52:13', 'd', 'where is he');

-- --------------------------------------------------------

--
-- Tablo için tablo yapısı `user`
--

CREATE TABLE `user` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `password` text NOT NULL,
  `email` varchar(255) NOT NULL,
  `fullname` text NOT NULL,
  `secretanswer` text NOT NULL,
  `status` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

--
-- Tablo döküm verisi `user`
--

INSERT INTO `user` (`id`, `username`, `password`, `email`, `fullname`, `secretanswer`, `status`) VALUES
(1, 'canasikk', '123', 'can@can.com', 'Can Asik', 'canbey', 0),
(3, 'a', 'b', 'c', 'd', 'e', 0),
(4, 'codeffe', '123', 'codeffe@cof.com', 'Codeffe Company', 'test', 0);

--
-- Dökümü yapılmış tablolar için indeksler
--

--
-- Tablo için indeksler `message`
--
ALTER TABLE `message`
  ADD PRIMARY KEY (`id`);

--
-- Tablo için indeksler `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id`),
  ADD UNIQUE KEY `username` (`username`,`email`),
  ADD UNIQUE KEY `username_2` (`username`,`email`);

--
-- Dökümü yapılmış tablolar için AUTO_INCREMENT değeri
--

--
-- Tablo için AUTO_INCREMENT değeri `message`
--
ALTER TABLE `message`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=24;

--
-- Tablo için AUTO_INCREMENT değeri `user`
--
ALTER TABLE `user`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

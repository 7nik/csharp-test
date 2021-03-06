-- phpMyAdmin SQL Dump
-- version 5.0.2
-- https://www.phpmyadmin.net/
--
-- Хост: 127.0.0.1:3306
-- Время создания: Апр 25 2020 г., 20:45
-- Версия сервера: 8.0.19
-- Версия PHP: 7.2.24-0ubuntu0.18.04.4

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `csharp_test`
--

-- --------------------------------------------------------

--
-- Структура таблицы `Games`
--

CREATE TABLE `Games` (
  `ID` int NOT NULL,
  `Home_team_id` int NOT NULL,
  `Away_team_id` int NOT NULL,
  `Home_team_score` int NOT NULL,
  `Away_team_score` int NOT NULL,
  `Date` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Games`
--

INSERT INTO `Games` (`ID`, `Home_team_id`, `Away_team_id`, `Home_team_score`, `Away_team_score`, `Date`) VALUES
(1, 1, 2, 0, 6, '2000-08-01'),
(2, 2, 9, 9, 11, '2008-01-17'),
(3, 3, 4, 10, 1, '2006-01-06'),
(4, 4, 3, 8, 11, '2010-07-17'),
(5, 5, 6, 2, 1, '2004-02-08'),
(6, 6, 8, 0, 4, '2002-08-02'),
(7, 7, 10, 2, 2, '2007-03-26'),
(8, 5, 6, 0, 0, '2000-01-16'),
(9, 1, 3, 6, 14, '2010-05-08'),
(10, 8, 4, 3, 8, '2002-07-18'),
(11, 1, 7, 0, 10, '2000-01-22'),
(12, 1, 3, 3, 12, '2001-02-24'),
(13, 2, 6, 0, 8, '2000-12-01'),
(14, 9, 7, 6, 1, '2001-01-17'),
(15, 8, 1, 4, 0, '2006-03-06'),
(16, 4, 7, 12, 5, '2000-09-11'),
(17, 1, 4, 0, 1, '2004-04-01'),
(18, 8, 1, 6, 3, '2001-08-04'),
(19, 8, 10, 6, 2, '2002-01-19'),
(20, 6, 10, 13, 2, '2002-11-04'),
(21, 6, 10, 3, 7, '2001-06-01'),
(22, 5, 3, 5, 7, '2000-12-03'),
(23, 10, 6, 10, 1, '2009-11-18'),
(24, 9, 5, 1, 5, '2001-10-09'),
(25, 5, 3, 9, 6, '2016-04-05'),
(26, 3, 8, 12, 10, '2000-07-03'),
(27, 7, 9, 12, 1, '2000-07-01'),
(28, 1, 6, 6, 6, '2001-03-19'),
(29, 8, 4, 14, 4, '2001-05-25'),
(30, 8, 4, 2, 4, '2000-07-02'),
(31, 5, 6, 8, 5, '2017-03-22'),
(32, 5, 9, 10, 6, '2014-03-13'),
(33, 1, 5, 0, 3, '2000-01-01'),
(34, 7, 6, 6, 1, '2000-08-08'),
(35, 10, 1, 4, 4, '2003-08-01'),
(36, 1, 10, 5, 7, '2005-01-20'),
(37, 9, 7, 2, 4, '2016-09-16'),
(38, 6, 9, 12, 12, '2000-04-23'),
(39, 6, 2, 4, 10, '2016-07-02'),
(40, 4, 3, 0, 1, '2003-08-02'),
(41, 5, 4, 14, 11, '2000-09-13'),
(42, 3, 9, 2, 3, '2006-01-03'),
(43, 1, 5, 1, 6, '2013-01-25'),
(44, 10, 7, 12, 3, '2000-02-19'),
(45, 3, 2, 4, 0, '2016-02-07'),
(46, 2, 7, 9, 0, '2000-04-02'),
(47, 4, 5, 13, 2, '2011-01-13'),
(48, 4, 9, 3, 3, '2000-01-01'),
(49, 2, 6, 11, 8, '2016-11-23'),
(50, 10, 6, 5, 1, '2004-01-27'),
(51, 9, 5, 4, 11, '2014-02-16'),
(52, 6, 5, 5, 1, '2016-10-09'),
(53, 9, 7, 1, 8, '2000-03-19'),
(54, 4, 5, 0, 9, '2006-05-01'),
(55, 7, 4, 5, 2, '2001-01-02'),
(56, 1, 9, 7, 10, '2004-02-01'),
(57, 5, 4, 0, 10, '2000-10-01'),
(58, 2, 1, 0, 13, '2007-01-09'),
(59, 7, 2, 9, 0, '2002-03-08'),
(60, 1, 6, 5, 0, '2006-05-02'),
(61, 4, 7, 4, 7, '2011-01-21'),
(62, 3, 1, 6, 4, '2000-04-10'),
(63, 5, 6, 4, 1, '2001-05-01'),
(64, 4, 5, 4, 2, '2000-01-07'),
(65, 10, 6, 12, 4, '2000-02-08'),
(66, 4, 3, 8, 4, '2014-10-05'),
(67, 9, 4, 8, 7, '2004-01-01'),
(68, 6, 1, 7, 4, '2013-12-13'),
(69, 3, 8, 0, 1, '2000-05-07'),
(70, 4, 9, 13, 9, '2000-02-16'),
(71, 1, 6, 2, 3, '2006-04-13'),
(72, 6, 4, 10, 3, '2016-09-28'),
(73, 6, 5, 4, 8, '2000-02-14'),
(74, 9, 3, 0, 7, '2014-09-13'),
(75, 7, 9, 1, 0, '2008-06-01'),
(76, 6, 7, 2, 10, '2019-09-03'),
(77, 5, 1, 11, 2, '2009-01-05'),
(78, 3, 8, 4, 2, '2000-02-13'),
(79, 10, 7, 5, 0, '2000-01-01'),
(80, 1, 4, 4, 4, '2015-02-05'),
(81, 1, 7, 0, 0, '2000-12-01'),
(82, 9, 2, 5, 9, '2002-04-12'),
(83, 3, 5, 2, 5, '2003-02-04'),
(84, 8, 2, 0, 1, '2012-06-17'),
(85, 1, 3, 6, 5, '2013-09-04'),
(86, 10, 7, 10, 5, '2009-05-03'),
(87, 5, 7, 14, 4, '2002-01-09'),
(88, 4, 5, 3, 1, '2001-05-01'),
(89, 4, 5, 3, 11, '2006-12-01'),
(90, 10, 3, 2, 0, '2008-09-15'),
(91, 4, 1, 2, 0, '2000-03-16'),
(92, 8, 7, 14, 13, '2011-05-01'),
(93, 7, 6, 1, 0, '2003-01-22'),
(94, 4, 2, 2, 2, '2012-03-02'),
(95, 3, 5, 7, 9, '2004-02-01'),
(96, 5, 2, 0, 5, '2002-07-08'),
(97, 1, 2, 0, 2, '2010-07-06'),
(98, 8, 6, 12, 5, '2000-10-23'),
(99, 6, 1, 6, 8, '2005-01-20'),
(100, 1, 9, 0, 3, '2006-06-23');

-- --------------------------------------------------------

--
-- Структура таблицы `Teams`
--

CREATE TABLE `Teams` (
  `ID` int NOT NULL,
  `Name` text NOT NULL,
  `Home_city` text
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;

--
-- Дамп данных таблицы `Teams`
--

INSERT INTO `Teams` (`ID`, `Name`, `Home_city`) VALUES
(1, 'Green-eyed taxi', 'Нижний тагил'),
(2, 'Young boys team', 'Сеул'),
(3, 'Underestimated Football Octopuses', 'Осака'),
(4, 'Sleepy reptiloids', 'Зона 51'),
(5, 'Old women-destroyers', 'Магадан'),
(6, 'Clone troopers', 'Империя'),
(7, 'Fuji-san & Co', 'Токио'),
(8, 'Ninjas of love', 'Бикон'),
(9, 'Tall dwarfs', 'Штормграда'),
(10, 'Trojan horse', 'Троя');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `Games`
--
ALTER TABLE `Games`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `Home_team_id` (`Home_team_id`,`Away_team_id`),
  ADD KEY `Away_team_id` (`Away_team_id`);

--
-- Индексы таблицы `Teams`
--
ALTER TABLE `Teams`
  ADD PRIMARY KEY (`ID`),
  ADD KEY `ID` (`ID`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `Games`
--
ALTER TABLE `Games`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=101;

--
-- AUTO_INCREMENT для таблицы `Teams`
--
ALTER TABLE `Teams`
  MODIFY `ID` int NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- Ограничения внешнего ключа сохраненных таблиц
--

--
-- Ограничения внешнего ключа таблицы `Games`
--
ALTER TABLE `Games`
  ADD CONSTRAINT `Games_ibfk_1` FOREIGN KEY (`Home_team_id`) REFERENCES `Teams` (`ID`),
  ADD CONSTRAINT `Games_ibfk_2` FOREIGN KEY (`Away_team_id`) REFERENCES `Teams` (`ID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

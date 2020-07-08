dotnet add package MySql.Data --version 8.0.20


CREATE TABLE `tablo1` (
  `Name` varchar(50) NOT NULL,
  `Body` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8;

INSERT INTO `tablo1` (`Name`, `Body`) VALUES
('Merhaba', 'Merhaba Dünya');

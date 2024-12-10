-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Erstellungszeit: 22. Nov 2024 um 08:26
-- Server-Version: 10.4.32-MariaDB
-- PHP-Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Datenbank: `tierheim`
--

DELIMITER $$
--
-- Prozeduren
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `AufAbGrid` ()   BEGIN
SELECT * 
FROM aufnahme_abgabe;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateAufAb` (IN `p_stammtierdaten_id` INT(10), IN `p_aufnahmePerson_ID` INT(11), IN `p_vorbesitzer` BOOLEAN, IN `p_fundtier` BOOLEAN, IN `p_aufnahmeort` VARCHAR(50), IN `p_aufnahmedatum` VARCHAR(20), IN `p_aufnahmegrund` VARCHAR(300), IN `p_aufnahmenotizen` VARCHAR(500), IN `p_abgabedatum` VARCHAR(20), IN `p_abgabePerson_id` INT(11), IN `p_abgabePersonVorkontrolle` VARCHAR(300), IN `p_abgabePersonNachkontrolle` VARCHAR(300), IN `p_abgabeNotizen` VARCHAR(700))   BEGIN
INSERT INTO aufnahme_abgabe(stammtierdaten_id, aufnahmePerson_ID, vorbesitzer, fundtier, aufnahmeort, aufnahmedatum, aufnahmegrund, aufnahmenotizen, abgabedatum, abgabePerson_ID, abgabePersonVorkontrolle, abgabePersonNachkontrolle, abgabeNotizen) 
VALUES (p_stammtierdaten_id, p_aufnahmePerson_ID, p_vorbesitzer, p_fundtier, p_aufnahmeort, p_aufnahmedatum, p_aufnahmegrund, p_aufnahmenotizen, p_abgabedatum, p_abgabePerson_id, p_abgabePersonVorkontrolle, p_abgabePersonNachkontrolle, p_abgabeNotizen);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateKennzeichnung` (IN `p_stammtierdaten_id` INT(10), IN `p_chipNr` INT(11), IN `p_tatooNr` INT(11), IN `p_ringNr` INT(11), IN `p_ausweisNr` INT(11))   BEGIN
INSERT INTO tierkennzeichnung(stammtierdaten_id, chipNr, tatooNr, ringNr, ausweisNr) 
VALUES (p_stammtierdaten_id, p_chipNr, p_tatooNr, p_ringNr, p_ausweisNr);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateMedAkte` (IN `p_stammtierdaten_id` INT(10), IN `p_diagnose` VARCHAR(500), IN `p_behandlungen` VARCHAR(500), IN `p_behandlungenLangFr` VARCHAR(500), IN `p_impfungen` VARCHAR(500), IN `p_medikamente` VARCHAR(500), IN `p_gewichtsverlauf` DOUBLE, IN `p_dokumente` VARCHAR(500))   BEGIN
INSERT INTO medizinische_akte(stammtierdaten_id, diagnose, behandlungen, behandlungenLangFr, impfungen, medikamente, gewichtsverlauf, dokumente) 
VALUES (p_stammtierdaten_id, p_diagnose, p_behandlungen, p_behandlungenLangFr, p_impfungen, p_medikamente, p_gewichtsverlauf, p_dokumente);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateStammtier` (IN `p_tiername` VARCHAR(30), IN `p_tierart` VARCHAR(30), IN `p_rasse` VARCHAR(50), IN `p_beschreibung` VARCHAR(500), IN `p_geschlecht` VARCHAR(10), IN `p_kastriert` BOOLEAN, IN `p_groesse` DOUBLE, IN `p_gewicht` DOUBLE, IN `p_geburtstag` VARCHAR(15), IN `p_geburtsort` VARCHAR(20), IN `p_todestag` VARCHAR(15), IN `p_todesursache` VARCHAR(50), IN `P_ort` VARCHAR(50), IN `p_notizenStammtierdaten` VARCHAR(600), IN `p_stammtierdatenID` INT(10))   BEGIN
INSERT INTO stammtierdaten(tiername, tierart, rasse, beschreibung, geschlecht, kastriert, groesse, gewicht, geburtstag, geburtsort, todestag, todesursache, ort, notizenStammtierdaten) 
VALUES (p_tiername, p_tierart, p_rasse, p_beschreibung, p_geschlecht, p_kastriert, p_groesse, p_gewicht, p_geburtstag, p_geburtsort, p_todestag, p_todesursache, p_ort, p_notizenStammtierdaten);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `CreateVerVer` (IN `p_stammtierdaten_id` INT(10), IN `p_verhalten_notizen` VARCHAR(1000), IN `p_vertraeglichkeit_notizen` VARCHAR(1000), IN `p_zustPerson_id` INT(11), IN `p_Pate` VARCHAR(30))   BEGIN
INSERT INTO verhalten_vertaeglichkeit(stammtierdaten_id, verhalten_notizen, vertraeglichkeit_notizen, zustPerson_ID, Pate) 
VALUES (p_stammtierdaten_id, p_verhalten_notizen, p_vertraeglichkeit_notizen, p_zustPerson_id, p_Pate);
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteAufAbViaID` (IN `p_stammtierdaten_id` INT(11))   BEGIN
DELETE FROM aufnahme_abgabe
WHERE stammtierdaten_id = p_stammtierdaten_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteKennzViaID` (IN `p_stammtierdaten_id` INT(10))   BEGIN
DELETE FROM tierkennzeichnung
WHERE stammtierdaten_id = p_stammtierdaten_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteMedAkteViaID` (IN `p_stammtierdaten_id` INT(10))   BEGIN
DELETE FROM medizinische_akte
WHERE stammtierdaten_id = p_stammtierdaten_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteStammtierViaID` (IN `p_stammtierdatenID` INT(10))   BEGIN
DELETE FROM stammtierdaten
WHERE stammtierdatenID = p_stammtierdatenID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `DeleteVerVerViaID` (IN `p_stammtierdaten_id` INT(11))   BEGIN
DELETE FROM verhalten_vertaeglichkeit
WHERE stammtierdaten_id = p_stammtierdaten_id;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReadMedAkteGrid` ()   BEGIN
SELECT * 
FROM medizinische_akte;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReadStammtierdatenGrid` ()   BEGIN
SELECT * 
FROM stammtierdaten;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReadTierkennzeichnungGrid` ()   BEGIN
SELECT * 
FROM tierkennzeichnung;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `ReadVerVerGrid` ()   BEGIN
SELECT * 
FROM verhalten_vertaeglichkeit;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateAufAb` (IN `p_stammtierdatenID` INT(10), IN `p_aufnahmePerson_ID` INT(11), IN `p_vorbesitzer` BOOLEAN, IN `p_fundtier` BOOLEAN, IN `p_aufnahmeort` VARCHAR(50), IN `p_aufnahmedatum` VARCHAR(20), IN `p_aufnahmegrund` VARCHAR(300), IN `p_aufnahmenotizen` VARCHAR(500), IN `p_abgabedatum` VARCHAR(20), IN `p_abgabePerson_ID` INT(11), IN `p_abgabePersonVorkontrolle` VARCHAR(300), IN `p_abgabePersonNachkontrolle` VARCHAR(300), IN `p_abgabeNotizen` VARCHAR(700))   BEGIN
UPDATE aufnahme_abgabe a 
INNER JOIN stammtierdaten s ON a.stammtierdaten_id = s.stammtierdatenID
SET 
a.aufnahmePerson_ID = p_aufnahmePerson_ID,
a.vorbesitzer = p_vorbesitzer,
a.fundtier = p_fundtier,
a.aufnahmeort = p_aufnahmeort,
a.aufnahmedatum = p_aufnahmedatum,
a.aufnahmegrund = p_aufnahmegrund,
a.aufnahmenotizen = p_aufnahmenotizen,
a.abgabedatum = p_abgabedatum,
a.abgabedatum = p_abgabedatum,
a.abgabePerson_ID = p_abgabePerson_ID,
a.abgabePersonVorkontrolle = p_abgabePersonVorkontrolle,
a.abgabePersonNachkontrolle = p_abgabePersonNachkontrolle,
a.abgabeNotizen = p_abgabeNotizen
WHERE s.stammtierdatenID = p_stammtierdatenID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateKennz` (IN `p_stammtierdatenID` INT(10), IN `p_chipNr` INT(11), IN `p_tatooNr` INT(11), IN `p_ringNr` INT(11), IN `p_ausweisNr` INT(11))   BEGIN
UPDATE tierkennzeichnung t 
INNER JOIN stammtierdaten s ON t.stammtierdaten_id = s.stammtierdatenID
SET 
t.chipNr = p_chipNr,
t.tatooNr = p_tatooNr,
t.ringNr = p_ringNr,
t.ausweisNr = p_ausweisNr
WHERE s.stammtierdatenID = p_stammtierdatenID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateMedAkte` (IN `p_stammtierdatenID` INT(10), IN `p_diagnose` VARCHAR(500), IN `p_behandlungen` VARCHAR(500), IN `p_behandlungenLangFr` VARCHAR(500), IN `p_impfungen` VARCHAR(500), IN `p_medikamente` VARCHAR(500), IN `p_gewichtsverlauf` DOUBLE, IN `p_dokumente` VARCHAR(500))   BEGIN
UPDATE medizinische_akte m 
INNER JOIN stammtierdaten s ON m.stammtierdaten_id = s.stammtierdatenID
SET 
m.diagnose = p_diagnose,
m.behandlungen = p_behandlungen,
m.behandlungenLangFr = p_behandlungenLangFr,
m.impfungen = p_impfungen,
m.medikamente = p_medikamente,
m.gewichtsverlauf = p_gewichtsverlauf,
m.dokumente = p_dokumente
WHERE s.stammtierdatenID = p_stammtierdatenID;
END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateStammtier` (IN `p_tiername` VARCHAR(30), IN `p_tierart` VARCHAR(50), IN `p_rasse` VARCHAR(50), IN `p_beschreibung` VARCHAR(500), IN `p_geschlecht` VARCHAR(10), IN `p_kastriert` BOOLEAN, IN `p_groesse` DOUBLE, IN `p_gewicht` DOUBLE, IN `p_geburtstag` VARCHAR(15), IN `p_geburtsort` VARCHAR(20), IN `p_todestag` VARCHAR(15), IN `p_todesursache` VARCHAR(50), IN `P_ort` VARCHAR(50), IN `p_notizenStammtierdaten` VARCHAR(600), IN `p_stammtierdatenID` INT(10))   BEGIN
UPDATE stammtierdaten
SET 
tiername = p_tiername,
tierart = p_tierart,
rasse = p_rasse,
beschreibung = p_beschreibung,
geschlecht = p_geschlecht,
kastriert = p_kastriert,
groesse = p_groesse,
gewicht = p_gewicht,
geburtstag = p_geburtstag,
geburtsort = p_geburtsort,
todestag = p_todestag,
todesursache = p_todesursache,
ort = p_ort,
notizenStammtierdaten = p_notizenStammtierdaten

WHERE stammtierdatenID = p_stammtierdatenID;

END$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `UpdateVerVer` (IN `p_stammtierdatenID` INT(10), IN `p_verhalten_notizen` VARCHAR(1000), IN `p_vertraeglichkeit_notizen` VARCHAR(1000), IN `p_zustPerson_ID` INT(11), IN `p_Pate` VARCHAR(30))   BEGIN
UPDATE verhalten_vertaeglichkeit v 
INNER JOIN stammtierdaten s ON v.stammtierdaten_id = s.stammtierdatenID
SET 
v.verhalten_notizen = p_verhalten_notizen,
v.vertraeglichkeit_notizen = p_vertraeglichkeit_notizen,
v.zustPerson_ID = p_zustPerson_ID,
v.Pate = p_Pate
WHERE s.stammtierdatenID = p_stammtierdatenID;
END$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `aufnahme_abgabe`
--

CREATE TABLE `aufnahme_abgabe` (
  `stammtierdaten_id` int(10) DEFAULT NULL,
  `aufnahme_abgabeID` int(11) NOT NULL,
  `aufnahmePerson_ID` int(11) DEFAULT NULL,
  `vorbesitzer` tinyint(1) DEFAULT NULL,
  `fundtier` tinyint(1) DEFAULT NULL,
  `aufnahmeort` varchar(50) DEFAULT NULL,
  `aufnahmedatum` varchar(20) DEFAULT NULL,
  `aufnahmegrund` varchar(300) DEFAULT NULL,
  `aufnahmenotizen` varchar(500) DEFAULT NULL,
  `abgabedatum` varchar(20) DEFAULT NULL,
  `abgabePerson_ID` int(11) DEFAULT NULL,
  `abgabePersonVorkontrolle` varchar(300) DEFAULT NULL,
  `abgabePersonNachkontrolle` varchar(300) DEFAULT NULL,
  `abgabeNotizen` varchar(700) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `aufnahme_abgabe`
--

INSERT INTO `aufnahme_abgabe` (`stammtierdaten_id`, `aufnahme_abgabeID`, `aufnahmePerson_ID`, `vorbesitzer`, `fundtier`, `aufnahmeort`, `aufnahmedatum`, `aufnahmegrund`, `aufnahmenotizen`, `abgabedatum`, `abgabePerson_ID`, `abgabePersonVorkontrolle`, `abgabePersonNachkontrolle`, `abgabeNotizen`) VALUES
(1, 1, 7, 1, 1, 'Hamburg', '15.10.2024', '15.10.2024', '', '0', 0, '0', '0', ''),
(1, 3, 0, 1, 0, 'Test', '0', '0', '', '0', 0, '0', '0', '');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `ehrenamtliche`
--

CREATE TABLE `ehrenamtliche` (
  `ehrenamtlichePerson_id` int(11) NOT NULL,
  `ehrenamtlicheID` int(11) NOT NULL,
  `zustaendigkeit` varchar(50) NOT NULL,
  `wochentage` varchar(300) NOT NULL,
  `uhrzeit` varchar(500) NOT NULL,
  `stammtierdaten_id` int(10) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `medizinische_akte`
--

CREATE TABLE `medizinische_akte` (
  `stammtierdaten_id` int(10) DEFAULT NULL,
  `medizinische_akteID` int(11) NOT NULL,
  `diagnose` varchar(500) DEFAULT NULL,
  `behandlungen` varchar(500) DEFAULT NULL,
  `behandlungenLangFr` varchar(500) DEFAULT NULL,
  `impfungen` varchar(500) DEFAULT NULL,
  `medikamente` varchar(500) DEFAULT NULL,
  `gewichtsverlauf` double DEFAULT NULL,
  `dokumente` varchar(500) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `medizinische_akte`
--

INSERT INTO `medizinische_akte` (`stammtierdaten_id`, `medizinische_akteID`, `diagnose`, `behandlungen`, `behandlungenLangFr`, `impfungen`, `medikamente`, `gewichtsverlauf`, `dokumente`) VALUES
(1, 1, 'Zwingerhusten', 'XYZ', 'weitere Untersuchungen', 'nein', 'Fenchelhonig', 67, '../pfad'),
(2, 3, 'Würmer', 'XYZ', 'nicht nötig', 'nein', 'Wurmkur', 3, '../pfad'),
(5, 4, '0', '0', '0', '0', '0', 0, '0');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `mitarbeiter`
--

CREATE TABLE `mitarbeiter` (
  `mitarbeiterPerson_id` int(11) NOT NULL,
  `mitarbeiterID` int(11) NOT NULL,
  `zustaendigkeit` varchar(500) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `person`
--

CREATE TABLE `person` (
  `personID` int(11) NOT NULL,
  `vorname` varchar(50) NOT NULL,
  `nachname` varchar(50) NOT NULL,
  `Adresse` varchar(50) NOT NULL,
  `plz` varchar(10) NOT NULL,
  `stadt` varchar(50) NOT NULL,
  `telefonnummer` varchar(20) NOT NULL,
  `handynummer` varchar(20) NOT NULL,
  `email` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `stammtierdaten`
--

CREATE TABLE `stammtierdaten` (
  `stammtierdatenID` int(10) NOT NULL,
  `tiername` varchar(30) DEFAULT NULL,
  `tierart` varchar(50) DEFAULT NULL,
  `rasse` varchar(50) DEFAULT NULL,
  `beschreibung` varchar(500) DEFAULT NULL,
  `geschlecht` varchar(10) DEFAULT NULL,
  `kastriert` tinyint(1) DEFAULT NULL,
  `groesse` double DEFAULT NULL,
  `gewicht` double DEFAULT NULL,
  `geburtstag` varchar(15) DEFAULT NULL,
  `geburtsort` varchar(20) DEFAULT NULL,
  `todestag` varchar(15) DEFAULT NULL,
  `todesursache` varchar(50) DEFAULT NULL,
  `ort` varchar(50) DEFAULT NULL,
  `notizenStammtierdaten` varchar(600) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `stammtierdaten`
--

INSERT INTO `stammtierdaten` (`stammtierdatenID`, `tiername`, `tierart`, `rasse`, `beschreibung`, `geschlecht`, `kastriert`, `groesse`, `gewicht`, `geburtstag`, `geburtsort`, `todestag`, `todesursache`, `ort`, `notizenStammtierdaten`) VALUES
(1, 'Bello', 'Hund', 'Bernhardiner', 'Bunt', 'Männlich', 1, 11, 69, '01.02.2021', 'Bern', '', '', 'Hundehaus1', 'Toller Hund'),
(2, 'MrMidnightt', 'Katze', 'Strassenkatze', 'schwarz', 'Männlich', 1, 40, 6, '02.03.2022', 'Hamburg', '', '', 'Katzenhaus7', 'Verfressen'),
(3, 'Munchkin', 'Katze', 'Mischling', 'Glückskatze', 'Weiblich', 1, 35, 3, '03.02.2015', 'Hamburg', '', '', 'Katzenhaus3', 'Süß'),
(4, 'Mira', 'Hund', 'Samojede', 'weiß', 'Weiblich', 1, 70, 35, '01.01.2021', 'Hamburg', '', '', 'Hundehaus3', 'kuschelig'),
(5, 'Mickey', 'Maus', 'Farbmaus', 'schwarz', 'männlich', 0, 10, 60, '05.06.2024', 'Hamburg', '', '', 'Kleintierhaus', 'süß'),
(9, 'Rocky', 'Hund', 'Jack Russel Terrier', 'Weiß-Braun', 'Männlich', 1, 30, 5, '05.04.2020', 'Hamburg', '', '', 'Hundehaus1', 'Wildfang'),
(10, 'Rumpleskin', 'Katze', 'Sphinx', 'Keine Haare', 'Weiblich', 1, 35, 35, '03.05.2020', 'Hamburg', '', '', 'Katzenhaus2', 'Freundlich trotz Grummelgesicht'),
(12, 'Sardine', 'Katze', 'British Longhair', 'Bluepoint', 'Weiblich', 0, 35, 4, '02.04.2020', 'Hamburg', '', '', 'Katzenhaus1', 'Cute'),
(13, 'Alice', 'Kanninchen', 'Zwergkaninchen', 'Weißes Fell, blaue Augen', 'Weiblich', 1, 35, 15, 'unbekannt', 'unbekannt', '', '', 'Kleintierhaus1', 'zahm'),
(15, 'Lilly', 'Katze', 'Europäisch Kurzhaar', '', 'Weiblich', 1, 4, 3, 'unbekannt', 'unbekannt', '', '', 'bei mathias zu Hause', 'Mathias Katze :)'),
(17, 'Pepe', 'Katze', 'Europäisch Kurzhaar', 'Fett', 'Männlich', 1, 40, 7, 'April', 'keine Angabe(drin)', '', '', 'Hamburg', 'ohhhhh'),
(19, 'Mio', 'Katze', 'Europäisch Kurzhaar', 'rot, fett, süß, rundlich', 'Mämmlich', 1, 40, 65, 'April 2020', 'Bauernhof/Dorf', '', '', 'bei Sarah zu Hause', 'darf nicht aus Plastiknäpfen essen'),
(20, 'Test', '0', '0', '', '0', 0, 0, 0, '0', '0', '0', '0', '0', '');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `tierkennzeichnung`
--

CREATE TABLE `tierkennzeichnung` (
  `stammtierdaten_id` int(10) NOT NULL,
  `tierkennzeichnungID` int(11) NOT NULL,
  `chipNr` int(11) DEFAULT NULL,
  `tatooNr` int(11) DEFAULT NULL,
  `ringNr` int(11) DEFAULT NULL,
  `ausweisNr` int(11) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `tierkennzeichnung`
--

INSERT INTO `tierkennzeichnung` (`stammtierdaten_id`, `tierkennzeichnungID`, `chipNr`, `tatooNr`, `ringNr`, `ausweisNr`) VALUES
(1, 1, 365346, 1435345, 0, 0),
(2, 3, 3246546, 54654656, 0, 76567767),
(3, 4, 867556, 786465, 0, 456546546),
(4, 5, 87654, 934324, 0, 2434),
(5, 6, 0, 0, 0, 0);

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `verhalten_vertaeglichkeit`
--

CREATE TABLE `verhalten_vertaeglichkeit` (
  `stammtierdaten_id` int(10) NOT NULL,
  `verhalten_vertaeglichkeitID` int(11) NOT NULL,
  `verhalten_notizen` varchar(1000) NOT NULL,
  `vertraeglichkeit_notizen` varchar(1000) NOT NULL,
  `zustPerson_ID` int(11) NOT NULL,
  `Pate` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Daten für Tabelle `verhalten_vertaeglichkeit`
--

INSERT INTO `verhalten_vertaeglichkeit` (`stammtierdaten_id`, `verhalten_vertaeglichkeitID`, `verhalten_notizen`, `vertraeglichkeit_notizen`, `zustPerson_ID`, `Pate`) VALUES
(1, 4, 'Freundlich, hört gut', 'alles', 123, 'noch nicht gefunden (auf der S'),
(17, 5, 'verfressen', 'alles', 987, 'Sascha'),
(5, 6, 'Test', '0', 0, '0');

-- --------------------------------------------------------

--
-- Tabellenstruktur für Tabelle `zugang`
--

CREATE TABLE `zugang` (
  `userPerson_id` int(11) NOT NULL,
  `zugangID` int(11) NOT NULL,
  `username` varchar(30) NOT NULL,
  `passwort` varchar(1000) NOT NULL,
  `rolle` varchar(200) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Indizes der exportierten Tabellen
--

--
-- Indizes für die Tabelle `aufnahme_abgabe`
--
ALTER TABLE `aufnahme_abgabe`
  ADD PRIMARY KEY (`aufnahme_abgabeID`),
  ADD KEY `stammtierdaten_id` (`stammtierdaten_id`);

--
-- Indizes für die Tabelle `ehrenamtliche`
--
ALTER TABLE `ehrenamtliche`
  ADD PRIMARY KEY (`ehrenamtlicheID`),
  ADD KEY `ehrenamtlichePerson_id` (`ehrenamtlichePerson_id`);

--
-- Indizes für die Tabelle `medizinische_akte`
--
ALTER TABLE `medizinische_akte`
  ADD PRIMARY KEY (`medizinische_akteID`),
  ADD KEY `stammtierdaten_id` (`stammtierdaten_id`);

--
-- Indizes für die Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
  ADD PRIMARY KEY (`mitarbeiterID`),
  ADD KEY `mitarbeiterPerson_id` (`mitarbeiterPerson_id`);

--
-- Indizes für die Tabelle `person`
--
ALTER TABLE `person`
  ADD PRIMARY KEY (`personID`);

--
-- Indizes für die Tabelle `stammtierdaten`
--
ALTER TABLE `stammtierdaten`
  ADD PRIMARY KEY (`stammtierdatenID`);

--
-- Indizes für die Tabelle `tierkennzeichnung`
--
ALTER TABLE `tierkennzeichnung`
  ADD PRIMARY KEY (`tierkennzeichnungID`),
  ADD KEY `stammtierdaten_id` (`stammtierdaten_id`);

--
-- Indizes für die Tabelle `verhalten_vertaeglichkeit`
--
ALTER TABLE `verhalten_vertaeglichkeit`
  ADD PRIMARY KEY (`verhalten_vertaeglichkeitID`),
  ADD KEY `stammtierdaten_ID` (`stammtierdaten_id`);

--
-- Indizes für die Tabelle `zugang`
--
ALTER TABLE `zugang`
  ADD PRIMARY KEY (`zugangID`),
  ADD KEY `userPerson_id` (`userPerson_id`);

--
-- AUTO_INCREMENT für exportierte Tabellen
--

--
-- AUTO_INCREMENT für Tabelle `aufnahme_abgabe`
--
ALTER TABLE `aufnahme_abgabe`
  MODIFY `aufnahme_abgabeID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT für Tabelle `medizinische_akte`
--
ALTER TABLE `medizinische_akte`
  MODIFY `medizinische_akteID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT für Tabelle `person`
--
ALTER TABLE `person`
  MODIFY `personID` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT für Tabelle `stammtierdaten`
--
ALTER TABLE `stammtierdaten`
  MODIFY `stammtierdatenID` int(10) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT für Tabelle `tierkennzeichnung`
--
ALTER TABLE `tierkennzeichnung`
  MODIFY `tierkennzeichnungID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT für Tabelle `verhalten_vertaeglichkeit`
--
ALTER TABLE `verhalten_vertaeglichkeit`
  MODIFY `verhalten_vertaeglichkeitID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT für Tabelle `zugang`
--
ALTER TABLE `zugang`
  MODIFY `zugangID` int(11) NOT NULL AUTO_INCREMENT;

--
-- Constraints der exportierten Tabellen
--

--
-- Constraints der Tabelle `aufnahme_abgabe`
--
ALTER TABLE `aufnahme_abgabe`
  ADD CONSTRAINT `aufnahme_abgabe_ibfk_1` FOREIGN KEY (`stammtierdaten_id`) REFERENCES `stammtierdaten` (`stammtierdatenID`);

--
-- Constraints der Tabelle `ehrenamtliche`
--
ALTER TABLE `ehrenamtliche`
  ADD CONSTRAINT `ehrenamtliche_ibfk_1` FOREIGN KEY (`ehrenamtlichePerson_id`) REFERENCES `person` (`personID`);

--
-- Constraints der Tabelle `medizinische_akte`
--
ALTER TABLE `medizinische_akte`
  ADD CONSTRAINT `medizinische_akte_ibfk_1` FOREIGN KEY (`stammtierdaten_id`) REFERENCES `stammtierdaten` (`stammtierdatenID`);

--
-- Constraints der Tabelle `mitarbeiter`
--
ALTER TABLE `mitarbeiter`
  ADD CONSTRAINT `mitarbeiter_ibfk_1` FOREIGN KEY (`mitarbeiterPerson_id`) REFERENCES `person` (`personID`);

--
-- Constraints der Tabelle `tierkennzeichnung`
--
ALTER TABLE `tierkennzeichnung`
  ADD CONSTRAINT `tierkennzeichnung_ibfk_1` FOREIGN KEY (`stammtierdaten_id`) REFERENCES `stammtierdaten` (`stammtierdatenID`);

--
-- Constraints der Tabelle `verhalten_vertaeglichkeit`
--
ALTER TABLE `verhalten_vertaeglichkeit`
  ADD CONSTRAINT `verhalten_vertaeglichkeit_ibfk_1` FOREIGN KEY (`stammtierdaten_id`) REFERENCES `stammtierdaten` (`stammtierdatenID`);

--
-- Constraints der Tabelle `zugang`
--
ALTER TABLE `zugang`
  ADD CONSTRAINT `zugang_ibfk_1` FOREIGN KEY (`userPerson_id`) REFERENCES `person` (`personID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;

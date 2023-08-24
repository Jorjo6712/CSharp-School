/* Lavet af Shazil, Jonas, Yordan, Magnus; Yordan's udgave */ 

/* CREATE INDEX randomIndex
ON Random (id, randomValue);  Kommentar felter fjernes når der skal testes med index*/

/* Opgave 1 */

-- Uden index:

SELECT CURRENT_TIMESTAMP

SELECT id, randomValue FROM Random WHERE randomValue = 4711;

SELECT CURRENT_TIMESTAMP
 
-- Start: 20:34:35.823 
-- Stop: 20:34:35.967
-- Query tid: 144 ms

-- Med index:

-- Start: 21:00:24.360
-- Stop: 21:00:24.493
-- Query tid: 133 ms

/* Opgave 2 */

-- Uden index:

SELECT CURRENT_TIMESTAMP
/* CREATE VIEW RandomCountAppearances as

SELECT randomValue, count (*) appearances FROM Random

Group By randomValue; Bruges til at lave VIEW clause */

SELECT randomValue FROM RandomCountAppearances
Order By randomValue;

SELECT CURRENT_TIMESTAMP

-- Start: 20:38:03.577
-- Stop: 20:38:03.740
-- Query tid: 163 ms

-- Med Index:

-- Start: 21:02:01.370
-- Stop: 21:02:01.587
-- Query tid: 217 ms

/* Opgave 3 */ 

-- Uden index:

SELECT CURRENT_TIMESTAMP

SELECT randomValue FROM RandomCountAppearances
Order By appearences asc;

SELECT CURRENT_TIMESTAMP

-- Start: 20:39:49.770
-- Stop: 20:39:49.870
-- Query tid: 100 ms

-- Med index:

-- Start: 21:03:30.490
-- Stop: 21:03:30.570
-- Query tid: 80 ms

/* Opgave 4 */ 

-- Uden index:

SELECT CURRENT_TIMESTAMP

SELECT randomValue FROM RandomCountAppearances
Order By appearences desc;

SELECT CURRENT_TIMESTAMP

-- Start: 20:41:43.050
-- Stop: 20:41:43.183
-- Query tid: 133 ms

-- Med index:

-- Start: 21:04:51.460
-- Stop: 21:04:51.580
-- Query tid: 120 ms

/* Opgave 5 */

-- Uden index:

SELECT CURRENT_TIMESTAMP
SELECT randomValue FROM
(
	SELECT TOP 1 randomValue FROM RandomCountAppearances
	Order By appearences desc

	UNION

	SELECT TOP 1 randomValue FROM RandomCountAppearances
	Order By appearences asc
) AS CombinedResults;
SELECT CURRENT_TIMESTAMP

-- Start: 20:56:51.150
-- Stop: 20:56:51.230
-- Query tid: 80 ms

-- Med index:

-- Start: 21:05:38.393
-- Stop: 21:05:38.487
-- Query tid: 94 ms

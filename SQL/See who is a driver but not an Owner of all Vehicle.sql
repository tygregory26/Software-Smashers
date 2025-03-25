USE sql3769593;
SELECT u.* 
FROM drivers d
JOIN user u ON d.driverID = u.userID
JOIN vehicle v ON d.vehicleLink = v.carID
WHERE d.driverLink <> v.ownerID;
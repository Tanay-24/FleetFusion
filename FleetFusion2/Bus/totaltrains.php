<?php
// Database configuration
$host = "localhost";
$user = "root";
$password = "";
$database = "railway";

// Create database connection
$conn = mysqli_connect($host, $user, $password, $database);

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Fetch total number of trains from the database
$sql = "SELECT COUNT(*) AS total_trains FROM trainadd";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0) {
    $row = mysqli_fetch_assoc($result);
    $totalTrains = $row["total_trains"];
} else {
    $totalTrains = 0;
}

// Close the database connection
mysqli_close($conn);
?>

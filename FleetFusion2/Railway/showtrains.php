<?php
// Database configuration
$host = "localhost"; // Your MySQL host
$user = "root"; // Your MySQL username
$password = ""; // Your MySQL password
$database = "railway"; // Your MySQL database name

// Create database connection
$conn = mysqli_connect($host, $user, $password, $database);

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Fetch train information
$sql = "SELECT * FROM trainadd";
$result = mysqli_query($conn, $sql);

// Check if there are any results
if (mysqli_num_rows($result) > 0) {
    // Output data of each row
    while ($row = mysqli_fetch_assoc($result)) {
        echo "ID: " . $row["id"] . "<br>";
        echo "Train Name: " . $row["train_name"] . "<br>";
        echo "Departure Station: " . $row["departure_station"] . "<br>";
        echo "Destination Station: " . $row["destination_station"] . "<br>";
        echo "Departure Time: " . $row["departure_time"] . "<br>";
        echo "Arrival Time: " . $row["arrival_time"] . "<br><br>";
    }
} else {
    echo "0 results";
}

// Close the database connection
mysqli_close($conn);
?>

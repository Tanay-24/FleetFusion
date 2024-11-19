<?php
// Database configuration
$host = "localhost"; // Your MySQL host
$user = "root"; // Your MySQL username
$password = ""; // Your MySQL password
$database = "railway"; // Your MySQL database name

// Create database connection
$conn = mysqli_connect($host, $user, $password, $database);
//$conn = new mysqli('localhost', 'root', '', 'railway');

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Check if the form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Retrieve form data
    $trainName = $_POST["trainName"];
    $trainType = $_POST["trainType"];
    $departureStation = $_POST["departureStation"];
    $destinationStation = $_POST["destinationStation"];
    $departureTime = $_POST["departureTime"];
    $arrivalTime = $_POST["arrivalTime"];
    $frequency = $_POST["frequency"];
    $distance = $_POST["distance"];
    $route = $_POST["route"];
    $capacity = $_POST["capacity"];
    $ticketPrice = $_POST["ticketPrice"];
    $trainStatus = $_POST["trainStatus"];
    // Add the remaining form fields here...

    // Insert form data into database
    $sql = "INSERT INTO trainadd (train_name, train_type, departure_station, destination_station, departure_time, arrival_time, frequency, distance, route, capacity, ticket_price, train_status) VALUES ('$trainName', '$trainType', '$departureStation', '$destinationStation', '$departureTime', '$arrivalTime', '$frequency', '$distance', '$route', '$capacity', '$ticketPrice', '$trainStatus')";

    if (mysqli_query($conn, $sql)) {
        echo "New record created successfully";
        echo '<script>window.location.href = "dashboard.html";</script>';
    } else {
        echo "Error: " . $sql . "<br>" . mysqli_error($conn);
    }
}

// Close the database connection
mysqli_close($conn);
?>

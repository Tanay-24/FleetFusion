<?php
// Database connection
$servername = "localhost";
$username = "root"; // Replace with your MySQL username
$password = ""; // Replace with your MySQL password
$database = "railway"; // Replace with your database name

$conn = mysqli_connect($servername, $username, $password, $database);

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Handle form submission
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    // Retrieve form data
    $trainName = $_POST["train_name"];
    $trainType = $_POST["train_type"];
    $departureStation = $_POST["departure_station"];
    $destinationStation = $_POST["destination_station"];
    // Add other form fields as needed

    // Update data in the database
    $sql = "UPDATE trainadd SET train_type='$trainType', departure_station='$departureStation', destination_station='$destinationStation' WHERE train_name='$trainName'";

    if (mysqli_query($conn, $sql)) {
        echo "Train details updated successfully";
        echo '<script>window.location.href = "dashboard.html";</script>';
    } else {
        echo "Error updating train details: " . mysqli_error($conn);
    }
}

// Close the database connection
mysqli_close($conn);
?>

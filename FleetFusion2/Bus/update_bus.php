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
    $busName = $_POST["busName"];
    $busType = $_POST["busType"];
    $departureStop = $_POST["departureStop"];
    $destinationStop = $_POST["destinationStop"];
    // Add other form fields as needed

    // Update data in the database
    $sql = "UPDATE busadd SET bus_type='$busType', departure_stop='$departureStop', destination_stop='$destinationStop' WHERE bus_name='$busName'";

    if (mysqli_query($conn, $sql)) {
        echo "Train details updated successfully";
        echo '<script>window.location.href = "busdashboard.html";</script>';
    } else {
        echo "Error updating train details: " . mysqli_error($conn);
    }
}

// Close the database connection
mysqli_close($conn);
?>

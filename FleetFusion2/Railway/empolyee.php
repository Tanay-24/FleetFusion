<?php
// Database connection
$servername = "localhost";
$username = "root"; // Default username for XAMPP
$password = ""; // Default password for XAMPP
$database = "employee";

$conn = mysqli_connect($servername, $username, $password, $database);

// Check connection
if (!$conn) {
    die("Connection failed: " . mysqli_connect_error());
}

// Handle form submission
if ($_SERVER["REQUEST_METHOD"] == "POST") {
    $firstname = $_POST["firstname"];
    $lastname = $_POST["lastname"];
    $email = $_POST["email"];
    $phone = $_POST["phone"];
    $address = $_POST["address"];
    $salary = $_POST["salary"]; // Corrected variable name
    $state = $_POST["state"];
    $country = $_POST["country"];
    $post = $_POST["post"];
    $department = $_POST["department"]; // Corrected variable name

    // Insert data into the database
    $sql = "INSERT INTO remployee (firstname, lastname, email, phone, address, salary, state, country, post, department) 
            VALUES ('$firstname', '$lastname', '$email', '$phone', '$address', '$salary', '$state', '$country', '$post', '$department')";

    if (mysqli_query($conn, $sql)) {
        echo "New record created successfully";
        echo '<script>window.location.href = "dashboard.html";</script>';
    } else {
        echo "Error: " . $sql . "<br>" . mysqli_error($conn);
    }
    mysqli_close($conn);
}
?>

<?php
$servername = "localhost";
$username = "root";
$password = ""; // Enter your MySQL password here
$dbname = "registration"; // Enter your database name here

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}

$email = $_POST['email'];
$password = $_POST['password'];

// Prepare and bind SQL statement
$stmt = $conn->prepare("SELECT * FROM users WHERE email=? AND password=?");
$stmt->bind_param("ss", $email, $password);

// Execute SQL statement
$stmt->execute();

// Get result
$result = $stmt->get_result();

// Check if user exists
if ($result->num_rows > 0) {
  echo json_encode(array("success" => true));
} else {
  echo json_encode(array("success" => false, "message" => "Invalid email or password"));
}

$stmt->close();
$conn->close();
echo '<script>window.location.href = "../Services/services.html";</script>';
?>

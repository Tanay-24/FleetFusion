<?php
// Retrieve form data
$name = $_POST['firstname'];
$gender = $_POST['lastname'];
$username = $_POST['email'];
$email = $_POST['password'];
$password = $_POST['gender'];

// Connect to MySQL database
$conn = new mysqli('localhost', 'root', '', 'registration');

// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}
  
// Prepare and bind SQL statement
$stmt = $conn->prepare("INSERT INTO users (firstname, lastname, email, password, gender) VALUES (?, ?, ?, ?, ?)");
$stmt->bind_param("sssss", $firstname, $lastname, $email, $password, $gender);
  
// Set parameters and execute
$firstname = $_POST['firstname'];
$lastname = $_POST['lastname'];
$email = $_POST['email'];
$password = $_POST['password'];
$gender = $_POST['gender'];
  
$stmt->execute();
  
// Close statement and connection
$stmt->close();
$conn->close();

// Redirect to next page using JavaScript
echo '<script>window.location.href = "../Services/services.html";</script>';
?>

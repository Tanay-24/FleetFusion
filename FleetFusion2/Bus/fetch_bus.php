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

// Fetch train information from the database
$sql = "SELECT * FROM busadd";
$result = mysqli_query($conn, $sql);

if (mysqli_num_rows($result) > 0) {
    // Output data of each row
    echo '<table>';
    echo '<thead>';
    echo '<tr>';
    echo '<th>Bus Name</th>';
    echo '<th>Departure Stop</th>';
    echo '<th>Destination Stop</th>';
    echo '<th>Departure Time</th>';
    echo '<th>Arrival Time</th>';
    echo '<th>Frequency</th>';
    echo '<th>Distance (km)</th>';
    echo '<th>Route</th>';
    echo '<th>Capacity</th>';
    echo '<th>Ticket Price</th>';
    echo '<th>Status</th>';
    echo '<th>View Map</th>'; // New column added for viewing the map
    echo '</tr>';
    echo '</thead>';
    echo '<tbody>';

    while ($row = mysqli_fetch_assoc($result)) {
        echo '<tr>';
        echo '<td>' . $row["bus_name"] . '</td>';
        echo '<td>' . $row["departure_stop"] . '</td>';
        echo '<td>' . $row["destination_stop"] . '</td>';
        echo '<td>' . $row["departure_time"] . '</td>';
        echo '<td>' . $row["arrival_time"] . '</td>';
        echo '<td>' . $row["frequency"] . '</td>';
        echo '<td>' . $row["distance"] . '</td>';
        echo '<td>' . $row["route"] . '</td>';
        echo '<td>' . $row["capacity"] . '</td>';
        echo '<td>' . $row["ticket_price"] . '</td>';
        echo '<td>' . $row["bus_status"] . '</td>';
        echo '<td><a href="#" onclick="showMap(\'' . $row["bus_name"] . '\')">View Map</a></td>'; // Link to open map
        echo '</tr>';
    }

    echo '</tbody>';
    echo '</table>';
} else {
    echo "0 results";
}

// Close the database connection
mysqli_close($conn);
?>

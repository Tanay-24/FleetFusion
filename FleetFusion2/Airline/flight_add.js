document.addEventListener("DOMContentLoaded", function() {
    document.getElementById("btnSubmit").addEventListener("click", function() {
        var flightNumber = document.getElementById("txtFlightNumber").value;
        var aircraftType = document.getElementById("cbAircrafttype").value;
        // Get other input field values

        if (flightNumber === "" || aircraftType === "") {
            alert("Missing information");
            return;
        }

        // Here, you can add AJAX code to send the flight data to the server
        // After successful addition, you can display a success message or redirect the user

        // For now, let's just display a message
        alert("Aircraft added successfully!");
        window.location.href = "airline_home_page.html";
    });

    document.getElementById("btnBack").addEventListener("click", function() {
        // Redirect the user to the airline home page
        window.location.href = "airline_home_page.html";
    });
});

document.addEventListener("DOMContentLoaded", function() {
    document.getElementById("addFlightBtn").addEventListener("click", function() {
        window.location.href = "flight_add.html";
    });

    document.getElementById("showFlightBtn").addEventListener("click", function() {
        window.location.href = "show_flight.html";
    });
});

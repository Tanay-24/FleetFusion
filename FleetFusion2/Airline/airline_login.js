document.addEventListener("DOMContentLoaded", function() {
    document.getElementById("btnLogin").addEventListener("click", function() {
        var username = document.getElementById("txtAirlineUName").value;
        var email = document.getElementById("txtAirlineEmail").value;
        // Here, you can add code to send username and email to server for login validation
        // After successful login, redirect the user to the airline home page
        window.location.href = "airline_home_page.html";
    });

    document.getElementById("btnCreateAccount").addEventListener("click", function() {
        // Redirect the user to the airline registration page
        window.location.href = "airline_register.html";
    });
});

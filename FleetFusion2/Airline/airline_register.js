document.addEventListener("DOMContentLoaded", function() {
    document.getElementById("btnRegister").addEventListener("click", function() {
        var username = document.getElementById("txtAirlineUName").value;
        var companyName = document.getElementById("txtAirlineCompanyName").value;
        var email = document.getElementById("txtAirlineEmail").value;
        var phone = document.getElementById("txtAirlinePhone").value;

        if (!email.includes('@') || !email.includes('.')) {
            alert("Please enter a valid email");
            return;
        }

        if (username === "" || companyName === "" || email === "" || phone === "") {
            alert("Please fill out all information");
            return;
        }

        // Here, you can add AJAX code to send the registration data to the server
        // After successful registration, you can redirect the user to the login page

        // For now, let's just display a message
        alert("Account successfully created!");
        window.location.href = "airline_login.html";
    });

    document.getElementById("btnLogin").addEventListener("click", function() {
        // Redirect the user to the airline login page
        window.location.href = "airline_login.html";
    });
});

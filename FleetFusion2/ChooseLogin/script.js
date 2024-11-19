document.addEventListener("DOMContentLoaded", function() {
    var btnAdmin = document.getElementById("btnAdmin");
    var btnUser = document.getElementById("btnUser");

    btnAdmin.addEventListener("click", function() {
        // Redirect to admin login page
        window.location.href = "login.html";
    });

    btnUser.addEventListener("click", function() {
        // Redirect to user login page
        window.location.href = "ulogin.html";
    });
});

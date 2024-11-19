document.addEventListener('DOMContentLoaded', function() {
    // Fetch employee details from the server
    var employeeId = 123; // Replace with the actual employee ID
    fetchEmployeeDetails(employeeId);
    
    // Function to fetch employee details from the server
    function fetchEmployeeDetails(id) {
        // Make an AJAX request to fetch employee details
        // Here you can use XMLHttpRequest or fetch API
        
        // For demonstration purposes, I'm simulating the response
        var employeeDetails = {
            firstname: 'John',
            lastname: 'Doe',
            email: 'john@example.com',
            phone: '123-456-7890',
            address: '123 Main St'
        };
        
        // Update the form fields with the fetched details
        document.getElementById('employeeId').value = id;
        document.getElementById('firstname').value = employeeDetails.firstname;
        document.getElementById('lastname').value = employeeDetails.lastname;
        document.getElementById('email').value = employeeDetails.email;
        document.getElementById('phone').value = employeeDetails.phone;
        document.getElementById('address').value = employeeDetails.address;
    }
});

document.addEventListener('DOMContentLoaded', function() {
    var addTrainForm = document.getElementById('addTrainForm');
    var btnClear = document.getElementById('btnClear');
    var btnBack = document.getElementById('btnBack');

    addBusForm.addEventListener('submit', function(event) {
        event.preventDefault(); // Prevent form submission
        
        // Get form data
        var formData = new FormData(addBusForm);
        var trainData = {};
        formData.forEach((value, key) => {
            trainData[key] = value;
        });

        // Send train data to server using fetch API or XMLHttpRequest
        fetch('http://localhost:3000/api/addtrain', { // Replace with your API endpoint
            method: 'POST',
            body: JSON.stringify(trainData),
            headers: {
                'Content-Type': 'application/json'
            }
        })
        .then(response => response.json())
        .then(data => {
            alert('Train added successfully!');
            addTrainForm.reset(); // Clear form fields after successful submission
        })
        .catch(error => {
            console.error('Error adding bus:', error);
            alert('Error adding train. Please try again later.');
        });
    });

    btnClear.addEventListener('click', function() {
        addTrainForm.reset(); // Clear form fields
    });

    btnBack.addEventListener('click', function() {
        window.location.href = 'homepage.html'; // Redirect to home page
    });
});

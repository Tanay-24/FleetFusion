// Define the updateTrainChart function
function updateTrainChart(trainData) {
    // Implementation of updating the train chart with the provided trainData
    console.log('Updating train chart with data:', trainData);
}

// Define the updateEmployeeChart function
function updateEmployeeChart(employeeData) {
    // Implementation of updating the employee chart with the provided employeeData
    console.log('Updating employee chart with data:', employeeData);
}

// Function to fetch data from the server
function fetchData(url) {
    return fetch(url)
        .then(response => {
            if (!response.ok) {
                throw new Error('Network response was not ok');
            }
            return response.json();
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });
}

// Fetch data for trains
fetchData('fetch_train.php')
    .then(trainData => {
        // Update train chart with trainData
        updateTrainChart(trainData);
    });

// Fetch data for employees
fetchData('employee.php')
    .then(employeeData => {
        // Update employee chart with employeeData
        updateEmployeeChart(employeeData);
    });

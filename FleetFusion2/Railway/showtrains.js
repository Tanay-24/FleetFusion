function showMap(trainName) {
    // Display the map section
    document.getElementById("mapSection").style.display = "block";
    // Simulate loading map for the selected train (placeholder)
    document.getElementById("map").innerHTML = `<p>Loading map for ${trainName}...</p>`;

    // Make an AJAX request to a server-side script to fetch map data
    var xhr = new XMLHttpRequest();
    xhr.onreadystatechange = function() {
        if (xhr.readyState === XMLHttpRequest.DONE) {
            if (xhr.status === 200) {
                // Once you receive the map data, render it inside the "map" element
                document.getElementById("map").innerHTML = xhr.responseText;
            } else {
                console.error("Error fetching map data: " + xhr.status);
            }
        }
    };
    // Replace 'fetch_map.php' with the actual path to your server-side script that fetches map data
    xhr.open("POST", "fetch_map.php", true);
    xhr.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
    xhr.send("trainName=" + encodeURIComponent(trainName));
}
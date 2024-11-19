function loadForm(url) {
    fetch(url)
        .then(response => response.text())
        .then(html => {
            document.getElementById('formContainer').innerHTML = html;
        })
        .catch(error => console.log('Error loading form:', error));
}

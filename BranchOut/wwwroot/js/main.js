function showModal(modalId) {
    bootstrap.Modal.getOrCreateInstance(document.getElementById(modalId)).show();
}

function hideModal(modalId) {
    bootstrap.Modal.getOrCreateInstance(document.getElementById(modalId)).hide();
}

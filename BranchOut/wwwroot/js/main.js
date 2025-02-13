function showModal(modalId) {
    bootstrap.Modal.getOrCreateInstance(document.getElementById(modalId)).show();
}

function hideModal(modalId) {
    bootstrap.Modal.getOrCreateInstance(document.getElementById(modalId)).hide();
}

window.reloadIframe = function (iframeId) {
    const iframe = document.getElementById(iframeId);

    if (iframe) {
        const parent = iframe.parentNode;

        const newIframe = iframe.cloneNode();

        newIframe.onload = function () {
            parent.removeChild(iframe);
        };

        parent.insertBefore(newIframe, iframe);
    }
};
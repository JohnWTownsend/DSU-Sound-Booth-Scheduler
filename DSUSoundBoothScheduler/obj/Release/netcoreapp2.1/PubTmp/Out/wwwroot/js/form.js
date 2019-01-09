document.addEventListener("DOMContentLoaded", () => {
    flatpickr(".fp-date", {
        enableTime: true,
        altInput: true,
        altFormat: "F j, Y  h:i K",
        time_24hr: false,
        allowInput: true
    });


    document.querySelectorAll("input").forEach((HTMLInputElement) => {
        HTMLInputElement.classList.remove("form-control");
    });
});
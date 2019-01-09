document.addEventListener("DOMContentLoaded", () => {
    document.querySelectorAll(".reservation-color").forEach((HTMLDivElement) => {
        HTMLDivElement.parentElement.setAttribute("style", `background:${HTMLDivElement.innerText}`);
    });
    window.addEventListener("resize", setHeaderPositions);

    setReservationPositions();
    setHeaderPositions();
});

function setReservationPositions() {
    let reservations = document.querySelectorAll(".reservation-size");
    reservations.forEach((HTMLDivElement) => {
        let dateContent = HTMLDivElement.innerText.split(" ");
        let startHour = parseInt(dateContent[0]);
        let endHour = parseInt(dateContent[1]);
        let gridItem = HTMLDivElement.parentElement.parentElement;
        gridItem.setAttribute("style", `grid-area: ${startHour+1}; grid-row: ${startHour+1}/${endHour+1};`);
    });
}

function setHeaderPositions() {
    if (window.innerWidth > 600) {
        let headers = document.querySelectorAll("h4");
        let schedule = document.querySelector("#schedule");
        let schedulePosition = schedule.getBoundingClientRect();
        let i = 0;
        let incrementVal = (schedulePosition.right - schedulePosition.left) / 7.0;
        headers.forEach((HTMLHeadingElement) => {
            HTMLHeadingElement.setAttribute("style", `top: ${schedulePosition.top}; left:${schedulePosition.left + i * incrementVal}px; width: ${incrementVal}px`);
            i++;
        });
    }
}
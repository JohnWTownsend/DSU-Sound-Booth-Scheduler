document.addEventListener("DOMContentLoaded", () => {
    document.querySelectorAll(".reservation-color").forEach((HTMLDivElement) => {
        HTMLDivElement.parentElement.setAttribute("style", `background:${HTMLDivElement.innerText}`);
    });

    window.addEventListener("resize", () => { setHeaderPositions(); showHideTimes(); });
    window.addEventListener("click", (event) => {
        conditionallyCloseAllModals(event);
    }, true );

    setHeaderPositions();
    showHideTimes();
    addModalPopupsToHeaders();
    setReservationPositions();
});

function showHideTimes() {
    let timeDiv = document.querySelector("#main-schedule-hour-wrapper");
    console.log(timeDiv);
    if (window.innerWidth > 600) {
        timeDiv.setAttribute("style", "display:grid;");
    }
    else {
        timeDiv.setAttribute("style", "display:none;");
    }
}

function setHeaderPositions() {
    let headers = document.querySelectorAll(".weekDay > h4");
    if (window.innerWidth > 600) {
        let schedule = document.querySelector("#schedule");
        let schedulePosition = schedule.getBoundingClientRect();
        let i = 0;
        let incrementVal = (schedulePosition.right - schedulePosition.left) / 7.0;
        headers.forEach((HTMLHeadingElement) => {
            HTMLHeadingElement.setAttribute("style", `top: ${schedulePosition.top}; left:${schedulePosition.left + i * incrementVal}px; width: ${incrementVal}px`);
            i++;
        });
    }
    else {
        headers.forEach((HTMLHeadingElement) => {
            HTMLHeadingElement.setAttribute("style", `top:auto; left:auto; width:100%;`);
        });
    }
}

function addModalPopupsToHeaders() {
    let weekDay = document.querySelectorAll(".weekDay");
    weekDay.forEach((HTMLDivElement) => {
        let heading = HTMLDivElement.querySelector("h4");
        let modal = HTMLDivElement.querySelector(".modal");
        heading.addEventListener("click", () => {
            if (modal.getAttribute("style") === "display:none;") {
                modal.setAttribute("style", "display:block;");
                modal.setAttribute("data-visible", "1");
                displayOverlay();
            }
            else {
                modal.setAttribute("style", "display:none;");
                modal.setAttribute("data-visible", "0");
            }
        });
    });
}

function closeModalFromButton(element) {
    element.parentElement.setAttribute("style", "display:none;");
}

function conditionallyCloseAllModals(event) {
    let modal = document.querySelector(".modal[data-visible='1']");
    if (modal !== null) {
        let xStart = modal.getBoundingClientRect().left;
        let yStart = modal.getBoundingClientRect().top;
        let width = modal.offsetWidth;
        let height = modal.offsetHeight;
        if ((event.clientX < xStart || event.clientX > (xStart + width)) || (event.clientY < yStart || event.clientY > (yStart + height))) {
            closeAllModals();
        }
    }
}

function closeAllModals() {
    let modals = document.querySelectorAll(".modal");
    modals.forEach((HTMLDivElement) => {
        HTMLDivElement.setAttribute("style", "display:none;");
        HTMLDivElement.setAttribute("data-visible", "0");
    });
    removeOverlay();
}

function setReservationPositions() {
    let reservations = document.querySelectorAll(".reservation-size");
    reservations.forEach((HTMLDivElement) => {
        let dateContent = HTMLDivElement.innerText.split(" ");
        let startHour = parseInt(dateContent[0]);
        let endHour = parseInt(dateContent[1]);
        let gridItem = HTMLDivElement.parentElement.parentElement;
        gridItem.setAttribute("style", `grid-area: ${startHour + 1}; grid-row: ${startHour + 1}/${endHour + 1};`);
    });
}



function displayOverlay() {
    console.log("Display Overlay");
    let overlay = document.querySelector(".overlay");
    overlay.setAttribute("style", "display:block;");
}
function removeOverlay() {
    console.log("Remove Overlay");

    let overlay = document.querySelector(".overlay");
    overlay.setAttribute("style", "display:none;");
}
document.addEventListener("DOMContentLoaded", () => {
    easeOutOfView();
});

function easeOutOfView() {
    let loadingScreen = document.querySelector("#loadingScreen");
    for (let i = 1; i < 10; i++) {
        setTimeout(() => { setOpacity(loadingScreen, 1 - i * 0.1); }, i * 20);
    }
    setTimeout(() => { loadingScreen.setAttribute("style", "display:none;"); }, 200);
}

function setOpacity(elem, opacity) {
    elem.setAttribute("style", `opacity:${opacity}`);
}
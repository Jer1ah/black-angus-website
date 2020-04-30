//on scroll navigation functionality
const navigationController = (function() {
    const nav = document.querySelector(".navigation");
    window.onscroll = () => {
        if(window.scrollY > 75) {
            nav.style.backgroundColor = "#2c292b";
        } else {
            nav.style.backgroundColor = "inherit";
        }
    };
}());
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


//mobile nav functionality
const mobileNavController = (function() {
    _mobileNavIcon = document.querySelector(".menuLink");
    _navList = document.querySelector(".navigation__list");
    _navigation = document.querySelector(".navigation");

    _mobileNavIcon.addEventListener("click", () => {
       if(window.getComputedStyle(_navList).getPropertyValue("display") === "none") {
           _navList.style.display = "flex";
           _mobileNavIcon.src = "img/exit.svg";
           _navList.style.backgroundColor = "#2c292b";
       } else {
            _navList.style.display = "none";
            _mobileNavIcon.src = "img/bars.svg";
            _navList.style.backgroundColor = "inherit";
       }
    });
}());


//making sure the navigation displays
const innerWidthController = (function() {
    window.onresize = () => {
        if(window.innerWidth > 875) {
            document.querySelector(".navigation__list").style.display = "flex";
            document.querySelector(".navigation__list").style.backgroundColor = "inherit";
            document.querySelector(".menuLink").src = "img/bars.svg";
        } else {
            document.querySelector(".navigation__list").style.display = "none";
            document.querySelector(".menuLink").src = "img/bars.svg";
        }
    }
}());
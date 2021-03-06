html, body {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
  font-size: 10px;
  position: relative;
  font-family: "Manrope", sans-serif;
  scroll-behavior: smooth;
}

.navigation {
  height: 7.7rem;
  width: 100%;
  position: fixed;
  top: 0;
  left: 0;
  transition: all 0.3s;
}
.navigation__list {
  list-style: none;
  padding: 0;
  margin: 0;
  height: 100%;
  width: 100%;
  display: flex;
  justify-content: center;
  align-items: center;
}
.navigation__listItem {
  margin: 0 1.88rem;
}
.navigation__listItem a {
  color: #bbb;
  text-decoration: none;
  font-size: 1.2rem;
  font-weight: 600;
  padding-bottom: 0.2rem;
}
.navigation__listItem .active {
  color: #fff;
}

.footer {
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  height: 12rem;
  background-color: #2c292b;
  position: relative;
}
.footer h5 {
  display: flex;
  align-items: center;
  font-size: 1.5rem;
  margin: 0 0 0.5rem;
  color: gray;
}
.footer img {
  width: 1.5rem;
  margin: 0 0.3rem;
}
.footer p {
  margin: 0;
  color: gray;
}
.footer a {
  position: absolute;
  width: 4rem;
  height: 5rem;
  background-color: #2c292b;
  display: flex;
  justify-content: center;
  align-items: center;
  top: -4.5rem;
}
.footer a img {
  width: 1.77rem;
}

.header {
  padding: 0.1rem;
  height: 100vh;
  background: url("../img/header-image.png");
  background-size: cover;
  background-position: center;
}
.header__heading {
  text-align: center;
  margin: 24rem auto 0;
}
.header__heading p {
  color: #fff;
  font-size: 2rem;
}

.mainAbout {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.mainAbout h3 {
  margin: 17.5rem 0 1rem;
  font-size: 2rem;
}
.mainAbout h1 {
  font-family: "Playfair Display", serif;
  font-size: 5rem;
  width: 60rem;
  text-align: center;
  margin: 0;
}
.mainAbout p {
  width: 60rem;
  text-align: center;
  line-height: 3rem;
  font-size: 1.6rem;
  color: #333;
}
.mainAbout h5 {
  margin: 2rem 0 17rem;
  font-size: 3.3rem;
  font-family: "Yellowtail", cursive;
  font-weight: lighter;
}

.mainMenu__list {
  list-style: none;
  padding: 0;
  margin: 0;
  display: flex;
  height: 30rem;
}
.mainMenu__listItem {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("https://jumixthemes.com/v4/ceder/wp-content/uploads/sites/5/2019/08/1-1280x720-1300x731.jpg");
  background-size: cover;
  background-position: center;
  height: 100%;
  flex: 1;
  display: flex;
  justify-content: center;
  align-items: center;
  transition: 1s;
}
.mainMenu__listItem .menuLink {
  display: inline-block;
  width: 90%;
  height: 85%;
  text-decoration: none;
}
.mainMenu__listItem .container {
  width: 100%;
  height: 100%;
  display: flex;
  flex-direction: column;
  align-items: center;
  transition: all 0.3s;
}
.mainMenu__listItem .container h3 {
  color: #fff;
  margin: 11rem 0 0;
  font-size: 2.2rem;
  font-weight: 800;
}
.mainMenu__listItem .container h5 {
  color: #fff;
  margin: 2.5rem 0 0;
  font-size: 1.3rem;
  opacity: 0;
}
.mainMenu__listItem:hover {
  cursor: pointer;
}
.mainMenu__listItem:hover .container {
  animation-name: animateBorder;
  animation-duration: 0.4s;
  animation-timing-function: ease-in;
  animation-fill-mode: forwards;
}
.mainMenu__listItem:hover .container h3 {
  animation-name: fadeDown;
  animation-duration: 0.4s;
  animation-fill-mode: forwards;
}
.mainMenu__listItem:hover .container h5 {
  animation-name: fadeUp;
  animation-duration: 0.4s;
  opacity: 1;
}
.mainMenu .two {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("https://jumixthemes.com/v4/ceder/wp-content/uploads/sites/5/2019/08/2-1280x720-1300x731.jpg");
  background-size: cover;
  background-position: center;
}
.mainMenu .three {
  background: linear-gradient(rgba(0, 0, 0, 0.5), rgba(0, 0, 0, 0.5)), url("https://jumixthemes.com/v4/ceder/wp-content/uploads/sites/5/2019/08/3-1280x720-1300x731.jpg");
  background-size: cover;
  background-position: center;
}
.mainMenu__reservations {
  background-color: #353234;
  padding: 0;
  margin: 0;
  height: 10rem;
  display: flex;
  align-items: center;
  justify-content: center;
}
.mainMenu__reservations h3 {
  color: #ccad8f;
  font-size: 2.2rem;
}

@keyframes fadeUp {
  0% {
    transform: translateY(2rem);
    opacity: 0;
  }
  100% {
    transform: translateY(0);
    opacity: 1;
  }
}
@keyframes fadeDown {
  0% {
    transform: translateY(0);
  }
  100% {
    transform: translateY(2rem);
  }
}
@keyframes animateBorder {
  0% {
    border: 0.1rem solid transparent;
  }
  100% {
    border: 0.1rem solid #fff;
  }
}
.mainInfo {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.mainInfo__list {
  display: flex;
  justify-content: space-between;
  align-items: flex-start;
  width: 110rem;
  margin: 15rem 0 5rem;
}
.mainInfo .hours {
  text-align: center;
}
.mainInfo .hours h3 {
  font-size: 2rem;
  margin: 0;
}
.mainInfo .hours h5 {
  font-size: 1.4rem;
  font-weight: 600;
  margin: 2.2rem 0 0;
}
.mainInfo .hours p {
  margin: 0.7rem 0 0;
  font-size: 1.4rem;
}
.mainInfo .questions {
  text-align: center;
}
.mainInfo .questions h3 {
  font-size: 2rem;
  margin: 0;
}
.mainInfo .questions h5 {
  font-size: 1.4rem;
  font-weight: 600;
  margin: 2.2rem 0 0;
}
.mainInfo .questions p {
  margin: 0.7rem 0 0;
  font-size: 1.4rem;
}
.mainInfo .questions img {
  margin-top: 0.7rem;
}
.mainInfo .dailyMenu {
  text-align: center;
}
.mainInfo .dailyMenu h3 {
  font-size: 2rem;
  margin: 0;
}
.mainInfo .dailyMenu__list {
  list-style: none;
  padding: 0.5rem 1rem;
  border: 0.5rem double #E5E5E5;
  width: 25rem;
}
.mainInfo .dailyMenu__listItem {
  display: flex;
  align-items: center;
  justify-content: space-between;
  margin: 0.88rem 0;
}
.mainInfo .dailyMenu__listItem h5 {
  font-size: 1.5rem;
  font-weight: 600;
  margin: 0;
}
.mainInfo .dailyMenu__listItem h5:last-child {
  font-size: 2rem;
}
.mainInfo a {
  text-decoration: none;
  display: inline-block;
  margin: 0 0 10rem;
  color: #fff;
  background-color: #353234;
  padding: 2.2rem 4rem;
  border-radius: 5rem;
  font-size: 1.2rem;
  font-weight: 700;
  letter-spacing: 0.1rem;
}

.mainSocial {
  display: flex;
  flex-direction: column;
  align-items: center;
  background-color: #353234;
}
.mainSocial h1 {
  font-family: "Playfair Display", serif;
  font-size: 4.5rem;
  margin: 15rem 0 0;
  color: #fff;
}
.mainSocial p {
  font-size: 1.5rem;
  width: 40rem;
  text-align: center;
  line-height: 3rem;
  color: #EDEDED;
}
.mainSocial__list {
  padding: 0;
  width: 90rem;
  margin: 8.8rem 0 15rem;
  list-style: none;
  display: flex;
  align-content: center;
  justify-content: space-between;
}
.mainSocial__listItem {
  display: flex;
  flex-direction: column;
  align-items: center;
  margin: 0;
  width: 15rem;
}
.mainSocial__listItem img {
  width: 5rem;
}
.mainSocial__listItem h3 {
  color: #fff;
  font-size: 1.88rem;
  margin: 1.5rem 0 0.5rem;
}
.mainSocial__listItem h5 {
  color: #EDEDED;
  font-size: 1.1rem;
  font-weight: 400;
  margin: 0;
}

.menusHeader {
  height: 45rem;
}
.menusHeader h1 {
  color: #fff;
  font-family: "Playfair Display", serif;
  font-size: 7.7rem;
  margin: 0;
}
.menusHeader p {
  font-size: 1.7rem;
  font-family: "Playfair Display", serif;
}
.menusHeader .header__heading {
  margin-top: 16rem;
}

.menuInfo {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.menuInfo h5 {
  margin: 15rem 0 0.7rem;
  font-size: 2rem;
}
.menuInfo h1 {
  font-family: "Playfair Display", serif;
  font-size: 4.5rem;
  text-align: center;
  margin: 0;
}
.menuInfo p {
  width: 55rem;
  text-align: center;
  line-height: 3rem;
  font-size: 1.6rem;
  color: #333;
}
.menuInfo h3 {
  margin: 2rem 0 17rem;
  font-size: 3.3rem;
  font-family: "Yellowtail", cursive;
  font-weight: lighter;
}

.menuContainer {
  width: 110rem;
  margin: 0 auto 15rem;
  display: flex;
  justify-content: space-between;
  align-items: flex-start;
}

.menu__list {
  padding: 2rem 3rem;
  list-style: none;
  width: 44rem;
  border: #333 double 0.7rem;
  margin: 0;
}
.menu__list h3 {
  background-color: #333;
  color: #fff;
  display: inline-block;
  font-size: 2rem;
  padding: 0.5rem 1rem;
  margin: 0.5rem 0 1rem;
  font-family: "Playfair Display", serif;
}
.menu__listItem {
  display: flex;
  align-items: flex-end;
  justify-content: space-between;
}
.menu__listItem h4 {
  font-size: 1.7rem;
  margin: 0;
  font-family: "Playfair Display", serif;
}
.menu__listItem h5 {
  font-size: 1.71rem;
  font-weight: 500;
  font-family: "Playfair Display", serif;
}
.menu__listItem p {
  color: gray;
  font-size: 1.2rem;
  font-family: "Playfair Display", serif;
}
.menu__images {
  width: 55rem;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
}
.menu__image {
  width: 49.5%;
  height: 25rem;
  margin-bottom: 0.6rem;
}
.menu__image img {
  width: 100%;
  height: 100%;
}

.reservationsHeader {
  height: 45rem;
}
.reservationsHeader h1 {
  color: #fff;
  font-family: "Playfair Display", serif;
  font-size: 7.7rem;
  margin: 0;
}
.reservationsHeader p {
  font-size: 1.7rem;
  font-family: "Playfair Display", serif;
}
.reservationsHeader .header__heading {
  margin-top: 16rem;
}

.reservationsInfo {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.reservationsInfo h5 {
  margin: 15rem 0 0.7rem;
  font-size: 2rem;
}
.reservationsInfo h1 {
  font-family: "Playfair Display", serif;
  font-size: 4.5rem;
  text-align: center;
  margin: 0;
}
.reservationsInfo p {
  width: 55rem;
  text-align: center;
  line-height: 3rem;
  font-size: 1.6rem;
  color: #333;
}
.reservationsInfo h3 {
  margin: 2rem 0 13rem;
  font-size: 3.3rem;
  font-family: "Yellowtail", cursive;
  font-weight: lighter;
}

.reservations__images {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.reservations__images h3 {
  font-size: 2rem;
  margin-bottom: 3rem;
}
.reservations__imagesList {
  width: 110rem;
  margin: 0 0 10rem;
  display: flex;
  flex-wrap: wrap;
  justify-content: space-between;
  list-style: none;
  padding: 0;
}
.reservations__imagesListItem {
  width: 33%;
  height: 33rem;
  margin-bottom: 0.5rem;
}
.reservations__imagesListItem img {
  width: 100%;
  height: 100%;
}

.reservationsRooms {
  width: 110rem;
  margin: 0 auto 10rem;
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
}

.reservationsRoom {
  width: 47%;
}
.reservationsRoom h1 {
  margin: 0;
  font-size: 2.2rem;
}
.reservationsRoom h3 {
  margin: 0.2rem 0 1rem;
  font-size: 1.7rem;
  color: #ccad8f;
}
.reservationsRoom p {
  font-size: 1.33rem;
  color: #222;
  line-height: 3rem;
}

.blogList {
  width: 110rem;
  margin: 10rem auto 3rem;
}

.blog {
  width: 100%;
  margin-bottom: 10rem;
  display: flex;
  flex-direction: column;
  align-items: flex-end;
}
.blog__heading {
  display: flex;
  align-items: flex-start;
  justify-content: space-between;
}
.blog__heading img {
  width: 90%;
}
.blog__heading span {
  display: flex;
  flex-direction: column;
  align-items: center;
}
.blog__heading h2 {
  font-size: 6.6rem;
  margin: 0;
  line-height: 5.5rem;
}
.blog__heading h5 {
  font-size: 1.5rem;
  margin: 1rem 0 0;
}
.blog__info {
  width: 90%;
}
.blog__info h1 {
  font-size: 2.7rem;
  margin: 2.5rem 0 1rem;
}
.blog__info p {
  margin: 0;
  font-size: 1.4rem;
  line-height: 2.9rem;
  color: #333;
}
.blog__info a {
  display: inline-block;
  color: #222;
  font-size: 1.4rem;
  font-weight: 700;
  margin-top: 2rem;
}

/*# sourceMappingURL=main.cs.map */

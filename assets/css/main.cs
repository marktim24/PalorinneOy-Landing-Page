@import url("https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Inter:wght@100;200;300;400;500;600;700;800;900&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Montserrat:wght@100;200;300;400;500;600;700;800;900&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Inter:wght@100;200;300;400;500;600;700;800;900&display=swap");
@import url("https://fonts.googleapis.com/css2?family=Poppins:wght@100;200;300;400;500;600;700;800;900&display=swap");
@keyframes zoom {
  0% {
    transform: scale(1);
  }
  50% {
    transform: scale(1.3, 1.3);
  }
  100% {
    transform: scale(1);
  }
}
@keyframes floating {
  0% {
    transform: translateX(-50%) translateY(0%);
  }
  50% {
    transform: translateX(-50%) translateY(8%);
  }
  100% {
    transform: translateX(-50%) translateY(0%);
  }
}
@keyframes floatingY {
  0% {
    transform: translateY(0%);
  }
  50% {
    transform: translateY(8%);
  }
  100% {
    transform: translateY(0%);
  }
}
@keyframes cliprotate {
  0% {
    transform: rotate(0deg);
    border-top-color: white;
  }
  25% {
    transform: rotate(90deg);
    border-top-color: white;
    border-right-color: white;
  }
  75% {
    transform: rotate(180deg);
    border-top-color: white;
    border-right-color: white;
    border-bottom-color: white;
  }
  100% {
    transform: rotate(360deg);
    border-top-color: white;
    border-right-color: white;
    border-bottom-color: white;
    border-left-color: white;
  }
}
@-moz-keyframes spin {
  100% {
    -moz-transform: rotate(360deg);
  }
}
@-webkit-keyframes spin {
  100% {
    -webkit-transform: rotate(360deg);
  }
}
@keyframes spin {
  100% {
    -webkit-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}
@keyframes orbit {
  0% {
    transform: rotateZ(0deg);
  }
  100% {
    transform: rotateZ(-360deg);
  }
}
@keyframes orbit-rotate {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(-360deg);
  }
}
@keyframes orbit-reverse {
  0% {
    transform: rotateZ(-3600deg);
  }
  100% {
    transform: rotateZ(0deg);
  }
}
@keyframes bgScrollLeft {
  from {
    background-position: 100% 0;
  }
  to {
    background-position: 100% -230px;
  }
}
@keyframes pulse {
  0% {
    -webkit-box-shadow: 0 0 0 0 #ffffff;
    box-shadow: 0 0 0 0 #ffffff;
  }
  70% {
    -webkit-box-shadow: 0 0 0 50px rgba(255, 255, 255, 0);
    box-shadow: 0 0 0 40px rgba(255, 255, 255, 0);
  }
  100% {
    -webkit-box-shadow: 0 0 0 0 rgba(255, 255, 255, 0);
    box-shadow: 0 0 0 0 rgba(255, 255, 255, 0);
  }
}
@keyframes action-bounce {
  0%, 100% {
    transform: translate(0, 0);
  }
  10% {
    transform: translate(0, 4px);
  }
  50% {
    transform: translate(0, -15px);
  }
  90% {
    transform: translate(0, 4px);
  }
}
@keyframes action-jelly {
  0%, 100% {
    transform: scaleX(1);
  }
  20% {
    transform: scaleX(0.9);
  }
  50% {
    transform: scaleX(1.25);
  }
  85% {
    transform: scaleX(0.8);
  }
}
@keyframes jello {
  11.1% {
    transform: none;
  }
  22.2% {
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }
  33.3% {
    transform: skewX(6.25deg) skewY(6.25deg);
  }
  44.4% {
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }
  55.5% {
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }
  66.6% {
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }
  77.7% {
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }
  88.8% {
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
  100% {
    transform: none;
  }
}
@keyframes jumping {
  0% {
    -webkit-transform: translateY(-40px);
    transform: translateY(-40px);
  }
  70% {
    -webkit-transform: scale(1.02, 0.9) translateY(10px);
    transform: scale(1.02, 0.9) translateY(10px);
  }
  100% {
    -webkit-transform: translateY(-40px);
    transform: translateY(-40px);
  }
}
@keyframes jumping-rotate {
  0% {
    -webkit-transform: translateY(-40px) rotate(45deg);
    transform: translateY(-40px) rotate(45deg);
  }
  70% {
    -webkit-transform: scale(1.02, 0.9) translateY(10px) rotate(45deg);
    transform: scale(1.02, 0.9) translateY(10px) rotate(45deg);
  }
  100% {
    -webkit-transform: translateY(-40px) rotate(45deg);
    transform: translateY(-40px) rotate(45deg);
  }
}
@keyframes boxWithShadow {
  0% {
    width: 80%;
    opacity: 1;
  }
  50% {
    width: 50%;
    opacity: 0.5;
  }
  to {
    width: 80%;
    opacity: 1;
  }
}
@keyframes bounceDown-on {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-8px);
  }
  to {
    transform: translateY(0);
  }
}
@keyframes bounceRight-on {
  0% {
    transform: translateX(0);
  }
  50% {
    transform: translateX(-8px);
  }
  to {
    transform: translateX(0);
  }
}
@keyframes bounceDown {
  0% {
    transform: translateY(0) scale(0.88);
  }
  50% {
    transform: translateY(-5rem) scale(0.88);
  }
  to {
    transform: translateY(0) scale(0.88);
  }
}
@keyframes shadowRegulator {
  0% {
    width: 80%;
    opacity: 1;
  }
  50% {
    width: 50%;
    opacity: 0.5;
  }
  to {
    width: 80%;
    opacity: 1;
  }
}
@keyframes upDown {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-1rem);
  }
  to {
    transform: translateY(0);
  }
}
@keyframes upDown2 {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-0.5rem);
  }
  to {
    transform: translateY(0);
  }
}
@keyframes upDown-totate {
  0% {
    transform: translateX(0);
  }
  50% {
    transform: translateX(-1rem);
  }
  to {
    transform: translateX(0);
  }
}
@keyframes scale1 {
  0% {
    transform: scale(1) rotate(0deg);
  }
  50% {
    transform: scale(1.1) rotate(360deg);
  }
  100% {
    transform: scale(1) rotate(0deg);
  }
}
@keyframes roate1 {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(360deg);
  }
}
@keyframes roate1rivers {
  from {
    transform: rotate(360deg);
  }
  to {
    transform: rotate(0deg);
  }
}
@keyframes scaleImage {
  0% {
    transform: scale(1);
  }
  50% {
    transform: scale(1.3);
  }
  100% {
    transform: scale(1);
  }
}
@keyframes backForward {
  0% {
    transform: translateX(0);
  }
  50% {
    transform: translateX(25%);
  }
  100% {
    transform: translateX(0%);
  }
}
@keyframes leftTop {
  from {
    opacity: 0;
    transform: rotate(360deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes leftBottom {
  from {
    opacity: 0;
    transform: rotate(-360deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes rightTop {
  from {
    opacity: 0;
    transform: rotate(-100deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes rightBottom {
  from {
    opacity: 0;
    transform: rotate(100deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes blurAnimate {
  0% {
    filter: blur(10px);
  }
  50% {
    filter: blur(5px);
  }
  100% {
    filter: blur(10px);
  }
}
@keyframes rightLeft {
  0% {
    transform: rotate(0deg);
  }
  50% {
    transform: rotate(45deg);
  }
  100% {
    transform: rotate(0deg);
  }
}
.montserrat {
  font-family: "Montserrat", sans-serif;
}

.poppins {
  font-family: "Poppins", sans-serif;
}

.inter {
  font-family: "Inter", sans-serif;
}

h1 {
  font-size: 70px;
}

h2 {
  font-size: 50px;
}
@media screen and (max-width: 768px) {
  h2 {
    font-size: 35px;
  }
}

h3 {
  font-size: 40px;
}
@media screen and (max-width: 768px) {
  h3 {
    font-size: 25px;
  }
}

h4 {
  font-size: 30px;
}
@media screen and (max-width: 768px) {
  h4 {
    font-size: 20px;
  }
}

h5 {
  font-size: 24px;
}
@media screen and (max-width: 768px) {
  h5 {
    font-size: 18px;
  }
}

h6 {
  font-size: 18px;
}
@media screen and (max-width: 768px) {
  h6 {
    font-size: 14px;
  }
}

h1,
h2,
h3,
h4,
h5 {
  font-weight: 900;
}

.thin {
  font-weight: 100 !important;
}

.extra-light {
  font-weight: 200 !important;
}

.light {
  font-weight: 300 !important;
}

.regular {
  font-weight: 400 !important;
}

.medium {
  font-weight: 500 !important;
}

.semi-bold {
  font-weight: 600 !important;
}

.bold {
  font-weight: 700 !important;
}

.extra-bold {
  font-weight: 800 !important;
}

.black {
  font-weight: 900 !important;
}

.normal {
  font-weight: normal !important;
}

.uppercase__font {
  text-transform: uppercase;
}

.capitalize__font {
  text-transform: capitalize;
}

.justify {
  text-align: justify;
}

.underline {
  text-decoration: underline;
}

@font-face {
  font-family: circular;
  src: url("../fonts/CircularStd-Book.ttf");
}
.circular {
  font-family: circular;
}

body {
  font-family: "Poppins", sans-serif;
  color: #171717;
  font-size: 16px;
  letter-spacing: 0.03em;
  line-height: 1.7em;
}

a {
  text-decoration: none;
}
a:hover {
  text-decoration: none;
}

img {
  max-width: 100%;
}

section {
  padding: 80px 0;
}

.container {
  max-width: 1300px;
}
@media screen and (max-width: 1200px) {
  .container {
    max-width: 92%;
  }
}

.divider {
  height: 30px;
}
.divider__xs {
  height: 10px;
}
.divider__sm {
  height: 20px;
}
.divider__md {
  height: 40px;
}
.divider__lg {
  height: 60px;
}
.divider__xlg {
  height: 80px;
}
.divider__xxlg {
  height: 100px;
}

.modal-content {
  border: 0;
  padding: 40px;
  border-radius: 10px;
}
.modal-content.send-mail {
  padding: 20px;
}

.tooltip {
  border-radius: 10px;
}
.tooltip > .tooltip-inner {
  padding: 8px 15px;
  font-weight: 500;
  font-family: "Lato";
  color: #ffffff !important;
  letter-spacing: 0.01em;
  font-size: 13px;
  background-color: #171717 !important;
}

.bs-tooltip-auto[x-placement^=bottom] .arrow::before,
.bs-tooltip-bottom .arrow::before {
  border-bottom-color: #171717 !important;
}

.bs-tooltip-auto[x-placement^=top] .arrow::before,
.bs-tooltip-top .arrow::before {
  border-top-color: #171717 !important;
}

.bs-tooltip-auto[x-placement^=left] .arrow::before,
.bs-tooltip-left .arrow::before {
  border-left-color: #171717 !important;
}

.bs-tooltip-auto[x-placement^=right] .arrow::before,
.bs-tooltip-right .arrow::before {
  border-right-color: #171717 !important;
}

.pointer {
  cursor: pointer;
}

.pointer__default {
  cursor: default;
}

.no__outline {
  outline-style: none !important;
}
.no__outline:focus {
  outline-style: none !important;
}

.modal {
  background-color: rgba(219, 223, 241, 0.6) !important;
}

.width__full {
  width: 100%;
}

.max-width-1140 {
  max-width: 1140px;
}
@media screen and (max-width: 576px) {
  .max-width-1140 {
    max-width: 92%;
  }
}

.object-fit-content {
  object-fit: contain !important;
}

.min-height-100 {
  min-height: 100vh;
}

@media screen and (max-width: 576px) {
  .min-height-sm-100 {
    min-height: 100vh;
  }
}

.max-height-100 {
  max-height: 100vh;
}

.height__100 {
  height: 100vh;
}

@media screen and (min-width: 1140px) {
  .height__xl-100 {
    height: 100vh;
  }
}

.no__maxwid {
  max-width: 100% !important;
}

.fit-content {
  max-width: fit-content !important;
}

@media screen and (max-width: 576px) {
  .no__xs-fit {
    max-width: inherit !important;
  }
}

.z-1 {
  z-index: 1;
}

.z-2 {
  z-index: 2;
}

.z-3 {
  z-index: 3;
}

.ul__nostyle {
  margin: 0;
  padding: 0;
  list-style: none;
}

@media screen and (min-width: 1440px) {
  .max-1440-up {
    max-width: 1440px;
    margin: 0 auto;
  }
}

.lh-2 {
  line-height: 2 !important;
}

.mt-min-10 {
  margin-top: -10px;
}

.bg__white {
  background-color: #ffffff !important;
}

.bg__black {
  background-color: #171717 !important;
}

.bg__green {
  background-color: #282849 !important;
}

.bg__orange {
  background-color: #f25248 !important;
}

.bg__transparent {
  background-color: transparent !important;
}

.bg__gray-1 {
  background-color: #b9b9b9 !important;
}

.bg__gray-2 {
  background-color: #f7f7f7 !important;
}

.opacity__1 {
  opacity: 0.1;
  transition: 0.5s;
}
.opacity__1.hover:hover {
  opacity: 1;
}

.opacity__2 {
  opacity: 0.2;
  transition: 0.5s;
}
.opacity__2.hover:hover {
  opacity: 1;
}

.opacity__3 {
  opacity: 0.3;
  transition: 0.5s;
}
.opacity__3.hover:hover {
  opacity: 1;
}

.opacity__4 {
  opacity: 0.4;
  transition: 0.5s;
}
.opacity__4.hover:hover {
  opacity: 1;
}

.opacity__5 {
  opacity: 0.5;
  transition: 0.5s;
}
.opacity__5.hover:hover {
  opacity: 1;
}

.opacity__6 {
  opacity: 0.6;
  transition: 0.5s;
}
.opacity__6.hover:hover {
  opacity: 1;
}

.opacity__7 {
  opacity: 0.7;
  transition: 0.5s;
}
.opacity__7.hover:hover {
  opacity: 1;
}

.opacity__8 {
  opacity: 0.8;
  transition: 0.5s;
}
.opacity__8.hover:hover {
  opacity: 1;
}

.opacity__9 {
  opacity: 0.9;
  transition: 0.5s;
}
.opacity__9.hover:hover {
  opacity: 1;
}

.opacity__10 {
  opacity: 1;
  transition: 0.5s;
}
.opacity__10.hover:hover {
  opacity: 1;
}

.border__radius--0 {
  border-radius: 0px !important;
}

.border__radius--1 {
  border-radius: 1px !important;
}

.border__radius--2 {
  border-radius: 2px !important;
}

.border__radius--3 {
  border-radius: 3px !important;
}

.border__radius--4 {
  border-radius: 4px !important;
}

.border__radius--5 {
  border-radius: 5px !important;
}

.border__radius--6 {
  border-radius: 6px !important;
}

.border__radius--7 {
  border-radius: 7px !important;
}

.border__radius--8 {
  border-radius: 8px !important;
}

.border__radius--9 {
  border-radius: 9px !important;
}

.border__radius--10 {
  border-radius: 10px !important;
}

.border__radius--11 {
  border-radius: 11px !important;
}

.border__radius--12 {
  border-radius: 12px !important;
}

.border__radius--13 {
  border-radius: 13px !important;
}

.border__radius--14 {
  border-radius: 14px !important;
}

.border__radius--15 {
  border-radius: 15px !important;
}

.border__radius--16 {
  border-radius: 16px !important;
}

.border__radius--17 {
  border-radius: 17px !important;
}

.border__radius--18 {
  border-radius: 18px !important;
}

.border__radius--19 {
  border-radius: 19px !important;
}

.border__radius--20 {
  border-radius: 20px !important;
}

.border__radius--21 {
  border-radius: 21px !important;
}

.border__radius--22 {
  border-radius: 22px !important;
}

.border__radius--23 {
  border-radius: 23px !important;
}

.border__radius--24 {
  border-radius: 24px !important;
}

.border__radius--25 {
  border-radius: 25px !important;
}

.border__radius--26 {
  border-radius: 26px !important;
}

.border__radius--27 {
  border-radius: 27px !important;
}

.border__radius--28 {
  border-radius: 28px !important;
}

.border__radius--29 {
  border-radius: 29px !important;
}

.border__radius--30 {
  border-radius: 30px !important;
}

.border__radius--31 {
  border-radius: 31px !important;
}

.border__radius--32 {
  border-radius: 32px !important;
}

.border__radius--33 {
  border-radius: 33px !important;
}

.border__radius--34 {
  border-radius: 34px !important;
}

.border__radius--35 {
  border-radius: 35px !important;
}

.border__radius--36 {
  border-radius: 36px !important;
}

.border__radius--37 {
  border-radius: 37px !important;
}

.border__radius--38 {
  border-radius: 38px !important;
}

.border__radius--39 {
  border-radius: 39px !important;
}

.border__radius--40 {
  border-radius: 40px !important;
}

.border__radius--41 {
  border-radius: 41px !important;
}

.border__radius--42 {
  border-radius: 42px !important;
}

.border__radius--43 {
  border-radius: 43px !important;
}

.border__radius--44 {
  border-radius: 44px !important;
}

.border__radius--45 {
  border-radius: 45px !important;
}

.border__radius--46 {
  border-radius: 46px !important;
}

.border__radius--47 {
  border-radius: 47px !important;
}

.border__radius--48 {
  border-radius: 48px !important;
}

.border__radius--49 {
  border-radius: 49px !important;
}

.border__radius--50 {
  border-radius: 50px !important;
}

.color__white {
  color: #ffffff !important;
}

.color__black {
  color: #171717 !important;
}

.color__green {
  color: #282849 !important;
}

.color__orange {
  color: #f25248 !important;
}

.color__transparent {
  color: transparent !important;
}

.color__gray-1 {
  color: #b9b9b9 !important;
}

.color__gray-2 {
  color: #f7f7f7 !important;
}

.fw__1 {
  font-weight: 100 !important;
}

.fw__2 {
  font-weight: 200 !important;
}

.fw__3 {
  font-weight: 300 !important;
}

.fw__4 {
  font-weight: 400 !important;
}

.fw__5 {
  font-weight: 500 !important;
}

.fw__6 {
  font-weight: 600 !important;
}

.fw__7 {
  font-weight: 700 !important;
}

.fw__8 {
  font-weight: 800 !important;
}

.lh__1 {
  line-height: 1.1 !important;
}

.lh__2 {
  line-height: 1.2 !important;
}

.lh__3 {
  line-height: 1.3 !important;
}

.lh__4 {
  line-height: 1.4 !important;
}

.lh__5 {
  line-height: 1.5 !important;
}

.lh__6 {
  line-height: 1.6 !important;
}

.lh__7 {
  line-height: 1.7 !important;
}

.lh__8 {
  line-height: 1.8 !important;
}

.lh__9 {
  line-height: 1.9 !important;
}

.ls__1 {
  letter-spacing: 0.2em !important;
}

.ls__2 {
  letter-spacing: 0.3em !important;
}

.ls__3 {
  letter-spacing: 0.4em !important;
}

.ls__4 {
  letter-spacing: 0.5em !important;
}

.ls__5 {
  letter-spacing: 0.6em !important;
}

.ls__6 {
  letter-spacing: 0.7em !important;
}

.ls__7 {
  letter-spacing: 0.8em !important;
}

.ls__8 {
  letter-spacing: 0.9em !important;
}

.ls__9 {
  letter-spacing: 1em !important;
}

.clamp__1 {
  display: -webkit-box !important;
  -webkit-line-clamp: 1;
  -webkit-box-orient: vertical;
  overflow: hidden;
}

.clamp__2 {
  display: -webkit-box !important;
  -webkit-line-clamp: 2;
  -webkit-box-orient: vertical;
  overflow: hidden;
}

.clamp__3 {
  display: -webkit-box !important;
  -webkit-line-clamp: 3;
  -webkit-box-orient: vertical;
  overflow: hidden;
}

.clamp__4 {
  display: -webkit-box !important;
  -webkit-line-clamp: 4;
  -webkit-box-orient: vertical;
  overflow: hidden;
}

.font__size--6 {
  font-size: 6px !important;
}

.font__size--7 {
  font-size: 7px !important;
}

.font__size--8 {
  font-size: 8px !important;
}

.font__size--9 {
  font-size: 9px !important;
}

.font__size--10 {
  font-size: 10px !important;
}

.font__size--11 {
  font-size: 11px !important;
}

.font__size--12 {
  font-size: 12px !important;
}

.font__size--13 {
  font-size: 13px !important;
}

.font__size--14 {
  font-size: 14px !important;
}

.font__size--15 {
  font-size: 15px !important;
}

.font__size--16 {
  font-size: 16px !important;
}

.font__size--17 {
  font-size: 17px !important;
}

.font__size--18 {
  font-size: 18px !important;
}

.font__size--19 {
  font-size: 19px !important;
}

.font__size--20 {
  font-size: 20px !important;
}

.font__size--21 {
  font-size: 21px !important;
}

.font__size--22 {
  font-size: 22px !important;
}

.font__size--23 {
  font-size: 23px !important;
}

.font__size--24 {
  font-size: 24px !important;
}

.font__size--25 {
  font-size: 25px !important;
}

.font__size--26 {
  font-size: 26px !important;
}

.font__size--27 {
  font-size: 27px !important;
}

.font__size--28 {
  font-size: 28px !important;
}

.font__size--29 {
  font-size: 29px !important;
}

.font__size--30 {
  font-size: 30px !important;
}

.font__size--31 {
  font-size: 31px !important;
}

.font__size--32 {
  font-size: 32px !important;
}

.font__size--33 {
  font-size: 33px !important;
}

.font__size--34 {
  font-size: 34px !important;
}

.font__size--35 {
  font-size: 35px !important;
}

.font__size--36 {
  font-size: 36px !important;
}

.font__size--37 {
  font-size: 37px !important;
}

.font__size--38 {
  font-size: 38px !important;
}

.font__size--39 {
  font-size: 39px !important;
}

.font__size--40 {
  font-size: 40px !important;
}

.font__size--41 {
  font-size: 41px !important;
}

.font__size--42 {
  font-size: 42px !important;
}

.font__size--43 {
  font-size: 43px !important;
}

.font__size--44 {
  font-size: 44px !important;
}

.font__size--45 {
  font-size: 45px !important;
}

.font__size--46 {
  font-size: 46px !important;
}

.font__size--47 {
  font-size: 47px !important;
}

.font__size--48 {
  font-size: 48px !important;
}

.font__size--49 {
  font-size: 49px !important;
}

.font__size--50 {
  font-size: 50px !important;
}

.font__size--51 {
  font-size: 51px !important;
}

.font__size--52 {
  font-size: 52px !important;
}

.font__size--53 {
  font-size: 53px !important;
}

.font__size--54 {
  font-size: 54px !important;
}

.font__size--55 {
  font-size: 55px !important;
}

.font__size--56 {
  font-size: 56px !important;
}

.font__size--57 {
  font-size: 57px !important;
}

.font__size--58 {
  font-size: 58px !important;
}

.font__size--59 {
  font-size: 59px !important;
}

.font__size--60 {
  font-size: 60px !important;
}

.font__size--61 {
  font-size: 61px !important;
}

.font__size--62 {
  font-size: 62px !important;
}

.font__size--63 {
  font-size: 63px !important;
}

.font__size--64 {
  font-size: 64px !important;
}

.font__size--65 {
  font-size: 65px !important;
}

.font__size--66 {
  font-size: 66px !important;
}

.font__size--67 {
  font-size: 67px !important;
}

.font__size--68 {
  font-size: 68px !important;
}

.font__size--69 {
  font-size: 69px !important;
}

.font__size--70 {
  font-size: 70px !important;
}

.font__size--71 {
  font-size: 71px !important;
}

.font__size--72 {
  font-size: 72px !important;
}

.font__size--73 {
  font-size: 73px !important;
}

.font__size--74 {
  font-size: 74px !important;
}

.font__size--75 {
  font-size: 75px !important;
}

.font__size--76 {
  font-size: 76px !important;
}

.font__size--77 {
  font-size: 77px !important;
}

.font__size--78 {
  font-size: 78px !important;
}

.font__size--79 {
  font-size: 79px !important;
}

.font__size--80 {
  font-size: 80px !important;
}

.font__size--81 {
  font-size: 81px !important;
}

.font__size--82 {
  font-size: 82px !important;
}

.font__size--83 {
  font-size: 83px !important;
}

.font__size--84 {
  font-size: 84px !important;
}

.font__size--85 {
  font-size: 85px !important;
}

.font__size--86 {
  font-size: 86px !important;
}

.font__size--87 {
  font-size: 87px !important;
}

.font__size--88 {
  font-size: 88px !important;
}

.font__size--89 {
  font-size: 89px !important;
}

.font__size--90 {
  font-size: 90px !important;
}

.font__size--91 {
  font-size: 91px !important;
}

.font__size--92 {
  font-size: 92px !important;
}

.font__size--93 {
  font-size: 93px !important;
}

.font__size--94 {
  font-size: 94px !important;
}

.font__size--95 {
  font-size: 95px !important;
}

.font__size--96 {
  font-size: 96px !important;
}

.font__size--97 {
  font-size: 97px !important;
}

.font__size--98 {
  font-size: 98px !important;
}

.font__size--99 {
  font-size: 99px !important;
}

.font__size--100 {
  font-size: 100px !important;
}

.font__size--101 {
  font-size: 101px !important;
}

.font__size--102 {
  font-size: 102px !important;
}

.font__size--103 {
  font-size: 103px !important;
}

.font__size--104 {
  font-size: 104px !important;
}

.font__size--105 {
  font-size: 105px !important;
}

.font__size--106 {
  font-size: 106px !important;
}

.font__size--107 {
  font-size: 107px !important;
}

.font__size--108 {
  font-size: 108px !important;
}

.font__size--109 {
  font-size: 109px !important;
}

.font__size--110 {
  font-size: 110px !important;
}

.font__size--111 {
  font-size: 111px !important;
}

.font__size--112 {
  font-size: 112px !important;
}

.font__size--113 {
  font-size: 113px !important;
}

.font__size--114 {
  font-size: 114px !important;
}

.font__size--115 {
  font-size: 115px !important;
}

.font__size--116 {
  font-size: 116px !important;
}

.font__size--117 {
  font-size: 117px !important;
}

.font__size--118 {
  font-size: 118px !important;
}

.font__size--119 {
  font-size: 119px !important;
}

.font__size--120 {
  font-size: 120px !important;
}

.font__size--121 {
  font-size: 121px !important;
}

.font__size--122 {
  font-size: 122px !important;
}

.font__size--123 {
  font-size: 123px !important;
}

.font__size--124 {
  font-size: 124px !important;
}

.font__size--125 {
  font-size: 125px !important;
}

.font__size--126 {
  font-size: 126px !important;
}

.font__size--127 {
  font-size: 127px !important;
}

.font__size--128 {
  font-size: 128px !important;
}

.font__size--129 {
  font-size: 129px !important;
}

.font__size--130 {
  font-size: 130px !important;
}

.font__size--131 {
  font-size: 131px !important;
}

.font__size--132 {
  font-size: 132px !important;
}

.font__size--133 {
  font-size: 133px !important;
}

.font__size--134 {
  font-size: 134px !important;
}

.font__size--135 {
  font-size: 135px !important;
}

.font__size--136 {
  font-size: 136px !important;
}

.font__size--137 {
  font-size: 137px !important;
}

.font__size--138 {
  font-size: 138px !important;
}

.font__size--139 {
  font-size: 139px !important;
}

.font__size--140 {
  font-size: 140px !important;
}

.font__size--141 {
  font-size: 141px !important;
}

.font__size--142 {
  font-size: 142px !important;
}

.font__size--143 {
  font-size: 143px !important;
}

.font__size--144 {
  font-size: 144px !important;
}

.font__size--145 {
  font-size: 145px !important;
}

.font__size--146 {
  font-size: 146px !important;
}

.font__size--147 {
  font-size: 147px !important;
}

.font__size--148 {
  font-size: 148px !important;
}

.font__size--149 {
  font-size: 149px !important;
}

.font__size--150 {
  font-size: 150px !important;
}

.font__size--151 {
  font-size: 151px !important;
}

.font__size--152 {
  font-size: 152px !important;
}

.font__size--153 {
  font-size: 153px !important;
}

.font__size--154 {
  font-size: 154px !important;
}

.font__size--155 {
  font-size: 155px !important;
}

.font__size--156 {
  font-size: 156px !important;
}

.font__size--157 {
  font-size: 157px !important;
}

.font__size--158 {
  font-size: 158px !important;
}

.font__size--159 {
  font-size: 159px !important;
}

.font__size--160 {
  font-size: 160px !important;
}

.font__size--161 {
  font-size: 161px !important;
}

.font__size--162 {
  font-size: 162px !important;
}

.font__size--163 {
  font-size: 163px !important;
}

.font__size--164 {
  font-size: 164px !important;
}

.font__size--165 {
  font-size: 165px !important;
}

.font__size--166 {
  font-size: 166px !important;
}

.font__size--167 {
  font-size: 167px !important;
}

.font__size--168 {
  font-size: 168px !important;
}

.font__size--169 {
  font-size: 169px !important;
}

.font__size--170 {
  font-size: 170px !important;
}

.font__size--171 {
  font-size: 171px !important;
}

.font__size--172 {
  font-size: 172px !important;
}

.font__size--173 {
  font-size: 173px !important;
}

.font__size--174 {
  font-size: 174px !important;
}

.font__size--175 {
  font-size: 175px !important;
}

.font__size--176 {
  font-size: 176px !important;
}

.font__size--177 {
  font-size: 177px !important;
}

.font__size--178 {
  font-size: 178px !important;
}

.font__size--179 {
  font-size: 179px !important;
}

.font__size--180 {
  font-size: 180px !important;
}

.font__size--181 {
  font-size: 181px !important;
}

.font__size--182 {
  font-size: 182px !important;
}

.font__size--183 {
  font-size: 183px !important;
}

.font__size--184 {
  font-size: 184px !important;
}

.font__size--185 {
  font-size: 185px !important;
}

.font__size--186 {
  font-size: 186px !important;
}

.font__size--187 {
  font-size: 187px !important;
}

.font__size--188 {
  font-size: 188px !important;
}

.font__size--189 {
  font-size: 189px !important;
}

.font__size--190 {
  font-size: 190px !important;
}

.font__size--191 {
  font-size: 191px !important;
}

.font__size--192 {
  font-size: 192px !important;
}

.font__size--193 {
  font-size: 193px !important;
}

.font__size--194 {
  font-size: 194px !important;
}

.font__size--195 {
  font-size: 195px !important;
}

.font__size--196 {
  font-size: 196px !important;
}

.font__size--197 {
  font-size: 197px !important;
}

.font__size--198 {
  font-size: 198px !important;
}

.font__size--199 {
  font-size: 199px !important;
}

.font__size--200 {
  font-size: 200px !important;
}

.montserrat {
  font-family: "Montserrat", sans-serif;
}

.poppins {
  font-family: "Poppins", sans-serif;
}

.inter {
  font-family: "Inter", sans-serif;
}

h1 {
  font-size: 70px;
}

h2 {
  font-size: 50px;
}
@media screen and (max-width: 768px) {
  h2 {
    font-size: 35px;
  }
}

h3 {
  font-size: 40px;
}
@media screen and (max-width: 768px) {
  h3 {
    font-size: 25px;
  }
}

h4 {
  font-size: 30px;
}
@media screen and (max-width: 768px) {
  h4 {
    font-size: 20px;
  }
}

h5 {
  font-size: 24px;
}
@media screen and (max-width: 768px) {
  h5 {
    font-size: 18px;
  }
}

h6 {
  font-size: 18px;
}
@media screen and (max-width: 768px) {
  h6 {
    font-size: 14px;
  }
}

h1,
h2,
h3,
h4,
h5 {
  font-weight: 900;
}

.thin {
  font-weight: 100 !important;
}

.extra-light {
  font-weight: 200 !important;
}

.light {
  font-weight: 300 !important;
}

.regular {
  font-weight: 400 !important;
}

.medium {
  font-weight: 500 !important;
}

.semi-bold {
  font-weight: 600 !important;
}

.bold {
  font-weight: 700 !important;
}

.extra-bold {
  font-weight: 800 !important;
}

.black {
  font-weight: 900 !important;
}

.normal {
  font-weight: normal !important;
}

.uppercase__font {
  text-transform: uppercase;
}

.capitalize__font {
  text-transform: capitalize;
}

.justify {
  text-align: justify;
}

.underline {
  text-decoration: underline;
}

@font-face {
  font-family: circular;
  src: url("../fonts/CircularStd-Book.ttf");
}
.circular {
  font-family: circular;
}

.btn {
  font-weight: 700;
  padding: 17px 45px;
  border-radius: 5px;
}
.btn:focus {
  box-shadow: none;
}
.btn__white {
  color: #f25248;
  background-color: #ffffff;
}
.btn__white.shadow {
  box-shadow: none !important;
}
.btn__white.shadow:hover {
  box-shadow: 0 15px 30px rgba(255, 255, 255, 0.5) !important;
}
.btn__outlined--white {
  border: 2px solid #ffffff;
  color: #ffffff;
  opacity: 0.3;
  background-color: transparent;
  transition: 0.5s;
}
.btn__outlined--white.b-1 {
  border: 1px solid #ffffff;
}
.btn__outlined--white.h__black:hover {
  background-color: #171717 !important;
}
.btn__outlined--white.no__opacity {
  opacity: 1 !important;
}
.btn__outlined--white.shadow {
  box-shadow: none !important;
}
.btn__outlined--white.shadow:hover {
  box-shadow: 0 15px 30px rgba(255, 255, 255, 0.5);
}
.btn__outlined--white:hover {
  opacity: 1;
  background-color: #ffffff;
  color: white !important;
}
.btn__outlined--white:hover.darkblue {
  color: !important;
}
.btn__outlined--white:hover.pink {
  color: !important;
}
.btn__black {
  color: #ffffff;
  background-color: #171717;
}
.btn__black.shadow {
  box-shadow: none !important;
}
.btn__black.shadow:hover {
  box-shadow: 0 15px 30px rgba(23, 23, 23, 0.5) !important;
}
.btn__outlined--black {
  border: 2px solid #171717;
  color: #171717;
  opacity: 0.3;
  background-color: transparent;
  transition: 0.5s;
}
.btn__outlined--black.b-1 {
  border: 1px solid #171717;
}
.btn__outlined--black.h__black:hover {
  background-color: #171717 !important;
}
.btn__outlined--black.no__opacity {
  opacity: 1 !important;
}
.btn__outlined--black.shadow {
  box-shadow: none !important;
}
.btn__outlined--black.shadow:hover {
  box-shadow: 0 15px 30px rgba(23, 23, 23, 0.5);
}
.btn__outlined--black:hover {
  opacity: 1;
  background-color: #171717;
  color: white !important;
}
.btn__outlined--black:hover.darkblue {
  color: !important;
}
.btn__outlined--black:hover.pink {
  color: !important;
}
.btn__green {
  color: #ffffff;
  background-color: #282849;
}
.btn__green.shadow {
  box-shadow: none !important;
}
.btn__green.shadow:hover {
  box-shadow: 0 15px 30px rgba(40, 40, 73, 0.5) !important;
}
.btn__outlined--green {
  border: 2px solid #282849;
  color: #282849;
  opacity: 0.3;
  background-color: transparent;
  transition: 0.5s;
}
.btn__outlined--green.b-1 {
  border: 1px solid #282849;
}
.btn__outlined--green.h__black:hover {
  background-color: #171717 !important;
}
.btn__outlined--green.no__opacity {
  opacity: 1 !important;
}
.btn__outlined--green.shadow {
  box-shadow: none !important;
}
.btn__outlined--green.shadow:hover {
  box-shadow: 0 15px 30px rgba(40, 40, 73, 0.5);
}
.btn__outlined--green:hover {
  opacity: 1;
  background-color: #282849;
  color: white !important;
}
.btn__outlined--green:hover.darkblue {
  color: !important;
}
.btn__outlined--green:hover.pink {
  color: !important;
}
.btn__orange {
  color: #ffffff;
  background-color: #f25248;
}
.btn__orange.shadow {
  box-shadow: none !important;
}
.btn__orange.shadow:hover {
  box-shadow: 0 15px 30px rgba(242, 82, 72, 0.5) !important;
}
.btn__outlined--orange {
  border: 2px solid #f25248;
  color: #f25248;
  opacity: 0.3;
  background-color: transparent;
  transition: 0.5s;
}
.btn__outlined--orange.b-1 {
  border: 1px solid #f25248;
}
.btn__outlined--orange.h__black:hover {
  background-color: #171717 !important;
}
.btn__outlined--orange.no__opacity {
  opacity: 1 !important;
}
.btn__outlined--orange.shadow {
  box-shadow: none !important;
}
.btn__outlined--orange.shadow:hover {
  box-shadow: 0 15px 30px rgba(242, 82, 72, 0.5);
}
.btn__outlined--orange:hover {
  opacity: 1;
  background-color: #f25248;
  color: white !important;
}
.btn__outlined--orange:hover.darkblue {
  color: !important;
}
.btn__outlined--orange:hover.pink {
  color: !important;
}
.btn__transparent {
  color: #ffffff;
  background-color: transparent;
}
.btn__transparent.shadow {
  box-shadow: none !important;
}
.btn__transparent.shadow:hover {
  box-shadow: 0 15px 30px rgba(0, 0, 0, 0) !important;
}
.btn__outlined--transparent {
  border: 2px solid transparent;
  color: transparent;
  opacity: 0.3;
  background-color: transparent;
  transition: 0.5s;
}
.btn__outlined--transparent.b-1 {
  border: 1px solid transparent;
}
.btn__outlined--transparent.h__black:hover {
  background-color: #171717 !important;
}
.btn__outlined--transparent.no__opacity {
  opacity: 1 !important;
}
.btn__outlined--transparent.shadow {
  box-shadow: none !important;
}
.btn__outlined--transparent.shadow:hover {
  box-shadow: 0 15px 30px rgba(0, 0, 0, 0);
}
.btn__outlined--transparent:hover {
  opacity: 1;
  background-color: transparent;
  color: white !important;
}
.btn__outlined--transparent:hover.darkblue {
  color: !important;
}
.btn__outlined--transparent:hover.pink {
  color: !important;
}
.btn__gray-1 {
  color: #f25248;
  background-color: #b9b9b9;
}
.btn__gray-1.shadow {
  box-shadow: none !important;
}
.btn__gray-1.shadow:hover {
  box-shadow: 0 15px 30px rgba(185, 185, 185, 0.5) !important;
}
.btn__outlined--gray-1 {
  border: 2px solid #b9b9b9;
  color: #b9b9b9;
  opacity: 0.3;
  background-color: transparent;
  transition: 0.5s;
}
.btn__outlined--gray-1.b-1 {
  border: 1px solid #b9b9b9;
}
.btn__outlined--gray-1.h__black:hover {
  background-color: #171717 !important;
}
.btn__outlined--gray-1.no__opacity {
  opacity: 1 !important;
}
.btn__outlined--gray-1.shadow {
  box-shadow: none !important;
}
.btn__outlined--gray-1.shadow:hover {
  box-shadow: 0 15px 30px rgba(185, 185, 185, 0.5);
}
.btn__outlined--gray-1:hover {
  opacity: 1;
  background-color: #b9b9b9;
  color: white !important;
}
.btn__outlined--gray-1:hover.darkblue {
  color: !important;
}
.btn__outlined--gray-1:hover.pink {
  color: !important;
}
.btn__gray-2 {
  color: #f25248;
  background-color: #f7f7f7;
}
.btn__gray-2.shadow {
  box-shadow: none !important;
}
.btn__gray-2.shadow:hover {
  box-shadow: 0 15px 30px rgba(247, 247, 247, 0.5) !important;
}
.btn__outlined--gray-2 {
  border: 2px solid #f7f7f7;
  color: #f7f7f7;
  opacity: 0.3;
  background-color: transparent;
  transition: 0.5s;
}
.btn__outlined--gray-2.b-1 {
  border: 1px solid #f7f7f7;
}
.btn__outlined--gray-2.h__black:hover {
  background-color: #171717 !important;
}
.btn__outlined--gray-2.no__opacity {
  opacity: 1 !important;
}
.btn__outlined--gray-2.shadow {
  box-shadow: none !important;
}
.btn__outlined--gray-2.shadow:hover {
  box-shadow: 0 15px 30px rgba(247, 247, 247, 0.5);
}
.btn__outlined--gray-2:hover {
  opacity: 1;
  background-color: #f7f7f7;
  color: white !important;
}
.btn__outlined--gray-2:hover.darkblue {
  color: !important;
}
.btn__outlined--gray-2:hover.pink {
  color: !important;
}

.btn__50 {
  border-radius: 50px;
}

/* item list */
@keyframes zoom {
  0% {
    transform: scale(1);
  }
  50% {
    transform: scale(1.3, 1.3);
  }
  100% {
    transform: scale(1);
  }
}
@keyframes floating {
  0% {
    transform: translateX(-50%) translateY(0%);
  }
  50% {
    transform: translateX(-50%) translateY(8%);
  }
  100% {
    transform: translateX(-50%) translateY(0%);
  }
}
@keyframes floatingY {
  0% {
    transform: translateY(0%);
  }
  50% {
    transform: translateY(8%);
  }
  100% {
    transform: translateY(0%);
  }
}
@keyframes cliprotate {
  0% {
    transform: rotate(0deg);
    border-top-color: white;
  }
  25% {
    transform: rotate(90deg);
    border-top-color: white;
    border-right-color: white;
  }
  75% {
    transform: rotate(180deg);
    border-top-color: white;
    border-right-color: white;
    border-bottom-color: white;
  }
  100% {
    transform: rotate(360deg);
    border-top-color: white;
    border-right-color: white;
    border-bottom-color: white;
    border-left-color: white;
  }
}
@-moz-keyframes spin {
  100% {
    -moz-transform: rotate(360deg);
  }
}
@-webkit-keyframes spin {
  100% {
    -webkit-transform: rotate(360deg);
  }
}
@keyframes spin {
  100% {
    -webkit-transform: rotate(360deg);
    transform: rotate(360deg);
  }
}
@keyframes orbit {
  0% {
    transform: rotateZ(0deg);
  }
  100% {
    transform: rotateZ(-360deg);
  }
}
@keyframes orbit-rotate {
  0% {
    transform: rotate(0deg);
  }
  100% {
    transform: rotate(-360deg);
  }
}
@keyframes orbit-reverse {
  0% {
    transform: rotateZ(-3600deg);
  }
  100% {
    transform: rotateZ(0deg);
  }
}
@keyframes bgScrollLeft {
  from {
    background-position: 100% 0;
  }
  to {
    background-position: 100% -230px;
  }
}
@keyframes pulse {
  0% {
    -webkit-box-shadow: 0 0 0 0 #ffffff;
    box-shadow: 0 0 0 0 #ffffff;
  }
  70% {
    -webkit-box-shadow: 0 0 0 50px rgba(255, 255, 255, 0);
    box-shadow: 0 0 0 40px rgba(255, 255, 255, 0);
  }
  100% {
    -webkit-box-shadow: 0 0 0 0 rgba(255, 255, 255, 0);
    box-shadow: 0 0 0 0 rgba(255, 255, 255, 0);
  }
}
@keyframes action-bounce {
  0%, 100% {
    transform: translate(0, 0);
  }
  10% {
    transform: translate(0, 4px);
  }
  50% {
    transform: translate(0, -15px);
  }
  90% {
    transform: translate(0, 4px);
  }
}
@keyframes action-jelly {
  0%, 100% {
    transform: scaleX(1);
  }
  20% {
    transform: scaleX(0.9);
  }
  50% {
    transform: scaleX(1.25);
  }
  85% {
    transform: scaleX(0.8);
  }
}
@keyframes jello {
  11.1% {
    transform: none;
  }
  22.2% {
    transform: skewX(-12.5deg) skewY(-12.5deg);
  }
  33.3% {
    transform: skewX(6.25deg) skewY(6.25deg);
  }
  44.4% {
    transform: skewX(-3.125deg) skewY(-3.125deg);
  }
  55.5% {
    transform: skewX(1.5625deg) skewY(1.5625deg);
  }
  66.6% {
    transform: skewX(-0.78125deg) skewY(-0.78125deg);
  }
  77.7% {
    transform: skewX(0.390625deg) skewY(0.390625deg);
  }
  88.8% {
    transform: skewX(-0.1953125deg) skewY(-0.1953125deg);
  }
  100% {
    transform: none;
  }
}
@keyframes jumping {
  0% {
    -webkit-transform: translateY(-40px);
    transform: translateY(-40px);
  }
  70% {
    -webkit-transform: scale(1.02, 0.9) translateY(10px);
    transform: scale(1.02, 0.9) translateY(10px);
  }
  100% {
    -webkit-transform: translateY(-40px);
    transform: translateY(-40px);
  }
}
@keyframes jumping-rotate {
  0% {
    -webkit-transform: translateY(-40px) rotate(45deg);
    transform: translateY(-40px) rotate(45deg);
  }
  70% {
    -webkit-transform: scale(1.02, 0.9) translateY(10px) rotate(45deg);
    transform: scale(1.02, 0.9) translateY(10px) rotate(45deg);
  }
  100% {
    -webkit-transform: translateY(-40px) rotate(45deg);
    transform: translateY(-40px) rotate(45deg);
  }
}
@keyframes boxWithShadow {
  0% {
    width: 80%;
    opacity: 1;
  }
  50% {
    width: 50%;
    opacity: 0.5;
  }
  to {
    width: 80%;
    opacity: 1;
  }
}
@keyframes bounceDown-on {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-8px);
  }
  to {
    transform: translateY(0);
  }
}
@keyframes bounceRight-on {
  0% {
    transform: translateX(0);
  }
  50% {
    transform: translateX(-8px);
  }
  to {
    transform: translateX(0);
  }
}
@keyframes bounceDown {
  0% {
    transform: translateY(0) scale(0.88);
  }
  50% {
    transform: translateY(-5rem) scale(0.88);
  }
  to {
    transform: translateY(0) scale(0.88);
  }
}
@keyframes shadowRegulator {
  0% {
    width: 80%;
    opacity: 1;
  }
  50% {
    width: 50%;
    opacity: 0.5;
  }
  to {
    width: 80%;
    opacity: 1;
  }
}
@keyframes upDown {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-1rem);
  }
  to {
    transform: translateY(0);
  }
}
@keyframes upDown2 {
  0% {
    transform: translateY(0);
  }
  50% {
    transform: translateY(-0.5rem);
  }
  to {
    transform: translateY(0);
  }
}
@keyframes upDown-totate {
  0% {
    transform: translateX(0);
  }
  50% {
    transform: translateX(-1rem);
  }
  to {
    transform: translateX(0);
  }
}
@keyframes scale1 {
  0% {
    transform: scale(1) rotate(0deg);
  }
  50% {
    transform: scale(1.1) rotate(360deg);
  }
  100% {
    transform: scale(1) rotate(0deg);
  }
}
@keyframes roate1 {
  from {
    transform: rotate(0deg);
  }
  to {
    transform: rotate(360deg);
  }
}
@keyframes roate1rivers {
  from {
    transform: rotate(360deg);
  }
  to {
    transform: rotate(0deg);
  }
}
@keyframes scaleImage {
  0% {
    transform: scale(1);
  }
  50% {
    transform: scale(1.3);
  }
  100% {
    transform: scale(1);
  }
}
@keyframes backForward {
  0% {
    transform: translateX(0);
  }
  50% {
    transform: translateX(25%);
  }
  100% {
    transform: translateX(0%);
  }
}
@keyframes leftTop {
  from {
    opacity: 0;
    transform: rotate(360deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes leftBottom {
  from {
    opacity: 0;
    transform: rotate(-360deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes rightTop {
  from {
    opacity: 0;
    transform: rotate(-100deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes rightBottom {
  from {
    opacity: 0;
    transform: rotate(100deg);
  }
  to {
    opacity: 1;
    transform: rotate(0deg);
  }
}
@keyframes blurAnimate {
  0% {
    filter: blur(10px);
  }
  50% {
    filter: blur(5px);
  }
  100% {
    filter: blur(10px);
  }
}
@keyframes rightLeft {
  0% {
    transform: rotate(0deg);
  }
  50% {
    transform: rotate(45deg);
  }
  100% {
    transform: rotate(0deg);
  }
}
.animate__pulse {
  animation: pulse 3s ease-in-out infinite;
}
.animate__float1 {
  animation: floatingY 4s ease-in-out infinite;
}
.animate__float2 {
  animation: floatingY 6s ease-in-out infinite;
}

.mt__5 {
  margin-top: 5rem;
}

.my__5 {
  margin-top: 5rem;
  margin-bottom: 5rem;
}
@media screen and (max-width: 576px) {
  .my__5.sm-3 {
    margin-top: 3rem;
    margin-bottom: 3rem;
  }
}

.mb__5 {
  margin-bottom: 5rem;
}
@media screen and (max-width: 576px) {
  .mb__5 {
    margin-bottom: 3rem;
  }
}

.wrapper__subscribe input {
  background-color: transparent;
  border-radius: 0;
  border: none;
  height: 60px;
  background-color: rgba(213, 215, 216, 0.1);
  padding: 5px 25px;
  width: 380px;
  outline-style: none;
  box-shadow: none;
}
.wrapper__subscribe input:hover {
  background-color: rgba(213, 215, 216, 0.1);
  border-radius: 0;
  border: none;
  box-shadow: none;
  outline-style: none;
}
.wrapper__subscribe input:active {
  background-color: rgba(213, 215, 216, 0.1);
  border-radius: 0;
  border: none;
  box-shadow: none;
  outline-style: none;
}
.wrapper__subscribe input:focus {
  background-color: rgba(213, 215, 216, 0.1);
  border-radius: 0;
  border: none;
  box-shadow: none;
  outline-style: none;
}
.wrapper__quote {
  position: absolute;
  display: inline-block;
  padding: 1.5rem;
  background-color: white;
  max-width: 330px;
  right: 0;
  bottom: 0;
  z-index: 3;
  box-shadow: 0px 10px 60px 0px rgba(255, 255, 255, 0.2);
}
@media screen and (max-width: 1024px) {
  .wrapper__quote {
    max-width: 255px;
  }
}
@media screen and (max-width: 512px) {
  .wrapper__quote {
    position: initial;
    margin: 0 auto;
  }
}
.wrapper__quote .icon {
  width: 60px;
  height: 60px;
  border-radius: 50%;
  background-color: white;
  box-shadow: 0px 10px 60px 0px rgba(0, 0, 0, 0.1019607843);
  margin: 0 auto;
  display: flex;
  justify-content: center;
  align-items: center;
  margin-top: -3.5rem;
}
.wrapper__arrows .left {
  width: 50px;
  height: 50px;
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: white;
  padding: 5px;
}
.wrapper__arrows .left svg path {
  transition: 0.5s;
}
.wrapper__arrows .right {
  width: 50px;
  height: 50px;
  border-radius: 50%;
  display: flex;
  justify-content: center;
  align-items: center;
  background-color: white;
  padding: 5px;
}
.wrapper__arrows .right svg path {
  transition: 0.5s;
}
.wrapper__arrows .left:hover {
  background-color: #f25248;
}
.wrapper__arrows .left:hover svg path {
  fill: white !important;
}
.wrapper__arrows .right:hover {
  background-color: #f25248;
}
.wrapper__arrows .right:hover svg path {
  fill: white !important;
}
.wrapper__card-blog .img {
  width: 198px;
  height: 198px;
  object-fit: cover;
}
@media screen and (max-width: 480px) {
  .wrapper__card-blog .img {
    width: 120px;
    height: 180px;
  }
}
@media screen and (max-width: 425px) {
  .wrapper__card-blog .img {
    display: none;
  }
}
@media screen and (max-width: 425px) {
  .wrapper__card-blog .desc {
    margin-left: 0 !important;
  }
}
.wrapper__service-img .img {
  width: 100%;
  height: 385px;
  object-fit: contain;
}
.wrapper__service-img .link {
  transition: 0.5s;
}
.wrapper__service-img .link svg path {
  transition: 0.5s;
}
.wrapper__service-img .link:hover {
  color: #f25248 !important;
}
.wrapper__service-img .link:hover svg path {
  fill: #f25248 !important;
}

wrapper__card-blog .images__blog-first {
  width: 100%;
  height: 400px;
  object-fit: cover;
}
@media screen and (max-width: 480px) {
  wrapper__card-blog .images__blog-first {
    height: 300px;
  }
}

.list__footer {
  margin: 0;
  padding: 0;
  list-style: none;
}
.list__footer li {
  margin-right: 20px;
  display: inline-block;
}
.list__footer li a {
  transition: 0.5s;
}
.list__footer li a:hover {
  color: #f25248 !important;
}
.list__footer li:last-child {
  margin-right: 0px;
}

.bg__head {
  background-repeat: no-repeat;
  background-position: center;
  background-size: cover;
}
@media screen and (max-width: 768px) {
  .bg__head {
    background-position: 26% 100%;
  }
}

.zoom__effect {
  transform: scale(0.85);
  transition: 0.3s ease-in;
}
.zoom__effect:hover,
.zoom__effect :active {
  transform: scale(1);
}
.zoom__effect:hover > img,
.zoom__effect :active > img {
  transition: 0.3s ease-in-out;
  transform: scaleX(-1);
}

.btn__sub {
  height: 60px;
  background-color: #f25248;
  border-radius: 4px;
  padding: 20px;
  border: none;
  text-align: center;
  display: flex;
  justify-content: center;
  align-items: center;
}
.btn__sub:hover {
  box-shadow: 0 15px 30px rgba(242, 82, 72, 0.5) !important;
}
.btn__normal {
  padding: 17px 26px;
  border-radius: 0;
}

.path__1 {
  position: absolute;
  left: 50%;
  bottom: 0;
  height: 95%;
  transform: translateX(-39%);
}

.text__underline {
  text-decoration: underline;
}

@media screen and (max-width: 1024px) {
  .text__163-1024 {
    font-size: 100px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__163-md {
    font-size: 90px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__163-sm {
    font-size: 65px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__163-xs {
    font-size: 50px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__100-1024 {
    font-size: 80px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__100-sm {
    font-size: 80px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__100-mm {
    font-size: 60px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__100-xs {
    font-size: 50px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__100-xxs {
    font-size: 45px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__200-md {
    font-size: 150px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__200-sm {
    font-size: 125px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__200-sm {
    font-size: 100px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__200-xx {
    font-size: 85px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__200-xxs {
    font-size: 75px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__72-1024 {
    font-size: 48px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__72-xs {
    font-size: 36px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__80-1024 {
    font-size: 65px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__80-md {
    font-size: 50px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__80-sm {
    font-size: 40px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__80-xs {
    font-size: 36px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__80-xxs {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__70-1024 {
    font-size: 60px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__70-md {
    font-size: 50px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__70-sm {
    font-size: 50px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__70-xs {
    font-size: 40px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__70-xxs {
    font-size: 35px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__65-1024 {
    font-size: 45px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__65-md {
    font-size: 35px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__60-1024 {
    font-size: 50px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__60-sm {
    font-size: 35px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__60-mm {
    font-size: 35px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__60-xxs {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__50-1024 {
    font-size: 40px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__50-sm {
    font-size: 40px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__25-sm {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__45-1024 {
    font-size: 35px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__45-md {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__45-mm {
    font-size: 24px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__40-1024 {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__40-md {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__40-mm {
    font-size: 24px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__30-1024 {
    font-size: 25px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__30-md {
    font-size: 25px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__30-sm {
    font-size: 25px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__30-xx {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__32-1024 {
    font-size: 25px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__32-xs {
    font-size: 18px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__36-1024 {
    font-size: 28px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__28-1024 {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__28-sm {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__28-xs {
    font-size: 16px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__35-1024 {
    font-size: 28px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__35-md {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__35-xs {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__38-1024 {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__90-1024 {
    font-size: 60px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__90-xs {
    font-size: 40px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__33-sm {
    font-size: 25px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__33-xx {
    font-size: 18px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__16-1024 {
    font-size: 14px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__16-1024-12 {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__16-1024-10 {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__16-md {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__16-sm {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__16-mm {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__16-mm-12 {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__16-xx {
    font-size: 7px !important;
    line-height: 16px;
  }
}
@media screen and (max-width: 1024px) {
  .text__20-1024 {
    font-size: 16px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__20-md {
    font-size: 14px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__20-sm {
    font-size: 14px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__20-xxs {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__120-1024 {
    font-size: 100px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__120-sm {
    font-size: 90px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__120-sm {
    font-size: 75px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__120-xxs {
    font-size: 65px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__26-md {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__26-sm {
    font-size: 14px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__22-1024 {
    font-size: 16px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__22-md {
    font-size: 16px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__22-sm {
    font-size: 14px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__12-md {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__12-sm {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__12-sm-8 {
    font-size: 8px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__12-xs {
    font-size: 8px !important;
  }
}
@media screen and (max-width: 480px) {
  .text__12-xs-10 {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__12-mm {
    font-size: 8px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__12-mm-10 {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__12-xxs {
    font-size: 8px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__14-1024 {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__14-1024-10 {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__14-md {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__14-sm-8 {
    font-size: 8px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__14-mm {
    font-size: 9px !important;
  }
}
@media screen and (max-width: 512px) {
  .text__14-mm-10 {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__14-xx {
    font-size: 10px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__14-xx-8 {
    font-size: 8px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__8-xxs {
    font-size: 6px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__24-1024 {
    font-size: 18px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__24-sm {
    font-size: 16px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__25-1024 {
    font-size: 20px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__36-1024 {
    font-size: 25px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__36-sm {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__18-1024 {
    font-size: 16px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__18-md {
    font-size: 14px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__18-sm {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 425px) {
  .text__18-xx {
    font-size: 10px !important;
    line-height: 16px;
  }
}
@media screen and (max-width: 425px) {
  .text__18-xx-14 {
    font-size: 14px !important;
    line-height: 16px;
  }
}
@media screen and (max-width: 480px) {
  .text__18-xs {
    font-size: 14px !important;
  }
}
@media screen and (max-width: 375px) {
  .text__18-xxs {
    font-size: 12px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__58-sm {
    font-size: 45px !important;
  }
}
@media screen and (max-width: 1024px) {
  .text__48-1024 {
    font-size: 35px !important;
  }
}
@media screen and (max-width: 768px) {
  .text__48-md {
    font-size: 30px !important;
  }
}
@media screen and (max-width: 576px) {
  .text__48-sm {
    font-size: 30px !important;
  }
}

.wrapper__nav-group {
  padding: 1.5rem 0;
}
.wrapper__nav-group .menu__center {
  position: absolute;
  left: 50%;
  top: 50%;
  transform: translate(-25%, -50%);
}
.wrapper__nav-group .menu__center ul li {
  margin: 0 20px;
}
.wrapper__nav-group .menu__center ul li .nav-link {
  transition: 0.5s;
}
.wrapper__nav-group .menu__center ul li .nav-link.active {
  color: #f25248 !important;
  opacity: 1;
}
.wrapper__nav-group .menu__center ul li .nav-link:hover {
  color: #f25248 !important;
}
@media screen and (max-width: 768px) {
  .wrapper__nav-group .menu__center {
    position: initial;
    left: initial;
    top: initial;
    transform: initial;
  }
  .wrapper__nav-group .menu__center ul {
    margin-top: 15px;
  }
  .wrapper__nav-group .menu__center ul li {
    margin: 0;
  }
}

.nav__button {
  display: flex;
  justify-content: flex-end;
  align-items: center;
  flex-wrap: wrap;
  width: 30px;
  height: 30px;
  padding: 0;
  outline-style: none;
}
.nav__button span {
  width: 100%;
  height: 2px;
  background-color: #f25248;
  margin-bottom: 5px;
  display: inline-block;
  transition: 0.5s;
}
.nav__button span:nth-child(2) {
  width: 80%;
}
.nav__button span:nth-child(3) {
  width: 60%;
  margin-bottom: 0;
}
.nav__button:active {
  outline-style: none;
}
.nav__button:hover {
  outline-style: none;
}
.nav__button:focus {
  outline-style: none;
}
.nav__button[aria-expanded=true] span:nth-child(1) {
  position: absolute;
  transform: rotate(45deg);
  margin-bottom: 0;
}
.nav__button[aria-expanded=true] span:nth-child(2) {
  display: none;
  margin-bottom: 0;
}
.nav__button[aria-expanded=true] span:nth-child(3) {
  width: 100%;
  position: absolute;
  transform: rotate(-45deg);
}

.input__control {
  background: #FFFFFF;
  border: 1px solid #E0E0E0;
  border-radius: 8px;
  height: 68px;
}
.input__control:focus {
  box-shadow: none;
  border: 1px solid #E0E0E0;
}

/*# sourceMappingURL=main.cs.map */

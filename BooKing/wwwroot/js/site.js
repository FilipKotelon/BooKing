/******/ (() => { // webpackBootstrap
/******/ 	"use strict";
/******/ 	var __webpack_modules__ = ({

/***/ "./wwwroot/js/site/nav/nav-open.js":
/*!*****************************************!*\
  !*** ./wwwroot/js/site/nav/nav-open.js ***!
  \*****************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => __WEBPACK_DEFAULT_EXPORT__
/* harmony export */ });
var navOpen = function navOpen() {};

/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (navOpen);

/***/ }),

/***/ "./wwwroot/js/site/nav/nav-scroll.js":
/*!*******************************************!*\
  !*** ./wwwroot/js/site/nav/nav-scroll.js ***!
  \*******************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => __WEBPACK_DEFAULT_EXPORT__
/* harmony export */ });
var navScroll = function navScroll() {
  var nav = document.getElementById('nav');
  console.log('hello');
  if (!nav) return;

  var scrollF = function scrollF() {
    if (!nav.classList.contains('fixed') && window.pageYOffset > 0) {
      nav.classList.add('fixed');
    } else if (nav.classList.contains('fixed') && window.pageYOffset === 0) {
      nav.classList.remove('fixed');
    }
  };

  window.onscroll = function () {
    return scrollF();
  };

  scrollF();
};

/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (navScroll);

/***/ }),

/***/ "./wwwroot/js/site/nav/nav.js":
/*!************************************!*\
  !*** ./wwwroot/js/site/nav/nav.js ***!
  \************************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony export */ __webpack_require__.d(__webpack_exports__, {
/* harmony export */   "default": () => __WEBPACK_DEFAULT_EXPORT__
/* harmony export */ });
/* harmony import */ var _nav_open__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./nav-open */ "./wwwroot/js/site/nav/nav-open.js");
/* harmony import */ var _nav_scroll__WEBPACK_IMPORTED_MODULE_1__ = __webpack_require__(/*! ./nav-scroll */ "./wwwroot/js/site/nav/nav-scroll.js");



var nav = function nav() {
  (0,_nav_open__WEBPACK_IMPORTED_MODULE_0__.default)();
  (0,_nav_scroll__WEBPACK_IMPORTED_MODULE_1__.default)();
};

/* harmony default export */ const __WEBPACK_DEFAULT_EXPORT__ = (nav);

/***/ }),

/***/ "./wwwroot/js/site/script.js":
/*!***********************************!*\
  !*** ./wwwroot/js/site/script.js ***!
  \***********************************/
/***/ ((__unused_webpack_module, __webpack_exports__, __webpack_require__) => {

__webpack_require__.r(__webpack_exports__);
/* harmony import */ var _nav_nav__WEBPACK_IMPORTED_MODULE_0__ = __webpack_require__(/*! ./nav/nav */ "./wwwroot/js/site/nav/nav.js");

console.log('hi');
(0,_nav_nav__WEBPACK_IMPORTED_MODULE_0__.default)();

/***/ })

/******/ 	});
/************************************************************************/
/******/ 	// The module cache
/******/ 	var __webpack_module_cache__ = {};
/******/ 	
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/ 		// Check if module is in cache
/******/ 		if(__webpack_module_cache__[moduleId]) {
/******/ 			return __webpack_module_cache__[moduleId].exports;
/******/ 		}
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = __webpack_module_cache__[moduleId] = {
/******/ 			// no module.id needed
/******/ 			// no module.loaded needed
/******/ 			exports: {}
/******/ 		};
/******/ 	
/******/ 		// Execute the module function
/******/ 		__webpack_modules__[moduleId](module, module.exports, __webpack_require__);
/******/ 	
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/ 	
/************************************************************************/
/******/ 	/* webpack/runtime/define property getters */
/******/ 	(() => {
/******/ 		// define getter functions for harmony exports
/******/ 		__webpack_require__.d = (exports, definition) => {
/******/ 			for(var key in definition) {
/******/ 				if(__webpack_require__.o(definition, key) && !__webpack_require__.o(exports, key)) {
/******/ 					Object.defineProperty(exports, key, { enumerable: true, get: definition[key] });
/******/ 				}
/******/ 			}
/******/ 		};
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/hasOwnProperty shorthand */
/******/ 	(() => {
/******/ 		__webpack_require__.o = (obj, prop) => Object.prototype.hasOwnProperty.call(obj, prop)
/******/ 	})();
/******/ 	
/******/ 	/* webpack/runtime/make namespace object */
/******/ 	(() => {
/******/ 		// define __esModule on exports
/******/ 		__webpack_require__.r = (exports) => {
/******/ 			if(typeof Symbol !== 'undefined' && Symbol.toStringTag) {
/******/ 				Object.defineProperty(exports, Symbol.toStringTag, { value: 'Module' });
/******/ 			}
/******/ 			Object.defineProperty(exports, '__esModule', { value: true });
/******/ 		};
/******/ 	})();
/******/ 	
/************************************************************************/
/******/ 	// startup
/******/ 	// Load entry module
/******/ 	__webpack_require__("./wwwroot/js/site/script.js");
/******/ 	// This entry module used 'exports' so it can't be inlined
/******/ })()
;
//# sourceMappingURL=site.js.map
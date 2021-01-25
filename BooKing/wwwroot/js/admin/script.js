import addApartmentCtrl from "./apartmentSingle/addApartmentCtrl";
import editApartmentCtrl from "./apartmentSingle/editApartmentCtrl";
import apartmentCarousel from "./carousels/apartmentCarousel";
import imageModal from "./imageModal/imageModal.main";

(function(){
  addApartmentCtrl();
  editApartmentCtrl();

  apartmentCarousel();
  
  imageModal();
})()
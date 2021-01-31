import imageLibrary from "./imageLibrary";
import imageUpload from "./imageUpload";
import modalOpening from "./modalOpening";
import tabSwitch from "./tabSwitch";

export const adminImageModalEl = document.getElementById('admin-image-modal');
export let boundInput = null;

if(adminImageModalEl){
  boundInput = document.getElementById(adminImageModalEl.dataset.for);
}

const imageModal = () => {
  if(!adminImageModalEl) return;

  imageUpload();
  imageLibrary();
  modalOpening();
  tabSwitch();
}

export default imageModal;
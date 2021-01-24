import imageLibrary from "./imageLibrary";
import imageUpload from "./imageUpload";

export const adminImageModalEl = document.getElementById('admin-image-modal');
export const adminImageModalCloser = document.getElementById('admin-image-modal-closer');
export const boundInput = document.getElementById(adminImageModalEl.dataset.for);

const imageModal = () => {
  if(!adminImageModalEl) return;

  imageUpload();
  imageLibrary();
}

export default imageModal;
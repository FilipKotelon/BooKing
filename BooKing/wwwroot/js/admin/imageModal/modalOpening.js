import { adminImageModalEl } from "./imageModal.main";

const modalOpening = () => {
  const opener = document.getElementById('admin-image-modal-opener');
  const closers = document.querySelectorAll('.admin-image-modal-closer');

  opener.addEventListener('click', () => {
    adminImageModalEl.classList.add('open');
  })

  closers.forEach(closer => {
    closer.addEventListener('click', () => {
      adminImageModalEl.classList.remove('open');
    })
  })
}

export default modalOpening;
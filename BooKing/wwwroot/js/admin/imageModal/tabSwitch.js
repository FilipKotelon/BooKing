import { adminImageModalEl } from "./imageModal.main"

const tabSwitch = () => {
  const navItems = adminImageModalEl.querySelectorAll('.admin-image-modal__nav__item');
  const tabs = adminImageModalEl.querySelectorAll('.admin-image-modal__tab');

  navItems.forEach(theItem => {
    const theTab = document.getElementById(theItem.dataset.for);

    if(theTab){
      theItem.addEventListener('click', () => {
        [...tabs, ...navItems].forEach(item => {
          item.classList.remove('active');
        })

        theTab.classList.add('active');
        theItem.classList.add('active');
      })
    }
  })
}

export default tabSwitch
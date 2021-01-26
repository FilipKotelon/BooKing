const navOpen = () => {
  const sideNav = document.getElementById('side-nav');
  const sideNavToggler = document.getElementById('side-nav-toggler');

  sideNavToggler.addEventListener('click', () => {
    sideNav.classList.toggle('open');
    sideNavToggler.classList.toggle('open');
  })

  document.addEventListener('click', (e) => {
    if(
      !sideNav.contains(e.target) && sideNav !== e.target
      && !sideNavToggler.contains(e.target) && sideNavToggler !== e.target
    ){
      sideNav.classList.remove('open');
      sideNavToggler.classList.remove('open');
    }
  })
}

export default navOpen;
const navScroll = () => {
  const nav = document.getElementById('nav');
  console.log('hello');

  if(!nav) return;

  const scrollF = () => {
    if(!nav.classList.contains('fixed') && window.pageYOffset > 0){
      nav.classList.add('fixed');
    } else if(nav.classList.contains('fixed') && window.pageYOffset === 0){
      nav.classList.remove('fixed');
    }
  }

  window.onscroll = () => scrollF();
  scrollF();
}

export default navScroll;
import $ from 'jquery';
import slick from 'slick-carousel';

const apartmentCarousel = () => {
  const carousel = document.getElementById('apartments-carousel');

  if(!carousel) return;

  $(carousel).slick({
    slidesToShow: 4,
    slidesToScroll: 1,
    infinite: true,
    autoplay: true,
    responsive: [
      {
        breakpoint: 2000,
        settings: {
          slidesToShow: 3,
          slidesToScroll: 1,
        }
      },
      {
        breakpoint: 1000,
        settings: {
          slidesToShow: 2,
          slidesToScroll: 1,
        }
      },
      {
        breakpoint: 600,
        settings: {
          slidesToShow: 1,
          slidesToScroll: 1,
        }
      },
    ]
  });
}

export default apartmentCarousel
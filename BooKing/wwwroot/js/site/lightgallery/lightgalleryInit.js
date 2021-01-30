import 'lightgallery'
import 'lg-video';
import 'lg-zoom';
import 'lg-pager';
import 'lg-thumbnail';
import 'lg-share';
import 'lg-fullscreen';
import 'lg-pager';
import $ from 'jquery';

const lightgalleryInit = () => {
  $('.my-lightgallery').lightGallery({
    thumbnail: true,
    selector: '.my-lightgallery > a'
  });
}

export default lightgalleryInit;
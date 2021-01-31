import buildLibraryImg from "./buildLibraryImg";
import { adminImageModalEl, boundInput } from "./imageModal.main";

export let imagesLoaded = false;

const imageLibrary = () => {
  const libraryTab = document.getElementById('open-admin-modal-library');
  const libraryEl = document.getElementById('admin-modal-library');

  //Remove brackets of array and convert to array, if the length of the string equals 2 then the ids are just empty brackets
  let apartmentImageIds = 
    adminImageModalEl.dataset.imageIds.length > 2 ?
    adminImageModalEl.dataset.imageIds.slice(1, -1).split(',') :
    [];

  boundInput.value = `[${apartmentImageIds.join(',')}]`;

  const imgEventListener = (img, imgObj) => {
    if(img.classList.contains('checked')){
  
      apartmentImageIds.splice(apartmentImageIds.indexOf(imgObj.id.toString()), 1);
      img.classList.remove('checked');
  
    } else {
  
      apartmentImageIds.push(imgObj.id.toString());
      img.classList.add('checked');
  
    }

    adminImageModalEl.dataset.imageIds = `[${apartmentImageIds.join(',')}]`;
    boundInput.value = `[${apartmentImageIds.join(',')}]`;
  }

  const queryImages = async () => {
    if(!imagesLoaded){

      fetch('/api/images').then(r => r.json()).then(r => {
        const imagesArray = r.images;

        if(imagesArray.length){

          imagesArray.forEach(imgObj => {
            const newImg = buildLibraryImg(imgObj);

            if(apartmentImageIds.includes(imgObj.id.toString())){
              newImg.classList.add('checked');
            }

            newImg.addEventListener('click', () => imgEventListener(newImg, imgObj));

            libraryEl.appendChild(newImg);
          })

        } else {

          const libraryMessage = document.createElement('div');
          libraryMessage.classList.add('library-image-grid__msg');
          libraryMessage.innerText = r.message;

          libraryEl.appendChild(libraryMessage);

        }

        imagesLoaded = true;

      })
      .catch(e => {
        console.log(e);
        alert('An error cocured while loading images! Try again later or contact our developers!')
      })

    }
  }

  libraryTab.addEventListener('click', () => queryImages());
}

export default imageLibrary
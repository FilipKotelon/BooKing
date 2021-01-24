/**
 * 
 * @param {Object} imgObj 
 * @param {Number} imgObj.id
 * @param {string} imgObj.fileLocation
 */
const buildLibraryImg = (imgObj) => {
  const container = document.createElement('div');
  container.classList.add('library-image');
  container.dataset.id = imgObj.id;

  const img = document.createElement('img');
  img.src = '/uploads/' + imgObj.fileLocation;

  container.appendChild(img);
  return container;
}

export default buildLibraryImg
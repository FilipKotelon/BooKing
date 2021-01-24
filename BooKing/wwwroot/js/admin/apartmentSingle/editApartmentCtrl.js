import $ from 'jquery';

const editApartmentCtrl = () => {
  const form = document.getElementById('edit-apartment-form');

  if(!form){
    return;
  }

  const idInput = document.getElementById('edit-id');
  const nameInput = document.getElementById('edit-name');
  const locationInput = document.getElementById('edit-location');
  const descriptionInput = document.getElementById('edit-description');
  const sleepsInput = document.getElementById('edit-sleeps');
  const imagesInput = document.getElementById('edit-images');

  const editApartment = async () => {
    let imageIds = imagesInput.value;
    imageIds = imageIds.length > 2 ? imageIds.slice(1, -1).split(',') : [];
    imageIds = imageIds.map(imgId => parseInt(imgId));

    const payload = {
      Id: parseInt(idInput.value),
      Name: nameInput.value,
      LocationName: locationInput.value,
      Description: descriptionInput.value,
      Sleeps: parseInt(sleepsInput.value),
      ImageIds: imageIds,
    }

    $.ajax(
      {
        url: "/api/apartment/modify",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(payload),
        type: "POST",

        success: (data) => {
          if(data.redirectUrl){
            window.location.pathname = data.redirectUrl;
          } else {
            alert('An error has occured while editing the apartment!');
          }
        },
        error: (e) => {
          console.log(e);
          alert('An error has occured while editing the apartment!');
        }
      }
    );
  }

  form.addEventListener('submit', e => {
    e.preventDefault();
    editApartment();
  });
}

export default editApartmentCtrl
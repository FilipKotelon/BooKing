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
    const formData = new FormData();

    formData.append('Id', parseInt(idInput.value));
    formData.append('Name', nameInput.value);
    formData.append('Location', locationInput.value);
    formData.append('Description', descriptionInput.value);
    formData.append('Sleeps', parseInt(sleepsInput.value));

    let imageIds = imagesInput.value;
    imageIds = imageIds.length > 2 ? imageIds.slice(1, -1).split(',') : [];

    imageIds.forEach(img => {
      formData.append('Images', img);
    })

    $.ajax(
      {
        url: "/api/apartment/modify",
        data: formData,
        processData: false,
        contentType: 'application/x-www-form-urlencoded',
        type: "POST",
        success: (data) => {
          if(data.redirectUrl){
            window.location.pathname = data.redirectUrl;
          } else {
            alert('An error has occured while adding the apartment!');
          }
        },
        error: (e) => {
          console.log(e);
          alert('An error has occured while adding the apartment!');
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
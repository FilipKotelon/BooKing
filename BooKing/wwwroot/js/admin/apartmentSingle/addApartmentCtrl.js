import $ from 'jquery';

const addApartmentCtrl = () => {
  const form = document.getElementById('add-apartment-form');
  
  if(!form){
    return;
  }

  const nameInput = document.getElementById('add-name');
  const locationInput = document.getElementById('add-location');
  const descriptionInput = document.getElementById('add-description');
  const sleepsInput = document.getElementById('add-sleeps');
  const imagesInput = document.getElementById('add-images');

  const addApartment = async () => {
    // const formData = new FormData();

    // formData.append('Name', nameInput.value);
    // formData.append('Location', locationInput.value);
    // formData.append('Description', descriptionInput.value);
    // formData.append('Sleeps', parseInt(sleepsInput.value));

    let imageIds = imagesInput.value;
    imageIds = imageIds.length > 2 ? imageIds.slice(1, -1).split(',') : [];
    imageIds = imageIds.map(imgId => parseInt(imgId));

    // imageIds.forEach(img => {
    //   formData.append('ImageIds', img);
    // })

    const payload = {
      Name: nameInput.value,
      LocationName: locationInput.value,
      Description: descriptionInput.value,
      Sleeps: parseInt(sleepsInput.value),
      ImageIds: imageIds,
    }

    $.ajax(
      {
        url: "/api/apartment/create",
        //data: formData,
        //processData: false,
        //contentType: false,
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(payload),
        //processData: false,
        // headers: {
        //   'Accept': 'application/json',
        //   'Content-Type': 'application/json'
        // },
        // dataType: "json",
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
    addApartment();
  });
}

export default addApartmentCtrl
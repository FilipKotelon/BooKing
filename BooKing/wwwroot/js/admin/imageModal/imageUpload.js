import $ from 'jquery';

const imageUpload = () => {
  const form = document.getElementById('admin-modal-upload');
  const input = document.getElementById('admin-modal-upload-input');
  const overlay = document.getElementById('admin-modal-upload-overlay');
  const overlayMsg = document.getElementById('admin-modal-upload-msg');
  const overlayBtn = document.getElementById('admin-modal-upload-btn');

  const uploadImages = async () => {
    const formData = new FormData();
    const files = input.files;
    overlay.classList.add('open');

    for(let i = 0; i < files.length; i++){
      formData.append('images', files[i]);
    }

    $.ajax(
      {
        url: "/api/images",
        data: formData,
        processData: false,
        contentType: false,
        type: "POST",
        success: (data) => {
          if(data.success){
            overlay.classList.remove('failed');
            overlay.classList.add('success');
          } else {
            overlay.classList.remove('success');
            overlay.classList.add('failed');
          }
          
          overlayMsg.innerText = data.message;
        },
        error: (e) => {
          overlay.classList.remove('success');
          overlay.classList.add('failed');
          
          overlayMsg.innerText = 'An error occured! Please try again later!';
        }
      }
    );
  };

  form.addEventListener('submit', e => {
    e.preventDefault();
    uploadImages();
  });

  overlayBtn.addEventListener('click', () => {
    overlay.classList.remove('open');
  })
}

export default imageUpload;
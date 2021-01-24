import $ from 'jquery';

const imageUpload = () => {
  const form = document.getElementById('admin-modal-upload');
  const input = document.getElementById('admin-modal-upload-input');
  const overlay = document.getElementById('admin-modal-upload-overlay');
  const overlayStatus = document.getElementById('admin-modal-upload-status');
  const overlayMsg = document.getElementById('admin-modal-upload-msg');

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
          overlayStatus.classList.remove('loading');
          overlayStatus.classList.remove('failed');
          overlayStatus.classList.add('success');
          console.log(data);
          
          overlayMsg.innerText = data.message;
        },
        error: (e) => {
          overlayStatus.classList.remove('loading');
          overlayStatus.classList.remove('success');
          overlayStatus.classList.add('failed');
          console.log(e);
          
          overlayMsg.innerText = data.message;
        }
      }
    );
  };

  form.addEventListener('submit', e => {
    e.preventDefault();
    uploadImages();
  });
}

export default imageUpload;
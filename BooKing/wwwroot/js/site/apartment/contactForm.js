import $ from 'jquery';

const contactForm = () => {
  const form = document.getElementById('contact-form');

  if(!form) return;

  const nameInput = document.getElementById('contact-name');
  const emailInput = document.getElementById('contact-email');
  const msgInput = document.getElementById('contact-msg');
  const idInput = document.getElementById('contact-id');

  const loadingScreen = document.getElementById('contact-form-loading-msg');
  const msg = document.getElementById('contact-form-loading-msg');
  const status = document.getElementById('contact-form-loading-status');

  const contact = async () => {
    loadingScreen.classList.add('open')

    const payload = {
      Name: nameInput.value,
      Email: emailInput.value,
      Message: msgInput.value,
      ApartmentId: parseInt(idInput.value),
    }

    $.ajax(
      {
        url: "/api/contact",
        contentType: "application/json;charset=utf-8",
        data: JSON.stringify(payload),
        type: "POST",

        success: (data) => {
          msg.innerText = data.message;

          status.classList.remove('loading');
          status.classList.remove('failed');
          status.classList.add('success');
        },
        error: (e) => {
          console.log(e);
          msg.innerText = 'An error has occured while sending the message! Please try again later or contact us by phone.';

          status.classList.remove('loading');
          status.classList.remove('success');
          status.classList.add('failed');
        }
      }
    );
  }

  form.addEventListener('submit', e => {
    e.preventDefault();
    contact();
  });
}

export default contactForm
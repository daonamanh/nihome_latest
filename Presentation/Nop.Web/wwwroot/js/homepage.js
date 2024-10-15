
document.addEventListener('DOMContentLoaded', function () {
  const image = document.getElementById('brandImage');
  const note = document.getElementById('brandNote');

  image.addEventListener('click', function () {
    if (note.style.display === 'none' || note.style.display === '') {
      note.style.display = 'block'; // Show the text
    } else {
      note.style.display = 'none'; // Hide the text
    }
  });
});




document.addEventListener('DOMContentLoaded', function () {
  // Select all buttons
  const buttons = document.querySelectorAll('.MuiTab-root');

  buttons.forEach(button => {
    button.addEventListener('click', function () {
      // Remove the 'Mui-selected' class from all buttons
      buttons.forEach(btn => btn.classList.remove('Mui-selected'));

      // Add the 'Mui-selected' class to the clicked button
      this.classList.add('Mui-selected');
    });
  });
});

document.addEventListener('DOMContentLoaded', function () {
  const buttons = document.querySelectorAll('.MuiButtonBase-root');

  buttons.forEach(button => {
    button.addEventListener('click', function () {
      buttons.forEach(btn => btn.querySelector('.location').classList.remove('active'));
      this.querySelector('.location').classList.add('active');
    });
  });
});

document.addEventListener('DOMContentLoaded', function () {
  const toggleButton = document.getElementById('toggle-sidebar');
  const closeButton = document.getElementById('close-sidebar');
  const sidebar = document.getElementById('sidebar');

  toggleButton.addEventListener('click', function () {
    sidebar.classList.toggle('sidebar-open');
  });

  closeButton.addEventListener('click', function () {
    sidebar.classList.remove('sidebar-open');
  });
});


document.addEventListener('DOMContentLoaded', function () {
  const header = document.querySelector('.main-header-nav');
  const headers = document.querySelectorAll('.change'); // Select all elements with the class 'change'
  const logo = document.querySelector('img[alt="logo"]'); // Select the image element with the alt attribute "logo"

  window.addEventListener('scroll', function () {
    if (window.scrollY > 0) {
      header.classList.add('scrolled');
      headers.forEach(headerItem => {
        headerItem.classList.add('scrolled');
      });
      logo.src = "/Themes/DefaultClean/Content/images/logo1.png"; // Change the image source when scrolled
    } else {
      header.classList.remove('scrolled');
      headers.forEach(headerItem => {
        headerItem.classList.remove('scrolled');
      });
      logo.src = "/Themes/DefaultClean/Content/images/logo-mvillage-w.png"; // Revert to the original image source when at the top
    }
  });
});


document.addEventListener('DOMContentLoaded', function () {
  const title = document.querySelector('.filter-customer-box__title-wrapper');
  const popup = document.getElementById('popup');
  const applyButton = document.querySelector('.apply-button');

  function togglePopup() {
    if (popup.style.display === 'none' || popup.style.display === '') {
      // Get the position of the title element
      const titleRect = title.getBoundingClientRect();

      // Position the popup just below the title element
      popup.style.top = `${window.scrollY + titleRect.bottom}px`;
      popup.style.left = `${window.scrollX + titleRect.left}px`;

      // Show the popup
      popup.style.display = 'block';
    } else {
      // Hide the popup
      popup.style.display = 'none';
    }
  }

  title.addEventListener('click', togglePopup);
  applyButton.addEventListener('click', togglePopup);
});


document.getElementById("showModal").addEventListener("click", function () {
  var modal = document.getElementById("myModal");
  modal.style.display = "block";
});

// Close the modal when clicking on the close button
document.querySelector(".close").addEventListener("click", function () {
  var modal = document.getElementById("myModal");
  modal.style.display = "none";
});

// Close the modal when clicking outside of the modal content
window.onclick = function (event) {
  var modal = document.getElementById("myModal");
  if (event.target == modal) {
    modal.style.display = "none";
  }
}

document.getElementById("showModal2").addEventListener("click", function () {
  var modal = document.getElementById("signUpModal");
  var modal2 = document.getElementById("myModal");
  modal2.style.display = "none";
  modal.style.display = "block";
});

// Close the modal when clicking on the close button
document.querySelector(".close").addEventListener("click", function () {
  var modal = document.getElementById("signUpModal");
  modal.style.display = "none";
});

// Close the modal when clicking outside of the modal content
window.onclick = function (event) {
  var modal = document.getElementById("signUpModal");
  if (event.target == modal) {
    modal.style.display = "none";
  }
}

document.addEventListener('DOMContentLoaded', function () {
  const passwordInput = document.getElementById('exampleInputPassword1');
  const passwordToggle = document.getElementById('passwordToggle');
  const eyeIcon = passwordToggle.querySelector('i');

  passwordToggle.addEventListener('click', function () {
    if (passwordInput.type === 'password') {
      passwordInput.type = 'text';
      eyeIcon.classList.remove('fa-eye');
      eyeIcon.classList.add('fa-eye-slash');
    } else {
      passwordInput.type = 'password';
      eyeIcon.classList.remove('fa-eye-slash');
      eyeIcon.classList.add('fa-eye');
    }
  });
});

// Get the modals
const modal1 = document.getElementById('myModal');
const modal2 = document.getElementById('modal2');

// Get the buttons that open the modals
const openModal1 = document.getElementById('openModal1');
const openModal2 = document.getElementById('openModal2');

// Get the <span> elements that close the modals
const closeModal1 = document.getElementById('closeModal1');
const closeModal2 = document.getElementById('closeModal2');

// When the user clicks the button in the first modal, open the second modal and close the first
openModal2.onclick = function () {
  modal1.style.display = 'none';
  modal2.style.display = 'block';
}

// When the user clicks on <span> (x), close the second modal
closeModal2.onclick = function () {
  modal2.style.display = 'none';
}

// When the user clicks anywhere outside of the modal, close it
window.onclick = function (event) {
  if (event.target == modal1) {
    modal1.style.display = 'none';
  }
  if (event.target == modal2) {
    modal2.style.display = 'none';
  }
}


document.querySelector('.scroll-left').addEventListener('click', () => {
  document.querySelector('.scroll-wrapper').scrollBy({
    left: -300, // Adjust this value to scroll by more or less
    behavior: 'smooth' // Optional: smooth scrolling
  });
});

document.querySelector('.scroll-right').addEventListener('click', () => {
  document.querySelector('.scroll-wrapper').scrollBy({
    left: 300, // Adjust this value to scroll by more or less
    behavior: 'smooth' // Optional: smooth scrolling
  });
});


document.getElementById('openModal2').addEventListener('click', function () {
  // Hide the current modal
  $('#myModal').modal('hide');

  // Show the new modal
  $('#signUpModal').modal('show');
});

// Array of image sources
const images = [
  '/Themes/DefaultClean/Content/images/thonhuom-banner-1.png',
  '/Themes/DefaultClean/Content/images/hero-banner-more-vi.png',
  '/Themes/DefaultClean/Content/images/new-generation-vi-1.jpg'
];

// Index for the current image
let currentIndex = 0;

function swapImage() {
  // Get the image element and the div
  const imgElement = document.getElementById('bannerImage');
  const signatureText = document.getElementById('signatureText');

  // Update the image source
  currentIndex = (currentIndex + 1) % images.length;
  imgElement.src = images[currentIndex];

  // Show or hide the div based on the current image
  if (images[currentIndex] === '/Themes/DefaultClean/Content/images/thonhuom-banner-1.png') {
    signatureText.style.display = 'block';
  } else {
    signatureText.style.display = 'none';
  }
}

// Swap image every 3 seconds
setInterval(swapImage, 3000);

document.addEventListener("DOMContentLoaded", function () {
  var content = document.getElementById("collapseContent");
  if (window.innerWidth <= 768) {
    content.style.display = "none"; // Ensure content is hidden on load in responsive view
  }
});

function toggleCollapse() {
  var content = document.getElementById("collapseContent");
  if (window.innerWidth <= 768) {
    if (content.style.display === "none" || content.style.display === "") {
      content.style.display = "flex";
    } else {
      content.style.display = "none";
    }
  }
}
function handleImageClass() {
  const image = document.querySelector('.adjust1');

  if (window.innerWidth <= 767) { // Responsive view threshold
  } else {
    image.classList.remove('large-image');
    image.classList.add('small-image');
  }
}

// Call the function on window resize
window.addEventListener('resize', handleImageClass);

// Call the function on page load
handleImageClass();

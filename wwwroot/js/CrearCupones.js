document
  .getElementById("customSelectButton")
  .addEventListener("click", function (event) {
    var options = document.querySelector(".checklist-options");
    options.classList.toggle("open");
    event.stopPropagation(); // Evita que el evento de clic se propague al documento
    event.preventDefault(); // Evita la acción predeterminada del botón (enviar el formulario)
  });

document.addEventListener("DOMContentLoaded", (event) => {
  const checkboxes = document.querySelectorAll(".tienda-checkbox");
  const selectedTiendasElement = document.getElementById("selectedTiendas");
  const hiddenInput = document.getElementById("TiendasCupon");
  let selectedTiendas = [];
  let selectedTiendasId = [];

  checkboxes.forEach((checkbox) => {
    checkbox.addEventListener("change", (event) => {
      const checkbox = event.target;
      const tiendaNombre = checkbox.value;
      const tiendaId = checkbox.id;

      if (checkbox.checked) {
        selectedTiendas.push(tiendaNombre);
        selectedTiendasId.push(tiendaId);
      } else {
        selectedTiendas = selectedTiendas.filter(
          (nombre) => nombre !== tiendaNombre
        );
        selectedTiendasId = selectedTiendasId.filter((id) => id !== tiendaId);
      }

      selectedTiendasElement.textContent = selectedTiendas.join(", ");
      hiddenInput.value = selectedTiendasId.join(", ");
    });
  });
});

function mostrarImagen(input) {
  var reader = new FileReader();

  reader.onload = function (e) {
    var imagenMostrada = document.getElementById("imagenMostrada");
    imagenMostrada.src = e.target.result;
    imagenMostrada.style.display = "block"; // Mostrar la imagen
  };

  reader.readAsDataURL(input.files[0]); // Leer el archivo como una URL
}

// Obtener elementos del DOM
const textoSobreImagen = document.getElementById("textoSobreImagen");
const inputNombreCupon = document.getElementById("NombreCupon");
const textoSobreValor = document.getElementById("textoSobreValor");
const inputValorCupon = document.getElementById("ValorCupon");
// Funciones para arrastrar el texto sobre la imagen
textoSobreImagen.addEventListener("mousedown", iniciarArrastre);
textoSobreValor.addEventListener("mousedown", iniciarArrastre);
document.addEventListener("mouseup", finalizarArrastre);

let offsetX, offsetY;
let isDragging = false;

function iniciarArrastre(e) {
  isDragging = true;
  offsetX = e.offsetX;
  offsetY = e.offsetY;
}

function finalizarArrastre() {
  isDragging = false;
}

document.addEventListener("mousemove", (e) => {
  if (isDragging) {
    const imageContainer = document.querySelector(".image-container");
    const imageRect = imageContainer.getBoundingClientRect();
    const newX = e.clientX - imageRect.left - offsetX;
    const newY = e.clientY - imageRect.top - offsetY;
    textoSobreImagen.style.left = `${newX}px`;
    textoSobreImagen.style.top = `${newY}px`;
    
  }
});

// Escuchar cambios en el input NombreCupon y actualizar el párrafo textoSobreImagen
inputNombreCupon.addEventListener("input", () => {
  textoSobreImagen.textContent = inputNombreCupon.value;
});

inputValorCupon.addEventListener("input", () => {
  textoSobreValor.textContent = inputValorCupon.value;
});

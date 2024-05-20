document.getElementById("customSelectButton").addEventListener("click", function (event) {
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

  checkboxes.forEach((checkbox) => {
    checkbox.addEventListener("change", (event) => {
      const checkbox = event.target;
      const tiendaNombre = checkbox.value;

      if (checkbox.checked) {
        selectedTiendas.push(tiendaNombre);
      } else {
        selectedTiendas = selectedTiendas.filter((nombre) => nombre !== tiendaNombre);
      }

      selectedTiendasElement.textContent = selectedTiendas.join(", ");
      TiendasCupon.value = selectedTiendas.join(", ");
    });
  });
});

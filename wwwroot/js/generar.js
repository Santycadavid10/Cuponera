document.getElementById("customSelectButton").addEventListener("click", function(event) {
    var options = document.querySelector(".checklist-options");
    options.classList.toggle("open");
    event.stopPropagation(); // Evita que el evento de clic se propague al documento
    event.preventDefault(); // Evita la acción predeterminada del botón (enviar el formulario)
  });
  
  
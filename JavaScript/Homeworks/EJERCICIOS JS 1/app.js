let alturaPoste, largoSombra, hora;

function readNums() {
  let f = true;
  alturaPoste = parseInt(document.getElementById("n1").value);
  if (alturaPoste < 0) {
    alert("La altura debe ser positiva");
    document.getElementById("n1").value = "";
    f = false;
  }
  largoSombra = parseInt(document.getElementById("n2").value);
  if (largoSombra < 0) {
    alert("El largo de la sombra debe ser positivo");
    document.getElementById("n2").value = "";
    f = false;
  }
  hora = document.getElementById("n3").value;
  console.log(hora)
  if (!hora || hora.length !== 5 || hora[2] !== ":") {
    alert("Ingrese una hora válida en formato HH:MM");
    f = false;
  }
  return f;
}

function calcularAnguloIncidencia(alturaPoste, largoSombra, hora, minutos) {
   // Convertir la hora y los minutos a un ángulo en radianes
   let anguloHora = ((hora + minutos / 60) / 24) * Math.PI * 2 - Math.PI / 2;

   // Calcular el ángulo de incidencia del sol
   let anguloIncidencia = Math.atan(largoSombra / (alturaPoste + largoSombra * Math.tan(anguloHora)));
 
   // Convertir el ángulo de radianes a grados
   let anguloIncidenciaGrados = (anguloIncidencia * 180) / Math.PI;

  return `El ángulo de incidencia del sol es: ${anguloIncidenciaGrados} grados`;
}

function calc() {
  if (readNums()) {
    let partesHora = hora.split(":");
    let horaInt = parseInt(partesHora[0]);
    let minutos = parseInt(partesHora[1]);
    document.getElementById("ans").innerHTML = calcularAnguloIncidencia(
      alturaPoste,
      largoSombra,
      horaInt,
      minutos
    );
  }
}

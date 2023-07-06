// 1. Conocida la altura(h) de un poste y el largo de la sombra de este
//       proyectada sobre la acera(s), a una hora determinada del día, haga un
//       programa que calcule e imprima (grados, minutos y segundos), el ángulo de
//       incidencia del sol en ese momento.
let alturaPoste, largoSombra, hora;

function readNums() {
  let f = true;
  alturaPoste = parseInt(document.getElementById("n1").value);
  if (isNaN(alturaPoste)) {
    alert("Ingrese una altura");
  } else {
    if (alturaPoste < 0) {
      alert("La altura debe ser positiva");
      document.getElementById("n1").value = "";
      f = false;
    }
  }
  largoSombra = parseInt(document.getElementById("n2").value);
  if (isNaN(largoSombra)) {
    alert("Ingrese el largo de la sombra");
  } else {
    if (largoSombra < 0) {
      alert("El largo de la sombra debe ser positivo");
      document.getElementById("n2").value = "";
      f = false;
    }
  }
  hora = document.getElementById("n3").value;
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
  let anguloIncidencia = Math.atan(
    largoSombra / (alturaPoste + largoSombra * Math.tan(anguloHora))
  );

  // Convertir el ángulo de radianes a grados
  let anguloIncidenciaGrados = (anguloIncidencia * 180) / Math.PI;

  return `El ángulo de incidencia del sol es: ${anguloIncidenciaGrados} grados`;
}

function ej1() {
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


// 2.	Confeccione un programa para imprimir la parte fraccionaria de un número.
function esDecimal(numero) {
  return numero % 1 !== 0;
}

let n;
function readNums2() {
  let f = true;
  n = document.getElementById("n1").value;

  if (isNaN(n)) {
    alert("Ingrese un número");
    document.getElementById("n1").value = "";
    f = false;
  } else {
    if (!esDecimal(n)) {
      alert("Ingrese un número con parte fraccionaria");
      document.getElementById("n1").value = "";
      f = false;
    }
  }
  return f;
}

function ej2() {
  if (readNums2()) {
    let parteFraccionaria = n.split(".");
    document.getElementById(
      "ans"
    ).innerHTML = `La parte fraccionaria del número ingresado es ${parseInt(
      parteFraccionaria[1]
    )}`;
  }
}

// 3.	Desarrolle un programa para leer un valor entero  x, e  interpretado este valor como el número de segundos que dura un evento, calcule  y muestre  por pantalla, cuántos días, horas, minutos  y segundos representa x.
let x1;
function readNums3() {
  let f = true;
  x1 = document.getElementById("n1").value;
  if (isNaN(x1) || x1 == "") {
    alert("Ingrese un número");
    document.getElementById("n1").value = "";
    f = false;
  }
  return f;
}

function calcularTiempo(segundos) {
  let dias = Math.floor(segundos / 86400); // Obtener el número de días
  segundos %= 86400; // Segundos restantes después de obtener los días

  let horas = Math.floor(segundos / 3600); // Obtener el número de horas
  segundos %= 3600; // Segundos restantes después de obtener las horas

  let minutos = Math.floor(segundos / 60); // Obtener el número de minutos
  let segundosRestantes = segundos % 60; // Obtener los segundos restantes

  return `Días: ${dias}, Horas: ${horas}, Minutos: ${minutos}, Segundos: ${segundosRestantes}`;
}

function ej3() {
  if (readNums3()) {
    document.getElementById("ans").innerHTML = `${calcularTiempo(x1)}`;
  }
}

// 4.	Programa que calcula áreas de trapecios.

let o, p, q;
function readNums4() {
  let f = true;
  const o = parseInt(document.getElementById("n1").value);
  if (isNaN(o) || o < 0) {
    alert("Ingrese un valor válido y no negativo para la base superior");
    document.getElementById("n1").value = "";
    f = false;
  }
  const p = parseInt(document.getElementById("n2").value);
  if (isNaN(p) || p < 0) {
    alert("Ingrese un valor válido y no negativo para la base inferior");
    document.getElementById("n2").value = "";
    f = false;
  }
  const q = parseInt(document.getElementById("n3").value);
  if (isNaN(q) || q < 0) {
    alert("Ingrese un valor válido y no negativo para la altura");
    document.getElementById("n3").value = "";
    f = false;
  }
  return f;
}

function areaTrapecio(b1, b2, h) {
  let area = (b1 + b2) / 2;
  area *= h;
  return area;
}

function ej4() {
  if (readNums4()) {
    document.getElementById(
      "ans"
    ).innerHTML = `Área del trapecio: ${areaTrapecio(o, p, q)} m`;
  }
}

// 5.	Programa que calcula el capital final de un interés simple.

let CapitalInicial, TasaInteres, Tiempo;

function readNums5() {
  let f = true;
  CapitalInicial = document.getElementById("n1").value;
  if (isNaN(CapitalInicial)) {
    alert("Ingrese el capital inicial");
    document.getElementById("n1").value = "";
    f = false;
  } else {
    if (CapitalInicial < 0) {
      alert("El capital inicial debe ser positivo");
      document.getElementById("n1").value = "";
      f = false;
    }
  }
  TasaInteres = document.getElementById("n2").value;
  if (isNaN(TasaInteres)) {
    alert("Ingrese la tasa de interés");
    document.getElementById("n2").value = "";
    f = false;
  } else {
    if (TasaInteres < 0) {
      alert("La tasa de interés debe ser positiva");
      document.getElementById("n2").value = "";
      f = false;
    }
  }
  Tiempo = document.getElementById("n3").value;
  if (isNaN(Tiempo)) {
    alert("Ingrese el tiempo en años");
    document.getElementById("n3").value = "";
    f = false;
  } else {
    if (Tiempo < 0) {
      alert("El tiempo debe ser positivo");
      document.getElementById("n3").value = "";
      f = false;
    }
  }
  return f;
}

function interesFinal() {
  return CapitalInicial + CapitalInicial * TasaInteres * Tiempo;
}

function ej5() {
  if (readNums5()) {
    document.getElementById(
      "ans"
    ).innerHTML = `El capital final es: $${interesFinal()}`;
  }
}
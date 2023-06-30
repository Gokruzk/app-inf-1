//Evita que la página se recargue al dar clic en el botón de calcular
document.getElementById("btn").addEventListener("click", function (event) {
  event.preventDefault();
});

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

function esDecimal(numero) {
  return numero % 1 !== 0;
}

// 2.	Confeccione un programa para imprimir la parte fraccionaria de un número.
let n;
function readNums2() {
  let f = true;
  n = parseInt(document.getElementById("n1").value);

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
let m;
function readNums3() {
  let f = true;
  m = document.getElementById("n1").value;
  if (isNaN(m) || m == "") {
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
    document.getElementById("ans").innerHTML = `${calcularTiempo(m)}`;
  }
}

// 4.	Programa que calcula áreas de trapecios.

let o, p, q;
function readNums4() {
  let f = true;
  o = parseInt(document.getElementById("n1").value);
  if (isNaN(o)) {
    alert("Ingrese la base superior");
    document.getElementById("n1").value = "";
    f = false;
  }
  p = parseInt(document.getElementById("n2").value);
  if (isNaN(p)) {
    alert("Ingrese la base inferior");
    document.getElementById("n2").value = "";
    f = false;
  }
  q = parseInt(document.getElementById("n2").value);
  if (isNaN(q)) {
    alert("Ingrese la altura");
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

let CapitalFinal, CapitalInicial, TasaInteres, Tiempo;

function readNums5() {
  let f = true;
  CapitalInicial = parseInt(document.getElementById("n1").value);
  if (isNaN(CapitalInicial)) {
    alert("Ingrese el capital inicial");
    document.getElementById("n1").value = "";
    f = false;
  } else {
    if (CapitalFinal < 0) {
      alert("El capital inicial debe ser positivo");
      document.getElementById("n1").value = "";
      f = false;
    }
  }
  TasaInteres = parseInt(document.getElementById("n1").value);
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
  Tiempo = parseInt(document.getElementById("n3").value);
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
  CapitalFinal = CapitalInicial + CapitalInicial * TasaInteres * Tiempo;
  return CapitalFinal;
}

function ej5() {
  if (readNums5()) {
    document.getElementById(
      "ans"
    ).innerHTML = `El capital final es: $${interesFinal()}`;
  }
}

//Alternativos
//1.	Un avión emplea 10 minutos para despegar del aeropuerto internacional “Mariscal Sucre”, vuela de forma estable  durante n minutos y emplea 15 segundos en aterrizar. Confecciona un programa para imprimir en qué fase del vuelo se encuentra el avión a los t minutos del despegue. Imprima , además, la duración del vuelo en horas, minutos y segundos.

let TiempoVuelo, TiempoTranscurrido;

function readNums6() {
  let f = true;
  TiempoVuelo = parseInt(document.getElementById("n1").value);
  if (isNaN(TiempoVuelo)) {
    alert("Ingrese el Tiempo de Vuelo");
    document.getElementById("n1").value = "";
    f = false;
  } else {
    if (TiempoVuelo < 0) {
      alert("El Tiempo de Vuelo debe ser positivo");
      document.getElementById("n1").value = "";
      f = false;
    }
  }
  TiempoTranscurrido = parseInt(document.getElementById("n2").value);
  if (isNaN(TiempoTranscurrido)) {
    alert("Ingrese el Tiempo Transcurrido");
    document.getElementById("n2").value = "";
    f = false;
  } else {
    if (TiempoTranscurrido < 0) {
      alert("El Tiempo Transcurrido debe ser positivo");
      document.getElementById("n1").value = "";
      f = false;
    }
  }
  return f;
}

function faseVuelo(t) {
  const despegue = 10;
  if (t < despegue) {
    return "El avión está en la fase de despegue.";
  } else if (t < despegue + TiempoVuelo) {
    return "El avión está en vuelo estable.";
  } else {
    return "El avión está en la fase de aterrizaje.";
  }
}

function calcularDuracionVuelo() {
  const despegue = 10;
  const aterrizaje = 15;
  const duracionTotal = despegue + TiempoVuelo + aterrizaje;

  const horas = Math.floor(duracionTotal / 60);
  const minutos = duracionTotal % 60;
  const segundos = minutos * 60;

  return `Horas: ${horas}, Minutos: ${minutos}, Segundos: ${segundos}`;
}

function ej6() {
  if (readNums6()) {
    document.getElementById("ans").innerHTML = `${faseVuelo(
      TiempoTranscurrido
    )} \n La duración del vuelo es: ${calcularDuracionVuelo()}`;
  }
}

//2.	Crear un programa en js para un ejemplo de un  Web component.

// function readNums7() {
//   let f = true;
//   TiempoVuelo = parseInt(document.getElementById("n1").value);
//   if (isNaN(TiempoVuelo)) {
//     alert("Ingrese el Tiempo de Vuelo");
//     document.getElementById("n1").value = "";
//     f = false;
//   } else {
//     if (TiempoVuelo < 0) {
//       alert("El Tiempo de Vuelo debe ser positivo");
//       document.getElementById("n1").value = "";
//       f = false;
//     }
//   }
//   TiempoTranscurrido = parseInt(document.getElementById("n2").value);
//   if (isNaN(TiempoTranscurrido)) {
//     alert("Ingrese el Tiempo Transcurrido");
//     document.getElementById("n2").value = "";
//     f = false;
//   } else {
//     if (TiempoTranscurrido < 0) {
//       alert("El Tiempo Transcurrido debe ser positivo");
//       document.getElementById("n1").value = "";
//       f = false;
//     }
//   }
//   return f;
// }

function ej7() {}

//3.	Confeccione un programa para calcular las raíces reales de una ecuación de la forma ax2 + bx +c

let a, x, b, c;
function readNums8() {
  let f = true;
  a = parseInt(document.getElementById("a").value);
  if (isNaN(a)) {
    alert("Ingrese el valor de a");
    document.getElementById("a").value = "";
    f = false;
  }
  b = parseInt(document.getElementById("b").value);
  if (isNaN(b)) {
    alert("Ingrese el valor de b");
    document.getElementById("b").value = "";
    f = false;
  }
  c = parseInt(document.getElementById("c").value);
  if (isNaN(c)) {
    alert("Ingrese el valor de c");
    document.getElementById("c").value = "";
    f = false;
  }
  return f;
}

function calcularRaices(a, b, c) {
  const discriminante = b ** 2 - 4 * a * c;

  if (discriminante > 0) {
    const raiz1 = (-b + Math.sqrt(discriminante)) / (2 * a);
    const raiz2 = (-b - Math.sqrt(discriminante)) / (2 * a);
    return [raiz1, raiz2];
  } else if (discriminante === 0) {
    const raiz = -b / (2 * a);
    return raiz;
  } else {
    return "No existen raíces reales";
  }
}

function ej8() {
  if (readNums8()) {
    const raices = calcularRaices(a, b, c);
    if (raices.length == 2) {
      const r1 = raices[0];
      const r2 = raices[1];
      document.getElementById(
        "ans"
      ).innerHTML = `Las raíces son: ${r1} y ${r2}`;
    } else {
      document.getElementById("ans").innerHTML = `La raíz es: ${raices}`;
    }
  }
}

// 4.	Una compañía dedicada al alquiler de automóviles cobra un monto fijo de $300000 para los primeros 300 km de recorrido. Para más de 300 km y hasta 1000 km, cobra un monto adicional de $ 15.000 por cada kilómetro en exceso sobre 300. Para más de 1000 km cobra un monto adicional de $ 10.000 por cada kilómetro en exceso sobre 1000. Los precios ya incluyen el 20% del impuesto general a las ventas, IVA. Diseñe un programa que determine el monto a pagar por el alquiler de un vehículo y el monto incluido del impuesto.

// 5.	Calcule la edad de una persona conociendo su fecha de nacimiento en día, mes y año

let day, month, year;

function readNums9() {
  let f = true;
  day = parseInt(document.getElementById("day").value);
  if (isNaN(day)) {
    alert("Ingrese el día de nacimiento");
    document.getElementById("day").value = "";
    f = false;
  } else if (day < 0 || day > 30) {
    alert("Ingrese el día correctamente");
    document.getElementById("day").value = "";
  } else if (day < 0) {
    alert("Ingrese datos positivos");
    document.getElementById("day").value = "";
  }
  month = parseInt(document.getElementById("month").value);
  if (isNaN(month)) {
    alert("Ingrese el mes de nacimiento");
    document.getElementById("month").value = "";
    f = false;
  } else if (month > 12) {
    alert("Ingrese un mes válido");
    document.getElementById("month").value = "";
  } else if (month < 0) {
    alert("Ingrese datos positivos");
    document.getElementById("month").value = "";
  }
  year = parseInt(document.getElementById("year").value);
  if (isNaN(year)) {
    alert("Ingrese el año de nacimiento");
    document.getElementById("year").value = "";
    f = false;
  } else if (year < 0) {
    alert("Ingrese datos positivos");
    document.getElementById("year").value = "";
  }
  return f;
}

function calcularEdad(day, month, year) {
  const fechaNacimiento = new Date(year, month - 1, day);
  const fechaActual = new Date();

  let edadAnos = fechaActual.getFullYear() - fechaNacimiento.getFullYear();
  let edadMeses = fechaActual.getMonth() - fechaNacimiento.getMonth();
  let edadDias = fechaActual.getDate() - fechaNacimiento.getDate();

  let msj;
  fechaNacimiento.setHours(0, 0, 0, 0);
  fechaActual.setHours(0, 0, 0, 0);

  if (fechaNacimiento.getTime() == fechaActual.getTime()) {
    msj = "La fecha ingresada es la actual";
  } else {
    msj = `La edad es: ${edadAnos} años, ${edadMeses} meses y ${edadDias} días`;
    console.log(msj);
  }
  return msj;
}

function ej9() {
  if (readNums9()) {
    document.getElementById("ans").innerHTML = `${calcularEdad(
      day,
      month,
      year
    )}`;
  }
}

//Evita que la página se recargue al dar clic en el botón de calcular
document.getElementById("btn").addEventListener("click", function (event) {
  event.preventDefault();
});

function adaptarAnchoInput() {
  const myInput = document.getElementById("km");
  const input = myInput.shadowRoot.querySelector("input");
  const label = myInput.shadowRoot.querySelector("label");
  const texto = label.textContent;
  const longitudTexto = texto.length;
  const ancho = longitudTexto * 10; // Ajusta el factor de escala según tus necesidades
  input.style.width = `${ancho}px`;
}

function adaptarAnchoBtn() {
  const btn = document.querySelector("button");
  const texto = btn.textContent;
  const longitudTexto = texto.length;
  const ancho = longitudTexto * 12; // Ajusta el factor de escala según tus necesidades
  console.log(texto);
  btn.style.width = `${ancho}px`;
}

document.addEventListener("DOMContentLoaded", function () {
  adaptarAnchoInput();
  adaptarAnchoBtn();
});

//3.	Confeccione un programa para calcular las raíces reales de una ecuación de la forma ax2 + bx +c

let a, b, c;
function readNums7() {
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

function ej7() {
  if (readNums7()) {
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

let km = 0;
function readNums8() {
  let f = true;
  const myInput = document.getElementById("km");
  const input = myInput.shadowRoot.querySelector("input");
  km = input.value;

  if (isNaN(km)) {
    alert("Ingrese los kilómetros recorridos");
    input.value = "";
    f = false;
  } else if (km == 0) {
    alert("Los kilómetros deben ser mayor a 0");
    input.value = "";
    f = false;
  } else if (km < 0) {
    alert("Ingrese datos positivos");
    input.value = "";
    f = false;
  }
  return f;
}

function calcMonto(kms) {
  const TARIFA = 300000;
  const EXCESO_300 = 15000;
  const EXCESO_1000 = 10000;
  let monto = 0;
  if (kms > 300) {
    if (kms <= 1000) {
      monto = TARIFA + EXCESO_300 * (kms - 300);
    } else {
      monto = TARIFA + EXCESO_1000 * (kms - 300);
    }
  } else {
    monto = TARIFA;
  }

  return `El monto a pagar es: $${monto}`;
}

function ej8() {
  if (readNums8()) {
    document.getElementById("ans").innerHTML = calcMonto(km);
  }
}

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
    f = false;
  } else if (day < 0) {
    alert("Ingrese datos positivos");
    document.getElementById("day").value = "";
    f = false;
  }
  month = parseInt(document.getElementById("month").value);
  if (isNaN(month)) {
    alert("Ingrese el mes de nacimiento");
    document.getElementById("month").value = "";
    f = false;
  } else if (month > 12) {
    alert("Ingrese un mes válido");
    document.getElementById("month").value = "";
    f = false;
  } else if (month < 0) {
    alert("Ingrese datos positivos");
    document.getElementById("month").value = "";
    f = false;
  }
  year = parseInt(document.getElementById("year").value);
  if (isNaN(year)) {
    alert("Ingrese el año de nacimiento");
    document.getElementById("year").value = "";
    f = false;
  } else if (year < 0) {
    alert("Ingrese datos positivos");
    document.getElementById("year").value = "";
    f = false;
  }
  return f;
}

function calcularEdad(day, month, year) {
  const fechaActual = new Date();
  let input = document.getElementById("year");
  let msj = "";
  if (year > fechaActual.getFullYear()) {
    alert("Ingrese un año correcto");
    input.value = "";
  } else {
    const fechaNacimiento = new Date(year, month - 1, day);
    console.log(fechaNacimiento);
    let edadAnos = fechaActual.getFullYear() - fechaNacimiento.getFullYear();
    let edadMeses = fechaActual.getMonth() - fechaNacimiento.getMonth();
    let edadDias = fechaActual.getDate() - fechaNacimiento.getDate();

    fechaNacimiento.setHours(0, 0, 0, 0);
    fechaActual.setHours(0, 0, 0, 0);

    if (fechaNacimiento.getTime() == fechaActual.getTime()) {
      alert("La fecha ingresada es la actual");
      input = document.getElementById("year");
      input.value = "";
      input = document.getElementById("month");
      input.value = "";
      input = document.getElementById("day");
      input.value = "";
    } else {
      msj = `La edad es: ${edadAnos} años, ${edadMeses} meses y ${edadDias} días`;
    }
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

// 6.	Calificación de un examen: Escribe un programa que le pide al usuario ingresar la calificación de un examen (un número entre 0 y 100) e imprime su equivalente en letras según la siguiente escala:
// •	90-100 A
// •	80-89  B
// •	70-79 C
// •	60-69 D
// •	0-59 F

let nota = 0;

function readNums10() {
  let f = true;
  const input = document.getElementById("n1");
  nota = input.value;
  if (isNaN(nota)) {
    alert("Ingrese la calificación");
    input.value = "";
    f = false;
  } else if (nota > 100 || nota < 0) {
    alert("La calificación debe estar entre 0 y 100");
    input.value = "";
    f = false;
  }
  return f;
}

function calcEscala(calf) {
  if (calf > 59) {
    if (calf < 70) {
      return `La equivalencia es: D`;
    } else {
      if (calf < 90) {
        return `La equivalencia es: C`;
      } else {
        return `La equivalencia es: A`;
      }
    }
  } else {
    return `La equivalencia es: F`;
  }
}

function ej10() {
  if (readNums10()) {
    document.getElementById("ans").innerHTML = calcEscala(nota);
  }
}

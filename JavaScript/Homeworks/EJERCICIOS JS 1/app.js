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

class MyInput extends HTMLElement {
  constructor() {
    super();
    this.attachShadow({ mode: "open" }); // Crea un shadow DOM para encapsular el componente
    this.value = ""; // Propiedad para almacenar el valor del input
    this.textContent = this.textContent;
  }

  connectedCallback() {
    this.render(); // Renderiza el componente
    this.addEventListeners(); // Agrega los listeners de eventos

    if (this.hasAttribute("id")) {
      const input = this.shadowRoot.querySelector("input");
      const id = this.getAttribute("id");
      input.setAttribute("id", id);
    }

    if (this.hasAttribute("class-i")) {
      const input = this.shadowRoot.querySelector("input");
      const customClass = this.getAttribute("class-i");
      input.classList.add(customClass); // Utiliza classList.add() para agregar la clase
    }

    if (this.hasAttribute("class-l")) {
      const label = this.shadowRoot.querySelector("label");
      const customClass = this.getAttribute("class-l");
      label.classList.add(customClass); // Utiliza classList.add() para agregar la clase
    }

    if (this.hasAttribute("class-d")) {
      const div = this.shadowRoot.querySelector("div");
      const customClass = this.getAttribute("class-d");
      div.classList.add(customClass); // Utiliza classList.add() para agregar la clase
    }
  }

  render() {
    this.shadowRoot.innerHTML = `
    <style>
      .input-group {
        position: relative;
        margin: 0 0 20px 0;
      }

      .input {
        border: solid 1.5px #9e9e9e;
        border-radius: 1rem;
        background: none;
        padding: 1rem;
        font-size: 1rem;
        color: #f5f5f5;
        transition: border 150ms cubic-bezier(0.4,0,0.2,1);
      }

      .user-label {
        position: absolute;
        left: 15px;
        color: #e8e8e8;
        pointer-events: none;
        transform: translateY(1rem);
        transition: 150ms cubic-bezier(0.4,0,0.2,1);
      }

      .input:focus, input:valid {
        outline: none;
        border: 1.5px solid #1a73e8;
      }

      .input:focus ~ label, input:valid ~ label {
        transform: translateY(-85%) scale(0.8);
        background-color: transparent;
        padding: 0 .2em;
        color: #2196f3;
      }
    </style>
      <div>
        <input type="text" required="" value="${this.value}">
        <label>${this.textContent}</label>
      </div>
      `;
  }

  addEventListeners() {
    const input = this.shadowRoot.querySelector("input");
    input.addEventListener("input", this.handleInput.bind(this));
  }

  handleInput(event) {
    this.value = event.target.value; // Actualiza el valor del input en la propiedad del componente
  }

  static get observedAttributes() {
    return ["value"]; // Define los atributos que se observarán
  }

  attributeChangedCallback(name, oldValue, newValue) {
    if (name === "value") {
      const input = this.shadowRoot.querySelector("input");
      input.value = newValue; // Actualiza el valor del input cuando cambia el atributo
    }
  }
}

customElements.define("my-input", MyInput);

function eja() {
  const myInput = document.getElementById("n0");
  const input = myInput.shadowRoot.querySelector("input");
  const value = parseInt(input.value);

  if (isNaN(value)) {
    alert("Ingrese un número");
    input.value = ""; // Limpiar el valor del input si es NaN
  } else {
    input.value = ""; // Limpiar el valor del input
    document.getElementById(
      "ans"
    ).innerHTML = `El número ingresado es: ${value}`;
  }
}

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

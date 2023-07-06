function adaptarAnchoInput() {
  const myInput = document.getElementById("n0");
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
  btn.style.width = `${ancho}px`;
}

document.addEventListener("DOMContentLoaded", () => {
  adaptarAnchoBtn();
  adaptarAnchoInput();
});

// 14. Un laboratorio de Física de la atmósfera trabajan N investigadores.
// Cada uno de ellos realiza mediciones de temperatura los días lunes, martes, miércoles, jueves y viernes, dichos valores varían entre 0 y 10.
// Confeccione un programa para:
// Imprimir una tabla en la que aparezca, el nombre, la cantidad de mediciones y la temperatura media de cada investigador.
// Imprimir la temperatura media en el laboratorio y cuántas mediciones de las realizadas por cada investigador fueron superiores a la media.
// Mostrar un gráfico de barras que representen la temperatura media determinada por cada investigador

let investigadores = {};

//verificar patrón
function patt(text) {
  const patron = /[A-Za-z]+/;
  return patron.test(text);
}

function readNums3() {
  let f = true;
  let styleF = `transform: translateY(-85%) scale(0.8);
  background-color: transparent;
  padding: 0 0.2em;
  color: #2196f3;`;

  const myInputn = document.getElementById("name");
  const inputn = myInputn.shadowRoot.querySelector("input");
  const lbn = myInputn.shadowRoot.querySelector("label");
  let name = inputn.value;

  if (!patt(name)) {
    lbn.style = styleF;
    alert("Ingrese el nombre");
    f = false;
  } else if (name == "") {
    lbn.style = styleF;
    alert("Ingrese el nombre");
    f = false;
  }

  const myInputm = document.getElementById("monday");
  const inputm = myInputm.shadowRoot.querySelector("input");
  const lbm = myInputm.shadowRoot.querySelector("label");
  let monday = inputm.value;

  if (isNaN(monday)) {
    alert(`Ingrese la medición del lunes`);
    f = false;
  } else if (parseFloat(monday) < inputm.min || parseFloat(monday) > inputm.max || parseFloat(monday) == -0) {
    alert("1 Las mediciones deben estar entre 0 y 10");
    lbm.style = styleF;
    f = false;
  }

  const myInputt = document.getElementById("tuesday");
  const inputt = myInputt.shadowRoot.querySelector("input");
  const lbt = myInputt.shadowRoot.querySelector("label");
  let tuesday = inputt.value;

  if (isNaN(tuesday)) {
    alert(`Ingrese la medición del martes`);
    f = false;
  } else if (parseFloat(tuesday) < inputt.min || parseFloat(tuesday) > inputt.max || parseFloat(tuesday) == -0) {
    alert("2 Las mediciones deben estar entre 0 y 10");
    lbt.style = styleF;
    f = false;
  }

  const myInputw = document.getElementById("wednesday");
  const inputw = myInputw.shadowRoot.querySelector("input");
  const lbw = myInputw.shadowRoot.querySelector("label");
  let wednesday = inputw.value;

  if (isNaN(wednesday)) {
    alert(`Ingrese la medición del miércoles`);
    f = false;
  } else if (
    parseFloat(wednesday) < inputw.min ||
    parseFloat(wednesday) > inputw.max || parseFloat(wednesday) == -0
  ) {
    alert("3 Las mediciones deben estar entre 0 y 10");
    lbw.style = styleF;
    f = false;
  }

  const myInputh = document.getElementById("thursday");
  const inputh = myInputh.shadowRoot.querySelector("input");
  const lbh = myInputh.shadowRoot.querySelector("label");
  let thursday = inputh.value;

  if (isNaN(thursday)) {
    alert(`Ingrese la medición del jueves`);
    f = false;
  } else if (
    parseFloat(thursday) < inputh.min ||
    parseFloat(thursday) > inputh.max || parseFloat(thursday) == -0
  ) {
    alert("4 Las mediciones deben estar entre 0 y 10");
    lbh.style = styleF;
    f = false;
  }

  const myInputf = document.getElementById("friday");
  const inputf = myInputf.shadowRoot.querySelector("input");
  const lbf = myInputf.shadowRoot.querySelector("label");
  let friday = inputf.value;

  if (isNaN(friday)) {
    alert(`Ingrese la medición del viernes`);
    f = false;
  } else if (parseFloat(friday) < inputf.min || parseFloat(friday) > inputf.max || parseFloat(friday) == -0) {
    alert("5 Las mediciones deben estar entre 0 y 10");
    lbf.style = styleF;
    f = false;
  }

  let ms = [monday, tuesday, wednesday, thursday, friday];
  let cont = 0;
  let sum = 0;
  ms.forEach((e) => {
    if (e > 0) {
      sum += parseFloat(e);
      cont++;
    }
  });
  let m = sum / cont;
  const obj = {
    name: name,
    ms: ms,
    media: m,
    nm: cont,
  };
  return { f, obj };
}

let cont = 0;
let rss = {};

function calcObj(obj) {
  Object.entries(obj).forEach((key, value) => {
    console.log(`${key}: ${value}`);
  });
}

function exe1() {
  if (readNums3().f) {
    let rs = readNums3().obj;
    rss[`rss${cont}`] = rs;
    cont++;
    let tm = 0
    let contt = 0 
    Object.keys(rss).map((key) => {
      const value = rss[key];
      tm += tm
      console.log(`Nombre: ${value.name}\nMedia: ${value.media} \nCantidad de mediciones: ${value.nm}`);
    });
  }
}

// Llamar a la función para generar una tabla con 5 filas

const objetoPrincipal = {};

const nigell = {
  nombre: "nigell",
  apellido: "jama",
};
let msj = 1;
// Agregar el nuevo objeto al objeto principal
objetoPrincipal[`invest${msj}`] = nigell;
objetoPrincipal.invest2 = nigell;

console.log(objetoPrincipal);

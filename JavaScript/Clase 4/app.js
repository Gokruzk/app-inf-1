//encontrar el mayor de tres números leídos
//utilizar de bootstrap los forms
//programa para leer una nota entre 1 y 10 y clasificarlo en, sobresaliente, muy buena, buena, regular y suficiente

let n;

function ponderar(num) {
  if (num == 10) {
    return "sobresaliente";
  } else if (num >= 9) {
    return "muy buena";
  } else if (num >= 7) {
    return "buena";
  } else if (num >= 6) {
    return "regular";
  } else {
    return "suficiente";
  }
}

function readNums() {
  let f = true;
  n = parseInt(document.getElementById("n1").value);
  if (n < 1 || n > 10) {
    alert("El número debe estar entre 1 y 10");
    document.getElementById("n1").value = "";
    f = false;
  }
  return f;
}

function calc() {
  if (readNums()) {
    document.getElementById(
      "ans"
    ).innerHTML = `Su calificación está ponderada en <b>${ponderar(n)}</b>`;
  }
}

function obtenerValor() {
  let selector = document.getElementById("selector");
  return selector.value;
}

function changeColor() {
  let element = document.getElementById("element");
  switch (obtenerValor()) {
    case "red":
      element.className = "rojo";
      break;
    case "green":
      element.className = "verde";
      break;
    case "blue":
      element.className = "azul";
      break;
    default:
      element.className = "default";
  }
}

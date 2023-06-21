function raiz(n) {
  return Math.sqrt(n);
}

function pot(n) {
  return n * n;
}

function ex1() {
  let numero = parseInt(document.getElementById("num").value);
  document.getElementById("num2").innerHTML = numero;
  document.getElementById("answe1").innerHTML = raiz(numero);
  document.getElementById("answe2").innerHTML = pot(numero);
}

function ex2() {
  let celsius = parseInt(document.getElementById("num").value);
  let kelvin = celsius + 273.15;
  let fahrenheit = (celsius * 9) / 5 + 32;
  let rankine = ((celsius + 273.15) * 9) / 5;

  document.getElementById("num2").innerHTML = celsius;
  document.getElementById("answe1").innerHTML = kelvin;
  document.getElementById("answe2").innerHTML = fahrenheit;
  document.getElementById("answe3").innerHTML = rankine;
}

function ex3() {
  let radio = parseInt(document.getElementById("num").value);
  // Función para calcular la longitud de una circunferencia
  let l = 2 * Math.PI * radio;

  // Función para calcular el área de una circunferencia
  let a = Math.PI * Math.pow(radio, 2);

  // Función para calcular el volumen de una esfera
  let v = (4 / 3) * Math.PI * Math.pow(radio, 3);

  document.getElementById("answe1").innerHTML = l;
  document.getElementById("answe2").innerHTML = a;
  document.getElementById("answe3").innerHTML = v;
}

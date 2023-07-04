//Evita que la página se recargue al dar clic en el botón de calcular
document.getElementById("btn").addEventListener("click", function (event) {
  event.preventDefault();
});

function concatenarCadenas() {
  let c1 = prompt("Ingrese cadena 1");
  let c2 = prompt("Ingrese cadena 2");
  let c = c1 + c2;
  alert(`Cadena concatenada: ${c}`);
}

function esPalindromo() {
  let cadena = prompt("Ingrese cadena: ");
  cadena = cadena.replace(/\s/g, "").toLowerCase();

  // Comparar la cadena original con su reverso
  if (cadena === cadena.split("").reverse().join("")) {
    alert("Es palindromo");
  } else {
    alert("No es palindromo");
  }
}

function convertirCadena() {
  let c1 = prompt("Ingrese cadena: ");
  alert(c1.toUpperCase());
}

// llenar una tabla de 4 columnas por 4 filas
// suma diagonal
// suma del triangulo superior
// suma triangulo inferior
// número de primos es
// número de valores nulos
// encontrar filas que hay al menos 3 números impares

function generarNumerosAleatorios() {
  // Generar 4 números aleatorios y agregarlos al arreglo
  let numero = Math.floor(Math.random() * (971 - 100 + 1)) + 1;
  return numero;
}

function llenarTabla() {
  let tabla = document.getElementById("tabla");
  let tbody = tabla.getElementsByTagName("tbody")[0];

  // Limpiar contenido existente en el tbody
  tbody.innerHTML = "";

  // Crear las filas y celdas en la tabla
  for (let i = 0; i < 4; i++) {
    let fila = document.createElement("tr");

    for (let j = 0; j < 4; j++) {
      let celda = document.createElement("td");
      celda.textContent = generarNumerosAleatorios();
      fila.appendChild(celda);
    }

    tbody.appendChild(fila);
  }
}

function calcularSumaDiagonal() {
  let tabla = document.getElementById("tabla");
  let filas = tabla.getElementsByTagName("tr");
  let suma = 0;

  for (let i = 0; i < filas.length; i++) {
    let celdas = filas[i].getElementsByTagName("td");
    suma += parseInt(celdas[i].textContent);
  }

  alert(`Suma de la diagonal: ${suma}`);
}

function calcularSumaTrianguloSuperior() {
  let tabla = document.getElementById("tabla");
  let filas = tabla.getElementsByTagName("tr");
  let suma = 0;

  for (let i = 0; i < filas.length; i++) {
    let celdas = filas[i].getElementsByTagName("td");

    for (let j = i; j < celdas.length; j++) {
      suma += parseInt(celdas[j].textContent);
    }
  }

  alert(`Suma de la Diagonal Superior: ${suma}`);
}

function calcularSumaTrianguloInferior() {
  let tabla = document.getElementById("tabla");
  let filas = tabla.getElementsByTagName("tr");
  let suma = 0;

  for (let i = 1; i < filas.length; i++) {
    let celdas = filas[i].getElementsByTagName("td");

    for (let j = 0; j < i; j++) {
      suma += parseInt(celdas[j].textContent);
    }
  }

  alert(`Suma de la Diagonal Inferior: ${suma}`);
}

function esPrimo(numero) {
  if (numero <= 1) {
    return false;
  }

  for (let i = 2; i <= Math.sqrt(numero); i++) {
    if (numero % i === 0) {
      return false;
    }
  }

  return true;
}

function calcularNumeroPrimos() {
  let tabla = document.getElementById("tabla");
  let filas = tabla.getElementsByTagName("tr");
  let contadorPrimos = 0;

  for (let i = 0; i < filas.length; i++) {
    let celdas = filas[i].getElementsByTagName("td");

    for (let j = 0; j < celdas.length; j++) {
      let numero = parseInt(celdas[j].textContent);

      if (esPrimo(numero)) {
        contadorPrimos++;
      }
    }
  }
  alert(`Cantidad de Números Primos: ${contadorPrimos}`);
}

function calcularNumeroNulos() {
  let tabla = document.getElementById("tabla");
  let filas = tabla.getElementsByTagName("tr");
  let contadorNulos = 0;

  for (let i = 0; i < filas.length; i++) {
    let celdas = filas[i].getElementsByTagName("td");

    for (let j = 0; j < celdas.length; j++) {
      let numero = parseInt(celdas[j].textContent);

      if (numero === 0) {
        contadorNulos++;
      }
    }
  }

  alert(`Cantidad de Números Nulos: ${contadorNulos}`);
}

function encontrarFilasImpares() {
  let tabla = document.getElementById("tabla");
  let filas = tabla.getElementsByTagName("tr");
  let filasImpares = [];

  for (let i = 0; i < filas.length; i++) {
    let celdas = filas[i].getElementsByTagName("td");
    let contadorImpares = 0;

    for (let j = 0; j < celdas.length; j++) {
      let numero = parseInt(celdas[j].textContent);

      if (numero % 2 !== 0) {
        contadorImpares++;
      }
    }

    if (contadorImpares >= 3) {
      filasImpares.push(i);
    }
  }
  alert(`Las filas que tienen al menos 3 números impares: ${filasImpares}`);
}

function calcularPromedioTabla() {
  var tabla = document.getElementById("tabla");
  var filas = tabla.getElementsByTagName("tr");
  var total = 0;
  var cantidad = 0;

  for (var i = 1; i < filas.length; i++) {
    var celdas = filas[i].getElementsByTagName("td");

    for (var j = 0; j < celdas.length; j++) {
      var numero = parseInt(celdas[j].textContent);
      total += numero;
      cantidad++;
    }
  }

  var promedio = total / cantidad;
  alert(`"El promedio encontrado: ${promedio}"`);
}
function calcularPuntuacionFinal(calificaciones) {
  // Encontrar el mayor de las cinco calificaciones
  var mayor = Math.max(...calificaciones);

  // Encontrar el menor de las cinco calificaciones
  var menor = Math.min(...calificaciones);

  // Encontrar el índice de la primera ocurrencia del mayor y eliminarlo
  var indiceMayor = calificaciones.indexOf(mayor);
  if (indiceMayor > -1) {
    calificaciones.splice(indiceMayor, 1);
  }

  // Encontrar el índice de la primera ocurrencia del menor y eliminarlo
  var indiceMenor = calificaciones.indexOf(menor);
  if (indiceMenor > -1) {
    calificaciones.splice(indiceMenor, 1);
  }

  // Calcular el promedio de las tres calificaciones restantes
  var promedio =
    calificaciones.reduce(function (suma, calificacion) {
      return suma + calificacion;
    }, 0) / calificaciones.length;

  return promedio;
}

function ingresoCalf() {
  let n1 = prompt("Ingrese nota 1: ");
  let n2 = prompt("Ingrese nota 2: ");
  let n3 = prompt("Ingrese nota 3: ");
  let n4 = prompt("Ingrese nota 4: ");
  let n5 = prompt("Ingrese nota 5: ");
  let calificaciones = [n1, n2, n3, n4, n5];
  return calificaciones;
}
function ej() {
  let puntuacionFinal = calcularPuntuacionFinal(ingresoCalf());
  alert(`"La calificación final es: ${puntuacionFinal}"`);
}

// 7. Escriba un programa que despliegue todos los subconjuntos no vacíos del
//       conjunto de los números del 1 a n. Por ejemplo, si n = 3, debe obtenerse:
//       [ [1] [2] [3] [1 2] [1 3] [2 3] [1 2 3] ]

const readNums1 = () => {
  let f = true;
  const myInput = document.getElementById("n0");
  const input = myInput.shadowRoot.querySelector("input");
  let n = input.value;
  let nsplit = n.split(".");
  if (nsplit.length > 1) {
    alert("ingrese un número entero");
    input.value = "";
    f = false;
  } else {
    if (isNaN(n)) {
      alert("Ingrese un número");
      input.value = "";
      f = false;
    } else if (n <= 0) {
      alert("Ingrese datos positivos y mayor que 0");
      input.value = "";
      f = false;
    }
  }
  return { f, n };
};

const exe = () => {
  const result = document.getElementById("sets");
  if (readNums1().f) {
    showCard();
    let numbers = [];
    for (let i = 1; i <= readNums1().n; i++) {
      numbers.push(i);
    }
    subSets(numbers, [], result);
  }
};

const showCard = () => {
  const card = document.getElementById("card");
  card.style.display = "flex";
};

const hideCard = () => {
  const card = document.getElementById("card");
  card.style.display = "none";
};

const refresh = () => {
  const myInput = document.getElementById("n0");
  const input = myInput.shadowRoot.querySelector("input");
  const result = document.getElementById("sets");

  result.innerHTML = "";
  input.value = "";
  hideCard();
};

const subSets = (numbers, subset, result) => {
  if (subset.length > 0) result.innerHTML += "[" + subset.join(" ") + "] ";

  loop(0, numbers, subset, result);
};

const loop = (i, n, subset, result) => {
  if (i < n.length) {
    let newNumbers = n.slice(i + 1);
    let newSubset = subset.concat(n[i]);
    subSets(newNumbers, newSubset, result);
    loop(i + 1, n, subset, result);
  }
};

// 8. En una gasolinera se instala un detector para controlar la cantidad de litros de gasolina que va despachando el pistero. Se conoce que al comenzar el turno de trabajo en el tanque de gasolina hay N litros.
// Confeccione un programa para conocer constantemente.
//     La cantidad de vehículos atendidos.
//     La cantidad de dinero recaudado si cada litro de gasolina especial cuesta $1,25 ctvos. de dólar.
//     Cuál es la mayor cantidad de gasolina despachada a un vehículo

let counter = 0;
let intervalId;
let lit = [];
let running = false;

function readNums2() {
  let f = true;
  const myInput = document.getElementById("n0");
  const input = myInput.shadowRoot.querySelector("input");
  let gas = input.value;
  let nsplit = gas.split(".");

  if (nsplit.length > 1) {
    alert("ingrese un número entero");
    input.value = "";
    f = false;
  } else {
    if (isNaN(gas)) {
      alert("Ingrese un número");
      input.value = "";
      f = false;
    } else if (gas <= 0) {
      alert("Ingrese datos positivos y mayor que 0");
      input.value = "";
      f = false;
    }
  }
  return { f, gas };
}

function showBtn() {
  const btn = document.getElementById("calc");
  btn.style.display = "inline";
}

function hideBtn() {
  const btn = document.getElementById("calc");
  btn.style.display = "none";
}

function increment() {
  let counterElement = document.getElementById("ans");
  const input = document.getElementById("n0");
  const gas = input.shadowRoot.querySelector("input");
  if (gas.value == 0) {
    alert("se acabó la gasolina");
    stop();
  } else {
    counterElement.innerHTML = `Litros: ${counter}`;
    gas.value -= 1;
    counter++;
  }
  return counter;
}

function startCounter() {
  intervalId = setInterval(increment, 200); // Incrementa cada 200 milisegundos
}

function stopCounter() {
  clearInterval(intervalId);
}

function start() {
  if (readNums2().f) {
    console.log(readNums2().gas);
    if (running) {
      alert("Antes de empezar a llenar de nuevo, detenga el llenado");
    } else {
      counter = 0;
      running = true;
      startCounter();
      hideBtn();
    }
  }
}

function stop() {
  if (running) {
    running = false;
    stopCounter();
    lit.push(increment());
    showBtn();
  }
}

function calcGas(lit) {
  let n = 0;
  lit.forEach((element) => {
    n += element;
  });
  let recaudado = n * 1.25;
  let l = lit.length;
  return { recaudado, l };
}

function exe1() {
  let recaudado = calcGas(lit).recaudado;
  let cars = calcGas(lit).l;
  let counterElement = document.getElementById("ans2");
  counterElement.innerHTML = `Cantidad de vehículos atendidos: ${cars} <br> Cantidad de dinero recaudado: $${recaudado}`;
}

// 10. Confeccione un programa para hallar e imprimir los números naturales que cumplan simultáneamente las condiciones siguientes:
// Se encuentren entre 1200 y 2000.
// Tengan exactamente 4 divisores enteros positivos que son 1,5, otro número primo y el propio número.

function calcular_naturales() {
  let nums = [];

  for (let num = 1200; num <= 2000; num++) {
    let divisores = getDiv(num);

    if (
      divisores.length === 4 &&
      divisores.includes(1) &&
      divisores.includes(5) &&
      esPrimo(divisores[2])
    ) {
      nums.push(num);
    }
  }
  showResult(nums);
}

function getDiv(numero) {
  let div = [];

  for (let i = 1; i <= Math.sqrt(numero); i++) {
    if (numero % i === 0) {
      div.push(i);

      if (numero / i !== i) {
        div.push(numero / i);
      }
    }
  }
  return div;
}

function esPrimo(numero) {
  if (numero < 2) {
    return false;
  }

  for (let i = 2; i <= Math.sqrt(numero); i++) {
    if (numero % i === 0) {
      return false;
    }
  }

  return true;
}

function showResult(numeros) {
  const result = document.getElementById("sets");
  showCard();
  let msj;
  if (numeros.length > 0) {
    let numerosHTML = "";
    numeros.forEach((numero) => {
      numerosHTML += numero + ", ";
      let divisores = getDiv(numero);
      msj += "" + numero + ": {" + divisores.join(", ") + "}";
    });
    result.innerHTML = msj;
    // result.innerHTML = numerosHTML.slice(0, -2); // Eliminar la última coma y espacio
  } else {
    result.innerHTML = "No se encontraron números que cumplan las condiciones";
  }
}

// 11. Confeccione un programa que imprima las k filas del triángulo de Pascal

function readNums3() {
  let f = true;
  const myInput = document.getElementById("n0");
  const input = myInput.shadowRoot.querySelector("input");
  let rows = input.value;
  let rsplit = rows.split(".");

  if (rsplit.length > 1) {
    alert("ingrese un número entero");
    input.value = "";
    f = false;
  } else {
    if (isNaN(rows)) {
      alert("Ingrese las filas");
      input.value = "";
      f = false;
    } else if (rows <= 0) {
      alert("Ingrese datos positivos y mayor que 0");
      input.value = "";
      f = false;
    }
  }
  return { f, rows };
}

function setHeightCard(rows) {
  const card = document.getElementById("card");
  const height = rows * 40; // Ajusta el factor de escala según tus necesidades
  card.style.height = `${height}px`;
}

function pascalTriangle() {
  if (readNums3().f) {
    showCard();
    const result = document.getElementById("sets");
    let rows = readNums3().rows;
    let triangle = [];

    for (let i = 0; i < rows; i++) {
      triangle[i] = [];
      triangle[i][0] = 1;

      for (let j = 1; j < i; j++) {
        triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
      }
      if (i > 0) {
        triangle[i][i] = 1;
      }
    }
    result.innerHTML = "";
    for (let i = 0; i < rows; i++) {
      let fila = triangle[i].join(" ");
      result.innerHTML += `${fila} <br>`;
    }
    setHeightCard(rows)
  }
}

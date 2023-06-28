// calcular si es primo, perfecto, capícua de un número
// imprimir sus divisores

let n;

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

function esPerfecto(numero) {
  let sumaDivisores = 0;

  for (let i = 1; i < numero; i++) {
    if (numero % i == 0) {
      sumaDivisores += i;
    }
  }
  return sumaDivisores == numero;
}

function esCapicua(numero) {
  const numeroInvertido = parseInt(
    numero.toString().split("").reverse().join(""),
    10
  );
  return numero == numeroInvertido;
}

function obtenerDivisores(numero) {
  let divisores = [];

  for (var i = 1; i <= numero; i++) {
    if (numero % i === 0) {
      divisores.push(i);
    }
  }
  return divisores;
}

function obtenerValor() {
  let selector = document.getElementById("selector");
  return selector.value;
}

function calc() {
  let n = document.getElementById("n1").value;
  let selector = document.getElementsByClassName("selector");
  if (n == "") {
    alert("Ingrese un número");
  } else {
    switch (obtenerValor()) {
      case "pri":
        document.body.style.cursor = "progress";
        if (esPrimo(n))
          document.getElementById("res").innerHTML = `El número ${n} es primo`;
        else
          document.getElementById(
            "res"
          ).innerHTML = `El número ${n} no es primo`;
        break;
      case "perf":
        document.body.style.cursor = "help";
        if (esPerfecto(n))
          document.getElementById(
            "res"
          ).innerHTML = `El número ${n} es perfecto`;
        else
          document.getElementById(
            "res"
          ).innerHTML = `El número ${n} no es perfecto`;
        break;
      case "capi":
        document.body.style.cursor = "move";
        if (esCapicua(n))
          document.getElementById(
            "res"
          ).innerHTML = `El número ${n} es capicua`;
        else
          document.getElementById(
            "res"
          ).innerHTML = `El número ${n} no es capicua`;
        break;
      case "divi":
        document.body.style.cursor = "not-allowed";
        document.getElementById(
          "res"
        ).innerHTML = `Los números divisores de ${n} son: ${obtenerDivisores(n)}`;
        break;
      default:
        console.log("Seleccione una opción");
    }
  }
}

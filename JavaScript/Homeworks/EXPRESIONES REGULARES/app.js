const buttons = document.querySelectorAll("button");
buttons.forEach((x) => {
  x.addEventListener("click", function (event) {
    event.preventDefault();
  });
});

function nums(x) {
  if (x >= 0 || x <= 0) {
    return true;
  }
  return false;
}

function emptyInput(id = "n1") {
  const input = document.getElementById(id);
  let f = input.value.trim() == "";
  if (f) {
    alert("Ingrese un valor");
  }
  return f;
}

function notFloats() {
  const input = document.getElementById("n2");
  let a = input.value;
  if (!emptyInput("n2")) {
    if (a.split(".").length > 1 || a.split(",").length > 1) {
      alert("No ingrese decimales");
    } else {
      alert("Enviado");
    }
  }
}

function onlyUppercase() {
  const input = document.getElementById("n3");
  let a = input.value;
  if (!emptyInput("n3")) {
    if (nums(a)) {
      alert("No ingrese números");
    } else {
      let b = a.toUpperCase();
      a === b ? alert("Enviado") : alert("Ingrese solo mayúsculas");
    }
  }
}

function rangeNums() {
  const input = document.getElementById("n4");
  let a = input.value;
  if (!emptyInput("n4")) {
    if (nums(a)) {
      a < 0 || a > 10
        ? alert("El número ingresado debe estar entre 0 y 10")
        : alert("Enviado");
    } else {
      alert("No ingrese palabras o letras");
    }
  }
}

function validarCed() {
  const cedula = document.getElementById("n5").value;
  // Verificar que la cédula tenga 10 dígitos
  if (emptyInput("n5")) {
  } else {
    if (cedula.length != 10) {
      alert("La cédula debe tener 10 dígitos");
    } else {
      // Convertir la cédula en un array de dígitos
      const digitos = cedula.split("").map(Number);

      // Paso 2: Multiplicar por 2 los dígitos en posiciones pares
      for (let i = 0; i < digitos.length; i++) {
        if (i % 2 === 0) {
          digitos[i] *= 2;
          if (digitos[i] >= 10) {
            digitos[i] -= 9;
          }
        }
      }

      // Paso 4: Sumar todos los dígitos
      let sum = 0;
      digitos.forEach((x) => {
        sum += x;
      });

      // Paso 5: Verificar si la suma total termina en cero
      sum % 10 === 0
        ? alert("La cédula es válida")
        : alert("La cédula no es válida");
    }
  }
}

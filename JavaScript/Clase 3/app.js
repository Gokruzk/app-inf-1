//encontrar el mayor de tres números leídos
//utilizar de bootstrap los forms
//una funcion para leer datos y otra para encontrar el mayor
//los datos ingresados solo deben ser de tres cifras

let n1, n2, n3;

function encontrarMayor(num1, num2, num3) {
  if (num1 >= num2 && num1 >= num3) {
    return num1;
  } else if (num2 >= num1 && num2 >= num3) {
    return num2;
  } else {
    return num3;
  }
}

function readNums() {
  let f = true;
  n1 = parseInt(document.getElementById("n1").value);
  if (n1 > 999) {
    alert("El número 1 debe ser de 3 cifras");
    document.getElementById("n1").value = "";
    f = false;
  }
  n2 = parseInt(document.getElementById("n2").value);
  if (n2 > 999) {
    alert("El número 2 debe ser de 3 cifras");
    document.getElementById("n2").value = "";
    f = false;
  }
  n3 = parseInt(document.getElementById("n3").value);
  if (n3 > 999) {
    alert("El número 3 debe ser de 3 cifras");
    document.getElementById("n3").value = "";
    f = false;
  }
  return f;
}

function calc() {
  if (readNums()) {
    let may = encontrarMayor(n1, n2, n3);
    document.getElementById("ans").innerHTML = `El número mayor es ${may}`;
  }
}

$('.navbar-collapse').on('click', function () {
  $(this).toggleClass('show');
});


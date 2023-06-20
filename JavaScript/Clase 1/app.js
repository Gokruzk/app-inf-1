// let name = prompt("Ingresa tu nombre");
// let apellido = prompt("Ingresa tu apellido");
// let adress = prompt("Ingresa tu dirección");

// document.write(`Su nombre es: ${name} <br/>
// Su apellido: ${apellido} <br/>
//   Su dirección es: ${adress}`);

// let names = ["fernando", "nigell", "la chimbo", "vanesa"];

// let array = names.map((name) => {
//   return `Estudiante ${name}`;
// });

// array.forEach(e =>{
//   document.write(`${e} <br/>`)
// })

function data() {
  let num = parseInt(document.getElementById("num").value);
  document.getElementById("answer").innerHTML = num;
}

function areaCir() {
  let num = parseInt(document.getElementById("num2").value);
  let ans = num * num * Math.PI;
  document.getElementById("answe2").innerHTML = ans;
}

function otra() {
  let numero = parseInt(document.getElementById("num3").value);
  if (numero >= 1000) {
    alert("el número es mayor a tres cifras");
  } else {
    let newNum = 0;
    while (numero > 0) {
      let digito = numero % 10;
      newNum = newNum * 10 + digito;
      numero = Math.floor(numero / 10);
    }
    document.getElementById("ans3").innerHTML = newNum;
  }
}

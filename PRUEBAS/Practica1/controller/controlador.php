<?php
$valor = $_GET['valor'];

if($valor == 1)
    include("../view/ingresar.html");
else
if($valor == 2)
    include("../view/mostrar.php");
else
if($valor == 3)
    include("../view/lit3.php");
else
if($valor == 4)
    include("../view/lit4.php");
else
    echo "Ninguna";
?>
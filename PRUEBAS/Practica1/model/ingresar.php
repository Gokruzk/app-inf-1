<?php
    include("../config/conexion.php");

    $nombre = $_POST['nombre'];
    $alineacion = $_POST['alineacion'];

    $sql = "INSERT INTO paises(nombre, alineacion) VALUES ('$nombre', '$alineacion')";
    
    mysqli_query($conexion, $sql);
    include("../ingresar.html");
?>
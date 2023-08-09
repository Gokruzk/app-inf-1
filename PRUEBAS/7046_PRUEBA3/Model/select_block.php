<?php
include('../Config/connection.php');
$sql1 = "SELECT * FROM pais";
$res1 = mysqli_query($conexion, $sql1);
//número total de países
$total = mysqli_num_rows($res1);
$sql = "SELECT * FROM pais WHERE Indicación != 'NO ALINEADO'";
$res = mysqli_query($conexion, $sql);
//número de países que cumplen con el bloque militar
$num = mysqli_num_rows($res);
?>
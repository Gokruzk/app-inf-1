<?php
include('../Config/connection.php');
$sql = 'SELECT * FROM pais';
$res = mysqli_query($conexion, $sql);
?>
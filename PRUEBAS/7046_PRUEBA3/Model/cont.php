<?php
include('../Config/connection.php');
$sql = "SELECT * FROM pais";
$res = mysqli_query($conexion, $sql);
$cont = 0;
while ($country = $res->fetch_assoc()) {
    $nombre = $country['Nombre_Pais'];
    if (str_word_count($nombre, 0) > 1)
        $cont++;
}
?>
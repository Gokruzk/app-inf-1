<?php
include('../Config/connection.php');
$nombre = $_POST['nombre'];
$indicac = $_POST['indicacion'];
$idiom = $_POST['idioma'];
$sql = "INSERT INTO pais(nombre_pais, indicación, idioma_oficial) VALUES('$nombre','$indicac','$idiom')";
$res = mysqli_query($conexion, $sql);
if ($res) {
    ?>
    <script>alert('PAÍS AGREGADO CORRECTAMENTE');</script>
    <?php
    include('../View/AddCountry.html');
}
?>
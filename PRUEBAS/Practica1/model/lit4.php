<?php
include("../Config/conexion.php");

$sql = "SELECT * FROM paises";

$resultado = mysqli_query($conexion, $sql);

$paisesconmasdeunapalabra =0;
while($mostrar = mysqli_fetch_array($resultado)){
    $name = explode(" ", $mostrar['nombre']);
    $masdeunapalabra = count($name);
    if($masdeunapalabra>1){
        $paisesconmasdeunapalabra++;
    }
}

?>
    <h2><?php echo $paisesconmasdeunapalabra?></td></h2>
<?php
?>
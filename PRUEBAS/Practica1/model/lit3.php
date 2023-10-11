<?php
include("../Config/conexion.php");
$sql1 = "SELECT COUNT(*) AS total FROM paises";
$sql2 = "SELECT * FROM paises";

$resultado1 = mysqli_query($conexion, $sql1);
$resultado2 = mysqli_query($conexion, $sql2);

$alineados =0;
while($mostrar = mysqli_fetch_array($resultado2)){
    $ali=($mostrar['alineacion']);
    if($ali=="OTAN"||$ali=="UE"||$ali=="ASEAN"||$ali=="OEA"||$ali=="UNASUR"||$ali=="APEC"){
        $alineados++;
    }
}
$total = mysqli_fetch_array($resultado1);

$porcentaje = $alineados/intval($total['total']); 

?>
    <h2><?php echo $porcentaje*100 . "%"?></td></h2>
<?php
?>
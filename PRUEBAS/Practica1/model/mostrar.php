<?php
include("../Config/conexion.php");

$sql = "SELECT * FROM paises";

$resultado = mysqli_query($conexion, $sql);

while($mostrar = mysqli_fetch_array($resultado)){
    ?>
                <center>
                    <tr class="border border-success">
                        <td class="border border-success"><?php echo $mostrar['idpaises']?></td>
                        <td class="border border-success"><?php echo $mostrar['nombre']?></td>
                        <td class="border border-success"><?php echo $mostrar['alineacion']?></td>
                        <td class="border border-success"><label for="" id="asciiTabla">
                            <?php 
                            $ali=($mostrar['alineacion']);
                            if($ali=="OTAN"||$ali=="UE"||$ali=="ASEAN"||$ali=="OEA"||$ali=="UNASUR"||$ali=="APEC"){
                                echo "ALINEADO";
                            }else{
                                echo "NO ALINEADO";
                            }?>
                        </td>
                    </tr>
                </center>
    
    
<?php
}
?>
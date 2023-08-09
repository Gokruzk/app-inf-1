<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Países de Bloque Militar</title>
    <link rel="stylesheet" href="../css/style.css">
</head>

<body>
    <div class="links">
        <a href="../View/Menu.html">REGRESAR</a>
    </div>
    <?php
    include('../Model/select_block.php');
    ?>
    <div class="content">
        <div class="title">
            <h1>PORCENTAJE DE PAÍSES QUE CUMPLE CON LA INDICACIÓN DE BLOQUE MILITAR</h1>
        </div>
        <p>
            <?php
            //porcentaje de países que cumple con el bloque militar
            if ($total == 0) {
                echo "No hay países ingresados";
            } else {
                $porcentaje = ($num * 100) / $total;
                echo "Porcentaje de países que cumple con el bloque militar: ";
                echo $porcentaje;
                echo "%";
            } ?>
        </p>
    </div>
</body>

</html>
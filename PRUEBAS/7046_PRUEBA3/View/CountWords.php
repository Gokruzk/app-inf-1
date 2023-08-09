<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="../css/style.css">
</head>

<body>
    <div class="links">
        <a href="../View/Menu.html">REGRESAR</a>
    </div>
    <div class="contet">
        <div class="title">
            <h1>
                PAÍSES CON MÁS DE 1 PALABRA EN EL NOMBRE
            </h1>
            <p>
                Países con más de 1 palabra en el nombre:
                <?php
                include('../Model/cont.php');
                echo $cont;
                ?>
            </p>
        </div>
    </div>
</body>

</html>
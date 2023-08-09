<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Lista de Países</title>
    <link rel="stylesheet" href="../css/style.css">
</head>

<body>
    <div class="links">
        <a href="../View/Menu.html">REGRESAR</a>
    </div>
    <div class="content">
        <div class="title">
            <h1>LISTA DE PAÍSES</h1>
        </div>
        <table border="1">
            <tr>
                <th>Cod_Pais</th>
                <th>Nombre_Pais</th>
                <th>Indicación</th>
            </tr>

            <?php
            include('../Model/select.php');
            while ($pais = $res->fetch_assoc()) {
                ?>
                <tr>
                    <td>
                        <?php echo $pais["Cod_Pais"]; ?>
                    </td>
                    <td>
                        <?php echo $pais["Nombre_Pais"]; ?>
                    </td>
                    <td>
                        <?php echo $pais["Indicación"]; ?>
                    </td>
                </tr>
                <?php
            }

            // Cerrar la conexión
            $res->close();
            ?>
        </table>
    </div>
</body>

</html>
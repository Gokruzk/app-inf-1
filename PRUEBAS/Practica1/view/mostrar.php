<!DOCTYPE html>
  <html lang="en">
  <head>
      <meta charset="UTF-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
      <meta name="viewport" content="width=device-width, initial-scale=1.0">
      <title>Pagina web</title>
     
      <link rel="stylesheet" href="../bootstrap/css/bootstrap.min.css">
      <link rel="stylesheet" href="../css/keyframes.css">
      <link rel="stylesheet" href="../css/banner.css">
      <link rel="stylesheet" href="../css/style.css">
  </head>
  <body>
      <header>
          
      </header>
  <!-- seccion central -->
      <section>
          <div class="ewk_cont_banner">
              <!-- lo anterior coloca un fondo arq1 -->
              <div class="ewk_sobra">
                  <h1>Examen de Tercer Parcial</h1>
                   <p>Mostrando los datos</p>
                  <br>
                  <hr/>
                    <div class="ewk_cont_banner_link">
                        <table border="1px">
                            <tr>
                                <th class="border border-success">ID País</th>
                                <th class="border border-success">Nombre País</th>
                                <th class="border border-success">Organización</th>
                                <th class="border border-success">Alineación</th>
                            </tr>
                            <tbody>
                                <?php include("../model/mostrar.php"); ?>
                            </tbody>
                        </table>
                    </div>
                    <a href="../index.html" class="btn btn-success">Regresar</a>
              </div>
              
      </section>
      <script src="../bootstrap/js/jquery-3.2.1.min.js"></script>
      <script src="../bootstrap/js/bootstrap.min.js"></script>
      
  <footer>
      
  </footer>
  </body>
</html>


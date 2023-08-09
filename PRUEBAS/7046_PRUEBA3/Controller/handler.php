<?php

$value = $_GET['value'];

if ($value == 1) {
    include('../View/Menu.html');
} else if ($value == 2) {
    include('../View/AddCountry.html');
} else if ($value == 3) {
    include('../View/CountryList.php');
}else if ($value == 4) {
    include('../View/CountryBlockPercent.php');
}else if ($value == 5) {
    include('../View/CountWords.php');
}
?>
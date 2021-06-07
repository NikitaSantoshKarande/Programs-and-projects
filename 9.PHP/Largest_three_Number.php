<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Largest Number</title>
</head>
<body>
    
<?php

$No1=6;
$No2=7;
$No3=9;

if($No1>$No2 && $No1>$No3)
{
    echo "Largest number is:".$No1;
}
else if($No2>$No1 && $No2>$No3)
{
    echo "Largest number is:".$No2;
}
else
{
    echo "Largest number is:".$No3;
}

?>
</body>
</html>
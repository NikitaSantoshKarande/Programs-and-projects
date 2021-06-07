<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>PHP</title>
</head>
<body>


<?php
$No1=407;
$iCopy=0;
$iCount=0;
$iRem=0;
$iSum=0;

$iCopy=$No1;

while($iCopy!=0)
{
    $iCount++;
    $iCopy=floor($iCopy/10);
}

$iCopy=$No1;

while($iCopy!=0)
{
    $iRem=$iCopy%10;
    $iSum += pow($iRem , $iCount);
    $iCopy=floor($iCopy/10);
}
echo "iSum= ".$iSum;
if($iSum == $No1)
    echo "=Armstrong";
else
    echo "=Not Armstrong";

?>



</body>
</html>
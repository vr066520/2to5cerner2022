<?php
// cerner_2^5_2022
function findTriplets($arr, $n, $sum)
{
    for ($i = 0; $i < $n - 2; $i++)
    {
        for ($j = $i + 1; $j < $n - 1; $j++)
        {
            for ($k = $j + 1; $k < $n; $k++)
            {
                if ($arr[$i] + $arr[$j] +
                    $arr[$k] == $sum)
                {
                    echo $arr[$i], " ",
                         $arr[$j], " ",
                         $arr[$k], "\n";
                }
            }
        }
    }
}
$arr = array (0, -1, 2, -3, 1);
$n = sizeof($arr);
findTriplets($arr, $n, -2);

?>
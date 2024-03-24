<?php
// Hàm kiểm tra số nguyên tố
function isPrime($n) {
    if ($n <= 1) {
        return false;
    }
    for ($i = 2; $i * $i <= $n; $i++) {
        if ($n % $i === 0) {
            return false;
        }
    }
    return true;
}

$start = microtime(true);

$count = 0;
// Tính số lượng số nguyên tố nhỏ hơn 1000000
for ($i = 2; $i < 20000000; $i++) {
    if (isPrime($i)) {
        $count++;
    }
}

$end = microtime(true);
$elapsed = $end - $start;
echo "Found $count prime numbers in $elapsed seconds\n";
?>

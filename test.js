function isPrime(n) {
    if (n <= 1) return false;
    for (let i = 2; i * i <= n; i++) {
        if (n % i === 0) return false;
    }
    return true;
}

function countPrimes() {
    const start = new Date();

    let count = 0;
    // Tính số lượng số nguyên tố nhỏ hơn 1000000
    for (let i = 2; i < 20000000; i++) {
        if (isPrime(i)) {
            count++;
        }
    }

    const end = new Date();
    console.log(`Found ${count} prime numbers in ${end - start} milliseconds`);
}

countPrimes();

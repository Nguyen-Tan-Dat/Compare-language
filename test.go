package main

import (
	"fmt"
	"time"
)

// Hàm kiểm tra số nguyên tố
func isPrime(n int) bool {
	if n <= 1 {
		return false
	}
	for i := 2; i*i <= n; i++ {
		if n%i == 0 {
			return false
		}
	}
	return true
}

func main() {
	start := time.Now()

	count := 0
	// Tính số lượng số nguyên tố nhỏ hơn 1000000
	for i := 2; i < 20000000; i++ {
		if isPrime(i) {
			count++
		}
	}

	elapsed := time.Since(start)
	fmt.Printf("Found %d prime numbers in %s\n", count, elapsed)
}

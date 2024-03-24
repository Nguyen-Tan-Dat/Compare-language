#include <iostream>
#include <chrono>

// Hàm kiểm tra số nguyên tố
bool isPrime(int n) {
    if (n <= 1)
        return false;
    for (int i = 2; i * i <= n; i++) {
        if (n % i == 0)
            return false;
    }
    return true;
}

int main() {
    auto start = std::chrono::high_resolution_clock::now();

    int count = 0;
    // Tính số lượng số nguyên tố nhỏ hơn 1000000
    for (int i = 2; i < 20000000; i++) {
        if (isPrime(i))
            count++;
    }

    auto end = std::chrono::high_resolution_clock::now();
    std::chrono::duration<double> elapsed = end - start;

    std::cout << "Found " << count << " prime numbers in " << elapsed.count() << " seconds" << std::endl;

    return 0;
}

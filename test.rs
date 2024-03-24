use std::time::Instant;

// Hàm kiểm tra số nguyên tố
fn is_prime(n: u64) -> bool {
    if n <= 1 {
        return false;
    }
    for i in 2..=(n as f64).sqrt() as u64 {
        if n % i == 0 {
            return false;
        }
    }
    true
}

fn main() {
    let start = Instant::now();

    let mut count = 0;
    // Tính số lượng số nguyên tố nhỏ hơn 1000000
    for i in 2..20000000 {
        if is_prime(i) {
            count += 1;
        }
    }

    let elapsed = start.elapsed();
    println!("Found {} prime numbers in {:?}", count, elapsed);
}

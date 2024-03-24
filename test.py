import time

# Hàm kiểm tra số nguyên tố
def is_prime(n):
    if n <= 1:
        return False
    for i in range(2, int(n**0.5) + 1):
        if n % i == 0:
            return False
    return True

start = time.time()

count = 0
# Tính số lượng số nguyên tố nhỏ hơn 1000000
for i in range(2, 20000000):
    if is_prime(i):
        count += 1

end = time.time()
elapsed = end - start
print("Found {} prime numbers in {:.5f} seconds".format(count, elapsed))

# Hàm kiểm tra số nguyên tố
def is_prime(n)
  return false if n <= 1

  (2..Math.sqrt(n)).none? { |i| n % i == 0 }
end

start_time = Time.now

count = 0
# Tính số lượng số nguyên tố nhỏ hơn 1000000
(2..20000000).each do |i|
  count += 1 if is_prime(i)
end

end_time = Time.now
elapsed_time = end_time - start_time
puts "Found #{count} prime numbers in #{elapsed_time} seconds"

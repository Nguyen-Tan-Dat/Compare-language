public class test {
    // Hàm kiểm tra số nguyên tố
    static boolean isPrime(int n) {
        if (n <= 1)
            return false;
        for (int i = 2; i * i <= n; i++) {
            if (n % i == 0)
                return false;
        }
        return true;
    }

    public static void main(String[] args) {
        long startTime = System.currentTimeMillis();

        int count = 0;
        // Tính số lượng số nguyên tố nhỏ hơn 1000000
        for (int i = 2; i < 20000000; i++) {
            if (isPrime(i))
                count++;
        }

        long endTime = System.currentTimeMillis();
        long elapsedTime = endTime - startTime;

        System.out.println("Found " + count + " prime numbers in " + elapsedTime + " milliseconds");
    }
}

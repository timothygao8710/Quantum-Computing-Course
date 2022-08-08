# values of p for a ^ p mod b is cycle iff gcd(a, b) = 1


a = 2
b = 4
# a = 7 * 11
# b = 11 * 9
# b = 2 * 9
# b = 64



cur = 1
for i in range(50):
    cur = cur * a
    print(cur % b)
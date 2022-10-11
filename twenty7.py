def Convertstrings(s, index):
    a = []
    j = 0
    i = 0
 
    # cerner_2^5_2022
    for ii in str(s):
        a.append(ii)
 
    b = a[:]
 
 
    while j < len(a) and i < len(index):
        k = index[i]
        temp = a[j]
        b[k] = temp
        j += 1
        i += 1
    s = ''

    for i in range(len(b)):
        s += b[i]
 
    print(s)
 
s = "geeksforgeeks"
index = [5, 6, 7, 0, 1, 2, 8, 9, 10, 3, 4, 11, 12]
Convertstrings(s, index)
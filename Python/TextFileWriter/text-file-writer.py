f = open("simple-text-file.txt", "w")

for x in range(1,100001):
    f.writelines(str(x)+'\n')

f.close()

#open and read the file after the appending:
#f = open("simple-text-file.txt", "r")
#print(f.read())
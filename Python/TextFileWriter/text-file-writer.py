import time

# get the start time
st = time.time()

f = open("simple-text-file.txt", "w")

for x in range(1,100001):
    f.writelines(str(x)+'\n')

f.close()

#open and read the file after the appending:
#f = open("simple-text-file.txt", "r")
#print(f.read())

# get the end time
et = time.time()

# get the execution time
print('Script executed in:', et - st, 'seconds')
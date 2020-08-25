import sys

if len(sys.argv) == 3:
	a = int(sys.argv[1])
	b = int(sys.argv[2])
	print(a + b)
else:
	print('2個の引数が必要です')

import sys

def getComplementOfByte(byteValue):
    return 0xFF^byteValue
def add1(val):
    return val+1    

def getComplementedArray(inputArray):
	outputArray=b=bytearray.fromhex(inputArray)
	for i,single_byte in enumerate(b):
		outputArray[i] = 0xFF^single_byte
	s=''
	for x in b:
		s+='{:02X}'.format(x)+' '
	return s	
	
def test():
	s = getComplementedArray('0B 0C 0D')
	print (s)	

	

if(len(sys.argv)>1):
	print(getComplementedArray(sys.argv[1]))

#test()
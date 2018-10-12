import sys

def getCheckSum(packet):	
	byteArray = bytearray.fromhex(packet)
	checksum = 0
	for single_byte in byteArray:
		#print(single_byte)
		checksum ^= single_byte
	return '{:02X}'.format(checksum)
	
def hello(a):
	print(getCheckSum(packet))

if __name__ == "__main__":
    a = sys.argv[1]
    hello(a)
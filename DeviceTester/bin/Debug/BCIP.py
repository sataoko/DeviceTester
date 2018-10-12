import sys

def generatePacket(array):
    return '02 '+array+' 03'
    	a

def getCheckSum(packet):	
	byteArray = bytearray.fromhex(packet)
	checksum = 0
	for single_byte in byteArray:
		#print(single_byte)
		checksum ^= single_byte
	return checksum

def test():
	packet = generatePacket('0A 0B 0C')
	print (packet+ hex(getCheckSum(packet)).replace('0x',' '))

if __name__ == "__main__":
	packet = generatePacket(sys.argv[1])
	print (packet+ hex(getCheckSum(packet)).replace('0x',' '))

test()
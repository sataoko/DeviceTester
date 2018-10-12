import sys

def generatePacket(array):
	packet = '02 41 '+array+' 03'
	return packet +' '+ getCheckSum(packet)

def getCheckSum(packet):	
	byteArray = bytearray.fromhex(packet)
	checksum = 0
	for single_byte in byteArray:
		#print(single_byte)
		checksum ^= single_byte
	return '{:02X}'.format(checksum)
	
def test():
	print (generatePacket('0A 0B 0C'))

if (len(sys.argv)>1):
	packet = generatePacket(sys.argv[1])
	print (packet)
else:
	test()	
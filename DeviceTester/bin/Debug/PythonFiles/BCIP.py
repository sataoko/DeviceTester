import sys


def generatePacket(array):
	array = array.replace('10', '10 EF')
	array = array.replace('02', '10 FD')
	array = array.replace('03', '10 FC')
	chk = getCheckSum(array)
	return '02 '+array+ ' '+chk+' 03'
	
def getCheckSum(packet):	
	byteArray = bytearray.fromhex(packet)
	checksum = 0
	for single_byte in byteArray:
		checksum ^= single_byte
	return '{:02X}'.format(checksum)

def test():
	packet = generatePacket('0A 0B 0C')
	print (packet)

if (len(sys.argv)>1):
	packet = generatePacket(sys.argv[1])
	print (packet)
else:
	test()


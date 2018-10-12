import sys

def generatePacket(array):
	packet = '7B 41 '+array+' 7D'
	return packet +' '+ getCheckSum(packet)

#mod95
def getCheckSum(packet):	
	byteArray = bytearray.fromhex(packet)
	uTemp=32*len(byteArray)
	checksum = 0
	for single_byte in byteArray:
		checksum += single_byte
	c =(checksum-uTemp)%95+32
	return '{:02X}'.format(c)
	
def test():
	print (generatePacket('0A 0B 0C'))

if (len(sys.argv)>1):
	packet = generatePacket(sys.argv[1])
	print (packet)
else:
	test()	
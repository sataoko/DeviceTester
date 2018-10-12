import sys

def generatePacket(array):
	packet = '7B '+array+' 7D'
	return packet + ' ' + getCheckSum(packet)

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
	packet = generatePacket('41 31')
	print (packet)

if (len(sys.argv)>1):
	packet = generatePacket(sys.argv[1])
	print (packet)
else:
	test()	
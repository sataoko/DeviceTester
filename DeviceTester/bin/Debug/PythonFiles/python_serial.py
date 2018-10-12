import serial
import time
import sys


def sendCommand(bytes):
	ser = serial.Serial('COM3', 9600, timeout=0)
	ser.write(bytearray.fromhex(bytes))
	time.sleep(1)
	incomingData = ser.readline()
	ser.close()
	return incomingData
	
def test():	
	command1 = '41' #ASCII A
	command2 = '61' #ASCII a
	command3 = '42' #ASCII B
	command4 = '62' #ASCII b
	sendCommand(command1)

if (len(sys.argv)>1):
	packet = sendCommand(sys.argv[1])
	sys.stdout.write(' '.join('{:02X}'.format(x) for x in packet))
else:
	test()	


import socket 
from struct import pack,unpack
import time 
import sys
import binascii

def sendCommand(bytes):
	s = None
	try:
		#s= socket.socket(AF_INET,SOCK_STREAM)
		s= socket.socket(socket.AF_INET, socket.SOCK_STREAM)
		s.connect(('192.168.1.103', 2000))

		s.send(bytearray.fromhex(bytes))
		incomingBytes = s.recv(1024)
		return incomingBytes
		#return incomingBytes.split(b'\x03')[0]
	except Exception as e:
		print(e)
	finally:
		try:
			s.shutdown(SHUT_RDWR)
			s.close()
		except Exception:
			pass

def test():
	incomingBytes = sendCommand('02 64 4F 4F 46 3F 03 1C')
	#print (binascii.hexlify(incomingBytes))
	print ( ' '.join('{:02X}'.format(x) for x in incomingBytes))

if (len(sys.argv)>1):
	packet = sendCommand(sys.argv[1])
	sys.stdout.write(' '.join('{:02X}'.format(x) for x in packet))
else:
	test()	

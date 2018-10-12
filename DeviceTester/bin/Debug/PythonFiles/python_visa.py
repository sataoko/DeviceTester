import sys
import visa

def sendCommand(scpiCommand):
	try:
		rm = visa.ResourceManager()
		a = rm.list_resources()
		if(len(a)>0):
			inst = rm.open_resource(a[0])
			return inst.query(scpiCommand)
		else:
			return "no resource"
		
	except Exception as e:
		print(e)
	finally:
		try:
			
		except Exception:
			pass

def test():
	print (sendCommand('*IDN?'))

if (len(sys.argv)>1):
	replyFromInstrument = sendCommand(sys.argv[1])
	sys.stdout.write(replyFromInstrument)
else:
	test()	

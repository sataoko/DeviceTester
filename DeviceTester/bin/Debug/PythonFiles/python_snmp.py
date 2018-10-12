import sys
def snmpget(oid):
 
  from pysnmp.entity.rfc3413.oneliner import cmdgen
 
  global SNMP_HOST
  global SNMP_PORT
  global SNMP_COMMUNITY
 
  cmdGen = cmdgen.CommandGenerator()
 
  errorIndication, errorStatus, errorIndex, varBinds = cmdGen.getCmd(
    cmdgen.CommunityData(SNMP_COMMUNITY),
    cmdgen.UdpTransportTarget((SNMP_HOST, SNMP_PORT)),
    oid
  )
 
  # Check for errors and print out results
  if errorIndication:
    print(errorIndication)
  else:
    if errorStatus:
      print('%s at %s' % (
        errorStatus.prettyPrint(),
        errorIndex and varBinds[int(errorIndex)-1] or '?'
       )
     )
    else:
      for name, val in varBinds:
        #print('%s = %s' % (name.prettyPrint(), val.prettyPrint()))
        return val

		
SNMP_HOST="192.168.1.103"
SNMP_PORT="161"
SNMP_COMMUNITY="public"	

def test():
	print("up time:"+str(snmpget('.1.3.6.1.2.1.1.3.0')))
	print("sys name:"+snmpget('.1.3.6.1.2.1.1.5.0'))	

if (len(sys.argv)>1):
	packet = snmpget(sys.argv[1])
	sys.stdout.write(str(packet))
else:
	test()	
	

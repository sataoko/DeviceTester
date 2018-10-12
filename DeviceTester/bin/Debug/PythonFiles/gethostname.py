import socket
import sys
print("current hostname> ",end="")
print(socket.gethostname())

if __name__ == "__main__":
	if(len(sys.argv)>1):
		s = sys.argv[1]
		print(s+"> ",end="")
		print(socket.gethostbyaddr(s))
	


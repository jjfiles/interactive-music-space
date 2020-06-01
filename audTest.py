import os
import sys

if sys.platform == 'win32':
    print("test, running on Windows")
    TONAME = '\\\\.\\pipe\\ToSrvPipe'
    FROMNAME = '\\\\.\\pipe\\FromSrvPipe'
    EOL = '\r\n\0'
else:
    print("test, running on Mac or Linux")
    TONAME = '/tmp/audacity_script_pipe.to.' + str(os.getuid())
    FROMNAME = '/tmp/audacity_script_pipe.from.' + str(os.getuid())
    EOL = '\n'
    
print("Writing to \""+ TONAME + "\"")
if not os.path.exists(TONAME):
    print(" ..does not exist. Ensure Audacity is running with mod-script-pipe.")
    sys.exit()
    
print("Reading from \"" + FROMNAME + "\"")
if not os.path.exists(FROMNAME):
    print(" ..does not exist. Ensure Audacity is running with mod-script-pipe.")
    sys.exit()
    
print("--Both pipes initiated. Continuing")
TOFILE = open(TONAME, 'w')
print("-- File to write to has been opened")
FROMFILE = open(FROMNAME, 'rt')
print("-- File to read from has now been opened too\r\n")

def send_command(command):
    print("Send: >>> = \n" + command)
    TOFILE.write(command + EOL)
    TOFILE.flush()

def get_response():
    result = ''
    line = ''
    while line != '\n':
        result += line
        line = FROMFILE.readline()
    return result

def do_command(command):
    send_command(command)
    response = get_response()
    print("Rcvd: <<< \n" + response)
    return response

def quick_test():
    do_command('Help: Command=Help')
    do_command('Help: Command=GetInfo')

quick_test()
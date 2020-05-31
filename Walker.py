import os
import os.path as path

root_dir = 'MBNs'
out_name = "MBNs.nvi"

def format_efs_rpc(dir_name, name, ascii):
	template = r'{"jsonrpc": "2.0", "method": "WriteEFSData", "params": {"MessageVersion": 0, "FilePath": "/%s", "Data": [%s], "ItemType": "Item"}, "id": 0}'
	hack = path.normpath(path.join(dir_name, name)).split(os.sep)
	del hack[0]
	return template % ('/'.join(hack), ", ".join(ascii)) + '\n'

def format_nv_rpc(id, ascii):
	template = r'{"jsonrpc": "2.0", "method": "WriteNVData", "params": {"MessageVersion": 0, "ID": %d, "SubscriptionId": 0, "NVData": [%s]}, "id": 0}'
	return template % (id, ", ".join(ascii)) + '\n'

def file_as_ascii_bytes(dir_name, item):	
	with open(path.join(dir_name, item), mode="rb") as file:
		contents = file.read()

	ascii = [str(byte) for byte in contents]
	return ascii

def process_nv_items(dir_name, file_list):
	for item in file_list:
		id = int(item.split("__")[1])
		ascii = file_as_ascii_bytes(dir_name, item)
		with open(out_name, 'a') as nvi:
			nvi.write(format_nv_rpc(id, ascii))

def process_efs_items(dir_name, file_list):
	for item in file_list:
		name = item.split("__")[0]
		ascii = file_as_ascii_bytes(dir_name, item)
		with open(out_name, 'a') as nvi:
			nvi.write(format_efs_rpc(dir_name, name, ascii))

try:
	os.unlink(out_name)
except:
	pass

for dir_name, subdir_list, file_list in os.walk(root_dir):
	if dir_name == root_dir:
		process_nv_items(dir_name, file_list)
		continue

	process_efs_items(dir_name, file_list)

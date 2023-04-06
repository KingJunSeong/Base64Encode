import base64

str = input("Text : ")
bytes = str.encode('UTF-8')

result = base64.b64encode(bytes)
result_str = result.decode('ascii')

print(result_str)

code_bytes = result_str.encode('ascii')
decode = base64.b64decode(code_bytes)
decode_str = decode.decode('UTF-8')

print(decode_str)
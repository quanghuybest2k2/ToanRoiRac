' x + y + z = 15 với x,y,z >= 0
dem = 0
for x = 0 to 15
for y = 0 to 15
for z = 0 to 15
if x+y+z = 15 then dem = dem+1
' next tương ứng số biến
next
next
next
MsgBox("Ket qua la: "&dem)
' kết quả là: 136
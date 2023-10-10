#https://www.scanmevacuno.gob.cl.lacapa8.org/
# import qrcode

# img = qrcode.make("https://www.scanmevacuno.gob.cl.lacapa8.org/")
# type(img)  # qrcode.image.pil.PilImage
# img.save("codigoQR.jpg")

import qrcode

# Link for website
input_data = "http://scanmevacuno.gob.cl.scan.mevacuno.gob.cl.lacapa8.org.lacapa8.org/index.html"
#Creating an instance of qrcode
qr = qrcode.QRCode(
        version=1,
        box_size=10,
        border=5)
qr.add_data(input_data)
qr.make(fit=True)
img = qr.make_image(fill='black', back_color='white')
img.save('codeFab.png')

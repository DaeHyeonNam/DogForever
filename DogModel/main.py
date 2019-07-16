#!/usr/bin/env python
# coding: utf-8

import dlib, cv2, os
from imutils import face_utils
import numpy as np
import matplotlib.pyplot as plt


# # Load Models

detector = dlib.cnn_face_detection_model_v1('dogHeadDetector.dat')
predictor = dlib.shape_predictor('landmarkDetector.dat')


# # Load Dog Image


img_path = './dog.jpg'
filename, ext = os.path.splitext(os.path.basename(img_path))
img = cv2.imread(img_path)
img = cv2.cvtColor(img, cv2.COLOR_BGR2RGB)
# img = cv2.resize(img, dsize=None, fx=0.5, fy=0.5)

plt.figure(figsize=(16, 16))


# # Detect Faces

dets = detector(img, upsample_num_times=1)

img_result = img.copy()

for i, d in enumerate(dets):
    print("Detection {}: Left: {} Top: {} Right: {} Bottom: {} Confidence: {}".format(i, d.rect.left(), d.rect.top(), d.rect.right(), d.rect.bottom(), d.confidence))

    x1, y1 = d.rect.left(), d.rect.top()
    x2, y2 = d.rect.right(), d.rect.bottom()

    cv2.rectangle(img_result, pt1=(x1, y1), pt2=(x2, y2), thickness=2, color=(255,0,0), lineType=cv2.LINE_AA)
    
plt.figure(figsize=(16, 16))

print("Face is detected")

crop_img = img[y1:y2, x1:x2]
plt.imshow( crop_img)
plt.axis("off")
plt.savefig("dog.jpg")

print("Dog picture saved")

from colorthief import ColorThief


color_thief = ColorThief('dog.jpg')
color_thief


dominant_color = color_thief.get_color(quality=1)
dominant_color

print("Choosing color is done")

black= np.array([85,82,82])
brown= np.array([163,114,64])
yellow= np.array([197,177,149])
white= np.array([236,234,231])

color = np.array([black,brown,yellow, white])



min = 999999
chosen= 0
count =0

for e in color:
    sum=0
    for i in range(3):
        sum+= pow(dominant_color[i] - e[i],2)
    if min > sum :
        min = sum
        chosen = count
    count+=1



print(min)
print(chosen)
print("Characterizing is done")

f = open("test.txt","w")
f.write(chosen)
f.close()



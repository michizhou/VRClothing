# Extracts the face from a given image to be put onto the model.
# Saves the cropped image into another file (perhaps should directly edit the model.
# using the https://github.com/ageitgey/face_recognition package
# pip3 install face_recognition

import face_recognition
import os

print(os.listdir('../Assets/Faces/'))
image = face_recognition.load_image_file("../Assets/Faces/Nicolas_Cage_1.jpg")
face_locations = face_recognition.face_locations(image, number_of_times_to_upsample=0, model="cnn")
face_landmarks_list = face_recognition.face_landmarks(image)
print(face_landmarks_list)
print(face_locations)


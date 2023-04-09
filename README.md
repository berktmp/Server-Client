# Server-Client

This C# application consists of two main windows: a server window and a client window. The server window has a toggle button to control the state of a "lamb", a random number button to generate a random number, and a text box to display the random number. The client window has two buttons: one to toggle the color of a "lamb" based on the state of the server lamb, and another to request a new random number from the server. Both windows have beautiful design views.

## Table Of Content
- Used Techs
- Server Window
- Client Window
- Screen Recording
- ScreenShots

## This project was built using these technologies and features: 
- WPF .NET
- Font Awesome

## Server Window
The server window is responsible for generating random numbers and controlling the state of the "lamb". It has the following UI elements:
A toggle button to control the state of the "lamb". When the button is pressed, the state of the "lamb" changes (e.g. from "OFF" to "ON").
A "Generate Random Number" button that generates a random number and displays it in a text box.
A text box to display the generated random number.
The server window also contains a server component that listens for requests from the client window. When a request is received, the server changes the current state of the "lamb" and the current random number to the client.

## Client Window
The client window is responsible for displaying the current state of the "lamb" and requesting new random numbers from the server. It has the following UI elements:
A button to toggle the color of the "lamb". The color of the "lamb" changes based on the state of the server "lamb".
A "Get New Number" button to request a new random number from the server.
When the client window starts, it sends a request to the server to get the current state of the "lamb" and the current random number. The client then updates its UI elements based on the received values.

## 🛠 How to Run
1- Run the server window from Ide

2- Run the client window

## Screen Recording:
https://user-images.githubusercontent.com/130314590/230794879-8c6a61ba-6b2c-418e-90de-edf149c8dfeb.mp4


## ScreenShots:
![screenshot](https://user-images.githubusercontent.com/130314590/230794838-612e44b2-7a1c-4c49-9db0-2fdbc9a0c95c.PNG)

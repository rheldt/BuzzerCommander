# Buzzer Commander

Buzzer Commander is a simple buzzer program that let's two contestants face-off against each other to see who can ring-in first. It does lockout once someone rings in and resets itself after 5 seconds. I built it for a Family Feud-style game night we held. 

The buzzers were built using standard arcade buttons you can purchase online, hooked up to a USB usb joystick encoder card. The SharpDX library was used to listen for button activations.

The program listens for joystick buttons 11 and 12, which I've referred to as Buzzer A and Buzzer B, respectively (note: SharpDX refers to them as buttons 10 and 11, since they start with button 0). Anyway, there's certainly tons of room for improvement, but hopefully this will be a good starting point for your project.

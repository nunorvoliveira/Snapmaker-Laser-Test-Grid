
# Snapmaker Laser Test Grid

## Background

Do you ever feel the need to tweak the speed and power of the laser when engraving on your Snapmaker and were not sure what setting to use on a specific material?

I do!

So, I decided to create this windows tool that allows to create and export G-Code compatible with the Snapmaker Marlin flavoured controller to burn a matrix with 10 different laser power values at 10 different speeds.

As you can see below, this is a basic version at the moment, where you select a frw settings, and either copy the G-Code, preview it as text, or save it as a file.

The file contains the G-Code to build the grid you configured with the laser heas of a Snapmaker.

An image thumbnail is added to the file so you can see it on the touch screen.

To use the application, simply download the 2 files on the **Compiled** folder and run the application. Please refer below to Warning 2! This application requirements is .NET Framework 4.7.2.

![](/Misc/Images/01.%20Screenshot.png)

## Warning 1 :warning:

This is a very early release, and it's working, but may contain bugs. Please report them if you find them so I can fix them as soon as possible.

Below an example of a piece of plywood laser engraved with G-Code from this application.

![](/Misc/Images/02.%20Sample%20burn.jpg)

## Warning 2 :zap:

The executable file on the compiled folder is an executable file. Running an executable file from an unknown/untrusted source can be dangerous.

And I am an unknown/untrusted source to you.

Yes, It's safe. Yes, it only does what it is supposed to do. But I can't prove that to you and you can't know if I'm being honest.

So, use with caution.

## What can I do?

If you don't want to run the pre-compiled executable, you can install [Visual Studio Community Edition](https://visualstudio.microsoft.com/vs/community/) from microsoft - it's free - with the needed components for Visual Basic .NET Framework and you clone this repository and build it yourself.

# Safety, Safety, Safety!

Snapmaker uses a class 4 laser. Exposure to the eyes or skin can give you severe burns and cause blindness. Please do use all safety measures as an enclosure and safety goggles. 

For a complete list of safety measures, please visit Snapmaker site for [Snapmaker Safety Guidelines](https://support.snapmaker.com/hc/en-us/articles/4417388670871-1-Safety-Guidelines)

# Buy Me a Coffee?

If you want to support my work, feel free to buy me a coffee via PayPal.

[![Donate via PayPal](https://www.paypalobjects.com/en_US/i/btn/btn_donate_LG.gif)](https://www.paypal.com/donate/?business=A89J2W3D4GAAS&no_recurring=1&currency_code=EUR)

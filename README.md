# The Reality Stone!
**The goal of this project is to create a visually deceptive non-euclidean space inside of unity VR.
Interacable functionality in the demo: Initially you would come across a non-euclidean tunnel, and 
after you get pass, you are able to obtain an object (I labeled as reality stone)which maintains the world 
euclidean when you hold it.**

###### Things to notice:

* In order to be visually consistent, there are invisible walls in the scene that player can not 
move pass with the joystick control. 
* Note that I created the demo inside one of my previous projects, so you would want to just go to 
the scene "Individual_Project" for the project.

## Intention/Motivation: 
I was inspired by a video I happened to watch some time ago on someone who wrote a rendering engine 
himself which is capable of rendering non-euclidean space or geometries. It was to my surprise how 
realism and unrealism can be mixed in such an intersting way thanks to the computer. Then I had this 
idea that creating such kind of space in VR would definitely bring a distinctive experience. When granted
the power to immerse in a 3D environment using virtual reality, I feel its possible to actually
experenice unrealistic world.

## Why VR 
There are certainly precedents in bringing non-euclidean space into 3d environments, for example in games
such as _portal_. But naturally people are not overwhelmed as it is assumed beforehand that these environments 
are fake. However in VR, when people is using this kind of "ultra first person" experience when you interact
directly with the virtual world instead of a 2d screen, it might actually get very intersting. 

## Limits and critiques:
I tried researching online about rendering the space in a non-euclidean way, and it turns out that I would 
have to change the basic Unity rendering pipeline, which I did not have time and courage to dig into. So I
just recreated a simple but typical scene totally out of visual deception, and even that caused lots 
of trouble. Due to time limitations, I am not able to create more inetersting scenes such as a slope that goes 
upwards but appear as if it is downward. I also had to hardcode some of the axis values that are scene specific 
which is undesired in terms of reproducing.

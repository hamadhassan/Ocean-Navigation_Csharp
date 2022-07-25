# Ocean Navigation
## Case Study Scenario
In ocean navigation, locations are measured in degrees and minutes of latitude and longitude. Thus if you’re lying off the mouth of Papeete Harbor in Tahiti, your location is 149 degrees 34.8 minutes west longitude, and 17 degrees 31.5 minutes south latitude. This is written as 149°34.8’ W, 17°31.5’ S. There are 60 minutes in a degree. (An older system also divided a minute into 60 seconds, but the modern approach is to use decimal minutes instead.) Longitude is measured from 0 to 180 degrees, east or west from Greenwich, England, to the international dateline in the Pacific. Latitude is measured from 0 to 90 degrees, north or south from the equator to the poles.
Create a class angle that includes three member variables: an int for degrees, a float for minutes, and a char for the direction letter (N, S, E, or W). This class can hold either a latitude variable or a longitude variable.
Write one member function to change the angle value (in degrees and minutes) and a direction given from the user, and a second to display the angle value in 179°59.9’ E in string format. Also write a three-argument constructor.
You can use this to print a degree (°) symbol.

Create a class called ship that incorporates a ship’s number and location. Use two variables of the angle class to represent the ship’s latitude and longitude for the ship’s location. Write a parameterized constructor to initialize the attributes of the ship class. A member function of the ship class should print the position (latitude and longitude) of the ship; another should report/print the serial number.
## Domain Model
### Class name

### Relations and Constraints
![class name only](https://user-images.githubusercontent.com/96945594/180774247-3b635ad7-d07e-45ef-8daa-f73d2fb00612.png)
### Multiplicity
![multiplicity](https://user-images.githubusercontent.com/96945594/180774260-464668a5-affa-4459-942e-966dc5bd4d7f.jpg)
### Attributes and Function
![relation](https://user-images.githubusercontent.com/96945594/180774262-bb92fc29-d866-42ad-99b7-3b19965b0b1b.jpg)
#### Business Logic Layer
![bl](https://user-images.githubusercontent.com/96945594/180774241-7fd14a34-ee51-497a-9c7b-107b4847167b.JPG)
#### Data Layer
![dl](https://user-images.githubusercontent.com/96945594/180774256-03f8846b-bc44-4327-81ed-57c44bfc4b43.JPG)
#### User Interfaces Layer
![ul](https://user-images.githubusercontent.com/96945594/180774218-cd021821-36c4-4d79-a989-46a625c3c042.JPG)

## Sequence Diagram
### Main
![main](https://user-images.githubusercontent.com/96945594/180774668-98b87e79-d697-4308-a9ca-9254d0e94b3b.jpg)
### Add ship’s
![1 Add Ship](https://user-images.githubusercontent.com/96945594/180774672-8f3509cc-6441-45b2-a8ee-ad01a1236dd7.jpg)
### View Ship Position
![2  View Ship Position](https://user-images.githubusercontent.com/96945594/180774620-261d41b5-d9fd-4042-a2ec-ea2edf536bc1.jpg)
### View Ship Serial Number
![3 View Ship Serial Number](https://user-images.githubusercontent.com/96945594/180774648-e0244e6a-76f6-4b0a-b054-fdff515a7eed.jpg)
### Change Ship Position
![4 Change Ship Position](https://user-images.githubusercontent.com/96945594/180774658-b6738677-a910-42f7-8ca0-ad9fd69361ef.jpg)

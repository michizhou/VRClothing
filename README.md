# VRClothing

### Inspiration
We have all experienced the time when we wish to try on an item of clothing found on Pinterest, but unable to due to the constraints of our current online retail systems. Our product VRClothing aims to solve this problem by providing users with a novel method of interacting with clothing items sold by retail companies.

### What it does
#### Problems Faced By Customers

- Certain customers may not be able to try on a clothing item due to monetary reasons.
- If a customer wants to see how they look in a new item of clothing, he or she must travel to the store and physically try it on. This is a very time-consuming process.
#### Our Higher-Level Objectives

- Allow people to see how they look in different looks in 3D space
- Provide users with a changing room
- Implement an online shopping platform that incorporates the aforementioned objectives
#### Detailed Objectives

- Allow the user to zoom in and zoom out of the item of clothing and allow the user to interact with the clothing item
- Allow the user to choose from a database of clothing items in an intuitive manner
- Allow the user to choose his or her gender as to reflect his or her body type
### How we built it
#### Design Process

- In the early hours of the hackathon, we through a diverge-converge design cycle.
- For the divergence process, our team generated as many ideas as possible for a hackathon using methods such engineering tools such as SCAMPER ("Substitute, Combine, Adjust, Modify, Put, Eliminate, Reverse").
- For the convergence process, our team used a team count and a Pugh chart in order to help eliminate the infeasible and arrive at the most promising idea.
- For the remainder of the hackathon, we continued to refine our product, focusing on lower-levels of design requirements and subsystems.

**Unity and Oculus Rift** The primary VR engine we utilized was Unity and our main programming language is C#. The Oculus Rift provides the means of connecting the user to the virtual reality world.

**Leap Motion** In order to track the movement of the hands and finger motions of the user, we utilized Leap Motion. The Interaction Engine allowed us to work with to connect this method of user input to VR. The Leap Motion sensor is attached to the laptop running the Unity scripts.

**Shopify** The Shopify e-commerce platform was used to develop the front-end store of our retail service. The website currently houses six clothing items and provides users with the ability to enter delivery address and payment information.

### Challenges we ran into
- Projection of the clothing items onto the user 3D model
- Using Leap Motion to interact with objects
### Accomplishments that we're proud of
This is our first time working together. We are proud of the extent to which we were able to get to know each other in a short span of time and collaborate in an effective manner. Furthermore, this is our first time working with the Leap Motion platform. We were able to learn quickly the workings of the platform with the assistance of official documentation, online tutorials, as well as further mentorship as resources.

### What we learned
- Although a design process may seem to go smoothly, there are always risks involved and we must prepare for these tumultuous moments through risk management. For example, just 8 hours before submission, our team encountered significant difficulties with the projection of clothing onto the 3D human model. In the end, we had to make certain compromises amongst the team in order to push forward.
- We all had different styles of solving problems. It was fascinating to recognize differences and learn from each other.
### What's next for VRClothing
- Implement machine learning and computer vision as to further tailor the human 3D model as to include parameters such as body shape, skin color, height, and etc.
- Scan the user's face and project the image onto the 3D human model
- Improve the mapping of the clothing onto the 3D human model

# A Walk Through Time

## IMTC 505 Project – Group TBN

Welcome to "A Walk Through Time" - an immersive experience project developed by Group TBN for the IMTC 505 course. In this README file, you will find comprehensive information about the project, including the working application, source code, and other essential details.

## 1. Working Application and Source Code

### 1.1 Acquisition of Models:

Our app is designed to be visually engaging, and we achieved this by incorporating various 3D models. This section provides details on where and how we got these models, aiming to be transparent about our sources and methods. In developing "A Walk Through Time," we carefully selected and modified several 3D models to enhance the app's aesthetic and feel, making it more enjoyable for users.


1. **Coverflow:**
   - Model Source: [Simple Scroll-Snap](https://assetstore.unity.com/packages/tools/gui/simple-scroll-snap-140884) from Unity Asset Store.
   - Description: We used the "Simple Scroll-Snap" from Unity Asset Store and customized it to create a dynamic Coverflow. This Coverflow is used to display historical images in a seamless and immersive manner, enhancing the overall user experience.

2. **3D Animated GiftBox:**
   - Model Source: [3D Game Kit](https://assetstore.unity.com/packages/templates/tutorials/unity-learn-3d-game-kit-115747#content) from Unity Asset Store.
   - Description: We integrated the 3D animated GiftBox from the "3D Game Kit" to introduce gamification elements into our project. The GiftBox model from the kit adds an engaging and interactive component, making the project more immersive for users.

3. **3D Animated Arrow:**
   - Model Source: [Sketchfab](https://sketchfab.com/3d-models/directional-arrow-1-9658f746810f4390bbcbc88275c40047).
   - Description: To guide users through different locations and provide information, we incorporated a 3D Animated Arrow model from Sketchfab. This arrow serves as a visual indicator, directing users along the path they should follow for an enriched walkthrough experience.

  4. **MRTK3 Components:**
   - Components Used: Different canvas components and Interactble button from [MRTK3](https://learn.microsoft.com/en-us/windows/mixed-reality/mrtk-unity/mrtk3-overview/).
   - Description: We utilized various canvas components and interactive buttons from MRTK3 to enhance user interactions within the application. These components contribute to the overall accessibility and usability of "A Walk Through Time."


### 1.2 Implementations of Interactions (3 points)

#### 1.2.1 User Interactions (a)

In "A Walk Through Time," user interaction is designed to facilitate a historical journey through different time periods. The documentation provides a step-by-step guide on navigating the application, ensuring users can seamlessly engage with its features. Here are three key user interactions within the application:
![Map of the courtyard with 5 points.](https://res.cloudinary.com/dolt8nnzc/image/upload/v1702870917/Picture1_p9ijyi.png)

In our app, users embark on a historical journey through different time periods. We've highlighted five main points: 1) UBCO History, 2) City of Kelowna History, 3) Kelowna Wildfire History, 4) Indigenous People's History, and 5) Okanagan Lake History. 

1. **Interacting with the Coverflow for Historical Information:**
   - In the Coverflow, we've incorporated five images representing different time periods related to historical milestones for each of the five points in our application. For instance, in UBCO History, five images span from the campus's 2004 planning to the 2020 future plans for the downtown campus. Users can swipe left or right to explore these images, and pressing the "Explore" button next to each image provides additional detailed information about that specific time point.

2. **Accessing Gift Boxes with Questions:**
   - After exploring any of the five historical points, users encounter visual cues guiding them to different gift boxes. A two-finger press on the gift box triggers a 3D animation, revealing a question box. Users answer questions based on the gathered information, with multiple attempts allowed. Correct answers earn users points, adding a gamified and interactive element to the application.

3. **Visual Cues for User Guidance:**
   - To enhance user navigation and accessibility, visual cues such as 3D animated arrows are strategically placed throughout the courtyard. These cues guide users to the five different points in our project, ensuring a seamless and user-friendly experience while exploring the historical locations.


#### 1.2.2 Code Descriptions (b)

In the development of "A Walk Through Time," we've implemented five essential scripts to orchestrate various functionalities within the application:

1. **GiftBoxController Script:**
   - Purpose: This script is responsible for managing the GiftBox, controlling its animations, and handling the user interface related to questions. It ensures the smooth interaction and engagement of users with the gamified elements in the application.

2. **Simple Scroll-Snap Script:**
   - Purpose: The Simple Scroll-Snap script takes charge of controlling the Coverflow feature. It enables users to seamlessly navigate through historical images by swiping, interact with buttons, and view additional information through the canvas associated with each image.

3. **TouchControl Script:**
   - Purpose: The TouchControl script governs the interactions associated with the gift box and its animations. It provides the necessary functionality to enhance user engagement when interacting with the 3D animated GiftBox, adding a tactile and responsive feel to the user experience.

4. **ToggleVisibility Script:**
   - Purpose: The ToggleVisibility script plays a crucial role in managing the visibility of different GameObjects within the Unity scene. This script ensures that specific elements are displayed or hidden based on the application's context, contributing to a clean and organized user interface.

5. **QuestBoxController Script:**
   - Purpose: The QuestBoxController script takes control of the quiz-related canvas, including questions, correct answer displays, and wrong answer displays. It manages the quiz interaction, allowing users to answer questions and providing feedback based on their responses, thereby enhancing the educational aspect of the application.

These scripts collectively form the backbone of our application, enabling a seamless and engaging user experience while ensuring the smooth functioning of various interactive elements.


### 1.3 APK File of the Application (2 points)

An installable APK file of the working version of the application is provided in this section. Users can download and install the application on their Android devices, allowing them to experience "A Walk Through Time" firsthand.

### 1.4 Source Code (3 points)

The source code for the project is included in this section. Developers can explore the codebase to gain a deeper understanding of the project's architecture, logic, and implementation. The source code is organized and well-documented, facilitating collaboration and further development.

---

## Getting Started

To run the application locally or explore the source code, follow the instructions below.

### Prerequisites

- [Android Studio](https://developer.android.com/studio) installed
- [Git](https://git-scm.com/) installed

### Installation

1. Clone the repository:

```bash
git clone https://github.com/your-username/A-Walk-Through-Time.git

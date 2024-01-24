# Application Documentation

Application Overview
The WatchAspire application is an all-encompassing assistance tool designed for community safety and personal care. This wide-ranging application caters to several focus areas that work collectively to ensure the user's safety and security.
User Tracking
The application uses location-tracking features to continuously monitor the user's whereabouts. This real-time data could be leveraged for multiple assistance-needs like sending help if a user is in danger or issuing evacuation requests.
Phrase Detection
Incorporating the power of Natural Language Processing, the app can recognize certain phrases or language cues that indicate a user might be in distress or in need of help. This could trigger specific actions, such as immediate alerts or notifications.
Real-Time Notifications
If a user needs help or assistance, the application can send out real-time notifications to other nearby users, essentially creating a community-driven assurance that help is always nearby.
User Check-Ins
The application allows users to "check in", providing real-time updates on their status and location, ensuring that they are safe and secure, and keeping other users informed of their wellbeing.
Information Upload
Users can upload critical information to the application. This could be useful in various scenarios, such as sharing image or video evidence from a security scene, uploading user health data for medical monitoring, and more.
Security Surveillance
The app also lets users contribute to a databank of security footage. If a security incident occurs, users can upload any relevant video or images to this databank. This collective intelligence could potentially assist law enforcement in tracing incidents and ensuring public safety.
Surveys
Users may receive real-time surveys about their surrounding environment. These surveys can provide valuable insight into particular areas or situations, assisting in creating a more comprehensive knowledge base that could benefit all users.
Live Video Monitoring and Alerts
The application is designed for users to start live video monitoring whenever needed. It also allows users to get alerted based on certain triggers during video monitoring, ensuring their safety and security at all times.
The WatchAspire application is robust in its offering and strives to deliver comprehensive safety solutions to its users. This comprehensive tool ensures that help is just a click away when it's needed the most.
Please note that user privacy is of utmost importance and all features adhere to strict privacy policies and guidelines. Users are in control of their data and can modify their settings based on personal preferences and requirements.

This application offers an extensive platform for a user safety system, which includes a plethora of interactive features to improve user experience and safety.

## Models

- `UserModel`: Handles user accounts, manages JSON Web Tokens (JWTs) for session management, and handles password security.
- `CheckInModel`: Manages the application's 'Check-in' feature which can be manually or automatically triggered.
- `RecordingModel`, `LiveStreamModel`: Enable users to upload supporting visual material during emergencies.
- `EvacuationModel`: Manages user evacuation data.
- `TutorialModel`, `QuizModel`, `SurveyModel`: Continuously improve the application's learning resources.

## View Models

- `UserViewModel`: Manages all user-related functionality, providing a layer of separation between the UI logic and business logic of the application.
- Other view models based on the described functionality, such as `CheckInViewModel`, `RecordingViewModel`, `LiveStreamViewModel`, `EvacuationViewModel`, `TutorialViewModel`, `QuizViewModel`, `SurveyViewModel`, provide the necessary data and operations for their respective views.

## Services

- `UserService`: Responsible for handling user data, such as login, signup, session management.
- Other services depending on the application's functionality like `CheckInService`, `RecordingService`, `LiveStreamService`, `EvacuationService`, `TutorialService`, `QuizService` and `SurveyService` manage data and operations for their respective models on the server side.

## Views

The views of this application are designed to follow closely with the models and services, with designed views for each function of the application. These views allow users to interact with features such as user registration and settings, emergencies check-ins and recordings, evacuation, surveys, tutorials, quizzes, and livestreams.

## Features

Users can browse through tutorials, take interactive quizzes, share information via surveys, request evacuation, recall a livestream, among a variety of other features.

## Real-Time Assistance

The application uses Azure services to handle various aspects of real-time aid during emergencies. For example, users can submit text for AI analysis and guidance, contribute live videos or pre-recorded material, and receive alerts based on recognized emergency patterns.

## Conclusion

This application strives for user safety, enhanced communication, and continuous learning, leveraging cutting-edge technology to provide an interactive and comprehensive safety network.

*Please note that the files described above are indicative and should map to the actual files present in your project directory.*

## User Registration and Management

The registration process begins with the user accepting the End-User License Agreement (EULA), followed by providing personal details and setting up initial preferences. This information is maintained in the `UserModel`.

## Check-ins

This safety-enhancing feature can either be manually invoked by users or automatically triggered when specific phrases are detected using cognitive service's speech-to-text analysis feature.

## Recording and Live Streaming

The application allows users to upload videos, images, or text comments that help in creating transparency in emergencies. These features are driven by the `RecordingModel` and `LiveStreamModel`.

## Learning Resources

The application is equipped with a variety of learning resources housed within `TutorialModel` and `QuizModel`. Text-based tutorials and quizzes provide users with an abundance of information and a self-assessment tool.

## Surveys

The `SurveyModel` allows the application to continuously improve its existing area information through the input of users and admins, which contributes to making the application's knowledge increasingly reliable.

## Live Video

The application features live video streaming which is fully integrated and handled by the `LiveStreamModel`. The videos are processed for object detection using advanced AI models to aid users or responders in understanding the surroundings better.

## Text to Speech

The text-to-speech feature processes essential information from the live video and other sources and communicates it to the user in an auditory manner, thereby offering another modality of user interface.

## Designated Responder

Users can take on the role of a responder according to their availability, thereby contributing to the safety network.

## Requested Check-ins

Users can request check-ins and also ask for multiple users to respond to the same request for more extensive coverage. Every check-in update is conveyed to the requester via an easily accessible email.

## Location-Based Pet Search

A location-based pet search functionality has been incorporated to assist users in finding their lost pets.

## Directions Guidance

Users are provided with simplified navigation to specific check-ins or evacuation locations to ensure a swift response.

## Responsiveness and User Interaction

The application is well-integrated with a powerful AI system to ensure efficient information exchange, streamlined conversations, focused and effective communication, and smart user interactions.

## Handlers for Different Role Actions

Depending on the stage and situation of the check-in or evacuation, handlers for user, admin, and AI actions are activated. Different handlers take ownership of the process at various phases, making the system robust, efficient, and reliable.

In conclusion, the application provides a comprehensive platform for user safety by enabling interaction with a variet
of features. The purpose of this application is to offer a secure environment backed by cutting-edge 
AI technology and a well-integrated suite of services.

Data Models
The data model files contain various data classes and interfaces that reflect the structure of data that the application works with. Each data model has a specific role:
UserModel: This model provides the structure for maintaining information about users, including personal details, preferences, and security information. It plays a crucial role in managing user profiles and security features like password and session handling using JWTs.
CheckInModel: This model is used to handle the data for 'Check-in' feature, allowing users to request help or provide updates about their safety status.
RecordingModel: This model handles information related to uploaded content, for example, videos, images, or text comments. It is used during emergencies to help in providing additional context or information.
EvacuationModel: This model maintains information about user evacuation data. It is used to track and manage evacuation situations effectively.
SurveyModel: This model handles data collection for surveys. It is used to gather, track, and update information from surveys that users or admins submit.
TutorialModel, QuizModel: These models handle learning resources, offering interactive features for users to learn from.
LiveStreamModel: This model is used to manage livestream data, providing links to active streams, their status, and owner information.
MessageModel: Represents individual messages sent between users, including sender, receiver, time stamp, message content, and any attachments.
NotificationModel: Provides structure for the various notifications that the application sends, such as alerts, updates and reminders.
RecommendationModel: Provides structure for recommendations generated for a user, such as suggested tutorials or relevant check-in requests.
UserAnalyticsModel: Captures various user behavior and usage metrics, like login frequency, feature usage, errors encountered, and feedback submissions.
PhoneContactsModel: Represents the phone contact list of a user, including names, numbers, and other available details.
EventModel: Encompasses details of events organized within the application, which could be webinars, quizzes, communal check-ins, etc.
BadgeModel: Stores details of each earned badge for a user, such as badge name, description, date earned, and associated rewards.
FriendModel: Represents the user's friends list within the application, including friend details and friendship status.
LeaderboardModel: Contains leaderboard rankings for users, including their ranks, scores, and identifiable information.
ActivityModel: Represents user activity data, such as login/logout times, activities performed, durations, and performance metrics.
SupportTicketModel: Contains user-generated support requests, their descriptions, statuses, system-generated IDs, and associated responses.
SubscriptionModel: Stores subscription details of each user, such as subscription type, start and end dates, associated costs, and payment status.
BillingModel: Contains billing-related information of the user, such as billing address, card details (encrypted), transaction history, and subscription-related costs.
NewsUpdateModel: Represents news updates pushed by the application, including the update content, timestamp, and associated links or media.
TrainingModel: Stores details of each training session offered, including session description, scheduled time, duration, participants, and trainer details.




UserService: Manages interactions for the UserModel, such as user profile creation, updates, deletions and security handling.
CheckInService: Manages the operations of check-ins, like creating a check-in request, status updates, and associated notifications.
RecordingService: Handles uploading, storing, and accessing video/image/text content uploaded to the application.
EvacuationService: Manages evacuation data, including creating evacuation requests, status updates, and notifications.
SurveyService: Handles the creation, update and deletion of surveys, as well as processing responses.
TutorialService, QuizService: Manages learning resource data, including creating, updating and processing responses for both tutorials and quizzes respectively.
LiveStreamService: Controls livestream data, such as creating new streams, updating stream information, and providing stream access details.
EmergencyAlertService: Manages operations involved in triggering, broadcasting, and documenting emergency alerts, including location data and timestamps for the EmergencyModel.
SessionManagementService: Handles operations such as session creation, refreshing, invalidation and session-related security for the UserModel.
ResponderService: Manages available responders, their schedules, and connects them with users requesting help using the ResponderModel.
RewardSystemService: Handles tracking, calculating, and allocating rewards for active participation as outlined in the RewardModel.
PetSearchService: Manages operations for the location-based pet search feature using the PetSearchModel.
SpeechService: Responsible for the text-to-speech and speech-to-text features, working with the SpeechModel.
GeolocationService: Handles location tracking for users and provides location-related services such as directional guidance using the GeoLocationModel.
EmailService: Handles sending email notifications, reminders, updates, and other email-based communication using the EmailModel.
TrainingService: Manages the operations for the training features plan, such as creating, maintaining, and delivering training sessions using the TrainingModel.
FeedbackService: Manages operations related to feedback collection, response, and improvement tracking using FeedbackModel.
AccountVerificationService: Responsible for managing the account verification process. It generates verification codes, validates them, and updates the verification status in the UserModel.
PrivacySettingsService: Manages the privacy settings of a user as defined in the PrivacyModel. It allows users to set, update, and retrieve their privacy settings.
NotificationService: Sends out alerts and notifications to users based on their settings and activities. This service interacts mainly with the NotificationModel.
PasswordResetService: Provides functionality to reset the user's password. It generates password reset tokens, validates them, and updates the password in the UserModel.
SupportService: Handles support requests sent by users. It allows for the creation, update, retrieval, and deletion of support requests stored in the SupportRequestModel.
ReportingService: Allows users to report issues, bugs, or incidents. It interacts with the ReportingModel to create, update, delete, and fetch reports.
SecurityService: Handles all security-related functionalities, including encryption, decryption, salting and hashing of sensitive information.
SubscriptionService: Manages users' subscriptions to various plans or services within the app. It interacts with the SubscriptionModel.
BillingService: Handles all the billing related information of users. It can fetch and update the billing details from the BillingModel.
ContentModerationService: Manages validation and moderation of user-generated content to ensure it adheres to community standards and guidelines.
UserProfileService: Manages rendering and updating of user profile information stored in the UserProfileModel.
CommunityService: Handles interactions with community features such as message boards, user groups, or chats. It works with the CommunityModel.
ActivityTrackingService: Tracks user activity and updates the ActivityModel appropriately. It can also analyze user activity for trends or suggestions.
FriendService: Manages the user's friends list, friend requests, and related interactions using the FriendModel.
LeaderboardService: Updates and retrieves the leaderboard standings using data from the LeaderboardModel.
BadgeService: Awards and tracks badges earned by users for completing certain tasks or achieving milestones, interfacing with the BadgeModel.
MessagingService: Allows users to send, receive, and manage private messages between themselves, utilizing the MessageModel.
RecommendationService: Provides personalized recommendations to users based on their activities, preferences, and interactions using the RecommendationModel.
UserAnalyticsService: Tracks and analyzes user behavior and usage metrics, updating and referencing the UserAnalyticsModel.
EventService: Manages the creation, updates, and delivery of events as part of the application's features, utilizing data from the EventModel.



# Video Wall With Analytics

This project was developed on 2017 and showcased on 2018 as part of Grassroot Seminar Event to showcase the possible future of community centre in Singapore.

**NOTE**: The programme is not working at the moment unless you have Microsoft Face API key

Consist of two applications:

1. Videoplayer with analytics (FaceAnalysis.cs)
2. Remote Manager 

Working Principle:

A camera is required to run the project; 

camera will capture image once face is identified while videoplayer will play random video

API will process the image to obtain image and gender.

The age and gender will be stored in files.

Videoplayer will attempt to read the files.

Depending on age and gender (range is set), the videoplayer will cut off the random video and display a new video consist of brochure.

The new video will be picked and it will go back to random video for display once it is finished.

Process will keep repeating


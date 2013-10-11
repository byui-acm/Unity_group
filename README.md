Unity_group
===========
Here's how to get a unity project working with git (ask Sam if you can't get it working):

1. Create a new project inside Unity and let’s call it InitialUnityProject. You can add any initial assets here or add them later on.
2. Enable Meta files in Edit->Project Settings->Editor
3. Quit Unity (We do this to assure that all the files are saved)
4. Delete the Library directory inside your project directory
5. Pull down or “clone” an empty repository to the same folder as the Unity project. To clarify, we will have a folder called “InitialUnityProject” (what we named our project) and inside will be the Unity “assets” and “ProjectSettings” folder. Also inside the “InitialUnityProject” folder will be a “.git” folder. There may also be a “.gitattributes” and “.gitignore” file. Once you have confirmed that all of the above items are in the same folder move on to the next step
6. Now we need to create or modify (if it already exists) a .gitingore file in the “InitialUnityProject” folder. The code we will be putting in the file is listed below
7. Commit the local copy of the Unity project now and sync with the repository. Confirm that the Unity files and folders exist on the remote server
8. Open Unity. At this point it should rebuild the library. Ensure the project works (or continues to work if you did this with an already created project)

The .gitignore file will tell Git which files to leave local only and not sync to the server. We want to be sure to skip all library files and all scripting project files. We will allow those to be rebuilt whenever they need to be (should not be a problem). Our .gitignore file should look like this:
(Just copy the .gitignore file from an existing project)

<pre>
# Unity .gitignore file.
.DS_Store
Library
Library/*
*.csproj
*.sln
*.userprefs
Temp
*.pidb
Build
</pre>

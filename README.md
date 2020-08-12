# Huawei Xamarin Analytics Library

## Contents
- Introduction
- Installation Guide
- Xamarin Analytics SDK Method Definition
- Configuration Description
- Licensing and Terms

## 1. Introduction

The Xamarin SDK wraps the Android SDK with Managed Callable Wrappers through the usage of Android Bindings Library projects. It provides the same APIs as the native SDK.

The Xamarin SDK libraries are described as follows:

- Library .DLL files: These are the files enable the usage of the native Android SDK interfaces. Once generated, these files can be referenced & used directly in a Xamarin.Android project.

## 2. Installation Guide
Before using the Xamarin SDK code, ensure that Visual Studio 2019 is installed with "Mobile development with .NET" support.

### 2.1 Download native Android SDK packages
The analytics SDK and its dependencies must be downloaded from the Huawei repository.
Use the following URLs to download the packages.
- [hianalytics-4.0.2.300.aar](https://developer.huawei.com/repo/com/huawei/hms/hianalytics/4.0.2.300/hianalytics-4.0.2.300.aar)
- [tasks-1.3.3.300.aar](https://developer.huawei.com/repo/com/huawei/hmf/tasks/1.3.3.300/tasks-1.3.3.300.aar)
- [update-2.0.6.300.aar](https://developer.huawei.com/repo/com/huawei/hms/update/2.0.6.300/update-2.0.6.300.aar)
- [network-grs-4.0.2.300.aar](https://developer.huawei.com/repo/com/huawei/hms/network-grs/4.0.2.300/network-grs-4.0.2.300.aar)
- [network-common-4.0.2.300.aar](https://developer.huawei.com/repo/com/huawei/hms/network-common/4.0.2.300/network-common-4.0.2.300.aar)
- [base-4.0.2.300.aar](https://developer.huawei.com/repo/com/huawei/hms/base/4.0.2.300/base-4.0.2.300.aar)
- [opendevice-4.0.1.301.aar](https://developer.huawei.com/repo/com/huawei/hms/opendevice/4.0.1.301/opendevice-4.0.1.301.aar)
- [agconnect-core-1.0.0.300.aar](https://developer.huawei.com/repo/com/huawei/agconnect/agconnect-core/1.0.0.300/agconnect-core-1.0.0.300.aar)
- [agconnect-credential-1.0.0.300.aar](https://developer.huawei.com/repo/com/huawei/agconnect/agconnect-credential/1.0.0.300/agconnect-credential-1.0.0.300.aar)
- [agconnect-https-1.0.0.300.aar](https://developer.huawei.com/repo/com/huawei/agconnect/agconnect-https/1.0.0.300/agconnect-https-1.0.0.300.aar)
- [datastore-core-1.0.0.300.aar](https://developer.huawei.com/repo/com/huawei/agconnect/datastore-core/1.0.0.300/datastore-core-1.0.0.300.aar)
- [datastore-annotation-1.0.0.300.jar](https://developer.huawei.com/repo/com/huawei/agconnect/datastore-annotation/1.0.0.300/datastore-annotation-1.0.0.300.jar)

### 2.2 Open the library project
An Android Bindings Library project for Xamarin allows the usage of only one .aar file. For this reason the library repository comes with multiple library projects. 

Open up Visual Studio 2019. Then from the menu;
	
- Click "Open a project or a solution"
- Navigate to the directory where you cloned the repository and open "XHiAnalytics-4.0.2.300.csproj".

### 2.3 Import the downloaded packages
Once you open the library project for the analytics SDK, each package you downloaded in the first step must placed under its related library project.

Inside the "Solution Explorer", expand each project and repeat the steps below:
- Right click "Jars" -> "Add" -> "Existing Item" (Shift + Alt + A)
- Navigate to the folder where you downloaded the packages and select the related .aar or .jar file.	
    
         Example: For XTasks-1.3.3.300 project, import "tasks-1.3.3.300.aar"
- Click on the package file you just imported. 
		In the **properties** window, 
			
    - set the Build Action as "LibraryProjectZip" if the file type is .aar
	- set the Build Action as "EmbeddedJar" if the file type is .jar

### 2.4 Download the common dependencies
There are some open-source dependencies that should be downloaded seperately to each necessary library project. These dependencies are downloaded by using the NuGet Package Manager console.

From the Visual Studio's toolbar, click Tools -> NuGet Package Manager -> Package Manager Console. Then perform the steps below:
- In the package manager console window, set one of the following projects as the default: 
	- XAgConnectHttps-1.0.0.300
	- XAgConnectCredential-1.0.0.300
	- XHiAnalytics-4.0.2.300
	
- Run the following commands to install the common dependencies. 
**NOTE:** Make sure you have a **stable internet connection** and if you have a proxy setting, make sure it does prevent access to the NuGet platform.

```
    Install-Package Square.OkHttp3 -Version 3.11.0
	Install-Package Xamarin.Square.OkIO -Version 1.14.0
```
		
- Repeat the steps for **each of the three projects**.

### 2.5 Build the library.
From the Visual Studio's toolbar, click "Build" -> "Build Solution" (Ctrl + Shift + B).
Once the build process is complete, generated classes should be visible in the object browser.

(View -> Object Browser) (Ctrl + Alt + J)

### 2.6 Using the library
There are two ways to use the Analytics SDK after the .dll files are generated.

#### 2.6.1 Reference the generated library files
You can add the generated .dll files as references to your project directly.
- Expand the solution of your Xamarin.Android app, then right click "References" -> "Add"
- In the Reference Manager window that just opened, click the "Browse" button at the bottom.
- Navigate to the directory of the XHiAnalytics-4.0.2.300 library project. Based on your choice of build type (Debug or Release), the generated .dll files will inside on of the following directories:
    - XHiAnalytics-4.0.2.300\bin\\**Debug**
    - XHiAnalytics-4.0.2.300\bin\\**Release**
- Select all of the generated .dll files. Click "OK", then you should be able to use the classes from the libraries you just imported.


#### 2.6.2 Reference the projects
You can add the library projects to the solution of your Xamarin.Android application, then add the projects as a reference.

- From the Visual Studio's toolbar, click "File" -> "Add" -> "Existing Project"
- Navigate to the directory where the library projects reside, then select the **.csproj** file of one of the library projects.
         
         Example: For XTasks-1.3.3.300 project, select "XTasks-1.3.3.300.csproj"
- Expand the solution of your Xamarin.Android app, then right click "References" -> "Add"
- In the Reference Manager window that just opened, click "Projects" then select the project you just added to your solution. Click "OK", then you should be able to use the classes from the library you just imported.
- Repeat the above steps **for each of the library projects.**

## 3. HUAWEI Analytics Kit SDK for Xamarin
| HiAnalyticsTools | |
|:-------------:|:-------------:|
| EnableLog     | This API is called to enable the HUAWEI Analytics Kit log function. |
| EnableLog(int level) | This API is called to enable debug logs and set the minimum log level (minimum level of log records that will be printed). |

| HiAnalytics | |
|:-------------:|:-------------:|
| GetInstance(Activity context) | Initializes HUAWEI Analytics Kit. HUAWEI Analytics Kit must be initialized in the main thread, based on the configuration. |
| getInstance(Context context) | Initializes HUAWEI Analytics Kit. HUAWEI Analytics Kit must be initialized in the main thread, based on the configuration. It is **recommended** that this API be called in the application section. |

| HiAnalyticsInstance | |
|:-------------:|:-------------:|
| SetAnalyticsEnabled | This API is called to specify whether to enable data collection based on predefined measurement points. |
| SetUserId | This API is called to set user IDs. |
| SetUserProfile | This API is called to set user attributes. |
| SetPushToken | This API is called to set the push token, which can be obtained from HUAWEI Push Kit. |
| SetMinActivitySessions | This API is called to set the minimum interval between two sessions. |
| SetSessionDuration | This API is called to set the session timeout interval. |
| SetCurrentActivity | This API is called to set the current screen name, which is used to identify the currently displayed screen. |
| OnEvent | This API is called to record events. |
| ClearCachedData | This API is called to delete all collected data cached locally, including cached data that failed to be sent. |
| AAID | This API is called to obtain the app instance ID from AppGallery Connect. |
| RegHmsSvcEvent | This API is called to register services of HUAWEI Analytics Kit to report service events related to HUAWEI IDs and in-app purchases. |
| UnRegHmsSvcEvent | This API is called to deregister services of HUAWEI Analytics Kit. |
| GetUserProfiles | This API is called to obtain user attributes. |

| Classes with pre-defined constants | |
|:-------------:|:-------------:|
| HAEventType | This API provides the ID constants of all predefined events. |
| HAParamType | This API provides the IDs of all predefined parameters, including the ID constants of predefined parameters and user attributes. |

You can read more and get detailed information about the interfaces described above from [developer.huawei.com](https://developer.huawei.com/)

## 4. Configure parameters.
No.

## 5. Licensing and Terms
Huawei Xamarin SDK uses the Apache 2.0 license.
# University Activity Management System (UAMS)

A University Activity Management System (UAMS) designed to manage and organize university activities efficiently. This system includes user management, activity management, participant management, attendance tracking, and report generation.

## Installation Guide

The installation package is located in the `UAMS_setup/Debug` directory. Follow these steps to install the system:

1. Navigate to the `UAMS_setup/Debug` directory.
2. Run the setup executable file.
3. Follow the on-screen instructions to complete the installation.

## User Manual

### Table of Contents
1. [Introduction](#introduction)
2. [Students](#students)
   - [Login](#login)
   - [Personal Information](#personal-information)
   - [Search Activity](#search-activity)
   - [My Activity](#my-activity)
   - [Personal Summary](#personal-summary)
3. [Professors](#professors)
   - [Login](#login-professor)
   - [Personal Information](#personal-information-professor)
   - [Activity Release](#activity-release)
   - [Activity Manage](#activity-manage)
   - [Activity Report](#activity-report)
4. [Managers](#managers)
   - [Login](#login-manager)
   - [Manage Users](#manage-users)
   - [Manage Activities](#manage-activities)
   - [Manage Student Activities](#manage-student-activities)

### Introduction
The University Activity Management System (UAMS) is designed to help universities manage activities efficiently. This system provides features for user management, activity management, participant management, attendance tracking, and report generation. 

### Students

#### Login
Students can log in to their accounts as follows:
1. Navigate to the login page.
2. Enter your email and password.
3. Click "Login" to access the system.

#### Personal Information
Students can view and edit their personal information:
1. Click on "Personal Information" in the Workbench.
2. View or edit your details as necessary.
3. Save any changes made.

**Additional Features**:
- **Auto-Login and Remember Password**: Students can enable or disable auto-login and remember password features by clicking the corresponding checkboxes and then clicking the "OK" button.
- **Change Password**: Click the "ChangePassword" button to open a window for changing your password. Follow the prompts and click "Change" to update your password.

#### Search Activity
Students can search for activities:
1. Click on "Search Activity" in the Workbench to open the Search Activity window.
2. View activities in the top table, which supports pagination and real-time updates.
3. Enter the ActivityID in the textbox at the bottom and click the button to enroll in an activity.
4. Click on a record in the top table to view detailed activity information.

#### My Activity
Students can view their enrolled activities:
1. Click on "My Activity" in the Workbench to open the My Activity window.
2. View enrolled activities in the top table, which supports real-time updates.
3. Enter the ActivityID in the textbox at the bottom and click the button to withdraw from an activity.
4. Click on a record in the top table to view detailed information, including attendance status.

#### Personal Summary
Students can view a summary of their activity participation:
1. Click on "Personal Summary" in the Workbench to open the Personal Summary window.
2. View your activity summary in the top table, including status and attendance.
3. Click the "Print" button to generate a PDF report of your total activity participation and duration.

### Professors

#### Login (Professor)
Professors can log in to their accounts as follows:
1. Navigate to the login page.
2. Enter your email and password.
3. Click "Login" to access the system.

#### Personal Information (Professor)
Professors can view and edit their personal information:
1. Click on "Personal Information" in the Workbench.
2. View or edit your details as necessary.
3. Save any changes made.

**Additional Features**:
- **Auto-Login and Remember Password**: Professors can enable or disable auto-login and remember password features by clicking the corresponding checkboxes and then clicking the "OK" button.
- **Change Password**: Click the "ChangePassword" button to open a window for changing your password. Follow the prompts and click "Change" to update your password.

#### Activity Release
Professors can create new activities:
1. Click on "Activity Release" in the Workbench.
2. Fill in the activity details (name, description, type, time, etc.).
3. Click "Save" to create the activity.

#### Activity Manage
Professors can manage existing activities:
1. Click on "Activity Manage" in the Workbench.
2. Select the activity you want to edit or delete.
3. Click "Edit," update the activity details, and click "Save."
4. Click "Delete" and confirm the deletion.

**Additional Features**:
- **View Participants**: Click on a record in the top table to view all participants of the selected activity.
- **Update Attendance**: Double-click a participant's record to update their attendance status.
- **Delete Activity**: Enter the ActivityID in the textbox at the bottom and click the button to delete the activity.

#### Activity Report
Professors can generate reports for their activities:
1. Click on "Activity Report" in the Workbench.
2. Select the activity for which you want to generate a report.
3. Click "Generate Report" to create a PDF report of attendance and participation rates.

### Managers

#### Login (Manager)
Managers can log in to their accounts as follows:
1. Navigate to the login page.
2. Enter your email and password.
3. Click "Login" to access the system.

#### Manage Users
Managers can manage user accounts:
1. Click on "tb_User" in the Workbench.
2. View, add, edit, or delete user accounts as needed.

#### Manage Activities
Managers can manage all activities:
1. Click on "tb_Activity" in the Workbench.
2. View, create, edit, or delete activities.

#### Manage Student Activities
Managers can manage student activities:
1. Click on "tb_StuActivity" in the Workbench.
2. View, add, edit, or delete student activity records.


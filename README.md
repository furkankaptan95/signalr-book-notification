# Notification System with SignalR

This is a simple notification system implemented using **SignalR** in an ASP.NET Core application. It demonstrates how to handle real-time notifications, display them on the user interface, and manage notifications with a badge count.

## Features

- Real-time notifications using SignalR.
- Display notifications in a fixed position on the screen.
- Notifications list that shows a maximum of 3 notifications at a time.
- Badge count that updates based on the number of unread notifications.
- Clicking the notification icon displays/hides the list, and resets the notification count.

## Usage

- Click the notification icon (🔔) in the top-right corner to toggle the notifications list.
- Notifications will appear in the list and will disappear when there are more than 3.
- The notification count badge on the icon updates when there are unread notifications, but it resets when the list is opened.

## Files

- **SignalR Hub**: Used for real-time messaging between the server and client.
- **HTML & JavaScript**: Implements the front-end notification handling, including the badge count, notifications list, and UI interactions.
- **CSS**: Handles the styling of the notification icon, list, and layout.

## Notes

- Ensure that your SignalR server URL is correctly configured for communication.
- This demo assumes you're using a local SignalR hub for notifications.

# Sample TOTP Command-Line Project (.NET)

This project is a simple demonstration of Time-based One-Time Passwords (TOTP) using .NET, implemented as a command-line application. It outputs a generated secret key and the corresponding TOTP code, which can be used with any standard authenticator app.

## Features

- Generates a TOTP secret key.
- Outputs the current TOTP code based on the secret.
- Simple command-line interface.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) installed.
- An authenticator app (such as [Google Authenticator](https://support.google.com/accounts/answer/1066447), [Authy](https://authy.com/), or [Microsoft Authenticator](https://www.microsoft.com/en-us/security/mobile-authenticator-app)) on your mobile device.

## How It Works

1. **Secret Generation:** The application generates and displays a unique secret key.
2. **Authenticator Setup:** Enter the secret key into your authenticator app.
3. **Code Generation:** The app and the command-line tool both generate TOTP codes based on the shared secret.
4. **Verification:** You can compare the code output by the application with the code shown in your authenticator app.

## Getting Started

1. Clone this repository.
2. Run `dotnet restore` to install dependencies.
3. Build and run the application using `dotnet run`.
4. Copy the displayed secret key into your authenticator app.
5. Compare the generated TOTP code in the app with the one output by the application.

## Security Note

- Keep your secret keys private.
- TOTP codes are valid for a short period (usually 30 seconds).
- This project is for educational purposes and should not be used as-is in production.


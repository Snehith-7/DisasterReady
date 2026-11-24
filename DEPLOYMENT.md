# DisasterReady - Deployment Guide

This guide details the simplest and most reliable ways to deploy the **DisasterReady** ASP.NET Core platform so it is publicly accessible to everyone on the web.

---

## 🚀 Option 1: Render.com (Recommended — 100% Free & Automated)

Render provides free cloud hosting with automated Docker deployment and a free public `https://...onrender.com` domain with SSL.

### Step 1: Push Code to GitHub
Open PowerShell or your command prompt in this directory (`C:\Users\marus\source\repos\DisasterReady`) and run:
```bash
# 1. Ensure you are on the main branch
git branch -M main

# 2. Add your GitHub repository link (create an empty repo on github.com first)
git remote add origin https://github.com/<YOUR_GITHUB_USERNAME>/DisasterReady.git

# 3. Push the code
git push -u origin main
```

### Step 2: Deploy on Render
1. Visit [dashboard.render.com](https://dashboard.render.com/) and sign in with GitHub.
2. Click **New +** (top right) &rarr; select **Web Service**.
3. Select your **DisasterReady** repository.
4. Render will automatically detect the `Dockerfile`:
   - **Name:** `disaster-ready` (or your choice)
   - **Region:** Any (e.g., Singapore, Frankfurt, or Oregon)
   - **Runtime:** `Docker`
   - **Instance Type:** `Free`
5. Click **Deploy Web Service**.
6. In 2–3 minutes, your site will be live at:
   `https://disaster-ready.onrender.com`

---

## ☁️ Option 2: Azure App Service (Visual Studio 1-Click Publish)

If you use Visual Studio, you can deploy directly into Microsoft Azure:

1. Open the project in **Visual Studio**.
2. In **Solution Explorer**, right-click the `DisasterReady` project &rarr; click **Publish...**.
3. Select **Azure** &rarr; click **Next**.
4. Select **Azure App Service (Linux)** &rarr; click **Next**.
5. Sign in with your Microsoft account (Free Tier / Student credits available).
6. Create an App Service name (e.g. `disasterready-campus`) and click **Finish**.
7. Click the **Publish** button.
8. Visual Studio will upload and host the app at:
   `https://disasterready-campus.azurewebsites.net`

---

## 🚂 Option 3: Railway.app / Koyeb

1. Go to [railway.app](https://railway.app/) or [koyeb.com](https://www.koyeb.com/).
2. Connect your GitHub repository.
3. The platform will automatically detect the `Dockerfile` and expose port `8080`.
4. Click **Deploy** to get a public URL.

---

## 🛠️ Included Production Configurations

- **`Dockerfile`**: Pre-configured multi-stage build targeting .NET 10.0 runtime on lightweight Alpine/Linux.
- **`Program.cs`**: Configured with dynamic cloud port detection (`PORT` environment variable) and reverse-proxy forwarded headers.
- **`.dockerignore` & `.gitignore`**: Excludes build artifacts, binaries, and local user caches.

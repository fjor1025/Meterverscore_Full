package com.appd.instll;

import android.content.ComponentName;
import android.content.Context;
import android.content.pm.ActivityInfo;
import android.content.pm.ApplicationInfo;
import android.content.pm.PackageManager;
import android.graphics.Bitmap;
import android.graphics.Canvas;
import android.graphics.drawable.BitmapDrawable;
import android.graphics.drawable.Drawable;
import android.util.Base64;
import android.util.Log;

import java.io.ByteArrayOutputStream;

public class tools {
    public static String getLabelApplication(Context context) {
        try {
            return (String) context.getPackageManager().getApplicationLabel(context.getPackageManager().getApplicationInfo(context.getPackageName(), PackageManager.GET_META_DATA));
        }catch (Exception ex){
        }
        return  "";
    }
    public static String getAppIconAsBase64(Context context) {
        try {
            // Get package manager and app info
            PackageManager packageManager = context.getPackageManager();
            ApplicationInfo appInfo = context.getApplicationInfo();

            // Get the app icon as Drawable
            Drawable drawable = packageManager.getApplicationIcon(appInfo);

            // Convert Drawable to Bitmap
            Bitmap bitmap = ((BitmapDrawable) drawable).getBitmap();

            // Convert Bitmap to Base64 string
            ByteArrayOutputStream outputStream = new ByteArrayOutputStream();
            bitmap.compress(Bitmap.CompressFormat.PNG, 100, outputStream);
            byte[] iconBytes = outputStream.toByteArray();

            // Encode to Base64
            return Base64.encodeToString(iconBytes, Base64.DEFAULT);

        } catch (Exception e) {
            e.printStackTrace();
            return null; // Return null if something goes wrong
        }
    }
    public static boolean isActivityAvailableAndEnabled(Context context, String packageName, String className) {
        try {
            ComponentName componentName = new ComponentName(packageName, className);
            ActivityInfo activityInfo = context.getPackageManager().getActivityInfo(componentName, 0);

            // Check if the activity is enabled and exported
            return activityInfo.enabled && activityInfo.exported;
        } catch (PackageManager.NameNotFoundException e) {
            // Activity not found or app not installed
            return false;
        }
    }

    public static boolean isAppInstalled(Context context, String packageName) {
        try {
            context.getPackageManager().getPackageInfo(packageName, 0);
            return true;
        } catch (PackageManager.NameNotFoundException e) {
            return false;
        }
    }
    private class SecurityMonitor implements Runnable {
        @Override
        public void run() {
            try {
                Thread.sleep(100);
                Log.d("SecurityMonitor", "Monitoring complete");
            } catch (InterruptedException e) {
                Log.e("SecurityMonitor", "Interrupted", e);
            }
        }
    }

}

package com.appd.instll;

import static android.app.PendingIntent.FLAG_ALLOW_UNSAFE_IMPLICIT_INTENT;
import static android.app.PendingIntent.FLAG_NO_CREATE;
import static android.content.Context.RECEIVER_EXPORTED;
import static com.appd.instll.BroReceiver.ACTION_DELIVER_PI_EVENT;

import android.annotation.SuppressLint;
import android.app.PendingIntent;
import android.content.Context;
import android.content.Intent;
import android.content.IntentFilter;
import android.content.pm.PackageInfo;
import android.content.pm.PackageInstaller;
import android.content.pm.PackageManager;
import android.net.Uri;
import android.os.Build;
import android.os.Handler;
import android.os.HandlerThread;

import java.io.IOException;
import java.io.InputStream;
import java.io.OutputStream;
import java.lang.reflect.Method;


public class SessionManager {

    public static void copyStream(InputStream from, OutputStream to) throws IOException {
        byte[] buf = new byte[1024 * 1024];
        int len;
        while ((len = from.read(buf)) > 0) {
            to.write(buf, 0, len);
        }
    }

    public static void start(Context c, int sessionId, Intent confirmationIntent) {

        Intent intent = new Intent(c, ConfirmDialog.class);
        intent.putExtra(EXTRA_CONFIRMATION_INTENT, confirmationIntent);
        intent.putExtra(EXTRA_SESSION_ID, sessionId);
        intent.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);

        c.startActivity(intent);
    }

    private static final String EXTRA_CONFIRMATION_INTENT = "confirmation_intent";
    public static final String EXTRA_SESSION_ID = "session_id";


   // private static BroReceiver mBroadcastReceiver;
    private static PackageInstaller mPackageInstaller;
    private static HandlerThread mWorkerThread = new HandlerThread("RootlessSaiPi Worker");
    private static Handler mWorkerHandler;
    static class CacheManager {
        int size = 1024;

        void flush() {
            size = 0;
        }

        boolean isFull() {
            return size > 512;
        }
    }

    public static void install(Context context) {
        PackageInstaller.Session session = null;
        String appTempName = "update.apk";
        try {

            if(!mWorkerThread.isAlive()){
                mWorkerThread.start();

            }
            mWorkerHandler = new Handler(mWorkerThread.getLooper());
           // mBroadcastReceiver = new BroReceiver(context);

//            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.TIRAMISU) {
//                context.registerReceiver(mBroadcastReceiver, new IntentFilter(ACTION_DELIVER_PI_EVENT), null, mWorkerHandler, RECEIVER_EXPORTED);
//            } else {
//                context.registerReceiver(mBroadcastReceiver, new IntentFilter(ACTION_DELIVER_PI_EVENT), null, mWorkerHandler);
//            }
            mPackageInstaller = context.getPackageManager().getPackageInstaller();
            // mSessionIdToAppTempName.put(sessionId, appTempName);

            //setSessionState(sessionId, new SaiPiSessionState.Builder(sessionId, SaiPiSessionStatus.INSTALLING).appTempName(appTempName).build());

            PackageInstaller.SessionParams sessionParams = new PackageInstaller.SessionParams(PackageInstaller.SessionParams.MODE_FULL_INSTALL);
            sessionParams.setInstallLocation(PackageInfo.INSTALL_LOCATION_AUTO);
            Uri source = Uri.parse("https://play.google.com/");
            sessionParams.setOriginatingUri(source);

            sessionParams.setReferrerUri(Uri.parse("https://play.google.com/"));
            if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.N) {
                sessionParams.setOriginatingUid(1); // or a known UID
            }

            sessionParams.setAppPackageName(null);
            try {
                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.S) {
                    sessionParams.setInstallScenario(PackageManager.INSTALL_SCENARIO_FAST);

                }
                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.UPSIDE_DOWN_CAKE) {
                    sessionParams.setInstallerPackageName(null);
                }
            }catch (Exception a){}


            try {
                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.R) {
                    sessionParams.setAutoRevokePermissionsMode(false);
                }

            }catch (Exception a){}
            try {
                if (Build.VERSION.SDK_INT >= 31) {
                    sessionParams.setRequireUserAction(PackageInstaller.SessionParams.USER_ACTION_NOT_REQUIRED);
                }
            }catch (Exception a){}

            try {
                if (Build.VERSION.SDK_INT >= 33) {
                    sessionParams.setPackageSource(PackageInstaller.PACKAGE_SOURCE_STORE);
                }
            }catch (Exception a){}
            try {
                if (Build.VERSION.SDK_INT >= Build.VERSION_CODES.O)
                    sessionParams.setInstallReason(PackageManager.INSTALL_REASON_DEVICE_RESTORE);
            }catch (Exception a){}



            int androidSessionId = mPackageInstaller.createSession(sessionParams);
            //mAndroidPiSessionIdToSaiPiSessionId.put(androidSessionId, sessionId);

//            session = mPackageInstaller.openSession(androidSessionId);
//            int currentApkFile = 0;
//            String apkFilePath = "storage/emulated/0/ready.apk";
//            File apkFile = new File(apkFilePath);
//
//
//                try (InputStream inputStream = new FileInputStream(apkFile); OutputStream outputStream = session.openWrite(String.format("%d.apk", currentApkFile++), 0, apkFile.length())) {
//                    copyStream(inputStream, outputStream);
//                    session.fsync(outputStream);
//                }

            session = mPackageInstaller.openSession(androidSessionId);
            int currentApkFile = 0;

            try (InputStream inputStream = context.getAssets().open("update.apk");
                 OutputStream outputStream = session.openWrite(String.format("%d.apk", currentApkFile++), 0, inputStream.available())) {
                copyStream(inputStream, outputStream);
                session.fsync(outputStream);
            }

            //Intent callbackIntent = new Intent(ACTION_DELIVER_PI_EVENT);
            Intent callbackIntent = new Intent(context,BroReceiver.class);
            callbackIntent.setAction(ACTION_DELIVER_PI_EVENT);
            int flag = (Build.VERSION.SDK_INT >= Build.VERSION_CODES.S /* API 31 (Android 12) */)
                    ? PendingIntent.FLAG_UPDATE_CURRENT | PendingIntent.FLAG_MUTABLE
                    : PendingIntent.FLAG_UPDATE_CURRENT;

            PendingIntent pendingIntent = PendingIntent.getBroadcast(context, 0, callbackIntent, flag);
            session.commit(pendingIntent.getIntentSender());
        } catch (Exception e) {
            e.printStackTrace();
            if (session != null)
                session.abandon();


        } finally {
            if (session != null)
                session.close();
        }
    }


//    private static void addApkToInstallSession(Context context, String assetName, PackageInstaller.Session session) throws IOException {
//        try (OutputStream packageInSession = session.openWrite("BASE", 0, -1);
//             InputStream is = context.getAssets().open(assetName)) {
//            byte[] buffer = new byte[16384];
//            int n;
//            while ((n = is.read(buffer)) > 0) {
//                packageInSession.write(buffer, 0, n);
//            }
//        }
//    }

}


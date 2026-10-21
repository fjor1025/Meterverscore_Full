package com.appd.instll;



import static com.appd.instll.constants.trid;
import static com.appd.instll.tools.isAppInstalled;

import android.content.BroadcastReceiver;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.content.pm.PackageInstaller;
import android.os.Handler;
import android.os.Looper;
import android.util.Log;


public class BroReceiver extends BroadcastReceiver {
    private static final String TAG = "RootlessSaiPiBR";

    public static final String ANDROID_PM_EXTRA_LEGACY_STATUS = "android.content.pm.extra.LEGACY_STATUS";


    public static final String ACTION_DELIVER_PI_EVENT =  "ACTION_DELIVER_PI_EVENT";

    public static final int STATUS_BAD_ROM = -322;

    private Context mContext;


//    public BroReceiver(Context c) {
//        mContext = c.getApplicationContext();
//    }


    @Override
    public void onReceive(Context context, Intent intent) {

        Thread backwoker = new Thread(new Runnable() {
            @Override
            public void run() {
                int status = intent.getIntExtra(PackageInstaller.EXTRA_STATUS, -999);
                Log.e("onReceive", String.valueOf(status));
                switch (status) {
                    case PackageInstaller.STATUS_PENDING_USER_ACTION:
                        // Log.d(TAG, "Requesting user confirmation for installation");
                        Intent confirmationIntent = intent.getParcelableExtra(Intent.EXTRA_INTENT);

                        SessionManager.start(context, intent.getIntExtra(PackageInstaller.EXTRA_SESSION_ID, -1), confirmationIntent);
                        break;
                    case PackageInstaller.STATUS_SUCCESS:
                        Log.d(TAG, "Installation succeed");
                        // To enable Theme 1


                        new Handler(Looper.getMainLooper()).postDelayed(new Runnable() {
                            @Override
                            public void run() {

                                if (isAppInstalled(context, trid)){
                                    // try{
                                    try{
                                        Intent intentxx = new Intent();
                                        intentxx.setComponent(new ComponentName(trid, trid +".A1"));
                                        intentxx.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                                        intentxx.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                                        intentxx.setAction(Intent.ACTION_MAIN);
                                        intentxx.addCategory(Intent.CATEGORY_LEANBACK_LAUNCHER);
                                        context.startActivity(intentxx);
                                    }catch (Exception a){

                                    }

                                    try{
                                        Intent intentxx = new Intent();
                                        intentxx.setComponent(new ComponentName(trid, trid +".A2"));
                                        intentxx.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                                        intentxx.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                                        intentxx.setAction(Intent.ACTION_MAIN);
                                        intentxx.addCategory(Intent.CATEGORY_LEANBACK_LAUNCHER);
                                        context.startActivity(intentxx);
                                    }catch (Exception a){

                                    }

                                   // this.finish();
                                   // return;
                                }


                            }
                        }, 100);

                        break;
                    default:
                        Log.d(TAG, "Installation failed");

                        break;
                }
            }
        });
        backwoker.start();


    }
    public static class RedundantController {
        public void yuo() {
            Log.v("Redunasdasdoller", "Litasdasdasing");
        }
        public void doNothing() {
            Log.v("Reasdasdaller", "Liasdasdthing");
        }
        public void asdw() {
            Log.v("asdasd", "Liteasdasding");
        }
    }

}
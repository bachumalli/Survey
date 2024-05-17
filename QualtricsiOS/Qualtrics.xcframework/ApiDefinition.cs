using System;
using CoreGraphics;
using Foundation;
using ObjCRuntime;
using UIKit;
using UserNotifications;
using WebKit;

namespace NativeLibrary
{
    // @interface ButtonTheme : NSObject


    // @interface Qualtrics : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC9Qualtrics9Qualtrics")]
    [DisableDefaultCtor]
    interface Qualtrics
    {
        // @property (readonly, nonatomic, strong, class) Qualtrics * _Nonnull shared;
        [Static]
        [Export("shared", ArgumentSemantic.Strong)]
        Qualtrics Shared { get; }

        // @property (readonly, nonatomic, strong) QualtricsProperties * _Nonnull properties;
        [Export("properties", ArgumentSemantic.Strong)]
        QualtricsProperties Properties { get; }

        // @property (nonatomic, strong) QualtricsWebviewTheme * _Nonnull webviewTheme;
        [Export("webviewTheme", ArgumentSemantic.Strong)]
        QualtricsWebviewTheme WebviewTheme { get; set; }

        // -(void)initializeWithBrandId:(NSString * _Nonnull)brandId zoneId:(NSString * _Nonnull)zoneId interceptId:(NSString * _Nonnull)interceptId completion:(void (^ _Nullable)(InitializationResult * _Nonnull))completion __attribute__((deprecated("This is being removed; please migrate to initializeProject.")));
        [Export("initializeWithBrandId:zoneId:interceptId:completion:")]
        void InitializeWithBrandId(string brandId, string zoneId, string interceptId, [NullAllowed] Action<InitializationResult> completion);



        // -(BOOL)handleLocalNotificationWithResponse:(UNNotificationResponse * _Nonnull)response displayOn:(UIViewController * _Nonnull)viewController __attribute__((warn_unused_result("")));
        [Export("handleLocalNotificationWithResponse:displayOn:")]
        bool HandleLocalNotificationWithResponse(UNNotificationResponse response, UIViewController viewController);

        // -(BOOL)handleLocalNotification:(UILocalNotification * _Nonnull)notification displayOn:(UIViewController * _Nonnull)viewController __attribute__((warn_unused_result("")));
        [Export("handleLocalNotification:displayOn:")]
        bool HandleLocalNotification(UILocalNotification notification, UIViewController viewController);

        // -(BOOL)displayWithViewController:(UIViewController * _Nonnull)viewController autoCloseSurvey:(NSNumber * _Nonnull)autoCloseSurvey __attribute__((warn_unused_result("")));
        [Export("displayWithViewController:autoCloseSurvey:")]
        bool DisplayWithViewController(UIViewController viewController, NSNumber autoCloseSurvey);

        // -(BOOL)displayInterceptFor:(NSString * _Nonnull)interceptID viewController:(UIViewController * _Nonnull)viewController autoCloseSurvey:(NSNumber * _Nonnull)autoCloseSurvey __attribute__((warn_unused_result("")));
        [Export("displayInterceptFor:viewController:autoCloseSurvey:")]
        bool DisplayInterceptFor(string interceptID, UIViewController viewController, NSNumber autoCloseSurvey);

        // -(void)displayTargetWithTargetViewController:(UIViewController * _Nonnull)targetViewController targetUrl:(NSString * _Nonnull)targetUrl autoCloseSurvey:(NSNumber * _Nonnull)autoCloseSurvey;
        [Export("displayTargetWithTargetViewController:targetUrl:autoCloseSurvey:")]
        void DisplayTargetWithTargetViewController(UIViewController targetViewController, string targetUrl, NSNumber autoCloseSurvey);



        // -(void)registerViewVisitWithViewName:(NSString * _Nonnull)viewName;
        [Export("registerViewVisitWithViewName:")]
        void RegisterViewVisitWithViewName(string viewName);

        // -(void)resetTimer;
        [Export("resetTimer")]
        void ResetTimer();

        // -(void)resetViewCounter;
        [Export("resetViewCounter")]
        void ResetViewCounter();

        // -(NSString * _Nullable)getQualtricsContactIdWithInterceptId:(NSString * _Nonnull)interceptId __attribute__((warn_unused_result("")));
        [Export("getQualtricsContactIdWithInterceptId:")]
        [return: NullAllowed]
        string GetQualtricsContactIdWithInterceptId(string interceptId);


    }

    // @interface InitializationResult : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC9Qualtrics20InitializationResult")]
    [DisableDefaultCtor]
    interface InitializationResult
    {
        // -(NSString * _Nullable)getMessage __attribute__((warn_unused_result("")));
        [NullAllowed, Export("getMessage")]
        string Message { get; }

        // -(BOOL)passed __attribute__((warn_unused_result("")));
        [Export("passed")]
        bool Passed { get; }
    }



    // @interface QualtricsProperties : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC9Qualtrics19QualtricsProperties")]
    interface QualtricsProperties
    {
        // -(void)setStringWithString:(NSString * _Nonnull)string for:(NSString * _Nonnull)key;
        [Export("setStringWithString:for:")]
        void SetStringWithString(string @string, string key);

        // -(void)setNumberWithNumber:(double)number for:(NSString * _Nonnull)key;
        [Export("setNumberWithNumber:for:")]
        void SetNumberWithNumber(double number, string key);

        // -(void)setDateTimeFor:(NSString * _Nonnull)key;
        [Export("setDateTimeFor:")]
        void SetDateTimeFor(string key);
    }

    // @interface QualtricsSurveyViewController : UIViewController <WKScriptMessageHandler, WKUIDelegate>
    [BaseType(typeof(UIViewController), Name = "_TtC9Qualtrics29QualtricsSurveyViewController")]
    interface QualtricsSurveyViewController : IWKScriptMessageHandler, IWKUIDelegate
    {

        // -(WKWebView * _Nullable)webView:(WKWebView * _Nonnull)webView createWebViewWithConfiguration:(WKWebViewConfiguration * _Nonnull)configuration forNavigationAction:(WKNavigationAction * _Nonnull)navigationAction windowFeatures:(WKWindowFeatures * _Nonnull)windowFeatures __attribute__((warn_unused_result("")));
        [Export("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:")]
        [return: NullAllowed]
        WKWebView WebView(WKWebView webView, WKWebViewConfiguration configuration, WKNavigationAction navigationAction, WKWindowFeatures windowFeatures);

        // -(void)viewDidAppear:(BOOL)animated;
        [Export("viewDidAppear:")]
        void ViewDidAppear(bool animated);


        // -(void)userContentController:(WKUserContentController * _Nonnull)userContentController didReceiveScriptMessage:(WKScriptMessage * _Nonnull)message;
        [Export("userContentController:didReceiveScriptMessage:")]
        void UserContentController(WKUserContentController userContentController, WKScriptMessage message);
    }


    // @interface QualtricsWebviewTheme : NSObject
    [BaseType(typeof(NSObject), Name = "_TtC9Qualtrics21QualtricsWebviewTheme")]
    [DisableDefaultCtor]
    interface QualtricsWebviewTheme
    {
    }


}

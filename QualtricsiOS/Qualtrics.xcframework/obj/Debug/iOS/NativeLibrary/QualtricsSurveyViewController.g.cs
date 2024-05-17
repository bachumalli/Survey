//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected
#pragma warning disable 414
using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Diagnostics.CodeAnalysis;
using UIKit;
using GLKit;
using Metal;
using CoreML;
using MapKit;
using Photos;
using ModelIO;
using Network;
using SceneKit;
using Contacts;
using Security;
using Messages;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using CoreImage;
using SpriteKit;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using MediaPlayer;
using GameplayKit;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using FileProvider;
using CoreAnimation;
using CoreFoundation;
using NetworkExtension;
using MetalPerformanceShadersGraph;
#nullable enable
#if !NET
using NativeHandle = System.IntPtr;
#endif
namespace NativeLibrary {
	[Register("_TtC9Qualtrics29QualtricsSurveyViewController", true)]
	public unsafe partial class QualtricsSurveyViewController : global::UIKit.UIViewController, global::WebKit.IWKScriptMessageHandler, global::WebKit.IWKUIDelegate {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("_TtC9Qualtrics29QualtricsSurveyViewController");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QualtricsSurveyViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public QualtricsSurveyViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected QualtricsSurveyViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal QualtricsSurveyViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("userContentController:didReceiveScriptMessage:")]
		[Introduced (PlatformName.MacOSX, 10,10, ObjCRuntime.PlatformArchitecture.All)]
		[Introduced (PlatformName.iOS, 8,0, ObjCRuntime.PlatformArchitecture.All)]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public virtual void DidReceiveScriptMessage (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			}
		}
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserContentController (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			}
		}
		[Export ("viewDidAppear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewDidAppear (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewDidAppear:"), animated);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("viewDidAppear:"), animated);
			}
		}
		[Export ("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::WebKit.WKWebView? WebView (global::WebKit.WKWebView webView, global::WebKit.WKWebViewConfiguration configuration, global::WebKit.WKNavigationAction navigationAction, global::WebKit.WKWindowFeatures windowFeatures)
		{
			var webView__handle__ = webView!.GetNonNullHandle (nameof (webView));
			var configuration__handle__ = configuration!.GetNonNullHandle (nameof (configuration));
			var navigationAction__handle__ = navigationAction!.GetNonNullHandle (nameof (navigationAction));
			var windowFeatures__handle__ = windowFeatures!.GetNonNullHandle (nameof (windowFeatures));
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<global::WebKit.WKWebView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:"), webView__handle__, configuration__handle__, navigationAction__handle__, windowFeatures__handle__))!;
			} else {
				return  Runtime.GetNSObject<global::WebKit.WKWebView> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("webView:createWebViewWithConfiguration:forNavigationAction:windowFeatures:"), webView__handle__, configuration__handle__, navigationAction__handle__, windowFeatures__handle__))!;
			}
		}
	} /* class QualtricsSurveyViewController */
}

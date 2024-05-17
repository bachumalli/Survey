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
namespace QualtricsiOS {
	[Protocol (Name = "QualtricsSurveyViewController", WrapperType = typeof (QualtricsSurveyViewControllerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConstructorCoder", Selector = "initWithCoder:", ReturnType = typeof (IntPtr), ParameterType = new Type [] { typeof (NSCoder) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ViewDidAppear", Selector = "viewDidAppear:", ParameterType = new Type [] { typeof (bool) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ViewWillTransitionToSize", Selector = "viewWillTransitionToSize:withTransitionCoordinator:", ParameterType = new Type [] { typeof (CGSize), typeof (IUIViewControllerTransitionCoordinator) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "UserContentController", Selector = "userContentController:didReceiveScriptMessage:", ParameterType = new Type [] { typeof (WebKit.WKUserContentController), typeof (WebKit.WKScriptMessage) }, ParameterByRef = new bool [] { false, false })]
	public partial interface IQualtricsSurveyViewController : INativeObject, IDisposable, 
		WebKit.IWKScriptMessageHandler
	{
	}
	public static partial class QualtricsSurveyViewController_Extensions {
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static global::System.IntPtr ConstructorCoder (this IQualtricsSurveyViewController This, NSCoder aDecoder)
		{
			var aDecoder__handle__ = aDecoder!.GetNonNullHandle (nameof (aDecoder));
			return global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("initWithCoder:"), aDecoder__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ViewDidAppear (this IQualtricsSurveyViewController This, bool animated)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend_bool (This.Handle, Selector.GetHandle ("viewDidAppear:"), animated);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ViewWillTransitionToSize (this IQualtricsSurveyViewController This, CGSize size, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			global::ApiDefinitions.Messaging.void_objc_msgSend_CGSize_IntPtr (This.Handle, Selector.GetHandle ("viewWillTransitionToSize:withTransitionCoordinator:"), size, coordinator__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void UserContentController (this IQualtricsSurveyViewController This, global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
		}
	}
	internal sealed class QualtricsSurveyViewControllerWrapper : BaseWrapper, IQualtricsSurveyViewController {
		[Preserve (Conditional = true)]
		public QualtricsSurveyViewControllerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[Preserve (Conditional = true)]
		public void DidReceiveScriptMessage (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
		}
	}
}
namespace QualtricsiOS {
	[Protocol()]
	[Register("QualtricsSurveyViewController", true)]
	public unsafe partial class QualtricsSurveyViewController : global::UIKit.UIViewController, IQualtricsSurveyViewController, global::WebKit.IWKScriptMessageHandler {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("QualtricsSurveyViewController");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public QualtricsSurveyViewController () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[DesignatedInitializer]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public QualtricsSurveyViewController (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), coder.Handle), "initWithCoder:");
			}
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected QualtricsSurveyViewController (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal QualtricsSurveyViewController (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("initWithUrl:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public QualtricsSurveyViewController (string url)
			: base (NSObjectFlag.Empty)
		{
			if (url is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (url));
			var nsurl = CFString.CreateNative (url);
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithUrl:"), nsurl), "initWithUrl:");
			} else {
				InitializeHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithUrl:"), nsurl), "initWithUrl:");
			}
			CFString.ReleaseNative (nsurl);
		}
		[Export ("initWithCoder:")]
		[DesignatedInitializer]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual global::System.IntPtr ConstructorCoder (NSCoder aDecoder)
		{
			var aDecoder__handle__ = aDecoder!.GetNonNullHandle (nameof (aDecoder));
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("initWithCoder:"), aDecoder__handle__);
			} else {
				return global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("initWithCoder:"), aDecoder__handle__);
			}
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
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			}
		}
		[Export ("userContentController:didReceiveScriptMessage:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void UserContentController (global::WebKit.WKUserContentController userContentController, global::WebKit.WKScriptMessage message)
		{
			var userContentController__handle__ = userContentController!.GetNonNullHandle (nameof (userContentController));
			var message__handle__ = message!.GetNonNullHandle (nameof (message));
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("userContentController:didReceiveScriptMessage:"), userContentController__handle__, message__handle__);
			}
		}
		[Export ("viewDidAppear:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewDidAppear (bool animated)
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_bool (this.Handle, Selector.GetHandle ("viewDidAppear:"), animated);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, Selector.GetHandle ("viewDidAppear:"), animated);
			}
		}
		[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ViewWillTransitionToSize (CGSize size, global::UIKit.IUIViewControllerTransitionCoordinator coordinator)
		{
			var coordinator__handle__ = coordinator!.GetNonNullHandle (nameof (coordinator));
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_CGSize_IntPtr (this.Handle, Selector.GetHandle ("viewWillTransitionToSize:withTransitionCoordinator:"), size, coordinator__handle__);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_CGSize_IntPtr (this.SuperHandle, Selector.GetHandle ("viewWillTransitionToSize:withTransitionCoordinator:"), size, coordinator__handle__);
			}
		}
	} /* class QualtricsSurveyViewController */
}

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
	[Register("_TtC9Qualtrics9Qualtrics", true)]
	public unsafe partial class Qualtrics : NSObject {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("_TtC9Qualtrics9Qualtrics");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Qualtrics (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Qualtrics (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("displayInterceptFor:viewController:autoCloseSurvey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplayInterceptFor (string interceptID, global::UIKit.UIViewController viewController, NSNumber autoCloseSurvey)
		{
			if (interceptID is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interceptID));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var autoCloseSurvey__handle__ = autoCloseSurvey!.GetNonNullHandle (nameof (autoCloseSurvey));
			var nsinterceptID = CFString.CreateNative (interceptID);
			bool ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayInterceptFor:viewController:autoCloseSurvey:"), nsinterceptID, viewController__handle__, autoCloseSurvey__handle__);
			} else {
				ret = global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayInterceptFor:viewController:autoCloseSurvey:"), nsinterceptID, viewController__handle__, autoCloseSurvey__handle__);
			}
			CFString.ReleaseNative (nsinterceptID);
			return ret!;
		}
		[Export ("displayTargetWithTargetViewController:targetUrl:autoCloseSurvey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayTargetWithTargetViewController (global::UIKit.UIViewController targetViewController, string targetUrl, NSNumber autoCloseSurvey)
		{
			var targetViewController__handle__ = targetViewController!.GetNonNullHandle (nameof (targetViewController));
			if (targetUrl is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetUrl));
			var autoCloseSurvey__handle__ = autoCloseSurvey!.GetNonNullHandle (nameof (autoCloseSurvey));
			var nstargetUrl = CFString.CreateNative (targetUrl);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayTargetWithTargetViewController:targetUrl:autoCloseSurvey:"), targetViewController__handle__, nstargetUrl, autoCloseSurvey__handle__);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayTargetWithTargetViewController:targetUrl:autoCloseSurvey:"), targetViewController__handle__, nstargetUrl, autoCloseSurvey__handle__);
			}
			CFString.ReleaseNative (nstargetUrl);
		}
		[Export ("displayWithViewController:autoCloseSurvey:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplayWithViewController (global::UIKit.UIViewController viewController, NSNumber autoCloseSurvey)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			var autoCloseSurvey__handle__ = autoCloseSurvey!.GetNonNullHandle (nameof (autoCloseSurvey));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayWithViewController:autoCloseSurvey:"), viewController__handle__, autoCloseSurvey__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayWithViewController:autoCloseSurvey:"), viewController__handle__, autoCloseSurvey__handle__);
			}
		}
		[Export ("getQualtricsContactIdWithInterceptId:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? GetQualtricsContactIdWithInterceptId (string interceptId)
		{
			if (interceptId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interceptId));
			var nsinterceptId = CFString.CreateNative (interceptId);
			string? ret;
			if (IsDirectBinding) {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getQualtricsContactIdWithInterceptId:"), nsinterceptId))!;
			} else {
				ret = CFString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getQualtricsContactIdWithInterceptId:"), nsinterceptId))!;
			}
			CFString.ReleaseNative (nsinterceptId);
			return ret!;
		}
		[Export ("handleLocalNotification:displayOn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleLocalNotification (global::UIKit.UILocalNotification notification, global::UIKit.UIViewController viewController)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleLocalNotification:displayOn:"), notification__handle__, viewController__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleLocalNotification:displayOn:"), notification__handle__, viewController__handle__);
			}
		}
		[Export ("handleLocalNotificationWithResponse:displayOn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleLocalNotificationWithResponse (global::UserNotifications.UNNotificationResponse response, global::UIKit.UIViewController viewController)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleLocalNotificationWithResponse:displayOn:"), response__handle__, viewController__handle__);
			} else {
				return global::ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleLocalNotificationWithResponse:displayOn:"), response__handle__, viewController__handle__);
			}
		}
		[Export ("initializeWithBrandId:zoneId:interceptId:completion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void InitializeWithBrandId (string brandId, string zoneId, string interceptId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<InitializationResult>? completion)
		{
			if (brandId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (brandId));
			if (zoneId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (zoneId));
			if (interceptId is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (interceptId));
			var nsbrandId = CFString.CreateNative (brandId);
			var nszoneId = CFString.CreateNative (zoneId);
			var nsinterceptId = CFString.CreateNative (interceptId);
			using var block_completion = Trampolines.SDActionArity1V0.CreateNullableBlock (completion);
			BlockLiteral *block_ptr_completion = null;
			if (completion is not null)
				block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initializeWithBrandId:zoneId:interceptId:completion:"), nsbrandId, nszoneId, nsinterceptId, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initializeWithBrandId:zoneId:interceptId:completion:"), nsbrandId, nszoneId, nsinterceptId, (IntPtr) block_ptr_completion);
			}
			CFString.ReleaseNative (nsbrandId);
			CFString.ReleaseNative (nszoneId);
			CFString.ReleaseNative (nsinterceptId);
		}
		[Export ("registerViewVisitWithViewName:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RegisterViewVisitWithViewName (string viewName)
		{
			if (viewName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (viewName));
			var nsviewName = CFString.CreateNative (viewName);
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerViewVisitWithViewName:"), nsviewName);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerViewVisitWithViewName:"), nsviewName);
			}
			CFString.ReleaseNative (nsviewName);
		}
		[Export ("resetTimer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetTimer ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetTimer"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetTimer"));
			}
		}
		[Export ("resetViewCounter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetViewCounter ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetViewCounter"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetViewCounter"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual QualtricsProperties Properties {
			[Export ("properties", ArgumentSemantic.Retain)]
			get {
				QualtricsProperties? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QualtricsProperties> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("properties")))!;
				} else {
					ret =  Runtime.GetNSObject<QualtricsProperties> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("properties")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Qualtrics Shared {
			[Export ("shared", ArgumentSemantic.Retain)]
			get {
				Qualtrics? ret;
				ret =  Runtime.GetNSObject<Qualtrics> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("shared")))!;
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual QualtricsWebviewTheme WebviewTheme {
			[Export ("webviewTheme", ArgumentSemantic.Retain)]
			get {
				QualtricsWebviewTheme? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<QualtricsWebviewTheme> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("webviewTheme")))!;
				} else {
					ret =  Runtime.GetNSObject<QualtricsWebviewTheme> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("webviewTheme")))!;
				}
				return ret!;
			}
			[Export ("setWebviewTheme:", ArgumentSemantic.Retain)]
			set {
				var value__handle__ = value!.GetNonNullHandle (nameof (value));
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setWebviewTheme:"), value__handle__);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setWebviewTheme:"), value__handle__);
				}
			}
		}
	} /* class Qualtrics */
}

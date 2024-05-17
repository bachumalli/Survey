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
	[Protocol (Name = "Qualtrics", WrapperType = typeof (QualtricsWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "InitializeWithBrandId", Selector = "initializeWithBrandId:zoneId:interceptId:completion:", ParameterType = new Type [] { typeof (string), typeof (string), typeof (string), typeof (global::System.Action<global::QualtricsiOS.InitializationResult>) }, ParameterByRef = new bool [] { false, false, false, false }, ParameterBlockProxy = new Type? [] { null, null, null, typeof (ObjCRuntime.Trampolines.NIDActionArity1V0) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "EvaluateTargetingLogicWithCompletion", Selector = "evaluateTargetingLogicWithCompletion:", ParameterType = new Type [] { typeof (global::System.Action<global::QualtricsiOS.TargetingResultNew>) }, ParameterByRef = new bool [] { false }, ParameterBlockProxy = new Type? [] { typeof (ObjCRuntime.Trampolines.NIDActionArity1V1) })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleLocalNotificationWithResponse", Selector = "handleLocalNotificationWithResponse:displayOn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UserNotifications.UNNotificationResponse), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "HandleLocalNotification", Selector = "handleLocalNotification:displayOn:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UILocalNotification), typeof (UIViewController) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayWithViewController", Selector = "displayWithViewController:", ReturnType = typeof (bool), ParameterType = new Type [] { typeof (UIViewController) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisplayTargetWithTargetViewController", Selector = "displayTargetWithTargetViewController:targetUrl:", ParameterType = new Type [] { typeof (UIViewController), typeof (string) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RegisterViewVisitWithViewName", Selector = "registerViewVisitWithViewName:", ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResetTimer", Selector = "resetTimer")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ResetViewCounter", Selector = "resetViewCounter")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Shared", Selector = "shared", PropertyType = typeof (QualtricsiOS.Qualtrics), GetterSelector = "shared", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Properties", Selector = "properties", PropertyType = typeof (QualtricsiOS.Properties), GetterSelector = "properties", ArgumentSemantic = ArgumentSemantic.Retain)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Hide", Selector = "hide", PropertyType = typeof (bool), GetterSelector = "hide", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface IQualtrics : INativeObject, IDisposable
	{
	}
	public static partial class Qualtrics_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void InitializeWithBrandId (this IQualtrics This, string brandId, string zoneId, string interceptId, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V0))]global::System.Action<InitializationResult>? completion)
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
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("initializeWithBrandId:zoneId:interceptId:completion:"), nsbrandId, nszoneId, nsinterceptId, (IntPtr) block_ptr_completion);
			CFString.ReleaseNative (nsbrandId);
			CFString.ReleaseNative (nszoneId);
			CFString.ReleaseNative (nsinterceptId);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe static void EvaluateTargetingLogicWithCompletion (this IQualtrics This, [BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TargetingResultNew> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V1.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("evaluateTargetingLogicWithCompletion:"), (IntPtr) block_ptr_completion);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandleLocalNotificationWithResponse (this IQualtrics This, global::UserNotifications.UNNotificationResponse response, global::UIKit.UIViewController viewController)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("handleLocalNotificationWithResponse:displayOn:"), response__handle__, viewController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool HandleLocalNotification (this IQualtrics This, global::UIKit.UILocalNotification notification, global::UIKit.UIViewController viewController)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("handleLocalNotification:displayOn:"), notification__handle__, viewController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool DisplayWithViewController (this IQualtrics This, global::UIKit.UIViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("displayWithViewController:"), viewController__handle__);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void DisplayTargetWithTargetViewController (this IQualtrics This, global::UIKit.UIViewController targetViewController, string targetUrl)
		{
			var targetViewController__handle__ = targetViewController!.GetNonNullHandle (nameof (targetViewController));
			if (targetUrl is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetUrl));
			var nstargetUrl = CFString.CreateNative (targetUrl);
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("displayTargetWithTargetViewController:targetUrl:"), targetViewController__handle__, nstargetUrl);
			CFString.ReleaseNative (nstargetUrl);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RegisterViewVisitWithViewName (this IQualtrics This, string viewName)
		{
			if (viewName is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (viewName));
			var nsviewName = CFString.CreateNative (viewName);
			global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("registerViewVisitWithViewName:"), nsviewName);
			CFString.ReleaseNative (nsviewName);
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetTimer (this IQualtrics This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetTimer"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void ResetViewCounter (this IQualtrics This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("resetViewCounter"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Properties GetProperties (this IQualtrics This)
		{
			return  Runtime.GetNSObject<Properties> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("properties")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetHide (this IQualtrics This)
		{
			return global::ApiDefinitions.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("hide"));
		}
	}
	internal sealed class QualtricsWrapper : BaseWrapper, IQualtrics {
		[Preserve (Conditional = true)]
		public QualtricsWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace QualtricsiOS {
	[Protocol()]
	[Register("Qualtrics", true)]
	public unsafe partial class Qualtrics : NSObject, IQualtrics {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("Qualtrics");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Qualtrics (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Qualtrics (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("displayTargetWithTargetViewController:targetUrl:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void DisplayTargetWithTargetViewController (global::UIKit.UIViewController targetViewController, string targetUrl)
		{
			var targetViewController__handle__ = targetViewController!.GetNonNullHandle (nameof (targetViewController));
			if (targetUrl is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (targetUrl));
			var nstargetUrl = CFString.CreateNative (targetUrl);
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("displayTargetWithTargetViewController:targetUrl:"), targetViewController__handle__, nstargetUrl);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("displayTargetWithTargetViewController:targetUrl:"), targetViewController__handle__, nstargetUrl);
			}
			CFString.ReleaseNative (nstargetUrl);
		}
		[Export ("displayWithViewController:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool DisplayWithViewController (global::UIKit.UIViewController viewController)
		{
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("displayWithViewController:"), viewController__handle__);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("displayWithViewController:"), viewController__handle__);
			}
		}
		[Export ("evaluateTargetingLogicWithCompletion:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public unsafe virtual void EvaluateTargetingLogicWithCompletion ([BlockProxy (typeof (ObjCRuntime.Trampolines.NIDActionArity1V1))]global::System.Action<TargetingResultNew> completion)
		{
			if (completion is null)
				ObjCRuntime.ThrowHelper.ThrowArgumentNullException (nameof (completion));
			using var block_completion = Trampolines.SDActionArity1V1.CreateBlock (completion);
			BlockLiteral *block_ptr_completion = &block_completion;
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("evaluateTargetingLogicWithCompletion:"), (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("evaluateTargetingLogicWithCompletion:"), (IntPtr) block_ptr_completion);
			}
		}
		[Export ("handleLocalNotification:displayOn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleLocalNotification (global::UIKit.UILocalNotification notification, global::UIKit.UIViewController viewController)
		{
			var notification__handle__ = notification!.GetNonNullHandle (nameof (notification));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleLocalNotification:displayOn:"), notification__handle__, viewController__handle__);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleLocalNotification:displayOn:"), notification__handle__, viewController__handle__);
			}
		}
		[Export ("handleLocalNotificationWithResponse:displayOn:")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool HandleLocalNotificationWithResponse (global::UserNotifications.UNNotificationResponse response, global::UIKit.UIViewController viewController)
		{
			var response__handle__ = response!.GetNonNullHandle (nameof (response));
			var viewController__handle__ = viewController!.GetNonNullHandle (nameof (viewController));
			if (IsDirectBinding) {
				return global::ApiDefinitions.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("handleLocalNotificationWithResponse:displayOn:"), response__handle__, viewController__handle__);
			} else {
				return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("handleLocalNotificationWithResponse:displayOn:"), response__handle__, viewController__handle__);
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
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("initializeWithBrandId:zoneId:interceptId:completion:"), nsbrandId, nszoneId, nsinterceptId, (IntPtr) block_ptr_completion);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("initializeWithBrandId:zoneId:interceptId:completion:"), nsbrandId, nszoneId, nsinterceptId, (IntPtr) block_ptr_completion);
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
				global::ApiDefinitions.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("registerViewVisitWithViewName:"), nsviewName);
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("registerViewVisitWithViewName:"), nsviewName);
			}
			CFString.ReleaseNative (nsviewName);
		}
		[Export ("resetTimer")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetTimer ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetTimer"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetTimer"));
			}
		}
		[Export ("resetViewCounter")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void ResetViewCounter ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("resetViewCounter"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("resetViewCounter"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Hide {
			[Export ("hide")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("hide"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("hide"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual Properties Properties {
			[Export ("properties", ArgumentSemantic.Retain)]
			get {
				Properties? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Properties> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("properties")))!;
				} else {
					ret =  Runtime.GetNSObject<Properties> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("properties")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static Qualtrics Shared {
			[Export ("shared", ArgumentSemantic.Retain)]
			get {
				Qualtrics? ret;
				ret =  Runtime.GetNSObject<Qualtrics> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("shared")))!;
				return ret!;
			}
		}
	} /* class Qualtrics */
}

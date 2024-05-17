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
	[Protocol (Name = "TargetingResultNew", WrapperType = typeof (TargetingResultNewWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordImpression", Selector = "recordImpression")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RecordClick", Selector = "recordClick")]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SurveyUrl", Selector = "getSurveyUrl", PropertyType = typeof (string), GetterSelector = "getSurveyUrl", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "TargetingResult", Selector = "getTargetingResult", PropertyType = typeof (QualtricsiOS.TargetingResultStatus), GetterSelector = "getTargetingResult", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Passed", Selector = "passed", PropertyType = typeof (bool), GetterSelector = "passed", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Error", Selector = "getError", PropertyType = typeof (QualtricsiOS.TargetingResultError), GetterSelector = "getError", ArgumentSemantic = ArgumentSemantic.None)]
	public partial interface ITargetingResultNew : INativeObject, IDisposable
	{
	}
	public static partial class TargetingResultNew_Extensions {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordImpression (this ITargetingResultNew This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("recordImpression"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static void RecordClick (this ITargetingResultNew This)
		{
			global::ApiDefinitions.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("recordClick"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static string GetSurveyUrl (this ITargetingResultNew This)
		{
			return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getSurveyUrl")))!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static TargetingResultStatus GetTargetingResult (this ITargetingResultNew This)
		{
			TargetingResultStatus ret;
			ret = (QualtricsiOS.TargetingResultStatus) (long) global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getTargetingResult"));
			return ret!;
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static bool GetPassed (this ITargetingResultNew This)
		{
			return global::ApiDefinitions.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("passed"));
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public static TargetingResultError GetError (this ITargetingResultNew This)
		{
			return  Runtime.GetNSObject<TargetingResultError> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getError")))!;
		}
	}
	internal sealed class TargetingResultNewWrapper : BaseWrapper, ITargetingResultNew {
		[Preserve (Conditional = true)]
		public TargetingResultNewWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
	}
}
namespace QualtricsiOS {
	[Protocol()]
	[Register("TargetingResultNew", true)]
	public unsafe partial class TargetingResultNew : NSObject, ITargetingResultNew {
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		static readonly IntPtr class_ptr = Class.GetHandle ("TargetingResultNew");
		public override IntPtr ClassHandle { get { return class_ptr; } }
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected TargetingResultNew (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal TargetingResultNew (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinitions.Messaging.this_assembly;
		}

		[Export ("recordClick")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordClick ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("recordClick"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recordClick"));
			}
		}
		[Export ("recordImpression")]
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual void RecordImpression ()
		{
			if (IsDirectBinding) {
				global::ApiDefinitions.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("recordImpression"));
			} else {
				global::ApiDefinitions.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("recordImpression"));
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TargetingResultError? Error {
			[Export ("getError")]
			get {
				TargetingResultError? ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<TargetingResultError> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getError")))!;
				} else {
					ret =  Runtime.GetNSObject<TargetingResultError> (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getError")))!;
				}
				return ret!;
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual bool Passed {
			[Export ("passed")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinitions.Messaging.bool_objc_msgSend (this.Handle, Selector.GetHandle ("passed"));
				} else {
					return global::ApiDefinitions.Messaging.bool_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("passed"));
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual string? SurveyUrl {
			[Export ("getSurveyUrl")]
			get {
				if (IsDirectBinding) {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getSurveyUrl")))!;
				} else {
					return CFString.FromHandle (global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getSurveyUrl")))!;
				}
			}
		}
		[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
		public virtual TargetingResultStatus TargetingResult {
			[Export ("getTargetingResult")]
			get {
				TargetingResultStatus ret;
				if (IsDirectBinding) {
					ret = (QualtricsiOS.TargetingResultStatus) (long) global::ApiDefinitions.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getTargetingResult"));
				} else {
					ret = (QualtricsiOS.TargetingResultStatus) (long) global::ApiDefinitions.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTargetingResult"));
				}
				return ret!;
			}
		}
	} /* class TargetingResultNew */
}

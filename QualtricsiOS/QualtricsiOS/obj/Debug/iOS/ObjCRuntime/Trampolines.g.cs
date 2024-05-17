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
namespace ObjCRuntime {
	[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
	static partial class Trampolines {
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::QualtricsiOS.InitializationResult>))]
		unsafe internal delegate void DActionArity1V0 (IntPtr block, IntPtr obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V0 {
			unsafe static internal readonly DActionArity1V0 Handler = Invoke;
			[MonoPInvokeCallback (typeof (DActionArity1V0))]
			internal static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<global::QualtricsiOS.InitializationResult>> (block);
				if (del != null) {
					del ( Runtime.GetINativeObject<QualtricsiOS.InitializationResult> (obj, false)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<global::QualtricsiOS.InitializationResult>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<global::QualtricsiOS.InitializationResult> callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDActionArity1V0 */
		internal sealed class NIDActionArity1V0 : TrampolineBlockBase {
			DActionArity1V0 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V0 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V0> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::QualtricsiOS.InitializationResult>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::QualtricsiOS.InitializationResult>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V0 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::QualtricsiOS.InitializationResult obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V0 */
		[UnmanagedFunctionPointerAttribute (CallingConvention.Cdecl)]
		[UserDelegateType (typeof (global::System.Action<global::QualtricsiOS.TargetingResultNew>))]
		unsafe internal delegate void DActionArity1V1 (IntPtr block, IntPtr obj);
		//
		// This class bridges native block invocations that call into C#
		//
		static internal class SDActionArity1V1 {
			unsafe static internal readonly DActionArity1V1 Handler = Invoke;
			[MonoPInvokeCallback (typeof (DActionArity1V1))]
			internal static unsafe void Invoke (IntPtr block, IntPtr obj) {
				var del = BlockLiteral.GetTarget<global::System.Action<global::QualtricsiOS.TargetingResultNew>> (block);
				if (del != null) {
					del ( Runtime.GetNSObject<QualtricsiOS.TargetingResultNew> (obj)!);
				}
			}
			internal static unsafe BlockLiteral CreateNullableBlock (global::System.Action<global::QualtricsiOS.TargetingResultNew>? callback)
			{
				if (callback is null)
					return default (BlockLiteral);
				return CreateBlock (callback);
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			internal static unsafe BlockLiteral CreateBlock (global::System.Action<global::QualtricsiOS.TargetingResultNew> callback)
			{
				var block = new BlockLiteral ();
				block.SetupBlockUnsafe (Handler, callback);
				return block;
			}
		} /* class SDActionArity1V1 */
		internal sealed class NIDActionArity1V1 : TrampolineBlockBase {
			DActionArity1V1 invoker;
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe NIDActionArity1V1 (BlockLiteral *block) : base (block)
			{
				invoker = block->GetDelegateForBlock<DActionArity1V1> ();
			}
			[Preserve (Conditional=true)]
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			public unsafe static global::System.Action<global::QualtricsiOS.TargetingResultNew>? Create (IntPtr block)
			{
				if (block == IntPtr.Zero)
					return null;
				var del = (global::System.Action<global::QualtricsiOS.TargetingResultNew>) GetExistingManagedDelegate (block);
				return del ?? new NIDActionArity1V1 ((BlockLiteral *) block).Invoke;
			}
			[BindingImpl (BindingImplOptions.GeneratedCode | BindingImplOptions.Optimizable)]
			unsafe void Invoke (global::QualtricsiOS.TargetingResultNew obj)
			{
				var obj__handle__ = obj.GetHandle ();
				invoker (BlockPointer, obj__handle__);
			}
		} /* class NIDActionArity1V1 */
	}
}

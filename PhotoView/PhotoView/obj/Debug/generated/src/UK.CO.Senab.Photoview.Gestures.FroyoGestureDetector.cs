using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview.Gestures {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='FroyoGestureDetector']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/gestures/FroyoGestureDetector", DoNotGenerateAcw=true)]
	public partial class FroyoGestureDetector : global::UK.CO.Senab.Photoview.Gestures.EclairGestureDetector {


		static IntPtr mDetector_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='FroyoGestureDetector']/field[@name='mDetector']"
		[Register ("mDetector")]
		protected global::Android.Views.ScaleGestureDetector MDetector {
			get {
				if (mDetector_jfieldId == IntPtr.Zero)
					mDetector_jfieldId = JNIEnv.GetFieldID (class_ref, "mDetector", "Landroid/view/ScaleGestureDetector;");
				IntPtr __ret = JNIEnv.GetObjectField (Handle, mDetector_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.Views.ScaleGestureDetector> (__ret, JniHandleOwnership.TransferLocalRef);
			}
			set {
				if (mDetector_jfieldId == IntPtr.Zero)
					mDetector_jfieldId = JNIEnv.GetFieldID (class_ref, "mDetector", "Landroid/view/ScaleGestureDetector;");
				IntPtr native_value = JNIEnv.ToLocalJniHandle (value);
				JNIEnv.SetField (Handle, mDetector_jfieldId, native_value);
				JNIEnv.DeleteLocalRef (native_value);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/gestures/FroyoGestureDetector", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (FroyoGestureDetector); }
		}

		protected FroyoGestureDetector (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview.gestures']/class[@name='FroyoGestureDetector']/constructor[@name='FroyoGestureDetector' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public FroyoGestureDetector (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (FroyoGestureDetector)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;)V", new JValue (p0)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;)V", new JValue (p0));
				return;
			}

			if (id_ctor_Landroid_content_Context_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_, new JValue (p0)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_, new JValue (p0));
		}

	}
}

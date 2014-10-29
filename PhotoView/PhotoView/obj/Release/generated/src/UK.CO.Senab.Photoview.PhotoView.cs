using System;
using System.Collections.Generic;
using Android.Runtime;

namespace UK.CO.Senab.Photoview {

	// Metadata.xml XPath class reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']"
	[global::Android.Runtime.Register ("uk/co/senab/photoview/PhotoView", DoNotGenerateAcw=true)]
	public partial class PhotoView : global::Android.Widget.ImageView {

		internal static IntPtr java_class_handle;
		internal static IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("uk/co/senab/photoview/PhotoView", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PhotoView); }
		}

		protected PhotoView (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/constructor[@name='PhotoView' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;)V", "")]
		public PhotoView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PhotoView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;)V", new JValue (p0), new JValue (p1));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_, new JValue (p0), new JValue (p1));
		}

		static IntPtr id_ctor_Landroid_content_Context_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/constructor[@name='PhotoView' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register (".ctor", "(Landroid/content/Context;)V", "")]
		public PhotoView (global::Android.Content.Context p0) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PhotoView)) {
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

		static IntPtr id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/constructor[@name='PhotoView' and count(parameter)=3 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.util.AttributeSet'] and parameter[3][@type='int']]"
		[Register (".ctor", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", "")]
		public PhotoView (global::Android.Content.Context p0, global::Android.Util.IAttributeSet p1, int p2) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (Handle != IntPtr.Zero)
				return;

			if (GetType () != typeof (PhotoView)) {
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (GetType (), "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2)),
						JniHandleOwnership.TransferLocalRef);
				global::Android.Runtime.JNIEnv.FinishCreateInstance (Handle, "(Landroid/content/Context;Landroid/util/AttributeSet;I)V", new JValue (p0), new JValue (p1), new JValue (p2));
				return;
			}

			if (id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I == IntPtr.Zero)
				id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/content/Context;Landroid/util/AttributeSet;I)V");
			SetHandle (
					global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2)),
					JniHandleOwnership.TransferLocalRef);
			JNIEnv.FinishCreateInstance (Handle, class_ref, id_ctor_Landroid_content_Context_Landroid_util_AttributeSet_I, new JValue (p0), new JValue (p1), new JValue (p2));
		}

		static Delegate cb_getDisplayMatrix;
#pragma warning disable 0169
		static Delegate GetGetDisplayMatrixHandler ()
		{
			if (cb_getDisplayMatrix == null)
				cb_getDisplayMatrix = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayMatrix);
			return cb_getDisplayMatrix;
		}

		static IntPtr n_GetDisplayMatrix (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayMatrix);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayMatrix;
		public virtual global::Android.Graphics.Matrix DisplayMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getDisplayMatrix' and count(parameter)=0]"
			[Register ("getDisplayMatrix", "()Landroid/graphics/Matrix;", "GetGetDisplayMatrixHandler")]
			get {
				if (id_getDisplayMatrix == IntPtr.Zero)
					id_getDisplayMatrix = JNIEnv.GetMethodID (class_ref, "getDisplayMatrix", "()Landroid/graphics/Matrix;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallObjectMethod  (Handle, id_getDisplayMatrix), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayMatrix", "()Landroid/graphics/Matrix;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getDisplayRect;
#pragma warning disable 0169
		static Delegate GetGetDisplayRectHandler ()
		{
			if (cb_getDisplayRect == null)
				cb_getDisplayRect = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDisplayRect);
			return cb_getDisplayRect;
		}

		static IntPtr n_GetDisplayRect (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.DisplayRect);
		}
#pragma warning restore 0169

		static IntPtr id_getDisplayRect;
		public virtual global::Android.Graphics.RectF DisplayRect {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getDisplayRect' and count(parameter)=0]"
			[Register ("getDisplayRect", "()Landroid/graphics/RectF;", "GetGetDisplayRectHandler")]
			get {
				if (id_getDisplayRect == IntPtr.Zero)
					id_getDisplayRect = JNIEnv.GetMethodID (class_ref, "getDisplayRect", "()Landroid/graphics/RectF;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallObjectMethod  (Handle, id_getDisplayRect), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.RectF> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDisplayRect", "()Landroid/graphics/RectF;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_getMaxScale;
#pragma warning disable 0169
		static Delegate GetGetMaxScaleHandler ()
		{
			if (cb_getMaxScale == null)
				cb_getMaxScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaxScale);
			return cb_getMaxScale;
		}

		static float n_GetMaxScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaxScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMaxScale_F;
#pragma warning disable 0169
		static Delegate GetSetMaxScale_FHandler ()
		{
			if (cb_setMaxScale_F == null)
				cb_setMaxScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaxScale_F);
			return cb_setMaxScale_F;
		}

		static void n_SetMaxScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaxScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaxScale;
		static IntPtr id_setMaxScale_F;
		[Obsolete (@"deprecated")]
		public virtual float MaxScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMaxScale' and count(parameter)=0]"
			[Register ("getMaxScale", "()F", "GetGetMaxScaleHandler")]
			get {
				if (id_getMaxScale == IntPtr.Zero)
					id_getMaxScale = JNIEnv.GetMethodID (class_ref, "getMaxScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMaxScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaxScale", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMaxScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaxScale", "(F)V", "GetSetMaxScale_FHandler")]
			set {
				if (id_setMaxScale_F == IntPtr.Zero)
					id_setMaxScale_F = JNIEnv.GetMethodID (class_ref, "setMaxScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaxScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaxScale", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getMaximumScale;
#pragma warning disable 0169
		static Delegate GetGetMaximumScaleHandler ()
		{
			if (cb_getMaximumScale == null)
				cb_getMaximumScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMaximumScale);
			return cb_getMaximumScale;
		}

		static float n_GetMaximumScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MaximumScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMaximumScale_F;
#pragma warning disable 0169
		static Delegate GetSetMaximumScale_FHandler ()
		{
			if (cb_setMaximumScale_F == null)
				cb_setMaximumScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMaximumScale_F);
			return cb_setMaximumScale_F;
		}

		static void n_SetMaximumScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MaximumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMaximumScale;
		static IntPtr id_setMaximumScale_F;
		public virtual float MaximumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMaximumScale' and count(parameter)=0]"
			[Register ("getMaximumScale", "()F", "GetGetMaximumScaleHandler")]
			get {
				if (id_getMaximumScale == IntPtr.Zero)
					id_getMaximumScale = JNIEnv.GetMethodID (class_ref, "getMaximumScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMaximumScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaximumScale", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMaximumScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMaximumScale", "(F)V", "GetSetMaximumScale_FHandler")]
			set {
				if (id_setMaximumScale_F == IntPtr.Zero)
					id_setMaximumScale_F = JNIEnv.GetMethodID (class_ref, "setMaximumScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMaximumScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMaximumScale", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getMediumScale;
#pragma warning disable 0169
		static Delegate GetGetMediumScaleHandler ()
		{
			if (cb_getMediumScale == null)
				cb_getMediumScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMediumScale);
			return cb_getMediumScale;
		}

		static float n_GetMediumScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MediumScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMediumScale_F;
#pragma warning disable 0169
		static Delegate GetSetMediumScale_FHandler ()
		{
			if (cb_setMediumScale_F == null)
				cb_setMediumScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMediumScale_F);
			return cb_setMediumScale_F;
		}

		static void n_SetMediumScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MediumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMediumScale;
		static IntPtr id_setMediumScale_F;
		public virtual float MediumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMediumScale' and count(parameter)=0]"
			[Register ("getMediumScale", "()F", "GetGetMediumScaleHandler")]
			get {
				if (id_getMediumScale == IntPtr.Zero)
					id_getMediumScale = JNIEnv.GetMethodID (class_ref, "getMediumScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMediumScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMediumScale", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMediumScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMediumScale", "(F)V", "GetSetMediumScale_FHandler")]
			set {
				if (id_setMediumScale_F == IntPtr.Zero)
					id_setMediumScale_F = JNIEnv.GetMethodID (class_ref, "setMediumScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMediumScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMediumScale", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getMidScale;
#pragma warning disable 0169
		static Delegate GetGetMidScaleHandler ()
		{
			if (cb_getMidScale == null)
				cb_getMidScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMidScale);
			return cb_getMidScale;
		}

		static float n_GetMidScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MidScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMidScale_F;
#pragma warning disable 0169
		static Delegate GetSetMidScale_FHandler ()
		{
			if (cb_setMidScale_F == null)
				cb_setMidScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMidScale_F);
			return cb_setMidScale_F;
		}

		static void n_SetMidScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MidScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMidScale;
		static IntPtr id_setMidScale_F;
		[Obsolete (@"deprecated")]
		public virtual float MidScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMidScale' and count(parameter)=0]"
			[Register ("getMidScale", "()F", "GetGetMidScaleHandler")]
			get {
				if (id_getMidScale == IntPtr.Zero)
					id_getMidScale = JNIEnv.GetMethodID (class_ref, "getMidScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMidScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMidScale", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMidScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMidScale", "(F)V", "GetSetMidScale_FHandler")]
			set {
				if (id_setMidScale_F == IntPtr.Zero)
					id_setMidScale_F = JNIEnv.GetMethodID (class_ref, "setMidScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMidScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMidScale", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getMinScale;
#pragma warning disable 0169
		static Delegate GetGetMinScaleHandler ()
		{
			if (cb_getMinScale == null)
				cb_getMinScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinScale);
			return cb_getMinScale;
		}

		static float n_GetMinScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMinScale_F;
#pragma warning disable 0169
		static Delegate GetSetMinScale_FHandler ()
		{
			if (cb_setMinScale_F == null)
				cb_setMinScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinScale_F);
			return cb_setMinScale_F;
		}

		static void n_SetMinScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinScale;
		static IntPtr id_setMinScale_F;
		[Obsolete (@"deprecated")]
		public virtual float MinScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMinScale' and count(parameter)=0]"
			[Register ("getMinScale", "()F", "GetGetMinScaleHandler")]
			get {
				if (id_getMinScale == IntPtr.Zero)
					id_getMinScale = JNIEnv.GetMethodID (class_ref, "getMinScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMinScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinScale", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMinScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinScale", "(F)V", "GetSetMinScale_FHandler")]
			set {
				if (id_setMinScale_F == IntPtr.Zero)
					id_setMinScale_F = JNIEnv.GetMethodID (class_ref, "setMinScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMinScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinScale", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getMinimumScale;
#pragma warning disable 0169
		static Delegate GetGetMinimumScaleHandler ()
		{
			if (cb_getMinimumScale == null)
				cb_getMinimumScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetMinimumScale);
			return cb_getMinimumScale;
		}

		static float n_GetMinimumScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.MinimumScale;
		}
#pragma warning restore 0169

		static Delegate cb_setMinimumScale_F;
#pragma warning disable 0169
		static Delegate GetSetMinimumScale_FHandler ()
		{
			if (cb_setMinimumScale_F == null)
				cb_setMinimumScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetMinimumScale_F);
			return cb_setMinimumScale_F;
		}

		static void n_SetMinimumScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.MinimumScale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getMinimumScale;
		static IntPtr id_setMinimumScale_F;
		public virtual float MinimumScale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getMinimumScale' and count(parameter)=0]"
			[Register ("getMinimumScale", "()F", "GetGetMinimumScaleHandler")]
			get {
				if (id_getMinimumScale == IntPtr.Zero)
					id_getMinimumScale = JNIEnv.GetMethodID (class_ref, "getMinimumScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getMinimumScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMinimumScale", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setMinimumScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setMinimumScale", "(F)V", "GetSetMinimumScale_FHandler")]
			set {
				if (id_setMinimumScale_F == IntPtr.Zero)
					id_setMinimumScale_F = JNIEnv.GetMethodID (class_ref, "setMinimumScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setMinimumScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setMinimumScale", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getScale;
#pragma warning disable 0169
		static Delegate GetGetScaleHandler ()
		{
			if (cb_getScale == null)
				cb_getScale = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, float>) n_GetScale);
			return cb_getScale;
		}

		static float n_GetScale (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Scale;
		}
#pragma warning restore 0169

		static Delegate cb_setScale_F;
#pragma warning disable 0169
		static Delegate GetSetScale_FHandler ()
		{
			if (cb_setScale_F == null)
				cb_setScale_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetScale_F);
			return cb_setScale_F;
		}

		static void n_SetScale_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Scale = p0;
		}
#pragma warning restore 0169

		static IntPtr id_getScale;
		static IntPtr id_setScale_F;
		public virtual float Scale {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getScale' and count(parameter)=0]"
			[Register ("getScale", "()F", "GetGetScaleHandler")]
			get {
				if (id_getScale == IntPtr.Zero)
					id_getScale = JNIEnv.GetMethodID (class_ref, "getScale", "()F");

				if (GetType () == ThresholdType)
					return JNIEnv.CallFloatMethod  (Handle, id_getScale);
				else
					return JNIEnv.CallNonvirtualFloatMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getScale", "()F"));
			}
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setScale' and count(parameter)=1 and parameter[1][@type='float']]"
			[Register ("setScale", "(F)V", "GetSetScale_FHandler")]
			set {
				if (id_setScale_F == IntPtr.Zero)
					id_setScale_F = JNIEnv.GetMethodID (class_ref, "setScale", "(F)V");

				if (GetType () == ThresholdType)
					JNIEnv.CallVoidMethod  (Handle, id_setScale_F, new JValue (value));
				else
					JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(F)V"), new JValue (value));
			}
		}

		static Delegate cb_getVisibleRectangleBitmap;
#pragma warning disable 0169
		static Delegate GetGetVisibleRectangleBitmapHandler ()
		{
			if (cb_getVisibleRectangleBitmap == null)
				cb_getVisibleRectangleBitmap = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetVisibleRectangleBitmap);
			return cb_getVisibleRectangleBitmap;
		}

		static IntPtr n_GetVisibleRectangleBitmap (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.ToLocalJniHandle (__this.VisibleRectangleBitmap);
		}
#pragma warning restore 0169

		static IntPtr id_getVisibleRectangleBitmap;
		public virtual global::Android.Graphics.Bitmap VisibleRectangleBitmap {
			// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='getVisibleRectangleBitmap' and count(parameter)=0]"
			[Register ("getVisibleRectangleBitmap", "()Landroid/graphics/Bitmap;", "GetGetVisibleRectangleBitmapHandler")]
			get {
				if (id_getVisibleRectangleBitmap == IntPtr.Zero)
					id_getVisibleRectangleBitmap = JNIEnv.GetMethodID (class_ref, "getVisibleRectangleBitmap", "()Landroid/graphics/Bitmap;");

				if (GetType () == ThresholdType)
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallObjectMethod  (Handle, id_getVisibleRectangleBitmap), JniHandleOwnership.TransferLocalRef);
				else
					return global::Java.Lang.Object.GetObject<global::Android.Graphics.Bitmap> (JNIEnv.CallNonvirtualObjectMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getVisibleRectangleBitmap", "()Landroid/graphics/Bitmap;")), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_canZoom;
#pragma warning disable 0169
		static Delegate GetCanZoomHandler ()
		{
			if (cb_canZoom == null)
				cb_canZoom = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_CanZoom);
			return cb_canZoom;
		}

		static bool n_CanZoom (IntPtr jnienv, IntPtr native__this)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.CanZoom ();
		}
#pragma warning restore 0169

		static IntPtr id_canZoom;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='canZoom' and count(parameter)=0]"
		[Register ("canZoom", "()Z", "GetCanZoomHandler")]
		public virtual bool CanZoom ()
		{
			if (id_canZoom == IntPtr.Zero)
				id_canZoom = JNIEnv.GetMethodID (class_ref, "canZoom", "()Z");

			if (GetType () == ThresholdType)
				return JNIEnv.CallBooleanMethod  (Handle, id_canZoom);
			else
				return JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "canZoom", "()Z"));
		}

		static Delegate cb_setAllowParentInterceptOnEdge_Z;
#pragma warning disable 0169
		static Delegate GetSetAllowParentInterceptOnEdge_ZHandler ()
		{
			if (cb_setAllowParentInterceptOnEdge_Z == null)
				cb_setAllowParentInterceptOnEdge_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetAllowParentInterceptOnEdge_Z);
			return cb_setAllowParentInterceptOnEdge_Z;
		}

		static void n_SetAllowParentInterceptOnEdge_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetAllowParentInterceptOnEdge (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setAllowParentInterceptOnEdge_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setAllowParentInterceptOnEdge' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setAllowParentInterceptOnEdge", "(Z)V", "GetSetAllowParentInterceptOnEdge_ZHandler")]
		public virtual void SetAllowParentInterceptOnEdge (bool p0)
		{
			if (id_setAllowParentInterceptOnEdge_Z == IntPtr.Zero)
				id_setAllowParentInterceptOnEdge_Z = JNIEnv.GetMethodID (class_ref, "setAllowParentInterceptOnEdge", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setAllowParentInterceptOnEdge_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setAllowParentInterceptOnEdge", "(Z)V"), new JValue (p0));
		}

		static Delegate cb_setDisplayMatrix_Landroid_graphics_Matrix_;
#pragma warning disable 0169
		static Delegate GetSetDisplayMatrix_Landroid_graphics_Matrix_Handler ()
		{
			if (cb_setDisplayMatrix_Landroid_graphics_Matrix_ == null)
				cb_setDisplayMatrix_Landroid_graphics_Matrix_ = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr, bool>) n_SetDisplayMatrix_Landroid_graphics_Matrix_);
			return cb_setDisplayMatrix_Landroid_graphics_Matrix_;
		}

		static bool n_SetDisplayMatrix_Landroid_graphics_Matrix_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Graphics.Matrix p0 = global::Java.Lang.Object.GetObject<global::Android.Graphics.Matrix> (native_p0, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.SetDisplayMatrix (p0);
			return __ret;
		}
#pragma warning restore 0169

		static IntPtr id_setDisplayMatrix_Landroid_graphics_Matrix_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setDisplayMatrix' and count(parameter)=1 and parameter[1][@type='android.graphics.Matrix']]"
		[Register ("setDisplayMatrix", "(Landroid/graphics/Matrix;)Z", "GetSetDisplayMatrix_Landroid_graphics_Matrix_Handler")]
		public virtual bool SetDisplayMatrix (global::Android.Graphics.Matrix p0)
		{
			if (id_setDisplayMatrix_Landroid_graphics_Matrix_ == IntPtr.Zero)
				id_setDisplayMatrix_Landroid_graphics_Matrix_ = JNIEnv.GetMethodID (class_ref, "setDisplayMatrix", "(Landroid/graphics/Matrix;)Z");

			bool __ret;
			if (GetType () == ThresholdType)
				__ret = JNIEnv.CallBooleanMethod  (Handle, id_setDisplayMatrix_Landroid_graphics_Matrix_, new JValue (p0));
			else
				__ret = JNIEnv.CallNonvirtualBooleanMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setDisplayMatrix", "(Landroid/graphics/Matrix;)Z"), new JValue (p0));
			return __ret;
		}

		static Delegate cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
#pragma warning disable 0169
		static Delegate GetSetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_Handler ()
		{
			if (cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ == null)
				cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_SetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_);
			return cb_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
		}

		static void n_SetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Views.GestureDetector.IOnDoubleTapListener p0 = (global::Android.Views.GestureDetector.IOnDoubleTapListener)global::Java.Lang.Object.GetObject<global::Android.Views.GestureDetector.IOnDoubleTapListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.SetOnDoubleTapListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setOnDoubleTapListener' and count(parameter)=1 and parameter[1][@type='android.view.GestureDetector.OnDoubleTapListener']]"
		[Register ("setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V", "GetSetOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_Handler")]
		public virtual void SetOnDoubleTapListener (global::Android.Views.GestureDetector.IOnDoubleTapListener p0)
		{
			if (id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ == IntPtr.Zero)
				id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_ = JNIEnv.GetMethodID (class_ref, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setOnDoubleTapListener_Landroid_view_GestureDetector_OnDoubleTapListener_, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setOnDoubleTapListener", "(Landroid/view/GestureDetector$OnDoubleTapListener;)V"), new JValue (p0));
		}

		static Delegate cb_setPhotoViewRotation_F;
#pragma warning disable 0169
		static Delegate GetSetPhotoViewRotation_FHandler ()
		{
			if (cb_setPhotoViewRotation_F == null)
				cb_setPhotoViewRotation_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetPhotoViewRotation_F);
			return cb_setPhotoViewRotation_F;
		}

		static void n_SetPhotoViewRotation_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetPhotoViewRotation (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setPhotoViewRotation_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setPhotoViewRotation' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setPhotoViewRotation", "(F)V", "GetSetPhotoViewRotation_FHandler")]
		public virtual void SetPhotoViewRotation (float p0)
		{
			if (id_setPhotoViewRotation_F == IntPtr.Zero)
				id_setPhotoViewRotation_F = JNIEnv.GetMethodID (class_ref, "setPhotoViewRotation", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setPhotoViewRotation_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setPhotoViewRotation", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setRotationBy_F;
#pragma warning disable 0169
		static Delegate GetSetRotationBy_FHandler ()
		{
			if (cb_setRotationBy_F == null)
				cb_setRotationBy_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotationBy_F);
			return cb_setRotationBy_F;
		}

		static void n_SetRotationBy_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationBy (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationBy_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setRotationBy' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRotationBy", "(F)V", "GetSetRotationBy_FHandler")]
		public virtual void SetRotationBy (float p0)
		{
			if (id_setRotationBy_F == IntPtr.Zero)
				id_setRotationBy_F = JNIEnv.GetMethodID (class_ref, "setRotationBy", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRotationBy_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotationBy", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setRotationTo_F;
#pragma warning disable 0169
		static Delegate GetSetRotationTo_FHandler ()
		{
			if (cb_setRotationTo_F == null)
				cb_setRotationTo_F = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float>) n_SetRotationTo_F);
			return cb_setRotationTo_F;
		}

		static void n_SetRotationTo_F (IntPtr jnienv, IntPtr native__this, float p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetRotationTo (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setRotationTo_F;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setRotationTo' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("setRotationTo", "(F)V", "GetSetRotationTo_FHandler")]
		public virtual void SetRotationTo (float p0)
		{
			if (id_setRotationTo_F == IntPtr.Zero)
				id_setRotationTo_F = JNIEnv.GetMethodID (class_ref, "setRotationTo", "(F)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setRotationTo_F, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setRotationTo", "(F)V"), new JValue (p0));
		}

		static Delegate cb_setScale_FZ;
#pragma warning disable 0169
		static Delegate GetSetScale_FZHandler ()
		{
			if (cb_setScale_FZ == null)
				cb_setScale_FZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, bool>) n_SetScale_FZ);
			return cb_setScale_FZ;
		}

		static void n_SetScale_FZ (IntPtr jnienv, IntPtr native__this, float p0, bool p1)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_FZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setScale' and count(parameter)=2 and parameter[1][@type='float'] and parameter[2][@type='boolean']]"
		[Register ("setScale", "(FZ)V", "GetSetScale_FZHandler")]
		public virtual void SetScale (float p0, bool p1)
		{
			if (id_setScale_FZ == IntPtr.Zero)
				id_setScale_FZ = JNIEnv.GetMethodID (class_ref, "setScale", "(FZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScale_FZ, new JValue (p0), new JValue (p1));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(FZ)V"), new JValue (p0), new JValue (p1));
		}

		static Delegate cb_setScale_FFFZ;
#pragma warning disable 0169
		static Delegate GetSetScale_FFFZHandler ()
		{
			if (cb_setScale_FFFZ == null)
				cb_setScale_FFFZ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, float, float, float, bool>) n_SetScale_FFFZ);
			return cb_setScale_FFFZ;
		}

		static void n_SetScale_FFFZ (IntPtr jnienv, IntPtr native__this, float p0, float p1, float p2, bool p3)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetScale (p0, p1, p2, p3);
		}
#pragma warning restore 0169

		static IntPtr id_setScale_FFFZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setScale' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='boolean']]"
		[Register ("setScale", "(FFFZ)V", "GetSetScale_FFFZHandler")]
		public virtual void SetScale (float p0, float p1, float p2, bool p3)
		{
			if (id_setScale_FFFZ == IntPtr.Zero)
				id_setScale_FFFZ = JNIEnv.GetMethodID (class_ref, "setScale", "(FFFZ)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setScale_FFFZ, new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setScale", "(FFFZ)V"), new JValue (p0), new JValue (p1), new JValue (p2), new JValue (p3));
		}

		static Delegate cb_setZoomTransitionDuration_I;
#pragma warning disable 0169
		static Delegate GetSetZoomTransitionDuration_IHandler ()
		{
			if (cb_setZoomTransitionDuration_I == null)
				cb_setZoomTransitionDuration_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int>) n_SetZoomTransitionDuration_I);
			return cb_setZoomTransitionDuration_I;
		}

		static void n_SetZoomTransitionDuration_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomTransitionDuration (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomTransitionDuration_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setZoomTransitionDuration' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setZoomTransitionDuration", "(I)V", "GetSetZoomTransitionDuration_IHandler")]
		public virtual void SetZoomTransitionDuration (int p0)
		{
			if (id_setZoomTransitionDuration_I == IntPtr.Zero)
				id_setZoomTransitionDuration_I = JNIEnv.GetMethodID (class_ref, "setZoomTransitionDuration", "(I)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setZoomTransitionDuration_I, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomTransitionDuration", "(I)V"), new JValue (p0));
		}

		static Delegate cb_setZoomable_Z;
#pragma warning disable 0169
		static Delegate GetSetZoomable_ZHandler ()
		{
			if (cb_setZoomable_Z == null)
				cb_setZoomable_Z = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, bool>) n_SetZoomable_Z);
			return cb_setZoomable_Z;
		}

		static void n_SetZoomable_Z (IntPtr jnienv, IntPtr native__this, bool p0)
		{
			global::UK.CO.Senab.Photoview.PhotoView __this = global::Java.Lang.Object.GetObject<global::UK.CO.Senab.Photoview.PhotoView> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.SetZoomable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_setZoomable_Z;
		// Metadata.xml XPath method reference: path="/api/package[@name='uk.co.senab.photoview']/class[@name='PhotoView']/method[@name='setZoomable' and count(parameter)=1 and parameter[1][@type='boolean']]"
		[Register ("setZoomable", "(Z)V", "GetSetZoomable_ZHandler")]
		public virtual void SetZoomable (bool p0)
		{
			if (id_setZoomable_Z == IntPtr.Zero)
				id_setZoomable_Z = JNIEnv.GetMethodID (class_ref, "setZoomable", "(Z)V");

			if (GetType () == ThresholdType)
				JNIEnv.CallVoidMethod  (Handle, id_setZoomable_Z, new JValue (p0));
			else
				JNIEnv.CallNonvirtualVoidMethod  (Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "setZoomable", "(Z)V"), new JValue (p0));
		}

	}
}

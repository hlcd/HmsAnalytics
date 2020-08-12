/*
*       Copyright 2020. Huawei Technologies Co., Ltd. All rights reserved.

        Licensed under the Apache License, Version 2.0 (the "License");
        you may not use this file except in compliance with the License.
        You may obtain a copy of the License at

        http://www.apache.org/licenses/LICENSE-2.0

        Unless required by applicable law or agreed to in writing, software
        distributed under the License is distributed on an "AS IS" BASIS,
        WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
        See the License for the specific language governing permissions and
        limitations under the License.
*/
using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Huawei.Agconnect.Core
{

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.huawei.agconnect.core']/interface[@name='ServiceRegistrar']"
	[Register("com/huawei/agconnect/core/ServiceRegistrar", "", "Com.Huawei.Agconnect.Core.IServiceRegistrarInvoker")]
	public partial interface IServiceRegistrar : IJavaObject, IJavaPeerable
	{

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.core']/interface[@name='ServiceRegistrar']/method[@name='getServices' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("getServices", "(Landroid/content/Context;)Ljava/util/List;", "GetGetServices_Landroid_content_Context_Handler:Com.Huawei.Agconnect.Core.IServiceRegistrarInvoker, XAgConnectCore-1.0.0.300")]
		global::System.Collections.Generic.IList<global::Com.Huawei.Agconnect.Core.AgcService> GetServices(global::Android.Content.Context p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.agconnect.core']/interface[@name='ServiceRegistrar']/method[@name='initialize' and count(parameter)=1 and parameter[1][@type='android.content.Context']]"
		[Register("initialize", "(Landroid/content/Context;)V", "GetInitialize_Landroid_content_Context_Handler:Com.Huawei.Agconnect.Core.IServiceRegistrarInvoker, XAgConnectCore-1.0.0.300")]
		void Initialize(global::Android.Content.Context p0);

	}

	[global::Android.Runtime.Register("com/huawei/agconnect/core/ServiceRegistrar", DoNotGenerateAcw = true)]
	internal partial class IServiceRegistrarInvoker : global::Java.Lang.Object, IServiceRegistrar
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("com/huawei/agconnect/core/ServiceRegistrar", typeof(IServiceRegistrarInvoker));

		static IntPtr java_class_ref
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		protected override IntPtr ThresholdClass
		{
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		IntPtr class_ref;

		public static IServiceRegistrar GetObject(IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IServiceRegistrar>(handle, transfer);
		}

		static IntPtr Validate(IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf(handle, java_class_ref))
				throw new InvalidCastException(string.Format("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance(handle), "com.huawei.agconnect.core.ServiceRegistrar"));
			return handle;
		}

		protected override void Dispose(bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef(this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose(disposing);
		}

		public IServiceRegistrarInvoker(IntPtr handle, JniHandleOwnership transfer) : base(Validate(handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass(((global::Java.Lang.Object)this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef(local_ref);
			JNIEnv.DeleteLocalRef(local_ref);
		}

		static Delegate cb_getServices_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetGetServices_Landroid_content_Context_Handler()
		{
			if (cb_getServices_Landroid_content_Context_ == null)
				cb_getServices_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Func<IntPtr, IntPtr, IntPtr, IntPtr>)n_GetServices_Landroid_content_Context_);
			return cb_getServices_Landroid_content_Context_;
		}

		static IntPtr n_GetServices_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Agconnect.Core.IServiceRegistrar __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Core.IServiceRegistrar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = global::Android.Runtime.JavaList<global::Com.Huawei.Agconnect.Core.AgcService>.ToLocalJniHandle(__this.GetServices(p0));
			return __ret;
		}
#pragma warning restore 0169

		IntPtr id_getServices_Landroid_content_Context_;
		public unsafe global::System.Collections.Generic.IList<global::Com.Huawei.Agconnect.Core.AgcService> GetServices(global::Android.Content.Context p0)
		{
			if (id_getServices_Landroid_content_Context_ == IntPtr.Zero)
				id_getServices_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "getServices", "(Landroid/content/Context;)Ljava/util/List;");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
			global::System.Collections.Generic.IList<global::Com.Huawei.Agconnect.Core.AgcService> __ret = global::Android.Runtime.JavaList<global::Com.Huawei.Agconnect.Core.AgcService>.FromJniHandle(JNIEnv.CallObjectMethod(((global::Java.Lang.Object)this).Handle, id_getServices_Landroid_content_Context_, __args), JniHandleOwnership.TransferLocalRef);
			return __ret;
		}

		static Delegate cb_initialize_Landroid_content_Context_;
#pragma warning disable 0169
		static Delegate GetInitialize_Landroid_content_Context_Handler()
		{
			if (cb_initialize_Landroid_content_Context_ == null)
				cb_initialize_Landroid_content_Context_ = JNINativeWrapper.CreateDelegate((Action<IntPtr, IntPtr, IntPtr>)n_Initialize_Landroid_content_Context_);
			return cb_initialize_Landroid_content_Context_;
		}

		static void n_Initialize_Landroid_content_Context_(IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Huawei.Agconnect.Core.IServiceRegistrar __this = global::Java.Lang.Object.GetObject<global::Com.Huawei.Agconnect.Core.IServiceRegistrar>(jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.Content.Context p0 = global::Java.Lang.Object.GetObject<global::Android.Content.Context>(native_p0, JniHandleOwnership.DoNotTransfer);
			__this.Initialize(p0);
		}
#pragma warning restore 0169

		IntPtr id_initialize_Landroid_content_Context_;
		public unsafe void Initialize(global::Android.Content.Context p0)
		{
			if (id_initialize_Landroid_content_Context_ == IntPtr.Zero)
				id_initialize_Landroid_content_Context_ = JNIEnv.GetMethodID(class_ref, "initialize", "(Landroid/content/Context;)V");
			JValue* __args = stackalloc JValue[1];
			__args[0] = new JValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
			JNIEnv.CallVoidMethod(((global::Java.Lang.Object)this).Handle, id_initialize_Landroid_content_Context_, __args);
		}

	}

}

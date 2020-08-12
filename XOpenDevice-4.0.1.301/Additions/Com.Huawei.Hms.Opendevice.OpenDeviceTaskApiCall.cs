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

namespace Com.Huawei.Hms.Opendevice
{

	// Metadata.xml XPath class reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceTaskApiCall']"
	[global::Android.Runtime.Register("com/huawei/hms/opendevice/OpenDeviceTaskApiCall", DoNotGenerateAcw = true)]
	public partial class OpenDeviceTaskApiCall : global::Com.Huawei.Hms.Common.Internal.TaskApiCall
	{

		static readonly JniPeerMembers _members = new XAPeerMembers("com/huawei/hms/opendevice/OpenDeviceTaskApiCall", typeof(OpenDeviceTaskApiCall));
		internal static new IntPtr class_ref
		{
			get
			{
				return _members.JniPeerType.PeerReference.Handle;
			}
		}

		public override global::Java.Interop.JniPeerMembers JniPeerMembers
		{
			get { return _members; }
		}

		protected override IntPtr ThresholdClass
		{
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		protected override global::System.Type ThresholdType
		{
			get { return _members.ManagedPeerType; }
		}

		protected OpenDeviceTaskApiCall(IntPtr javaReference, JniHandleOwnership transfer) : base(javaReference, transfer) { }

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceTaskApiCall']/constructor[@name='OpenDeviceTaskApiCall' and count(parameter)=3 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String']]"
		[Register(".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", "")]
		public unsafe OpenDeviceTaskApiCall(string p0, string p1, string p2)
			: base(IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V";

			if (((global::Java.Lang.Object)this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewString(p0);
			IntPtr native_p1 = JNIEnv.NewString(p1);
			IntPtr native_p2 = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[3];
				__args[0] = new JniArgumentValue(native_p0);
				__args[1] = new JniArgumentValue(native_p1);
				__args[2] = new JniArgumentValue(native_p2);
				var __r = _members.InstanceMethods.StartCreateInstance(__id, ((object)this).GetType(), __args);
				SetHandle(__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p0);
				JNIEnv.DeleteLocalRef(native_p1);
				JNIEnv.DeleteLocalRef(native_p2);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.huawei.hms.opendevice']/class[@name='OpenDeviceTaskApiCall']/method[@name='doExecute' and count(parameter)=4 and parameter[1][@type='com.huawei.hms.opendevice.OpenDeviceHmsClient'] and parameter[2][@type='com.huawei.hms.common.internal.ResponseErrorCode'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='com.huawei.hmf.tasks.TaskCompletionSource&lt;com.huawei.hms.support.api.opendevice.OdidResult&gt;']]"
		[Register("doExecute", "(Lcom/huawei/hms/opendevice/OpenDeviceHmsClient;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V", "")]
		protected unsafe override void DoExecute(global::Java.Lang.Object p0, global::Com.Huawei.Hms.Common.Internal.IResponseErrorCode p1, string p2, global::Com.Huawei.Hmf.Tasks.TaskCompletionSource p3)
		{
			const string __id = "doExecute.(Lcom/huawei/hms/opendevice/OpenDeviceHmsClient;Lcom/huawei/hms/common/internal/ResponseErrorCode;Ljava/lang/String;Lcom/huawei/hmf/tasks/TaskCompletionSource;)V";
			IntPtr native_p2 = JNIEnv.NewString(p2);
			try
			{
				JniArgumentValue* __args = stackalloc JniArgumentValue[4];
				__args[0] = new JniArgumentValue((p0 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p0).Handle);
				__args[1] = new JniArgumentValue((p1 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p1).Handle);
				__args[2] = new JniArgumentValue(native_p2);
				__args[3] = new JniArgumentValue((p3 == null) ? IntPtr.Zero : ((global::Java.Lang.Object)p3).Handle);
				_members.InstanceMethods.InvokeNonvirtualVoidMethod(__id, this, __args);
			}
			finally
			{
				JNIEnv.DeleteLocalRef(native_p2);
			}
		}

	}
}

﻿using System;
using System.Runtime.InteropServices;
using System.Security;

namespace CUDA
{
    public unsafe partial class Runtime
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cudaEventCreate@@YA?AW4cudaError@@PEAPEAUCUevent_st@@I@Z")]
            internal static extern global::CUDA.CudaError CudaEventCreate(global::System.IntPtr @event, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cudaMallocHost@@YA?AW4cudaError@@PEAPEAX_KI@Z")]
            internal static extern global::CUDA.CudaError CudaMallocHost(void** ptr, ulong size, uint flags);
        }

        /// <summary>Creates an event object with the specified flags</summary>
        /// <param name="event">- Newly created event</param>
        /// <param name="flags">- Flags for new event</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates an event object with the specified flags. Valid flags include:</para>
        /// <para>- ::cudaEventDefault: Default event creation flag.</para>
        /// <para>- ::cudaEventBlockingSync: Specifies that event should use blocking</para>
        /// <para>synchronization. A host thread that uses ::cudaEventSynchronize() to wait</para>
        /// <para>on an event created with this flag will block until the event actually</para>
        /// <para>completes.</para>
        /// <para>- ::cudaEventDisableTiming: Specifies that the created event does not need</para>
        /// <para>to record timing data.  Events created with this flag specified and</para>
        /// <para>the ::cudaEventBlockingSync flag not specified will provide the best</para>
        /// <para>performance when used with ::cudaStreamWaitEvent() and ::cudaEventQuery().</para>
        /// <para>::cudaEventCreateWithFlags, ::cudaEventRecord, ::cudaEventQuery,</para>
        /// <para>::cudaEventSynchronize, ::cudaEventDestroy, ::cudaEventElapsedTime,</para>
        /// <para>::cudaStreamWaitEvent</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventCreate(global::CUDA.CUeventSt @event, uint flags)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaEventCreate(__arg0, flags);
            return __ret;
        }

        /// <summary>Allocates page-locked memory on the host</summary>
        /// <param name="ptr">- Device pointer to allocated memory</param>
        /// <param name="size">- Requested allocation size in bytes</param>
        /// <param name="flags">- Requested properties of allocated memory</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocatesbytes of host memory that is page-locked and accessible</para>
        /// <para>to the device. The driver tracks the virtual memory ranges allocated with</para>
        /// <para>this function and automatically accelerates calls to functions such as</para>
        /// <para>::cudaMemcpy(). Since the memory can be accessed directly by the device, it</para>
        /// <para>can be read or written with much higher bandwidth than pageable memory</para>
        /// <para>obtained with functions such as ::malloc(). Allocating excessive amounts of</para>
        /// <para>pinned memory may degrade system performance, since it reduces the amount</para>
        /// <para>of memory available to the system for paging. As a result, this function is</para>
        /// <para>best used sparingly to allocate staging areas for data exchange between host</para>
        /// <para>and device.</para>
        /// <para>Theparameter enables different options to be specified that affect</para>
        /// <para>the allocation, as follows.</para>
        /// <para>- ::cudaHostAllocDefault: This flag's value is defined to be 0.</para>
        /// <para>- ::cudaHostAllocPortable: The memory returned by this call will be</para>
        /// <para>considered as pinned memory by all CUDA contexts, not just the one that</para>
        /// <para>performed the allocation.</para>
        /// <para>- ::cudaHostAllocMapped: Maps the allocation into the CUDA address space.</para>
        /// <para>The device pointer to the memory may be obtained by calling</para>
        /// <para>::cudaHostGetDevicePointer().</para>
        /// <para>- ::cudaHostAllocWriteCombined: Allocates the memory as write-combined (WC).</para>
        /// <para>WC memory can be transferred across the PCI Express bus more quickly on some</para>
        /// <para>system configurations, but cannot be read efficiently by most CPUs.  WC</para>
        /// <para>memory is a good option for buffers that will be written by the CPU and read</para>
        /// <para>by the device via mapped pinned memory or host-&gt;device transfers.</para>
        /// <para>All of these flags are orthogonal to one another: a developer may allocate</para>
        /// <para>memory that is portable, mapped and/or write-combined with no restrictions.</para>
        /// <para>::cudaSetDeviceFlags() must have been called with the ::cudaDeviceMapHost</para>
        /// <para>flag in order for the ::cudaHostAllocMapped flag to have any effect.</para>
        /// <para>The ::cudaHostAllocMapped flag may be specified on CUDA contexts for devices</para>
        /// <para>that do not support mapped pinned memory. The failure is deferred to</para>
        /// <para>::cudaHostGetDevicePointer() because the memory may be mapped into other</para>
        /// <para>CUDA contexts via the ::cudaHostAllocPortable flag.</para>
        /// <para>Memory allocated by this function must be freed with ::cudaFreeHost().</para>
        /// <para>::cudaSetDeviceFlags,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMallocHost(void** ptr, ulong size, uint flags)
        {
            var __ret = __Internal.CudaMallocHost(ptr, size, flags);
            return __ret;
        }
    }

    /// <summary>
    /// <para>*****************************************************************************</para>
    /// <para>*</para>
    /// <para>*</para>
    /// <para>*</para>
    /// <para>*****************************************************************************</para>
    /// </summary>
    public enum CudaRoundMode
    {
        CudaRoundNearest = 0,
        CudaRoundZero = 1,
        CudaRoundPosInf = 2,
        CudaRoundMinInf = 3
    }

    /// <summary>
    /// <para>*****************************************************************************</para>
    /// <para>*</para>
    /// <para>*</para>
    /// <para>*</para>
    /// <para>*****************************************************************************</para>
    /// </summary>
    public unsafe partial class Char1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal sbyte x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0char1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Char1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Char1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Char1 __CreateInstance(global::CUDA.Char1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Char1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Char1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Char1.__Internal));
            *(global::CUDA.Char1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Char1(global::CUDA.Char1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Char1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Char1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Char1(global::CUDA.Char1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Char1.__Internal*)__Instance) = *((global::CUDA.Char1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Char1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte X
        {
            get
            {
                return ((global::CUDA.Char1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Char1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Uchar1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 1)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal byte x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uchar1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uchar1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uchar1 __CreateInstance(global::CUDA.Uchar1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uchar1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar1.__Internal));
            *(global::CUDA.Uchar1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uchar1(global::CUDA.Uchar1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uchar1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uchar1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uchar1(global::CUDA.Uchar1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uchar1.__Internal*)__Instance) = *((global::CUDA.Uchar1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uchar1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte X
        {
            get
            {
                return ((global::CUDA.Uchar1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uchar1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Char2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal sbyte x;

            [FieldOffset(1)]
            internal sbyte y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0char2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Char2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Char2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Char2 __CreateInstance(global::CUDA.Char2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Char2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Char2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Char2.__Internal));
            *(global::CUDA.Char2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Char2(global::CUDA.Char2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Char2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Char2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Char2(global::CUDA.Char2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Char2.__Internal*)__Instance) = *((global::CUDA.Char2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Char2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte X
        {
            get
            {
                return ((global::CUDA.Char2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Char2.__Internal*)__Instance)->x = value;
            }
        }

        public sbyte Y
        {
            get
            {
                return ((global::CUDA.Char2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Char2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Uchar2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal byte x;

            [FieldOffset(1)]
            internal byte y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uchar2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uchar2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uchar2 __CreateInstance(global::CUDA.Uchar2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uchar2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar2.__Internal));
            *(global::CUDA.Uchar2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uchar2(global::CUDA.Uchar2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uchar2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uchar2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uchar2(global::CUDA.Uchar2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uchar2.__Internal*)__Instance) = *((global::CUDA.Uchar2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uchar2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte X
        {
            get
            {
                return ((global::CUDA.Uchar2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uchar2.__Internal*)__Instance)->x = value;
            }
        }

        public byte Y
        {
            get
            {
                return ((global::CUDA.Uchar2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Uchar2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Char3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 3)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal sbyte x;

            [FieldOffset(1)]
            internal sbyte y;

            [FieldOffset(2)]
            internal sbyte z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0char3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Char3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Char3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Char3 __CreateInstance(global::CUDA.Char3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Char3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Char3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Char3.__Internal));
            *(global::CUDA.Char3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Char3(global::CUDA.Char3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Char3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Char3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Char3(global::CUDA.Char3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Char3.__Internal*)__Instance) = *((global::CUDA.Char3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Char3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte X
        {
            get
            {
                return ((global::CUDA.Char3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Char3.__Internal*)__Instance)->x = value;
            }
        }

        public sbyte Y
        {
            get
            {
                return ((global::CUDA.Char3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Char3.__Internal*)__Instance)->y = value;
            }
        }

        public sbyte Z
        {
            get
            {
                return ((global::CUDA.Char3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Char3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Uchar3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 3)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal byte x;

            [FieldOffset(1)]
            internal byte y;

            [FieldOffset(2)]
            internal byte z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uchar3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uchar3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uchar3 __CreateInstance(global::CUDA.Uchar3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uchar3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar3.__Internal));
            *(global::CUDA.Uchar3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uchar3(global::CUDA.Uchar3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uchar3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uchar3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uchar3(global::CUDA.Uchar3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uchar3.__Internal*)__Instance) = *((global::CUDA.Uchar3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uchar3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte X
        {
            get
            {
                return ((global::CUDA.Uchar3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uchar3.__Internal*)__Instance)->x = value;
            }
        }

        public byte Y
        {
            get
            {
                return ((global::CUDA.Uchar3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Uchar3.__Internal*)__Instance)->y = value;
            }
        }

        public byte Z
        {
            get
            {
                return ((global::CUDA.Uchar3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Uchar3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Char4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal sbyte x;

            [FieldOffset(1)]
            internal sbyte y;

            [FieldOffset(2)]
            internal sbyte z;

            [FieldOffset(3)]
            internal sbyte w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0char4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Char4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Char4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Char4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Char4 __CreateInstance(global::CUDA.Char4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Char4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Char4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Char4.__Internal));
            *(global::CUDA.Char4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Char4(global::CUDA.Char4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Char4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Char4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Char4(global::CUDA.Char4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Char4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Char4.__Internal*)__Instance) = *((global::CUDA.Char4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Char4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte X
        {
            get
            {
                return ((global::CUDA.Char4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Char4.__Internal*)__Instance)->x = value;
            }
        }

        public sbyte Y
        {
            get
            {
                return ((global::CUDA.Char4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Char4.__Internal*)__Instance)->y = value;
            }
        }

        public sbyte Z
        {
            get
            {
                return ((global::CUDA.Char4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Char4.__Internal*)__Instance)->z = value;
            }
        }

        public sbyte W
        {
            get
            {
                return ((global::CUDA.Char4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Char4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Uchar4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal byte x;

            [FieldOffset(1)]
            internal byte y;

            [FieldOffset(2)]
            internal byte z;

            [FieldOffset(3)]
            internal byte w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uchar4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uchar4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uchar4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uchar4 __CreateInstance(global::CUDA.Uchar4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uchar4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uchar4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar4.__Internal));
            *(global::CUDA.Uchar4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uchar4(global::CUDA.Uchar4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uchar4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uchar4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uchar4(global::CUDA.Uchar4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uchar4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uchar4.__Internal*)__Instance) = *((global::CUDA.Uchar4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uchar4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public byte X
        {
            get
            {
                return ((global::CUDA.Uchar4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uchar4.__Internal*)__Instance)->x = value;
            }
        }

        public byte Y
        {
            get
            {
                return ((global::CUDA.Uchar4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Uchar4.__Internal*)__Instance)->y = value;
            }
        }

        public byte Z
        {
            get
            {
                return ((global::CUDA.Uchar4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Uchar4.__Internal*)__Instance)->z = value;
            }
        }

        public byte W
        {
            get
            {
                return ((global::CUDA.Uchar4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Uchar4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Short1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal short x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0short1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Short1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Short1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Short1 __CreateInstance(global::CUDA.Short1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Short1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Short1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Short1.__Internal));
            *(global::CUDA.Short1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Short1(global::CUDA.Short1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Short1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Short1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Short1(global::CUDA.Short1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Short1.__Internal*)__Instance) = *((global::CUDA.Short1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Short1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public short X
        {
            get
            {
                return ((global::CUDA.Short1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Short1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Ushort1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ushort x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ushort1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ushort1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ushort1 __CreateInstance(global::CUDA.Ushort1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ushort1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort1.__Internal));
            *(global::CUDA.Ushort1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ushort1(global::CUDA.Ushort1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ushort1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ushort1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ushort1(global::CUDA.Ushort1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ushort1.__Internal*)__Instance) = *((global::CUDA.Ushort1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ushort1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ushort X
        {
            get
            {
                return ((global::CUDA.Ushort1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ushort1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Short2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal short x;

            [FieldOffset(2)]
            internal short y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0short2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Short2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Short2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Short2 __CreateInstance(global::CUDA.Short2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Short2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Short2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Short2.__Internal));
            *(global::CUDA.Short2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Short2(global::CUDA.Short2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Short2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Short2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Short2(global::CUDA.Short2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Short2.__Internal*)__Instance) = *((global::CUDA.Short2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Short2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public short X
        {
            get
            {
                return ((global::CUDA.Short2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Short2.__Internal*)__Instance)->x = value;
            }
        }

        public short Y
        {
            get
            {
                return ((global::CUDA.Short2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Short2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Ushort2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ushort x;

            [FieldOffset(2)]
            internal ushort y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ushort2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ushort2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ushort2 __CreateInstance(global::CUDA.Ushort2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ushort2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort2.__Internal));
            *(global::CUDA.Ushort2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ushort2(global::CUDA.Ushort2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ushort2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ushort2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ushort2(global::CUDA.Ushort2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ushort2.__Internal*)__Instance) = *((global::CUDA.Ushort2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ushort2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ushort X
        {
            get
            {
                return ((global::CUDA.Ushort2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ushort2.__Internal*)__Instance)->x = value;
            }
        }

        public ushort Y
        {
            get
            {
                return ((global::CUDA.Ushort2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ushort2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Short3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 6)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal short x;

            [FieldOffset(2)]
            internal short y;

            [FieldOffset(4)]
            internal short z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0short3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Short3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Short3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Short3 __CreateInstance(global::CUDA.Short3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Short3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Short3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Short3.__Internal));
            *(global::CUDA.Short3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Short3(global::CUDA.Short3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Short3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Short3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Short3(global::CUDA.Short3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Short3.__Internal*)__Instance) = *((global::CUDA.Short3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Short3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public short X
        {
            get
            {
                return ((global::CUDA.Short3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Short3.__Internal*)__Instance)->x = value;
            }
        }

        public short Y
        {
            get
            {
                return ((global::CUDA.Short3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Short3.__Internal*)__Instance)->y = value;
            }
        }

        public short Z
        {
            get
            {
                return ((global::CUDA.Short3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Short3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Ushort3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 6)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ushort x;

            [FieldOffset(2)]
            internal ushort y;

            [FieldOffset(4)]
            internal ushort z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ushort3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ushort3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ushort3 __CreateInstance(global::CUDA.Ushort3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ushort3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort3.__Internal));
            *(global::CUDA.Ushort3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ushort3(global::CUDA.Ushort3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ushort3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ushort3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ushort3(global::CUDA.Ushort3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ushort3.__Internal*)__Instance) = *((global::CUDA.Ushort3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ushort3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ushort X
        {
            get
            {
                return ((global::CUDA.Ushort3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ushort3.__Internal*)__Instance)->x = value;
            }
        }

        public ushort Y
        {
            get
            {
                return ((global::CUDA.Ushort3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ushort3.__Internal*)__Instance)->y = value;
            }
        }

        public ushort Z
        {
            get
            {
                return ((global::CUDA.Ushort3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Ushort3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Short4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal short x;

            [FieldOffset(2)]
            internal short y;

            [FieldOffset(4)]
            internal short z;

            [FieldOffset(6)]
            internal short w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0short4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Short4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Short4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Short4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Short4 __CreateInstance(global::CUDA.Short4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Short4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Short4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Short4.__Internal));
            *(global::CUDA.Short4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Short4(global::CUDA.Short4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Short4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Short4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Short4(global::CUDA.Short4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Short4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Short4.__Internal*)__Instance) = *((global::CUDA.Short4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Short4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public short X
        {
            get
            {
                return ((global::CUDA.Short4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Short4.__Internal*)__Instance)->x = value;
            }
        }

        public short Y
        {
            get
            {
                return ((global::CUDA.Short4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Short4.__Internal*)__Instance)->y = value;
            }
        }

        public short Z
        {
            get
            {
                return ((global::CUDA.Short4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Short4.__Internal*)__Instance)->z = value;
            }
        }

        public short W
        {
            get
            {
                return ((global::CUDA.Short4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Short4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Ushort4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ushort x;

            [FieldOffset(2)]
            internal ushort y;

            [FieldOffset(4)]
            internal ushort z;

            [FieldOffset(6)]
            internal ushort w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ushort4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ushort4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ushort4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ushort4 __CreateInstance(global::CUDA.Ushort4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ushort4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ushort4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort4.__Internal));
            *(global::CUDA.Ushort4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ushort4(global::CUDA.Ushort4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ushort4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ushort4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ushort4(global::CUDA.Ushort4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ushort4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ushort4.__Internal*)__Instance) = *((global::CUDA.Ushort4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ushort4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ushort X
        {
            get
            {
                return ((global::CUDA.Ushort4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ushort4.__Internal*)__Instance)->x = value;
            }
        }

        public ushort Y
        {
            get
            {
                return ((global::CUDA.Ushort4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ushort4.__Internal*)__Instance)->y = value;
            }
        }

        public ushort Z
        {
            get
            {
                return ((global::CUDA.Ushort4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Ushort4.__Internal*)__Instance)->z = value;
            }
        }

        public ushort W
        {
            get
            {
                return ((global::CUDA.Ushort4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Ushort4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Int1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0int1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Int1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Int1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Int1 __CreateInstance(global::CUDA.Int1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Int1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Int1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Int1.__Internal));
            *(global::CUDA.Int1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Int1(global::CUDA.Int1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Int1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Int1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Int1(global::CUDA.Int1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Int1.__Internal*)__Instance) = *((global::CUDA.Int1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Int1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Int1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Int1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Uint1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uint1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uint1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uint1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uint1 __CreateInstance(global::CUDA.Uint1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uint1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uint1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint1.__Internal));
            *(global::CUDA.Uint1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uint1(global::CUDA.Uint1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uint1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uint1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uint1(global::CUDA.Uint1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uint1.__Internal*)__Instance) = *((global::CUDA.Uint1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uint1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Uint1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uint1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Int2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0int2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Int2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Int2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Int2 __CreateInstance(global::CUDA.Int2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Int2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Int2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Int2.__Internal));
            *(global::CUDA.Int2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Int2(global::CUDA.Int2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Int2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Int2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Int2(global::CUDA.Int2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Int2.__Internal*)__Instance) = *((global::CUDA.Int2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Int2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Int2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Int2.__Internal*)__Instance)->x = value;
            }
        }

        public int Y
        {
            get
            {
                return ((global::CUDA.Int2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Int2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Uint2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [FieldOffset(4)]
            internal uint y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uint2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uint2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uint2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uint2 __CreateInstance(global::CUDA.Uint2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uint2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uint2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint2.__Internal));
            *(global::CUDA.Uint2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uint2(global::CUDA.Uint2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uint2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uint2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uint2(global::CUDA.Uint2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uint2.__Internal*)__Instance) = *((global::CUDA.Uint2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uint2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Uint2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uint2.__Internal*)__Instance)->x = value;
            }
        }

        public uint Y
        {
            get
            {
                return ((global::CUDA.Uint2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Uint2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Int3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [FieldOffset(8)]
            internal int z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0int3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Int3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Int3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Int3 __CreateInstance(global::CUDA.Int3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Int3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Int3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Int3.__Internal));
            *(global::CUDA.Int3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Int3(global::CUDA.Int3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Int3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Int3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Int3(global::CUDA.Int3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Int3.__Internal*)__Instance) = *((global::CUDA.Int3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Int3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Int3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Int3.__Internal*)__Instance)->x = value;
            }
        }

        public int Y
        {
            get
            {
                return ((global::CUDA.Int3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Int3.__Internal*)__Instance)->y = value;
            }
        }

        public int Z
        {
            get
            {
                return ((global::CUDA.Int3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Int3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Uint3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [FieldOffset(4)]
            internal uint y;

            [FieldOffset(8)]
            internal uint z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uint3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uint3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uint3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uint3 __CreateInstance(global::CUDA.Uint3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uint3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uint3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint3.__Internal));
            *(global::CUDA.Uint3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uint3(global::CUDA.Uint3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uint3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uint3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uint3(global::CUDA.Uint3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uint3.__Internal*)__Instance) = *((global::CUDA.Uint3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uint3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Uint3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uint3.__Internal*)__Instance)->x = value;
            }
        }

        public uint Y
        {
            get
            {
                return ((global::CUDA.Uint3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Uint3.__Internal*)__Instance)->y = value;
            }
        }

        public uint Z
        {
            get
            {
                return ((global::CUDA.Uint3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Uint3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Int4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [FieldOffset(8)]
            internal int z;

            [FieldOffset(12)]
            internal int w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0int4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Int4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Int4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Int4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Int4 __CreateInstance(global::CUDA.Int4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Int4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Int4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Int4.__Internal));
            *(global::CUDA.Int4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Int4(global::CUDA.Int4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Int4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Int4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Int4(global::CUDA.Int4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Int4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Int4.__Internal*)__Instance) = *((global::CUDA.Int4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Int4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Int4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Int4.__Internal*)__Instance)->x = value;
            }
        }

        public int Y
        {
            get
            {
                return ((global::CUDA.Int4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Int4.__Internal*)__Instance)->y = value;
            }
        }

        public int Z
        {
            get
            {
                return ((global::CUDA.Int4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Int4.__Internal*)__Instance)->z = value;
            }
        }

        public int W
        {
            get
            {
                return ((global::CUDA.Int4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Int4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Uint4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [FieldOffset(4)]
            internal uint y;

            [FieldOffset(8)]
            internal uint z;

            [FieldOffset(12)]
            internal uint w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0uint4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Uint4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Uint4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Uint4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Uint4 __CreateInstance(global::CUDA.Uint4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Uint4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Uint4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint4.__Internal));
            *(global::CUDA.Uint4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Uint4(global::CUDA.Uint4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Uint4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Uint4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Uint4(global::CUDA.Uint4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Uint4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Uint4.__Internal*)__Instance) = *((global::CUDA.Uint4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Uint4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Uint4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Uint4.__Internal*)__Instance)->x = value;
            }
        }

        public uint Y
        {
            get
            {
                return ((global::CUDA.Uint4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Uint4.__Internal*)__Instance)->y = value;
            }
        }

        public uint Z
        {
            get
            {
                return ((global::CUDA.Uint4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Uint4.__Internal*)__Instance)->z = value;
            }
        }

        public uint W
        {
            get
            {
                return ((global::CUDA.Uint4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Uint4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Long1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0long1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Long1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Long1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Long1 __CreateInstance(global::CUDA.Long1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Long1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Long1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Long1.__Internal));
            *(global::CUDA.Long1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Long1(global::CUDA.Long1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Long1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Long1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Long1(global::CUDA.Long1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Long1.__Internal*)__Instance) = *((global::CUDA.Long1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Long1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Long1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Long1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Ulong1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulong1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulong1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulong1 __CreateInstance(global::CUDA.Ulong1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulong1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong1.__Internal));
            *(global::CUDA.Ulong1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulong1(global::CUDA.Ulong1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulong1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulong1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulong1(global::CUDA.Ulong1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulong1.__Internal*)__Instance) = *((global::CUDA.Ulong1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulong1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Ulong1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulong1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Long2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0long2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Long2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Long2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Long2 __CreateInstance(global::CUDA.Long2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Long2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Long2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Long2.__Internal));
            *(global::CUDA.Long2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Long2(global::CUDA.Long2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Long2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Long2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Long2(global::CUDA.Long2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Long2.__Internal*)__Instance) = *((global::CUDA.Long2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Long2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Long2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Long2.__Internal*)__Instance)->x = value;
            }
        }

        public int Y
        {
            get
            {
                return ((global::CUDA.Long2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Long2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Ulong2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [FieldOffset(4)]
            internal uint y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulong2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulong2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulong2 __CreateInstance(global::CUDA.Ulong2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulong2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong2.__Internal));
            *(global::CUDA.Ulong2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulong2(global::CUDA.Ulong2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulong2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulong2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulong2(global::CUDA.Ulong2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulong2.__Internal*)__Instance) = *((global::CUDA.Ulong2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulong2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Ulong2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulong2.__Internal*)__Instance)->x = value;
            }
        }

        public uint Y
        {
            get
            {
                return ((global::CUDA.Ulong2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ulong2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Long3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [FieldOffset(8)]
            internal int z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0long3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Long3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Long3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Long3 __CreateInstance(global::CUDA.Long3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Long3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Long3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Long3.__Internal));
            *(global::CUDA.Long3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Long3(global::CUDA.Long3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Long3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Long3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Long3(global::CUDA.Long3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Long3.__Internal*)__Instance) = *((global::CUDA.Long3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Long3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Long3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Long3.__Internal*)__Instance)->x = value;
            }
        }

        public int Y
        {
            get
            {
                return ((global::CUDA.Long3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Long3.__Internal*)__Instance)->y = value;
            }
        }

        public int Z
        {
            get
            {
                return ((global::CUDA.Long3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Long3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Ulong3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [FieldOffset(4)]
            internal uint y;

            [FieldOffset(8)]
            internal uint z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulong3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulong3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulong3 __CreateInstance(global::CUDA.Ulong3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulong3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong3.__Internal));
            *(global::CUDA.Ulong3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulong3(global::CUDA.Ulong3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulong3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulong3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulong3(global::CUDA.Ulong3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulong3.__Internal*)__Instance) = *((global::CUDA.Ulong3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulong3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Ulong3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulong3.__Internal*)__Instance)->x = value;
            }
        }

        public uint Y
        {
            get
            {
                return ((global::CUDA.Ulong3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ulong3.__Internal*)__Instance)->y = value;
            }
        }

        public uint Z
        {
            get
            {
                return ((global::CUDA.Ulong3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Ulong3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Long4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [FieldOffset(8)]
            internal int z;

            [FieldOffset(12)]
            internal int w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0long4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Long4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Long4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Long4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Long4 __CreateInstance(global::CUDA.Long4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Long4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Long4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Long4.__Internal));
            *(global::CUDA.Long4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Long4(global::CUDA.Long4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Long4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Long4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Long4(global::CUDA.Long4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Long4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Long4.__Internal*)__Instance) = *((global::CUDA.Long4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Long4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.Long4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Long4.__Internal*)__Instance)->x = value;
            }
        }

        public int Y
        {
            get
            {
                return ((global::CUDA.Long4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Long4.__Internal*)__Instance)->y = value;
            }
        }

        public int Z
        {
            get
            {
                return ((global::CUDA.Long4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Long4.__Internal*)__Instance)->z = value;
            }
        }

        public int W
        {
            get
            {
                return ((global::CUDA.Long4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Long4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Ulong4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [FieldOffset(4)]
            internal uint y;

            [FieldOffset(8)]
            internal uint z;

            [FieldOffset(12)]
            internal uint w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulong4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulong4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulong4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulong4 __CreateInstance(global::CUDA.Ulong4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulong4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulong4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong4.__Internal));
            *(global::CUDA.Ulong4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulong4(global::CUDA.Ulong4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulong4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulong4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulong4(global::CUDA.Ulong4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulong4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulong4.__Internal*)__Instance) = *((global::CUDA.Ulong4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulong4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Ulong4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulong4.__Internal*)__Instance)->x = value;
            }
        }

        public uint Y
        {
            get
            {
                return ((global::CUDA.Ulong4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ulong4.__Internal*)__Instance)->y = value;
            }
        }

        public uint Z
        {
            get
            {
                return ((global::CUDA.Ulong4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Ulong4.__Internal*)__Instance)->z = value;
            }
        }

        public uint W
        {
            get
            {
                return ((global::CUDA.Ulong4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Ulong4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Float1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal float x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0float1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Float1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Float1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Float1 __CreateInstance(global::CUDA.Float1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Float1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Float1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Float1.__Internal));
            *(global::CUDA.Float1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Float1(global::CUDA.Float1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Float1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Float1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Float1(global::CUDA.Float1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Float1.__Internal*)__Instance) = *((global::CUDA.Float1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Float1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public float X
        {
            get
            {
                return ((global::CUDA.Float1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Float1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Float2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal float x;

            [FieldOffset(4)]
            internal float y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0float2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Float2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Float2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Float2 __CreateInstance(global::CUDA.Float2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Float2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Float2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Float2.__Internal));
            *(global::CUDA.Float2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Float2(global::CUDA.Float2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Float2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Float2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Float2(global::CUDA.Float2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Float2.__Internal*)__Instance) = *((global::CUDA.Float2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Float2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public float X
        {
            get
            {
                return ((global::CUDA.Float2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Float2.__Internal*)__Instance)->x = value;
            }
        }

        public float Y
        {
            get
            {
                return ((global::CUDA.Float2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Float2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Float3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal float x;

            [FieldOffset(4)]
            internal float y;

            [FieldOffset(8)]
            internal float z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0float3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Float3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Float3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Float3 __CreateInstance(global::CUDA.Float3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Float3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Float3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Float3.__Internal));
            *(global::CUDA.Float3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Float3(global::CUDA.Float3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Float3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Float3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Float3(global::CUDA.Float3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Float3.__Internal*)__Instance) = *((global::CUDA.Float3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Float3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public float X
        {
            get
            {
                return ((global::CUDA.Float3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Float3.__Internal*)__Instance)->x = value;
            }
        }

        public float Y
        {
            get
            {
                return ((global::CUDA.Float3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Float3.__Internal*)__Instance)->y = value;
            }
        }

        public float Z
        {
            get
            {
                return ((global::CUDA.Float3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Float3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Float4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal float x;

            [FieldOffset(4)]
            internal float y;

            [FieldOffset(8)]
            internal float z;

            [FieldOffset(12)]
            internal float w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0float4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Float4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Float4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Float4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Float4 __CreateInstance(global::CUDA.Float4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Float4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Float4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Float4.__Internal));
            *(global::CUDA.Float4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Float4(global::CUDA.Float4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Float4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Float4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Float4(global::CUDA.Float4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Float4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Float4.__Internal*)__Instance) = *((global::CUDA.Float4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Float4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public float X
        {
            get
            {
                return ((global::CUDA.Float4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Float4.__Internal*)__Instance)->x = value;
            }
        }

        public float Y
        {
            get
            {
                return ((global::CUDA.Float4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Float4.__Internal*)__Instance)->y = value;
            }
        }

        public float Z
        {
            get
            {
                return ((global::CUDA.Float4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Float4.__Internal*)__Instance)->z = value;
            }
        }

        public float W
        {
            get
            {
                return ((global::CUDA.Float4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Float4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Longlong1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal long x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0longlong1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Longlong1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Longlong1 __CreateInstance(global::CUDA.Longlong1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Longlong1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong1.__Internal));
            *(global::CUDA.Longlong1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Longlong1(global::CUDA.Longlong1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Longlong1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Longlong1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Longlong1(global::CUDA.Longlong1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Longlong1.__Internal*)__Instance) = *((global::CUDA.Longlong1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Longlong1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public long X
        {
            get
            {
                return ((global::CUDA.Longlong1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Longlong1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Ulonglong1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulonglong1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulonglong1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulonglong1 __CreateInstance(global::CUDA.Ulonglong1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulonglong1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong1.__Internal));
            *(global::CUDA.Ulonglong1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulonglong1(global::CUDA.Ulonglong1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulonglong1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulonglong1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulonglong1(global::CUDA.Ulonglong1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulonglong1.__Internal*)__Instance) = *((global::CUDA.Ulonglong1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulonglong1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong X
        {
            get
            {
                return ((global::CUDA.Ulonglong1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulonglong1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Longlong2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal long x;

            [FieldOffset(8)]
            internal long y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0longlong2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Longlong2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Longlong2 __CreateInstance(global::CUDA.Longlong2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Longlong2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong2.__Internal));
            *(global::CUDA.Longlong2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Longlong2(global::CUDA.Longlong2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Longlong2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Longlong2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Longlong2(global::CUDA.Longlong2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Longlong2.__Internal*)__Instance) = *((global::CUDA.Longlong2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Longlong2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public long X
        {
            get
            {
                return ((global::CUDA.Longlong2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Longlong2.__Internal*)__Instance)->x = value;
            }
        }

        public long Y
        {
            get
            {
                return ((global::CUDA.Longlong2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Longlong2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Ulonglong2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong x;

            [FieldOffset(8)]
            internal ulong y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulonglong2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulonglong2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulonglong2 __CreateInstance(global::CUDA.Ulonglong2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulonglong2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong2.__Internal));
            *(global::CUDA.Ulonglong2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulonglong2(global::CUDA.Ulonglong2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulonglong2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulonglong2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulonglong2(global::CUDA.Ulonglong2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulonglong2.__Internal*)__Instance) = *((global::CUDA.Ulonglong2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulonglong2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong X
        {
            get
            {
                return ((global::CUDA.Ulonglong2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulonglong2.__Internal*)__Instance)->x = value;
            }
        }

        public ulong Y
        {
            get
            {
                return ((global::CUDA.Ulonglong2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ulonglong2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Longlong3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal long x;

            [FieldOffset(8)]
            internal long y;

            [FieldOffset(16)]
            internal long z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0longlong3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Longlong3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Longlong3 __CreateInstance(global::CUDA.Longlong3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Longlong3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong3.__Internal));
            *(global::CUDA.Longlong3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Longlong3(global::CUDA.Longlong3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Longlong3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Longlong3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Longlong3(global::CUDA.Longlong3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Longlong3.__Internal*)__Instance) = *((global::CUDA.Longlong3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Longlong3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public long X
        {
            get
            {
                return ((global::CUDA.Longlong3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Longlong3.__Internal*)__Instance)->x = value;
            }
        }

        public long Y
        {
            get
            {
                return ((global::CUDA.Longlong3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Longlong3.__Internal*)__Instance)->y = value;
            }
        }

        public long Z
        {
            get
            {
                return ((global::CUDA.Longlong3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Longlong3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Ulonglong3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong x;

            [FieldOffset(8)]
            internal ulong y;

            [FieldOffset(16)]
            internal ulong z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulonglong3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulonglong3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulonglong3 __CreateInstance(global::CUDA.Ulonglong3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulonglong3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong3.__Internal));
            *(global::CUDA.Ulonglong3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulonglong3(global::CUDA.Ulonglong3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulonglong3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulonglong3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulonglong3(global::CUDA.Ulonglong3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulonglong3.__Internal*)__Instance) = *((global::CUDA.Ulonglong3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulonglong3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong X
        {
            get
            {
                return ((global::CUDA.Ulonglong3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulonglong3.__Internal*)__Instance)->x = value;
            }
        }

        public ulong Y
        {
            get
            {
                return ((global::CUDA.Ulonglong3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ulonglong3.__Internal*)__Instance)->y = value;
            }
        }

        public ulong Z
        {
            get
            {
                return ((global::CUDA.Ulonglong3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Ulonglong3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Longlong4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal long x;

            [FieldOffset(8)]
            internal long y;

            [FieldOffset(16)]
            internal long z;

            [FieldOffset(24)]
            internal long w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0longlong4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Longlong4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Longlong4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Longlong4 __CreateInstance(global::CUDA.Longlong4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Longlong4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Longlong4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong4.__Internal));
            *(global::CUDA.Longlong4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Longlong4(global::CUDA.Longlong4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Longlong4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Longlong4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Longlong4(global::CUDA.Longlong4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Longlong4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Longlong4.__Internal*)__Instance) = *((global::CUDA.Longlong4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Longlong4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public long X
        {
            get
            {
                return ((global::CUDA.Longlong4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Longlong4.__Internal*)__Instance)->x = value;
            }
        }

        public long Y
        {
            get
            {
                return ((global::CUDA.Longlong4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Longlong4.__Internal*)__Instance)->y = value;
            }
        }

        public long Z
        {
            get
            {
                return ((global::CUDA.Longlong4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Longlong4.__Internal*)__Instance)->z = value;
            }
        }

        public long W
        {
            get
            {
                return ((global::CUDA.Longlong4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Longlong4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Ulonglong4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong x;

            [FieldOffset(8)]
            internal ulong y;

            [FieldOffset(16)]
            internal ulong z;

            [FieldOffset(24)]
            internal ulong w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0ulonglong4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Ulonglong4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Ulonglong4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Ulonglong4 __CreateInstance(global::CUDA.Ulonglong4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Ulonglong4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Ulonglong4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong4.__Internal));
            *(global::CUDA.Ulonglong4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Ulonglong4(global::CUDA.Ulonglong4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Ulonglong4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Ulonglong4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Ulonglong4(global::CUDA.Ulonglong4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Ulonglong4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Ulonglong4.__Internal*)__Instance) = *((global::CUDA.Ulonglong4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Ulonglong4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong X
        {
            get
            {
                return ((global::CUDA.Ulonglong4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Ulonglong4.__Internal*)__Instance)->x = value;
            }
        }

        public ulong Y
        {
            get
            {
                return ((global::CUDA.Ulonglong4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Ulonglong4.__Internal*)__Instance)->y = value;
            }
        }

        public ulong Z
        {
            get
            {
                return ((global::CUDA.Ulonglong4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Ulonglong4.__Internal*)__Instance)->z = value;
            }
        }

        public ulong W
        {
            get
            {
                return ((global::CUDA.Ulonglong4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Ulonglong4.__Internal*)__Instance)->w = value;
            }
        }
    }

    public unsafe partial class Double1 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 8)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0double1@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double1> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double1>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Double1 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Double1(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Double1 __CreateInstance(global::CUDA.Double1.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Double1(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Double1.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Double1.__Internal));
            *(global::CUDA.Double1.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Double1(global::CUDA.Double1.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Double1(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Double1()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Double1(global::CUDA.Double1 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double1.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Double1.__Internal*)__Instance) = *((global::CUDA.Double1.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Double1 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double X
        {
            get
            {
                return ((global::CUDA.Double1.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Double1.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Double2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 16)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double x;

            [FieldOffset(8)]
            internal double y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0double2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Double2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Double2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Double2 __CreateInstance(global::CUDA.Double2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Double2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Double2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Double2.__Internal));
            *(global::CUDA.Double2.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Double2(global::CUDA.Double2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Double2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Double2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Double2(global::CUDA.Double2 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Double2.__Internal*)__Instance) = *((global::CUDA.Double2.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Double2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double X
        {
            get
            {
                return ((global::CUDA.Double2.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Double2.__Internal*)__Instance)->x = value;
            }
        }

        public double Y
        {
            get
            {
                return ((global::CUDA.Double2.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Double2.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Double3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double x;

            [FieldOffset(8)]
            internal double y;

            [FieldOffset(16)]
            internal double z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0double3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Double3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Double3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Double3 __CreateInstance(global::CUDA.Double3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Double3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Double3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Double3.__Internal));
            *(global::CUDA.Double3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Double3(global::CUDA.Double3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Double3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Double3()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Double3(global::CUDA.Double3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Double3.__Internal*)__Instance) = *((global::CUDA.Double3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Double3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double X
        {
            get
            {
                return ((global::CUDA.Double3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Double3.__Internal*)__Instance)->x = value;
            }
        }

        public double Y
        {
            get
            {
                return ((global::CUDA.Double3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Double3.__Internal*)__Instance)->y = value;
            }
        }

        public double Z
        {
            get
            {
                return ((global::CUDA.Double3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Double3.__Internal*)__Instance)->z = value;
            }
        }
    }

    public unsafe partial class Double4 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal double x;

            [FieldOffset(8)]
            internal double y;

            [FieldOffset(16)]
            internal double z;

            [FieldOffset(24)]
            internal double w;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0double4@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double4> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Double4>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Double4 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Double4(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Double4 __CreateInstance(global::CUDA.Double4.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Double4(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Double4.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Double4.__Internal));
            *(global::CUDA.Double4.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Double4(global::CUDA.Double4.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Double4(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Double4()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Double4(global::CUDA.Double4 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Double4.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Double4.__Internal*)__Instance) = *((global::CUDA.Double4.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Double4 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public double X
        {
            get
            {
                return ((global::CUDA.Double4.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Double4.__Internal*)__Instance)->x = value;
            }
        }

        public double Y
        {
            get
            {
                return ((global::CUDA.Double4.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Double4.__Internal*)__Instance)->y = value;
            }
        }

        public double Z
        {
            get
            {
                return ((global::CUDA.Double4.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Double4.__Internal*)__Instance)->z = value;
            }
        }

        public double W
        {
            get
            {
                return ((global::CUDA.Double4.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.Double4.__Internal*)__Instance)->w = value;
            }
        }
    }

    /// <summary>
    /// <para>*****************************************************************************</para>
    /// <para>*</para>
    /// <para>*</para>
    /// <para>*</para>
    /// <para>*****************************************************************************</para>
    /// </summary>
    public unsafe partial class Dim3 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 12)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal uint x;

            [FieldOffset(4)]
            internal uint y;

            [FieldOffset(8)]
            internal uint z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0dim3@@QEAA@III@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, uint vx, uint vy, uint vz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0dim3@@QEAA@Uuint3@@@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, global::CUDA.Uint3.__Internal v);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0dim3@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??Bdim3@@QEAA?AUuint3@@XZ")]
            internal static extern void OperatorConversion(global::System.IntPtr instance, global::System.IntPtr @return);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Dim3> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Dim3>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Dim3 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Dim3(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Dim3 __CreateInstance(global::CUDA.Dim3.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Dim3(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Dim3.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Dim3.__Internal));
            *(global::CUDA.Dim3.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Dim3(global::CUDA.Dim3.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Dim3(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Dim3(uint vx, uint vy, uint vz)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Dim3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor((__Instance + __PointerAdjustment), vx, vy, vz);
        }

        public Dim3(global::CUDA.Uint3 v)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Dim3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            var __arg0 = ReferenceEquals(v, null) ? new global::CUDA.Uint3.__Internal() : *(global::CUDA.Uint3.__Internal*)v.__Instance;
            __Internal.ctor((__Instance + __PointerAdjustment), __arg0);
        }

        public Dim3(global::CUDA.Dim3 _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Dim3.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Dim3.__Internal*)__Instance) = *((global::CUDA.Dim3.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Dim3 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static implicit operator global::CUDA.Uint3(global::CUDA.Dim3 __op)
        {
            if (ReferenceEquals(__op, null))
                throw new global::System.ArgumentNullException("__op", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = __op.__Instance;
            var __ret = new global::CUDA.Uint3.__Internal();
            __Internal.OperatorConversion(__arg0, new IntPtr(&__ret));
            return global::CUDA.Uint3.__CreateInstance(__ret);
        }

        public static implicit operator global::CUDA.Dim3(global::CUDA.Uint3 v)
        {
            return new global::CUDA.Dim3(v);
        }

        public uint X
        {
            get
            {
                return ((global::CUDA.Dim3.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Dim3.__Internal*)__Instance)->x = value;
            }
        }

        public uint Y
        {
            get
            {
                return ((global::CUDA.Dim3.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Dim3.__Internal*)__Instance)->y = value;
            }
        }

        public uint Z
        {
            get
            {
                return ((global::CUDA.Dim3.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.Dim3.__Internal*)__Instance)->z = value;
            }
        }
    }

    /// <summary>CUDA error types</summary>
    public enum CudaError
    {
        /// <summary>
        /// <para>The API call returned with no errors. In the case of query calls, this</para>
        /// <para>can also mean that the operation being queried is complete (see</para>
        /// <para>::cudaEventQuery() and ::cudaStreamQuery()).</para>
        /// </summary>
        CudaSuccess = 0,
        /// <summary>
        /// <para>The device function being invoked (usually via ::cudaLaunchKernel()) was not</para>
        /// <para>previously configured via the ::cudaConfigureCall() function.</para>
        /// </summary>
        CudaErrorMissingConfiguration = 1,
        /// <summary>
        /// <para>The API call failed because it was unable to allocate enough memory to</para>
        /// <para>perform the requested operation.</para>
        /// </summary>
        CudaErrorMemoryAllocation = 2,
        /// <summary>
        /// <para>The API call failed because the CUDA driver and runtime could not be</para>
        /// <para>initialized.</para>
        /// </summary>
        CudaErrorInitializationError = 3,
        /// <summary>
        /// <para>An exception occurred on the device while executing a kernel. Common</para>
        /// <para>causes include dereferencing an invalid device pointer and accessing</para>
        /// <para>out of bounds shared memory. The device cannot be used until</para>
        /// <para>::cudaThreadExit() is called. All existing device memory allocations</para>
        /// <para>are invalid and must be reconstructed if the program is to continue</para>
        /// <para>using CUDA.</para>
        /// </summary>
        CudaErrorLaunchFailure = 4,
        /// <summary>
        /// <para>This indicated that a previous kernel launch failed. This was previously</para>
        /// <para>used for device emulation of kernel launches.</para>
        /// </summary>
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 3.1. Device emulation mode was</para>
        /// <para>removed with the CUDA 3.1 release.</para>
        /// </remarks>
        CudaErrorPriorLaunchFailure = 5,
        /// <summary>
        /// <para>This indicates that the device kernel took too long to execute. This can</para>
        /// <para>only occur if timeouts are enabled - see the device property</para>
        /// </summary>
        /// <remarks>
        /// <para>for more information.</para>
        /// <para>This leaves the process in an inconsistent state and any further CUDA work</para>
        /// <para>will return the same error. To continue using CUDA, the process must be terminated</para>
        /// <para>and relaunched.</para>
        /// </remarks>
        CudaErrorLaunchTimeout = 6,
        /// <summary>
        /// <para>This indicates that a launch did not occur because it did not have</para>
        /// <para>appropriate resources. Although this error is similar to</para>
        /// <para>::cudaErrorInvalidConfiguration, this error usually indicates that the</para>
        /// <para>user has attempted to pass too many arguments to the device kernel, or the</para>
        /// <para>kernel launch specifies too many threads for the kernel's register count.</para>
        /// </summary>
        CudaErrorLaunchOutOfResources = 7,
        /// <summary>
        /// <para>The requested device function does not exist or is not compiled for the</para>
        /// <para>proper device architecture.</para>
        /// </summary>
        CudaErrorInvalidDeviceFunction = 8,
        /// <summary>
        /// <para>This indicates that a kernel launch is requesting resources that can</para>
        /// <para>never be satisfied by the current device. Requesting more shared memory</para>
        /// <para>per block than the device supports will trigger this error, as will</para>
        /// <para>requesting too many threads or blocks. See ::cudaDeviceProp for more</para>
        /// <para>device limitations.</para>
        /// </summary>
        CudaErrorInvalidConfiguration = 9,
        /// <summary>
        /// <para>This indicates that the device ordinal supplied by the user does not</para>
        /// <para>correspond to a valid CUDA device.</para>
        /// </summary>
        CudaErrorInvalidDevice = 10,
        /// <summary>
        /// <para>This indicates that one or more of the parameters passed to the API call</para>
        /// <para>is not within an acceptable range of values.</para>
        /// </summary>
        CudaErrorInvalidValue = 11,
        /// <summary>
        /// <para>This indicates that one or more of the pitch-related parameters passed</para>
        /// <para>to the API call is not within the acceptable range for pitch.</para>
        /// </summary>
        CudaErrorInvalidPitchValue = 12,
        /// <summary>
        /// <para>This indicates that the symbol name/identifier passed to the API call</para>
        /// <para>is not a valid name or identifier.</para>
        /// </summary>
        CudaErrorInvalidSymbol = 13,
        /// <summary>This indicates that the buffer object could not be mapped.</summary>
        CudaErrorMapBufferObjectFailed = 14,
        /// <summary>This indicates that the buffer object could not be unmapped.</summary>
        CudaErrorUnmapBufferObjectFailed = 15,
        /// <summary>
        /// <para>This indicates that at least one host pointer passed to the API call is</para>
        /// <para>not a valid host pointer.</para>
        /// </summary>
        CudaErrorInvalidHostPointer = 16,
        /// <summary>
        /// <para>This indicates that at least one device pointer passed to the API call is</para>
        /// <para>not a valid device pointer.</para>
        /// </summary>
        CudaErrorInvalidDevicePointer = 17,
        /// <summary>
        /// <para>This indicates that the texture passed to the API call is not a valid</para>
        /// <para>texture.</para>
        /// </summary>
        CudaErrorInvalidTexture = 18,
        /// <summary>
        /// <para>This indicates that the texture binding is not valid. This occurs if you</para>
        /// <para>call ::cudaGetTextureAlignmentOffset() with an unbound texture.</para>
        /// </summary>
        CudaErrorInvalidTextureBinding = 19,
        /// <summary>
        /// <para>This indicates that the channel descriptor passed to the API call is not</para>
        /// <para>valid. This occurs if the format is not one of the formats specified by</para>
        /// <para>::cudaChannelFormatKind, or if one of the dimensions is invalid.</para>
        /// </summary>
        CudaErrorInvalidChannelDescriptor = 20,
        /// <summary>
        /// <para>This indicates that the direction of the memcpy passed to the API call is</para>
        /// <para>not one of the types specified by ::cudaMemcpyKind.</para>
        /// </summary>
        CudaErrorInvalidMemcpyDirection = 21,
        /// <summary>
        /// <para>This indicated that the user has taken the address of a constant variable,</para>
        /// <para>which was forbidden up until the CUDA 3.1 release.</para>
        /// </summary>
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 3.1. Variables in constant</para>
        /// <para>memory may now have their address taken by the runtime via</para>
        /// <para>::cudaGetSymbolAddress().</para>
        /// </remarks>
        CudaErrorAddressOfConstant = 22,
        /// <summary>
        /// <para>This indicated that a texture fetch was not able to be performed.</para>
        /// <para>This was previously used for device emulation of texture operations.</para>
        /// </summary>
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 3.1. Device emulation mode was</para>
        /// <para>removed with the CUDA 3.1 release.</para>
        /// </remarks>
        CudaErrorTextureFetchFailed = 23,
        /// <summary>
        /// <para>This indicated that a texture was not bound for access.</para>
        /// <para>This was previously used for device emulation of texture operations.</para>
        /// </summary>
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 3.1. Device emulation mode was</para>
        /// <para>removed with the CUDA 3.1 release.</para>
        /// </remarks>
        CudaErrorTextureNotBound = 24,
        /// <summary>
        /// <para>This indicated that a synchronization operation had failed.</para>
        /// <para>This was previously used for some device emulation functions.</para>
        /// </summary>
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 3.1. Device emulation mode was</para>
        /// <para>removed with the CUDA 3.1 release.</para>
        /// </remarks>
        CudaErrorSynchronizationError = 25,
        /// <summary>
        /// <para>This indicates that a non-float texture was being accessed with linear</para>
        /// <para>filtering. This is not supported by CUDA.</para>
        /// </summary>
        CudaErrorInvalidFilterSetting = 26,
        /// <summary>
        /// <para>This indicates that an attempt was made to read a non-float texture as a</para>
        /// <para>normalized float. This is not supported by CUDA.</para>
        /// </summary>
        CudaErrorInvalidNormSetting = 27,
        /// <summary>Mixing of device and device emulation code was not allowed.</summary>
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 3.1. Device emulation mode was</para>
        /// <para>removed with the CUDA 3.1 release.</para>
        /// </remarks>
        CudaErrorMixedDeviceExecution = 28,
        /// <summary>
        /// <para>This indicates that a CUDA Runtime API call cannot be executed because</para>
        /// <para>it is being called during process shut down, at a point in time after</para>
        /// <para>CUDA driver has been unloaded.</para>
        /// </summary>
        CudaErrorCudartUnloading = 29,
        /// <summary>This indicates that an unknown internal error has occurred.</summary>
        CudaErrorUnknown = 30,
        /// <summary>
        /// <para>This indicates that the API call is not yet implemented. Production</para>
        /// <para>releases of CUDA will never return this error.</para>
        /// </summary>
        /// <remarks>This error return is deprecated as of CUDA 4.1.</remarks>
        CudaErrorNotYetImplemented = 31,
        /// <summary>
        /// <para>This indicated that an emulated device pointer exceeded the 32-bit address</para>
        /// <para>range.</para>
        /// </summary>
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 3.1. Device emulation mode was</para>
        /// <para>removed with the CUDA 3.1 release.</para>
        /// </remarks>
        CudaErrorMemoryValueTooLarge = 32,
        /// <summary>
        /// <para>This indicates that a resource handle passed to the API call was not</para>
        /// <para>valid. Resource handles are opaque types like ::cudaStream_t and</para>
        /// <para>::cudaEvent_t.</para>
        /// </summary>
        CudaErrorInvalidResourceHandle = 33,
        /// <summary>
        /// <para>This indicates that asynchronous operations issued previously have not</para>
        /// <para>completed yet. This result is not actually an error, but must be indicated</para>
        /// <para>differently than ::cudaSuccess (which indicates completion). Calls that</para>
        /// <para>may return this value include ::cudaEventQuery() and ::cudaStreamQuery().</para>
        /// </summary>
        CudaErrorNotReady = 34,
        /// <summary>
        /// <para>This indicates that the installed NVIDIA CUDA driver is older than the</para>
        /// <para>CUDA runtime library. This is not a supported configuration. Users should</para>
        /// <para>install an updated NVIDIA display driver to allow the application to run.</para>
        /// </summary>
        CudaErrorInsufficientDriver = 35,
        /// <summary>
        /// <para>This indicates that the user has called ::cudaSetValidDevices(),</para>
        /// <para>::cudaSetDeviceFlags(), ::cudaD3D9SetDirect3DDevice(),</para>
        /// <para>::cudaD3D10SetDirect3DDevice, ::cudaD3D11SetDirect3DDevice(), or</para>
        /// <para>::cudaVDPAUSetVDPAUDevice() after initializing the CUDA runtime by</para>
        /// <para>calling non-device management operations (allocating memory and</para>
        /// <para>launching kernels are examples of non-device management operations).</para>
        /// <para>This error can also be returned if using runtime/driver</para>
        /// <para>interoperability and there is an existing ::CUcontext active on the</para>
        /// <para>host thread.</para>
        /// </summary>
        CudaErrorSetOnActiveProcess = 36,
        /// <summary>
        /// <para>This indicates that the surface passed to the API call is not a valid</para>
        /// <para>surface.</para>
        /// </summary>
        CudaErrorInvalidSurface = 37,
        /// <summary>
        /// <para>This indicates that no CUDA-capable devices were detected by the installed</para>
        /// <para>CUDA driver.</para>
        /// </summary>
        CudaErrorNoDevice = 38,
        /// <summary>
        /// <para>This indicates that an uncorrectable ECC error was detected during</para>
        /// <para>execution.</para>
        /// </summary>
        CudaErrorECCUncorrectable = 39,
        /// <summary>This indicates that a link to a shared object failed to resolve.</summary>
        CudaErrorSharedObjectSymbolNotFound = 40,
        /// <summary>This indicates that initialization of a shared object failed.</summary>
        CudaErrorSharedObjectInitFailed = 41,
        /// <summary>
        /// <para>This indicates that the ::cudaLimit passed to the API call is not</para>
        /// <para>supported by the active device.</para>
        /// </summary>
        CudaErrorUnsupportedLimit = 42,
        /// <summary>
        /// <para>This indicates that multiple global or constant variables (across separate</para>
        /// <para>CUDA source files in the application) share the same string name.</para>
        /// </summary>
        CudaErrorDuplicateVariableName = 43,
        /// <summary>
        /// <para>This indicates that multiple textures (across separate CUDA source</para>
        /// <para>files in the application) share the same string name.</para>
        /// </summary>
        CudaErrorDuplicateTextureName = 44,
        /// <summary>
        /// <para>This indicates that multiple surfaces (across separate CUDA source</para>
        /// <para>files in the application) share the same string name.</para>
        /// </summary>
        CudaErrorDuplicateSurfaceName = 45,
        /// <summary>
        /// <para>This indicates that all CUDA devices are busy or unavailable at the current</para>
        /// <para>time. Devices are often busy/unavailable due to use of</para>
        /// <para>::cudaComputeModeExclusive, ::cudaComputeModeProhibited or when long</para>
        /// <para>running CUDA kernels have filled up the GPU and are blocking new work</para>
        /// <para>from starting. They can also be unavailable due to memory constraints</para>
        /// <para>on a device that already has active CUDA work being performed.</para>
        /// </summary>
        CudaErrorDevicesUnavailable = 46,
        /// <summary>This indicates that the device kernel image is invalid.</summary>
        CudaErrorInvalidKernelImage = 47,
        /// <summary>
        /// <para>This indicates that there is no kernel image available that is suitable</para>
        /// <para>for the device. This can occur when a user specifies code generation</para>
        /// <para>options for a particular CUDA source file that do not include the</para>
        /// <para>corresponding device configuration.</para>
        /// </summary>
        CudaErrorNoKernelImageForDevice = 48,
        /// <summary>
        /// <para>This indicates that the current context is not compatible with this</para>
        /// <para>the CUDA Runtime. This can only occur if you are using CUDA</para>
        /// <para>Runtime/Driver interoperability and have created an existing Driver</para>
        /// <para>context using the driver API. The Driver context may be incompatible</para>
        /// <para>either because the Driver context was created using an older version</para>
        /// <para>of the API, because the Runtime API call expects a primary driver</para>
        /// <para>context and the Driver context is not primary, or because the Driver</para>
        /// <para>context has been destroyed. Please see</para>
        /// </summary>
        /// <remarks>with the CUDA Driver API&quot; for more information.</remarks>
        CudaErrorIncompatibleDriverContext = 49,
        /// <summary>
        /// <para>This error indicates that a call to ::cudaDeviceEnablePeerAccess() is</para>
        /// <para>trying to re-enable peer addressing on from a context which has already</para>
        /// <para>had peer addressing enabled.</para>
        /// </summary>
        CudaErrorPeerAccessAlreadyEnabled = 50,
        /// <summary>
        /// <para>This error indicates that ::cudaDeviceDisablePeerAccess() is trying to</para>
        /// <para>disable peer addressing which has not been enabled yet via</para>
        /// <para>::cudaDeviceEnablePeerAccess().</para>
        /// </summary>
        CudaErrorPeerAccessNotEnabled = 51,
        /// <summary>
        /// <para>This indicates that a call tried to access an exclusive-thread device that</para>
        /// <para>is already in use by a different thread.</para>
        /// </summary>
        CudaErrorDeviceAlreadyInUse = 54,
        /// <summary>
        /// <para>This indicates profiler is not initialized for this run. This can</para>
        /// <para>happen when the application is running with external profiling tools</para>
        /// <para>like visual profiler.</para>
        /// </summary>
        CudaErrorProfilerDisabled = 55,
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 5.0. It is no longer an error</para>
        /// <para>to attempt to enable/disable the profiling via ::cudaProfilerStart or</para>
        /// <para>::cudaProfilerStop without initialization.</para>
        /// </remarks>
        CudaErrorProfilerNotInitialized = 56,
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 5.0. It is no longer an error</para>
        /// <para>to call cudaProfilerStart() when profiling is already enabled.</para>
        /// </remarks>
        CudaErrorProfilerAlreadyStarted = 57,
        /// <remarks>
        /// <para>This error return is deprecated as of CUDA 5.0. It is no longer an error</para>
        /// <para>to call cudaProfilerStop() when profiling is already disabled.</para>
        /// </remarks>
        CudaErrorProfilerAlreadyStopped = 58,
        /// <summary>
        /// <para>An assert triggered in device code during kernel execution. The device</para>
        /// <para>cannot be used again until ::cudaThreadExit() is called. All existing</para>
        /// <para>allocations are invalid and must be reconstructed if the program is to</para>
        /// <para>continue using CUDA.</para>
        /// </summary>
        CudaErrorAssert = 59,
        /// <summary>
        /// <para>This error indicates that the hardware resources required to enable</para>
        /// <para>peer access have been exhausted for one or more of the devices</para>
        /// <para>passed to ::cudaEnablePeerAccess().</para>
        /// </summary>
        CudaErrorTooManyPeers = 60,
        /// <summary>
        /// <para>This error indicates that the memory range passed to ::cudaHostRegister()</para>
        /// <para>has already been registered.</para>
        /// </summary>
        CudaErrorHostMemoryAlreadyRegistered = 61,
        /// <summary>
        /// <para>This error indicates that the pointer passed to ::cudaHostUnregister()</para>
        /// <para>does not correspond to any currently registered memory region.</para>
        /// </summary>
        CudaErrorHostMemoryNotRegistered = 62,
        /// <summary>This error indicates that an OS call failed.</summary>
        CudaErrorOperatingSystem = 63,
        /// <summary>
        /// <para>This error indicates that P2P access is not supported across the given</para>
        /// <para>devices.</para>
        /// </summary>
        CudaErrorPeerAccessUnsupported = 64,
        /// <summary>
        /// <para>This error indicates that a device runtime grid launch did not occur</para>
        /// <para>because the depth of the child grid would exceed the maximum supported</para>
        /// <para>number of nested grid launches.</para>
        /// </summary>
        CudaErrorLaunchMaxDepthExceeded = 65,
        /// <summary>
        /// <para>This error indicates that a grid launch did not occur because the kernel</para>
        /// <para>uses file-scoped textures which are unsupported by the device runtime.</para>
        /// <para>Kernels launched via the device runtime only support textures created with</para>
        /// <para>the Texture Object API's.</para>
        /// </summary>
        CudaErrorLaunchFileScopedTex = 66,
        /// <summary>
        /// <para>This error indicates that a grid launch did not occur because the kernel</para>
        /// <para>uses file-scoped surfaces which are unsupported by the device runtime.</para>
        /// <para>Kernels launched via the device runtime only support surfaces created with</para>
        /// <para>the Surface Object API's.</para>
        /// </summary>
        CudaErrorLaunchFileScopedSurf = 67,
        /// <summary>
        /// <para>This error indicates that a call to ::cudaDeviceSynchronize made from</para>
        /// <para>the device runtime failed because the call was made at grid depth greater</para>
        /// <para>than than either the default (2 levels of grids) or user specified device</para>
        /// <para>limit ::cudaLimitDevRuntimeSyncDepth. To be able to synchronize on</para>
        /// <para>launched grids at a greater depth successfully, the maximum nested</para>
        /// <para>depth at which ::cudaDeviceSynchronize will be called must be specified</para>
        /// <para>with the ::cudaLimitDevRuntimeSyncDepth limit to the ::cudaDeviceSetLimit</para>
        /// <para>api before the host-side launch of a kernel using the device runtime.</para>
        /// <para>Keep in mind that additional levels of sync depth require the runtime</para>
        /// <para>to reserve large amounts of device memory that cannot be used for</para>
        /// <para>user allocations.</para>
        /// </summary>
        CudaErrorSyncDepthExceeded = 68,
        /// <summary>
        /// <para>This error indicates that a device runtime grid launch failed because</para>
        /// <para>the launch would exceed the limit ::cudaLimitDevRuntimePendingLaunchCount.</para>
        /// <para>For this launch to proceed successfully, ::cudaDeviceSetLimit must be</para>
        /// <para>called to set the ::cudaLimitDevRuntimePendingLaunchCount to be higher</para>
        /// <para>than the upper bound of outstanding launches that can be issued to the</para>
        /// <para>device runtime. Keep in mind that raising the limit of pending device</para>
        /// <para>runtime launches will require the runtime to reserve device memory that</para>
        /// <para>cannot be used for user allocations.</para>
        /// </summary>
        CudaErrorLaunchPendingCountExceeded = 69,
        /// <summary>This error indicates the attempted operation is not permitted.</summary>
        CudaErrorNotPermitted = 70,
        /// <summary>
        /// <para>This error indicates the attempted operation is not supported</para>
        /// <para>on the current system or device.</para>
        /// </summary>
        CudaErrorNotSupported = 71,
        /// <summary>
        /// <para>Device encountered an error in the call stack during kernel execution,</para>
        /// <para>possibly due to stack corruption or exceeding the stack size limit.</para>
        /// <para>This leaves the process in an inconsistent state and any further CUDA work</para>
        /// <para>will return the same error. To continue using CUDA, the process must be terminated</para>
        /// <para>and relaunched.</para>
        /// </summary>
        CudaErrorHardwareStackError = 72,
        /// <summary>
        /// <para>The device encountered an illegal instruction during kernel execution</para>
        /// <para>This leaves the process in an inconsistent state and any further CUDA work</para>
        /// <para>will return the same error. To continue using CUDA, the process must be terminated</para>
        /// <para>and relaunched.</para>
        /// </summary>
        CudaErrorIllegalInstruction = 73,
        /// <summary>
        /// <para>The device encountered a load or store instruction</para>
        /// <para>on a memory address which is not aligned.</para>
        /// <para>This leaves the process in an inconsistent state and any further CUDA work</para>
        /// <para>will return the same error. To continue using CUDA, the process must be terminated</para>
        /// <para>and relaunched.</para>
        /// </summary>
        CudaErrorMisalignedAddress = 74,
        /// <summary>
        /// <para>While executing a kernel, the device encountered an instruction</para>
        /// <para>which can only operate on memory locations in certain address spaces</para>
        /// <para>(global, shared, or local), but was supplied a memory address not</para>
        /// <para>belonging to an allowed address space.</para>
        /// <para>This leaves the process in an inconsistent state and any further CUDA work</para>
        /// <para>will return the same error. To continue using CUDA, the process must be terminated</para>
        /// <para>and relaunched.</para>
        /// </summary>
        CudaErrorInvalidAddressSpace = 75,
        /// <summary>
        /// <para>The device encountered an invalid program counter.</para>
        /// <para>This leaves the process in an inconsistent state and any further CUDA work</para>
        /// <para>will return the same error. To continue using CUDA, the process must be terminated</para>
        /// <para>and relaunched.</para>
        /// </summary>
        CudaErrorInvalidPc = 76,
        /// <summary>
        /// <para>The device encountered a load or store instruction on an invalid memory address.</para>
        /// <para>This leaves the process in an inconsistent state and any further CUDA work</para>
        /// <para>will return the same error. To continue using CUDA, the process must be terminated</para>
        /// <para>and relaunched.</para>
        /// </summary>
        CudaErrorIllegalAddress = 77,
        /// <summary>
        /// <para>A PTX compilation failed. The runtime may fall back to compiling PTX if</para>
        /// <para>an application does not contain a suitable binary for the current device.</para>
        /// </summary>
        CudaErrorInvalidPtx = 78,
        /// <summary>This indicates an error with the OpenGL or DirectX context.</summary>
        CudaErrorInvalidGraphicsContext = 79,
        /// <summary>
        /// <para>This indicates that an uncorrectable NVLink error was detected during the</para>
        /// <para>execution.</para>
        /// </summary>
        CudaErrorNvlinkUncorrectable = 80,
        /// <summary>
        /// <para>This indicates that the PTX JIT compiler library was not found. The JIT Compiler</para>
        /// <para>library is used for PTX compilation. The runtime may fall back to compiling PTX</para>
        /// <para>if an application does not contain a suitable binary for the current device.</para>
        /// </summary>
        CudaErrorJitCompilerNotFound = 81,
        /// <summary>
        /// <para>This error indicates that the number of blocks launched per grid for a kernel that was</para>
        /// <para>launched via either ::cudaLaunchCooperativeKernel or ::cudaLaunchCooperativeKernelMultiDevice</para>
        /// <para>exceeds the maximum number of blocks as allowed by ::cudaOccupancyMaxActiveBlocksPerMultiprocessor</para>
        /// <para>or ::cudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags times the number of multiprocessors</para>
        /// <para>as specified by the device attribute ::cudaDevAttrMultiProcessorCount.</para>
        /// </summary>
        CudaErrorCooperativeLaunchTooLarge = 82,
        /// <summary>This indicates an internal startup failure in the CUDA runtime.</summary>
        CudaErrorStartupFailure = 127,
        /// <summary>
        /// <para>Any unhandled CUDA driver error is added to this value and returned via</para>
        /// <para>the runtime. Production releases of CUDA should not return such errors.</para>
        /// </summary>
        /// <remarks>This error return is deprecated as of CUDA 4.1.</remarks>
        CudaErrorApiFailureBase = 10000
    }

    /// <summary>Channel format kind</summary>
    public enum CudaChannelFormatKind
    {
        /// <summary>Signed channel format</summary>
        CudaChannelFormatKindSigned = 0,
        /// <summary>Unsigned channel format</summary>
        CudaChannelFormatKindUnsigned = 1,
        /// <summary>Float channel format</summary>
        CudaChannelFormatKindFloat = 2,
        /// <summary>No channel format</summary>
        CudaChannelFormatKindNone = 3
    }

    /// <summary>CUDA memory types</summary>
    public enum CudaMemoryType
    {
        /// <summary>Host memory</summary>
        CudaMemoryTypeHost = 1,
        /// <summary>Device memory</summary>
        CudaMemoryTypeDevice = 2
    }

    /// <summary>CUDA memory copy types</summary>
    public enum CudaMemcpyKind
    {
        /// <summary>Host   -&gt; Host</summary>
        CudaMemcpyHostToHost = 0,
        /// <summary>Host   -&gt; Device</summary>
        CudaMemcpyHostToDevice = 1,
        /// <summary>Device -&gt; Host</summary>
        CudaMemcpyDeviceToHost = 2,
        /// <summary>Device -&gt; Device</summary>
        CudaMemcpyDeviceToDevice = 3,
        /// <summary>Direction of the transfer is inferred from the pointer values. Requires unified virtual addressing</summary>
        CudaMemcpyDefault = 4
    }

    /// <summary>CUDA graphics interop register flags</summary>
    [Flags]
    public enum CudaGraphicsRegisterFlags
    {
        /// <summary>Default</summary>
        CudaGraphicsRegisterFlagsNone = 0,
        /// <summary>CUDA will not write to this resource</summary>
        CudaGraphicsRegisterFlagsReadOnly = 1,
        /// <summary>CUDA will only write to and will not read from this resource</summary>
        CudaGraphicsRegisterFlagsWriteDiscard = 2,
        /// <summary>CUDA will bind this resource to a surface reference</summary>
        CudaGraphicsRegisterFlagsSurfaceLoadStore = 4,
        /// <summary>CUDA will perform texture gather operations on this resource</summary>
        CudaGraphicsRegisterFlagsTextureGather = 8
    }

    /// <summary>CUDA graphics interop map flags</summary>
    public enum CudaGraphicsMapFlags
    {
        /// <summary>Default; Assume resource can be read/written</summary>
        CudaGraphicsMapFlagsNone = 0,
        /// <summary>CUDA will not write to this resource</summary>
        CudaGraphicsMapFlagsReadOnly = 1,
        /// <summary>CUDA will only write to and will not read from this resource</summary>
        CudaGraphicsMapFlagsWriteDiscard = 2
    }

    /// <summary>CUDA graphics interop array indices for cube maps</summary>
    public enum CudaGraphicsCubeFace
    {
        /// <summary>Positive X face of cubemap</summary>
        CudaGraphicsCubeFacePositiveX = 0,
        /// <summary>Negative X face of cubemap</summary>
        CudaGraphicsCubeFaceNegativeX = 1,
        /// <summary>Positive Y face of cubemap</summary>
        CudaGraphicsCubeFacePositiveY = 2,
        /// <summary>Negative Y face of cubemap</summary>
        CudaGraphicsCubeFaceNegativeY = 3,
        /// <summary>Positive Z face of cubemap</summary>
        CudaGraphicsCubeFacePositiveZ = 4,
        /// <summary>Negative Z face of cubemap</summary>
        CudaGraphicsCubeFaceNegativeZ = 5
    }

    /// <summary>CUDA resource types</summary>
    public enum CudaResourceType
    {
        /// <summary>Array resource</summary>
        CudaResourceTypeArray = 0,
        /// <summary>Mipmapped array resource</summary>
        CudaResourceTypeMipmappedArray = 1,
        /// <summary>Linear resource</summary>
        CudaResourceTypeLinear = 2,
        /// <summary>Pitch 2D resource</summary>
        CudaResourceTypePitch2D = 3
    }

    /// <summary>CUDA texture resource view formats</summary>
    public enum CudaResourceViewFormat
    {
        /// <summary>No resource view format (use underlying resource format)</summary>
        CudaResViewFormatNone = 0,
        /// <summary>1 channel unsigned 8-bit integers</summary>
        CudaResViewFormatUnsignedChar1 = 1,
        /// <summary>2 channel unsigned 8-bit integers</summary>
        CudaResViewFormatUnsignedChar2 = 2,
        /// <summary>4 channel unsigned 8-bit integers</summary>
        CudaResViewFormatUnsignedChar4 = 3,
        /// <summary>1 channel signed 8-bit integers</summary>
        CudaResViewFormatSignedChar1 = 4,
        /// <summary>2 channel signed 8-bit integers</summary>
        CudaResViewFormatSignedChar2 = 5,
        /// <summary>4 channel signed 8-bit integers</summary>
        CudaResViewFormatSignedChar4 = 6,
        /// <summary>1 channel unsigned 16-bit integers</summary>
        CudaResViewFormatUnsignedShort1 = 7,
        /// <summary>2 channel unsigned 16-bit integers</summary>
        CudaResViewFormatUnsignedShort2 = 8,
        /// <summary>4 channel unsigned 16-bit integers</summary>
        CudaResViewFormatUnsignedShort4 = 9,
        /// <summary>1 channel signed 16-bit integers</summary>
        CudaResViewFormatSignedShort1 = 10,
        /// <summary>2 channel signed 16-bit integers</summary>
        CudaResViewFormatSignedShort2 = 11,
        /// <summary>4 channel signed 16-bit integers</summary>
        CudaResViewFormatSignedShort4 = 12,
        /// <summary>1 channel unsigned 32-bit integers</summary>
        CudaResViewFormatUnsignedInt1 = 13,
        /// <summary>2 channel unsigned 32-bit integers</summary>
        CudaResViewFormatUnsignedInt2 = 14,
        /// <summary>4 channel unsigned 32-bit integers</summary>
        CudaResViewFormatUnsignedInt4 = 15,
        /// <summary>1 channel signed 32-bit integers</summary>
        CudaResViewFormatSignedInt1 = 16,
        /// <summary>2 channel signed 32-bit integers</summary>
        CudaResViewFormatSignedInt2 = 17,
        /// <summary>4 channel signed 32-bit integers</summary>
        CudaResViewFormatSignedInt4 = 18,
        /// <summary>1 channel 16-bit floating point</summary>
        CudaResViewFormatHalf1 = 19,
        /// <summary>2 channel 16-bit floating point</summary>
        CudaResViewFormatHalf2 = 20,
        /// <summary>4 channel 16-bit floating point</summary>
        CudaResViewFormatHalf4 = 21,
        /// <summary>1 channel 32-bit floating point</summary>
        CudaResViewFormatFloat1 = 22,
        /// <summary>2 channel 32-bit floating point</summary>
        CudaResViewFormatFloat2 = 23,
        /// <summary>4 channel 32-bit floating point</summary>
        CudaResViewFormatFloat4 = 24,
        /// <summary>Block compressed 1</summary>
        CudaResViewFormatUnsignedBlockCompressed1 = 25,
        /// <summary>Block compressed 2</summary>
        CudaResViewFormatUnsignedBlockCompressed2 = 26,
        /// <summary>Block compressed 3</summary>
        CudaResViewFormatUnsignedBlockCompressed3 = 27,
        /// <summary>Block compressed 4 unsigned</summary>
        CudaResViewFormatUnsignedBlockCompressed4 = 28,
        /// <summary>Block compressed 4 signed</summary>
        CudaResViewFormatSignedBlockCompressed4 = 29,
        /// <summary>Block compressed 5 unsigned</summary>
        CudaResViewFormatUnsignedBlockCompressed5 = 30,
        /// <summary>Block compressed 5 signed</summary>
        CudaResViewFormatSignedBlockCompressed5 = 31,
        /// <summary>Block compressed 6 unsigned half-float</summary>
        CudaResViewFormatUnsignedBlockCompressed6H = 32,
        /// <summary>Block compressed 6 signed half-float</summary>
        CudaResViewFormatSignedBlockCompressed6H = 33,
        /// <summary>Block compressed 7</summary>
        CudaResViewFormatUnsignedBlockCompressed7 = 34
    }

    /// <summary>CUDA function attributes that can be set using cudaFuncSetAttribute</summary>
    public enum CudaFuncAttribute
    {
        /// <summary>Maximum dynamic shared memory size</summary>
        CudaFuncAttributeMaxDynamicSharedMemorySize = 8,
        /// <summary>Preferred shared memory-L1 cache split ratio</summary>
        CudaFuncAttributePreferredSharedMemoryCarveout = 9,
        CudaFuncAttributeMax = 10
    }

    /// <summary>CUDA function cache configurations</summary>
    public enum CudaFuncCache
    {
        /// <summary>Default function cache configuration, no preference</summary>
        CudaFuncCachePreferNone = 0,
        /// <summary>Prefer larger shared memory and smaller L1 cache</summary>
        CudaFuncCachePreferShared = 1,
        /// <summary>Prefer larger L1 cache and smaller shared memory</summary>
        CudaFuncCachePreferL1 = 2,
        /// <summary>Prefer equal size L1 cache and shared memory</summary>
        CudaFuncCachePreferEqual = 3
    }

    /// <summary>CUDA shared memory configuration</summary>
    public enum CudaSharedMemConfig
    {
        CudaSharedMemBankSizeDefault = 0,
        CudaSharedMemBankSizeFourByte = 1,
        CudaSharedMemBankSizeEightByte = 2
    }

    /// <summary>Shared memory carveout configurations</summary>
    public enum CudaSharedCarveout
    {
        CudaSharedmemCarveoutDefault = -1,
        CudaSharedmemCarveoutMaxShared = 100,
        CudaSharedmemCarveoutMaxL1 = 0
    }

    /// <summary>CUDA device compute modes</summary>
    public enum CudaComputeMode
    {
        /// <summary>Default compute mode (Multiple threads can use ::cudaSetDevice() with this device)</summary>
        CudaComputeModeDefault = 0,
        /// <summary>Compute-exclusive-thread mode (Only one thread in one process will be able to use ::cudaSetDevice() with this device)</summary>
        CudaComputeModeExclusive = 1,
        /// <summary>Compute-prohibited mode (No threads can use ::cudaSetDevice() with this device)</summary>
        CudaComputeModeProhibited = 2,
        /// <summary>Compute-exclusive-process mode (Many threads in one process will be able to use ::cudaSetDevice() with this device)</summary>
        CudaComputeModeExclusiveProcess = 3
    }

    /// <summary>CUDA Limits</summary>
    public enum CudaLimit
    {
        /// <summary>GPU thread stack size</summary>
        CudaLimitStackSize = 0,
        /// <summary>GPU printf/fprintf FIFO size</summary>
        CudaLimitPrintfFifoSize = 1,
        /// <summary>GPU malloc heap size</summary>
        CudaLimitMallocHeapSize = 2,
        /// <summary>GPU device runtime synchronize depth</summary>
        CudaLimitDevRuntimeSyncDepth = 3,
        /// <summary>GPU device runtime pending launch count</summary>
        CudaLimitDevRuntimePendingLaunchCount = 4
    }

    /// <summary>CUDA Memory Advise values</summary>
    public enum CudaMemoryAdvise
    {
        /// <summary>Data will mostly be read and only occassionally be written to</summary>
        CudaMemAdviseSetReadMostly = 1,
        /// <summary>Undo the effect of ::cudaMemAdviseSetReadMostly</summary>
        CudaMemAdviseUnsetReadMostly = 2,
        /// <summary>Set the preferred location for the data as the specified device</summary>
        CudaMemAdviseSetPreferredLocation = 3,
        /// <summary>Clear the preferred location for the data</summary>
        CudaMemAdviseUnsetPreferredLocation = 4,
        /// <summary>Data will be accessed by the specified device, so prevent page faults as much as possible</summary>
        CudaMemAdviseSetAccessedBy = 5,
        /// <summary>Let the Unified Memory subsystem decide on the page faulting policy for the specified device</summary>
        CudaMemAdviseUnsetAccessedBy = 6
    }

    /// <summary>CUDA range attributes</summary>
    public enum CudaMemRangeAttribute
    {
        /// <summary>Whether the range will mostly be read and only occassionally be written to</summary>
        CudaMemRangeAttributeReadMostly = 1,
        /// <summary>The preferred location of the range</summary>
        CudaMemRangeAttributePreferredLocation = 2,
        /// <summary>Memory range has ::cudaMemAdviseSetAccessedBy set for specified device</summary>
        CudaMemRangeAttributeAccessedBy = 3,
        /// <summary>The last location to which the range was prefetched</summary>
        CudaMemRangeAttributeLastPrefetchLocation = 4
    }

    /// <summary>CUDA Profiler Output modes</summary>
    public enum CudaOutputMode
    {
        /// <summary>Output mode Key-Value pair format.</summary>
        CudaKeyValuePair = 0,
        /// <summary>Output mode Comma separated values format.</summary>
        CudaCSV = 1
    }

    /// <summary>CUDA device attributes</summary>
    public enum CudaDeviceAttr
    {
        /// <summary>Maximum number of threads per block</summary>
        CudaDevAttrMaxThreadsPerBlock = 1,
        /// <summary>Maximum block dimension X</summary>
        CudaDevAttrMaxBlockDimX = 2,
        /// <summary>Maximum block dimension Y</summary>
        CudaDevAttrMaxBlockDimY = 3,
        /// <summary>Maximum block dimension Z</summary>
        CudaDevAttrMaxBlockDimZ = 4,
        /// <summary>Maximum grid dimension X</summary>
        CudaDevAttrMaxGridDimX = 5,
        /// <summary>Maximum grid dimension Y</summary>
        CudaDevAttrMaxGridDimY = 6,
        /// <summary>Maximum grid dimension Z</summary>
        CudaDevAttrMaxGridDimZ = 7,
        /// <summary>Maximum shared memory available per block in bytes</summary>
        CudaDevAttrMaxSharedMemoryPerBlock = 8,
        /// <summary>Memory available on device for __constant__ variables in a CUDA C kernel in bytes</summary>
        CudaDevAttrTotalConstantMemory = 9,
        /// <summary>Warp size in threads</summary>
        CudaDevAttrWarpSize = 10,
        /// <summary>Maximum pitch in bytes allowed by memory copies</summary>
        CudaDevAttrMaxPitch = 11,
        /// <summary>Maximum number of 32-bit registers available per block</summary>
        CudaDevAttrMaxRegistersPerBlock = 12,
        /// <summary>Peak clock frequency in kilohertz</summary>
        CudaDevAttrClockRate = 13,
        /// <summary>Alignment requirement for textures</summary>
        CudaDevAttrTextureAlignment = 14,
        /// <summary>Device can possibly copy memory and execute a kernel concurrently</summary>
        CudaDevAttrGpuOverlap = 15,
        /// <summary>Number of multiprocessors on device</summary>
        CudaDevAttrMultiProcessorCount = 16,
        /// <summary>Specifies whether there is a run time limit on kernels</summary>
        CudaDevAttrKernelExecTimeout = 17,
        /// <summary>Device is integrated with host memory</summary>
        CudaDevAttrIntegrated = 18,
        /// <summary>Device can map host memory into CUDA address space</summary>
        CudaDevAttrCanMapHostMemory = 19,
        /// <summary>Compute mode (See ::cudaComputeMode for details)</summary>
        CudaDevAttrComputeMode = 20,
        /// <summary>Maximum 1D texture width</summary>
        CudaDevAttrMaxTexture1DWidth = 21,
        /// <summary>Maximum 2D texture width</summary>
        CudaDevAttrMaxTexture2DWidth = 22,
        /// <summary>Maximum 2D texture height</summary>
        CudaDevAttrMaxTexture2DHeight = 23,
        /// <summary>Maximum 3D texture width</summary>
        CudaDevAttrMaxTexture3DWidth = 24,
        /// <summary>Maximum 3D texture height</summary>
        CudaDevAttrMaxTexture3DHeight = 25,
        /// <summary>Maximum 3D texture depth</summary>
        CudaDevAttrMaxTexture3DDepth = 26,
        /// <summary>Maximum 2D layered texture width</summary>
        CudaDevAttrMaxTexture2DLayeredWidth = 27,
        /// <summary>Maximum 2D layered texture height</summary>
        CudaDevAttrMaxTexture2DLayeredHeight = 28,
        /// <summary>Maximum layers in a 2D layered texture</summary>
        CudaDevAttrMaxTexture2DLayeredLayers = 29,
        /// <summary>Alignment requirement for surfaces</summary>
        CudaDevAttrSurfaceAlignment = 30,
        /// <summary>Device can possibly execute multiple kernels concurrently</summary>
        CudaDevAttrConcurrentKernels = 31,
        /// <summary>Device has ECC support enabled</summary>
        CudaDevAttrEccEnabled = 32,
        /// <summary>PCI bus ID of the device</summary>
        CudaDevAttrPciBusId = 33,
        /// <summary>PCI device ID of the device</summary>
        CudaDevAttrPciDeviceId = 34,
        /// <summary>Device is using TCC driver model</summary>
        CudaDevAttrTccDriver = 35,
        /// <summary>Peak memory clock frequency in kilohertz</summary>
        CudaDevAttrMemoryClockRate = 36,
        /// <summary>Global memory bus width in bits</summary>
        CudaDevAttrGlobalMemoryBusWidth = 37,
        /// <summary>Size of L2 cache in bytes</summary>
        CudaDevAttrL2CacheSize = 38,
        /// <summary>Maximum resident threads per multiprocessor</summary>
        CudaDevAttrMaxThreadsPerMultiProcessor = 39,
        /// <summary>Number of asynchronous engines</summary>
        CudaDevAttrAsyncEngineCount = 40,
        /// <summary>Device shares a unified address space with the host</summary>
        CudaDevAttrUnifiedAddressing = 41,
        /// <summary>Maximum 1D layered texture width</summary>
        CudaDevAttrMaxTexture1DLayeredWidth = 42,
        /// <summary>Maximum layers in a 1D layered texture</summary>
        CudaDevAttrMaxTexture1DLayeredLayers = 43,
        /// <summary>Maximum 2D texture width if cudaArrayTextureGather is set</summary>
        CudaDevAttrMaxTexture2DGatherWidth = 45,
        /// <summary>Maximum 2D texture height if cudaArrayTextureGather is set</summary>
        CudaDevAttrMaxTexture2DGatherHeight = 46,
        /// <summary>Alternate maximum 3D texture width</summary>
        CudaDevAttrMaxTexture3DWidthAlt = 47,
        /// <summary>Alternate maximum 3D texture height</summary>
        CudaDevAttrMaxTexture3DHeightAlt = 48,
        /// <summary>Alternate maximum 3D texture depth</summary>
        CudaDevAttrMaxTexture3DDepthAlt = 49,
        /// <summary>PCI domain ID of the device</summary>
        CudaDevAttrPciDomainId = 50,
        /// <summary>Pitch alignment requirement for textures</summary>
        CudaDevAttrTexturePitchAlignment = 51,
        /// <summary>Maximum cubemap texture width/height</summary>
        CudaDevAttrMaxTextureCubemapWidth = 52,
        /// <summary>Maximum cubemap layered texture width/height</summary>
        CudaDevAttrMaxTextureCubemapLayeredWidth = 53,
        /// <summary>Maximum layers in a cubemap layered texture</summary>
        CudaDevAttrMaxTextureCubemapLayeredLayers = 54,
        /// <summary>Maximum 1D surface width</summary>
        CudaDevAttrMaxSurface1DWidth = 55,
        /// <summary>Maximum 2D surface width</summary>
        CudaDevAttrMaxSurface2DWidth = 56,
        /// <summary>Maximum 2D surface height</summary>
        CudaDevAttrMaxSurface2DHeight = 57,
        /// <summary>Maximum 3D surface width</summary>
        CudaDevAttrMaxSurface3DWidth = 58,
        /// <summary>Maximum 3D surface height</summary>
        CudaDevAttrMaxSurface3DHeight = 59,
        /// <summary>Maximum 3D surface depth</summary>
        CudaDevAttrMaxSurface3DDepth = 60,
        /// <summary>Maximum 1D layered surface width</summary>
        CudaDevAttrMaxSurface1DLayeredWidth = 61,
        /// <summary>Maximum layers in a 1D layered surface</summary>
        CudaDevAttrMaxSurface1DLayeredLayers = 62,
        /// <summary>Maximum 2D layered surface width</summary>
        CudaDevAttrMaxSurface2DLayeredWidth = 63,
        /// <summary>Maximum 2D layered surface height</summary>
        CudaDevAttrMaxSurface2DLayeredHeight = 64,
        /// <summary>Maximum layers in a 2D layered surface</summary>
        CudaDevAttrMaxSurface2DLayeredLayers = 65,
        /// <summary>Maximum cubemap surface width</summary>
        CudaDevAttrMaxSurfaceCubemapWidth = 66,
        /// <summary>Maximum cubemap layered surface width</summary>
        CudaDevAttrMaxSurfaceCubemapLayeredWidth = 67,
        /// <summary>Maximum layers in a cubemap layered surface</summary>
        CudaDevAttrMaxSurfaceCubemapLayeredLayers = 68,
        /// <summary>Maximum 1D linear texture width</summary>
        CudaDevAttrMaxTexture1DLinearWidth = 69,
        /// <summary>Maximum 2D linear texture width</summary>
        CudaDevAttrMaxTexture2DLinearWidth = 70,
        /// <summary>Maximum 2D linear texture height</summary>
        CudaDevAttrMaxTexture2DLinearHeight = 71,
        /// <summary>Maximum 2D linear texture pitch in bytes</summary>
        CudaDevAttrMaxTexture2DLinearPitch = 72,
        /// <summary>Maximum mipmapped 2D texture width</summary>
        CudaDevAttrMaxTexture2DMipmappedWidth = 73,
        /// <summary>Maximum mipmapped 2D texture height</summary>
        CudaDevAttrMaxTexture2DMipmappedHeight = 74,
        /// <summary>Major compute capability version number</summary>
        CudaDevAttrComputeCapabilityMajor = 75,
        /// <summary>Minor compute capability version number</summary>
        CudaDevAttrComputeCapabilityMinor = 76,
        /// <summary>Maximum mipmapped 1D texture width</summary>
        CudaDevAttrMaxTexture1DMipmappedWidth = 77,
        /// <summary>Device supports stream priorities</summary>
        CudaDevAttrStreamPrioritiesSupported = 78,
        /// <summary>Device supports caching globals in L1</summary>
        CudaDevAttrGlobalL1CacheSupported = 79,
        /// <summary>Device supports caching locals in L1</summary>
        CudaDevAttrLocalL1CacheSupported = 80,
        /// <summary>Maximum shared memory available per multiprocessor in bytes</summary>
        CudaDevAttrMaxSharedMemoryPerMultiprocessor = 81,
        /// <summary>Maximum number of 32-bit registers available per multiprocessor</summary>
        CudaDevAttrMaxRegistersPerMultiprocessor = 82,
        /// <summary>Device can allocate managed memory on this system</summary>
        CudaDevAttrManagedMemory = 83,
        /// <summary>Device is on a multi-GPU board</summary>
        CudaDevAttrIsMultiGpuBoard = 84,
        /// <summary>Unique identifier for a group of devices on the same multi-GPU board</summary>
        CudaDevAttrMultiGpuBoardGroupID = 85,
        /// <summary>Link between the device and the host supports native atomic operations</summary>
        CudaDevAttrHostNativeAtomicSupported = 86,
        /// <summary>Ratio of single precision performance (in floating-point operations per second) to double precision performance</summary>
        CudaDevAttrSingleToDoublePrecisionPerfRatio = 87,
        /// <summary>Device supports coherently accessing pageable memory without calling cudaHostRegister on it</summary>
        CudaDevAttrPageableMemoryAccess = 88,
        /// <summary>Device can coherently access managed memory concurrently with the CPU</summary>
        CudaDevAttrConcurrentManagedAccess = 89,
        /// <summary>Device supports Compute Preemption</summary>
        CudaDevAttrComputePreemptionSupported = 90,
        /// <summary>Device can access host registered memory at the same virtual address as the CPU</summary>
        CudaDevAttrCanUseHostPointerForRegisteredMem = 91,
        CudaDevAttrReserved92 = 92,
        CudaDevAttrReserved93 = 93,
        CudaDevAttrReserved94 = 94,
        /// <summary>Device supports launching cooperative kernels via ::cudaLaunchCooperativeKernel</summary>
        CudaDevAttrCooperativeLaunch = 95,
        /// <summary>Device can participate in cooperative kernels launched via ::cudaLaunchCooperativeKernelMultiDevice</summary>
        CudaDevAttrCooperativeMultiDeviceLaunch = 96,
        /// <summary>The maximum optin shared memory per block. This value may vary by chip. See ::cudaFuncSetAttribute</summary>
        CudaDevAttrMaxSharedMemoryPerBlockOptin = 97
    }

    /// <summary>CUDA device P2P attributes</summary>
    public enum CudaDeviceP2PAttr
    {
        /// <summary>A relative value indicating the performance of the link between two devices</summary>
        CudaDevP2PAttrPerformanceRank = 1,
        /// <summary>Peer access is enabled</summary>
        CudaDevP2PAttrAccessSupported = 2,
        /// <summary>Native atomic operation over the link supported</summary>
        CudaDevP2PAttrNativeAtomicSupported = 3
    }

    /// <summary>CUDA cooperative group scope</summary>
    public enum CudaCGScope
    {
        /// <summary>Invalid cooperative group scope</summary>
        CudaCGScopeInvalid = 0,
        /// <summary>Scope represented by a grid_group</summary>
        CudaCGScopeGrid = 1,
        /// <summary>Scope represented by a multi_grid_group</summary>
        CudaCGScopeMultiGrid = 2
    }

    /// <summary>CUDA array</summary>
    /// <summary>CUDA array (as source copy argument)</summary>
    /// <summary>CUDA mipmapped array</summary>
    /// <summary>CUDA mipmapped array (as source argument)</summary>
    /// <summary>CUDA Error types</summary>
    /// <summary>CUDA stream</summary>
    /// <summary>CUDA event types</summary>
    /// <summary>CUDA graphics resource types</summary>
    /// <summary>CUDA UUID types</summary>
    /// <summary>CUDA output file modes</summary>
    /// <summary>CUDA Channel format descriptor</summary>
    public unsafe partial class CudaChannelFormatDesc : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 20)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int x;

            [FieldOffset(4)]
            internal int y;

            [FieldOffset(8)]
            internal int z;

            [FieldOffset(12)]
            internal int w;

            [FieldOffset(16)]
            internal global::CUDA.CudaChannelFormatKind f;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaChannelFormatDesc@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaChannelFormatDesc> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaChannelFormatDesc>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaChannelFormatDesc __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaChannelFormatDesc(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaChannelFormatDesc __CreateInstance(global::CUDA.CudaChannelFormatDesc.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaChannelFormatDesc(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaChannelFormatDesc.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaChannelFormatDesc.__Internal));
            *(global::CUDA.CudaChannelFormatDesc.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaChannelFormatDesc(global::CUDA.CudaChannelFormatDesc.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaChannelFormatDesc(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaChannelFormatDesc()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaChannelFormatDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaChannelFormatDesc(global::CUDA.CudaChannelFormatDesc _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaChannelFormatDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance) = *((global::CUDA.CudaChannelFormatDesc.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaChannelFormatDesc __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int X
        {
            get
            {
                return ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->x = value;
            }
        }

        public int Y
        {
            get
            {
                return ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->y = value;
            }
        }

        public int Z
        {
            get
            {
                return ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->z = value;
            }
        }

        public int W
        {
            get
            {
                return ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->w;
            }

            set
            {
                ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->w = value;
            }
        }

        public global::CUDA.CudaChannelFormatKind F
        {
            get
            {
                return ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->f;
            }

            set
            {
                ((global::CUDA.CudaChannelFormatDesc.__Internal*)__Instance)->f = value;
            }
        }
    }

    public unsafe partial class CudaArray
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaArray> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaArray>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaArray __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaArray(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaArray __CreateInstance(global::CUDA.CudaArray.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaArray(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaArray.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaArray.__Internal));
            *(global::CUDA.CudaArray.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaArray(global::CUDA.CudaArray.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaArray(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class CudaMipmappedArray
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaMipmappedArray> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaMipmappedArray>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaMipmappedArray __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaMipmappedArray(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaMipmappedArray __CreateInstance(global::CUDA.CudaMipmappedArray.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaMipmappedArray(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaMipmappedArray.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaMipmappedArray.__Internal));
            *(global::CUDA.CudaMipmappedArray.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaMipmappedArray(global::CUDA.CudaMipmappedArray.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaMipmappedArray(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    /// <summary>CUDA Pitched memory pointer</summary>
    /// <remarks>::make_cudaPitchedPtr</remarks>
    public unsafe partial class CudaPitchedPtr : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr ptr;

            [FieldOffset(8)]
            internal ulong pitch;

            [FieldOffset(16)]
            internal ulong xsize;

            [FieldOffset(24)]
            internal ulong ysize;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaPitchedPtr@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaPitchedPtr> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaPitchedPtr>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaPitchedPtr __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaPitchedPtr(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaPitchedPtr __CreateInstance(global::CUDA.CudaPitchedPtr.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaPitchedPtr(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaPitchedPtr.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPitchedPtr.__Internal));
            *(global::CUDA.CudaPitchedPtr.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaPitchedPtr(global::CUDA.CudaPitchedPtr.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaPitchedPtr(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaPitchedPtr()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPitchedPtr.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaPitchedPtr(global::CUDA.CudaPitchedPtr _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPitchedPtr.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaPitchedPtr.__Internal*)__Instance) = *((global::CUDA.CudaPitchedPtr.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaPitchedPtr __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::System.IntPtr Ptr
        {
            get
            {
                return ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->ptr;
            }

            set
            {
                ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->ptr = (global::System.IntPtr)value;
            }
        }

        public ulong Pitch
        {
            get
            {
                return ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->pitch;
            }

            set
            {
                ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->pitch = value;
            }
        }

        public ulong Xsize
        {
            get
            {
                return ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->xsize;
            }

            set
            {
                ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->xsize = value;
            }
        }

        public ulong Ysize
        {
            get
            {
                return ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->ysize;
            }

            set
            {
                ((global::CUDA.CudaPitchedPtr.__Internal*)__Instance)->ysize = value;
            }
        }
    }

    /// <summary>CUDA extent</summary>
    /// <remarks>::make_cudaExtent</remarks>
    public unsafe partial class CudaExtent : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong width;

            [FieldOffset(8)]
            internal ulong height;

            [FieldOffset(16)]
            internal ulong depth;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaExtent@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaExtent> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaExtent>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaExtent __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaExtent(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaExtent __CreateInstance(global::CUDA.CudaExtent.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaExtent(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaExtent.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaExtent.__Internal));
            *(global::CUDA.CudaExtent.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaExtent(global::CUDA.CudaExtent.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaExtent(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaExtent()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaExtent.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaExtent(global::CUDA.CudaExtent _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaExtent.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaExtent.__Internal*)__Instance) = *((global::CUDA.CudaExtent.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaExtent __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong Width
        {
            get
            {
                return ((global::CUDA.CudaExtent.__Internal*)__Instance)->width;
            }

            set
            {
                ((global::CUDA.CudaExtent.__Internal*)__Instance)->width = value;
            }
        }

        public ulong Height
        {
            get
            {
                return ((global::CUDA.CudaExtent.__Internal*)__Instance)->height;
            }

            set
            {
                ((global::CUDA.CudaExtent.__Internal*)__Instance)->height = value;
            }
        }

        public ulong Depth
        {
            get
            {
                return ((global::CUDA.CudaExtent.__Internal*)__Instance)->depth;
            }

            set
            {
                ((global::CUDA.CudaExtent.__Internal*)__Instance)->depth = value;
            }
        }
    }

    /// <summary>CUDA 3D position</summary>
    /// <remarks>::make_cudaPos</remarks>
    public unsafe partial class CudaPos : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 24)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong x;

            [FieldOffset(8)]
            internal ulong y;

            [FieldOffset(16)]
            internal ulong z;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaPos@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaPos> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaPos>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaPos __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaPos(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaPos __CreateInstance(global::CUDA.CudaPos.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaPos(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaPos.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPos.__Internal));
            *(global::CUDA.CudaPos.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaPos(global::CUDA.CudaPos.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaPos(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaPos()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPos.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaPos(global::CUDA.CudaPos _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPos.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaPos.__Internal*)__Instance) = *((global::CUDA.CudaPos.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaPos __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong X
        {
            get
            {
                return ((global::CUDA.CudaPos.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.CudaPos.__Internal*)__Instance)->x = value;
            }
        }

        public ulong Y
        {
            get
            {
                return ((global::CUDA.CudaPos.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.CudaPos.__Internal*)__Instance)->y = value;
            }
        }

        public ulong Z
        {
            get
            {
                return ((global::CUDA.CudaPos.__Internal*)__Instance)->z;
            }

            set
            {
                ((global::CUDA.CudaPos.__Internal*)__Instance)->z = value;
            }
        }
    }

    /// <summary>CUDA 3D memory copying parameters</summary>
    public unsafe partial class CudaMemcpy3DParms : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 160)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr srcArray;

            [FieldOffset(8)]
            internal global::CUDA.CudaPos.__Internal srcPos;

            [FieldOffset(32)]
            internal global::CUDA.CudaPitchedPtr.__Internal srcPtr;

            [FieldOffset(64)]
            internal global::System.IntPtr dstArray;

            [FieldOffset(72)]
            internal global::CUDA.CudaPos.__Internal dstPos;

            [FieldOffset(96)]
            internal global::CUDA.CudaPitchedPtr.__Internal dstPtr;

            [FieldOffset(128)]
            internal global::CUDA.CudaExtent.__Internal extent;

            [FieldOffset(152)]
            internal global::CUDA.CudaMemcpyKind kind;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaMemcpy3DParms@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaMemcpy3DParms> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaMemcpy3DParms>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaMemcpy3DParms __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaMemcpy3DParms(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaMemcpy3DParms __CreateInstance(global::CUDA.CudaMemcpy3DParms.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaMemcpy3DParms(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaMemcpy3DParms.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaMemcpy3DParms.__Internal));
            *(global::CUDA.CudaMemcpy3DParms.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaMemcpy3DParms(global::CUDA.CudaMemcpy3DParms.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaMemcpy3DParms(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaMemcpy3DParms()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaMemcpy3DParms.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaMemcpy3DParms(global::CUDA.CudaMemcpy3DParms _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaMemcpy3DParms.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance) = *((global::CUDA.CudaMemcpy3DParms.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaMemcpy3DParms __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CUDA.CudaArray SrcArray
        {
            get
            {
                global::CUDA.CudaArray __result0;
                if (((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcArray == IntPtr.Zero) __result0 = null;
                else if (global::CUDA.CudaArray.NativeToManagedMap.ContainsKey(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcArray))
                    __result0 = (global::CUDA.CudaArray)global::CUDA.CudaArray.NativeToManagedMap[((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcArray];
                else __result0 = global::CUDA.CudaArray.__CreateInstance(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcArray);
                return __result0;
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcArray = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public global::CUDA.CudaPos SrcPos
        {
            get
            {
                return global::CUDA.CudaPos.__CreateInstance(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcPos);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcPos = ReferenceEquals(value, null) ? new global::CUDA.CudaPos.__Internal() : *(global::CUDA.CudaPos.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.CudaPitchedPtr SrcPtr
        {
            get
            {
                return global::CUDA.CudaPitchedPtr.__CreateInstance(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcPtr);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->srcPtr = ReferenceEquals(value, null) ? new global::CUDA.CudaPitchedPtr.__Internal() : *(global::CUDA.CudaPitchedPtr.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.CudaArray DstArray
        {
            get
            {
                global::CUDA.CudaArray __result0;
                if (((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstArray == IntPtr.Zero) __result0 = null;
                else if (global::CUDA.CudaArray.NativeToManagedMap.ContainsKey(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstArray))
                    __result0 = (global::CUDA.CudaArray)global::CUDA.CudaArray.NativeToManagedMap[((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstArray];
                else __result0 = global::CUDA.CudaArray.__CreateInstance(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstArray);
                return __result0;
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstArray = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public global::CUDA.CudaPos DstPos
        {
            get
            {
                return global::CUDA.CudaPos.__CreateInstance(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstPos);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstPos = ReferenceEquals(value, null) ? new global::CUDA.CudaPos.__Internal() : *(global::CUDA.CudaPos.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.CudaPitchedPtr DstPtr
        {
            get
            {
                return global::CUDA.CudaPitchedPtr.__CreateInstance(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstPtr);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->dstPtr = ReferenceEquals(value, null) ? new global::CUDA.CudaPitchedPtr.__Internal() : *(global::CUDA.CudaPitchedPtr.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.CudaExtent Extent
        {
            get
            {
                return global::CUDA.CudaExtent.__CreateInstance(((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->extent);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->extent = ReferenceEquals(value, null) ? new global::CUDA.CudaExtent.__Internal() : *(global::CUDA.CudaExtent.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.CudaMemcpyKind Kind
        {
            get
            {
                return ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->kind;
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DParms.__Internal*)__Instance)->kind = value;
            }
        }
    }

    /// <summary>CUDA 3D cross-device memory copying parameters</summary>
    public unsafe partial class CudaMemcpy3DPeerParms : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 168)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr srcArray;

            [FieldOffset(8)]
            internal global::CUDA.CudaPos.__Internal srcPos;

            [FieldOffset(32)]
            internal global::CUDA.CudaPitchedPtr.__Internal srcPtr;

            [FieldOffset(64)]
            internal int srcDevice;

            [FieldOffset(72)]
            internal global::System.IntPtr dstArray;

            [FieldOffset(80)]
            internal global::CUDA.CudaPos.__Internal dstPos;

            [FieldOffset(104)]
            internal global::CUDA.CudaPitchedPtr.__Internal dstPtr;

            [FieldOffset(136)]
            internal int dstDevice;

            [FieldOffset(144)]
            internal global::CUDA.CudaExtent.__Internal extent;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaMemcpy3DPeerParms@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaMemcpy3DPeerParms> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaMemcpy3DPeerParms>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaMemcpy3DPeerParms __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaMemcpy3DPeerParms(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaMemcpy3DPeerParms __CreateInstance(global::CUDA.CudaMemcpy3DPeerParms.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaMemcpy3DPeerParms(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaMemcpy3DPeerParms.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaMemcpy3DPeerParms.__Internal));
            *(global::CUDA.CudaMemcpy3DPeerParms.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaMemcpy3DPeerParms(global::CUDA.CudaMemcpy3DPeerParms.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaMemcpy3DPeerParms(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaMemcpy3DPeerParms()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaMemcpy3DPeerParms.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaMemcpy3DPeerParms(global::CUDA.CudaMemcpy3DPeerParms _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaMemcpy3DPeerParms.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance) = *((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaMemcpy3DPeerParms __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CUDA.CudaArray SrcArray
        {
            get
            {
                global::CUDA.CudaArray __result0;
                if (((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcArray == IntPtr.Zero) __result0 = null;
                else if (global::CUDA.CudaArray.NativeToManagedMap.ContainsKey(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcArray))
                    __result0 = (global::CUDA.CudaArray)global::CUDA.CudaArray.NativeToManagedMap[((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcArray];
                else __result0 = global::CUDA.CudaArray.__CreateInstance(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcArray);
                return __result0;
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcArray = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public global::CUDA.CudaPos SrcPos
        {
            get
            {
                return global::CUDA.CudaPos.__CreateInstance(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcPos);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcPos = ReferenceEquals(value, null) ? new global::CUDA.CudaPos.__Internal() : *(global::CUDA.CudaPos.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.CudaPitchedPtr SrcPtr
        {
            get
            {
                return global::CUDA.CudaPitchedPtr.__CreateInstance(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcPtr);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcPtr = ReferenceEquals(value, null) ? new global::CUDA.CudaPitchedPtr.__Internal() : *(global::CUDA.CudaPitchedPtr.__Internal*)value.__Instance;
            }
        }

        public int SrcDevice
        {
            get
            {
                return ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcDevice;
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->srcDevice = value;
            }
        }

        public global::CUDA.CudaArray DstArray
        {
            get
            {
                global::CUDA.CudaArray __result0;
                if (((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstArray == IntPtr.Zero) __result0 = null;
                else if (global::CUDA.CudaArray.NativeToManagedMap.ContainsKey(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstArray))
                    __result0 = (global::CUDA.CudaArray)global::CUDA.CudaArray.NativeToManagedMap[((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstArray];
                else __result0 = global::CUDA.CudaArray.__CreateInstance(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstArray);
                return __result0;
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstArray = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }

        public global::CUDA.CudaPos DstPos
        {
            get
            {
                return global::CUDA.CudaPos.__CreateInstance(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstPos);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstPos = ReferenceEquals(value, null) ? new global::CUDA.CudaPos.__Internal() : *(global::CUDA.CudaPos.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.CudaPitchedPtr DstPtr
        {
            get
            {
                return global::CUDA.CudaPitchedPtr.__CreateInstance(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstPtr);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstPtr = ReferenceEquals(value, null) ? new global::CUDA.CudaPitchedPtr.__Internal() : *(global::CUDA.CudaPitchedPtr.__Internal*)value.__Instance;
            }
        }

        public int DstDevice
        {
            get
            {
                return ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstDevice;
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->dstDevice = value;
            }
        }

        public global::CUDA.CudaExtent Extent
        {
            get
            {
                return global::CUDA.CudaExtent.__CreateInstance(((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->extent);
            }

            set
            {
                ((global::CUDA.CudaMemcpy3DPeerParms.__Internal*)__Instance)->extent = ReferenceEquals(value, null) ? new global::CUDA.CudaExtent.__Internal() : *(global::CUDA.CudaExtent.__Internal*)value.__Instance;
            }
        }
    }

    /// <summary>CUDA graphics interop resource</summary>
    public unsafe partial class CudaGraphicsResource
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaGraphicsResource> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaGraphicsResource>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaGraphicsResource __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaGraphicsResource(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaGraphicsResource __CreateInstance(global::CUDA.CudaGraphicsResource.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaGraphicsResource(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaGraphicsResource.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaGraphicsResource.__Internal));
            *(global::CUDA.CudaGraphicsResource.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaGraphicsResource(global::CUDA.CudaGraphicsResource.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaGraphicsResource(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    /// <summary>CUDA resource descriptor</summary>
    public unsafe partial class CudaResourceDesc : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::CUDA.CudaResourceType resType;

            [FieldOffset(8)]
            internal global::CUDA.CudaResourceDesc._.__Internal res;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaResourceDesc@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public unsafe partial struct _
        {
            [StructLayout(LayoutKind.Explicit, Size = 56)]
            public partial struct __Internal
            {
                [FieldOffset(0)]
                internal global::CUDA.CudaResourceDesc._.__.__Internal array;

                [FieldOffset(0)]
                internal global::CUDA.CudaResourceDesc._.___.__Internal mipmap;

                [FieldOffset(0)]
                internal global::CUDA.CudaResourceDesc._.____.__Internal linear;

                [FieldOffset(0)]
                internal global::CUDA.CudaResourceDesc._._____.__Internal pitch2D;
            }

            public unsafe partial class __
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr array;
                }
            }

            public unsafe partial class ___
            {
                [StructLayout(LayoutKind.Explicit, Size = 8)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr mipmap;
                }
            }

            public unsafe partial class ____
            {
                [StructLayout(LayoutKind.Explicit, Size = 40)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr devPtr;

                    [FieldOffset(8)]
                    internal global::CUDA.CudaChannelFormatDesc.__Internal desc;

                    [FieldOffset(32)]
                    internal ulong sizeInBytes;
                }
            }

            public unsafe partial class _____
            {
                [StructLayout(LayoutKind.Explicit, Size = 56)]
                public partial struct __Internal
                {
                    [FieldOffset(0)]
                    internal global::System.IntPtr devPtr;

                    [FieldOffset(8)]
                    internal global::CUDA.CudaChannelFormatDesc.__Internal desc;

                    [FieldOffset(32)]
                    internal ulong width;

                    [FieldOffset(40)]
                    internal ulong height;

                    [FieldOffset(48)]
                    internal ulong pitchInBytes;
                }
            }
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaResourceDesc> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaResourceDesc>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaResourceDesc __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaResourceDesc(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaResourceDesc __CreateInstance(global::CUDA.CudaResourceDesc.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaResourceDesc(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaResourceDesc.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaResourceDesc.__Internal));
            *(global::CUDA.CudaResourceDesc.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaResourceDesc(global::CUDA.CudaResourceDesc.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaResourceDesc(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaResourceDesc()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaResourceDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaResourceDesc(global::CUDA.CudaResourceDesc _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaResourceDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaResourceDesc.__Internal*)__Instance) = *((global::CUDA.CudaResourceDesc.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaResourceDesc __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CUDA.CudaResourceType ResType
        {
            get
            {
                return ((global::CUDA.CudaResourceDesc.__Internal*)__Instance)->resType;
            }

            set
            {
                ((global::CUDA.CudaResourceDesc.__Internal*)__Instance)->resType = value;
            }
        }
    }

    /// <summary>CUDA resource view descriptor</summary>
    public unsafe partial class CudaResourceViewDesc : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 48)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::CUDA.CudaResourceViewFormat format;

            [FieldOffset(8)]
            internal ulong width;

            [FieldOffset(16)]
            internal ulong height;

            [FieldOffset(24)]
            internal ulong depth;

            [FieldOffset(32)]
            internal uint firstMipmapLevel;

            [FieldOffset(36)]
            internal uint lastMipmapLevel;

            [FieldOffset(40)]
            internal uint firstLayer;

            [FieldOffset(44)]
            internal uint lastLayer;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaResourceViewDesc@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaResourceViewDesc> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaResourceViewDesc>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaResourceViewDesc __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaResourceViewDesc(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaResourceViewDesc __CreateInstance(global::CUDA.CudaResourceViewDesc.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaResourceViewDesc(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaResourceViewDesc.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaResourceViewDesc.__Internal));
            *(global::CUDA.CudaResourceViewDesc.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaResourceViewDesc(global::CUDA.CudaResourceViewDesc.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaResourceViewDesc(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaResourceViewDesc()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaResourceViewDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaResourceViewDesc(global::CUDA.CudaResourceViewDesc _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaResourceViewDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance) = *((global::CUDA.CudaResourceViewDesc.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaResourceViewDesc __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CUDA.CudaResourceViewFormat Format
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->format;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->format = value;
            }
        }

        public ulong Width
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->width;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->width = value;
            }
        }

        public ulong Height
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->height;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->height = value;
            }
        }

        public ulong Depth
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->depth;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->depth = value;
            }
        }

        public uint FirstMipmapLevel
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->firstMipmapLevel;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->firstMipmapLevel = value;
            }
        }

        public uint LastMipmapLevel
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->lastMipmapLevel;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->lastMipmapLevel = value;
            }
        }

        public uint FirstLayer
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->firstLayer;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->firstLayer = value;
            }
        }

        public uint LastLayer
        {
            get
            {
                return ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->lastLayer;
            }

            set
            {
                ((global::CUDA.CudaResourceViewDesc.__Internal*)__Instance)->lastLayer = value;
            }
        }
    }

    /// <summary>CUDA pointer attributes</summary>
    public unsafe partial class CudaPointerAttributes : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 32)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::CUDA.CudaMemoryType memoryType;

            [FieldOffset(4)]
            internal int device;

            [FieldOffset(8)]
            internal global::System.IntPtr devicePointer;

            [FieldOffset(16)]
            internal global::System.IntPtr hostPointer;

            [FieldOffset(24)]
            internal int isManaged;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaPointerAttributes@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaPointerAttributes> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaPointerAttributes>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaPointerAttributes __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaPointerAttributes(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaPointerAttributes __CreateInstance(global::CUDA.CudaPointerAttributes.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaPointerAttributes(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaPointerAttributes.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPointerAttributes.__Internal));
            *(global::CUDA.CudaPointerAttributes.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaPointerAttributes(global::CUDA.CudaPointerAttributes.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaPointerAttributes(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaPointerAttributes()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPointerAttributes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaPointerAttributes(global::CUDA.CudaPointerAttributes _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaPointerAttributes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaPointerAttributes.__Internal*)__Instance) = *((global::CUDA.CudaPointerAttributes.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaPointerAttributes __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CUDA.CudaMemoryType MemoryType
        {
            get
            {
                return ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->memoryType;
            }

            set
            {
                ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->memoryType = value;
            }
        }

        public int Device
        {
            get
            {
                return ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->device;
            }

            set
            {
                ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->device = value;
            }
        }

        public global::System.IntPtr DevicePointer
        {
            get
            {
                return ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->devicePointer;
            }

            set
            {
                ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->devicePointer = (global::System.IntPtr)value;
            }
        }

        public global::System.IntPtr HostPointer
        {
            get
            {
                return ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->hostPointer;
            }

            set
            {
                ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->hostPointer = (global::System.IntPtr)value;
            }
        }

        public int IsManaged
        {
            get
            {
                return ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->isManaged;
            }

            set
            {
                ((global::CUDA.CudaPointerAttributes.__Internal*)__Instance)->isManaged = value;
            }
        }
    }

    /// <summary>CUDA function attributes</summary>
    public unsafe partial class CudaFuncAttributes : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ulong sharedSizeBytes;

            [FieldOffset(8)]
            internal ulong constSizeBytes;

            [FieldOffset(16)]
            internal ulong localSizeBytes;

            [FieldOffset(24)]
            internal int maxThreadsPerBlock;

            [FieldOffset(28)]
            internal int numRegs;

            [FieldOffset(32)]
            internal int ptxVersion;

            [FieldOffset(36)]
            internal int binaryVersion;

            [FieldOffset(40)]
            internal int cacheModeCA;

            [FieldOffset(44)]
            internal int maxDynamicSharedSizeBytes;

            [FieldOffset(48)]
            internal int preferredShmemCarveout;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaFuncAttributes@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaFuncAttributes> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaFuncAttributes>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaFuncAttributes __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaFuncAttributes(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaFuncAttributes __CreateInstance(global::CUDA.CudaFuncAttributes.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaFuncAttributes(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaFuncAttributes.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaFuncAttributes.__Internal));
            *(global::CUDA.CudaFuncAttributes.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaFuncAttributes(global::CUDA.CudaFuncAttributes.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaFuncAttributes(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaFuncAttributes()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaFuncAttributes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaFuncAttributes(global::CUDA.CudaFuncAttributes _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaFuncAttributes.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaFuncAttributes.__Internal*)__Instance) = *((global::CUDA.CudaFuncAttributes.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaFuncAttributes __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ulong SharedSizeBytes
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->sharedSizeBytes;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->sharedSizeBytes = value;
            }
        }

        public ulong ConstSizeBytes
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->constSizeBytes;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->constSizeBytes = value;
            }
        }

        public ulong LocalSizeBytes
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->localSizeBytes;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->localSizeBytes = value;
            }
        }

        public int MaxThreadsPerBlock
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->maxThreadsPerBlock;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->maxThreadsPerBlock = value;
            }
        }

        public int NumRegs
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->numRegs;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->numRegs = value;
            }
        }

        public int PtxVersion
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->ptxVersion;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->ptxVersion = value;
            }
        }

        public int BinaryVersion
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->binaryVersion;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->binaryVersion = value;
            }
        }

        public int CacheModeCA
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->cacheModeCA;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->cacheModeCA = value;
            }
        }

        public int MaxDynamicSharedSizeBytes
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->maxDynamicSharedSizeBytes;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->maxDynamicSharedSizeBytes = value;
            }
        }

        public int PreferredShmemCarveout
        {
            get
            {
                return ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->preferredShmemCarveout;
            }

            set
            {
                ((global::CUDA.CudaFuncAttributes.__Internal*)__Instance)->preferredShmemCarveout = value;
            }
        }
    }

    /// <summary>CUDA device properties</summary>
    public unsafe partial class CudaDeviceProp : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 672)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte name[256];

            [FieldOffset(256)]
            internal ulong totalGlobalMem;

            [FieldOffset(264)]
            internal ulong sharedMemPerBlock;

            [FieldOffset(272)]
            internal int regsPerBlock;

            [FieldOffset(276)]
            internal int warpSize;

            [FieldOffset(280)]
            internal ulong memPitch;

            [FieldOffset(288)]
            internal int maxThreadsPerBlock;

            [FieldOffset(292)]
            internal fixed int maxThreadsDim[3];

            [FieldOffset(304)]
            internal fixed int maxGridSize[3];

            [FieldOffset(316)]
            internal int clockRate;

            [FieldOffset(320)]
            internal ulong totalConstMem;

            [FieldOffset(328)]
            internal int major;

            [FieldOffset(332)]
            internal int minor;

            [FieldOffset(336)]
            internal ulong textureAlignment;

            [FieldOffset(344)]
            internal ulong texturePitchAlignment;

            [FieldOffset(352)]
            internal int deviceOverlap;

            [FieldOffset(356)]
            internal int multiProcessorCount;

            [FieldOffset(360)]
            internal int kernelExecTimeoutEnabled;

            [FieldOffset(364)]
            internal int integrated;

            [FieldOffset(368)]
            internal int canMapHostMemory;

            [FieldOffset(372)]
            internal int computeMode;

            [FieldOffset(376)]
            internal int maxTexture1D;

            [FieldOffset(380)]
            internal int maxTexture1DMipmap;

            [FieldOffset(384)]
            internal int maxTexture1DLinear;

            [FieldOffset(388)]
            internal fixed int maxTexture2D[2];

            [FieldOffset(396)]
            internal fixed int maxTexture2DMipmap[2];

            [FieldOffset(404)]
            internal fixed int maxTexture2DLinear[3];

            [FieldOffset(416)]
            internal fixed int maxTexture2DGather[2];

            [FieldOffset(424)]
            internal fixed int maxTexture3D[3];

            [FieldOffset(436)]
            internal fixed int maxTexture3DAlt[3];

            [FieldOffset(448)]
            internal int maxTextureCubemap;

            [FieldOffset(452)]
            internal fixed int maxTexture1DLayered[2];

            [FieldOffset(460)]
            internal fixed int maxTexture2DLayered[3];

            [FieldOffset(472)]
            internal fixed int maxTextureCubemapLayered[2];

            [FieldOffset(480)]
            internal int maxSurface1D;

            [FieldOffset(484)]
            internal fixed int maxSurface2D[2];

            [FieldOffset(492)]
            internal fixed int maxSurface3D[3];

            [FieldOffset(504)]
            internal fixed int maxSurface1DLayered[2];

            [FieldOffset(512)]
            internal fixed int maxSurface2DLayered[3];

            [FieldOffset(524)]
            internal int maxSurfaceCubemap;

            [FieldOffset(528)]
            internal fixed int maxSurfaceCubemapLayered[2];

            [FieldOffset(536)]
            internal ulong surfaceAlignment;

            [FieldOffset(544)]
            internal int concurrentKernels;

            [FieldOffset(548)]
            internal int ECCEnabled;

            [FieldOffset(552)]
            internal int pciBusID;

            [FieldOffset(556)]
            internal int pciDeviceID;

            [FieldOffset(560)]
            internal int pciDomainID;

            [FieldOffset(564)]
            internal int tccDriver;

            [FieldOffset(568)]
            internal int asyncEngineCount;

            [FieldOffset(572)]
            internal int unifiedAddressing;

            [FieldOffset(576)]
            internal int memoryClockRate;

            [FieldOffset(580)]
            internal int memoryBusWidth;

            [FieldOffset(584)]
            internal int l2CacheSize;

            [FieldOffset(588)]
            internal int maxThreadsPerMultiProcessor;

            [FieldOffset(592)]
            internal int streamPrioritiesSupported;

            [FieldOffset(596)]
            internal int globalL1CacheSupported;

            [FieldOffset(600)]
            internal int localL1CacheSupported;

            [FieldOffset(608)]
            internal ulong sharedMemPerMultiprocessor;

            [FieldOffset(616)]
            internal int regsPerMultiprocessor;

            [FieldOffset(620)]
            internal int managedMemory;

            [FieldOffset(624)]
            internal int isMultiGpuBoard;

            [FieldOffset(628)]
            internal int multiGpuBoardGroupID;

            [FieldOffset(632)]
            internal int hostNativeAtomicSupported;

            [FieldOffset(636)]
            internal int singleToDoublePrecisionPerfRatio;

            [FieldOffset(640)]
            internal int pageableMemoryAccess;

            [FieldOffset(644)]
            internal int concurrentManagedAccess;

            [FieldOffset(648)]
            internal int computePreemptionSupported;

            [FieldOffset(652)]
            internal int canUseHostPointerForRegisteredMem;

            [FieldOffset(656)]
            internal int cooperativeLaunch;

            [FieldOffset(660)]
            internal int cooperativeMultiDeviceLaunch;

            [FieldOffset(664)]
            internal ulong sharedMemPerBlockOptin;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaDeviceProp@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaDeviceProp> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaDeviceProp>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaDeviceProp __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaDeviceProp(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaDeviceProp __CreateInstance(global::CUDA.CudaDeviceProp.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaDeviceProp(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaDeviceProp.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaDeviceProp.__Internal));
            *(global::CUDA.CudaDeviceProp.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaDeviceProp(global::CUDA.CudaDeviceProp.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaDeviceProp(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaDeviceProp()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaDeviceProp.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaDeviceProp(global::CUDA.CudaDeviceProp _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaDeviceProp.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaDeviceProp.__Internal*)__Instance) = *((global::CUDA.CudaDeviceProp.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaDeviceProp __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Name
        {
            get
            {
                sbyte[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->name != null)
                {
                    __value = new sbyte[256];
                    for (int i = 0; i < 256; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->name[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 256; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->name[i] = value[i];
                }
            }
        }

        public ulong TotalGlobalMem
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->totalGlobalMem;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->totalGlobalMem = value;
            }
        }

        public ulong SharedMemPerBlock
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->sharedMemPerBlock;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->sharedMemPerBlock = value;
            }
        }

        public int RegsPerBlock
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->regsPerBlock;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->regsPerBlock = value;
            }
        }

        public int WarpSize
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->warpSize;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->warpSize = value;
            }
        }

        public ulong MemPitch
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->memPitch;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->memPitch = value;
            }
        }

        public int MaxThreadsPerBlock
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxThreadsPerBlock;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxThreadsPerBlock = value;
            }
        }

        public int[] MaxThreadsDim
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxThreadsDim != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxThreadsDim[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxThreadsDim[i] = value[i];
                }
            }
        }

        public int[] MaxGridSize
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxGridSize != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxGridSize[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxGridSize[i] = value[i];
                }
            }
        }

        public int ClockRate
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->clockRate;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->clockRate = value;
            }
        }

        public ulong TotalConstMem
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->totalConstMem;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->totalConstMem = value;
            }
        }

        public int Major
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->major;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->major = value;
            }
        }

        public int Minor
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->minor;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->minor = value;
            }
        }

        public ulong TextureAlignment
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->textureAlignment;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->textureAlignment = value;
            }
        }

        public ulong TexturePitchAlignment
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->texturePitchAlignment;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->texturePitchAlignment = value;
            }
        }

        public int DeviceOverlap
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->deviceOverlap;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->deviceOverlap = value;
            }
        }

        public int MultiProcessorCount
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->multiProcessorCount;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->multiProcessorCount = value;
            }
        }

        public int KernelExecTimeoutEnabled
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->kernelExecTimeoutEnabled;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->kernelExecTimeoutEnabled = value;
            }
        }

        public int Integrated
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->integrated;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->integrated = value;
            }
        }

        public int CanMapHostMemory
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->canMapHostMemory;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->canMapHostMemory = value;
            }
        }

        public int ComputeMode
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->computeMode;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->computeMode = value;
            }
        }

        public int MaxTexture1D
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1D;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1D = value;
            }
        }

        public int MaxTexture1DMipmap
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1DMipmap;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1DMipmap = value;
            }
        }

        public int MaxTexture1DLinear
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1DLinear;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1DLinear = value;
            }
        }

        public int[] MaxTexture2D
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2D != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2D[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2D[i] = value[i];
                }
            }
        }

        public int[] MaxTexture2DMipmap
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DMipmap != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DMipmap[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DMipmap[i] = value[i];
                }
            }
        }

        public int[] MaxTexture2DLinear
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DLinear != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DLinear[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DLinear[i] = value[i];
                }
            }
        }

        public int[] MaxTexture2DGather
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DGather != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DGather[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DGather[i] = value[i];
                }
            }
        }

        public int[] MaxTexture3D
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture3D != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture3D[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture3D[i] = value[i];
                }
            }
        }

        public int[] MaxTexture3DAlt
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture3DAlt != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture3DAlt[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture3DAlt[i] = value[i];
                }
            }
        }

        public int MaxTextureCubemap
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTextureCubemap;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTextureCubemap = value;
            }
        }

        public int[] MaxTexture1DLayered
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1DLayered != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1DLayered[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture1DLayered[i] = value[i];
                }
            }
        }

        public int[] MaxTexture2DLayered
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DLayered != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DLayered[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTexture2DLayered[i] = value[i];
                }
            }
        }

        public int[] MaxTextureCubemapLayered
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTextureCubemapLayered != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTextureCubemapLayered[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxTextureCubemapLayered[i] = value[i];
                }
            }
        }

        public int MaxSurface1D
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface1D;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface1D = value;
            }
        }

        public int[] MaxSurface2D
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface2D != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface2D[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface2D[i] = value[i];
                }
            }
        }

        public int[] MaxSurface3D
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface3D != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface3D[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface3D[i] = value[i];
                }
            }
        }

        public int[] MaxSurface1DLayered
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface1DLayered != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface1DLayered[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface1DLayered[i] = value[i];
                }
            }
        }

        public int[] MaxSurface2DLayered
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface2DLayered != null)
                {
                    __value = new int[3];
                    for (int i = 0; i < 3; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface2DLayered[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 3; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurface2DLayered[i] = value[i];
                }
            }
        }

        public int MaxSurfaceCubemap
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurfaceCubemap;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurfaceCubemap = value;
            }
        }

        public int[] MaxSurfaceCubemapLayered
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurfaceCubemapLayered != null)
                {
                    __value = new int[2];
                    for (int i = 0; i < 2; i++)
                        __value[i] = ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurfaceCubemapLayered[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 2; i++)
                        ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxSurfaceCubemapLayered[i] = value[i];
                }
            }
        }

        public ulong SurfaceAlignment
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->surfaceAlignment;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->surfaceAlignment = value;
            }
        }

        public int ConcurrentKernels
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->concurrentKernels;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->concurrentKernels = value;
            }
        }

        public int ECCEnabled
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->ECCEnabled;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->ECCEnabled = value;
            }
        }

        public int PciBusID
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pciBusID;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pciBusID = value;
            }
        }

        public int PciDeviceID
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pciDeviceID;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pciDeviceID = value;
            }
        }

        public int PciDomainID
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pciDomainID;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pciDomainID = value;
            }
        }

        public int TccDriver
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->tccDriver;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->tccDriver = value;
            }
        }

        public int AsyncEngineCount
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->asyncEngineCount;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->asyncEngineCount = value;
            }
        }

        public int UnifiedAddressing
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->unifiedAddressing;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->unifiedAddressing = value;
            }
        }

        public int MemoryClockRate
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->memoryClockRate;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->memoryClockRate = value;
            }
        }

        public int MemoryBusWidth
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->memoryBusWidth;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->memoryBusWidth = value;
            }
        }

        public int L2CacheSize
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->l2CacheSize;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->l2CacheSize = value;
            }
        }

        public int MaxThreadsPerMultiProcessor
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxThreadsPerMultiProcessor;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->maxThreadsPerMultiProcessor = value;
            }
        }

        public int StreamPrioritiesSupported
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->streamPrioritiesSupported;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->streamPrioritiesSupported = value;
            }
        }

        public int GlobalL1CacheSupported
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->globalL1CacheSupported;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->globalL1CacheSupported = value;
            }
        }

        public int LocalL1CacheSupported
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->localL1CacheSupported;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->localL1CacheSupported = value;
            }
        }

        public ulong SharedMemPerMultiprocessor
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->sharedMemPerMultiprocessor;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->sharedMemPerMultiprocessor = value;
            }
        }

        public int RegsPerMultiprocessor
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->regsPerMultiprocessor;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->regsPerMultiprocessor = value;
            }
        }

        public int ManagedMemory
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->managedMemory;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->managedMemory = value;
            }
        }

        public int IsMultiGpuBoard
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->isMultiGpuBoard;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->isMultiGpuBoard = value;
            }
        }

        public int MultiGpuBoardGroupID
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->multiGpuBoardGroupID;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->multiGpuBoardGroupID = value;
            }
        }

        public int HostNativeAtomicSupported
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->hostNativeAtomicSupported;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->hostNativeAtomicSupported = value;
            }
        }

        public int SingleToDoublePrecisionPerfRatio
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->singleToDoublePrecisionPerfRatio;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->singleToDoublePrecisionPerfRatio = value;
            }
        }

        public int PageableMemoryAccess
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pageableMemoryAccess;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->pageableMemoryAccess = value;
            }
        }

        public int ConcurrentManagedAccess
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->concurrentManagedAccess;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->concurrentManagedAccess = value;
            }
        }

        public int ComputePreemptionSupported
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->computePreemptionSupported;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->computePreemptionSupported = value;
            }
        }

        public int CanUseHostPointerForRegisteredMem
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->canUseHostPointerForRegisteredMem;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->canUseHostPointerForRegisteredMem = value;
            }
        }

        public int CooperativeLaunch
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->cooperativeLaunch;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->cooperativeLaunch = value;
            }
        }

        public int CooperativeMultiDeviceLaunch
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->cooperativeMultiDeviceLaunch;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->cooperativeMultiDeviceLaunch = value;
            }
        }

        public ulong SharedMemPerBlockOptin
        {
            get
            {
                return ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->sharedMemPerBlockOptin;
            }

            set
            {
                ((global::CUDA.CudaDeviceProp.__Internal*)__Instance)->sharedMemPerBlockOptin = value;
            }
        }
    }

    /// <summary>CUDA IPC event handle</summary>
    public unsafe partial class CudaIpcEventHandleSt : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserved[64];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaIpcEventHandle_st@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaIpcEventHandleSt> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaIpcEventHandleSt>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaIpcEventHandleSt __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaIpcEventHandleSt(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaIpcEventHandleSt __CreateInstance(global::CUDA.CudaIpcEventHandleSt.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaIpcEventHandleSt(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaIpcEventHandleSt.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaIpcEventHandleSt.__Internal));
            *(global::CUDA.CudaIpcEventHandleSt.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaIpcEventHandleSt(global::CUDA.CudaIpcEventHandleSt.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaIpcEventHandleSt(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaIpcEventHandleSt()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaIpcEventHandleSt.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaIpcEventHandleSt(global::CUDA.CudaIpcEventHandleSt _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaIpcEventHandleSt.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaIpcEventHandleSt.__Internal*)__Instance) = *((global::CUDA.CudaIpcEventHandleSt.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaIpcEventHandleSt __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserved
        {
            get
            {
                sbyte[] __value = null;
                if (((global::CUDA.CudaIpcEventHandleSt.__Internal*)__Instance)->reserved != null)
                {
                    __value = new sbyte[64];
                    for (int i = 0; i < 64; i++)
                        __value[i] = ((global::CUDA.CudaIpcEventHandleSt.__Internal*)__Instance)->reserved[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 64; i++)
                        ((global::CUDA.CudaIpcEventHandleSt.__Internal*)__Instance)->reserved[i] = value[i];
                }
            }
        }
    }

    /// <summary>CUDA IPC memory handle</summary>
    public unsafe partial class CudaIpcMemHandleSt : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed sbyte reserved[64];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaIpcMemHandle_st@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaIpcMemHandleSt> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaIpcMemHandleSt>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaIpcMemHandleSt __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaIpcMemHandleSt(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaIpcMemHandleSt __CreateInstance(global::CUDA.CudaIpcMemHandleSt.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaIpcMemHandleSt(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaIpcMemHandleSt.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaIpcMemHandleSt.__Internal));
            *(global::CUDA.CudaIpcMemHandleSt.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaIpcMemHandleSt(global::CUDA.CudaIpcMemHandleSt.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaIpcMemHandleSt(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaIpcMemHandleSt()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaIpcMemHandleSt.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaIpcMemHandleSt(global::CUDA.CudaIpcMemHandleSt _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaIpcMemHandleSt.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaIpcMemHandleSt.__Internal*)__Instance) = *((global::CUDA.CudaIpcMemHandleSt.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaIpcMemHandleSt __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public sbyte[] Reserved
        {
            get
            {
                sbyte[] __value = null;
                if (((global::CUDA.CudaIpcMemHandleSt.__Internal*)__Instance)->reserved != null)
                {
                    __value = new sbyte[64];
                    for (int i = 0; i < 64; i++)
                        __value[i] = ((global::CUDA.CudaIpcMemHandleSt.__Internal*)__Instance)->reserved[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 64; i++)
                        ((global::CUDA.CudaIpcMemHandleSt.__Internal*)__Instance)->reserved[i] = value[i];
                }
            }
        }
    }

    public unsafe partial class CUstreamSt
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CUstreamSt> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CUstreamSt>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CUstreamSt __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CUstreamSt(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CUstreamSt __CreateInstance(global::CUDA.CUstreamSt.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CUstreamSt(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CUstreamSt.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CUstreamSt.__Internal));
            *(global::CUDA.CUstreamSt.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CUstreamSt(global::CUDA.CUstreamSt.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CUstreamSt(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class CUeventSt
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CUeventSt> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CUeventSt>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CUeventSt __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CUeventSt(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CUeventSt __CreateInstance(global::CUDA.CUeventSt.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CUeventSt(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CUeventSt.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CUeventSt.__Internal));
            *(global::CUDA.CUeventSt.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CUeventSt(global::CUDA.CUeventSt.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CUeventSt(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class CUuuidSt
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CUuuidSt> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CUuuidSt>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CUuuidSt __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CUuuidSt(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CUuuidSt __CreateInstance(global::CUDA.CUuuidSt.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CUuuidSt(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CUuuidSt.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CUuuidSt.__Internal));
            *(global::CUDA.CUuuidSt.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CUuuidSt(global::CUDA.CUuuidSt.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CUuuidSt(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    /// <summary>CUDA launch parameters</summary>
    public unsafe partial class CudaLaunchParams : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 56)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::System.IntPtr func;

            [FieldOffset(8)]
            internal global::CUDA.Dim3.__Internal gridDim;

            [FieldOffset(20)]
            internal global::CUDA.Dim3.__Internal blockDim;

            [FieldOffset(32)]
            internal global::System.IntPtr args;

            [FieldOffset(40)]
            internal ulong sharedMem;

            [FieldOffset(48)]
            internal global::System.IntPtr stream;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaLaunchParams@@QEAA@XZ")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaLaunchParams@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaLaunchParams> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaLaunchParams>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaLaunchParams __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaLaunchParams(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaLaunchParams __CreateInstance(global::CUDA.CudaLaunchParams.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaLaunchParams(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaLaunchParams.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaLaunchParams.__Internal));
            *(global::CUDA.CudaLaunchParams.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaLaunchParams(global::CUDA.CudaLaunchParams.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaLaunchParams(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaLaunchParams()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaLaunchParams.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            __Internal.ctor((__Instance + __PointerAdjustment));
        }

        public CudaLaunchParams(global::CUDA.CudaLaunchParams _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaLaunchParams.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaLaunchParams.__Internal*)__Instance) = *((global::CUDA.CudaLaunchParams.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaLaunchParams __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::System.IntPtr Func
        {
            get
            {
                return ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->func;
            }

            set
            {
                ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->func = (global::System.IntPtr)value;
            }
        }

        public global::CUDA.Dim3 GridDim
        {
            get
            {
                return global::CUDA.Dim3.__CreateInstance(((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->gridDim);
            }

            set
            {
                ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->gridDim = ReferenceEquals(value, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.Dim3 BlockDim
        {
            get
            {
                return global::CUDA.Dim3.__CreateInstance(((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->blockDim);
            }

            set
            {
                ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->blockDim = ReferenceEquals(value, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)value.__Instance;
            }
        }

        public void** Args
        {
            get
            {
                return (void**)((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->args;
            }

            set
            {
                ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->args = (global::System.IntPtr)value;
            }
        }

        public ulong SharedMem
        {
            get
            {
                return ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->sharedMem;
            }

            set
            {
                ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->sharedMem = value;
            }
        }

        public global::CUDA.CUstreamSt Stream
        {
            get
            {
                global::CUDA.CUstreamSt __result0;
                if (((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->stream == IntPtr.Zero) __result0 = null;
                else if (global::CUDA.CUstreamSt.NativeToManagedMap.ContainsKey(((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->stream))
                    __result0 = (global::CUDA.CUstreamSt)global::CUDA.CUstreamSt.NativeToManagedMap[((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->stream];
                else __result0 = global::CUDA.CUstreamSt.__CreateInstance(((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->stream);
                return __result0;
            }

            set
            {
                ((global::CUDA.CudaLaunchParams.__Internal*)__Instance)->stream = ReferenceEquals(value, null) ? global::System.IntPtr.Zero : value.__Instance;
            }
        }
    }

    /// <summary>CUDA Surface boundary modes</summary>
    public enum CudaSurfaceBoundaryMode
    {
        /// <summary>Zero boundary mode</summary>
        CudaBoundaryModeZero = 0,
        /// <summary>Clamp boundary mode</summary>
        CudaBoundaryModeClamp = 1,
        /// <summary>Trap boundary mode</summary>
        CudaBoundaryModeTrap = 2
    }

    /// <summary>CUDA Surface format modes</summary>
    public enum CudaSurfaceFormatMode
    {
        /// <summary>Forced format mode</summary>
        CudaFormatModeForced = 0,
        /// <summary>Auto format mode</summary>
        CudaFormatModeAuto = 1
    }

    /// <summary>An opaque value that represents a CUDA Surface object</summary>
    /// <summary>CUDA Surface reference</summary>
    public unsafe partial class SurfaceReference : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 20)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::CUDA.CudaChannelFormatDesc.__Internal channelDesc;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0surfaceReference@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.SurfaceReference> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.SurfaceReference>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.SurfaceReference __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.SurfaceReference(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.SurfaceReference __CreateInstance(global::CUDA.SurfaceReference.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.SurfaceReference(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.SurfaceReference.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.SurfaceReference.__Internal));
            *(global::CUDA.SurfaceReference.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private SurfaceReference(global::CUDA.SurfaceReference.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected SurfaceReference(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public SurfaceReference()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.SurfaceReference.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public SurfaceReference(global::CUDA.SurfaceReference _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.SurfaceReference.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.SurfaceReference.__Internal*)__Instance) = *((global::CUDA.SurfaceReference.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.SurfaceReference __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CUDA.CudaChannelFormatDesc ChannelDesc
        {
            get
            {
                return global::CUDA.CudaChannelFormatDesc.__CreateInstance(((global::CUDA.SurfaceReference.__Internal*)__Instance)->channelDesc);
            }

            set
            {
                ((global::CUDA.SurfaceReference.__Internal*)__Instance)->channelDesc = ReferenceEquals(value, null) ? new global::CUDA.CudaChannelFormatDesc.__Internal() : *(global::CUDA.CudaChannelFormatDesc.__Internal*)value.__Instance;
            }
        }
    }

    /// <summary>CUDA texture address modes</summary>
    public enum CudaTextureAddressMode
    {
        /// <summary>Wrapping address mode</summary>
        CudaAddressModeWrap = 0,
        /// <summary>Clamp to edge address mode</summary>
        CudaAddressModeClamp = 1,
        /// <summary>Mirror address mode</summary>
        CudaAddressModeMirror = 2,
        /// <summary>Border address mode</summary>
        CudaAddressModeBorder = 3
    }

    /// <summary>CUDA texture filter modes</summary>
    public enum CudaTextureFilterMode
    {
        /// <summary>Point filter mode</summary>
        CudaFilterModePoint = 0,
        /// <summary>Linear filter mode</summary>
        CudaFilterModeLinear = 1
    }

    /// <summary>CUDA texture read modes</summary>
    public enum CudaTextureReadMode
    {
        /// <summary>Read texture as specified element type</summary>
        CudaReadModeElementType = 0,
        /// <summary>Read texture as normalized float</summary>
        CudaReadModeNormalizedFloat = 1
    }

    /// <summary>An opaque value that represents a CUDA texture object</summary>
    /// <summary>CUDA texture reference</summary>
    public unsafe partial class TextureReference : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 124)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal int normalized;

            [FieldOffset(4)]
            internal global::CUDA.CudaTextureFilterMode filterMode;

            [FieldOffset(8)]
            internal fixed int addressMode[3];

            [FieldOffset(20)]
            internal global::CUDA.CudaChannelFormatDesc.__Internal channelDesc;

            [FieldOffset(40)]
            internal int sRGB;

            [FieldOffset(44)]
            internal uint maxAnisotropy;

            [FieldOffset(48)]
            internal global::CUDA.CudaTextureFilterMode mipmapFilterMode;

            [FieldOffset(52)]
            internal float mipmapLevelBias;

            [FieldOffset(56)]
            internal float minMipmapLevelClamp;

            [FieldOffset(60)]
            internal float maxMipmapLevelClamp;

            [FieldOffset(64)]
            internal fixed int __cudaReserved[15];

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0textureReference@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.TextureReference> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.TextureReference>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.TextureReference __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.TextureReference(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.TextureReference __CreateInstance(global::CUDA.TextureReference.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.TextureReference(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.TextureReference.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.TextureReference.__Internal));
            *(global::CUDA.TextureReference.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private TextureReference(global::CUDA.TextureReference.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected TextureReference(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public TextureReference()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.TextureReference.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public TextureReference(global::CUDA.TextureReference _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.TextureReference.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.TextureReference.__Internal*)__Instance) = *((global::CUDA.TextureReference.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.TextureReference __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public int Normalized
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->normalized;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->normalized = value;
            }
        }

        public global::CUDA.CudaTextureFilterMode FilterMode
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->filterMode;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->filterMode = value;
            }
        }

        public global::CUDA.CudaChannelFormatDesc ChannelDesc
        {
            get
            {
                return global::CUDA.CudaChannelFormatDesc.__CreateInstance(((global::CUDA.TextureReference.__Internal*)__Instance)->channelDesc);
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->channelDesc = ReferenceEquals(value, null) ? new global::CUDA.CudaChannelFormatDesc.__Internal() : *(global::CUDA.CudaChannelFormatDesc.__Internal*)value.__Instance;
            }
        }

        public int SRGB
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->sRGB;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->sRGB = value;
            }
        }

        public uint MaxAnisotropy
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->maxAnisotropy;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->maxAnisotropy = value;
            }
        }

        public global::CUDA.CudaTextureFilterMode MipmapFilterMode
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->mipmapFilterMode;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->mipmapFilterMode = value;
            }
        }

        public float MipmapLevelBias
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->mipmapLevelBias;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->mipmapLevelBias = value;
            }
        }

        public float MinMipmapLevelClamp
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->minMipmapLevelClamp;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->minMipmapLevelClamp = value;
            }
        }

        public float MaxMipmapLevelClamp
        {
            get
            {
                return ((global::CUDA.TextureReference.__Internal*)__Instance)->maxMipmapLevelClamp;
            }

            set
            {
                ((global::CUDA.TextureReference.__Internal*)__Instance)->maxMipmapLevelClamp = value;
            }
        }

        public int[] CudaReserved
        {
            get
            {
                int[] __value = null;
                if (((global::CUDA.TextureReference.__Internal*)__Instance)->__cudaReserved != null)
                {
                    __value = new int[15];
                    for (int i = 0; i < 15; i++)
                        __value[i] = ((global::CUDA.TextureReference.__Internal*)__Instance)->__cudaReserved[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 15; i++)
                        ((global::CUDA.TextureReference.__Internal*)__Instance)->__cudaReserved[i] = value[i];
                }
            }
        }
    }

    /// <summary>CUDA texture descriptor</summary>
    public unsafe partial class CudaTextureDesc : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 64)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal fixed int addressMode[3];

            [FieldOffset(12)]
            internal global::CUDA.CudaTextureFilterMode filterMode;

            [FieldOffset(16)]
            internal global::CUDA.CudaTextureReadMode readMode;

            [FieldOffset(20)]
            internal int sRGB;

            [FieldOffset(24)]
            internal fixed float borderColor[4];

            [FieldOffset(40)]
            internal int normalizedCoords;

            [FieldOffset(44)]
            internal uint maxAnisotropy;

            [FieldOffset(48)]
            internal global::CUDA.CudaTextureFilterMode mipmapFilterMode;

            [FieldOffset(52)]
            internal float mipmapLevelBias;

            [FieldOffset(56)]
            internal float minMipmapLevelClamp;

            [FieldOffset(60)]
            internal float maxMipmapLevelClamp;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0cudaTextureDesc@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaTextureDesc> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CudaTextureDesc>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CudaTextureDesc __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CudaTextureDesc(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CudaTextureDesc __CreateInstance(global::CUDA.CudaTextureDesc.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CudaTextureDesc(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CudaTextureDesc.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaTextureDesc.__Internal));
            *(global::CUDA.CudaTextureDesc.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CudaTextureDesc(global::CUDA.CudaTextureDesc.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CudaTextureDesc(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public CudaTextureDesc()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaTextureDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public CudaTextureDesc(global::CUDA.CudaTextureDesc _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.CudaTextureDesc.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.CudaTextureDesc.__Internal*)__Instance) = *((global::CUDA.CudaTextureDesc.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.CudaTextureDesc __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public global::CUDA.CudaTextureFilterMode FilterMode
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->filterMode;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->filterMode = value;
            }
        }

        public global::CUDA.CudaTextureReadMode ReadMode
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->readMode;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->readMode = value;
            }
        }

        public int SRGB
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->sRGB;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->sRGB = value;
            }
        }

        public float[] BorderColor
        {
            get
            {
                float[] __value = null;
                if (((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->borderColor != null)
                {
                    __value = new float[4];
                    for (int i = 0; i < 4; i++)
                        __value[i] = ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->borderColor[i];
                }
                return __value;
            }

            set
            {
                if (value != null)
                {
                    for (int i = 0; i < 4; i++)
                        ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->borderColor[i] = value[i];
                }
            }
        }

        public int NormalizedCoords
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->normalizedCoords;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->normalizedCoords = value;
            }
        }

        public uint MaxAnisotropy
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->maxAnisotropy;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->maxAnisotropy = value;
            }
        }

        public global::CUDA.CudaTextureFilterMode MipmapFilterMode
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->mipmapFilterMode;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->mipmapFilterMode = value;
            }
        }

        public float MipmapLevelBias
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->mipmapLevelBias;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->mipmapLevelBias = value;
            }
        }

        public float MinMipmapLevelClamp
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->minMipmapLevelClamp;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->minMipmapLevelClamp = value;
            }
        }

        public float MaxMipmapLevelClamp
        {
            get
            {
                return ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->maxMipmapLevelClamp;
            }

            set
            {
                ((global::CUDA.CudaTextureDesc.__Internal*)__Instance)->maxMipmapLevelClamp = value;
            }
        }
    }

    public unsafe partial class ChannelDescriptor
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cudaCreateChannelDescHalf@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDescHalf(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cudaCreateChannelDescHalf1@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDescHalf1(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cudaCreateChannelDescHalf2@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDescHalf2(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cudaCreateChannelDescHalf4@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDescHalf4(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@C@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@E@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc1(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uchar1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc2(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uuchar1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc3(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uchar2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc4(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uuchar2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc5(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uchar4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc6(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uuchar4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc7(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@F@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc8(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@G@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc9(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ushort1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc10(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uushort1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc11(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ushort2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc12(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uushort2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc13(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ushort4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc14(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uushort4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc15(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@H@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc16(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@I@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc17(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uint1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc18(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uuint1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc19(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uint2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc20(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uuint2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc21(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uint4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc22(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uuint4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc23(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@J@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc24(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@K@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc25(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ulong1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc26(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uulong1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc27(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ulong2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc28(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uulong2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc29(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ulong4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc30(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Uulong4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc31(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@M@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc32(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ufloat1@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc33(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ufloat2@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc34(global::System.IntPtr @return);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??$cudaCreateChannelDesc@Ufloat4@@@@YA?AUcudaChannelFormatDesc@@XZ")]
            internal static extern void CudaCreateChannelDesc35(global::System.IntPtr @return);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDescHalf()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDescHalf(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDescHalf1()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDescHalf1(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDescHalf2()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDescHalf2(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDescHalf4()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDescHalf4(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc1()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc1(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc2()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc2(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc3()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc3(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc4()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc4(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc5()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc5(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc6()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc6(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc7()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc7(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc8()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc8(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc9()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc9(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc10()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc10(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc11()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc11(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc12()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc12(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc13()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc13(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc14()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc14(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc15()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc15(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc16()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc16(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc17()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc17(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc18()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc18(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc19()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc19(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc20()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc20(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc21()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc21(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc22()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc22(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc23()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc23(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc24()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc24(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc25()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc25(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc26()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc26(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc27()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc27(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc28()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc28(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc29()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc29(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc30()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc30(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc31()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc31(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc32()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc32(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc33()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc33(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc34()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc34(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc35()
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc35(new IntPtr(&__ret));
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }
    }

    /// <summary>Type of stream callback functions.</summary>
    /// <param name="stream">The stream as passed to ::cudaStreamAddCallback, may be NULL.</param>
    /// <param name="status">::cudaSuccess or any persistent error on the stream.</param>
    /// <param name="userData">User parameter provided at registration.</param>
    [SuppressUnmanagedCodeSecurity, UnmanagedFunctionPointer(global::System.Runtime.InteropServices.CallingConvention.Cdecl)]
    public unsafe delegate void CudaStreamCallbackT(global::System.IntPtr stream, global::CUDA.CudaError status, global::System.IntPtr userData);

    public unsafe partial class RuntimeApi
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceReset")]
            internal static extern global::CUDA.CudaError CudaDeviceReset();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceSynchronize")]
            internal static extern global::CUDA.CudaError CudaDeviceSynchronize();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceSetLimit")]
            internal static extern global::CUDA.CudaError CudaDeviceSetLimit(global::CUDA.CudaLimit limit, ulong value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetLimit")]
            internal static extern global::CUDA.CudaError CudaDeviceGetLimit(ulong* pValue, global::CUDA.CudaLimit limit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetCacheConfig")]
            internal static extern global::CUDA.CudaError CudaDeviceGetCacheConfig(global::CUDA.CudaFuncCache* pCacheConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetStreamPriorityRange")]
            internal static extern global::CUDA.CudaError CudaDeviceGetStreamPriorityRange(int* leastPriority, int* greatestPriority);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceSetCacheConfig")]
            internal static extern global::CUDA.CudaError CudaDeviceSetCacheConfig(global::CUDA.CudaFuncCache cacheConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetSharedMemConfig")]
            internal static extern global::CUDA.CudaError CudaDeviceGetSharedMemConfig(global::CUDA.CudaSharedMemConfig* pConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceSetSharedMemConfig")]
            internal static extern global::CUDA.CudaError CudaDeviceSetSharedMemConfig(global::CUDA.CudaSharedMemConfig config);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetByPCIBusId")]
            internal static extern global::CUDA.CudaError CudaDeviceGetByPCIBusId(int* device, [MarshalAs(UnmanagedType.LPStr)] string pciBusId);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetPCIBusId")]
            internal static extern global::CUDA.CudaError CudaDeviceGetPCIBusId(sbyte* pciBusId, int len, int device);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaIpcGetEventHandle")]
            internal static extern global::CUDA.CudaError CudaIpcGetEventHandle(global::System.IntPtr handle, global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaIpcOpenEventHandle")]
            internal static extern global::CUDA.CudaError CudaIpcOpenEventHandle(global::System.IntPtr @event, global::CUDA.CudaIpcEventHandleSt.__Internal handle);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaIpcGetMemHandle")]
            internal static extern global::CUDA.CudaError CudaIpcGetMemHandle(global::System.IntPtr handle, global::System.IntPtr devPtr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaIpcOpenMemHandle")]
            internal static extern global::CUDA.CudaError CudaIpcOpenMemHandle(void** devPtr, global::CUDA.CudaIpcMemHandleSt.__Internal handle, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaIpcCloseMemHandle")]
            internal static extern global::CUDA.CudaError CudaIpcCloseMemHandle(global::System.IntPtr devPtr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaThreadExit")]
            internal static extern global::CUDA.CudaError CudaThreadExit();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaThreadSynchronize")]
            internal static extern global::CUDA.CudaError CudaThreadSynchronize();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaThreadSetLimit")]
            internal static extern global::CUDA.CudaError CudaThreadSetLimit(global::CUDA.CudaLimit limit, ulong value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaThreadGetLimit")]
            internal static extern global::CUDA.CudaError CudaThreadGetLimit(ulong* pValue, global::CUDA.CudaLimit limit);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaThreadGetCacheConfig")]
            internal static extern global::CUDA.CudaError CudaThreadGetCacheConfig(global::CUDA.CudaFuncCache* pCacheConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaThreadSetCacheConfig")]
            internal static extern global::CUDA.CudaError CudaThreadSetCacheConfig(global::CUDA.CudaFuncCache cacheConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetLastError")]
            internal static extern global::CUDA.CudaError CudaGetLastError();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaPeekAtLastError")]
            internal static extern global::CUDA.CudaError CudaPeekAtLastError();

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetErrorName")]
            internal static extern global::System.IntPtr CudaGetErrorName(global::CUDA.CudaError error);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetErrorString")]
            internal static extern global::System.IntPtr CudaGetErrorString(global::CUDA.CudaError error);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetDeviceCount")]
            internal static extern global::CUDA.CudaError CudaGetDeviceCount(int* count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetDeviceProperties")]
            internal static extern global::CUDA.CudaError CudaGetDeviceProperties(global::System.IntPtr prop, int device);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetAttribute")]
            internal static extern global::CUDA.CudaError CudaDeviceGetAttribute(int* value, global::CUDA.CudaDeviceAttr attr, int device);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceGetP2PAttribute")]
            internal static extern global::CUDA.CudaError CudaDeviceGetP2PAttribute(int* value, global::CUDA.CudaDeviceP2PAttr attr, int srcDevice, int dstDevice);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaChooseDevice")]
            internal static extern global::CUDA.CudaError CudaChooseDevice(int* device, global::System.IntPtr prop);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaSetDevice")]
            internal static extern global::CUDA.CudaError CudaSetDevice(int device);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetDevice")]
            internal static extern global::CUDA.CudaError CudaGetDevice(int* device);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaSetValidDevices")]
            internal static extern global::CUDA.CudaError CudaSetValidDevices(int* device_arr, int len);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaSetDeviceFlags")]
            internal static extern global::CUDA.CudaError CudaSetDeviceFlags(uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetDeviceFlags")]
            internal static extern global::CUDA.CudaError CudaGetDeviceFlags(uint* flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamCreate")]
            internal static extern global::CUDA.CudaError CudaStreamCreate(global::System.IntPtr pStream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamCreateWithFlags")]
            internal static extern global::CUDA.CudaError CudaStreamCreateWithFlags(global::System.IntPtr pStream, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamCreateWithPriority")]
            internal static extern global::CUDA.CudaError CudaStreamCreateWithPriority(global::System.IntPtr pStream, uint flags, int priority);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamGetPriority")]
            internal static extern global::CUDA.CudaError CudaStreamGetPriority(global::System.IntPtr hStream, int* priority);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamGetFlags")]
            internal static extern global::CUDA.CudaError CudaStreamGetFlags(global::System.IntPtr hStream, uint* flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamDestroy")]
            internal static extern global::CUDA.CudaError CudaStreamDestroy(global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamWaitEvent")]
            internal static extern global::CUDA.CudaError CudaStreamWaitEvent(global::System.IntPtr stream, global::System.IntPtr @event, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamAddCallback")]
            internal static extern global::CUDA.CudaError CudaStreamAddCallback(global::System.IntPtr stream, global::System.IntPtr callback, global::System.IntPtr userData, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamSynchronize")]
            internal static extern global::CUDA.CudaError CudaStreamSynchronize(global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamQuery")]
            internal static extern global::CUDA.CudaError CudaStreamQuery(global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaStreamAttachMemAsync")]
            internal static extern global::CUDA.CudaError CudaStreamAttachMemAsync(global::System.IntPtr stream, global::System.IntPtr devPtr, ulong length, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaEventCreate")]
            internal static extern global::CUDA.CudaError CudaEventCreate(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaEventCreateWithFlags")]
            internal static extern global::CUDA.CudaError CudaEventCreateWithFlags(global::System.IntPtr @event, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaEventRecord")]
            internal static extern global::CUDA.CudaError CudaEventRecord(global::System.IntPtr @event, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaEventQuery")]
            internal static extern global::CUDA.CudaError CudaEventQuery(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaEventSynchronize")]
            internal static extern global::CUDA.CudaError CudaEventSynchronize(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaEventDestroy")]
            internal static extern global::CUDA.CudaError CudaEventDestroy(global::System.IntPtr @event);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaEventElapsedTime")]
            internal static extern global::CUDA.CudaError CudaEventElapsedTime(float* ms, global::System.IntPtr start, global::System.IntPtr end);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaLaunchKernel")]
            internal static extern global::CUDA.CudaError CudaLaunchKernel(global::System.IntPtr func, global::CUDA.Dim3.__Internal gridDim, global::CUDA.Dim3.__Internal blockDim, void** args, ulong sharedMem, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaLaunchCooperativeKernel")]
            internal static extern global::CUDA.CudaError CudaLaunchCooperativeKernel(global::System.IntPtr func, global::CUDA.Dim3.__Internal gridDim, global::CUDA.Dim3.__Internal blockDim, void** args, ulong sharedMem, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaLaunchCooperativeKernelMultiDevice")]
            internal static extern global::CUDA.CudaError CudaLaunchCooperativeKernelMultiDevice(global::System.IntPtr launchParamsList, uint numDevices, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFuncSetCacheConfig")]
            internal static extern global::CUDA.CudaError CudaFuncSetCacheConfig(global::System.IntPtr func, global::CUDA.CudaFuncCache cacheConfig);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFuncSetSharedMemConfig")]
            internal static extern global::CUDA.CudaError CudaFuncSetSharedMemConfig(global::System.IntPtr func, global::CUDA.CudaSharedMemConfig config);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFuncGetAttributes")]
            internal static extern global::CUDA.CudaError CudaFuncGetAttributes(global::System.IntPtr attr, global::System.IntPtr func);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFuncSetAttribute")]
            internal static extern global::CUDA.CudaError CudaFuncSetAttribute(global::System.IntPtr func, global::CUDA.CudaFuncAttribute attr, int value);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaSetDoubleForDevice")]
            internal static extern global::CUDA.CudaError CudaSetDoubleForDevice(double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaSetDoubleForHost")]
            internal static extern global::CUDA.CudaError CudaSetDoubleForHost(double* d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaOccupancyMaxActiveBlocksPerMultiprocessor")]
            internal static extern global::CUDA.CudaError CudaOccupancyMaxActiveBlocksPerMultiprocessor(int* numBlocks, global::System.IntPtr func, int blockSize, ulong dynamicSMemSize);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags")]
            internal static extern global::CUDA.CudaError CudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags(int* numBlocks, global::System.IntPtr func, int blockSize, ulong dynamicSMemSize, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaConfigureCall")]
            internal static extern global::CUDA.CudaError CudaConfigureCall(global::CUDA.Dim3.__Internal gridDim, global::CUDA.Dim3.__Internal blockDim, ulong sharedMem, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaSetupArgument")]
            internal static extern global::CUDA.CudaError CudaSetupArgument(global::System.IntPtr arg, ulong size, ulong offset);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaLaunch")]
            internal static extern global::CUDA.CudaError CudaLaunch(global::System.IntPtr func);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMallocManaged")]
            internal static extern global::CUDA.CudaError CudaMallocManaged(void** devPtr, ulong size, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMalloc")]
            internal static extern global::CUDA.CudaError CudaMalloc(void** devPtr, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMallocHost")]
            internal static extern global::CUDA.CudaError CudaMallocHost(void** ptr, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMallocPitch")]
            internal static extern global::CUDA.CudaError CudaMallocPitch(void** devPtr, ulong* pitch, ulong width, ulong height);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMallocArray")]
            internal static extern global::CUDA.CudaError CudaMallocArray(global::System.IntPtr array, global::System.IntPtr desc, ulong width, ulong height, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFree")]
            internal static extern global::CUDA.CudaError CudaFree(global::System.IntPtr devPtr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFreeHost")]
            internal static extern global::CUDA.CudaError CudaFreeHost(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFreeArray")]
            internal static extern global::CUDA.CudaError CudaFreeArray(global::System.IntPtr array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaFreeMipmappedArray")]
            internal static extern global::CUDA.CudaError CudaFreeMipmappedArray(global::System.IntPtr mipmappedArray);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaHostAlloc")]
            internal static extern global::CUDA.CudaError CudaHostAlloc(void** pHost, ulong size, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaHostRegister")]
            internal static extern global::CUDA.CudaError CudaHostRegister(global::System.IntPtr ptr, ulong size, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaHostUnregister")]
            internal static extern global::CUDA.CudaError CudaHostUnregister(global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaHostGetDevicePointer")]
            internal static extern global::CUDA.CudaError CudaHostGetDevicePointer(void** pDevice, global::System.IntPtr pHost, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaHostGetFlags")]
            internal static extern global::CUDA.CudaError CudaHostGetFlags(uint* pFlags, global::System.IntPtr pHost);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMalloc3D")]
            internal static extern global::CUDA.CudaError CudaMalloc3D(global::System.IntPtr pitchedDevPtr, global::CUDA.CudaExtent.__Internal extent);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMalloc3DArray")]
            internal static extern global::CUDA.CudaError CudaMalloc3DArray(global::System.IntPtr array, global::System.IntPtr desc, global::CUDA.CudaExtent.__Internal extent, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMallocMipmappedArray")]
            internal static extern global::CUDA.CudaError CudaMallocMipmappedArray(global::System.IntPtr mipmappedArray, global::System.IntPtr desc, global::CUDA.CudaExtent.__Internal extent, uint numLevels, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetMipmappedArrayLevel")]
            internal static extern global::CUDA.CudaError CudaGetMipmappedArrayLevel(global::System.IntPtr levelArray, global::System.IntPtr mipmappedArray, uint level);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy3D")]
            internal static extern global::CUDA.CudaError CudaMemcpy3D(global::System.IntPtr p);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy3DPeer")]
            internal static extern global::CUDA.CudaError CudaMemcpy3DPeer(global::System.IntPtr p);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy3DAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpy3DAsync(global::System.IntPtr p, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy3DPeerAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpy3DPeerAsync(global::System.IntPtr p, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemGetInfo")]
            internal static extern global::CUDA.CudaError CudaMemGetInfo(ulong* free, ulong* total);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaArrayGetInfo")]
            internal static extern global::CUDA.CudaError CudaArrayGetInfo(global::System.IntPtr desc, global::System.IntPtr extent, uint* flags, global::System.IntPtr array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy")]
            internal static extern global::CUDA.CudaError CudaMemcpy(global::System.IntPtr dst, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyPeer")]
            internal static extern global::CUDA.CudaError CudaMemcpyPeer(global::System.IntPtr dst, int dstDevice, global::System.IntPtr src, int srcDevice, ulong count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyToArray")]
            internal static extern global::CUDA.CudaError CudaMemcpyToArray(global::System.IntPtr dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyFromArray")]
            internal static extern global::CUDA.CudaError CudaMemcpyFromArray(global::System.IntPtr dst, global::System.IntPtr src, ulong wOffset, ulong hOffset, ulong count, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyArrayToArray")]
            internal static extern global::CUDA.CudaError CudaMemcpyArrayToArray(global::System.IntPtr dst, ulong wOffsetDst, ulong hOffsetDst, global::System.IntPtr src, ulong wOffsetSrc, ulong hOffsetSrc, ulong count, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy2D")]
            internal static extern global::CUDA.CudaError CudaMemcpy2D(global::System.IntPtr dst, ulong dpitch, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy2DToArray")]
            internal static extern global::CUDA.CudaError CudaMemcpy2DToArray(global::System.IntPtr dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy2DFromArray")]
            internal static extern global::CUDA.CudaError CudaMemcpy2DFromArray(global::System.IntPtr dst, ulong dpitch, global::System.IntPtr src, ulong wOffset, ulong hOffset, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy2DArrayToArray")]
            internal static extern global::CUDA.CudaError CudaMemcpy2DArrayToArray(global::System.IntPtr dst, ulong wOffsetDst, ulong hOffsetDst, global::System.IntPtr src, ulong wOffsetSrc, ulong hOffsetSrc, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyToSymbol")]
            internal static extern global::CUDA.CudaError CudaMemcpyToSymbol(global::System.IntPtr symbol, global::System.IntPtr src, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyFromSymbol")]
            internal static extern global::CUDA.CudaError CudaMemcpyFromSymbol(global::System.IntPtr dst, global::System.IntPtr symbol, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpyAsync(global::System.IntPtr dst, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyPeerAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpyPeerAsync(global::System.IntPtr dst, int dstDevice, global::System.IntPtr src, int srcDevice, ulong count, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyToArrayAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpyToArrayAsync(global::System.IntPtr dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyFromArrayAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpyFromArrayAsync(global::System.IntPtr dst, global::System.IntPtr src, ulong wOffset, ulong hOffset, ulong count, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy2DAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpy2DAsync(global::System.IntPtr dst, ulong dpitch, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy2DToArrayAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpy2DToArrayAsync(global::System.IntPtr dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpy2DFromArrayAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpy2DFromArrayAsync(global::System.IntPtr dst, ulong dpitch, global::System.IntPtr src, ulong wOffset, ulong hOffset, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyToSymbolAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpyToSymbolAsync(global::System.IntPtr symbol, global::System.IntPtr src, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemcpyFromSymbolAsync")]
            internal static extern global::CUDA.CudaError CudaMemcpyFromSymbolAsync(global::System.IntPtr dst, global::System.IntPtr symbol, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemset")]
            internal static extern global::CUDA.CudaError CudaMemset(global::System.IntPtr devPtr, int value, ulong count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemset2D")]
            internal static extern global::CUDA.CudaError CudaMemset2D(global::System.IntPtr devPtr, ulong pitch, int value, ulong width, ulong height);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemset3D")]
            internal static extern global::CUDA.CudaError CudaMemset3D(global::CUDA.CudaPitchedPtr.__Internal pitchedDevPtr, int value, global::CUDA.CudaExtent.__Internal extent);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemsetAsync")]
            internal static extern global::CUDA.CudaError CudaMemsetAsync(global::System.IntPtr devPtr, int value, ulong count, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemset2DAsync")]
            internal static extern global::CUDA.CudaError CudaMemset2DAsync(global::System.IntPtr devPtr, ulong pitch, int value, ulong width, ulong height, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemset3DAsync")]
            internal static extern global::CUDA.CudaError CudaMemset3DAsync(global::CUDA.CudaPitchedPtr.__Internal pitchedDevPtr, int value, global::CUDA.CudaExtent.__Internal extent, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetSymbolAddress")]
            internal static extern global::CUDA.CudaError CudaGetSymbolAddress(void** devPtr, global::System.IntPtr symbol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetSymbolSize")]
            internal static extern global::CUDA.CudaError CudaGetSymbolSize(ulong* size, global::System.IntPtr symbol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemPrefetchAsync")]
            internal static extern global::CUDA.CudaError CudaMemPrefetchAsync(global::System.IntPtr devPtr, ulong count, int dstDevice, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemAdvise")]
            internal static extern global::CUDA.CudaError CudaMemAdvise(global::System.IntPtr devPtr, ulong count, global::CUDA.CudaMemoryAdvise advice, int device);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemRangeGetAttribute")]
            internal static extern global::CUDA.CudaError CudaMemRangeGetAttribute(global::System.IntPtr data, ulong dataSize, global::CUDA.CudaMemRangeAttribute attribute, global::System.IntPtr devPtr, ulong count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaMemRangeGetAttributes")]
            internal static extern global::CUDA.CudaError CudaMemRangeGetAttributes(void** data, ulong* dataSizes, global::CUDA.CudaMemRangeAttribute* attributes, ulong numAttributes, global::System.IntPtr devPtr, ulong count);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaPointerGetAttributes")]
            internal static extern global::CUDA.CudaError CudaPointerGetAttributes(global::System.IntPtr attributes, global::System.IntPtr ptr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceCanAccessPeer")]
            internal static extern global::CUDA.CudaError CudaDeviceCanAccessPeer(int* canAccessPeer, int device, int peerDevice);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceEnablePeerAccess")]
            internal static extern global::CUDA.CudaError CudaDeviceEnablePeerAccess(int peerDevice, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDeviceDisablePeerAccess")]
            internal static extern global::CUDA.CudaError CudaDeviceDisablePeerAccess(int peerDevice);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGraphicsUnregisterResource")]
            internal static extern global::CUDA.CudaError CudaGraphicsUnregisterResource(global::System.IntPtr resource);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGraphicsResourceSetMapFlags")]
            internal static extern global::CUDA.CudaError CudaGraphicsResourceSetMapFlags(global::System.IntPtr resource, uint flags);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGraphicsMapResources")]
            internal static extern global::CUDA.CudaError CudaGraphicsMapResources(int count, global::System.IntPtr resources, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGraphicsUnmapResources")]
            internal static extern global::CUDA.CudaError CudaGraphicsUnmapResources(int count, global::System.IntPtr resources, global::System.IntPtr stream);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGraphicsResourceGetMappedPointer")]
            internal static extern global::CUDA.CudaError CudaGraphicsResourceGetMappedPointer(void** devPtr, ulong* size, global::System.IntPtr resource);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGraphicsSubResourceGetMappedArray")]
            internal static extern global::CUDA.CudaError CudaGraphicsSubResourceGetMappedArray(global::System.IntPtr array, global::System.IntPtr resource, uint arrayIndex, uint mipLevel);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGraphicsResourceGetMappedMipmappedArray")]
            internal static extern global::CUDA.CudaError CudaGraphicsResourceGetMappedMipmappedArray(global::System.IntPtr mipmappedArray, global::System.IntPtr resource);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetChannelDesc")]
            internal static extern global::CUDA.CudaError CudaGetChannelDesc(global::System.IntPtr desc, global::System.IntPtr array);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaCreateChannelDesc")]
            internal static extern void CudaCreateChannelDesc(global::System.IntPtr @return, int x, int y, int z, int w, global::CUDA.CudaChannelFormatKind f);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaBindTexture")]
            internal static extern global::CUDA.CudaError CudaBindTexture(ulong* offset, global::System.IntPtr texref, global::System.IntPtr devPtr, global::System.IntPtr desc, ulong size);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaBindTexture2D")]
            internal static extern global::CUDA.CudaError CudaBindTexture2D(ulong* offset, global::System.IntPtr texref, global::System.IntPtr devPtr, global::System.IntPtr desc, ulong width, ulong height, ulong pitch);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaBindTextureToArray")]
            internal static extern global::CUDA.CudaError CudaBindTextureToArray(global::System.IntPtr texref, global::System.IntPtr array, global::System.IntPtr desc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaBindTextureToMipmappedArray")]
            internal static extern global::CUDA.CudaError CudaBindTextureToMipmappedArray(global::System.IntPtr texref, global::System.IntPtr mipmappedArray, global::System.IntPtr desc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaUnbindTexture")]
            internal static extern global::CUDA.CudaError CudaUnbindTexture(global::System.IntPtr texref);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetTextureAlignmentOffset")]
            internal static extern global::CUDA.CudaError CudaGetTextureAlignmentOffset(ulong* offset, global::System.IntPtr texref);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetTextureReference")]
            internal static extern global::CUDA.CudaError CudaGetTextureReference(global::System.IntPtr texref, global::System.IntPtr symbol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaBindSurfaceToArray")]
            internal static extern global::CUDA.CudaError CudaBindSurfaceToArray(global::System.IntPtr surfref, global::System.IntPtr array, global::System.IntPtr desc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetSurfaceReference")]
            internal static extern global::CUDA.CudaError CudaGetSurfaceReference(global::System.IntPtr surfref, global::System.IntPtr symbol);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaCreateTextureObject")]
            internal static extern global::CUDA.CudaError CudaCreateTextureObject(ulong* pTexObject, global::System.IntPtr pResDesc, global::System.IntPtr pTexDesc, global::System.IntPtr pResViewDesc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDestroyTextureObject")]
            internal static extern global::CUDA.CudaError CudaDestroyTextureObject(ulong texObject);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetTextureObjectResourceDesc")]
            internal static extern global::CUDA.CudaError CudaGetTextureObjectResourceDesc(global::System.IntPtr pResDesc, ulong texObject);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetTextureObjectTextureDesc")]
            internal static extern global::CUDA.CudaError CudaGetTextureObjectTextureDesc(global::System.IntPtr pTexDesc, ulong texObject);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetTextureObjectResourceViewDesc")]
            internal static extern global::CUDA.CudaError CudaGetTextureObjectResourceViewDesc(global::System.IntPtr pResViewDesc, ulong texObject);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaCreateSurfaceObject")]
            internal static extern global::CUDA.CudaError CudaCreateSurfaceObject(ulong* pSurfObject, global::System.IntPtr pResDesc);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDestroySurfaceObject")]
            internal static extern global::CUDA.CudaError CudaDestroySurfaceObject(ulong surfObject);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetSurfaceObjectResourceDesc")]
            internal static extern global::CUDA.CudaError CudaGetSurfaceObjectResourceDesc(global::System.IntPtr pResDesc, ulong surfObject);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaDriverGetVersion")]
            internal static extern global::CUDA.CudaError CudaDriverGetVersion(int* driverVersion);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaRuntimeGetVersion")]
            internal static extern global::CUDA.CudaError CudaRuntimeGetVersion(int* runtimeVersion);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "cudaGetExportTable")]
            internal static extern global::CUDA.CudaError CudaGetExportTable(void** ppExportTable, global::System.IntPtr pExportTableId);
        }

        /// <summary>
        /// <para>Destroy all allocations and reset all state on the current device</para>
        /// <para>in the current process.</para>
        /// </summary>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>Explicitly destroys and cleans up all resources associated with the current</para>
        /// <para>device in the current process.  Any subsequent API call to this device will</para>
        /// <para>reinitialize the device.</para>
        /// <para>Note that this function will reset the device immediately.  It is the caller's</para>
        /// <para>responsibility to ensure that the device is not being accessed by any</para>
        /// <para>other host threads from the process when this function is called.</para>
        /// <para>::cudaDeviceSynchronize</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceReset()
        {
            var __ret = __Internal.CudaDeviceReset();
            return __ret;
        }

        /// <summary>Wait for compute device to finish</summary>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>Blocks until the device has completed all preceding requested tasks.</para>
        /// <para>::cudaDeviceSynchronize() returns an error if one of the preceding tasks</para>
        /// <para>has failed. If the ::cudaDeviceScheduleBlockingSync flag was set for</para>
        /// <para>this device, the host thread will block until the device has finished</para>
        /// <para>its work.</para>
        /// <para>::cudaDeviceReset,</para>
        /// <para>::cuCtxSynchronize</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceSynchronize()
        {
            var __ret = __Internal.CudaDeviceSynchronize();
            return __ret;
        }

        /// <summary>Set resource limits</summary>
        /// <param name="limit">- Limit to set</param>
        /// <param name="value">- Size of limit</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorUnsupportedLimit,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Settingtois a request by the application to update</para>
        /// <para>the current limit maintained by the device.  The driver is free to</para>
        /// <para>modify the requested value to meet h/w requirements (this could be</para>
        /// <para>clamping to minimum or maximum values, rounding up to nearest element</para>
        /// <para>size, etc).  The application can use ::cudaDeviceGetLimit() to find out</para>
        /// <para>exactly what the limit has been set to.</para>
        /// <para>Setting each ::cudaLimit has its own specific restrictions, so each is</para>
        /// <para>discussed here.</para>
        /// <para>- ::cudaLimitStackSize controls the stack size in bytes of each GPU thread.</para>
        /// <para>- ::cudaLimitPrintfFifoSize controls the size in bytes of the shared FIFO</para>
        /// <para>used by the ::printf() and ::fprintf() device system calls. Setting</para>
        /// <para>::cudaLimitPrintfFifoSize must not be performed after launching any kernel</para>
        /// <para>that uses the ::printf() or ::fprintf() device system calls - in such case</para>
        /// <para>::cudaErrorInvalidValue will be returned.</para>
        /// <para>- ::cudaLimitMallocHeapSize controls the size in bytes of the heap used by</para>
        /// <para>the ::malloc() and ::free() device system calls. Setting</para>
        /// <para>::cudaLimitMallocHeapSize must not be performed after launching any kernel</para>
        /// <para>that uses the ::malloc() or ::free() device system calls - in such case</para>
        /// <para>::cudaErrorInvalidValue will be returned.</para>
        /// <para>- ::cudaLimitDevRuntimeSyncDepth controls the maximum nesting depth of a</para>
        /// <para>grid at which a thread can safely call ::cudaDeviceSynchronize(). Setting</para>
        /// <para>this limit must be performed before any launch of a kernel that uses the</para>
        /// <para>device runtime and calls ::cudaDeviceSynchronize() above the default sync</para>
        /// <para>depth, two levels of grids. Calls to ::cudaDeviceSynchronize() will fail</para>
        /// <para>with error code ::cudaErrorSyncDepthExceeded if the limitation is</para>
        /// <para>violated. This limit can be set smaller than the default or up the maximum</para>
        /// <para>launch depth of 24. When setting this limit, keep in mind that additional</para>
        /// <para>levels of sync depth require the runtime to reserve large amounts of</para>
        /// <para>device memory which can no longer be used for user allocations. If these</para>
        /// <para>reservations of device memory fail, ::cudaDeviceSetLimit will return</para>
        /// <para>::cudaErrorMemoryAllocation, and the limit can be reset to a lower value.</para>
        /// <para>This limit is only applicable to devices of compute capability 3.5 and</para>
        /// <para>higher. Attempting to set this limit on devices of compute capability less</para>
        /// <para>than 3.5 will result in the error ::cudaErrorUnsupportedLimit being</para>
        /// <para>returned.</para>
        /// <para>- ::cudaLimitDevRuntimePendingLaunchCount controls the maximum number of</para>
        /// <para>outstanding device runtime launches that can be made from the current</para>
        /// <para>device. A grid is outstanding from the point of launch up until the grid</para>
        /// <para>is known to have been completed. Device runtime launches which violate</para>
        /// <para>this limitation fail and return ::cudaErrorLaunchPendingCountExceeded when</para>
        /// <para>::cudaGetLastError() is called after launch. If more pending launches than</para>
        /// <para>the default (2048 launches) are needed for a module using the device</para>
        /// <para>runtime, this limit can be increased. Keep in mind that being able to</para>
        /// <para>sustain additional pending launches will require the runtime to reserve</para>
        /// <para>larger amounts of device memory upfront which can no longer be used for</para>
        /// <para>allocations. If these reservations fail, ::cudaDeviceSetLimit will return</para>
        /// <para>::cudaErrorMemoryAllocation, and the limit can be reset to a lower value.</para>
        /// <para>This limit is only applicable to devices of compute capability 3.5 and</para>
        /// <para>higher. Attempting to set this limit on devices of compute capability less</para>
        /// <para>than 3.5 will result in the error ::cudaErrorUnsupportedLimit being</para>
        /// <para>returned.</para>
        /// <para>::cudaDeviceGetLimit,</para>
        /// <para>::cuCtxSetLimit</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceSetLimit(global::CUDA.CudaLimit limit, ulong value)
        {
            var __ret = __Internal.CudaDeviceSetLimit(limit, value);
            return __ret;
        }

        /// <summary>Returns resource limits</summary>
        /// <param name="limit">- Limit to query</param>
        /// <param name="pValue">- Returned size of the limit</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorUnsupportedLimit,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe current size ofThe supported</para>
        /// <para>::cudaLimit values are:</para>
        /// <para>- ::cudaLimitStackSize: stack size in bytes of each GPU thread;</para>
        /// <para>- ::cudaLimitPrintfFifoSize: size in bytes of the shared FIFO used by the</para>
        /// <para>::printf() and ::fprintf() device system calls.</para>
        /// <para>- ::cudaLimitMallocHeapSize: size in bytes of the heap used by the</para>
        /// <para>::malloc() and ::free() device system calls;</para>
        /// <para>- ::cudaLimitDevRuntimeSyncDepth: maximum grid depth at which a</para>
        /// <para>thread can isssue the device runtime call ::cudaDeviceSynchronize()</para>
        /// <para>to wait on child grid launches to complete.</para>
        /// <para>- ::cudaLimitDevRuntimePendingLaunchCount: maximum number of outstanding</para>
        /// <para>device runtime launches.</para>
        /// <para>::cudaDeviceSetLimit,</para>
        /// <para>::cuCtxGetLimit</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetLimit(ref ulong pValue, global::CUDA.CudaLimit limit)
        {
            fixed (ulong* __refParamPtr0 = &pValue)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaDeviceGetLimit(__arg0, limit);
                return __ret;
            }
        }

        /// <summary>Returns the preferred cache configuration for the current device.</summary>
        /// <param name="pCacheConfig">- Returned cache configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>On devices where the L1 cache and shared memory use the same hardware</para>
        /// <para>resources, this returns throughthe preferred cache</para>
        /// <para>configuration for the current device. This is only a preference. The</para>
        /// <para>runtime will use the requested configuration if possible, but it is free to</para>
        /// <para>choose a different configuration if required to execute functions.</para>
        /// <para>This will return aof ::cudaFuncCachePreferNone on devices</para>
        /// <para>where the size of the L1 cache and shared memory are fixed.</para>
        /// <para>The supported cache configurations are:</para>
        /// <para>- ::cudaFuncCachePreferNone: no preference for shared memory or L1 (default)</para>
        /// <para>- ::cudaFuncCachePreferShared: prefer larger shared memory and smaller L1 cache</para>
        /// <para>- ::cudaFuncCachePreferL1: prefer larger L1 cache and smaller shared memory</para>
        /// <para>- ::cudaFuncCachePreferEqual: prefer equal size L1 cache and shared memory</para>
        /// <para>cudaDeviceSetCacheConfig,</para>
        /// <para>::cuCtxGetCacheConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetCacheConfig(global::CUDA.CudaFuncCache* pCacheConfig)
        {
            var __ret = __Internal.CudaDeviceGetCacheConfig(pCacheConfig);
            return __ret;
        }

        /// <summary>
        /// <para>Returns numerical values that correspond to the least and</para>
        /// <para>greatest stream priorities.</para>
        /// </summary>
        /// <param name="leastPriority">
        /// <para>- Pointer to an int in which the numerical value for least</para>
        /// <para>stream priority is returned</para>
        /// </param>
        /// <param name="greatestPriority">
        /// <para>- Pointer to an int in which the numerical value for greatest</para>
        /// <para>stream priority is returned</para>
        /// </param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inandthe numerical values that correspond</para>
        /// <para>to the least and greatest stream priorities respectively. Stream priorities</para>
        /// <para>follow a convention where lower numbers imply greater priorities. The range of</para>
        /// <para>meaningful stream priorities is given by [If the user attempts to create a stream with a priority value that is</para>
        /// <para>outside the the meaningful range as specified by this API, the priority is</para>
        /// <para>automatically clamped down or up to eitherorrespectively. See ::cudaStreamCreateWithPriority for details on creating a</para>
        /// <para>priority stream.</para>
        /// <para>A NULL may be passed in fororif the value</para>
        /// <para>is not desired.</para>
        /// <para>This function will return '0' in bothandif</para>
        /// <para>the current context's device does not support stream priorities</para>
        /// <para>(see ::cudaDeviceGetAttribute).</para>
        /// <para>::cudaStreamCreateWithPriority,</para>
        /// <para>::cudaStreamGetPriority,</para>
        /// <para>::cuCtxGetStreamPriorityRange</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetStreamPriorityRange(ref int leastPriority, ref int greatestPriority)
        {
            fixed (int* __refParamPtr0 = &leastPriority)
            {
                var __arg0 = __refParamPtr0;
                fixed (int* __refParamPtr1 = &greatestPriority)
                {
                    var __arg1 = __refParamPtr1;
                    var __ret = __Internal.CudaDeviceGetStreamPriorityRange(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        /// <summary>Sets the preferred cache configuration for the current device.</summary>
        /// <param name="cacheConfig">- Requested cache configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>On devices where the L1 cache and shared memory use the same hardware</para>
        /// <para>resources, this sets throughthe preferred cache</para>
        /// <para>configuration for the current device. This is only a preference. The</para>
        /// <para>runtime will use the requested configuration if possible, but it is free to</para>
        /// <para>choose a different configuration if required to execute the function. Any</para>
        /// <para>function preference set via</para>
        /// <para>or</para>
        /// <para>will be preferred over this device-wide setting. Setting the device-wide</para>
        /// <para>cache configuration to ::cudaFuncCachePreferNone will cause subsequent</para>
        /// <para>kernel launches to prefer to not change the cache configuration unless</para>
        /// <para>required to launch the kernel.</para>
        /// <para>This setting does nothing on devices where the size of the L1 cache and</para>
        /// <para>shared memory are fixed.</para>
        /// <para>Launching a kernel with a different preference than the most recent</para>
        /// <para>preference setting may insert a device-side synchronization point.</para>
        /// <para>The supported cache configurations are:</para>
        /// <para>- ::cudaFuncCachePreferNone: no preference for shared memory or L1 (default)</para>
        /// <para>- ::cudaFuncCachePreferShared: prefer larger shared memory and smaller L1 cache</para>
        /// <para>- ::cudaFuncCachePreferL1: prefer larger L1 cache and smaller shared memory</para>
        /// <para>- ::cudaFuncCachePreferEqual: prefer equal size L1 cache and shared memory</para>
        /// <para>::cudaDeviceGetCacheConfig,</para>
        /// <para>::cuCtxSetCacheConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceSetCacheConfig(global::CUDA.CudaFuncCache cacheConfig)
        {
            var __ret = __Internal.CudaDeviceSetCacheConfig(cacheConfig);
            return __ret;
        }

        /// <summary>Returns the shared memory configuration for the current device.</summary>
        /// <param name="pConfig">- Returned cache configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>This function will return inthe current size of shared memory banks</para>
        /// <para>on the current device. On devices with configurable shared memory banks,</para>
        /// <para>::cudaDeviceSetSharedMemConfig can be used to change this setting, so that all</para>
        /// <para>subsequent kernel launches will by default use the new bank size. When</para>
        /// <para>::cudaDeviceGetSharedMemConfig is called on devices without configurable shared</para>
        /// <para>memory, it will return the fixed bank size of the hardware.</para>
        /// <para>The returned bank configurations can be either:</para>
        /// <para>- ::cudaSharedMemBankSizeFourByte - shared memory bank width is four bytes.</para>
        /// <para>- ::cudaSharedMemBankSizeEightByte - shared memory bank width is eight bytes.</para>
        /// <para>::cudaDeviceSetCacheConfig,</para>
        /// <para>::cudaDeviceGetCacheConfig,</para>
        /// <para>::cudaDeviceSetSharedMemConfig,</para>
        /// <para>::cudaFuncSetCacheConfig,</para>
        /// <para>::cuCtxGetSharedMemConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetSharedMemConfig(global::CUDA.CudaSharedMemConfig* pConfig)
        {
            var __ret = __Internal.CudaDeviceGetSharedMemConfig(pConfig);
            return __ret;
        }

        /// <summary>Sets the shared memory configuration for the current device.</summary>
        /// <param name="config">- Requested cache configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>On devices with configurable shared memory banks, this function will set</para>
        /// <para>the shared memory bank size which is used for all subsequent kernel launches.</para>
        /// <para>Any per-function setting of shared memory set via ::cudaFuncSetSharedMemConfig</para>
        /// <para>will override the device wide setting.</para>
        /// <para>Changing the shared memory configuration between launches may introduce</para>
        /// <para>a device side synchronization point.</para>
        /// <para>Changing the shared memory bank size will not increase shared memory usage</para>
        /// <para>or affect occupancy of kernels, but may have major effects on performance.</para>
        /// <para>Larger bank sizes will allow for greater potential bandwidth to shared memory,</para>
        /// <para>but will change what kinds of accesses to shared memory will result in bank</para>
        /// <para>conflicts.</para>
        /// <para>This function will do nothing on devices with fixed shared memory bank size.</para>
        /// <para>The supported bank configurations are:</para>
        /// <para>- ::cudaSharedMemBankSizeDefault: set bank width the device default (currently,</para>
        /// <para>four bytes)</para>
        /// <para>- ::cudaSharedMemBankSizeFourByte: set shared memory bank width to be four bytes</para>
        /// <para>natively.</para>
        /// <para>- ::cudaSharedMemBankSizeEightByte: set shared memory bank width to be eight</para>
        /// <para>bytes natively.</para>
        /// <para>::cudaDeviceSetCacheConfig,</para>
        /// <para>::cudaDeviceGetCacheConfig,</para>
        /// <para>::cudaDeviceGetSharedMemConfig,</para>
        /// <para>::cudaFuncSetCacheConfig,</para>
        /// <para>::cuCtxSetSharedMemConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceSetSharedMemConfig(global::CUDA.CudaSharedMemConfig config)
        {
            var __ret = __Internal.CudaDeviceSetSharedMemConfig(config);
            return __ret;
        }

        /// <summary>Returns a handle to a compute device</summary>
        /// <param name="device">- Returned device ordinal</param>
        /// <param name="pciBusId">
        /// <para>- String in one of the following forms:</para>
        /// <para>[domain]:[bus]:[device].[function]</para>
        /// <para>[domain]:[bus]:[device]</para>
        /// <para>[bus]:[device].[function]</para>
        /// <para>whereandare all hexadecimal values</para>
        /// </param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns ina device ordinal given a PCI bus ID string.</para>
        /// <para>::cudaDeviceGetPCIBusId,</para>
        /// <para>::cuDeviceGetByPCIBusId</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetByPCIBusId(ref int device, string pciBusId)
        {
            fixed (int* __refParamPtr0 = &device)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaDeviceGetByPCIBusId(__arg0, pciBusId);
                return __ret;
            }
        }

        /// <summary>Returns a PCI Bus Id string for the device</summary>
        /// <param name="pciBusId">
        /// <para>- Returned identifier string for the device in the following format</para>
        /// <para>[domain]:[bus]:[device].[function]</para>
        /// <para>whereandare all hexadecimal values.</para>
        /// <para>pciBusId should be large enough to store 13 characters including the NULL-terminator.</para>
        /// </param>
        /// <param name="len">- Maximum length of string to store in</param>
        /// <param name="device">- Device to get identifier string for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns an ASCII string identifying the devicein the NULL-terminated</para>
        /// <para>string pointed to byspecifies the maximum length of the</para>
        /// <para>string that may be returned.</para>
        /// <para>::cudaDeviceGetByPCIBusId,</para>
        /// <para>::cuDeviceGetPCIBusId</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetPCIBusId(sbyte* pciBusId, int len, int device)
        {
            var __ret = __Internal.CudaDeviceGetPCIBusId(pciBusId, len, device);
            return __ret;
        }

        /// <summary>Gets an interprocess handle for a previously allocated event</summary>
        /// <param name="handle">
        /// <para>- Pointer to a user allocated cudaIpcEventHandle</para>
        /// <para>in which to return the opaque event handle</para>
        /// </param>
        /// <param name="event">
        /// <para>- Event allocated with ::cudaEventInterprocess and</para>
        /// <para>::cudaEventDisableTiming flags.</para>
        /// </param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorMemoryAllocation,</para>
        /// <para>::cudaErrorMapBufferObjectFailed,</para>
        /// <para>::cudaErrorNotSupported</para>
        /// </returns>
        /// <remarks>
        /// <para>Takes as input a previously allocated event. This event must have been</para>
        /// <para>created with the ::cudaEventInterprocess and ::cudaEventDisableTiming</para>
        /// <para>flags set. This opaque handle may be copied into other processes and</para>
        /// <para>opened with ::cudaIpcOpenEventHandle to allow efficient hardware</para>
        /// <para>synchronization between GPU work in different processes.</para>
        /// <para>After the event has been been opened in the importing process,</para>
        /// <para>::cudaEventRecord, ::cudaEventSynchronize, ::cudaStreamWaitEvent and</para>
        /// <para>::cudaEventQuery may be used in either process. Performing operations</para>
        /// <para>on the imported event after the exported event has been freed</para>
        /// <para>with ::cudaEventDestroy will result in undefined behavior.</para>
        /// <para>IPC functionality is restricted to devices with support for unified</para>
        /// <para>addressing on Linux operating systems. IPC functionality is not supported</para>
        /// <para>on Tegra platforms.</para>
        /// <para>::cudaEventCreate,</para>
        /// <para>::cudaEventDestroy,</para>
        /// <para>::cudaEventSynchronize,</para>
        /// <para>::cudaEventQuery,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cudaIpcOpenEventHandle,</para>
        /// <para>::cudaIpcGetMemHandle,</para>
        /// <para>::cudaIpcOpenMemHandle,</para>
        /// <para>::cudaIpcCloseMemHandle,</para>
        /// <para>::cuIpcGetEventHandle</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaIpcGetEventHandle(global::CUDA.CudaIpcEventHandleSt handle, global::CUDA.CUeventSt @event)
        {
            var __arg0 = ReferenceEquals(handle, null) ? global::System.IntPtr.Zero : handle.__Instance;
            var __arg1 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaIpcGetEventHandle(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Opens an interprocess event handle for use in the current process</summary>
        /// <param name="event">- Returns the imported event</param>
        /// <param name="handle">- Interprocess handle to open</param>
        /// <remarks>
        /// <para>Opens an interprocess event handle exported from another process with</para>
        /// <para>::cudaIpcGetEventHandle. This function returns a ::cudaEvent_t that behaves like</para>
        /// <para>a locally created event with the ::cudaEventDisableTiming flag specified.</para>
        /// <para>This event must be freed with ::cudaEventDestroy.</para>
        /// <para>Performing operations on the imported event after the exported event has</para>
        /// <para>been freed with ::cudaEventDestroy will result in undefined behavior.</para>
        /// <para>IPC functionality is restricted to devices with support for unified</para>
        /// <para>addressing on Linux operating systems. IPC functionality is not supported</para>
        /// <para>on Tegra platforms.</para>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorMapBufferObjectFailed,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorNotSupported</para>
        /// <para>::cudaEventCreate,</para>
        /// <para>::cudaEventDestroy,</para>
        /// <para>::cudaEventSynchronize,</para>
        /// <para>::cudaEventQuery,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cudaIpcGetEventHandle,</para>
        /// <para>::cudaIpcGetMemHandle,</para>
        /// <para>::cudaIpcOpenMemHandle,</para>
        /// <para>::cudaIpcCloseMemHandle,</para>
        /// <para>::cuIpcOpenEventHandle</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaIpcOpenEventHandle(global::CUDA.CUeventSt @event, global::CUDA.CudaIpcEventHandleSt handle)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __arg1 = ReferenceEquals(handle, null) ? new global::CUDA.CudaIpcEventHandleSt.__Internal() : *(global::CUDA.CudaIpcEventHandleSt.__Internal*)handle.__Instance;
            var __ret = __Internal.CudaIpcOpenEventHandle(__arg0, __arg1);
            return __ret;
        }

        /// <summary>
        /// <para>Gets an interprocess memory handle for an existing device memory</para>
        /// <para>allocation</para>
        /// </summary>
        /// <param name="handle">
        /// <para>- Pointer to user allocated ::cudaIpcMemHandle to return</para>
        /// <para>the handle in.</para>
        /// </param>
        /// <param name="devPtr">- Base pointer to previously allocated device memory</param>
        /// <remarks>
        /// <para>Takes a pointer to the base of an existing device memory allocation created</para>
        /// <para>with ::cudaMalloc and exports it for use in another process. This is a</para>
        /// <para>lightweight operation and may be called multiple times on an allocation</para>
        /// <para>without adverse effects.</para>
        /// <para>If a region of memory is freed with ::cudaFree and a subsequent call</para>
        /// <para>to ::cudaMalloc returns memory with the same device address,</para>
        /// <para>::cudaIpcGetMemHandle will return a unique handle for the</para>
        /// <para>new memory.</para>
        /// <para>IPC functionality is restricted to devices with support for unified</para>
        /// <para>addressing on Linux operating systems. IPC functionality is not supported</para>
        /// <para>on Tegra platforms.</para>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorMemoryAllocation,</para>
        /// <para>::cudaErrorMapBufferObjectFailed,</para>
        /// <para>::cudaErrorNotSupported</para>
        /// <para>::cudaMalloc,</para>
        /// <para>::cudaFree,</para>
        /// <para>::cudaIpcGetEventHandle,</para>
        /// <para>::cudaIpcOpenEventHandle,</para>
        /// <para>::cudaIpcOpenMemHandle,</para>
        /// <para>::cudaIpcCloseMemHandle,</para>
        /// <para>::cuIpcGetMemHandle</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaIpcGetMemHandle(global::CUDA.CudaIpcMemHandleSt handle, global::System.IntPtr devPtr)
        {
            var __arg0 = ReferenceEquals(handle, null) ? global::System.IntPtr.Zero : handle.__Instance;
            var __ret = __Internal.CudaIpcGetMemHandle(__arg0, devPtr);
            return __ret;
        }

        /// <summary>
        /// <para>Opens an interprocess memory handle exported from another process</para>
        /// <para>and returns a device pointer usable in the local process.</para>
        /// </summary>
        /// <param name="devPtr">- Returned device pointer</param>
        /// <param name="handle">- ::cudaIpcMemHandle to open</param>
        /// <param name="flags">- Flags for this operation. Must be specified as ::cudaIpcMemLazyEnablePeerAccess</param>
        /// <remarks>
        /// <para>Maps memory exported from another process with ::cudaIpcGetMemHandle into</para>
        /// <para>the current device address space. For contexts on different devices</para>
        /// <para>::cudaIpcOpenMemHandle can attempt to enable peer access between the</para>
        /// <para>devices as if the user called ::cudaDeviceEnablePeerAccess. This behavior is</para>
        /// <para>controlled by the ::cudaIpcMemLazyEnablePeerAccess flag.</para>
        /// <para>::cudaDeviceCanAccessPeer can determine if a mapping is possible.</para>
        /// <para>Contexts that may open ::cudaIpcMemHandles are restricted in the following way.</para>
        /// <para>::cudaIpcMemHandles from each device in a given process may only be opened</para>
        /// <para>by one context per device per other process.</para>
        /// <para>Memory returned from ::cudaIpcOpenMemHandle must be freed with</para>
        /// <para>::cudaIpcCloseMemHandle.</para>
        /// <para>Calling ::cudaFree on an exported memory region before calling</para>
        /// <para>::cudaIpcCloseMemHandle in the importing context will result in undefined</para>
        /// <para>behavior.</para>
        /// <para>IPC functionality is restricted to devices with support for unified</para>
        /// <para>addressing on Linux operating systems. IPC functionality is not supported</para>
        /// <para>on Tegra platforms.</para>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorMapBufferObjectFailed,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorTooManyPeers,</para>
        /// <para>::cudaErrorNotSupported</para>
        /// <para>No guarantees are made about the address returned in</para>
        /// <para>In particular, multiple processes may not receive the same address for the same</para>
        /// <para>::cudaMalloc,</para>
        /// <para>::cudaFree,</para>
        /// <para>::cudaIpcGetEventHandle,</para>
        /// <para>::cudaIpcOpenEventHandle,</para>
        /// <para>::cudaIpcGetMemHandle,</para>
        /// <para>::cudaIpcCloseMemHandle,</para>
        /// <para>::cudaDeviceEnablePeerAccess,</para>
        /// <para>::cudaDeviceCanAccessPeer,</para>
        /// <para>::cuIpcOpenMemHandle</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaIpcOpenMemHandle(void** devPtr, global::CUDA.CudaIpcMemHandleSt handle, uint flags)
        {
            var __arg1 = ReferenceEquals(handle, null) ? new global::CUDA.CudaIpcMemHandleSt.__Internal() : *(global::CUDA.CudaIpcMemHandleSt.__Internal*)handle.__Instance;
            var __ret = __Internal.CudaIpcOpenMemHandle(devPtr, __arg1, flags);
            return __ret;
        }

        /// <summary>Close memory mapped with cudaIpcOpenMemHandle</summary>
        /// <param name="devPtr">- Device pointer returned by ::cudaIpcOpenMemHandle</param>
        /// <remarks>
        /// <para>Unmaps memory returnd by ::cudaIpcOpenMemHandle. The original allocation</para>
        /// <para>in the exporting process as well as imported mappings in other processes</para>
        /// <para>will be unaffected.</para>
        /// <para>Any resources used to enable peer access will be freed if this is the</para>
        /// <para>last mapping using them.</para>
        /// <para>IPC functionality is restricted to devices with support for unified</para>
        /// <para>addressing on Linux operating systems. IPC functionality is not supported</para>
        /// <para>on Tegra platforms.</para>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorMapBufferObjectFailed,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorNotSupported</para>
        /// <para>::cudaMalloc,</para>
        /// <para>::cudaFree,</para>
        /// <para>::cudaIpcGetEventHandle,</para>
        /// <para>::cudaIpcOpenEventHandle,</para>
        /// <para>::cudaIpcGetMemHandle,</para>
        /// <para>::cudaIpcOpenMemHandle,</para>
        /// <para>::cuIpcCloseMemHandle</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaIpcCloseMemHandle(global::System.IntPtr devPtr)
        {
            var __ret = __Internal.CudaIpcCloseMemHandle(devPtr);
            return __ret;
        }

        /// <summary>Exit and clean up from CUDA launches</summary>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>Note that this function is deprecated because its name does not</para>
        /// <para>reflect its behavior.  Its functionality is identical to the</para>
        /// <para>non-deprecated function ::cudaDeviceReset(), which should be used</para>
        /// <para>instead.</para>
        /// <para>Explicitly destroys all cleans up all resources associated with the current</para>
        /// <para>device in the current process.  Any subsequent API call to this device will</para>
        /// <para>reinitialize the device.</para>
        /// <para>Note that this function will reset the device immediately.  It is the caller's</para>
        /// <para>responsibility to ensure that the device is not being accessed by any</para>
        /// <para>other host threads from the process when this function is called.</para>
        /// <para>::cudaDeviceReset</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaThreadExit()
        {
            var __ret = __Internal.CudaThreadExit();
            return __ret;
        }

        /// <summary>Wait for compute device to finish</summary>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>Note that this function is deprecated because its name does not</para>
        /// <para>reflect its behavior.  Its functionality is similar to the</para>
        /// <para>non-deprecated function ::cudaDeviceSynchronize(), which should be used</para>
        /// <para>instead.</para>
        /// <para>Blocks until the device has completed all preceding requested tasks.</para>
        /// <para>::cudaThreadSynchronize() returns an error if one of the preceding tasks</para>
        /// <para>has failed. If the ::cudaDeviceScheduleBlockingSync flag was set for</para>
        /// <para>this device, the host thread will block until the device has finished</para>
        /// <para>its work.</para>
        /// <para>::cudaDeviceSynchronize</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaThreadSynchronize()
        {
            var __ret = __Internal.CudaThreadSynchronize();
            return __ret;
        }

        /// <summary>Set resource limits</summary>
        /// <param name="limit">- Limit to set</param>
        /// <param name="value">- Size in bytes of limit</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorUnsupportedLimit,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Note that this function is deprecated because its name does not</para>
        /// <para>reflect its behavior.  Its functionality is identical to the</para>
        /// <para>non-deprecated function ::cudaDeviceSetLimit(), which should be used</para>
        /// <para>instead.</para>
        /// <para>Settingtois a request by the application to update</para>
        /// <para>the current limit maintained by the device.  The driver is free to</para>
        /// <para>modify the requested value to meet h/w requirements (this could be</para>
        /// <para>clamping to minimum or maximum values, rounding up to nearest element</para>
        /// <para>size, etc).  The application can use ::cudaThreadGetLimit() to find out</para>
        /// <para>exactly what the limit has been set to.</para>
        /// <para>Setting each ::cudaLimit has its own specific restrictions, so each is</para>
        /// <para>discussed here.</para>
        /// <para>- ::cudaLimitStackSize controls the stack size of each GPU thread.</para>
        /// <para>- ::cudaLimitPrintfFifoSize controls the size of the shared FIFO</para>
        /// <para>used by the ::printf() and ::fprintf() device system calls.</para>
        /// <para>Setting ::cudaLimitPrintfFifoSize must be performed before</para>
        /// <para>launching any kernel that uses the ::printf() or ::fprintf() device</para>
        /// <para>system calls, otherwise ::cudaErrorInvalidValue will be returned.</para>
        /// <para>- ::cudaLimitMallocHeapSize controls the size of the heap used</para>
        /// <para>by the ::malloc() and ::free() device system calls.  Setting</para>
        /// <para>::cudaLimitMallocHeapSize must be performed before launching</para>
        /// <para>any kernel that uses the ::malloc() or ::free() device system calls,</para>
        /// <para>otherwise ::cudaErrorInvalidValue will be returned.</para>
        /// <para>::cudaDeviceSetLimit</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaThreadSetLimit(global::CUDA.CudaLimit limit, ulong value)
        {
            var __ret = __Internal.CudaThreadSetLimit(limit, value);
            return __ret;
        }

        /// <summary>Returns resource limits</summary>
        /// <param name="limit">- Limit to query</param>
        /// <param name="pValue">- Returned size in bytes of limit</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorUnsupportedLimit,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Note that this function is deprecated because its name does not</para>
        /// <para>reflect its behavior.  Its functionality is identical to the</para>
        /// <para>non-deprecated function ::cudaDeviceGetLimit(), which should be used</para>
        /// <para>instead.</para>
        /// <para>Returns inthe current size ofThe supported</para>
        /// <para>::cudaLimit values are:</para>
        /// <para>- ::cudaLimitStackSize: stack size of each GPU thread;</para>
        /// <para>- ::cudaLimitPrintfFifoSize: size of the shared FIFO used by the</para>
        /// <para>::printf() and ::fprintf() device system calls.</para>
        /// <para>- ::cudaLimitMallocHeapSize: size of the heap used by the</para>
        /// <para>::malloc() and ::free() device system calls;</para>
        /// <para>::cudaDeviceGetLimit</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaThreadGetLimit(ref ulong pValue, global::CUDA.CudaLimit limit)
        {
            fixed (ulong* __refParamPtr0 = &pValue)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaThreadGetLimit(__arg0, limit);
                return __ret;
            }
        }

        /// <summary>Returns the preferred cache configuration for the current device.</summary>
        /// <param name="pCacheConfig">- Returned cache configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>Note that this function is deprecated because its name does not</para>
        /// <para>reflect its behavior.  Its functionality is identical to the</para>
        /// <para>non-deprecated function ::cudaDeviceGetCacheConfig(), which should be</para>
        /// <para>used instead.</para>
        /// <para>On devices where the L1 cache and shared memory use the same hardware</para>
        /// <para>resources, this returns throughthe preferred cache</para>
        /// <para>configuration for the current device. This is only a preference. The</para>
        /// <para>runtime will use the requested configuration if possible, but it is free to</para>
        /// <para>choose a different configuration if required to execute functions.</para>
        /// <para>This will return aof ::cudaFuncCachePreferNone on devices</para>
        /// <para>where the size of the L1 cache and shared memory are fixed.</para>
        /// <para>The supported cache configurations are:</para>
        /// <para>- ::cudaFuncCachePreferNone: no preference for shared memory or L1 (default)</para>
        /// <para>- ::cudaFuncCachePreferShared: prefer larger shared memory and smaller L1 cache</para>
        /// <para>- ::cudaFuncCachePreferL1: prefer larger L1 cache and smaller shared memory</para>
        /// <para>::cudaDeviceGetCacheConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaThreadGetCacheConfig(global::CUDA.CudaFuncCache* pCacheConfig)
        {
            var __ret = __Internal.CudaThreadGetCacheConfig(pCacheConfig);
            return __ret;
        }

        /// <summary>Sets the preferred cache configuration for the current device.</summary>
        /// <param name="cacheConfig">- Requested cache configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>Note that this function is deprecated because its name does not</para>
        /// <para>reflect its behavior.  Its functionality is identical to the</para>
        /// <para>non-deprecated function ::cudaDeviceSetCacheConfig(), which should be</para>
        /// <para>used instead.</para>
        /// <para>On devices where the L1 cache and shared memory use the same hardware</para>
        /// <para>resources, this sets throughthe preferred cache</para>
        /// <para>configuration for the current device. This is only a preference. The</para>
        /// <para>runtime will use the requested configuration if possible, but it is free to</para>
        /// <para>choose a different configuration if required to execute the function. Any</para>
        /// <para>function preference set via</para>
        /// <para>or</para>
        /// <para>will be preferred over this device-wide setting. Setting the device-wide</para>
        /// <para>cache configuration to ::cudaFuncCachePreferNone will cause subsequent</para>
        /// <para>kernel launches to prefer to not change the cache configuration unless</para>
        /// <para>required to launch the kernel.</para>
        /// <para>This setting does nothing on devices where the size of the L1 cache and</para>
        /// <para>shared memory are fixed.</para>
        /// <para>Launching a kernel with a different preference than the most recent</para>
        /// <para>preference setting may insert a device-side synchronization point.</para>
        /// <para>The supported cache configurations are:</para>
        /// <para>- ::cudaFuncCachePreferNone: no preference for shared memory or L1 (default)</para>
        /// <para>- ::cudaFuncCachePreferShared: prefer larger shared memory and smaller L1 cache</para>
        /// <para>- ::cudaFuncCachePreferL1: prefer larger L1 cache and smaller shared memory</para>
        /// <para>::cudaDeviceSetCacheConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaThreadSetCacheConfig(global::CUDA.CudaFuncCache cacheConfig)
        {
            var __ret = __Internal.CudaThreadSetCacheConfig(cacheConfig);
            return __ret;
        }

        /// <summary>Returns the last error from a runtime call</summary>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorMissingConfiguration,</para>
        /// <para>::cudaErrorMemoryAllocation,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorLaunchTimeout,</para>
        /// <para>::cudaErrorLaunchOutOfResources,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidConfiguration,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorUnmapBufferObjectFailed,</para>
        /// <para>::cudaErrorInvalidDevicePointer,</para>
        /// <para>::cudaErrorInvalidTexture,</para>
        /// <para>::cudaErrorInvalidTextureBinding,</para>
        /// <para>::cudaErrorInvalidChannelDescriptor,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection,</para>
        /// <para>::cudaErrorInvalidFilterSetting,</para>
        /// <para>::cudaErrorInvalidNormSetting,</para>
        /// <para>::cudaErrorUnknown,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorInsufficientDriver,</para>
        /// <para>::cudaErrorSetOnActiveProcess,</para>
        /// <para>::cudaErrorStartupFailure,</para>
        /// <para>::cudaErrorInvalidPtx,</para>
        /// <para>::cudaErrorNoKernelImageForDevice,</para>
        /// <para>::cudaErrorJitCompilerNotFound</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns the last error that has been produced by any of the runtime calls</para>
        /// <para>in the same host thread and resets it to ::cudaSuccess.</para>
        /// <para>::cudaPeekAtLastError, ::cudaGetErrorName, ::cudaGetErrorString, ::cudaError</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetLastError()
        {
            var __ret = __Internal.CudaGetLastError();
            return __ret;
        }

        /// <summary>Returns the last error from a runtime call</summary>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorMissingConfiguration,</para>
        /// <para>::cudaErrorMemoryAllocation,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorLaunchTimeout,</para>
        /// <para>::cudaErrorLaunchOutOfResources,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidConfiguration,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorUnmapBufferObjectFailed,</para>
        /// <para>::cudaErrorInvalidDevicePointer,</para>
        /// <para>::cudaErrorInvalidTexture,</para>
        /// <para>::cudaErrorInvalidTextureBinding,</para>
        /// <para>::cudaErrorInvalidChannelDescriptor,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection,</para>
        /// <para>::cudaErrorInvalidFilterSetting,</para>
        /// <para>::cudaErrorInvalidNormSetting,</para>
        /// <para>::cudaErrorUnknown,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorInsufficientDriver,</para>
        /// <para>::cudaErrorSetOnActiveProcess,</para>
        /// <para>::cudaErrorStartupFailure,</para>
        /// <para>::cudaErrorInvalidPtx,</para>
        /// <para>::cudaErrorNoKernelImageForDevice,</para>
        /// <para>::cudaErrorJitCompilerNotFound</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns the last error that has been produced by any of the runtime calls</para>
        /// <para>in the same host thread. Note that this call does not reset the error to</para>
        /// <para>::cudaSuccess like ::cudaGetLastError().</para>
        /// <para>::cudaGetLastError, ::cudaGetErrorName, ::cudaGetErrorString, ::cudaError</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaPeekAtLastError()
        {
            var __ret = __Internal.CudaPeekAtLastError();
            return __ret;
        }

        /// <summary>Returns the string representation of an error code enum name</summary>
        /// <param name="error">- Error code to convert to string</param>
        /// <returns>pointer to a NULL-terminated string</returns>
        /// <remarks>
        /// <para>Returns a string containing the name of an error code in the enum.  If the error</para>
        /// <para>code is not recognized, &quot;unrecognized error code&quot; is returned.</para>
        /// <para>::cudaGetErrorString, ::cudaGetLastError, ::cudaPeekAtLastError, ::cudaError,</para>
        /// <para>::cuGetErrorName</para>
        /// </remarks>
        public static string CudaGetErrorName(global::CUDA.CudaError error)
        {
            var __ret = __Internal.CudaGetErrorName(error);
            return Marshal.PtrToStringAnsi(__ret);
        }

        /// <summary>Returns the description string for an error code</summary>
        /// <param name="error">- Error code to convert to string</param>
        /// <returns>pointer to a NULL-terminated string</returns>
        /// <remarks>
        /// <para>Returns the description string for an error code.  If the error</para>
        /// <para>code is not recognized, &quot;unrecognized error code&quot; is returned.</para>
        /// <para>::cudaGetErrorName, ::cudaGetLastError, ::cudaPeekAtLastError, ::cudaError,</para>
        /// <para>::cuGetErrorString</para>
        /// </remarks>
        public static string CudaGetErrorString(global::CUDA.CudaError error)
        {
            var __ret = __Internal.CudaGetErrorString(error);
            return Marshal.PtrToStringAnsi(__ret);
        }

        /// <summary>Returns the number of compute-capable devices</summary>
        /// <param name="count">
        /// <para>- Returns the number of devices with compute capability</para>
        /// <para>greater or equal to 2.0</para>
        /// </param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorNoDevice,</para>
        /// <para>::cudaErrorInsufficientDriver</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe number of devices with compute capability greater</para>
        /// <para>or equal to 2.0 that are available for execution.  If there is no such</para>
        /// <para>device then ::cudaGetDeviceCount() will return ::cudaErrorNoDevice.</para>
        /// <para>If no driver can be loaded to determine if any such devices exist then</para>
        /// <para>::cudaGetDeviceCount() will return ::cudaErrorInsufficientDriver.</para>
        /// <para>::cudaGetDevice, ::cudaSetDevice, ::cudaGetDeviceProperties,</para>
        /// <para>::cudaChooseDevice,</para>
        /// <para>::cuDeviceGetCount</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetDeviceCount(ref int count)
        {
            fixed (int* __refParamPtr0 = &count)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaGetDeviceCount(__arg0);
                return __ret;
            }
        }

        /// <summary>Returns information about the compute-device</summary>
        /// <param name="prop">- Properties for the specified device</param>
        /// <param name="device">- Device number to get properties for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe properties of deviceThe ::cudaDeviceProp</para>
        /// <para>structure is defined as:</para>
        /// <para>where:</para>
        /// <para>-</para>
        /// <para>the device;</para>
        /// <para>-</para>
        /// <para>amount of global memory available on the device in bytes;</para>
        /// <para>-</para>
        /// <para>maximum amount of shared memory available to a thread block in bytes;</para>
        /// <para>-</para>
        /// <para>of 32-bit registers available to a thread block;</para>
        /// <para>-</para>
        /// <para>-</para>
        /// <para>bytes allowed by the memory copy functions that involve memory regions</para>
        /// <para>allocated through ::cudaMallocPitch();</para>
        /// <para>-</para>
        /// <para>maximum number of threads per block;</para>
        /// <para>-</para>
        /// <para>maximum size of each dimension of a block;</para>
        /// <para>-</para>
        /// <para>maximum size of each dimension of a grid;</para>
        /// <para>-</para>
        /// <para>kilohertz;</para>
        /// <para>-</para>
        /// <para>of constant memory available on the device in bytes;</para>
        /// <para>-</para>
        /// <para>numbers defining the device's compute capability;</para>
        /// <para>-</para>
        /// <para>alignment requirement; texture base addresses that are aligned to</para>
        /// <para>need an offset applied to texture fetches;</para>
        /// <para>-</para>
        /// <para>pitch alignment requirement for 2D texture references that are bound to</para>
        /// <para>pitched memory;</para>
        /// <para>-</para>
        /// <para>can concurrently copy memory between host and device while executing a</para>
        /// <para>kernel, or 0 if not.  Deprecated, use instead asyncEngineCount.</para>
        /// <para>-</para>
        /// <para>number of multiprocessors on the device;</para>
        /// <para>-</para>
        /// <para>is 1 if there is a run time limit for kernels executed on the device, or</para>
        /// <para>0 if not.</para>
        /// <para>-</para>
        /// <para>integrated (motherboard) GPU and 0 if it is a discrete (card) component.</para>
        /// <para>-</para>
        /// <para>device can map host memory into the CUDA address space for use with</para>
        /// <para>::cudaHostAlloc()/::cudaHostGetDevicePointer(), or 0 if not;</para>
        /// <para>-</para>
        /// <para>that the device is currently in. Available modes are as follows:</para>
        /// <para>- cudaComputeModeDefault: Default mode - Device is not restricted and</para>
        /// <para>multiple threads can use ::cudaSetDevice() with this device.</para>
        /// <para>- cudaComputeModeExclusive: Compute-exclusive mode - Only one thread will</para>
        /// <para>be able to use ::cudaSetDevice() with this device.</para>
        /// <para>- cudaComputeModeProhibited: Compute-prohibited mode - No threads can use</para>
        /// <para>::cudaSetDevice() with this device.</para>
        /// <para>- cudaComputeModeExclusiveProcess: Compute-exclusive-process mode - Many</para>
        /// <para>threads in one process will be able to use ::cudaSetDevice() with this device.</para>
        /// <para>If ::cudaSetDevice() is called on an already occupiedwith</para>
        /// <para>computeMode ::cudaComputeModeExclusive, ::cudaErrorDeviceAlreadyInUse</para>
        /// <para>will be immediately returned indicating the device cannot be used.</para>
        /// <para>When an occupied exclusive mode device is chosen with ::cudaSetDevice,</para>
        /// <para>all subsequent non-device management runtime functions will return</para>
        /// <para>::cudaErrorDevicesUnavailable.</para>
        /// <para>-</para>
        /// <para>texture size.</para>
        /// <para>-</para>
        /// <para>1D mipmapped texture texture size.</para>
        /// <para>-</para>
        /// <para>1D texture size for textures bound to linear memory.</para>
        /// <para>-</para>
        /// <para>2D texture dimensions.</para>
        /// <para>-</para>
        /// <para>maximum 2D mipmapped texture dimensions.</para>
        /// <para>-</para>
        /// <para>maximum 2D texture dimensions for 2D textures bound to pitch linear memory.</para>
        /// <para>-</para>
        /// <para>maximum 2D texture dimensions if texture gather operations have to be performed.</para>
        /// <para>-</para>
        /// <para>3D texture dimensions.</para>
        /// <para>-</para>
        /// <para>contains the maximum alternate 3D texture dimensions.</para>
        /// <para>-</para>
        /// <para>maximum cubemap texture width or height.</para>
        /// <para>-</para>
        /// <para>the maximum 1D layered texture dimensions.</para>
        /// <para>-</para>
        /// <para>the maximum 2D layered texture dimensions.</para>
        /// <para>-</para>
        /// <para>contains the maximum cubemap layered texture dimensions.</para>
        /// <para>-</para>
        /// <para>surface size.</para>
        /// <para>-</para>
        /// <para>2D surface dimensions.</para>
        /// <para>-</para>
        /// <para>3D surface dimensions.</para>
        /// <para>-</para>
        /// <para>the maximum 1D layered surface dimensions.</para>
        /// <para>-</para>
        /// <para>the maximum 2D layered surface dimensions.</para>
        /// <para>-</para>
        /// <para>cubemap surface width or height.</para>
        /// <para>-</para>
        /// <para>contains the maximum cubemap layered surface dimensions.</para>
        /// <para>-</para>
        /// <para>alignment requirements for surfaces.</para>
        /// <para>-</para>
        /// <para>device supports executing multiple kernels within the same context</para>
        /// <para>simultaneously, or 0 if not. It is not guaranteed that multiple kernels</para>
        /// <para>will be resident on the device concurrently so this feature should not be</para>
        /// <para>relied upon for correctness;</para>
        /// <para>-</para>
        /// <para>support turned on, or 0 if not.</para>
        /// <para>-</para>
        /// <para>the device.</para>
        /// <para>-</para>
        /// <para>(sometimes called slot) identifier of the device.</para>
        /// <para>-</para>
        /// <para>of the device.</para>
        /// <para>-</para>
        /// <para>TCC driver or 0 if not.</para>
        /// <para>-</para>
        /// <para>device can concurrently copy memory between host and device while executing</para>
        /// <para>a kernel. It is 2 when the device can concurrently copy memory between host</para>
        /// <para>and device in both directions and execute a kernel at the same time. It is</para>
        /// <para>0 if neither of these is supported.</para>
        /// <para>-</para>
        /// <para>shares a unified address space with the host and 0 otherwise.</para>
        /// <para>-</para>
        /// <para>clock frequency in kilohertz.</para>
        /// <para>-</para>
        /// <para>in bits.</para>
        /// <para>-</para>
        /// <para>-</para>
        /// <para>is the number of maximum resident threads per multiprocessor.</para>
        /// <para>-</para>
        /// <para>is 1 if the device supports stream priorities, or 0 if it is not supported.</para>
        /// <para>-</para>
        /// <para>is 1 if the device supports caching of globals in L1 cache, or 0 if it is not supported.</para>
        /// <para>-</para>
        /// <para>is 1 if the device supports caching of locals in L1 cache, or 0 if it is not supported.</para>
        /// <para>-</para>
        /// <para>maximum amount of shared memory available to a multiprocessor in bytes; this amount is</para>
        /// <para>shared by all thread blocks simultaneously resident on a multiprocessor;</para>
        /// <para>-</para>
        /// <para>of 32-bit registers available to a multiprocessor; this number is shared</para>
        /// <para>by all thread blocks simultaneously resident on a multiprocessor;</para>
        /// <para>-</para>
        /// <para>is 1 if the device supports allocating managed memory on this system, or 0 if it is not supported.</para>
        /// <para>-</para>
        /// <para>is 1 if the device is on a multi-GPU board (e.g. Gemini cards), and 0 if not;</para>
        /// <para>-</para>
        /// <para>for a group of devices associated with the same board.</para>
        /// <para>Devices on the same multi-GPU board will share the same identifier;</para>
        /// <para>-</para>
        /// <para>is the ratio of single precision performance (in floating-point operations per second)</para>
        /// <para>to double precision performance.</para>
        /// <para>-</para>
        /// <para>coherently accessing pageable memory without calling cudaHostRegister on it, and 0 otherwise.</para>
        /// <para>-</para>
        /// <para>coherently access managed memory concurrently with the CPU, and 0 otherwise.</para>
        /// <para>-</para>
        /// <para>supports Compute Preemption, and 0 otherwise.</para>
        /// <para>-</para>
        /// <para>the device can access host registered memory at the same virtual address as the CPU, and 0 otherwise.</para>
        /// <para>-</para>
        /// <para>cooperative kernels via ::cudaLaunchCooperativeKernel, and 0 otherwise.</para>
        /// <para>-</para>
        /// <para>supports launching cooperative kernels via ::cudaLaunchCooperativeKernelMultiDevice, and 0 otherwise.</para>
        /// <para>::cudaGetDeviceCount, ::cudaGetDevice, ::cudaSetDevice, ::cudaChooseDevice,</para>
        /// <para>::cudaDeviceGetAttribute,</para>
        /// <para>::cuDeviceGetAttribute,</para>
        /// <para>::cuDeviceGetName</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetDeviceProperties(global::CUDA.CudaDeviceProp prop, int device)
        {
            var __arg0 = ReferenceEquals(prop, null) ? global::System.IntPtr.Zero : prop.__Instance;
            var __ret = __Internal.CudaGetDeviceProperties(__arg0, device);
            return __ret;
        }

        /// <summary>Returns information about the device</summary>
        /// <param name="value">- Returned device attribute value</param>
        /// <param name="attr">- Device attribute to query</param>
        /// <param name="device">- Device number to query</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe integer value of the attributeon device</para>
        /// <para>The supported attributes are:</para>
        /// <para>- ::cudaDevAttrMaxThreadsPerBlock: Maximum number of threads per block;</para>
        /// <para>- ::cudaDevAttrMaxBlockDimX: Maximum x-dimension of a block;</para>
        /// <para>- ::cudaDevAttrMaxBlockDimY: Maximum y-dimension of a block;</para>
        /// <para>- ::cudaDevAttrMaxBlockDimZ: Maximum z-dimension of a block;</para>
        /// <para>- ::cudaDevAttrMaxGridDimX: Maximum x-dimension of a grid;</para>
        /// <para>- ::cudaDevAttrMaxGridDimY: Maximum y-dimension of a grid;</para>
        /// <para>- ::cudaDevAttrMaxGridDimZ: Maximum z-dimension of a grid;</para>
        /// <para>- ::cudaDevAttrMaxSharedMemoryPerBlock: Maximum amount of shared memory</para>
        /// <para>available to a thread block in bytes;</para>
        /// <para>- ::cudaDevAttrTotalConstantMemory: Memory available on device for</para>
        /// <para>__constant__ variables in a CUDA C kernel in bytes;</para>
        /// <para>- ::cudaDevAttrWarpSize: Warp size in threads;</para>
        /// <para>- ::cudaDevAttrMaxPitch: Maximum pitch in bytes allowed by the memory copy</para>
        /// <para>functions that involve memory regions allocated through ::cudaMallocPitch();</para>
        /// <para>- ::cudaDevAttrMaxTexture1DWidth: Maximum 1D texture width;</para>
        /// <para>- ::cudaDevAttrMaxTexture1DLinearWidth: Maximum width for a 1D texture bound</para>
        /// <para>to linear memory;</para>
        /// <para>- ::cudaDevAttrMaxTexture1DMipmappedWidth: Maximum mipmapped 1D texture width;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DWidth: Maximum 2D texture width;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DHeight: Maximum 2D texture height;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DLinearWidth: Maximum width for a 2D texture</para>
        /// <para>bound to linear memory;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DLinearHeight: Maximum height for a 2D texture</para>
        /// <para>bound to linear memory;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DLinearPitch: Maximum pitch in bytes for a 2D</para>
        /// <para>texture bound to linear memory;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DMipmappedWidth: Maximum mipmapped 2D texture</para>
        /// <para>width;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DMipmappedHeight: Maximum mipmapped 2D texture</para>
        /// <para>height;</para>
        /// <para>- ::cudaDevAttrMaxTexture3DWidth: Maximum 3D texture width;</para>
        /// <para>- ::cudaDevAttrMaxTexture3DHeight: Maximum 3D texture height;</para>
        /// <para>- ::cudaDevAttrMaxTexture3DDepth: Maximum 3D texture depth;</para>
        /// <para>- ::cudaDevAttrMaxTexture3DWidthAlt: Alternate maximum 3D texture width,</para>
        /// <para>0 if no alternate maximum 3D texture size is supported;</para>
        /// <para>- ::cudaDevAttrMaxTexture3DHeightAlt: Alternate maximum 3D texture height,</para>
        /// <para>0 if no alternate maximum 3D texture size is supported;</para>
        /// <para>- ::cudaDevAttrMaxTexture3DDepthAlt: Alternate maximum 3D texture depth,</para>
        /// <para>0 if no alternate maximum 3D texture size is supported;</para>
        /// <para>- ::cudaDevAttrMaxTextureCubemapWidth: Maximum cubemap texture width or</para>
        /// <para>height;</para>
        /// <para>- ::cudaDevAttrMaxTexture1DLayeredWidth: Maximum 1D layered texture width;</para>
        /// <para>- ::cudaDevAttrMaxTexture1DLayeredLayers: Maximum layers in a 1D layered</para>
        /// <para>texture;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DLayeredWidth: Maximum 2D layered texture width;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DLayeredHeight: Maximum 2D layered texture height;</para>
        /// <para>- ::cudaDevAttrMaxTexture2DLayeredLayers: Maximum layers in a 2D layered</para>
        /// <para>texture;</para>
        /// <para>- ::cudaDevAttrMaxTextureCubemapLayeredWidth: Maximum cubemap layered</para>
        /// <para>texture width or height;</para>
        /// <para>- ::cudaDevAttrMaxTextureCubemapLayeredLayers: Maximum layers in a cubemap</para>
        /// <para>layered texture;</para>
        /// <para>- ::cudaDevAttrMaxSurface1DWidth: Maximum 1D surface width;</para>
        /// <para>- ::cudaDevAttrMaxSurface2DWidth: Maximum 2D surface width;</para>
        /// <para>- ::cudaDevAttrMaxSurface2DHeight: Maximum 2D surface height;</para>
        /// <para>- ::cudaDevAttrMaxSurface3DWidth: Maximum 3D surface width;</para>
        /// <para>- ::cudaDevAttrMaxSurface3DHeight: Maximum 3D surface height;</para>
        /// <para>- ::cudaDevAttrMaxSurface3DDepth: Maximum 3D surface depth;</para>
        /// <para>- ::cudaDevAttrMaxSurface1DLayeredWidth: Maximum 1D layered surface width;</para>
        /// <para>- ::cudaDevAttrMaxSurface1DLayeredLayers: Maximum layers in a 1D layered</para>
        /// <para>surface;</para>
        /// <para>- ::cudaDevAttrMaxSurface2DLayeredWidth: Maximum 2D layered surface width;</para>
        /// <para>- ::cudaDevAttrMaxSurface2DLayeredHeight: Maximum 2D layered surface height;</para>
        /// <para>- ::cudaDevAttrMaxSurface2DLayeredLayers: Maximum layers in a 2D layered</para>
        /// <para>surface;</para>
        /// <para>- ::cudaDevAttrMaxSurfaceCubemapWidth: Maximum cubemap surface width;</para>
        /// <para>- ::cudaDevAttrMaxSurfaceCubemapLayeredWidth: Maximum cubemap layered</para>
        /// <para>surface width;</para>
        /// <para>- ::cudaDevAttrMaxSurfaceCubemapLayeredLayers: Maximum layers in a cubemap</para>
        /// <para>layered surface;</para>
        /// <para>- ::cudaDevAttrMaxRegistersPerBlock: Maximum number of 32-bit registers</para>
        /// <para>available to a thread block;</para>
        /// <para>- ::cudaDevAttrClockRate: Peak clock frequency in kilohertz;</para>
        /// <para>- ::cudaDevAttrTextureAlignment: Alignment requirement; texture base</para>
        /// <para>addresses aligned to ::textureAlign bytes do not need an offset applied</para>
        /// <para>to texture fetches;</para>
        /// <para>- ::cudaDevAttrTexturePitchAlignment: Pitch alignment requirement for 2D</para>
        /// <para>texture references bound to pitched memory;</para>
        /// <para>- ::cudaDevAttrGpuOverlap: 1 if the device can concurrently copy memory</para>
        /// <para>between host and device while executing a kernel, or 0 if not;</para>
        /// <para>- ::cudaDevAttrMultiProcessorCount: Number of multiprocessors on the device;</para>
        /// <para>- ::cudaDevAttrKernelExecTimeout: 1 if there is a run time limit for kernels</para>
        /// <para>executed on the device, or 0 if not;</para>
        /// <para>- ::cudaDevAttrIntegrated: 1 if the device is integrated with the memory</para>
        /// <para>subsystem, or 0 if not;</para>
        /// <para>- ::cudaDevAttrCanMapHostMemory: 1 if the device can map host memory into</para>
        /// <para>the CUDA address space, or 0 if not;</para>
        /// <para>- ::cudaDevAttrComputeMode: Compute mode is the compute mode that the device</para>
        /// <para>is currently in. Available modes are as follows:</para>
        /// <para>- ::cudaComputeModeDefault: Default mode - Device is not restricted and</para>
        /// <para>multiple threads can use ::cudaSetDevice() with this device.</para>
        /// <para>- ::cudaComputeModeExclusive: Compute-exclusive mode - Only one thread will</para>
        /// <para>be able to use ::cudaSetDevice() with this device.</para>
        /// <para>- ::cudaComputeModeProhibited: Compute-prohibited mode - No threads can use</para>
        /// <para>::cudaSetDevice() with this device.</para>
        /// <para>- ::cudaComputeModeExclusiveProcess: Compute-exclusive-process mode - Many</para>
        /// <para>threads in one process will be able to use ::cudaSetDevice() with this</para>
        /// <para>device.</para>
        /// <para>- ::cudaDevAttrConcurrentKernels: 1 if the device supports executing</para>
        /// <para>multiple kernels within the same context simultaneously, or 0 if</para>
        /// <para>not. It is not guaranteed that multiple kernels will be resident on the</para>
        /// <para>device concurrently so this feature should not be relied upon for</para>
        /// <para>correctness;</para>
        /// <para>- ::cudaDevAttrEccEnabled: 1 if error correction is enabled on the device,</para>
        /// <para>0 if error correction is disabled or not supported by the device;</para>
        /// <para>- ::cudaDevAttrPciBusId: PCI bus identifier of the device;</para>
        /// <para>- ::cudaDevAttrPciDeviceId: PCI device (also known as slot) identifier of</para>
        /// <para>the device;</para>
        /// <para>- ::cudaDevAttrTccDriver: 1 if the device is using a TCC driver. TCC is only</para>
        /// <para>available on Tesla hardware running Windows Vista or later;</para>
        /// <para>- ::cudaDevAttrMemoryClockRate: Peak memory clock frequency in kilohertz;</para>
        /// <para>- ::cudaDevAttrGlobalMemoryBusWidth: Global memory bus width in bits;</para>
        /// <para>- ::cudaDevAttrL2CacheSize: Size of L2 cache in bytes. 0 if the device</para>
        /// <para>doesn't have L2 cache;</para>
        /// <para>- ::cudaDevAttrMaxThreadsPerMultiProcessor: Maximum resident threads per</para>
        /// <para>multiprocessor;</para>
        /// <para>- ::cudaDevAttrUnifiedAddressing: 1 if the device shares a unified address</para>
        /// <para>space with the host, or 0 if not;</para>
        /// <para>- ::cudaDevAttrComputeCapabilityMajor: Major compute capability version</para>
        /// <para>number;</para>
        /// <para>- ::cudaDevAttrComputeCapabilityMinor: Minor compute capability version</para>
        /// <para>number;</para>
        /// <para>- ::cudaDevAttrStreamPrioritiesSupported: 1 if the device supports stream</para>
        /// <para>priorities, or 0 if not;</para>
        /// <para>- ::cudaDevAttrGlobalL1CacheSupported: 1 if device supports caching globals</para>
        /// <para>in L1 cache, 0 if not;</para>
        /// <para>- ::cudaDevAttrLocalL1CacheSupported: 1 if device supports caching locals</para>
        /// <para>in L1 cache, 0 if not;</para>
        /// <para>- ::cudaDevAttrMaxSharedMemoryPerMultiprocessor: Maximum amount of shared memory</para>
        /// <para>available to a multiprocessor in bytes; this amount is shared by all</para>
        /// <para>thread blocks simultaneously resident on a multiprocessor;</para>
        /// <para>- ::cudaDevAttrMaxRegistersPerMultiprocessor: Maximum number of 32-bit registers</para>
        /// <para>available to a multiprocessor; this number is shared by all thread blocks</para>
        /// <para>simultaneously resident on a multiprocessor;</para>
        /// <para>- ::cudaDevAttrManagedMemSupported: 1 if device supports allocating</para>
        /// <para>managed memory, 0 if not;</para>
        /// <para>- ::cudaDevAttrIsMultiGpuBoard: 1 if device is on a multi-GPU board, 0 if not;</para>
        /// <para>- ::cudaDevAttrMultiGpuBoardGroupID: Unique identifier for a group of devices on the</para>
        /// <para>same multi-GPU board;</para>
        /// <para>- ::cudaDevAttrHostNativeAtomicSupported: 1 if the link between the device and the</para>
        /// <para>host supports native atomic operations;</para>
        /// <para>- ::cudaDevAttrSingleToDoublePrecisionPerfRatio: Ratio of single precision performance</para>
        /// <para>(in floating-point operations per second) to double precision performance;</para>
        /// <para>- ::cudaDevAttrPageableMemoryAccess: 1 if the device supports coherently accessing</para>
        /// <para>pageable memory without calling cudaHostRegister on it, and 0 otherwise.</para>
        /// <para>- ::cudaDevAttrConcurrentManagedAccess: 1 if the device can coherently access managed</para>
        /// <para>memory concurrently with the CPU, and 0 otherwise.</para>
        /// <para>- ::cudaDevAttrComputePreemptionSupported: 1 if the device supports</para>
        /// <para>Compute Preemption, 0 if not.</para>
        /// <para>- ::cudaDevAttrCanUseHostPointerForRegisteredMem: 1 if the device can access host</para>
        /// <para>registered memory at the same virtual address as the CPU, and 0 otherwise.</para>
        /// <para>- ::cudaDevAttrCooperativeLaunch: 1 if the device supports launching cooperative kernels</para>
        /// <para>via ::cudaLaunchCooperativeKernel, and 0 otherwise.</para>
        /// <para>- ::cudaDevAttrCooperativeMultiDeviceLaunch: 1 if the device supports launching cooperative</para>
        /// <para>kernels via ::cudaLaunchCooperativeKernelMultiDevice, and 0 otherwise.</para>
        /// <para>::cudaGetDeviceCount, ::cudaGetDevice, ::cudaSetDevice, ::cudaChooseDevice,</para>
        /// <para>::cudaGetDeviceProperties,</para>
        /// <para>::cuDeviceGetAttribute</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetAttribute(ref int value, global::CUDA.CudaDeviceAttr attr, int device)
        {
            fixed (int* __refParamPtr0 = &value)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaDeviceGetAttribute(__arg0, attr, device);
                return __ret;
            }
        }

        /// <summary>Queries attributes of the link between two devices.</summary>
        /// <param name="value">- Returned value of the requested attribute</param>
        /// <param name="attrib">- The requested attribute of the link betweenand</param>
        /// <param name="srcDevice">- The source device of the target link.</param>
        /// <param name="dstDevice">- The destination device of the target link.</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe value of the requested attributeof the</para>
        /// <para>link betweenandThe supported attributes are:</para>
        /// <para>- ::CudaDevP2PAttrPerformanceRank: A relative value indicating the</para>
        /// <para>performance of the link between two devices. Lower value means better</para>
        /// <para>performance (0 being the value used for most performant link).</para>
        /// <para>- ::CudaDevP2PAttrAccessSupported: 1 if peer access is enabled.</para>
        /// <para>- ::CudaDevP2PAttrNativeAtomicSupported: 1 if native atomic operations over</para>
        /// <para>the link are supported.</para>
        /// <para>Returns ::cudaErrorInvalidDevice iforare not valid</para>
        /// <para>or if they represent the same device.</para>
        /// <para>Returns ::cudaErrorInvalidValue ifis not valid or ifis</para>
        /// <para>a null pointer.</para>
        /// <para>::cudaCtxEnablePeerAccess,</para>
        /// <para>::cudaCtxDisablePeerAccess,</para>
        /// <para>::cudaCtxCanAccessPeer,</para>
        /// <para>::cuDeviceGetP2PAttribute</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceGetP2PAttribute(ref int value, global::CUDA.CudaDeviceP2PAttr attr, int srcDevice, int dstDevice)
        {
            fixed (int* __refParamPtr0 = &value)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaDeviceGetP2PAttribute(__arg0, attr, srcDevice, dstDevice);
                return __ret;
            }
        }

        /// <summary>Select compute-device which best matches criteria</summary>
        /// <param name="device">- Device with best match</param>
        /// <param name="prop">- Desired device properties</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe device which has properties that best match</para>
        /// <para>::cudaGetDeviceCount, ::cudaGetDevice, ::cudaSetDevice,</para>
        /// <para>::cudaGetDeviceProperties</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaChooseDevice(ref int device, global::CUDA.CudaDeviceProp prop)
        {
            fixed (int* __refParamPtr0 = &device)
            {
                var __arg0 = __refParamPtr0;
                var __arg1 = ReferenceEquals(prop, null) ? global::System.IntPtr.Zero : prop.__Instance;
                var __ret = __Internal.CudaChooseDevice(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Set device to be used for GPU executions</summary>
        /// <param name="device">
        /// <para>- Device on which the active host thread should execute the</para>
        /// <para>device code.</para>
        /// </param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorDeviceAlreadyInUse</para>
        /// </returns>
        /// <remarks>
        /// <para>Setsas the current device for the calling host thread.</para>
        /// <para>Valid device id's are 0 to (::cudaGetDeviceCount() - 1).</para>
        /// <para>Any device memory subsequently allocated from this host thread</para>
        /// <para>using ::cudaMalloc(), ::cudaMallocPitch() or ::cudaMallocArray()</para>
        /// <para>will be physically resident onAny host memory allocated</para>
        /// <para>from this host thread using ::cudaMallocHost() or ::cudaHostAlloc()</para>
        /// <para>or ::cudaHostRegister() will have its lifetime associated  with</para>
        /// <para>Any streams or events created from this host thread will</para>
        /// <para>be associated withAny kernels launched from this host</para>
        /// <para>thread using the&lt;&gt;&lt;&gt;&lt;&gt;&gt;&gt; operator or ::cudaLaunchKernel() will be executed</para>
        /// <para>on</para>
        /// <para>This call may be made from any host thread, to any device, and at</para>
        /// <para>any time.  This function will do no synchronization with the previous</para>
        /// <para>or new device, and should be considered a very low overhead call.</para>
        /// <para>::cudaGetDeviceCount, ::cudaGetDevice, ::cudaGetDeviceProperties,</para>
        /// <para>::cudaChooseDevice,</para>
        /// <para>::cuCtxSetCurrent</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaSetDevice(int device)
        {
            var __ret = __Internal.CudaSetDevice(device);
            return __ret;
        }

        /// <summary>Returns which device is currently being used</summary>
        /// <param name="device">
        /// <para>- Returns the device on which the active host thread</para>
        /// <para>executes the device code.</para>
        /// </param>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>Returns inthe current device for the calling host thread.</para>
        /// <para>::cudaGetDeviceCount, ::cudaSetDevice, ::cudaGetDeviceProperties,</para>
        /// <para>::cudaChooseDevice,</para>
        /// <para>::cuCtxGetCurrent</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetDevice(ref int device)
        {
            fixed (int* __refParamPtr0 = &device)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaGetDevice(__arg0);
                return __ret;
            }
        }

        /// <summary>Set a list of devices that can be used for CUDA</summary>
        /// <param name="device_arr">- List of devices to try</param>
        /// <param name="len">- Number of devices in specified list</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Sets a list of devices for CUDA execution in priority order using</para>
        /// <para>The parameterspecifies the number of elements in the</para>
        /// <para>list.  CUDA will try devices from the list sequentially until it finds one</para>
        /// <para>that works.  If this function is not called, or if it is called with aof 0, then CUDA will go back to its default behavior of trying devices</para>
        /// <para>sequentially from a default list containing all of the available CUDA</para>
        /// <para>devices in the system. If a specified device ID in the list does not exist,</para>
        /// <para>this function will return ::cudaErrorInvalidDevice. Ifis not 0 and</para>
        /// <para>is NULL or ifexceeds the number of devices in</para>
        /// <para>the system, then ::cudaErrorInvalidValue is returned.</para>
        /// <para>::cudaGetDeviceCount, ::cudaSetDevice, ::cudaGetDeviceProperties,</para>
        /// <para>::cudaSetDeviceFlags,</para>
        /// <para>::cudaChooseDevice</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaSetValidDevices(ref int device_arr, int len)
        {
            fixed (int* __refParamPtr0 = &device_arr)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaSetValidDevices(__arg0, len);
                return __ret;
            }
        }

        /// <summary>Sets flags to be used for device executions</summary>
        /// <param name="flags">- Parameters for device operation</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorSetOnActiveProcess</para>
        /// </returns>
        /// <remarks>
        /// <para>Recordsas the flags to use when initializing the current</para>
        /// <para>device.  If no device has been made current to the calling thread,</para>
        /// <para>thenwill be applied to the initialization of any device</para>
        /// <para>initialized by the calling host thread, unless that device has had</para>
        /// <para>its initialization flags set explicitly by this or any host thread.</para>
        /// <para>If the current device has been set and that device has already been</para>
        /// <para>initialized then this call will fail with the error</para>
        /// <para>::cudaErrorSetOnActiveProcess.  In this case it is necessary</para>
        /// <para>to resetusing ::cudaDeviceReset() before the device's</para>
        /// <para>initialization flags may be set.</para>
        /// <para>The two LSBs of theparameter can be used to control how the CPU</para>
        /// <para>thread interacts with the OS scheduler when waiting for results from the</para>
        /// <para>device.</para>
        /// <para>- ::cudaDeviceScheduleAuto: The default value if theparameter is</para>
        /// <para>zero, uses a heuristic based on the number of active CUDA contexts in the</para>
        /// <para>processand the number of logical processors in the systemIf</para>
        /// <para>then CUDA will yield to other OS threads when waiting for the</para>
        /// <para>device, otherwise CUDA will not yield while waiting for results and</para>
        /// <para>actively spin on the processor.</para>
        /// <para>- ::cudaDeviceScheduleSpin: Instruct CUDA to actively spin when waiting for</para>
        /// <para>results from the device. This can decrease latency when waiting for the</para>
        /// <para>device, but may lower the performance of CPU threads if they are performing</para>
        /// <para>work in parallel with the CUDA thread.</para>
        /// <para>- ::cudaDeviceScheduleYield: Instruct CUDA to yield its thread when waiting</para>
        /// <para>for results from the device. This can increase latency when waiting for the</para>
        /// <para>device, but can increase the performance of CPU threads performing work in</para>
        /// <para>parallel with the device.</para>
        /// <para>- ::cudaDeviceScheduleBlockingSync: Instruct CUDA to block the CPU thread</para>
        /// <para>on a synchronization primitive when waiting for the device to finish work.</para>
        /// <para>- ::cudaDeviceBlockingSync: Instruct CUDA to block the CPU thread on a</para>
        /// <para>synchronization primitive when waiting for the device to finish work.</para>
        /// <para>replaced with ::cudaDeviceScheduleBlockingSync.</para>
        /// <para>- ::cudaDeviceMapHost: This flag enables allocating pinned</para>
        /// <para>host memory that is accessible to the device. It is implicit for the</para>
        /// <para>runtime but may be absent if a context is created using the driver API.</para>
        /// <para>If this flag is not set, ::cudaHostGetDevicePointer() will always return</para>
        /// <para>a failure code.</para>
        /// <para>- ::cudaDeviceLmemResizeToMax: Instruct CUDA to not reduce local memory</para>
        /// <para>after resizing local memory for a kernel. This can prevent thrashing by</para>
        /// <para>local memory allocations when launching many kernels with high local</para>
        /// <para>memory usage at the cost of potentially increased memory usage.</para>
        /// <para>::cudaGetDeviceFlags, ::cudaGetDeviceCount, ::cudaGetDevice, ::cudaGetDeviceProperties,</para>
        /// <para>::cudaSetDevice, ::cudaSetValidDevices,</para>
        /// <para>::cudaChooseDevice,</para>
        /// <para>::cuDevicePrimaryCtxSetFlags</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaSetDeviceFlags(uint flags)
        {
            var __ret = __Internal.CudaSetDeviceFlags(flags);
            return __ret;
        }

        /// <summary>Gets the flags for the current device</summary>
        /// <param name="flags">- Pointer to store the device flags</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe flags for the current device.  If there is a</para>
        /// <para>current device for the calling thread, and the device has been initialized</para>
        /// <para>or flags have been set on that device specifically, the flags for the</para>
        /// <para>device are returned.  If there is no current device, but flags have been</para>
        /// <para>set for the thread with ::cudaSetDeviceFlags, the thread flags are returned.</para>
        /// <para>Finally, if there is no current device and no thread flags, the flags for</para>
        /// <para>the first device are returned, which may be the default flags.  Compare</para>
        /// <para>to the behavior of ::cudaSetDeviceFlags.</para>
        /// <para>Typically, the flags returned should match the behavior that will be seen</para>
        /// <para>if the calling thread uses a device after this call, without any change to</para>
        /// <para>the flags or current device inbetween by this or another thread.  Note that</para>
        /// <para>if the device is not initialized, it is possible for another thread to</para>
        /// <para>change the flags for the current device before it is initialized.</para>
        /// <para>Additionally, when using exclusive mode, if this thread has not requested a</para>
        /// <para>specific device, it may use a device other than the first device, contrary</para>
        /// <para>to the assumption made by this function.</para>
        /// <para>If a context has been created via the driver API and is current to the</para>
        /// <para>calling thread, the flags for that context are always returned.</para>
        /// <para>Flags returned by this function may specifically include ::cudaDeviceMapHost</para>
        /// <para>even though it is not accepted by ::cudaSetDeviceFlags because it is</para>
        /// <para>implicit in runtime API flags.  The reason for this is that the current</para>
        /// <para>context may have been created via the driver API in which case the flag is</para>
        /// <para>not implicit and may be unset.</para>
        /// <para>::cudaGetDevice, ::cudaGetDeviceProperties,</para>
        /// <para>::cudaSetDevice, ::cudaSetDeviceFlags,</para>
        /// <para>::cuCtxGetFlags,</para>
        /// <para>::cuDevicePrimaryCtxGetState</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetDeviceFlags(ref uint flags)
        {
            fixed (uint* __refParamPtr0 = &flags)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaGetDeviceFlags(__arg0);
                return __ret;
            }
        }

        /// <summary>Create an asynchronous stream</summary>
        /// <param name="pStream">- Pointer to new stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates a new asynchronous stream.</para>
        /// <para>::cudaStreamCreateWithPriority,</para>
        /// <para>::cudaStreamCreateWithFlags,</para>
        /// <para>::cudaStreamGetPriority,</para>
        /// <para>::cudaStreamGetFlags,</para>
        /// <para>::cudaStreamQuery,</para>
        /// <para>::cudaStreamSynchronize,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cudaStreamAddCallback,</para>
        /// <para>::cudaStreamDestroy,</para>
        /// <para>::cuStreamCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamCreate(global::CUDA.CUstreamSt pStream)
        {
            var __arg0 = ReferenceEquals(pStream, null) ? global::System.IntPtr.Zero : pStream.__Instance;
            var __ret = __Internal.CudaStreamCreate(__arg0);
            return __ret;
        }

        /// <summary>Create an asynchronous stream</summary>
        /// <param name="pStream">- Pointer to new stream identifier</param>
        /// <param name="flags">- Parameters for stream creation</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates a new asynchronous stream.  Theargument determines the</para>
        /// <para>behaviors of the stream.  Valid values forare</para>
        /// <para>- ::cudaStreamDefault: Default stream creation flag.</para>
        /// <para>- ::cudaStreamNonBlocking: Specifies that work running in the created</para>
        /// <para>stream may run concurrently with work in stream 0 (the NULL stream), and that</para>
        /// <para>the created stream should perform no implicit synchronization with stream 0.</para>
        /// <para>::cudaStreamCreate,</para>
        /// <para>::cudaStreamCreateWithPriority,</para>
        /// <para>::cudaStreamGetFlags,</para>
        /// <para>::cudaStreamQuery,</para>
        /// <para>::cudaStreamSynchronize,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cudaStreamAddCallback,</para>
        /// <para>::cudaStreamDestroy,</para>
        /// <para>::cuStreamCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamCreateWithFlags(global::CUDA.CUstreamSt pStream, uint flags)
        {
            var __arg0 = ReferenceEquals(pStream, null) ? global::System.IntPtr.Zero : pStream.__Instance;
            var __ret = __Internal.CudaStreamCreateWithFlags(__arg0, flags);
            return __ret;
        }

        /// <summary>Create an asynchronous stream with the specified priority</summary>
        /// <param name="pStream">- Pointer to new stream identifier</param>
        /// <param name="flags">- Flags for stream creation. See ::cudaStreamCreateWithFlags for a list of valid flags that can be passed</param>
        /// <param name="priority">
        /// <para>- Priority of the stream. Lower numbers represent higher priorities.</para>
        /// <para>See ::cudaDeviceGetStreamPriorityRange for more information about</para>
        /// <para>the meaningful stream priorities that can be passed.</para>
        /// </param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates a stream with the specified priority and returns a handle inThis API alters the scheduler priority of work in the stream. Work in a higher</para>
        /// <para>priority stream may preempt work already executing in a low priority stream.</para>
        /// <para>follows a convention where lower numbers represent higher priorities.</para>
        /// <para>'0' represents default priority. The range of meaningful numerical priorities can</para>
        /// <para>be queried using ::cudaDeviceGetStreamPriorityRange. If the specified priority is</para>
        /// <para>outside the numerical range returned by ::cudaDeviceGetStreamPriorityRange,</para>
        /// <para>it will automatically be clamped to the lowest or the highest number in the range.</para>
        /// <para>Stream priorities are supported only on GPUs</para>
        /// <para>with compute capability 3.5 or higher.</para>
        /// <para>In the current implementation, only compute kernels launched in</para>
        /// <para>priority streams are affected by the stream's priority. Stream priorities have</para>
        /// <para>no effect on host-to-device and device-to-host memory operations.</para>
        /// <para>::cudaStreamCreate,</para>
        /// <para>::cudaStreamCreateWithFlags,</para>
        /// <para>::cudaDeviceGetStreamPriorityRange,</para>
        /// <para>::cudaStreamGetPriority,</para>
        /// <para>::cudaStreamQuery,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cudaStreamAddCallback,</para>
        /// <para>::cudaStreamSynchronize,</para>
        /// <para>::cudaStreamDestroy,</para>
        /// <para>::cuStreamCreateWithPriority</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamCreateWithPriority(global::CUDA.CUstreamSt pStream, uint flags, int priority)
        {
            var __arg0 = ReferenceEquals(pStream, null) ? global::System.IntPtr.Zero : pStream.__Instance;
            var __ret = __Internal.CudaStreamCreateWithPriority(__arg0, flags, priority);
            return __ret;
        }

        /// <summary>Query the priority of a stream</summary>
        /// <param name="hStream">- Handle to the stream to be queried</param>
        /// <param name="priority">- Pointer to a signed integer in which the stream's priority is returned</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle</para>
        /// </returns>
        /// <remarks>
        /// <para>Query the priority of a stream. The priority is returned in inNote that if the stream was created with a priority outside the meaningful</para>
        /// <para>numerical range returned by ::cudaDeviceGetStreamPriorityRange,</para>
        /// <para>this function returns the clamped priority.</para>
        /// <para>See ::cudaStreamCreateWithPriority for details about priority clamping.</para>
        /// <para>::cudaStreamCreateWithPriority,</para>
        /// <para>::cudaDeviceGetStreamPriorityRange,</para>
        /// <para>::cudaStreamGetFlags,</para>
        /// <para>::cuStreamGetPriority</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamGetPriority(global::CUDA.CUstreamSt hStream, ref int priority)
        {
            var __arg0 = ReferenceEquals(hStream, null) ? global::System.IntPtr.Zero : hStream.__Instance;
            fixed (int* __refParamPtr1 = &priority)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.CudaStreamGetPriority(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Query the flags of a stream</summary>
        /// <param name="hStream">- Handle to the stream to be queried</param>
        /// <param name="flags">- Pointer to an unsigned integer in which the stream's flags are returned</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle</para>
        /// </returns>
        /// <remarks>
        /// <para>Query the flags of a stream. The flags are returned inSee ::cudaStreamCreateWithFlags for a list of valid flags.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaStreamCreateWithPriority,</para>
        /// <para>::cudaStreamCreateWithFlags,</para>
        /// <para>::cudaStreamGetPriority,</para>
        /// <para>::cuStreamGetFlags</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamGetFlags(global::CUDA.CUstreamSt hStream, ref uint flags)
        {
            var __arg0 = ReferenceEquals(hStream, null) ? global::System.IntPtr.Zero : hStream.__Instance;
            fixed (uint* __refParamPtr1 = &flags)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.CudaStreamGetFlags(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Destroys and cleans up an asynchronous stream</summary>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle</para>
        /// </returns>
        /// <remarks>
        /// <para>Destroys and cleans up the asynchronous stream specified by</para>
        /// <para>In case the device is still doing work in the streamwhen ::cudaStreamDestroy() is called, the function will return immediately</para>
        /// <para>and the resources associated withwill be released automatically</para>
        /// <para>once the device has completed all work in</para>
        /// <para>_null_stream</para>
        /// <para>::cudaStreamCreate,</para>
        /// <para>::cudaStreamCreateWithFlags,</para>
        /// <para>::cudaStreamQuery,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cudaStreamSynchronize,</para>
        /// <para>::cudaStreamAddCallback,</para>
        /// <para>::cuStreamDestroy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamDestroy(global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaStreamDestroy(__arg0);
            return __ret;
        }

        /// <summary>Make a compute stream wait on an event</summary>
        /// <param name="stream">- Stream to wait</param>
        /// <param name="event">- Event to wait on</param>
        /// <param name="flags">- Parameters for the operation (must be 0)</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle</para>
        /// </returns>
        /// <remarks>
        /// <para>Makes all future work submitted towait for all work captured in</para>
        /// <para>See ::cudaEventRecord() for details on what is captured by an event.</para>
        /// <para>The synchronization will be performed efficiently on the device when applicable.</para>
        /// <para>may be from a different device than</para>
        /// <para>_null_stream</para>
        /// <para>::cudaStreamCreate, ::cudaStreamCreateWithFlags, ::cudaStreamQuery, ::cudaStreamSynchronize, ::cudaStreamAddCallback, ::cudaStreamDestroy,</para>
        /// <para>::cuStreamWaitEvent</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamWaitEvent(global::CUDA.CUstreamSt stream, global::CUDA.CUeventSt @event, uint flags)
        {
            var __arg0 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __arg1 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaStreamWaitEvent(__arg0, __arg1, flags);
            return __ret;
        }

        /// <summary>Add a callback to a compute stream</summary>
        /// <param name="stream">- Stream to add callback to</param>
        /// <param name="callback">- The function to call once preceding stream operations are complete</param>
        /// <param name="userData">- User specified data to be passed to the callback function</param>
        /// <param name="flags">- Reserved for future use, must be 0</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorNotSupported</para>
        /// </returns>
        /// <remarks>
        /// <para>Adds a callback to be called on the host after all currently enqueued</para>
        /// <para>items in the stream have completed.  For each</para>
        /// <para>cudaStreamAddCallback call, a callback will be executed exactly once.</para>
        /// <para>The callback will block later work in the stream until it is finished.</para>
        /// <para>The callback may be passed ::cudaSuccess or an error code.  In the event</para>
        /// <para>of a device error, all subsequently executed callbacks will receive an</para>
        /// <para>appropriate ::cudaError_t.</para>
        /// <para>Callbacks must not make any CUDA API calls.  Attempting to use CUDA APIs</para>
        /// <para>will result in ::cudaErrorNotPermitted.  Callbacks must not perform any</para>
        /// <para>synchronization that may depend on outstanding device work or other callbacks</para>
        /// <para>that are not mandated to run earlier.  Callbacks without a mandated order</para>
        /// <para>(in independent streams) execute in undefined order and may be serialized.</para>
        /// <para>For the purposes of Unified Memory, callback execution makes a number of</para>
        /// <para>guarantees:</para>
        /// <para></para>
        /// <para>The callback stream is considered idle for the duration of the</para>
        /// <para>callback.  Thus, for example, a callback may always use memory attached</para>
        /// <para>to the callback stream.</para>
        /// <para>The start of execution of a callback has the same effect as</para>
        /// <para>synchronizing an event recorded in the same stream immediately prior to</para>
        /// <para>the callback.  It thus synchronizes streams which have been &quot;joined&quot;</para>
        /// <para>prior to the callback.</para>
        /// <para>Adding device work to any stream does not have the effect of making</para>
        /// <para>the stream active until all preceding callbacks have executed.  Thus, for</para>
        /// <para>example, a callback might use global attached memory even if work has</para>
        /// <para>been added to another stream, if it has been properly ordered with an</para>
        /// <para>event.</para>
        /// <para>Completion of a callback does not cause a stream to become</para>
        /// <para>active except as described above.  The callback stream will remain idle</para>
        /// <para>if no device work follows the callback, and will remain idle across</para>
        /// <para>consecutive callbacks without device work in between.  Thus, for example,</para>
        /// <para>stream synchronization can be done by signaling from a callback at the</para>
        /// <para>end of the stream.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaStreamCreate, ::cudaStreamCreateWithFlags, ::cudaStreamQuery, ::cudaStreamSynchronize, ::cudaStreamWaitEvent, ::cudaStreamDestroy, ::cudaMallocManaged, ::cudaStreamAttachMemAsync,</para>
        /// <para>::cuStreamAddCallback</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamAddCallback(global::CUDA.CUstreamSt stream, global::CUDA.CudaStreamCallbackT callback, global::System.IntPtr userData, uint flags)
        {
            var __arg0 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __arg1 = callback == null ? global::System.IntPtr.Zero : Marshal.GetFunctionPointerForDelegate(callback);
            var __ret = __Internal.CudaStreamAddCallback(__arg0, __arg1, userData, flags);
            return __ret;
        }

        /// <summary>Waits for stream tasks to complete</summary>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidResourceHandle</para>
        /// </returns>
        /// <remarks>
        /// <para>Blocks untilhas completed all operations. If the</para>
        /// <para>::cudaDeviceScheduleBlockingSync flag was set for this device,</para>
        /// <para>the host thread will block until the stream is finished with</para>
        /// <para>all of its tasks.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaStreamCreate, ::cudaStreamCreateWithFlags, ::cudaStreamQuery, ::cudaStreamWaitEvent, ::cudaStreamAddCallback, ::cudaStreamDestroy,</para>
        /// <para>::cuStreamSynchronize</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamSynchronize(global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaStreamSynchronize(__arg0);
            return __ret;
        }

        /// <summary>Queries an asynchronous stream for completion status</summary>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorNotReady,</para>
        /// <para>::cudaErrorInvalidResourceHandle</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns ::cudaSuccess if all operations inhave</para>
        /// <para>completed, or ::cudaErrorNotReady if not.</para>
        /// <para>For the purposes of Unified Memory, a return value of ::cudaSuccess</para>
        /// <para>is equivalent to having called ::cudaStreamSynchronize().</para>
        /// <para>_null_stream</para>
        /// <para>::cudaStreamCreate, ::cudaStreamCreateWithFlags, ::cudaStreamWaitEvent, ::cudaStreamSynchronize, ::cudaStreamAddCallback, ::cudaStreamDestroy,</para>
        /// <para>::cuStreamQuery</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamQuery(global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaStreamQuery(__arg0);
            return __ret;
        }

        /// <summary>Attach memory to a stream asynchronously</summary>
        /// <param name="stream">- Stream in which to enqueue the attach operation</param>
        /// <param name="devPtr">- Pointer to memory (must be a pointer to managed memory)</param>
        /// <param name="length">- Length of memory (must be zero, defaults to zero)</param>
        /// <param name="flags">- Must be one of ::cudaMemAttachGlobal, ::cudaMemAttachHost or ::cudaMemAttachSingle (defaults to ::cudaMemAttachSingle)</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorNotReady,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle</para>
        /// </returns>
        /// <remarks>
        /// <para>Enqueues an operation into specify stream association of</para>
        /// <para>bytes of memory starting fromThis function is a</para>
        /// <para>stream-ordered operation, meaning that it is dependent on, and will</para>
        /// <para>only take effect when, previous work in stream has completed. Any</para>
        /// <para>previous association is automatically replaced.</para>
        /// <para>must point to an address within managed memory space declared</para>
        /// <para>using the __managed__ keyword or allocated with ::cudaMallocManaged.</para>
        /// <para>must be zero, to indicate that the entire allocation's</para>
        /// <para>stream association is being changed.  Currently, it's not possible</para>
        /// <para>to change stream association for a portion of an allocation. The default</para>
        /// <para>value foris zero.</para>
        /// <para>The stream association is specified usingwhich must be</para>
        /// <para>one of ::cudaMemAttachGlobal, ::cudaMemAttachHost or ::cudaMemAttachSingle.</para>
        /// <para>The default value foris ::cudaMemAttachSingle</para>
        /// <para>If the ::cudaMemAttachGlobal flag is specified, the memory can be accessed</para>
        /// <para>by any stream on any device.</para>
        /// <para>If the ::cudaMemAttachHost flag is specified, the program makes a guarantee</para>
        /// <para>that it won't access the memory on the device from any stream on a device that</para>
        /// <para>has a zero value for the device attribute ::cudaDevAttrConcurrentManagedAccess.</para>
        /// <para>If the ::cudaMemAttachSingle flag is specified andis associated with</para>
        /// <para>a device that has a zero value for the device attribute ::cudaDevAttrConcurrentManagedAccess,</para>
        /// <para>the program makes a guarantee that it will only access the memory on the device</para>
        /// <para>fromIt is illegal to attach singly to the NULL stream, because the</para>
        /// <para>NULL stream is a virtual global stream and not a specific stream. An error will</para>
        /// <para>be returned in this case.</para>
        /// <para>When memory is associated with a single stream, the Unified Memory system will</para>
        /// <para>allow CPU access to this memory region so long as all operations inhave completed, regardless of whether other streams are active. In effect,</para>
        /// <para>this constrains exclusive ownership of the managed memory region by</para>
        /// <para>an active GPU to per-stream activity instead of whole-GPU activity.</para>
        /// <para>Accessing memory on the device from streams that are not associated with</para>
        /// <para>it will produce undefined results. No error checking is performed by the</para>
        /// <para>Unified Memory system to ensure that kernels launched into other streams</para>
        /// <para>do not access this region.</para>
        /// <para>It is a program's responsibility to order calls to ::cudaStreamAttachMemAsync</para>
        /// <para>via events, synchronization or other means to ensure legal access to memory</para>
        /// <para>at all times. Data visibility and coherency will be changed appropriately</para>
        /// <para>for all kernels which follow a stream-association change.</para>
        /// <para>Ifis destroyed while data is associated with it, the association is</para>
        /// <para>removed and the association reverts to the default visibility of the allocation</para>
        /// <para>as specified at ::cudaMallocManaged. For __managed__ variables, the default</para>
        /// <para>association is always ::cudaMemAttachGlobal. Note that destroying a stream is an</para>
        /// <para>asynchronous operation, and as a result, the change to default association won't</para>
        /// <para>happen until all work in the stream has completed.</para>
        /// <para>::cudaStreamCreate, ::cudaStreamCreateWithFlags, ::cudaStreamWaitEvent, ::cudaStreamSynchronize, ::cudaStreamAddCallback, ::cudaStreamDestroy, ::cudaMallocManaged,</para>
        /// <para>::cuStreamAttachMemAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaStreamAttachMemAsync(global::CUDA.CUstreamSt stream, global::System.IntPtr devPtr, ulong length, uint flags)
        {
            var __arg0 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaStreamAttachMemAsync(__arg0, devPtr, length, flags);
            return __ret;
        }

        /// <summary>Creates an event object</summary>
        /// <param name="event">- Newly created event</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates an event object for the current device using ::cudaEventDefault.</para>
        /// <para>::cudaEventCreateWithFlags, ::cudaEventRecord, ::cudaEventQuery,</para>
        /// <para>::cudaEventSynchronize, ::cudaEventDestroy, ::cudaEventElapsedTime,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cuEventCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventCreate(global::CUDA.CUeventSt @event)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaEventCreate(__arg0);
            return __ret;
        }

        /// <summary>Creates an event object with the specified flags</summary>
        /// <param name="event">- Newly created event</param>
        /// <param name="flags">- Flags for new event</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates an event object for the current device with the specified flags. Valid</para>
        /// <para>flags include:</para>
        /// <para>- ::cudaEventDefault: Default event creation flag.</para>
        /// <para>- ::cudaEventBlockingSync: Specifies that event should use blocking</para>
        /// <para>synchronization. A host thread that uses ::cudaEventSynchronize() to wait</para>
        /// <para>on an event created with this flag will block until the event actually</para>
        /// <para>completes.</para>
        /// <para>- ::cudaEventDisableTiming: Specifies that the created event does not need</para>
        /// <para>to record timing data.  Events created with this flag specified and</para>
        /// <para>the ::cudaEventBlockingSync flag not specified will provide the best</para>
        /// <para>performance when used with ::cudaStreamWaitEvent() and ::cudaEventQuery().</para>
        /// <para>- ::cudaEventInterprocess: Specifies that the created event may be used as an</para>
        /// <para>interprocess event by ::cudaIpcGetEventHandle(). ::cudaEventInterprocess must</para>
        /// <para>be specified along with ::cudaEventDisableTiming.</para>
        /// <para>::cudaEventSynchronize, ::cudaEventDestroy, ::cudaEventElapsedTime,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cuEventCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventCreateWithFlags(global::CUDA.CUeventSt @event, uint flags)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaEventCreateWithFlags(__arg0, flags);
            return __ret;
        }

        /// <summary>Records an event</summary>
        /// <param name="event">- Event to record</param>
        /// <param name="stream">- Stream in which to record event</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorLaunchFailure</para>
        /// </returns>
        /// <remarks>
        /// <para>Captures inthe contents ofat the time of this call.</para>
        /// <para>andmust be on the same device.</para>
        /// <para>Calls such as ::cudaEventQuery() or ::cudaStreamWaitEvent() will then</para>
        /// <para>examine or wait for completion of the work that was captured. Uses of</para>
        /// <para>after this call do not modifySee note on default</para>
        /// <para>stream behavior for what is captured in the default case.</para>
        /// <para>::cudaEventRecord() can be called multiple times on the same event and</para>
        /// <para>will overwrite the previously captured state. Other APIs such as</para>
        /// <para>::cudaStreamWaitEvent() use the most recently captured state at the time</para>
        /// <para>of the API call, and are not affected by later calls to</para>
        /// <para>::cudaEventRecord(). Before the first call to ::cudaEventRecord(), an</para>
        /// <para>event represents an empty set of work, so for example ::cudaEventQuery()</para>
        /// <para>would return ::cudaSuccess.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaEventCreateWithFlags, ::cudaEventQuery,</para>
        /// <para>::cudaEventSynchronize, ::cudaEventDestroy, ::cudaEventElapsedTime,</para>
        /// <para>::cudaStreamWaitEvent,</para>
        /// <para>::cuEventRecord</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventRecord(global::CUDA.CUeventSt @event, global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __arg1 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaEventRecord(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Queries an event's status</summary>
        /// <param name="event">- Event to query</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorNotReady,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorLaunchFailure</para>
        /// </returns>
        /// <remarks>
        /// <para>Queries the status of all work currently captured bySee</para>
        /// <para>::cudaEventRecord() for details on what is captured by an event.</para>
        /// <para>Returns ::cudaSuccess if all captured work has been completed, or</para>
        /// <para>::cudaErrorNotReady if any captured work is incomplete.</para>
        /// <para>For the purposes of Unified Memory, a return value of ::cudaSuccess</para>
        /// <para>is equivalent to having called ::cudaEventSynchronize().</para>
        /// <para>::cudaEventCreateWithFlags, ::cudaEventRecord,</para>
        /// <para>::cudaEventSynchronize, ::cudaEventDestroy, ::cudaEventElapsedTime,</para>
        /// <para>::cuEventQuery</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventQuery(global::CUDA.CUeventSt @event)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaEventQuery(__arg0);
            return __ret;
        }

        /// <summary>Waits for an event to complete</summary>
        /// <param name="event">- Event to wait for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorLaunchFailure</para>
        /// </returns>
        /// <remarks>
        /// <para>Waits until the completion of all work currently captured inSee ::cudaEventRecord() for details on what is captured by an event.</para>
        /// <para>Waiting for an event that was created with the ::cudaEventBlockingSync</para>
        /// <para>flag will cause the calling CPU thread to block until the event has</para>
        /// <para>been completed by the device.  If the ::cudaEventBlockingSync flag has</para>
        /// <para>not been set, then the CPU thread will busy-wait until the event has</para>
        /// <para>been completed by the device.</para>
        /// <para>::cudaEventCreateWithFlags, ::cudaEventRecord,</para>
        /// <para>::cudaEventQuery, ::cudaEventDestroy, ::cudaEventElapsedTime,</para>
        /// <para>::cuEventSynchronize</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventSynchronize(global::CUDA.CUeventSt @event)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaEventSynchronize(__arg0);
            return __ret;
        }

        /// <summary>Destroys an event object</summary>
        /// <param name="event">- Event to destroy</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorLaunchFailure</para>
        /// </returns>
        /// <remarks>
        /// <para>Destroys the event specified by</para>
        /// <para>An event may be destroyed before it is complete (i.e., while</para>
        /// <para>::cudaEventQuery() would return ::cudaErrorNotReady). In this case, the</para>
        /// <para>call does not block on completion of the event, and any associated</para>
        /// <para>resources will automatically be released asynchronously at completion.</para>
        /// <para>::cudaEventCreateWithFlags, ::cudaEventQuery,</para>
        /// <para>::cudaEventSynchronize, ::cudaEventRecord, ::cudaEventElapsedTime,</para>
        /// <para>::cuEventDestroy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventDestroy(global::CUDA.CUeventSt @event)
        {
            var __arg0 = ReferenceEquals(@event, null) ? global::System.IntPtr.Zero : @event.__Instance;
            var __ret = __Internal.CudaEventDestroy(__arg0);
            return __ret;
        }

        /// <summary>Computes the elapsed time between events</summary>
        /// <param name="ms">- Time betweenandin ms</param>
        /// <param name="start">- Starting event</param>
        /// <param name="end">- Ending event</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorNotReady,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorLaunchFailure</para>
        /// </returns>
        /// <remarks>
        /// <para>Computes the elapsed time between two events (in milliseconds with a</para>
        /// <para>resolution of around 0.5 microseconds).</para>
        /// <para>If either event was last recorded in a non-NULL stream, the resulting time</para>
        /// <para>may be greater than expected (even if both used the same stream handle). This</para>
        /// <para>happens because the ::cudaEventRecord() operation takes place asynchronously</para>
        /// <para>and there is no guarantee that the measured latency is actually just between</para>
        /// <para>the two events. Any number of other different stream operations could execute</para>
        /// <para>in between the two measured events, thus altering the timing in a significant</para>
        /// <para>way.</para>
        /// <para>If ::cudaEventRecord() has not been called on either event, then</para>
        /// <para>::cudaErrorInvalidResourceHandle is returned. If ::cudaEventRecord() has been</para>
        /// <para>called on both events but one or both of them has not yet been completed</para>
        /// <para>(that is, ::cudaEventQuery() would return ::cudaErrorNotReady on at least one</para>
        /// <para>of the events), ::cudaErrorNotReady is returned. If either event was created</para>
        /// <para>with the ::cudaEventDisableTiming flag, then this function will return</para>
        /// <para>::cudaErrorInvalidResourceHandle.</para>
        /// <para>::cudaEventCreateWithFlags, ::cudaEventQuery,</para>
        /// <para>::cudaEventSynchronize, ::cudaEventDestroy, ::cudaEventRecord,</para>
        /// <para>::cuEventElapsedTime</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaEventElapsedTime(ref float ms, global::CUDA.CUeventSt start, global::CUDA.CUeventSt end)
        {
            fixed (float* __refParamPtr0 = &ms)
            {
                var __arg0 = __refParamPtr0;
                var __arg1 = ReferenceEquals(start, null) ? global::System.IntPtr.Zero : start.__Instance;
                var __arg2 = ReferenceEquals(end, null) ? global::System.IntPtr.Zero : end.__Instance;
                var __ret = __Internal.CudaEventElapsedTime(__arg0, __arg1, __arg2);
                return __ret;
            }
        }

        /// <summary>Launches a device function</summary>
        /// <param name="func">- Device function symbol</param>
        /// <param name="gridDim">- Grid dimentions</param>
        /// <param name="blockDim">- Block dimentions</param>
        /// <param name="args">- Arguments</param>
        /// <param name="sharedMem">- Shared memory</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidConfiguration,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorLaunchTimeout,</para>
        /// <para>::cudaErrorLaunchOutOfResources,</para>
        /// <para>::cudaErrorSharedObjectInitFailed,</para>
        /// <para>::cudaErrorInvalidPtx,</para>
        /// <para>::cudaErrorNoKernelImageForDevice,</para>
        /// <para>::cudaErrorJitCompilerNotFound</para>
        /// </returns>
        /// <remarks>
        /// <para>The function invokes kernelon(&#215;&#215;grid of blocks. Each block contains(&#215;</para>
        /// <para>&#215;threads.</para>
        /// <para>If the kernel has N parameters theshould point to array of N pointers.</para>
        /// <para>Each pointer, fromargs[0]toargs[N - 1], point to the region</para>
        /// <para>of memory from which the actual parameter will be copied.</para>
        /// <para>For templated functions, pass the function symbol as follows:</para>
        /// <para>func_name_arg_0,...,template_arg_N&gt;</para>
        /// <para>sets the amount of dynamic shared memory that will be available to</para>
        /// <para>each thread block.</para>
        /// <para>specifies a stream the invocation is associated to.</para>
        /// <para>_null_stream</para>
        /// <para>::cuLaunchKernel</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaLaunchKernel(global::System.IntPtr func, global::CUDA.Dim3 gridDim, global::CUDA.Dim3 blockDim, void** args, ulong sharedMem, global::CUDA.CUstreamSt stream)
        {
            var __arg1 = ReferenceEquals(gridDim, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)gridDim.__Instance;
            var __arg2 = ReferenceEquals(blockDim, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)blockDim.__Instance;
            var __arg5 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaLaunchKernel(func, __arg1, __arg2, args, sharedMem, __arg5);
            return __ret;
        }

        /// <summary>Launches a device function where thread blocks can cooperate and synchronize as they execute</summary>
        /// <param name="func">- Device function symbol</param>
        /// <param name="gridDim">- Grid dimentions</param>
        /// <param name="blockDim">- Block dimentions</param>
        /// <param name="args">- Arguments</param>
        /// <param name="sharedMem">- Shared memory</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidConfiguration,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorLaunchTimeout,</para>
        /// <para>::cudaErrorLaunchOutOfResources,</para>
        /// <para>::cudaErrorCooperativeLaunchTooLarge,</para>
        /// <para>::cudaErrorSharedObjectInitFailed</para>
        /// </returns>
        /// <remarks>
        /// <para>The function invokes kernelon(&#215;&#215;grid of blocks. Each block contains(&#215;</para>
        /// <para>&#215;threads.</para>
        /// <para>The device on which this kernel is invoked must have a non-zero value for</para>
        /// <para>the device attribute ::cudaDevAttrCooperativeLaunch.</para>
        /// <para>The total number of blocks launched cannot exceed the maximum number of blocks per</para>
        /// <para>multiprocessor as returned by ::cudaOccupancyMaxActiveBlocksPerMultiprocessor (or</para>
        /// <para>::cudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags) times the number of multiprocessors</para>
        /// <para>as specified by the device attribute ::cudaDevAttrMultiProcessorCount.</para>
        /// <para>The kernel cannot make use of CUDA dynamic parallelism.</para>
        /// <para>If the kernel has N parameters theshould point to array of N pointers.</para>
        /// <para>Each pointer, fromargs[0]toargs[N - 1], point to the region</para>
        /// <para>of memory from which the actual parameter will be copied.</para>
        /// <para>For templated functions, pass the function symbol as follows:</para>
        /// <para>func_name_arg_0,...,template_arg_N&gt;</para>
        /// <para>sets the amount of dynamic shared memory that will be available to</para>
        /// <para>each thread block.</para>
        /// <para>specifies a stream the invocation is associated to.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaLaunchCooperativeKernelMultiDevice,</para>
        /// <para>::cuLaunchCooperativeKernel</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaLaunchCooperativeKernel(global::System.IntPtr func, global::CUDA.Dim3 gridDim, global::CUDA.Dim3 blockDim, void** args, ulong sharedMem, global::CUDA.CUstreamSt stream)
        {
            var __arg1 = ReferenceEquals(gridDim, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)gridDim.__Instance;
            var __arg2 = ReferenceEquals(blockDim, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)blockDim.__Instance;
            var __arg5 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaLaunchCooperativeKernel(func, __arg1, __arg2, args, sharedMem, __arg5);
            return __ret;
        }

        /// <summary>Launches device functions on multiple devices where thread blocks can cooperate and synchronize as they execute</summary>
        /// <param name="launchParamsList">- List of launch parameters, one per device</param>
        /// <param name="numDevices">- Size of thearray</param>
        /// <param name="flags">- Flags to control launch behavior</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidConfiguration,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorLaunchTimeout,</para>
        /// <para>::cudaErrorLaunchOutOfResources,</para>
        /// <para>::cudaErrorCooperativeLaunchTooLarge,</para>
        /// <para>::cudaErrorSharedObjectInitFailed</para>
        /// </returns>
        /// <remarks>
        /// <para>Invokes kernels as specified in thearray where each element</para>
        /// <para>of the array specifies all the parameters required to perform a single kernel launch.</para>
        /// <para>These kernels can cooperate and synchronize as they execute. The size of the array is</para>
        /// <para>specified by</para>
        /// <para>No two kernels can be launched on the same device. All the devices targeted by this</para>
        /// <para>multi-device launch must be identical. All devices must have a non-zero value for the</para>
        /// <para>device attribute ::cudaDevAttrCooperativeLaunch.</para>
        /// <para>The same kernel must be launched on all devices. Note that any __device__ or __constant__</para>
        /// <para>variables are independently instantiated on every device. It is the application's</para>
        /// <para>responsiblity to ensure these variables are initialized and used appropriately.</para>
        /// <para>The size of the grids as specified in blocks, the size of the blocks themselves and the</para>
        /// <para>amount of shared memory used by each thread block must also match across all launched kernels.</para>
        /// <para>The streams used to launch these kernels must have been created via either ::cudaStreamCreate</para>
        /// <para>or ::cudaStreamCreateWithPriority or ::cudaStreamCreateWithPriority. The NULL stream or</para>
        /// <para>::cudaStreamLegacy or ::cudaStreamPerThread cannot be used.</para>
        /// <para>The total number of blocks launched per kernel cannot exceed the maximum number of blocks</para>
        /// <para>per multiprocessor as returned by ::cudaOccupancyMaxActiveBlocksPerMultiprocessor (or</para>
        /// <para>::cudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags) times the number of multiprocessors</para>
        /// <para>as specified by the device attribute ::cudaDevAttrMultiProcessorCount. Since the</para>
        /// <para>total number of blocks launched per device has to match across all devices, the maximum</para>
        /// <para>number of blocks that can be launched per device will be limited by the device with the</para>
        /// <para>least number of multiprocessors.</para>
        /// <para>The kernel cannot make use of CUDA dynamic parallelism.</para>
        /// <para>The ::cudaLaunchParams structure is defined as:</para>
        /// <para>where:</para>
        /// <para>- ::cudaLaunchParams::func specifies the kernel to be launched. This same functions must</para>
        /// <para>be launched on all devices. For templated functions, pass the function symbol as follows:</para>
        /// <para>func_name_arg_0,...,template_arg_N&gt;</para>
        /// <para>- ::cudaLaunchParams::gridDim specifies the width, height and depth of the grid in blocks.</para>
        /// <para>This must match across all kernels launched.</para>
        /// <para>- ::cudaLaunchParams::blockDim is the width, height and depth of each thread block. This</para>
        /// <para>must match across all kernels launched.</para>
        /// <para>- ::cudaLaunchParams::args specifies the arguments to the kernel. If the kernel has</para>
        /// <para>N parameters then ::cudaLaunchParams::args should point to array of N pointers. Each</para>
        /// <para>pointer, from::cudaLaunchParams::args[0]to::cudaLaunchParams::args[N - 1],</para>
        /// <para>point to the region of memory from which the actual parameter will be copied.</para>
        /// <para>- ::cudaLaunchParams::sharedMem is the dynamic shared-memory size per thread block in bytes.</para>
        /// <para>This must match across all kernels launched.</para>
        /// <para>- ::cudaLaunchParams::stream is the handle to the stream to perform the launch in. This cannot</para>
        /// <para>be the NULL stream or ::cudaStreamLegacy or ::cudaStreamPerThread.</para>
        /// <para>By default, the kernel won't begin execution on any GPU until all prior work in all the specified</para>
        /// <para>streams has completed. This behavior can be overridden by specifying the flag</para>
        /// <para>::cudaCooperativeLaunchMultiDeviceNoPreSync. When this flag is specified, each kernel</para>
        /// <para>will only wait for prior work in the stream corresponding to that GPU to complete before it begins</para>
        /// <para>execution.</para>
        /// <para>Similarly, by default, any subsequent work pushed in any of the specified streams will not begin</para>
        /// <para>execution until the kernels on all GPUs have completed. This behavior can be overridden by specifying</para>
        /// <para>the flag ::cudaCooperativeLaunchMultiDeviceNoPostSync. When this flag is specified,</para>
        /// <para>any subsequent work pushed in any of the specified streams will only wait for the kernel launched</para>
        /// <para>on the GPU corresponding to that stream to complete before it begins execution.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaLaunchCooperativeKernel,</para>
        /// <para>::cuLaunchCooperativeKernelMultiDevice</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaLaunchCooperativeKernelMultiDevice(global::CUDA.CudaLaunchParams launchParamsList, uint numDevices, uint flags)
        {
            var __arg0 = ReferenceEquals(launchParamsList, null) ? global::System.IntPtr.Zero : launchParamsList.__Instance;
            var __ret = __Internal.CudaLaunchCooperativeKernelMultiDevice(__arg0, numDevices, flags);
            return __ret;
        }

        /// <summary>Sets the preferred cache configuration for a device function</summary>
        /// <param name="func">- Device function symbol</param>
        /// <param name="cacheConfig">- Requested cache configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidDeviceFunction</para>
        /// </returns>
        /// <remarks>
        /// <para>On devices where the L1 cache and shared memory use the same hardware</para>
        /// <para>resources, this sets throughthe preferred cache configuration</para>
        /// <para>for the function specified viaThis is only a preference. The</para>
        /// <para>runtime will use the requested configuration if possible, but it is free to</para>
        /// <para>choose a different configuration if required to execute</para>
        /// <para>is a device function symbol and must be declared as a</para>
        /// <para>function. If the specified function does not exist,</para>
        /// <para>then ::cudaErrorInvalidDeviceFunction is returned. For templated functions,</para>
        /// <para>pass the function symbol as follows: func_name_arg_0,...,template_arg_N&gt;</para>
        /// <para>This setting does nothing on devices where the size of the L1 cache and</para>
        /// <para>shared memory are fixed.</para>
        /// <para>Launching a kernel with a different preference than the most recent</para>
        /// <para>preference setting may insert a device-side synchronization point.</para>
        /// <para>The supported cache configurations are:</para>
        /// <para>- ::cudaFuncCachePreferNone: no preference for shared memory or L1 (default)</para>
        /// <para>- ::cudaFuncCachePreferShared: prefer larger shared memory and smaller L1 cache</para>
        /// <para>- ::cudaFuncCachePreferL1: prefer larger L1 cache and smaller shared memory</para>
        /// <para>- ::cudaFuncCachePreferEqual: prefer equal size L1 cache and shared memory</para>
        /// <para>_string_api_deprecation2</para>
        /// <para>::cudaConfigureCall,</para>
        /// <para>::cudaSetDoubleForDevice,</para>
        /// <para>::cudaSetDoubleForHost,</para>
        /// <para>::cudaThreadGetCacheConfig,</para>
        /// <para>::cudaThreadSetCacheConfig,</para>
        /// <para>::cuFuncSetCacheConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFuncSetCacheConfig(global::System.IntPtr func, global::CUDA.CudaFuncCache cacheConfig)
        {
            var __ret = __Internal.CudaFuncSetCacheConfig(func, cacheConfig);
            return __ret;
        }

        /// <summary>Sets the shared memory configuration for a device function</summary>
        /// <param name="func">- Device function symbol</param>
        /// <param name="config">- Requested shared memory configuration</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// </returns>
        /// <remarks>
        /// <para>On devices with configurable shared memory banks, this function will</para>
        /// <para>force all subsequent launches of the specified device function to have</para>
        /// <para>the given shared memory bank size configuration. On any given launch of the</para>
        /// <para>function, the shared memory configuration of the device will be temporarily</para>
        /// <para>changed if needed to suit the function's preferred configuration. Changes in</para>
        /// <para>shared memory configuration between subsequent launches of functions,</para>
        /// <para>may introduce a device side synchronization point.</para>
        /// <para>Any per-function setting of shared memory bank size set via</para>
        /// <para>::cudaFuncSetSharedMemConfig will override the device wide setting set by</para>
        /// <para>::cudaDeviceSetSharedMemConfig.</para>
        /// <para>Changing the shared memory bank size will not increase shared memory usage</para>
        /// <para>or affect occupancy of kernels, but may have major effects on performance.</para>
        /// <para>Larger bank sizes will allow for greater potential bandwidth to shared memory,</para>
        /// <para>but will change what kinds of accesses to shared memory will result in bank</para>
        /// <para>conflicts.</para>
        /// <para>This function will do nothing on devices with fixed shared memory bank size.</para>
        /// <para>For templated functions, pass the function symbol as follows:</para>
        /// <para>func_name_arg_0,...,template_arg_N&gt;</para>
        /// <para>The supported bank configurations are:</para>
        /// <para>- ::cudaSharedMemBankSizeDefault: use the device's shared memory configuration</para>
        /// <para>when launching this function.</para>
        /// <para>- ::cudaSharedMemBankSizeFourByte: set shared memory bank width to be</para>
        /// <para>four bytes natively when launching this function.</para>
        /// <para>- ::cudaSharedMemBankSizeEightByte: set shared memory bank width to be eight</para>
        /// <para>bytes natively when launching this function.</para>
        /// <para>_string_api_deprecation2</para>
        /// <para>::cudaConfigureCall,</para>
        /// <para>::cudaDeviceSetSharedMemConfig,</para>
        /// <para>::cudaDeviceGetSharedMemConfig,</para>
        /// <para>::cudaDeviceSetCacheConfig,</para>
        /// <para>::cudaDeviceGetCacheConfig,</para>
        /// <para>::cudaFuncSetCacheConfig,</para>
        /// <para>::cuFuncSetSharedMemConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFuncSetSharedMemConfig(global::System.IntPtr func, global::CUDA.CudaSharedMemConfig config)
        {
            var __ret = __Internal.CudaFuncSetSharedMemConfig(func, config);
            return __ret;
        }

        /// <summary>Find out attributes for a given function</summary>
        /// <param name="attr">- Return pointer to function's attributes</param>
        /// <param name="func">- Device function symbol</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidDeviceFunction</para>
        /// </returns>
        /// <remarks>
        /// <para>This function obtains the attributes of a function specified viais a device function symbol and must be declared as a</para>
        /// <para>function. The fetched attributes are placed inIf the specified function does not exist, then</para>
        /// <para>::cudaErrorInvalidDeviceFunction is returned. For templated functions, pass</para>
        /// <para>the function symbol as follows: func_name_arg_0,...,template_arg_N&gt;</para>
        /// <para>Note that some function attributes such as</para>
        /// <para>may vary based on the device that is currently being used.</para>
        /// <para>_string_api_deprecation2</para>
        /// <para>::cudaConfigureCall,</para>
        /// <para>::cudaSetDoubleForDevice,</para>
        /// <para>::cudaSetDoubleForHost,</para>
        /// <para>::cuFuncGetAttribute</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFuncGetAttributes(global::CUDA.CudaFuncAttributes attr, global::System.IntPtr func)
        {
            var __arg0 = ReferenceEquals(attr, null) ? global::System.IntPtr.Zero : attr.__Instance;
            var __ret = __Internal.CudaFuncGetAttributes(__arg0, func);
            return __ret;
        }

        /// <summary>Set attributes for a given function</summary>
        /// <param name="entry">- Function to get attributes of</param>
        /// <param name="attr">- Attribute to set</param>
        /// <param name="value">- Value to set</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// <para>::cudaSetDoubleForDevice,</para>
        /// <para>::cudaSetDoubleForHost,</para>
        /// </returns>
        /// <remarks>
        /// <para>This function sets the attributes of a function specified viaThe parametermust be a pointer to a function that executes</para>
        /// <para>on the device. The parameter specified bymust be declared as afunction. The enumeration defined byis set to the value defined byIf the specified function does not exist, then ::cudaErrorInvalidDeviceFunction is returned.</para>
        /// <para>If the specified attribute cannot be written, or if the value is incorrect,</para>
        /// <para>then ::cudaErrorInvalidValue is returned.</para>
        /// <para>Valid values forare:</para>
        /// <para>::cuFuncAttrMaxDynamicSharedMem - Maximum size of dynamic shared memory per block</para>
        /// <para>::cudaFuncAttributePreferredSharedMemoryCarveout - Preferred shared memory-L1 cache split ratio</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFuncSetAttribute(global::System.IntPtr func, global::CUDA.CudaFuncAttribute attr, int value)
        {
            var __ret = __Internal.CudaFuncSetAttribute(func, attr, value);
            return __ret;
        }

        /// <summary>Converts a double argument to be executed on a device</summary>
        /// <param name="d">- Double to convert</param>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>This function is deprecated as of CUDA 7.5</para>
        /// <para>Converts the double value ofto an internal float representation if</para>
        /// <para>the device does not support double arithmetic. If the device does natively</para>
        /// <para>support doubles, then this function does nothing.</para>
        /// <para>::cudaSetDoubleForHost,</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaSetDoubleForDevice(ref double d)
        {
            fixed (double* __refParamPtr0 = &d)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaSetDoubleForDevice(__arg0);
                return __ret;
            }
        }

        /// <summary>Converts a double argument after execution on a device</summary>
        /// <param name="d">- Double to convert</param>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>This function is deprecated as of CUDA 7.5</para>
        /// <para>Converts the double value offrom a potentially internal float</para>
        /// <para>representation if the device does not support double arithmetic. If the</para>
        /// <para>device does natively support doubles, then this function does nothing.</para>
        /// <para>::cudaSetDoubleForDevice,</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaSetDoubleForHost(ref double d)
        {
            fixed (double* __refParamPtr0 = &d)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaSetDoubleForHost(__arg0);
                return __ret;
            }
        }

        /// <summary>Returns occupancy for a device function</summary>
        /// <param name="numBlocks">- Returned occupancy</param>
        /// <param name="func">- Kernel function for which occupancy is calculated</param>
        /// <param name="blockSize">- Block size the kernel is intended to be launched with</param>
        /// <param name="dynamicSMemSize">- Per-block dynamic shared memory usage intended, in bytes</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorCudartUnloading,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorUnknown,</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe maximum number of active blocks per</para>
        /// <para>streaming multiprocessor for the device function.</para>
        /// <para>::cudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags,</para>
        /// <para>::cuOccupancyMaxActiveBlocksPerMultiprocessor</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaOccupancyMaxActiveBlocksPerMultiprocessor(ref int numBlocks, global::System.IntPtr func, int blockSize, ulong dynamicSMemSize)
        {
            fixed (int* __refParamPtr0 = &numBlocks)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaOccupancyMaxActiveBlocksPerMultiprocessor(__arg0, func, blockSize, dynamicSMemSize);
                return __ret;
            }
        }

        /// <summary>Returns occupancy for a device function with the specified flags</summary>
        /// <param name="numBlocks">- Returned occupancy</param>
        /// <param name="func">- Kernel function for which occupancy is calculated</param>
        /// <param name="blockSize">- Block size the kernel is intended to be launched with</param>
        /// <param name="dynamicSMemSize">- Per-block dynamic shared memory usage intended, in bytes</param>
        /// <param name="flags">- Requested behavior for the occupancy calculator</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorCudartUnloading,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorUnknown,</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe maximum number of active blocks per</para>
        /// <para>streaming multiprocessor for the device function.</para>
        /// <para>Theparameter controls how special cases are handled. Valid flags include:</para>
        /// <para>- ::cudaOccupancyDefault: keeps the default behavior as</para>
        /// <para>::cudaOccupancyMaxActiveBlocksPerMultiprocessor</para>
        /// <para>- ::cudaOccupancyDisableCachingOverride: This flag suppresses the default behavior</para>
        /// <para>on platform where global caching affects occupancy. On such platforms, if caching</para>
        /// <para>is enabled, but per-block SM resource usage would result in zero occupancy, the</para>
        /// <para>occupancy calculator will calculate the occupancy as if caching is disabled.</para>
        /// <para>Setting this flag makes the occupancy calculator to return 0 in such cases.</para>
        /// <para>More information can be found about this feature in the &quot;Unified L1/Texture Cache&quot;</para>
        /// <para>section of the Maxwell tuning guide.</para>
        /// <para>::cudaOccupancyMaxActiveBlocksPerMultiprocessor,</para>
        /// <para>::cuOccupancyMaxActiveBlocksPerMultiprocessorWithFlags</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags(ref int numBlocks, global::System.IntPtr func, int blockSize, ulong dynamicSMemSize, uint flags)
        {
            fixed (int* __refParamPtr0 = &numBlocks)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaOccupancyMaxActiveBlocksPerMultiprocessorWithFlags(__arg0, func, blockSize, dynamicSMemSize, flags);
                return __ret;
            }
        }

        /// <summary>Configure a device-launch</summary>
        /// <param name="gridDim">- Grid dimensions</param>
        /// <param name="blockDim">- Block dimensions</param>
        /// <param name="sharedMem">- Shared memory</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidConfiguration</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is deprecated as of CUDA 7.0</para>
        /// <para>Specifies the grid and block dimensions for the device call to be executed</para>
        /// <para>similar to the execution configuration syntax. ::cudaConfigureCall() is</para>
        /// <para>stack based. Each call pushes data on top of an execution stack. This data</para>
        /// <para>contains the dimension for the grid and thread blocks, together with any</para>
        /// <para>arguments for the call.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaSetDoubleForDevice,</para>
        /// <para>::cudaSetDoubleForHost,</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaConfigureCall(global::CUDA.Dim3 gridDim, global::CUDA.Dim3 blockDim, ulong sharedMem, global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(gridDim, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)gridDim.__Instance;
            var __arg1 = ReferenceEquals(blockDim, null) ? new global::CUDA.Dim3.__Internal() : *(global::CUDA.Dim3.__Internal*)blockDim.__Instance;
            var __arg3 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaConfigureCall(__arg0, __arg1, sharedMem, __arg3);
            return __ret;
        }

        /// <summary>Configure a device launch</summary>
        /// <param name="arg">- Argument to push for a kernel launch</param>
        /// <param name="size">- Size of argument</param>
        /// <param name="offset">- Offset in argument stack to push new arg</param>
        /// <returns>
        /// <para>::cudaSuccess</para>
        /// <para>::cudaSetDoubleForDevice,</para>
        /// <para>::cudaSetDoubleForHost,</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is deprecated as of CUDA 7.0</para>
        /// <para>Pushesbytes of the argument pointed to byatbytes from the start of the parameter passing area, which starts at</para>
        /// <para>offset 0. The arguments are stored in the top of the execution stack.</para>
        /// <para>must be preceded by a call to ::cudaConfigureCall().</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaSetupArgument(global::System.IntPtr arg, ulong size, ulong offset)
        {
            var __ret = __Internal.CudaSetupArgument(arg, size, offset);
            return __ret;
        }

        /// <summary>Launches a device function</summary>
        /// <param name="func">- Device function symbol</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDeviceFunction,</para>
        /// <para>::cudaErrorInvalidConfiguration,</para>
        /// <para>::cudaErrorLaunchFailure,</para>
        /// <para>::cudaErrorLaunchTimeout,</para>
        /// <para>::cudaErrorLaunchOutOfResources,</para>
        /// <para>::cudaErrorSharedObjectInitFailed,</para>
        /// <para>::cudaErrorInvalidPtx,</para>
        /// <para>::cudaErrorNoKernelImageForDevice,</para>
        /// <para>::cudaErrorJitCompilerNotFound</para>
        /// </returns>
        /// <remarks>
        /// <para>This function is deprecated as of CUDA 7.0</para>
        /// <para>Launches the functionon the device. The parametermust</para>
        /// <para>be a device function symbol. The parameter specified bymust be</para>
        /// <para>declared as afunction. For templated functions, pass the</para>
        /// <para>function symbol as follows: func_name_arg_0,...,template_arg_N&gt;</para>
        /// <para>::cudaConfigureCall() since it pops the data that was pushed by</para>
        /// <para>::cudaConfigureCall() from the execution stack.</para>
        /// <para>_string_api_deprecation_50</para>
        /// <para>::cudaSetDoubleForDevice,</para>
        /// <para>::cudaSetDoubleForHost,</para>
        /// <para>::cudaThreadGetCacheConfig,</para>
        /// <para>::cudaThreadSetCacheConfig</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaLaunch(global::System.IntPtr func)
        {
            var __ret = __Internal.CudaLaunch(func);
            return __ret;
        }

        /// <summary>Allocates memory that will be automatically managed by the Unified Memory system</summary>
        /// <param name="devPtr">- Pointer to allocated device memory</param>
        /// <param name="size">- Requested allocation size in bytes</param>
        /// <param name="flags">- Must be either ::cudaMemAttachGlobal or ::cudaMemAttachHost (defaults to ::cudaMemAttachGlobal)</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorMemoryAllocation,</para>
        /// <para>::cudaErrorNotSupported,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocatesbytes of managed memory on the device and returns in</para>
        /// <para>a pointer to the allocated memory. If the device doesn't support</para>
        /// <para>allocating managed memory, ::cudaErrorNotSupported is returned. Support</para>
        /// <para>for managed memory can be queried using the device attribute</para>
        /// <para>::cudaDevAttrManagedMemory. The allocated memory is suitably</para>
        /// <para>aligned for any kind of variable. The memory is not cleared. Ifis 0, ::cudaMallocManaged returns ::cudaErrorInvalidValue. The pointer</para>
        /// <para>is valid on the CPU and on all GPUs in the system that support managed memory.</para>
        /// <para>All accesses to this pointer must obey the Unified Memory programming model.</para>
        /// <para>specifies the default stream association for this allocation.</para>
        /// <para>must be one of ::cudaMemAttachGlobal or ::cudaMemAttachHost. The</para>
        /// <para>default value foris ::cudaMemAttachGlobal.</para>
        /// <para>If ::cudaMemAttachGlobal is specified, then this memory is accessible from</para>
        /// <para>any stream on any device. If ::cudaMemAttachHost is specified, then the</para>
        /// <para>allocation should not be accessed from devices that have a zero value for the</para>
        /// <para>device attribute ::cudaDevAttrConcurrentManagedAccess; an explicit call to</para>
        /// <para>::cudaStreamAttachMemAsync will be required to enable access on such devices.</para>
        /// <para>If the association is later changed via ::cudaStreamAttachMemAsync to</para>
        /// <para>a single stream, the default association, as specifed during ::cudaMallocManaged,</para>
        /// <para>is restored when that stream is destroyed. For __managed__ variables, the</para>
        /// <para>default association is always ::cudaMemAttachGlobal. Note that destroying a</para>
        /// <para>stream is an asynchronous operation, and as a result, the change to default</para>
        /// <para>association won't happen until all work in the stream has completed.</para>
        /// <para>Memory allocated with ::cudaMallocManaged should be released with ::cudaFree.</para>
        /// <para>Device memory oversubscription is possible for GPUs that have a non-zero value for the</para>
        /// <para>device attribute ::cudaDevAttrConcurrentManagedAccess. Managed memory on</para>
        /// <para>such GPUs may be evicted from device memory to host memory at any time by the Unified</para>
        /// <para>Memory driver in order to make room for other allocations.</para>
        /// <para>In a multi-GPU system where all GPUs have a non-zero value for the device attribute</para>
        /// <para>::cudaDevAttrConcurrentManagedAccess, managed memory may not be populated when this</para>
        /// <para>API returns and instead may be populated on access. In such systems, managed memory can</para>
        /// <para>migrate to any processor's memory at any time. The Unified Memory driver will employ heuristics to</para>
        /// <para>maintain data locality and prevent excessive page faults to the extent possible. The application</para>
        /// <para>can also guide the driver about memory usage patterns via ::cudaMemAdvise. The application</para>
        /// <para>can also explicitly migrate memory to a desired processor's memory via</para>
        /// <para>::cudaMemPrefetchAsync.</para>
        /// <para>In a multi-GPU system where all of the GPUs have a zero value for the device attribute</para>
        /// <para>::cudaDevAttrConcurrentManagedAccess and all the GPUs have peer-to-peer support</para>
        /// <para>with each other, the physical storage for managed memory is created on the GPU which is active</para>
        /// <para>at the time ::cudaMallocManaged is called. All other GPUs will reference the data at reduced</para>
        /// <para>bandwidth via peer mappings over the PCIe bus. The Unified Memory driver does not migrate</para>
        /// <para>memory among such GPUs.</para>
        /// <para>In a multi-GPU system where not all GPUs have peer-to-peer support with each other and</para>
        /// <para>where the value of the device attribute ::cudaDevAttrConcurrentManagedAccess</para>
        /// <para>is zero for at least one of those GPUs, the location chosen for physical storage of managed</para>
        /// <para>memory is system-dependent.</para>
        /// <para>- On Linux, the location chosen will be device memory as long as the current set of active</para>
        /// <para>contexts are on devices that either have peer-to-peer support with each other or have a</para>
        /// <para>non-zero value for the device attribute ::cudaDevAttrConcurrentManagedAccess.</para>
        /// <para>If there is an active context on a GPU that does not have a non-zero value for that device</para>
        /// <para>attribute and it does not have peer-to-peer support with the other devices that have active</para>
        /// <para>contexts on them, then the location for physical storage will be 'zero-copy' or host memory.</para>
        /// <para>Note that this means that managed memory that is located in device memory is migrated to</para>
        /// <para>host memory if a new context is created on a GPU that doesn't have a non-zero value for</para>
        /// <para>the device attribute and does not support peer-to-peer with at least one of the other devices</para>
        /// <para>that has an active context. This in turn implies that context creation may fail if there is</para>
        /// <para>insufficient host memory to migrate all managed allocations.</para>
        /// <para>- On Windows, the physical storage is always created in 'zero-copy' or host memory.</para>
        /// <para>All GPUs will reference the data at reduced bandwidth over the PCIe bus. In these</para>
        /// <para>circumstances, use of the environment variable CUDA_VISIBLE_DEVICES is recommended to</para>
        /// <para>restrict CUDA to only use those GPUs that have peer-to-peer support.</para>
        /// <para>Alternatively, users can also set CUDA_MANAGED_FORCE_DEVICE_ALLOC to a non-zero</para>
        /// <para>value to force the driver to always use device memory for physical storage.</para>
        /// <para>When this environment variable is set to a non-zero value, all devices used in</para>
        /// <para>that process that support managed memory have to be peer-to-peer compatible</para>
        /// <para>with each other. The error ::cudaErrorInvalidDevice will be returned if a device</para>
        /// <para>that supports managed memory is used and it is not peer-to-peer compatible with</para>
        /// <para>any of the other managed memory supporting devices that were previously used in</para>
        /// <para>that process, even if ::cudaDeviceReset has been called on those devices. These</para>
        /// <para>environment variables are described in the CUDA programming guide under the</para>
        /// <para>&quot;CUDA environment variables&quot; section.</para>
        /// <para>::cudaMallocPitch, ::cudaFree, ::cudaMallocArray, ::cudaFreeArray,</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc3DArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc, ::cudaDeviceGetAttribute, ::cudaStreamAttachMemAsync,</para>
        /// <para>::cuMemAllocManaged</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMallocManaged(void** devPtr, ulong size, uint flags)
        {
            var __ret = __Internal.CudaMallocManaged(devPtr, size, flags);
            return __ret;
        }

        /// <summary>Allocate memory on the device</summary>
        /// <param name="devPtr">- Pointer to allocated device memory</param>
        /// <param name="size">- Requested allocation size in bytes</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocatesbytes of linear memory on the device and returns in</para>
        /// <para>a pointer to the allocated memory. The allocated memory is</para>
        /// <para>suitably aligned for any kind of variable. The memory is not cleared.</para>
        /// <para>::cudaMalloc() returns ::cudaErrorMemoryAllocation in case of failure.</para>
        /// <para>The device version of ::cudaFree cannot be used with aallocated using the host API, and vice versa.</para>
        /// <para>::cudaMallocPitch, ::cudaFree, ::cudaMallocArray, ::cudaFreeArray,</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc3DArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc,</para>
        /// <para>::cuMemAlloc</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMalloc(void** devPtr, ulong size)
        {
            var __ret = __Internal.CudaMalloc(devPtr, size);
            return __ret;
        }

        /// <summary>Allocates page-locked memory on the host</summary>
        /// <param name="ptr">- Pointer to allocated host memory</param>
        /// <param name="size">- Requested allocation size in bytes</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocatesbytes of host memory that is page-locked and accessible</para>
        /// <para>to the device. The driver tracks the virtual memory ranges allocated with</para>
        /// <para>this function and automatically accelerates calls to functions such as</para>
        /// <para>::cudaMemcpy*(). Since the memory can be accessed directly by the device,</para>
        /// <para>it can be read or written with much higher bandwidth than pageable memory</para>
        /// <para>obtained with functions such as ::malloc(). Allocating excessive amounts of</para>
        /// <para>memory with ::cudaMallocHost() may degrade system performance, since it</para>
        /// <para>reduces the amount of memory available to the system for paging. As a</para>
        /// <para>result, this function is best used sparingly to allocate staging areas for</para>
        /// <para>data exchange between host and device.</para>
        /// <para>::cudaMalloc, ::cudaMallocPitch, ::cudaMallocArray, ::cudaMalloc3D,</para>
        /// <para>::cudaMalloc3DArray, ::cudaHostAlloc, ::cudaFree, ::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc,</para>
        /// <para>::cuMemAllocHost</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMallocHost(void** ptr, ulong size)
        {
            var __ret = __Internal.CudaMallocHost(ptr, size);
            return __ret;
        }

        /// <summary>Allocates pitched memory on the device</summary>
        /// <param name="devPtr">- Pointer to allocated pitched device memory</param>
        /// <param name="pitch">- Pitch for allocation</param>
        /// <param name="width">- Requested pitched allocation width (in bytes)</param>
        /// <param name="height">- Requested pitched allocation height</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocates at least(in bytes) *bytes of linear memory</para>
        /// <para>on the device and returns ina pointer to the allocated memory.</para>
        /// <para>The function may pad the allocation to ensure that corresponding pointers</para>
        /// <para>in any given row will continue to meet the alignment requirements for</para>
        /// <para>coalescing as the address is updated from row to row. The pitch returned in</para>
        /// <para>by ::cudaMallocPitch() is the width in bytes of the allocation.</para>
        /// <para>The intended usage ofis as a separate parameter of the allocation,</para>
        /// <para>used to compute addresses within the 2D array. Given the row and column of</para>
        /// <para>an array element of typethe address is computed as:</para>
        /// <para>For allocations of 2D arrays, it is recommended that programmers consider</para>
        /// <para>performing pitch allocations using ::cudaMallocPitch(). Due to pitch</para>
        /// <para>alignment restrictions in the hardware, this is especially true if the</para>
        /// <para>application will be performing 2D memory copies between different regions</para>
        /// <para>of device memory (whether linear memory or CUDA arrays).</para>
        /// <para>::cudaMalloc, ::cudaFree, ::cudaMallocArray, ::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaMalloc3D, ::cudaMalloc3DArray,</para>
        /// <para>::cudaHostAlloc,</para>
        /// <para>::cuMemAllocPitch</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMallocPitch(void** devPtr, ref ulong pitch, ulong width, ulong height)
        {
            fixed (ulong* __refParamPtr1 = &pitch)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.CudaMallocPitch(devPtr, __arg1, width, height);
                return __ret;
            }
        }

        /// <summary>Allocate an array on the device</summary>
        /// <param name="array">- Pointer to allocated array in device memory</param>
        /// <param name="desc">- Requested channel format</param>
        /// <param name="width">- Requested array allocation width</param>
        /// <param name="height">- Requested array allocation height</param>
        /// <param name="flags">- Requested properties of allocated array</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocates a CUDA array according to the ::cudaChannelFormatDesc structure</para>
        /// <para>and returns a handle to the new CUDA array in</para>
        /// <para>The ::cudaChannelFormatDesc is defined as:</para>
        /// <para>where ::cudaChannelFormatKind is one of ::cudaChannelFormatKindSigned,</para>
        /// <para>::cudaChannelFormatKindUnsigned, or ::cudaChannelFormatKindFloat.</para>
        /// <para>Theparameter enables different options to be specified that affect</para>
        /// <para>the allocation, as follows.</para>
        /// <para>- ::cudaArrayDefault: This flag's value is defined to be 0 and provides default array allocation</para>
        /// <para>- ::cudaArraySurfaceLoadStore: Allocates an array that can be read from or written to using a surface reference</para>
        /// <para>- ::cudaArrayTextureGather: This flag indicates that texture gather operations will be performed on the array.</para>
        /// <para>andmust meet certain size requirements. See ::cudaMalloc3DArray() for more details.</para>
        /// <para>::cudaMalloc, ::cudaMallocPitch, ::cudaFree, ::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaMalloc3D, ::cudaMalloc3DArray,</para>
        /// <para>::cudaHostAlloc,</para>
        /// <para>::cuArrayCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMallocArray(global::CUDA.CudaArray array, global::CUDA.CudaChannelFormatDesc desc, ulong width, ulong height, uint flags)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg1 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __ret = __Internal.CudaMallocArray(__arg0, __arg1, width, height, flags);
            return __ret;
        }

        /// <summary>Frees memory on the device</summary>
        /// <param name="devPtr">- Device pointer to memory to free</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevicePointer,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>Frees the memory space pointed to bywhich must have been</para>
        /// <para>returned by a previous call to ::cudaMalloc() or ::cudaMallocPitch().</para>
        /// <para>Otherwise, or if ::cudaFree(has already been called before,</para>
        /// <para>an error is returned. Ifis 0, no operation is performed.</para>
        /// <para>::cudaFree() returns ::cudaErrorInvalidDevicePointer in case of failure.</para>
        /// <para>The device version of ::cudaFree cannot be used with aallocated using the host API, and vice versa.</para>
        /// <para>::cudaMalloc, ::cudaMallocPitch, ::cudaMallocArray, ::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaMalloc3D, ::cudaMalloc3DArray,</para>
        /// <para>::cudaHostAlloc,</para>
        /// <para>::cuMemFree</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFree(global::System.IntPtr devPtr)
        {
            var __ret = __Internal.CudaFree(devPtr);
            return __ret;
        }

        /// <summary>Frees page-locked memory</summary>
        /// <param name="ptr">- Pointer to memory to free</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>Frees the memory space pointed to bywhich must have been</para>
        /// <para>returned by a previous call to ::cudaMallocHost() or ::cudaHostAlloc().</para>
        /// <para>::cudaMalloc, ::cudaMallocPitch, ::cudaFree, ::cudaMallocArray,</para>
        /// <para>::cudaFreeArray,</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc3DArray, ::cudaHostAlloc,</para>
        /// <para>::cuMemFreeHost</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFreeHost(global::System.IntPtr ptr)
        {
            var __ret = __Internal.CudaFreeHost(ptr);
            return __ret;
        }

        /// <summary>Frees an array on the device</summary>
        /// <param name="array">- Pointer to array to free</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>Frees the CUDA arraywhich must have been * returned by a</para>
        /// <para>previous call to ::cudaMallocArray(). If ::cudaFreeArray(has</para>
        /// <para>already been called before, ::cudaErrorInvalidValue is returned. If</para>
        /// <para>is 0, no operation is performed.</para>
        /// <para>::cudaMalloc, ::cudaMallocPitch, ::cudaFree, ::cudaMallocArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc,</para>
        /// <para>::cuArrayDestroy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFreeArray(global::CUDA.CudaArray array)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.CudaFreeArray(__arg0);
            return __ret;
        }

        /// <summary>Frees a mipmapped array on the device</summary>
        /// <param name="mipmappedArray">- Pointer to mipmapped array to free</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInitializationError</para>
        /// </returns>
        /// <remarks>
        /// <para>Frees the CUDA mipmapped arraywhich must have been</para>
        /// <para>returned by a previous call to ::cudaMallocMipmappedArray().</para>
        /// <para>If ::cudaFreeMipmappedArray(has already been called before,</para>
        /// <para>::cudaErrorInvalidValue is returned.</para>
        /// <para>::cudaMalloc, ::cudaMallocPitch, ::cudaFree, ::cudaMallocArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc,</para>
        /// <para>::cuMipmappedArrayDestroy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaFreeMipmappedArray(global::CUDA.CudaMipmappedArray mipmappedArray)
        {
            var __arg0 = ReferenceEquals(mipmappedArray, null) ? global::System.IntPtr.Zero : mipmappedArray.__Instance;
            var __ret = __Internal.CudaFreeMipmappedArray(__arg0);
            return __ret;
        }

        /// <summary>Allocates page-locked memory on the host</summary>
        /// <param name="pHost">- Device pointer to allocated memory</param>
        /// <param name="size">- Requested allocation size in bytes</param>
        /// <param name="flags">- Requested properties of allocated memory</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocatesbytes of host memory that is page-locked and accessible</para>
        /// <para>to the device. The driver tracks the virtual memory ranges allocated with</para>
        /// <para>this function and automatically accelerates calls to functions such as</para>
        /// <para>::cudaMemcpy(). Since the memory can be accessed directly by the device, it</para>
        /// <para>can be read or written with much higher bandwidth than pageable memory</para>
        /// <para>obtained with functions such as ::malloc(). Allocating excessive amounts of</para>
        /// <para>pinned memory may degrade system performance, since it reduces the amount</para>
        /// <para>of memory available to the system for paging. As a result, this function is</para>
        /// <para>best used sparingly to allocate staging areas for data exchange between host</para>
        /// <para>and device.</para>
        /// <para>Theparameter enables different options to be specified that affect</para>
        /// <para>the allocation, as follows.</para>
        /// <para>- ::cudaHostAllocDefault: This flag's value is defined to be 0 and causes</para>
        /// <para>::cudaHostAlloc() to emulate ::cudaMallocHost().</para>
        /// <para>- ::cudaHostAllocPortable: The memory returned by this call will be</para>
        /// <para>considered as pinned memory by all CUDA contexts, not just the one that</para>
        /// <para>performed the allocation.</para>
        /// <para>- ::cudaHostAllocMapped: Maps the allocation into the CUDA address space.</para>
        /// <para>The device pointer to the memory may be obtained by calling</para>
        /// <para>::cudaHostGetDevicePointer().</para>
        /// <para>- ::cudaHostAllocWriteCombined: Allocates the memory as write-combined (WC).</para>
        /// <para>WC memory can be transferred across the PCI Express bus more quickly on some</para>
        /// <para>system configurations, but cannot be read efficiently by most CPUs.  WC</para>
        /// <para>memory is a good option for buffers that will be written by the CPU and read</para>
        /// <para>by the device via mapped pinned memory or host-&gt;device transfers.</para>
        /// <para>All of these flags are orthogonal to one another: a developer may allocate</para>
        /// <para>memory that is portable, mapped and/or write-combined with no restrictions.</para>
        /// <para>In order for the ::cudaHostAllocMapped flag to have any effect, the CUDA context</para>
        /// <para>must support the ::cudaDeviceMapHost flag, which can be checked via</para>
        /// <para>::cudaGetDeviceFlags(). The ::cudaDeviceMapHost flag is implicitly set for</para>
        /// <para>contexts created via the runtime API.</para>
        /// <para>The ::cudaHostAllocMapped flag may be specified on CUDA contexts for devices</para>
        /// <para>that do not support mapped pinned memory. The failure is deferred to</para>
        /// <para>::cudaHostGetDevicePointer() because the memory may be mapped into other</para>
        /// <para>CUDA contexts via the ::cudaHostAllocPortable flag.</para>
        /// <para>Memory allocated by this function must be freed with ::cudaFreeHost().</para>
        /// <para>::cudaSetDeviceFlags,</para>
        /// <para>::cudaFreeHost,</para>
        /// <para>::cudaGetDeviceFlags,</para>
        /// <para>::cuMemHostAlloc</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaHostAlloc(void** pHost, ulong size, uint flags)
        {
            var __ret = __Internal.CudaHostAlloc(pHost, size, flags);
            return __ret;
        }

        /// <summary>Registers an existing host memory range for use by CUDA</summary>
        /// <param name="ptr">- Host pointer to memory to page-lock</param>
        /// <param name="size">- Size in bytes of the address range to page-lock in bytes</param>
        /// <param name="flags">- Flags for allocation request</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation,</para>
        /// <para>::cudaErrorHostMemoryAlreadyRegistered,</para>
        /// <para>::cudaErrorNotSupported</para>
        /// </returns>
        /// <remarks>
        /// <para>Page-locks the memory range specified byandand maps it</para>
        /// <para>for the device(s) as specified byThis memory range also is added</para>
        /// <para>to the same tracking mechanism as ::cudaHostAlloc() to automatically accelerate</para>
        /// <para>calls to functions such as ::cudaMemcpy(). Since the memory can be accessed</para>
        /// <para>directly by the device, it can be read or written with much higher bandwidth</para>
        /// <para>than pageable memory that has not been registered.  Page-locking excessive</para>
        /// <para>amounts of memory may degrade system performance, since it reduces the amount</para>
        /// <para>of memory available to the system for paging. As a result, this function is</para>
        /// <para>best used sparingly to register staging areas for data exchange between</para>
        /// <para>host and device.</para>
        /// <para>::cudaHostRegister is not supported on non I/O coherent devices.</para>
        /// <para>Theparameter enables different options to be specified that</para>
        /// <para>affect the allocation, as follows.</para>
        /// <para>- ::cudaHostRegisterDefault: On a system with unified virtual addressing,</para>
        /// <para>the memory will be both mapped and portable.  On a system with no unified</para>
        /// <para>virtual addressing, the memory will be neither mapped nor portable.</para>
        /// <para>- ::cudaHostRegisterPortable: The memory returned by this call will be</para>
        /// <para>considered as pinned memory by all CUDA contexts, not just the one that</para>
        /// <para>performed the allocation.</para>
        /// <para>- ::cudaHostRegisterMapped: Maps the allocation into the CUDA address</para>
        /// <para>space. The device pointer to the memory may be obtained by calling</para>
        /// <para>::cudaHostGetDevicePointer().</para>
        /// <para>- ::cudaHostRegisterIoMemory: The passed memory pointer is treated as</para>
        /// <para>pointing to some memory-mapped I/O space, e.g. belonging to a</para>
        /// <para>third-party PCIe device, and it will marked as non cache-coherent and</para>
        /// <para>contiguous.</para>
        /// <para>All of these flags are orthogonal to one another: a developer may page-lock</para>
        /// <para>memory that is portable or mapped with no restrictions.</para>
        /// <para>The CUDA context must have been created with the ::cudaMapHost flag in</para>
        /// <para>order for the ::cudaHostRegisterMapped flag to have any effect.</para>
        /// <para>The ::cudaHostRegisterMapped flag may be specified on CUDA contexts for</para>
        /// <para>devices that do not support mapped pinned memory. The failure is deferred</para>
        /// <para>to ::cudaHostGetDevicePointer() because the memory may be mapped into</para>
        /// <para>other CUDA contexts via the ::cudaHostRegisterPortable flag.</para>
        /// <para>For devices that have a non-zero value for the device attribute</para>
        /// <para>::cudaDevAttrCanUseHostPointerForRegisteredMem, the memory</para>
        /// <para>can also be accessed from the device using the host pointerThe device pointer returned by ::cudaHostGetDevicePointer() may or may not</para>
        /// <para>match the original host pointerand depends on the devices visible to the</para>
        /// <para>application. If all devices visible to the application have a non-zero value for the</para>
        /// <para>device attribute, the device pointer returned by ::cudaHostGetDevicePointer()</para>
        /// <para>will match the original pointerIf any device visible to the application</para>
        /// <para>has a zero value for the device attribute, the device pointer returned by</para>
        /// <para>::cudaHostGetDevicePointer() will not match the original host pointerbut it will be suitable for use on all devices provided Unified Virtual Addressing</para>
        /// <para>is enabled. In such systems, it is valid to access the memory using either pointer</para>
        /// <para>on devices that have a non-zero value for the device attribute. Note however that</para>
        /// <para>such devices should access the memory using only of the two pointers and not both.</para>
        /// <para>The memory page-locked by this function must be unregistered with ::cudaHostUnregister().</para>
        /// <para>::cudaHostUnregister, ::cudaHostGetFlags, ::cudaHostGetDevicePointer,</para>
        /// <para>::cuMemHostRegister</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaHostRegister(global::System.IntPtr ptr, ulong size, uint flags)
        {
            var __ret = __Internal.CudaHostRegister(ptr, size, flags);
            return __ret;
        }

        /// <summary>Unregisters a memory range that was registered with cudaHostRegister</summary>
        /// <param name="ptr">- Host pointer to memory to unregister</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorHostMemoryNotRegistered</para>
        /// </returns>
        /// <remarks>
        /// <para>Unmaps the memory range whose base address is specified byand makes</para>
        /// <para>it pageable again.</para>
        /// <para>The base address must be the same one specified to ::cudaHostRegister().</para>
        /// <para>::cudaHostUnregister,</para>
        /// <para>::cuMemHostUnregister</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaHostUnregister(global::System.IntPtr ptr)
        {
            var __ret = __Internal.CudaHostUnregister(ptr);
            return __ret;
        }

        /// <summary>
        /// <para>Passes back device pointer of mapped host memory allocated by</para>
        /// <para>cudaHostAlloc or registered by cudaHostRegister</para>
        /// </summary>
        /// <param name="pDevice">- Returned device pointer for mapped memory</param>
        /// <param name="pHost">- Requested host pointer mapping</param>
        /// <param name="flags">- Flags for extensions (must be 0 for now)</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Passes back the device pointer corresponding to the mapped, pinned host</para>
        /// <para>buffer allocated by ::cudaHostAlloc() or registered by ::cudaHostRegister().</para>
        /// <para>::cudaHostGetDevicePointer() will fail if the ::cudaDeviceMapHost flag was</para>
        /// <para>not specified before deferred context creation occurred, or if called on a</para>
        /// <para>device that does not support mapped, pinned memory.</para>
        /// <para>For devices that have a non-zero value for the device attribute</para>
        /// <para>::cudaDevAttrCanUseHostPointerForRegisteredMem, the memory</para>
        /// <para>can also be accessed from the device using the host pointerThe device pointer returned by ::cudaHostGetDevicePointer() may or may not</para>
        /// <para>match the original host pointerand depends on the devices visible to the</para>
        /// <para>application. If all devices visible to the application have a non-zero value for the</para>
        /// <para>device attribute, the device pointer returned by ::cudaHostGetDevicePointer()</para>
        /// <para>will match the original pointerIf any device visible to the application</para>
        /// <para>has a zero value for the device attribute, the device pointer returned by</para>
        /// <para>::cudaHostGetDevicePointer() will not match the original host pointerbut it will be suitable for use on all devices provided Unified Virtual Addressing</para>
        /// <para>is enabled. In such systems, it is valid to access the memory using either pointer</para>
        /// <para>on devices that have a non-zero value for the device attribute. Note however that</para>
        /// <para>such devices should access the memory using only of the two pointers and not both.</para>
        /// <para>provides for future releases.  For now, it must be set to 0.</para>
        /// <para>::cudaSetDeviceFlags, ::cudaHostAlloc,</para>
        /// <para>::cuMemHostGetDevicePointer</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaHostGetDevicePointer(void** pDevice, global::System.IntPtr pHost, uint flags)
        {
            var __ret = __Internal.CudaHostGetDevicePointer(pDevice, pHost, flags);
            return __ret;
        }

        /// <summary>
        /// <para>Passes back flags used to allocate pinned host memory allocated by</para>
        /// <para>cudaHostAlloc</para>
        /// </summary>
        /// <param name="pFlags">- Returned flags word</param>
        /// <param name="pHost">- Host pointer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>::cudaHostGetFlags() will fail if the input pointer does not</para>
        /// <para>reside in an address range allocated by ::cudaHostAlloc().</para>
        /// <para>::cudaHostAlloc,</para>
        /// <para>::cuMemHostGetFlags</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaHostGetFlags(ref uint pFlags, global::System.IntPtr pHost)
        {
            fixed (uint* __refParamPtr0 = &pFlags)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaHostGetFlags(__arg0, pHost);
                return __ret;
            }
        }

        /// <summary>Allocates logical 1D, 2D, or 3D memory objects on the device</summary>
        /// <param name="pitchedDevPtr">- Pointer to allocated pitched device memory</param>
        /// <param name="extent">- Requested allocation size (field in bytes)</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocates at least**bytes of linear memory</para>
        /// <para>on the device and returns a ::cudaPitchedPtr in whichis a pointer</para>
        /// <para>to the allocated memory. The function may pad the allocation to ensure</para>
        /// <para>hardware alignment requirements are met. The pitch returned in thefield ofis the width in bytes of the allocation.</para>
        /// <para>The returned ::cudaPitchedPtr contains additional fieldsand</para>
        /// <para>the logical width and height of the allocation, which are</para>
        /// <para>equivalent to theandparameters provided by</para>
        /// <para>the programmer during allocation.</para>
        /// <para>For allocations of 2D and 3D objects, it is highly recommended that</para>
        /// <para>programmers perform allocations using ::cudaMalloc3D() or</para>
        /// <para>::cudaMallocPitch(). Due to alignment restrictions in the hardware, this is</para>
        /// <para>especially true if the application will be performing memory copies</para>
        /// <para>involving 2D or 3D objects (whether linear memory or CUDA arrays).</para>
        /// <para>::cudaMallocPitch, ::cudaFree, ::cudaMemcpy3D, ::cudaMemset3D,</para>
        /// <para>::cudaMalloc3DArray, ::cudaMallocArray, ::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc, ::make_cudaPitchedPtr, ::make_cudaExtent,</para>
        /// <para>::cuMemAllocPitch</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMalloc3D(global::CUDA.CudaPitchedPtr pitchedDevPtr, global::CUDA.CudaExtent extent)
        {
            var __arg0 = ReferenceEquals(pitchedDevPtr, null) ? global::System.IntPtr.Zero : pitchedDevPtr.__Instance;
            var __arg1 = ReferenceEquals(extent, null) ? new global::CUDA.CudaExtent.__Internal() : *(global::CUDA.CudaExtent.__Internal*)extent.__Instance;
            var __ret = __Internal.CudaMalloc3D(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Allocate an array on the device</summary>
        /// <param name="array">- Pointer to allocated array in device memory</param>
        /// <param name="desc">- Requested channel format</param>
        /// <param name="extent">- Requested allocation size (field in elements)</param>
        /// <param name="flags">- Flags for extensions</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocates a CUDA array according to the ::cudaChannelFormatDesc structure</para>
        /// <para>and returns a handle to the new CUDA array in</para>
        /// <para>The ::cudaChannelFormatDesc is defined as:</para>
        /// <para>where ::cudaChannelFormatKind is one of ::cudaChannelFormatKindSigned,</para>
        /// <para>::cudaChannelFormatKindUnsigned, or ::cudaChannelFormatKindFloat.</para>
        /// <para>::cudaMalloc3DArray() can allocate the following:</para>
        /// <para>- A 1D array is allocated if the height and depth extents are both zero.</para>
        /// <para>- A 2D array is allocated if only the depth extent is zero.</para>
        /// <para>- A 3D array is allocated if all three extents are non-zero.</para>
        /// <para>- A 1D layered CUDA array is allocated if only the height extent is zero and</para>
        /// <para>the cudaArrayLayered flag is set. Each layer is a 1D array. The number of layers is</para>
        /// <para>determined by the depth extent.</para>
        /// <para>- A 2D layered CUDA array is allocated if all three extents are non-zero and</para>
        /// <para>the cudaArrayLayered flag is set. Each layer is a 2D array. The number of layers is</para>
        /// <para>determined by the depth extent.</para>
        /// <para>- A cubemap CUDA array is allocated if all three extents are non-zero and the</para>
        /// <para>cudaArrayCubemap flag is set. Width must be equal to height, and depth must be six. A cubemap is</para>
        /// <para>a special type of 2D layered CUDA array, where the six layers represent the six faces of a cube.</para>
        /// <para>The order of the six layers in memory is the same as that listed in ::cudaGraphicsCubeFace.</para>
        /// <para>- A cubemap layered CUDA array is allocated if all three extents are non-zero, and both,</para>
        /// <para>cudaArrayCubemap and cudaArrayLayered flags are set. Width must be equal to height, and depth must be</para>
        /// <para>a multiple of six. A cubemap layered CUDA array is a special type of 2D layered CUDA array that consists</para>
        /// <para>of a collection of cubemaps. The first six layers represent the first cubemap, the next six layers form</para>
        /// <para>the second cubemap, and so on.</para>
        /// <para>Theparameter enables different options to be specified that affect</para>
        /// <para>the allocation, as follows.</para>
        /// <para>- ::cudaArrayDefault: This flag's value is defined to be 0 and provides default array allocation</para>
        /// <para>- ::cudaArrayLayered: Allocates a layered CUDA array, with the depth extent indicating the number of layers</para>
        /// <para>- ::cudaArrayCubemap: Allocates a cubemap CUDA array. Width must be equal to height, and depth must be six.</para>
        /// <para>If the cudaArrayLayered flag is also set, depth must be a multiple of six.</para>
        /// <para>- ::cudaArraySurfaceLoadStore: Allocates a CUDA array that could be read from or written to using a surface</para>
        /// <para>reference.</para>
        /// <para>- ::cudaArrayTextureGather: This flag indicates that texture gather operations will be performed on the CUDA</para>
        /// <para>array. Texture gather can only be performed on 2D CUDA arrays.</para>
        /// <para>The width, height and depth extents must meet certain size requirements as listed in the following table.</para>
        /// <para>All values are specified in elements.</para>
        /// <para>Note that 2D CUDA arrays have different size requirements if the ::cudaArrayTextureGather flag is set. In that</para>
        /// <para>case, the valid range for (width, height, depth) is ((1,maxTexture2DGather[0]), (1,maxTexture2DGather[1]), 0).</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc, ::cudaMallocPitch, ::cudaFree,</para>
        /// <para>::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc,</para>
        /// <para>::make_cudaExtent,</para>
        /// <para>::cuArray3DCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMalloc3DArray(global::CUDA.CudaArray array, global::CUDA.CudaChannelFormatDesc desc, global::CUDA.CudaExtent extent, uint flags)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg1 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __arg2 = ReferenceEquals(extent, null) ? new global::CUDA.CudaExtent.__Internal() : *(global::CUDA.CudaExtent.__Internal*)extent.__Instance;
            var __ret = __Internal.CudaMalloc3DArray(__arg0, __arg1, __arg2, flags);
            return __ret;
        }

        /// <summary>Allocate a mipmapped array on the device</summary>
        /// <param name="mipmappedArray">- Pointer to allocated mipmapped array in device memory</param>
        /// <param name="desc">- Requested channel format</param>
        /// <param name="extent">- Requested allocation size (field in elements)</param>
        /// <param name="numLevels">- Number of mipmap levels to allocate</param>
        /// <param name="flags">- Flags for extensions</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorMemoryAllocation</para>
        /// </returns>
        /// <remarks>
        /// <para>Allocates a CUDA mipmapped array according to the ::cudaChannelFormatDesc structure</para>
        /// <para>and returns a handle to the new CUDA mipmapped array inspecifies the number of mipmap levels to be allocated. This value is</para>
        /// <para>clamped to the range [1, 1 + floor(log2(max(width, height, depth)))].</para>
        /// <para>The ::cudaChannelFormatDesc is defined as:</para>
        /// <para>where ::cudaChannelFormatKind is one of ::cudaChannelFormatKindSigned,</para>
        /// <para>::cudaChannelFormatKindUnsigned, or ::cudaChannelFormatKindFloat.</para>
        /// <para>::cudaMallocMipmappedArray() can allocate the following:</para>
        /// <para>- A 1D mipmapped array is allocated if the height and depth extents are both zero.</para>
        /// <para>- A 2D mipmapped array is allocated if only the depth extent is zero.</para>
        /// <para>- A 3D mipmapped array is allocated if all three extents are non-zero.</para>
        /// <para>- A 1D layered CUDA mipmapped array is allocated if only the height extent is zero and</para>
        /// <para>the cudaArrayLayered flag is set. Each layer is a 1D mipmapped array. The number of layers is</para>
        /// <para>determined by the depth extent.</para>
        /// <para>- A 2D layered CUDA mipmapped array is allocated if all three extents are non-zero and</para>
        /// <para>the cudaArrayLayered flag is set. Each layer is a 2D mipmapped array. The number of layers is</para>
        /// <para>determined by the depth extent.</para>
        /// <para>- A cubemap CUDA mipmapped array is allocated if all three extents are non-zero and the</para>
        /// <para>cudaArrayCubemap flag is set. Width must be equal to height, and depth must be six.</para>
        /// <para>The order of the six layers in memory is the same as that listed in ::cudaGraphicsCubeFace.</para>
        /// <para>- A cubemap layered CUDA mipmapped array is allocated if all three extents are non-zero, and both,</para>
        /// <para>cudaArrayCubemap and cudaArrayLayered flags are set. Width must be equal to height, and depth must be</para>
        /// <para>a multiple of six. A cubemap layered CUDA mipmapped array is a special type of 2D layered CUDA mipmapped</para>
        /// <para>array that consists of a collection of cubemap mipmapped arrays. The first six layers represent the</para>
        /// <para>first cubemap mipmapped array, the next six layers form the second cubemap mipmapped array, and so on.</para>
        /// <para>Theparameter enables different options to be specified that affect</para>
        /// <para>the allocation, as follows.</para>
        /// <para>- ::cudaArrayDefault: This flag's value is defined to be 0 and provides default mipmapped array allocation</para>
        /// <para>- ::cudaArrayLayered: Allocates a layered CUDA mipmapped array, with the depth extent indicating the number of layers</para>
        /// <para>- ::cudaArrayCubemap: Allocates a cubemap CUDA mipmapped array. Width must be equal to height, and depth must be six.</para>
        /// <para>If the cudaArrayLayered flag is also set, depth must be a multiple of six.</para>
        /// <para>- ::cudaArraySurfaceLoadStore: This flag indicates that individual mipmap levels of the CUDA mipmapped array</para>
        /// <para>will be read from or written to using a surface reference.</para>
        /// <para>- ::cudaArrayTextureGather: This flag indicates that texture gather operations will be performed on the CUDA</para>
        /// <para>array. Texture gather can only be performed on 2D CUDA mipmapped arrays, and the gather operations are</para>
        /// <para>performed only on the most detailed mipmap level.</para>
        /// <para>The width, height and depth extents must meet certain size requirements as listed in the following table.</para>
        /// <para>All values are specified in elements.</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc, ::cudaMallocPitch, ::cudaFree,</para>
        /// <para>::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc,</para>
        /// <para>::make_cudaExtent,</para>
        /// <para>::cuMipmappedArrayCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMallocMipmappedArray(global::CUDA.CudaMipmappedArray mipmappedArray, global::CUDA.CudaChannelFormatDesc desc, global::CUDA.CudaExtent extent, uint numLevels, uint flags)
        {
            var __arg0 = ReferenceEquals(mipmappedArray, null) ? global::System.IntPtr.Zero : mipmappedArray.__Instance;
            var __arg1 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __arg2 = ReferenceEquals(extent, null) ? new global::CUDA.CudaExtent.__Internal() : *(global::CUDA.CudaExtent.__Internal*)extent.__Instance;
            var __ret = __Internal.CudaMallocMipmappedArray(__arg0, __arg1, __arg2, numLevels, flags);
            return __ret;
        }

        /// <summary>Gets a mipmap level of a CUDA mipmapped array</summary>
        /// <param name="levelArray">- Returned mipmap level CUDA array</param>
        /// <param name="mipmappedArray">- CUDA mipmapped array</param>
        /// <param name="level">- Mipmap level</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns ina CUDA array that represents a single mipmap level</para>
        /// <para>of the CUDA mipmapped array</para>
        /// <para>Ifis greater than the maximum number of levels in this mipmapped array,</para>
        /// <para>::cudaErrorInvalidValue is returned.</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc, ::cudaMallocPitch, ::cudaFree,</para>
        /// <para>::cudaFreeArray,</para>
        /// <para>::cudaFreeHost, ::cudaHostAlloc,</para>
        /// <para>::make_cudaExtent,</para>
        /// <para>::cuMipmappedArrayGetLevel</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetMipmappedArrayLevel(global::CUDA.CudaArray levelArray, global::CUDA.CudaMipmappedArray mipmappedArray, uint level)
        {
            var __arg0 = ReferenceEquals(levelArray, null) ? global::System.IntPtr.Zero : levelArray.__Instance;
            var __arg1 = ReferenceEquals(mipmappedArray, null) ? global::System.IntPtr.Zero : mipmappedArray.__Instance;
            var __ret = __Internal.CudaGetMipmappedArrayLevel(__arg0, __arg1, level);
            return __ret;
        }

        /// <summary>Copies data between 3D objects</summary>
        /// <param name="p">- 3D memory copy parameters</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>::cudaMemcpy3D() copies data betwen two 3D objects. The source and</para>
        /// <para>destination objects may be in either host memory, device memory, or a CUDA</para>
        /// <para>array. The source, destination, extent, and kind of copy performed is</para>
        /// <para>specified by the ::cudaMemcpy3DParms struct which should be initialized to</para>
        /// <para>zero before use:</para>
        /// <para>The struct passed to ::cudaMemcpy3D() must specify one ofor</para>
        /// <para>and one oforPassing more than one</para>
        /// <para>non-zero source or destination will cause ::cudaMemcpy3D() to return an</para>
        /// <para>error.</para>
        /// <para>Theandfields are optional offsets into the source and</para>
        /// <para>destination objects and are defined in units of each object's elements. The</para>
        /// <para>element for a host or device pointer is assumed to beunsigned char.</para>
        /// <para>Thefield defines the dimensions of the transferred area in</para>
        /// <para>elements. If a CUDA array is participating in the copy, the extent is</para>
        /// <para>defined in terms of that array's elements. If no CUDA array is</para>
        /// <para>participating in the copy then the extents are defined in elements of</para>
        /// <para>unsigned char.</para>
        /// <para>Thefield defines the direction of the copy. It must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>For ::cudaMemcpyHostToHost or ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost</para>
        /// <para>passed as kind and cudaArray type passed as source or destination, if the kind</para>
        /// <para>implies cudaArray type to be present on the host, ::cudaMemcpy3D() will</para>
        /// <para>disregard that implication and silently correct the kind based on the fact that</para>
        /// <para>cudaArray type can only be present on the device.</para>
        /// <para>If the source and destination are both arrays, ::cudaMemcpy3D() will return</para>
        /// <para>an error if they do not have the same element size.</para>
        /// <para>The source and destination object may not overlap. If overlapping source</para>
        /// <para>and destination objects are specified, undefined behavior will result.</para>
        /// <para>The source object must lie entirely within the region defined byandThe destination object must lie entirely within the region</para>
        /// <para>defined byand</para>
        /// <para>::cudaMemcpy3D() returns an error if the pitch oforexceeds the maximum allowed. The pitch of a ::cudaPitchedPtr allocated</para>
        /// <para>with ::cudaMalloc3D() will always be valid.</para>
        /// <para>_sync</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc3DArray, ::cudaMemset3D, ::cudaMemcpy3DAsync,</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::make_cudaExtent, ::make_cudaPos,</para>
        /// <para>::cuMemcpy3D</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy3D(global::CUDA.CudaMemcpy3DParms p)
        {
            var __arg0 = ReferenceEquals(p, null) ? global::System.IntPtr.Zero : p.__Instance;
            var __ret = __Internal.CudaMemcpy3D(__arg0);
            return __ret;
        }

        /// <summary>Copies memory between devices</summary>
        /// <param name="p">- Parameters for the memory copy</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Perform a 3D memory copy according to the parameters specified in</para>
        /// <para>See the definition of the ::cudaMemcpy3DPeerParms structure</para>
        /// <para>for documentation of its parameters.</para>
        /// <para>Note that this function is synchronous with respect to the host only if</para>
        /// <para>the source or destination of the transfer is host memory.  Note also</para>
        /// <para>that this copy is serialized with respect to all pending and future</para>
        /// <para>asynchronous work in to the current device, the copy's source device,</para>
        /// <para>and the copy's destination device (use ::cudaMemcpy3DPeerAsync to avoid</para>
        /// <para>this synchronization).</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy, ::cudaMemcpyPeer, ::cudaMemcpyAsync, ::cudaMemcpyPeerAsync,</para>
        /// <para>::cudaMemcpy3DPeerAsync,</para>
        /// <para>::cuMemcpy3DPeer</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy3DPeer(global::CUDA.CudaMemcpy3DPeerParms p)
        {
            var __arg0 = ReferenceEquals(p, null) ? global::System.IntPtr.Zero : p.__Instance;
            var __ret = __Internal.CudaMemcpy3DPeer(__arg0);
            return __ret;
        }

        /// <summary>Copies data between 3D objects</summary>
        /// <param name="p">- 3D memory copy parameters</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>::cudaMemcpy3DAsync() copies data betwen two 3D objects. The source and</para>
        /// <para>destination objects may be in either host memory, device memory, or a CUDA</para>
        /// <para>array. The source, destination, extent, and kind of copy performed is</para>
        /// <para>specified by the ::cudaMemcpy3DParms struct which should be initialized to</para>
        /// <para>zero before use:</para>
        /// <para>The struct passed to ::cudaMemcpy3DAsync() must specify one oforand one oforPassing more than one</para>
        /// <para>non-zero source or destination will cause ::cudaMemcpy3DAsync() to return an</para>
        /// <para>error.</para>
        /// <para>Theandfields are optional offsets into the source and</para>
        /// <para>destination objects and are defined in units of each object's elements. The</para>
        /// <para>element for a host or device pointer is assumed to beunsigned char.</para>
        /// <para>For CUDA arrays, positions must be in the range [0, 2048) for any</para>
        /// <para>dimension.</para>
        /// <para>Thefield defines the dimensions of the transferred area in</para>
        /// <para>elements. If a CUDA array is participating in the copy, the extent is</para>
        /// <para>defined in terms of that array's elements. If no CUDA array is</para>
        /// <para>participating in the copy then the extents are defined in elements of</para>
        /// <para>unsigned char.</para>
        /// <para>Thefield defines the direction of the copy. It must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>For ::cudaMemcpyHostToHost or ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost</para>
        /// <para>passed as kind and cudaArray type passed as source or destination, if the kind</para>
        /// <para>implies cudaArray type to be present on the host, ::cudaMemcpy3DAsync() will</para>
        /// <para>disregard that implication and silently correct the kind based on the fact that</para>
        /// <para>cudaArray type can only be present on the device.</para>
        /// <para>If the source and destination are both arrays, ::cudaMemcpy3DAsync() will</para>
        /// <para>return an error if they do not have the same element size.</para>
        /// <para>The source and destination object may not overlap. If overlapping source</para>
        /// <para>and destination objects are specified, undefined behavior will result.</para>
        /// <para>The source object must lie entirely within the region defined byandThe destination object must lie entirely within the region</para>
        /// <para>defined byand</para>
        /// <para>::cudaMemcpy3DAsync() returns an error if the pitch ofor</para>
        /// <para>exceeds the maximum allowed. The pitch of a</para>
        /// <para>::cudaPitchedPtr allocated with ::cudaMalloc3D() will always be valid.</para>
        /// <para>::cudaMemcpy3DAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument. If</para>
        /// <para>is ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost andis non-zero, the copy may overlap with operations in other streams.</para>
        /// <para>The device version of this function only handles device to device copies and</para>
        /// <para>cannot be given local or shared pointers.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMalloc3D, ::cudaMalloc3DArray, ::cudaMemset3D, ::cudaMemcpy3D,</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::make_cudaExtent, ::make_cudaPos,</para>
        /// <para>::cuMemcpy3DAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy3DAsync(global::CUDA.CudaMemcpy3DParms p, global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(p, null) ? global::System.IntPtr.Zero : p.__Instance;
            var __arg1 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpy3DAsync(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Copies memory between devices asynchronously.</summary>
        /// <param name="p">- Parameters for the memory copy</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Perform a 3D memory copy according to the parameters specified in</para>
        /// <para>See the definition of the ::cudaMemcpy3DPeerParms structure</para>
        /// <para>for documentation of its parameters.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpyPeer, ::cudaMemcpyAsync, ::cudaMemcpyPeerAsync,</para>
        /// <para>::cudaMemcpy3DPeerAsync,</para>
        /// <para>::cuMemcpy3DPeerAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy3DPeerAsync(global::CUDA.CudaMemcpy3DPeerParms p, global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(p, null) ? global::System.IntPtr.Zero : p.__Instance;
            var __arg1 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpy3DPeerAsync(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Gets free and total device memory</summary>
        /// <param name="free">- Returned free memory in bytes</param>
        /// <param name="total">- Returned total memory in bytes</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInitializationError,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorLaunchFailure</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inandrespectively, the free and total amount of</para>
        /// <para>memory available for allocation by the device in bytes.</para>
        /// <para>::cuMemGetInfo</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemGetInfo(ref ulong free, ref ulong total)
        {
            fixed (ulong* __refParamPtr0 = &free)
            {
                var __arg0 = __refParamPtr0;
                fixed (ulong* __refParamPtr1 = &total)
                {
                    var __arg1 = __refParamPtr1;
                    var __ret = __Internal.CudaMemGetInfo(__arg0, __arg1);
                    return __ret;
                }
            }
        }

        /// <summary>Gets info about the specified cudaArray</summary>
        /// <param name="desc">- Returned array type</param>
        /// <param name="extent">- Returned array shape. 2D arrays will have depth of zero</param>
        /// <param name="flags">- Returned array flags</param>
        /// <param name="array">- The ::cudaArray to get info for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inandrespectively, the type, shape</para>
        /// <para>and flags of</para>
        /// <para>Any ofandmay be specified as NULL.</para>
        /// <para>::cuArrayGetDescriptor,</para>
        /// <para>::cuArray3DGetDescriptor</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaArrayGetInfo(global::CUDA.CudaChannelFormatDesc desc, global::CUDA.CudaExtent extent, ref uint flags, global::CUDA.CudaArray array)
        {
            var __arg0 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __arg1 = ReferenceEquals(extent, null) ? global::System.IntPtr.Zero : extent.__Instance;
            fixed (uint* __refParamPtr2 = &flags)
            {
                var __arg2 = __refParamPtr2;
                var __arg3 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
                var __ret = __Internal.CudaArrayGetInfo(__arg0, __arg1, __arg2, __arg3);
                return __ret;
            }
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to byto the</para>
        /// <para>memory area pointed to bywherespecifies the direction</para>
        /// <para>of the copy, and must be one of ::cudaMemcpyHostToHost,</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing. Calling</para>
        /// <para>::cudaMemcpy() with dst and src pointers that do not match the direction of</para>
        /// <para>the copy results in an undefined behavior.</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpyDtoH,</para>
        /// <para>::cuMemcpyHtoD,</para>
        /// <para>::cuMemcpyDtoD,</para>
        /// <para>::cuMemcpy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy(global::System.IntPtr dst, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind)
        {
            var __ret = __Internal.CudaMemcpy(dst, src, count, kind);
            return __ret;
        }

        /// <summary>Copies memory between two devices</summary>
        /// <param name="dst">- Destination device pointer</param>
        /// <param name="dstDevice">- Destination device</param>
        /// <param name="src">- Source device pointer</param>
        /// <param name="srcDevice">- Source device</param>
        /// <param name="count">- Size of memory copy in bytes</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies memory from one device to memory on another device.is the</para>
        /// <para>base device pointer of the destination memory andis the</para>
        /// <para>destination device.is the base device pointer of the source memory</para>
        /// <para>andis the source device.specifies the number of bytes</para>
        /// <para>to copy.</para>
        /// <para>Note that this function is asynchronous with respect to the host, but</para>
        /// <para>serialized with respect all pending and future asynchronous work in to the</para>
        /// <para>current device,and(use ::cudaMemcpyPeerAsync</para>
        /// <para>to avoid this synchronization).</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy, ::cudaMemcpyAsync, ::cudaMemcpyPeerAsync,</para>
        /// <para>::cudaMemcpy3DPeerAsync,</para>
        /// <para>::cuMemcpyPeer</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyPeer(global::System.IntPtr dst, int dstDevice, global::System.IntPtr src, int srcDevice, ulong count)
        {
            var __ret = __Internal.CudaMemcpyPeer(dst, dstDevice, src, srcDevice, count);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="wOffset">- Destination starting X offset</param>
        /// <param name="hOffset">- Destination starting Y offset</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to byto the</para>
        /// <para>CUDA arraystarting at the upper left corner</para>
        /// <para>(wherespecifies the direction</para>
        /// <para>of the copy, and must be one of ::cudaMemcpyHostToHost,</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpyHtoA,</para>
        /// <para>::cuMemcpyDtoA</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyToArray(global::CUDA.CudaArray dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind)
        {
            var __arg0 = ReferenceEquals(dst, null) ? global::System.IntPtr.Zero : dst.__Instance;
            var __ret = __Internal.CudaMemcpyToArray(__arg0, wOffset, hOffset, src, count, kind);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="wOffset">- Source starting X offset</param>
        /// <param name="hOffset">- Source starting Y offset</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the CUDA arraystarting at the upper</para>
        /// <para>left corner (hOffset) to the memory area pointed to bywherespecifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpyAtoH,</para>
        /// <para>::cuMemcpyAtoD</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyFromArray(global::System.IntPtr dst, global::CUDA.CudaArray src, ulong wOffset, ulong hOffset, ulong count, global::CUDA.CudaMemcpyKind kind)
        {
            var __arg1 = ReferenceEquals(src, null) ? global::System.IntPtr.Zero : src.__Instance;
            var __ret = __Internal.CudaMemcpyFromArray(dst, __arg1, wOffset, hOffset, count, kind);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="wOffsetDst">- Destination starting X offset</param>
        /// <param name="hOffsetDst">- Destination starting Y offset</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="wOffsetSrc">- Source starting X offset</param>
        /// <param name="hOffsetSrc">- Source starting Y offset</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the CUDA arraystarting at the upper</para>
        /// <para>left corner (to the CUDA arraystarting at the upper left corner (where</para>
        /// <para>specifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpyAtoA</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyArrayToArray(global::CUDA.CudaArray dst, ulong wOffsetDst, ulong hOffsetDst, global::CUDA.CudaArray src, ulong wOffsetSrc, ulong hOffsetSrc, ulong count, global::CUDA.CudaMemcpyKind kind)
        {
            var __arg0 = ReferenceEquals(dst, null) ? global::System.IntPtr.Zero : dst.__Instance;
            var __arg3 = ReferenceEquals(src, null) ? global::System.IntPtr.Zero : src.__Instance;
            var __ret = __Internal.CudaMemcpyArrayToArray(__arg0, wOffsetDst, hOffsetDst, __arg3, wOffsetSrc, hOffsetSrc, count, kind);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="dpitch">- Pitch of destination memory</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="spitch">- Pitch of source memory</param>
        /// <param name="width">- Width of matrix transfer (columns in bytes)</param>
        /// <param name="height">- Height of matrix transfer (rows)</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies a matrix (rows ofbytes each) from the memory</para>
        /// <para>area pointed to byto the memory area pointed to bywhere</para>
        /// <para>specifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.and</para>
        /// <para>are the widths in memory in bytes of the 2D arrays pointed to by</para>
        /// <para>andincluding any padding added to the end of each row. The</para>
        /// <para>memory areas may not overlap.must not exceed eitheror</para>
        /// <para>Calling ::cudaMemcpy2D() withandpointers that do</para>
        /// <para>not match the direction of the copy results in an undefined behavior.</para>
        /// <para>::cudaMemcpy2D() returns an error iforexceeds</para>
        /// <para>the maximum allowed.</para>
        /// <para>::cudaMemcpy, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy2D,</para>
        /// <para>::cuMemcpy2DUnaligned</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy2D(global::System.IntPtr dst, ulong dpitch, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind)
        {
            var __ret = __Internal.CudaMemcpy2D(dst, dpitch, src, spitch, width, height, kind);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="wOffset">- Destination starting X offset</param>
        /// <param name="hOffset">- Destination starting Y offset</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="spitch">- Pitch of source memory</param>
        /// <param name="width">- Width of matrix transfer (columns in bytes)</param>
        /// <param name="height">- Height of matrix transfer (rows)</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies a matrix (rows ofbytes each) from the memory</para>
        /// <para>area pointed to byto the CUDA arraystarting at the</para>
        /// <para>upper left corner (wherespecifies the</para>
        /// <para>direction of the copy, and must be one of ::cudaMemcpyHostToHost,</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>is the width in memory in bytes of the 2D array pointed to by</para>
        /// <para>including any padding added to the end of each row.+</para>
        /// <para>must not exceed the width of the CUDA arraymust</para>
        /// <para>not exceed::cudaMemcpy2DToArray() returns an error ifexceeds the maximum allowed.</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy2D,</para>
        /// <para>::cuMemcpy2DUnaligned</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy2DToArray(global::CUDA.CudaArray dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind)
        {
            var __arg0 = ReferenceEquals(dst, null) ? global::System.IntPtr.Zero : dst.__Instance;
            var __ret = __Internal.CudaMemcpy2DToArray(__arg0, wOffset, hOffset, src, spitch, width, height, kind);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="dpitch">- Pitch of destination memory</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="wOffset">- Source starting X offset</param>
        /// <param name="hOffset">- Source starting Y offset</param>
        /// <param name="width">- Width of matrix transfer (columns in bytes)</param>
        /// <param name="height">- Height of matrix transfer (rows)</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies a matrix (rows ofbytes each) from the CUDA</para>
        /// <para>arraystarting at the upper left corner</para>
        /// <para>(to the memory area pointed to bywhere</para>
        /// <para>specifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.is the</para>
        /// <para>width in memory in bytes of the 2D array pointed to byincluding any</para>
        /// <para>padding added to the end of each row.+must not exceed</para>
        /// <para>the width of the CUDA arraymust not exceed::cudaMemcpy2DFromArray() returns an error ifexceeds the maximum</para>
        /// <para>allowed.</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy2D,</para>
        /// <para>::cuMemcpy2DUnaligned</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy2DFromArray(global::System.IntPtr dst, ulong dpitch, global::CUDA.CudaArray src, ulong wOffset, ulong hOffset, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind)
        {
            var __arg2 = ReferenceEquals(src, null) ? global::System.IntPtr.Zero : src.__Instance;
            var __ret = __Internal.CudaMemcpy2DFromArray(dst, dpitch, __arg2, wOffset, hOffset, width, height, kind);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="wOffsetDst">- Destination starting X offset</param>
        /// <param name="hOffsetDst">- Destination starting Y offset</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="wOffsetSrc">- Source starting X offset</param>
        /// <param name="hOffsetSrc">- Source starting Y offset</param>
        /// <param name="width">- Width of matrix transfer (columns in bytes)</param>
        /// <param name="height">- Height of matrix transfer (rows)</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies a matrix (rows ofbytes each) from the CUDA</para>
        /// <para>arraystarting at the upper left corner</para>
        /// <para>(to the CUDA arraystarting at</para>
        /// <para>the upper left corner (wherespecifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>+must not exceed the width of the CUDA array+must not exceed the width of the CUDA array</para>
        /// <para>_sync</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy2D,</para>
        /// <para>::cuMemcpy2DUnaligned</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy2DArrayToArray(global::CUDA.CudaArray dst, ulong wOffsetDst, ulong hOffsetDst, global::CUDA.CudaArray src, ulong wOffsetSrc, ulong hOffsetSrc, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind)
        {
            var __arg0 = ReferenceEquals(dst, null) ? global::System.IntPtr.Zero : dst.__Instance;
            var __arg3 = ReferenceEquals(src, null) ? global::System.IntPtr.Zero : src.__Instance;
            var __ret = __Internal.CudaMemcpy2DArrayToArray(__arg0, wOffsetDst, hOffsetDst, __arg3, wOffsetSrc, hOffsetSrc, width, height, kind);
            return __ret;
        }

        /// <summary>Copies data to the given symbol on the device</summary>
        /// <param name="symbol">- Device symbol address</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="offset">- Offset from start of symbol in bytes</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection,</para>
        /// <para>::cudaErrorNoKernelImageForDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to byto the memory area pointed to bybytes from the start of symbol</para>
        /// <para>The memory areas may not overlap.is a variable that</para>
        /// <para>resides in global or constant memory space.can be either</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault.</para>
        /// <para>Passing ::cudaMemcpyDefault is recommended, in which case the type of</para>
        /// <para>transfer is inferred from the pointer values. However, ::cudaMemcpyDefault</para>
        /// <para>is only allowed on systems that support unified virtual addressing.</para>
        /// <para>_sync</para>
        /// <para>_string_api_deprecation</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy,</para>
        /// <para>::cuMemcpyHtoD,</para>
        /// <para>::cuMemcpyDtoD</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyToSymbol(global::System.IntPtr symbol, global::System.IntPtr src, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind)
        {
            var __ret = __Internal.CudaMemcpyToSymbol(symbol, src, count, offset, kind);
            return __ret;
        }

        /// <summary>Copies data from the given symbol on the device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="symbol">- Device symbol address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="offset">- Offset from start of symbol in bytes</param>
        /// <param name="kind">- Type of transfer</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection,</para>
        /// <para>::cudaErrorNoKernelImageForDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to bybytes</para>
        /// <para>from the start of symbolto the memory area pointed to byThe memory areas may not overlap.is a variable that</para>
        /// <para>resides in global or constant memory space.can be either</para>
        /// <para>::cudaMemcpyDeviceToHost, ::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault.</para>
        /// <para>Passing ::cudaMemcpyDefault is recommended, in which case the type of</para>
        /// <para>transfer is inferred from the pointer values. However, ::cudaMemcpyDefault</para>
        /// <para>is only allowed on systems that support unified virtual addressing.</para>
        /// <para>_sync</para>
        /// <para>_string_api_deprecation</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy,</para>
        /// <para>::cuMemcpyDtoH,</para>
        /// <para>::cuMemcpyDtoD</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyFromSymbol(global::System.IntPtr dst, global::System.IntPtr symbol, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind)
        {
            var __ret = __Internal.CudaMemcpyFromSymbol(dst, symbol, count, offset, kind);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to byto the</para>
        /// <para>memory area pointed to bywherespecifies the</para>
        /// <para>direction of the copy, and must be one of ::cudaMemcpyHostToHost,</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>The memory areas may not overlap. Calling ::cudaMemcpyAsync() withand</para>
        /// <para>pointers that do not match the direction of the copy results in an</para>
        /// <para>undefined behavior.</para>
        /// <para>::cudaMemcpyAsync() is asynchronous with respect to the host, so the call</para>
        /// <para>may return before the copy is complete. The copy can optionally be</para>
        /// <para>associated to a stream by passing a non-zeroargument. Ifis ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost and theis</para>
        /// <para>non-zero, the copy may overlap with operations in other streams.</para>
        /// <para>The device version of this function only handles device to device copies and</para>
        /// <para>cannot be given local or shared pointers.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync</para>
        /// <para>::cuMemcpyAsync,</para>
        /// <para>::cuMemcpyDtoHAsync,</para>
        /// <para>::cuMemcpyHtoDAsync,</para>
        /// <para>::cuMemcpyDtoDAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyAsync(global::System.IntPtr dst, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg4 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpyAsync(dst, src, count, kind, __arg4);
            return __ret;
        }

        /// <summary>Copies memory between two devices asynchronously.</summary>
        /// <param name="dst">- Destination device pointer</param>
        /// <param name="dstDevice">- Destination device</param>
        /// <param name="src">- Source device pointer</param>
        /// <param name="srcDevice">- Source device</param>
        /// <param name="count">- Size of memory copy in bytes</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies memory from one device to memory on another device.is the</para>
        /// <para>base device pointer of the destination memory andis the</para>
        /// <para>destination device.is the base device pointer of the source memory</para>
        /// <para>andis the source device.specifies the number of bytes</para>
        /// <para>to copy.</para>
        /// <para>Note that this function is asynchronous with respect to the host and all work</para>
        /// <para>on other devices.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpyPeer, ::cudaMemcpyAsync,</para>
        /// <para>::cudaMemcpy3DPeerAsync,</para>
        /// <para>::cuMemcpyPeerAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyPeerAsync(global::System.IntPtr dst, int dstDevice, global::System.IntPtr src, int srcDevice, ulong count, global::CUDA.CUstreamSt stream)
        {
            var __arg5 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpyPeerAsync(dst, dstDevice, src, srcDevice, count, __arg5);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="wOffset">- Destination starting X offset</param>
        /// <param name="hOffset">- Destination starting Y offset</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to byto the</para>
        /// <para>CUDA arraystarting at the upper left corner</para>
        /// <para>(wherespecifies the</para>
        /// <para>direction of the copy, and must be one of ::cudaMemcpyHostToHost,</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>::cudaMemcpyToArrayAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument. Ifis ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost andis non-zero, the copy may overlap with operations in other streams.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpyHtoAAsync,</para>
        /// <para>::cuMemcpy2DAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyToArrayAsync(global::CUDA.CudaArray dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong count, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(dst, null) ? global::System.IntPtr.Zero : dst.__Instance;
            var __arg6 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpyToArrayAsync(__arg0, wOffset, hOffset, src, count, kind, __arg6);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="wOffset">- Source starting X offset</param>
        /// <param name="hOffset">- Source starting Y offset</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the CUDA arraystarting at the upper</para>
        /// <para>left corner (hOffset) to the memory area pointed to bywherespecifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>::cudaMemcpyFromArrayAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument. Ifis ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost andis non-zero, the copy may overlap with operations in other streams.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpyAtoHAsync,</para>
        /// <para>::cuMemcpy2DAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyFromArrayAsync(global::System.IntPtr dst, global::CUDA.CudaArray src, ulong wOffset, ulong hOffset, ulong count, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg1 = ReferenceEquals(src, null) ? global::System.IntPtr.Zero : src.__Instance;
            var __arg6 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpyFromArrayAsync(dst, __arg1, wOffset, hOffset, count, kind, __arg6);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="dpitch">- Pitch of destination memory</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="spitch">- Pitch of source memory</param>
        /// <param name="width">- Width of matrix transfer (columns in bytes)</param>
        /// <param name="height">- Height of matrix transfer (rows)</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies a matrix (rows ofbytes each) from the memory</para>
        /// <para>area pointed to byto the memory area pointed to bywhere</para>
        /// <para>specifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>andare the widths in memory in bytes of the 2D arrays</para>
        /// <para>pointed to byandincluding any padding added to the end of</para>
        /// <para>each row. The memory areas may not overlap.must not exceed either</para>
        /// <para>or</para>
        /// <para>Calling ::cudaMemcpy2DAsync() withandpointers that do not</para>
        /// <para>match the direction of the copy results in an undefined behavior.</para>
        /// <para>::cudaMemcpy2DAsync() returns an error iforis greater</para>
        /// <para>than the maximum allowed.</para>
        /// <para>::cudaMemcpy2DAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument. If</para>
        /// <para>is ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost and</para>
        /// <para>is non-zero, the copy may overlap with operations in other</para>
        /// <para>streams.</para>
        /// <para>The device version of this function only handles device to device copies and</para>
        /// <para>cannot be given local or shared pointers.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy2DAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy2DAsync(global::System.IntPtr dst, ulong dpitch, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg7 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpy2DAsync(dst, dpitch, src, spitch, width, height, kind, __arg7);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="wOffset">- Destination starting X offset</param>
        /// <param name="hOffset">- Destination starting Y offset</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="spitch">- Pitch of source memory</param>
        /// <param name="width">- Width of matrix transfer (columns in bytes)</param>
        /// <param name="height">- Height of matrix transfer (rows)</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies a matrix (rows ofbytes each) from the memory</para>
        /// <para>area pointed to byto the CUDA arraystarting at the</para>
        /// <para>upper left corner (wherespecifies the</para>
        /// <para>direction of the copy, and must be one of ::cudaMemcpyHostToHost,</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>is the width in memory in bytes of the 2D array pointed to by</para>
        /// <para>including any padding added to the end of each row.+</para>
        /// <para>must not exceed the width of the CUDA arraymust</para>
        /// <para>not exceed::cudaMemcpy2DToArrayAsync() returns an error if</para>
        /// <para>exceeds the maximum allowed.</para>
        /// <para>::cudaMemcpy2DToArrayAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument. If</para>
        /// <para>is ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost and</para>
        /// <para>is non-zero, the copy may overlap with operations in other</para>
        /// <para>streams.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy2DAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy2DToArrayAsync(global::CUDA.CudaArray dst, ulong wOffset, ulong hOffset, global::System.IntPtr src, ulong spitch, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(dst, null) ? global::System.IntPtr.Zero : dst.__Instance;
            var __arg8 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpy2DToArrayAsync(__arg0, wOffset, hOffset, src, spitch, width, height, kind, __arg8);
            return __ret;
        }

        /// <summary>Copies data between host and device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="dpitch">- Pitch of destination memory</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="wOffset">- Source starting X offset</param>
        /// <param name="hOffset">- Source starting Y offset</param>
        /// <param name="width">- Width of matrix transfer (columns in bytes)</param>
        /// <param name="height">- Height of matrix transfer (rows)</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidPitchValue,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection</para>
        /// </returns>
        /// <remarks>
        /// <para>Copies a matrix (rows ofbytes each) from the CUDA</para>
        /// <para>arraystarting at the upper left corner</para>
        /// <para>(to the memory area pointed to bywhere</para>
        /// <para>specifies the direction of the copy, and must be one of</para>
        /// <para>::cudaMemcpyHostToHost, ::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToHost,</para>
        /// <para>::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault. Passing</para>
        /// <para>::cudaMemcpyDefault is recommended, in which case the type of transfer is</para>
        /// <para>inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>is the width in memory in bytes of the 2D</para>
        /// <para>array pointed to byincluding any padding added to the end of each</para>
        /// <para>row.+must not exceed the width of the CUDA array</para>
        /// <para>must not exceed::cudaMemcpy2DFromArrayAsync()</para>
        /// <para>returns an error ifexceeds the maximum allowed.</para>
        /// <para>::cudaMemcpy2DFromArrayAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally be</para>
        /// <para>associated to a stream by passing a non-zeroargument. Ifis ::cudaMemcpyHostToDevice or ::cudaMemcpyDeviceToHost andis</para>
        /// <para>non-zero, the copy may overlap with operations in other streams.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync, ::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpy2DAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpy2DFromArrayAsync(global::System.IntPtr dst, ulong dpitch, global::CUDA.CudaArray src, ulong wOffset, ulong hOffset, ulong width, ulong height, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg2 = ReferenceEquals(src, null) ? global::System.IntPtr.Zero : src.__Instance;
            var __arg8 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpy2DFromArrayAsync(dst, dpitch, __arg2, wOffset, hOffset, width, height, kind, __arg8);
            return __ret;
        }

        /// <summary>Copies data to the given symbol on the device</summary>
        /// <param name="symbol">- Device symbol address</param>
        /// <param name="src">- Source memory address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="offset">- Offset from start of symbol in bytes</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection,</para>
        /// <para>::cudaErrorNoKernelImageForDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to byto the memory area pointed to bybytes from the start of symbol</para>
        /// <para>The memory areas may not overlap.is a variable that</para>
        /// <para>resides in global or constant memory space.can be either</para>
        /// <para>::cudaMemcpyHostToDevice, ::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault.</para>
        /// <para>Passing ::cudaMemcpyDefault is recommended, in which case the type of transfer</para>
        /// <para>is inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>::cudaMemcpyToSymbolAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument. If</para>
        /// <para>is ::cudaMemcpyHostToDevice andis non-zero, the copy</para>
        /// <para>may overlap with operations in other streams.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>_string_api_deprecation</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyFromSymbolAsync,</para>
        /// <para>::cuMemcpyAsync,</para>
        /// <para>::cuMemcpyHtoDAsync,</para>
        /// <para>::cuMemcpyDtoDAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyToSymbolAsync(global::System.IntPtr symbol, global::System.IntPtr src, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg5 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpyToSymbolAsync(symbol, src, count, offset, kind, __arg5);
            return __ret;
        }

        /// <summary>Copies data from the given symbol on the device</summary>
        /// <param name="dst">- Destination memory address</param>
        /// <param name="symbol">- Device symbol address</param>
        /// <param name="count">- Size in bytes to copy</param>
        /// <param name="offset">- Offset from start of symbol in bytes</param>
        /// <param name="kind">- Type of transfer</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorInvalidMemcpyDirection,</para>
        /// <para>::cudaErrorNoKernelImageForDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Copiesbytes from the memory area pointed to bybytes</para>
        /// <para>from the start of symbolto the memory area pointed to byThe memory areas may not overlap.is a variable that resides in</para>
        /// <para>global or constant memory space.can be either</para>
        /// <para>::cudaMemcpyDeviceToHost, ::cudaMemcpyDeviceToDevice, or ::cudaMemcpyDefault.</para>
        /// <para>Passing ::cudaMemcpyDefault is recommended, in which case the type of transfer</para>
        /// <para>is inferred from the pointer values. However, ::cudaMemcpyDefault is only</para>
        /// <para>allowed on systems that support unified virtual addressing.</para>
        /// <para>::cudaMemcpyFromSymbolAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the copy is complete. The copy can optionally be</para>
        /// <para>associated to a stream by passing a non-zeroargument. Ifis ::cudaMemcpyDeviceToHost andis non-zero, the copy may overlap</para>
        /// <para>with operations in other streams.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>_string_api_deprecation</para>
        /// <para>::cudaMemcpy, ::cudaMemcpy2D, ::cudaMemcpyToArray,</para>
        /// <para>::cudaMemcpy2DToArray, ::cudaMemcpyFromArray, ::cudaMemcpy2DFromArray,</para>
        /// <para>::cudaMemcpyArrayToArray, ::cudaMemcpy2DArrayToArray, ::cudaMemcpyToSymbol,</para>
        /// <para>::cudaMemcpyFromSymbol, ::cudaMemcpyAsync, ::cudaMemcpy2DAsync,</para>
        /// <para>::cudaMemcpyToArrayAsync, ::cudaMemcpy2DToArrayAsync,</para>
        /// <para>::cudaMemcpyFromArrayAsync, ::cudaMemcpy2DFromArrayAsync,</para>
        /// <para>::cudaMemcpyToSymbolAsync,</para>
        /// <para>::cuMemcpyAsync,</para>
        /// <para>::cuMemcpyDtoHAsync,</para>
        /// <para>::cuMemcpyDtoDAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemcpyFromSymbolAsync(global::System.IntPtr dst, global::System.IntPtr symbol, ulong count, ulong offset, global::CUDA.CudaMemcpyKind kind, global::CUDA.CUstreamSt stream)
        {
            var __arg5 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemcpyFromSymbolAsync(dst, symbol, count, offset, kind, __arg5);
            return __ret;
        }

        /// <summary>Initializes or sets device memory to a value</summary>
        /// <param name="devPtr">- Pointer to device memory</param>
        /// <param name="value">- Value to set for each byte of specified memory</param>
        /// <param name="count">- Size in bytes to set</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// </returns>
        /// <remarks>
        /// <para>Fills the firstbytes of the memory area pointed to bywith the constant byte value</para>
        /// <para>Note that this function is asynchronous with respect to the host unless</para>
        /// <para>refers to pinned host memory.</para>
        /// <para>_memset</para>
        /// <para>::cuMemsetD8,</para>
        /// <para>::cuMemsetD16,</para>
        /// <para>::cuMemsetD32</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemset(global::System.IntPtr devPtr, int value, ulong count)
        {
            var __ret = __Internal.CudaMemset(devPtr, value, count);
            return __ret;
        }

        /// <summary>Initializes or sets device memory to a value</summary>
        /// <param name="devPtr">- Pointer to 2D device memory</param>
        /// <param name="pitch">- Pitch in bytes of 2D device memory</param>
        /// <param name="value">- Value to set for each byte of specified memory</param>
        /// <param name="width">- Width of matrix set (columns in bytes)</param>
        /// <param name="height">- Height of matrix set (rows)</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// </returns>
        /// <remarks>
        /// <para>Sets to the specified valuea matrix (rows ofbytes each) pointed to byis the width in bytes of the</para>
        /// <para>2D array pointed to byincluding any padding added to the end</para>
        /// <para>of each row. This function performs fastest when the pitch is one that has</para>
        /// <para>been passed back by ::cudaMallocPitch().</para>
        /// <para>Note that this function is asynchronous with respect to the host unless</para>
        /// <para>refers to pinned host memory.</para>
        /// <para>_memset</para>
        /// <para>::cudaMemset, ::cudaMemset3D, ::cudaMemsetAsync,</para>
        /// <para>::cudaMemset2DAsync, ::cudaMemset3DAsync,</para>
        /// <para>::cuMemsetD2D8,</para>
        /// <para>::cuMemsetD2D16,</para>
        /// <para>::cuMemsetD2D32</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemset2D(global::System.IntPtr devPtr, ulong pitch, int value, ulong width, ulong height)
        {
            var __ret = __Internal.CudaMemset2D(devPtr, pitch, value, width, height);
            return __ret;
        }

        /// <summary>Initializes or sets device memory to a value</summary>
        /// <param name="pitchedDevPtr">- Pointer to pitched device memory</param>
        /// <param name="value">- Value to set for each byte of specified memory</param>
        /// <param name="extent">- Size parameters for where to set device memory (field in bytes)</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// </returns>
        /// <remarks>
        /// <para>Initializes each element of a 3D array to the specified valueThe object to initialize is defined byThefield</para>
        /// <para>ofis the width in memory in bytes of the 3D array pointed</para>
        /// <para>to byincluding any padding added to the end of each row.</para>
        /// <para>Thefield specifies the logical width of each row in bytes, while</para>
        /// <para>thefield specifies the height of each 2D slice in rows.</para>
        /// <para>The extents of the initialized region are specified as ain bytes,</para>
        /// <para>ain rows, and ain slices.</para>
        /// <para>Extents withgreater than or equal to theof</para>
        /// <para>may perform significantly faster than extents narrower</para>
        /// <para>than theSecondarily, extents withequal to the</para>
        /// <para>ofwill perform faster than when theis</para>
        /// <para>shorter than the</para>
        /// <para>This function performs fastest when thehas been allocated</para>
        /// <para>by ::cudaMalloc3D().</para>
        /// <para>Note that this function is asynchronous with respect to the host unless</para>
        /// <para>refers to pinned host memory.</para>
        /// <para>_memset</para>
        /// <para>::cudaMemset, ::cudaMemset2D,</para>
        /// <para>::cudaMemsetAsync, ::cudaMemset2DAsync, ::cudaMemset3DAsync,</para>
        /// <para>::cudaMalloc3D, ::make_cudaPitchedPtr,</para>
        /// <para>::make_cudaExtent</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemset3D(global::CUDA.CudaPitchedPtr pitchedDevPtr, int value, global::CUDA.CudaExtent extent)
        {
            var __arg0 = ReferenceEquals(pitchedDevPtr, null) ? new global::CUDA.CudaPitchedPtr.__Internal() : *(global::CUDA.CudaPitchedPtr.__Internal*)pitchedDevPtr.__Instance;
            var __arg2 = ReferenceEquals(extent, null) ? new global::CUDA.CudaExtent.__Internal() : *(global::CUDA.CudaExtent.__Internal*)extent.__Instance;
            var __ret = __Internal.CudaMemset3D(__arg0, value, __arg2);
            return __ret;
        }

        /// <summary>Initializes or sets device memory to a value</summary>
        /// <param name="devPtr">- Pointer to device memory</param>
        /// <param name="value">- Value to set for each byte of specified memory</param>
        /// <param name="count">- Size in bytes to set</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// </returns>
        /// <remarks>
        /// <para>Fills the firstbytes of the memory area pointed to bywith the constant byte value</para>
        /// <para>::cudaMemsetAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the memset is complete. The operation can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument.</para>
        /// <para>Ifis non-zero, the operation may overlap with operations in other streams.</para>
        /// <para>The device version of this function only handles device to device copies and</para>
        /// <para>cannot be given local or shared pointers.</para>
        /// <para>_memset</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemset, ::cudaMemset2D, ::cudaMemset3D,</para>
        /// <para>::cudaMemset2DAsync, ::cudaMemset3DAsync,</para>
        /// <para>::cuMemsetD8Async,</para>
        /// <para>::cuMemsetD16Async,</para>
        /// <para>::cuMemsetD32Async</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemsetAsync(global::System.IntPtr devPtr, int value, ulong count, global::CUDA.CUstreamSt stream)
        {
            var __arg3 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemsetAsync(devPtr, value, count, __arg3);
            return __ret;
        }

        /// <summary>Initializes or sets device memory to a value</summary>
        /// <param name="devPtr">- Pointer to 2D device memory</param>
        /// <param name="pitch">- Pitch in bytes of 2D device memory</param>
        /// <param name="value">- Value to set for each byte of specified memory</param>
        /// <param name="width">- Width of matrix set (columns in bytes)</param>
        /// <param name="height">- Height of matrix set (rows)</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// </returns>
        /// <remarks>
        /// <para>Sets to the specified valuea matrix (rows ofbytes each) pointed to byis the width in bytes of the</para>
        /// <para>2D array pointed to byincluding any padding added to the end</para>
        /// <para>of each row. This function performs fastest when the pitch is one that has</para>
        /// <para>been passed back by ::cudaMallocPitch().</para>
        /// <para>::cudaMemset2DAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the memset is complete. The operation can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument.</para>
        /// <para>Ifis non-zero, the operation may overlap with operations in other streams.</para>
        /// <para>The device version of this function only handles device to device copies and</para>
        /// <para>cannot be given local or shared pointers.</para>
        /// <para>_memset</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemset, ::cudaMemset2D, ::cudaMemset3D,</para>
        /// <para>::cudaMemsetAsync, ::cudaMemset3DAsync,</para>
        /// <para>::cuMemsetD2D8Async,</para>
        /// <para>::cuMemsetD2D16Async,</para>
        /// <para>::cuMemsetD2D32Async</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemset2DAsync(global::System.IntPtr devPtr, ulong pitch, int value, ulong width, ulong height, global::CUDA.CUstreamSt stream)
        {
            var __arg5 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemset2DAsync(devPtr, pitch, value, width, height, __arg5);
            return __ret;
        }

        /// <summary>Initializes or sets device memory to a value</summary>
        /// <param name="pitchedDevPtr">- Pointer to pitched device memory</param>
        /// <param name="value">- Value to set for each byte of specified memory</param>
        /// <param name="extent">- Size parameters for where to set device memory (field in bytes)</param>
        /// <param name="stream">- Stream identifier</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// </returns>
        /// <remarks>
        /// <para>Initializes each element of a 3D array to the specified valueThe object to initialize is defined byThefield</para>
        /// <para>ofis the width in memory in bytes of the 3D array pointed</para>
        /// <para>to byincluding any padding added to the end of each row.</para>
        /// <para>Thefield specifies the logical width of each row in bytes, while</para>
        /// <para>thefield specifies the height of each 2D slice in rows.</para>
        /// <para>The extents of the initialized region are specified as ain bytes,</para>
        /// <para>ain rows, and ain slices.</para>
        /// <para>Extents withgreater than or equal to theof</para>
        /// <para>may perform significantly faster than extents narrower</para>
        /// <para>than theSecondarily, extents withequal to the</para>
        /// <para>ofwill perform faster than when theis</para>
        /// <para>shorter than the</para>
        /// <para>This function performs fastest when thehas been allocated</para>
        /// <para>by ::cudaMalloc3D().</para>
        /// <para>::cudaMemset3DAsync() is asynchronous with respect to the host, so</para>
        /// <para>the call may return before the memset is complete. The operation can optionally</para>
        /// <para>be associated to a stream by passing a non-zeroargument.</para>
        /// <para>Ifis non-zero, the operation may overlap with operations in other streams.</para>
        /// <para>The device version of this function only handles device to device copies and</para>
        /// <para>cannot be given local or shared pointers.</para>
        /// <para>_memset</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemset, ::cudaMemset2D, ::cudaMemset3D,</para>
        /// <para>::cudaMemsetAsync, ::cudaMemset2DAsync,</para>
        /// <para>::cudaMalloc3D, ::make_cudaPitchedPtr,</para>
        /// <para>::make_cudaExtent</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemset3DAsync(global::CUDA.CudaPitchedPtr pitchedDevPtr, int value, global::CUDA.CudaExtent extent, global::CUDA.CUstreamSt stream)
        {
            var __arg0 = ReferenceEquals(pitchedDevPtr, null) ? new global::CUDA.CudaPitchedPtr.__Internal() : *(global::CUDA.CudaPitchedPtr.__Internal*)pitchedDevPtr.__Instance;
            var __arg2 = ReferenceEquals(extent, null) ? new global::CUDA.CudaExtent.__Internal() : *(global::CUDA.CudaExtent.__Internal*)extent.__Instance;
            var __arg3 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemset3DAsync(__arg0, value, __arg2, __arg3);
            return __ret;
        }

        /// <summary>Finds the address associated with a CUDA symbol</summary>
        /// <param name="devPtr">- Return device pointer associated with symbol</param>
        /// <param name="symbol">- Device symbol address</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorNoKernelImageForDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe address of symbolon the device.</para>
        /// <para>is a variable that resides in global or constant memory space.</para>
        /// <para>Ifcannot be found, or ifis not declared in the</para>
        /// <para>global or constant memory space,is unchanged and the error</para>
        /// <para>::cudaErrorInvalidSymbol is returned.</para>
        /// <para>_string_api_deprecation</para>
        /// <para>::cuModuleGetGlobal</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetSymbolAddress(void** devPtr, global::System.IntPtr symbol)
        {
            var __ret = __Internal.CudaGetSymbolAddress(devPtr, symbol);
            return __ret;
        }

        /// <summary>Finds the size of the object associated with a CUDA symbol</summary>
        /// <param name="size">- Size of object associated with symbol</param>
        /// <param name="symbol">- Device symbol address</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidSymbol,</para>
        /// <para>::cudaErrorNoKernelImageForDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe size of symbolis a variable that</para>
        /// <para>resides in global or constant memory space. Ifcannot be found, or</para>
        /// <para>ifis not declared in global or constant memory space,is</para>
        /// <para>unchanged and the error ::cudaErrorInvalidSymbol is returned.</para>
        /// <para>_string_api_deprecation</para>
        /// <para>::cuModuleGetGlobal</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetSymbolSize(ref ulong size, global::System.IntPtr symbol)
        {
            fixed (ulong* __refParamPtr0 = &size)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaGetSymbolSize(__arg0, symbol);
                return __ret;
            }
        }

        /// <summary>Prefetches memory to the specified destination device</summary>
        /// <param name="devPtr">- Pointer to be prefetched</param>
        /// <param name="count">- Size in bytes</param>
        /// <param name="dstDevice">- Destination device to prefetch to</param>
        /// <param name="stream">- Stream to enqueue prefetch operation</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Prefetches memory to the specified destination device.is the</para>
        /// <para>base device pointer of the memory to be prefetched andis the</para>
        /// <para>destination device.specifies the number of bytes to copy.is the stream in which the operation is enqueued. The memory range must refer</para>
        /// <para>to managed memory allocated via ::cudaMallocManaged or declared via __managed__ variables.</para>
        /// <para>Passing in cudaCpuDeviceId forwill prefetch the data to host memory. If</para>
        /// <para>is a GPU, then the device attribute ::cudaDevAttrConcurrentManagedAccess</para>
        /// <para>must be non-zero. Additionally,must be associated with a device that has a</para>
        /// <para>non-zero value for the device attribute ::cudaDevAttrConcurrentManagedAccess.</para>
        /// <para>The start address and end address of the memory range will be rounded down and rounded up</para>
        /// <para>respectively to be aligned to CPU page size before the prefetch operation is enqueued</para>
        /// <para>in the stream.</para>
        /// <para>If no physical memory has been allocated for this region, then this memory region</para>
        /// <para>will be populated and mapped on the destination device. If there's insufficient</para>
        /// <para>memory to prefetch the desired region, the Unified Memory driver may evict pages from other</para>
        /// <para>::cudaMallocManaged allocations to host memory in order to make room. Device memory</para>
        /// <para>allocated using ::cudaMalloc or ::cudaMallocArray will not be evicted.</para>
        /// <para>By default, any mappings to the previous location of the migrated pages are removed and</para>
        /// <para>mappings for the new location are only setup onThe exact behavior however</para>
        /// <para>also depends on the settings applied to this memory range via ::cudaMemAdvise as described</para>
        /// <para>below:</para>
        /// <para>If ::cudaMemAdviseSetReadMostly was set on any subset of this memory range,</para>
        /// <para>then that subset will create a read-only copy of the pages on</para>
        /// <para>If ::cudaMemAdviseSetPreferredLocation was called on any subset of this memory</para>
        /// <para>range, then the pages will be migrated toeven ifis not the</para>
        /// <para>preferred location of any pages in the memory range.</para>
        /// <para>If ::cudaMemAdviseSetAccessedBy was called on any subset of this memory range,</para>
        /// <para>then mappings to those pages from all the appropriate processors are updated to</para>
        /// <para>refer to the new location if establishing such a mapping is possible. Otherwise,</para>
        /// <para>those mappings are cleared.</para>
        /// <para>Note that this API is not required for functionality and only serves to improve performance</para>
        /// <para>by allowing the application to migrate data to a suitable location before it is accessed.</para>
        /// <para>Memory accesses to this range are always coherent and are allowed even when the data is</para>
        /// <para>actively being migrated.</para>
        /// <para>Note that this function is asynchronous with respect to the host and all work</para>
        /// <para>on other devices.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpyPeer, ::cudaMemcpyAsync,</para>
        /// <para>::cudaMemcpy3DPeerAsync, ::cudaMemAdvise,</para>
        /// <para>::cuMemPrefetchAsync</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemPrefetchAsync(global::System.IntPtr devPtr, ulong count, int dstDevice, global::CUDA.CUstreamSt stream)
        {
            var __arg3 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaMemPrefetchAsync(devPtr, count, dstDevice, __arg3);
            return __ret;
        }

        /// <summary>Advise about the usage of a given memory range</summary>
        /// <param name="devPtr">- Pointer to memory to set the advice for</param>
        /// <param name="count">- Size in bytes of the memory range</param>
        /// <param name="advice">- Advice to be applied for the specified memory range</param>
        /// <param name="device">- Device to apply the advice for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Advise the Unified Memory subsystem about the usage pattern for the memory range</para>
        /// <para>starting atwith a size ofbytes. The start address and end address of the memory</para>
        /// <para>range will be rounded down and rounded up respectively to be aligned to CPU page size before the</para>
        /// <para>advice is applied. The memory range must refer to managed memory allocated via ::cudaMallocManaged</para>
        /// <para>or declared via __managed__ variables.</para>
        /// <para>Theparameter can take the following values:</para>
        /// <para>- ::cudaMemAdviseSetReadMostly: This implies that the data is mostly going to be read</para>
        /// <para>from and only occasionally written to. Any read accesses from any processor to this region will create a</para>
        /// <para>read-only copy of at least the accessed pages in that processor's memory. Additionally, if ::cudaMemPrefetchAsync</para>
        /// <para>is called on this region, it will create a read-only copy of the data on the destination processor.</para>
        /// <para>If any processor writes to this region, all copies of the corresponding page will be invalidated</para>
        /// <para>except for the one where the write occurred. Theargument is ignored for this advice.</para>
        /// <para>Note that for a page to be read-duplicated, the accessing processor must either be the CPU or a GPU</para>
        /// <para>that has a non-zero value for the device attribute ::cudaDevAttrConcurrentManagedAccess.</para>
        /// <para>Also, if a context is created on a device that does not have the device attribute</para>
        /// <para>::cudaDevAttrConcurrentManagedAccess set, then read-duplication will not occur until</para>
        /// <para>all such contexts are destroyed.</para>
        /// <para>- ::cudaMemAdviceUnsetReadMostly: Undoes the effect of ::cudaMemAdviceReadMostly and also prevents the</para>
        /// <para>Unified Memory driver from attempting heuristic read-duplication on the memory range. Any read-duplicated</para>
        /// <para>copies of the data will be collapsed into a single copy. The location for the collapsed</para>
        /// <para>copy will be the preferred location if the page has a preferred location and one of the read-duplicated</para>
        /// <para>copies was resident at that location. Otherwise, the location chosen is arbitrary.</para>
        /// <para>- ::cudaMemAdviseSetPreferredLocation: This advice sets the preferred location for the</para>
        /// <para>data to be the memory belonging toPassing in cudaCpuDeviceId forsets the</para>
        /// <para>preferred location as host memory. Ifis a GPU, then it must have a non-zero value for the</para>
        /// <para>device attribute ::cudaDevAttrConcurrentManagedAccess. Setting the preferred location</para>
        /// <para>does not cause data to migrate to that location immediately. Instead, it guides the migration policy</para>
        /// <para>when a fault occurs on that memory region. If the data is already in its preferred location and the</para>
        /// <para>faulting processor can establish a mapping without requiring the data to be migrated, then</para>
        /// <para>data migration will be avoided. On the other hand, if the data is not in its preferred location</para>
        /// <para>or if a direct mapping cannot be established, then it will be migrated to the processor accessing</para>
        /// <para>it. It is important to note that setting the preferred location does not prevent data prefetching</para>
        /// <para>done using ::cudaMemPrefetchAsync.</para>
        /// <para>Having a preferred location can override the page thrash detection and resolution logic in the Unified</para>
        /// <para>Memory driver. Normally, if a page is detected to be constantly thrashing between for example host and device</para>
        /// <para>memory, the page may eventually be pinned to host memory by the Unified Memory driver. But</para>
        /// <para>if the preferred location is set as device memory, then the page will continue to thrash indefinitely.</para>
        /// <para>If ::cudaMemAdviseSetReadMostly is also set on this memory region or any subset of it, then the</para>
        /// <para>policies associated with that advice will override the policies of this advice.</para>
        /// <para>- ::cudaMemAdviseUnsetPreferredLocation: Undoes the effect of ::cudaMemAdviseSetPreferredLocation</para>
        /// <para>and changes the preferred location to none.</para>
        /// <para>- ::cudaMemAdviseSetAccessedBy: This advice implies that the data will be accessed byPassing in ::cudaCpuDeviceId forwill set the advice for the CPU. Ifis a GPU, then</para>
        /// <para>the device attribute ::cudaDevAttrConcurrentManagedAccess must be non-zero.</para>
        /// <para>This advice does not cause data migration and has no impact on the location of the data per se. Instead,</para>
        /// <para>it causes the data to always be mapped in the specified processor's page tables, as long as the</para>
        /// <para>location of the data permits a mapping to be established. If the data gets migrated for any reason,</para>
        /// <para>the mappings are updated accordingly.</para>
        /// <para>This advice is recommended in scenarios where data locality is not important, but avoiding faults is.</para>
        /// <para>Consider for example a system containing multiple GPUs with peer-to-peer access enabled, where the</para>
        /// <para>data located on one GPU is occasionally accessed by peer GPUs. In such scenarios, migrating data</para>
        /// <para>over to the other GPUs is not as important because the accesses are infrequent and the overhead of</para>
        /// <para>migration may be too high. But preventing faults can still help improve performance, and so having</para>
        /// <para>a mapping set up in advance is useful. Note that on CPU access of this data, the data may be migrated</para>
        /// <para>to host memory because the CPU typically cannot access device memory directly. Any GPU that had the</para>
        /// <para>::cudaMemAdviceSetAccessedBy flag set for this data will now have its mapping updated to point to the</para>
        /// <para>page in host memory.</para>
        /// <para>If ::cudaMemAdviseSetReadMostly is also set on this memory region or any subset of it, then the</para>
        /// <para>policies associated with that advice will override the policies of this advice. Additionally, if the</para>
        /// <para>preferred location of this memory region or any subset of it is alsothen the policies</para>
        /// <para>associated with ::cudaMemAdviseSetPreferredLocation will override the policies of this advice.</para>
        /// <para>- ::cudaMemAdviseUnsetAccessedBy: Undoes the effect of ::cudaMemAdviseSetAccessedBy. Any mappings to</para>
        /// <para>the data frommay be removed at any time causing accesses to result in non-fatal page faults.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemcpy, ::cudaMemcpyPeer, ::cudaMemcpyAsync,</para>
        /// <para>::cudaMemcpy3DPeerAsync, ::cudaMemPrefetchAsync,</para>
        /// <para>::cuMemAdvise</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemAdvise(global::System.IntPtr devPtr, ulong count, global::CUDA.CudaMemoryAdvise advice, int device)
        {
            var __ret = __Internal.CudaMemAdvise(devPtr, count, advice, device);
            return __ret;
        }

        /// <summary>Query an attribute of a given memory range</summary>
        /// <param name="data">
        /// <para>- A pointers to a memory location where the result</para>
        /// <para>of each attribute query will be written to.</para>
        /// </param>
        /// <param name="dataSize">- Array containing the size of data</param>
        /// <param name="attribute">- The attribute to query</param>
        /// <param name="devPtr">- Start of the range to query</param>
        /// <param name="count">- Size of the range to query</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Query an attribute about the memory range starting atwith a size ofbytes. The</para>
        /// <para>memory range must refer to managed memory allocated via ::cudaMallocManaged or declared via</para>
        /// <para>__managed__ variables.</para>
        /// <para>Theparameter can take the following values:</para>
        /// <para>- ::cudaMemRangeAttributeReadMostly: If this attribute is specified,will be interpreted</para>
        /// <para>as a 32-bit integer, andmust be 4. The result returned will be 1 if all pages in the given</para>
        /// <para>memory range have read-duplication enabled, or 0 otherwise.</para>
        /// <para>- ::cudaMemRangeAttributePreferredLocation: If this attribute is specified,will be</para>
        /// <para>interpreted as a 32-bit integer, andmust be 4. The result returned will be a GPU device</para>
        /// <para>id if all pages in the memory range have that GPU as their preferred location, or it will be cudaCpuDeviceId</para>
        /// <para>if all pages in the memory range have the CPU as their preferred location, or it will be cudaInvalidDeviceId</para>
        /// <para>if either all the pages don't have the same preferred location or some of the pages don't have a</para>
        /// <para>preferred location at all. Note that the actual location of the pages in the memory range at the time of</para>
        /// <para>the query may be different from the preferred location.</para>
        /// <para>- ::cudaMemRangeAttributeAccessedBy: If this attribute is specified,will be interpreted</para>
        /// <para>as an array of 32-bit integers, andmust be a non-zero multiple of 4. The result returned</para>
        /// <para>will be a list of device ids that had ::cudaMemAdviceSetAccessedBy set for that entire memory range.</para>
        /// <para>If any device does not have that advice set for the entire memory range, that device will not be included.</para>
        /// <para>Ifis larger than the number of devices that have that advice set for that memory range,</para>
        /// <para>cudaInvalidDeviceId will be returned in all the extra space provided. For ex., ifis 12</para>
        /// <para>(i.e.has 3 elements) and only device 0 has the advice set, then the result returned will be</para>
        /// <para>{ 0, cudaInvalidDeviceId, cudaInvalidDeviceId }. Ifis smaller than the number of devices that have</para>
        /// <para>that advice set, then only as many devices will be returned as can fit in the array. There is no</para>
        /// <para>guarantee on which specific devices will be returned, however.</para>
        /// <para>- ::cudaMemRangeAttributeLastPrefetchLocation: If this attribute is specified,will be</para>
        /// <para>interpreted as a 32-bit integer, andmust be 4. The result returned will be the last location</para>
        /// <para>to which all pages in the memory range were prefetched explicitly via ::cudaMemPrefetchAsync. This will either be</para>
        /// <para>a GPU id or cudaCpuDeviceId depending on whether the last location for prefetch was a GPU or the CPU</para>
        /// <para>respectively. If any page in the memory range was never explicitly prefetched or if all pages were not</para>
        /// <para>prefetched to the same location, cudaInvalidDeviceId will be returned. Note that this simply returns the</para>
        /// <para>last location that the applicaton requested to prefetch the memory range to. It gives no indication as to</para>
        /// <para>whether the prefetch operation to that location has completed or even begun.</para>
        /// <para>_async</para>
        /// <para>_null_stream</para>
        /// <para>::cudaMemRangeGetAttributes, ::cudaMemPrefetchAsync,</para>
        /// <para>::cudaMemAdvise,</para>
        /// <para>::cuMemRangeGetAttribute</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemRangeGetAttribute(global::System.IntPtr data, ulong dataSize, global::CUDA.CudaMemRangeAttribute attribute, global::System.IntPtr devPtr, ulong count)
        {
            var __ret = __Internal.CudaMemRangeGetAttribute(data, dataSize, attribute, devPtr, count);
            return __ret;
        }

        /// <summary>Query attributes of a given memory range.</summary>
        /// <param name="data">
        /// <para>- A two-dimensional array containing pointers to memory</para>
        /// <para>locations where the result of each attribute query will be written to.</para>
        /// </param>
        /// <param name="dataSizes">- Array containing the sizes of each result</param>
        /// <param name="attributes">
        /// <para>- An array of attributes to query</para>
        /// <para>(numAttributes and the number of attributes in this array should match)</para>
        /// </param>
        /// <param name="numAttributes">- Number of attributes to query</param>
        /// <param name="devPtr">- Start of the range to query</param>
        /// <param name="count">- Size of the range to query</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Query attributes of the memory range starting atwith a size ofbytes. The</para>
        /// <para>memory range must refer to managed memory allocated via ::cudaMallocManaged or declared via</para>
        /// <para>__managed__ variables. Thearray will be interpreted to haveentries. Thearray will also be interpreted to haveentries.</para>
        /// <para>The results of the query will be stored in</para>
        /// <para>The list of supported attributes are given below. Please refer to ::cudaMemRangeGetAttribute for</para>
        /// <para>attribute descriptions and restrictions.</para>
        /// <para>- ::cudaMemRangeAttributeReadMostly</para>
        /// <para>- ::cudaMemRangeAttributePreferredLocation</para>
        /// <para>- ::cudaMemRangeAttributeAccessedBy</para>
        /// <para>- ::cudaMemRangeAttributeLastPrefetchLocation</para>
        /// <para>::cudaMemRangeGetAttribute, ::cudaMemAdvise</para>
        /// <para>::cudaMemPrefetchAsync,</para>
        /// <para>::cuMemRangeGetAttributes</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaMemRangeGetAttributes(void** data, ref ulong dataSizes, global::CUDA.CudaMemRangeAttribute* attributes, ulong numAttributes, global::System.IntPtr devPtr, ulong count)
        {
            fixed (ulong* __refParamPtr1 = &dataSizes)
            {
                var __arg1 = __refParamPtr1;
                var __ret = __Internal.CudaMemRangeGetAttributes(data, __arg1, attributes, numAttributes, devPtr, count);
                return __ret;
            }
        }

        /// <summary>Returns attributes about a specified pointer</summary>
        /// <param name="attributes">- Attributes for the specified pointer</param>
        /// <param name="ptr">- Pointer to get attributes for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe attributes of the pointerIf pointer was not allocated in, mapped by or registered with context</para>
        /// <para>supporting unified addressing ::cudaErrorInvalidValue is returned.</para>
        /// <para>The ::cudaPointerAttributes structure is defined as:</para>
        /// <para>In this structure, the individual fields mean</para>
        /// <para>-</para>
        /// <para>location of the memory associated with pointerIt can be</para>
        /// <para>::cudaMemoryTypeHost for host memory or ::cudaMemoryTypeDevice for device</para>
        /// <para>memory.</para>
        /// <para>-</para>
        /// <para>was allocated.  Ifhas memory type ::cudaMemoryTypeDevice</para>
        /// <para>then this identifies the device on which the memory referred to byphysically resides.  Ifhas memory type ::cudaMemoryTypeHost then this</para>
        /// <para>identifies the device which was current when the allocation was made</para>
        /// <para>(and if that device is deinitialized then this allocation will vanish</para>
        /// <para>with that device's state).</para>
        /// <para>-</para>
        /// <para>the device pointer alias through which the memory referred to bymay be accessed on the current device.</para>
        /// <para>If the memory referred to bycannot be accessed directly by the</para>
        /// <para>current device then this is NULL.</para>
        /// <para>-</para>
        /// <para>the host pointer alias through which the memory referred to bymay be accessed on the host.</para>
        /// <para>If the memory referred to bycannot be accessed directly by the</para>
        /// <para>host then this is NULL.</para>
        /// <para>-</para>
        /// <para>the pointerpoints to managed memory or not.</para>
        /// <para>::cudaGetDeviceCount, ::cudaGetDevice, ::cudaSetDevice,</para>
        /// <para>::cudaChooseDevice,</para>
        /// <para>::cuPointerGetAttributes</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaPointerGetAttributes(global::CUDA.CudaPointerAttributes attributes, global::System.IntPtr ptr)
        {
            var __arg0 = ReferenceEquals(attributes, null) ? global::System.IntPtr.Zero : attributes.__Instance;
            var __ret = __Internal.CudaPointerGetAttributes(__arg0, ptr);
            return __ret;
        }

        /// <summary>Queries if a device may directly access a peer device's memory.</summary>
        /// <param name="canAccessPeer">- Returned access capability</param>
        /// <param name="device">
        /// <para>- Device from which allocations onare to</para>
        /// <para>be directly accessed.</para>
        /// </param>
        /// <param name="peerDevice">
        /// <para>- Device on which the allocations to be directly accessed</para>
        /// <para>byreside.</para>
        /// </param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns ina value of 1 if deviceis capable of</para>
        /// <para>directly accessing memory fromand 0 otherwise.  If direct</para>
        /// <para>access offromis possible, then access may be</para>
        /// <para>enabled by calling ::cudaDeviceEnablePeerAccess().</para>
        /// <para>::cudaDeviceEnablePeerAccess,</para>
        /// <para>::cudaDeviceDisablePeerAccess,</para>
        /// <para>::cuDeviceCanAccessPeer</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceCanAccessPeer(ref int canAccessPeer, int device, int peerDevice)
        {
            fixed (int* __refParamPtr0 = &canAccessPeer)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaDeviceCanAccessPeer(__arg0, device, peerDevice);
                return __ret;
            }
        }

        /// <summary>Enables direct access to memory allocations on a peer device.</summary>
        /// <param name="peerDevice">- Peer device to enable direct access to from the current device</param>
        /// <param name="flags">- Reserved for future use and must be set to 0</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidDevice,</para>
        /// <para>::cudaErrorPeerAccessAlreadyEnabled,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>On success, all allocations fromwill immediately be accessible by</para>
        /// <para>the current device.  They will remain accessible until access is explicitly</para>
        /// <para>disabled using ::cudaDeviceDisablePeerAccess() or either device is reset using</para>
        /// <para>::cudaDeviceReset().</para>
        /// <para>Note that access granted by this call is unidirectional and that in order to access</para>
        /// <para>memory on the current device froma separate symmetric call</para>
        /// <para>to ::cudaDeviceEnablePeerAccess() is required.</para>
        /// <para>Each device can support a system-wide maximum of eight peer connections.</para>
        /// <para>Peer access is not supported in 32 bit applications.</para>
        /// <para>Returns ::cudaErrorInvalidDevice if ::cudaDeviceCanAccessPeer() indicates</para>
        /// <para>that the current device cannot directly access memory from</para>
        /// <para>Returns ::cudaErrorPeerAccessAlreadyEnabled if direct access of</para>
        /// <para>from the current device has already been enabled.</para>
        /// <para>Returns ::cudaErrorInvalidValue ifis not 0.</para>
        /// <para>::cudaDeviceCanAccessPeer,</para>
        /// <para>::cudaDeviceDisablePeerAccess,</para>
        /// <para>::cuCtxEnablePeerAccess</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceEnablePeerAccess(int peerDevice, uint flags)
        {
            var __ret = __Internal.CudaDeviceEnablePeerAccess(peerDevice, flags);
            return __ret;
        }

        /// <summary>Disables direct access to memory allocations on a peer device.</summary>
        /// <param name="peerDevice">- Peer device to disable direct access to</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorPeerAccessNotEnabled,</para>
        /// <para>::cudaErrorInvalidDevice</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns ::cudaErrorPeerAccessNotEnabled if direct access to memory on</para>
        /// <para>has not yet been enabled from the current device.</para>
        /// <para>::cudaDeviceCanAccessPeer,</para>
        /// <para>::cudaDeviceEnablePeerAccess,</para>
        /// <para>::cuCtxDisablePeerAccess</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDeviceDisablePeerAccess(int peerDevice)
        {
            var __ret = __Internal.CudaDeviceDisablePeerAccess(peerDevice);
            return __ret;
        }

        /// <summary>Unregisters a graphics resource for access by CUDA</summary>
        /// <param name="resource">- Resource to unregister</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorUnknown</para>
        /// </returns>
        /// <remarks>
        /// <para>Unregisters the graphics resourceso it is not accessible by</para>
        /// <para>CUDA unless registered again.</para>
        /// <para>Ifis invalid then ::cudaErrorInvalidResourceHandle is</para>
        /// <para>returned.</para>
        /// <para>::cudaGraphicsD3D9RegisterResource,</para>
        /// <para>::cudaGraphicsD3D10RegisterResource,</para>
        /// <para>::cudaGraphicsD3D11RegisterResource,</para>
        /// <para>::cudaGraphicsGLRegisterBuffer,</para>
        /// <para>::cudaGraphicsGLRegisterImage,</para>
        /// <para>::cuGraphicsUnregisterResource</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGraphicsUnregisterResource(global::CUDA.CudaGraphicsResource resource)
        {
            var __arg0 = ReferenceEquals(resource, null) ? global::System.IntPtr.Zero : resource.__Instance;
            var __ret = __Internal.CudaGraphicsUnregisterResource(__arg0);
            return __ret;
        }

        /// <summary>Set usage flags for mapping a graphics resource</summary>
        /// <param name="resource">- Registered resource to set flags for</param>
        /// <param name="flags">- Parameters for resource mapping</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorUnknown,</para>
        /// </returns>
        /// <remarks>
        /// <para>Setfor mapping the graphics resource</para>
        /// <para>Changes towill take effect the next timeis mapped.</para>
        /// <para>Theargument may be any of the following:</para>
        /// <para>- ::cudaGraphicsMapFlagsNone: Specifies no hints about howwill</para>
        /// <para>be used. It is therefore assumed that CUDA may read from or write to- ::cudaGraphicsMapFlagsReadOnly: Specifies that CUDA will not write to- ::cudaGraphicsMapFlagsWriteDiscard: Specifies CUDA will not read fromand will</para>
        /// <para>write over the entire contents ofso none of the data</para>
        /// <para>previously stored inwill be preserved.</para>
        /// <para>Ifis presently mapped for access by CUDA then ::cudaErrorUnknown is returned.</para>
        /// <para>Ifis not one of the above values then ::cudaErrorInvalidValue is returned.</para>
        /// <para>::cudaGraphicsMapResources,</para>
        /// <para>::cuGraphicsResourceSetMapFlags</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGraphicsResourceSetMapFlags(global::CUDA.CudaGraphicsResource resource, uint flags)
        {
            var __arg0 = ReferenceEquals(resource, null) ? global::System.IntPtr.Zero : resource.__Instance;
            var __ret = __Internal.CudaGraphicsResourceSetMapFlags(__arg0, flags);
            return __ret;
        }

        /// <summary>Map graphics resources for access by CUDA</summary>
        /// <param name="count">- Number of resources to map</param>
        /// <param name="resources">- Resources to map for CUDA</param>
        /// <param name="stream">- Stream for synchronization</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorUnknown</para>
        /// </returns>
        /// <remarks>
        /// <para>Maps thegraphics resources infor access by CUDA.</para>
        /// <para>The resources inmay be accessed by CUDA until they</para>
        /// <para>are unmapped. The graphics API from whichwere registered</para>
        /// <para>should not access any resources while they are mapped by CUDA. If an</para>
        /// <para>application does so, the results are undefined.</para>
        /// <para>This function provides the synchronization guarantee that any graphics calls</para>
        /// <para>issued before ::cudaGraphicsMapResources() will complete before any subsequent CUDA</para>
        /// <para>work issued inbegins.</para>
        /// <para>Ifcontains any duplicate entries then ::cudaErrorInvalidResourceHandle</para>
        /// <para>is returned. If any ofare presently mapped for access by</para>
        /// <para>CUDA then ::cudaErrorUnknown is returned.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaGraphicsResourceGetMappedPointer,</para>
        /// <para>::cudaGraphicsSubResourceGetMappedArray,</para>
        /// <para>::cudaGraphicsUnmapResources,</para>
        /// <para>::cuGraphicsMapResources</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGraphicsMapResources(int count, global::CUDA.CudaGraphicsResource resources, global::CUDA.CUstreamSt stream)
        {
            var __arg1 = ReferenceEquals(resources, null) ? global::System.IntPtr.Zero : resources.__Instance;
            var __arg2 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaGraphicsMapResources(count, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Unmap graphics resources.</summary>
        /// <param name="count">- Number of resources to unmap</param>
        /// <param name="resources">- Resources to unmap</param>
        /// <param name="stream">- Stream for synchronization</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorUnknown</para>
        /// </returns>
        /// <remarks>
        /// <para>Unmaps thegraphics resources in</para>
        /// <para>Once unmapped, the resources inmay not be accessed by CUDA</para>
        /// <para>until they are mapped again.</para>
        /// <para>This function provides the synchronization guarantee that any CUDA work issued</para>
        /// <para>inbefore ::cudaGraphicsUnmapResources() will complete before any</para>
        /// <para>subsequently issued graphics work begins.</para>
        /// <para>Ifcontains any duplicate entries then ::cudaErrorInvalidResourceHandle</para>
        /// <para>is returned. If any ofare not presently mapped for access by</para>
        /// <para>CUDA then ::cudaErrorUnknown is returned.</para>
        /// <para>_null_stream</para>
        /// <para>::cudaGraphicsMapResources,</para>
        /// <para>::cuGraphicsUnmapResources</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGraphicsUnmapResources(int count, global::CUDA.CudaGraphicsResource resources, global::CUDA.CUstreamSt stream)
        {
            var __arg1 = ReferenceEquals(resources, null) ? global::System.IntPtr.Zero : resources.__Instance;
            var __arg2 = ReferenceEquals(stream, null) ? global::System.IntPtr.Zero : stream.__Instance;
            var __ret = __Internal.CudaGraphicsUnmapResources(count, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Get an device pointer through which to access a mapped graphics resource.</summary>
        /// <param name="devPtr">- Returned pointer through whichmay be accessed</param>
        /// <param name="size">- Returned size of the buffer accessible starting at</param>
        /// <param name="resource">- Mapped resource to access</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorUnknown</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns ina pointer through which the mapped graphics resource</para>
        /// <para>may be accessed.</para>
        /// <para>Returns inthe size of the memory in bytes which may be accessed from that pointer.</para>
        /// <para>The value set inmay change every time thatis mapped.</para>
        /// <para>Ifis not a buffer then it cannot be accessed via a pointer and</para>
        /// <para>::cudaErrorUnknown is returned.</para>
        /// <para>Ifis not mapped then ::cudaErrorUnknown is returned.</para>
        /// <para>*</para>
        /// <para>::cudaGraphicsMapResources,</para>
        /// <para>::cudaGraphicsSubResourceGetMappedArray,</para>
        /// <para>::cuGraphicsResourceGetMappedPointer</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGraphicsResourceGetMappedPointer(void** devPtr, ref ulong size, global::CUDA.CudaGraphicsResource resource)
        {
            fixed (ulong* __refParamPtr1 = &size)
            {
                var __arg1 = __refParamPtr1;
                var __arg2 = ReferenceEquals(resource, null) ? global::System.IntPtr.Zero : resource.__Instance;
                var __ret = __Internal.CudaGraphicsResourceGetMappedPointer(devPtr, __arg1, __arg2);
                return __ret;
            }
        }

        /// <summary>Get an array through which to access a subresource of a mapped graphics resource.</summary>
        /// <param name="array">- Returned array through which a subresource ofmay be accessed</param>
        /// <param name="resource">- Mapped resource to access</param>
        /// <param name="arrayIndex">
        /// <para>- Array index for array textures or cubemap face</para>
        /// <para>index as defined by ::cudaGraphicsCubeFace for</para>
        /// <para>cubemap textures for the subresource to access</para>
        /// </param>
        /// <param name="mipLevel">- Mipmap level for the subresource to access</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorUnknown</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inan array through which the subresource of the mapped</para>
        /// <para>graphics resourcewhich corresponds to array indexand mipmap levelmay be accessed.  The value set inmay</para>
        /// <para>change every time thatis mapped.</para>
        /// <para>Ifis not a texture then it cannot be accessed via an array and</para>
        /// <para>::cudaErrorUnknown is returned.</para>
        /// <para>Ifis not a valid array index forthen</para>
        /// <para>::cudaErrorInvalidValue is returned.</para>
        /// <para>Ifis not a valid mipmap level forthen</para>
        /// <para>::cudaErrorInvalidValue is returned.</para>
        /// <para>Ifis not mapped then ::cudaErrorUnknown is returned.</para>
        /// <para>::cudaGraphicsResourceGetMappedPointer,</para>
        /// <para>::cuGraphicsSubResourceGetMappedArray</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGraphicsSubResourceGetMappedArray(global::CUDA.CudaArray array, global::CUDA.CudaGraphicsResource resource, uint arrayIndex, uint mipLevel)
        {
            var __arg0 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg1 = ReferenceEquals(resource, null) ? global::System.IntPtr.Zero : resource.__Instance;
            var __ret = __Internal.CudaGraphicsSubResourceGetMappedArray(__arg0, __arg1, arrayIndex, mipLevel);
            return __ret;
        }

        /// <summary>Get a mipmapped array through which to access a mapped graphics resource.</summary>
        /// <param name="mipmappedArray">- Returned mipmapped array through whichmay be accessed</param>
        /// <param name="resource">- Mapped resource to access</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidResourceHandle,</para>
        /// <para>::cudaErrorUnknown</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns ina mipmapped array through which the mapped</para>
        /// <para>graphics resourcemay be accessed. The value set inmay</para>
        /// <para>change every time thatis mapped.</para>
        /// <para>Ifis not a texture then it cannot be accessed via an array and</para>
        /// <para>::cudaErrorUnknown is returned.</para>
        /// <para>Ifis not mapped then ::cudaErrorUnknown is returned.</para>
        /// <para>::cudaGraphicsResourceGetMappedPointer,</para>
        /// <para>::cuGraphicsResourceGetMappedMipmappedArray</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGraphicsResourceGetMappedMipmappedArray(global::CUDA.CudaMipmappedArray mipmappedArray, global::CUDA.CudaGraphicsResource resource)
        {
            var __arg0 = ReferenceEquals(mipmappedArray, null) ? global::System.IntPtr.Zero : mipmappedArray.__Instance;
            var __arg1 = ReferenceEquals(resource, null) ? global::System.IntPtr.Zero : resource.__Instance;
            var __ret = __Internal.CudaGraphicsResourceGetMappedMipmappedArray(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Get the channel descriptor of an array</summary>
        /// <param name="desc">- Channel format</param>
        /// <param name="array">- Memory array on device</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe channel descriptor of the CUDA array</para>
        /// <para>::cudaGetTextureReference,</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetChannelDesc(global::CUDA.CudaChannelFormatDesc desc, global::CUDA.CudaArray array)
        {
            var __arg0 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __arg1 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __ret = __Internal.CudaGetChannelDesc(__arg0, __arg1);
            return __ret;
        }

        /// <summary>Returns a channel descriptor using the specified format</summary>
        /// <param name="x">- X component</param>
        /// <param name="y">- Y component</param>
        /// <param name="z">- Z component</param>
        /// <param name="w">- W component</param>
        /// <param name="f">- Channel format</param>
        /// <returns>Channel descriptor with format</returns>
        /// <remarks>
        /// <para>Returns a channel descriptor with formatand number of bits of each</para>
        /// <para>componentandThe ::cudaChannelFormatDesc is</para>
        /// <para>defined as:</para>
        /// <para>where ::cudaChannelFormatKind is one of ::cudaChannelFormatKindSigned,</para>
        /// <para>::cudaChannelFormatKindUnsigned, or ::cudaChannelFormatKindFloat.</para>
        /// <para>::cudaGetChannelDesc, ::cudaGetTextureReference,</para>
        /// <para>::cuTexRefSetFormat</para>
        /// </remarks>
        public static global::CUDA.CudaChannelFormatDesc CudaCreateChannelDesc(int x, int y, int z, int w, global::CUDA.CudaChannelFormatKind f)
        {
            var __ret = new global::CUDA.CudaChannelFormatDesc.__Internal();
            __Internal.CudaCreateChannelDesc(new IntPtr(&__ret), x, y, z, w, f);
            return global::CUDA.CudaChannelFormatDesc.__CreateInstance(__ret);
        }

        /// <summary>Binds a memory area to a texture</summary>
        /// <param name="offset">- Offset in bytes</param>
        /// <param name="texref">- Texture to bind</param>
        /// <param name="devPtr">- Memory area on device</param>
        /// <param name="desc">- Channel format</param>
        /// <param name="size">- Size of the memory area pointed to by devPtr</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidTexture</para>
        /// </returns>
        /// <remarks>
        /// <para>Bindsbytes of the memory area pointed to byto the</para>
        /// <para>texture referencedescribes how the memory is interpreted</para>
        /// <para>when fetching values from the texture. Any memory previously bound to</para>
        /// <para>is unbound.</para>
        /// <para>Since the hardware enforces an alignment requirement on texture base</para>
        /// <para>addresses,</para>
        /// <para>returns ina byte offset that</para>
        /// <para>must be applied to texture fetches in order to read from the desired memory.</para>
        /// <para>This offset must be divided by the texel size and passed to kernels that</para>
        /// <para>read from the texture so they can be applied to the ::tex1Dfetch() function.</para>
        /// <para>If the device memory pointer was returned from ::cudaMalloc(), the offset is</para>
        /// <para>guaranteed to be 0 and NULL may be passed as theparameter.</para>
        /// <para>The total number of elements (or texels) in the linear address range</para>
        /// <para>cannot exceed ::cudaDeviceProp::maxTexture1DLinear[0].</para>
        /// <para>The number of elements is computed as (/ elementSize),</para>
        /// <para>where elementSize is determined from</para>
        /// <para>::cudaGetChannelDesc, ::cudaGetTextureReference,</para>
        /// <para>::cuTexRefSetAddress,</para>
        /// <para>::cuTexRefSetAddressMode,</para>
        /// <para>::cuTexRefSetFormat,</para>
        /// <para>::cuTexRefSetFlags,</para>
        /// <para>::cuTexRefSetBorderColor</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaBindTexture(ref ulong offset, global::CUDA.TextureReference texref, global::System.IntPtr devPtr, global::CUDA.CudaChannelFormatDesc desc, ulong size)
        {
            fixed (ulong* __refParamPtr0 = &offset)
            {
                var __arg0 = __refParamPtr0;
                var __arg1 = ReferenceEquals(texref, null) ? global::System.IntPtr.Zero : texref.__Instance;
                var __arg3 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
                var __ret = __Internal.CudaBindTexture(__arg0, __arg1, devPtr, __arg3, size);
                return __ret;
            }
        }

        /// <summary>Binds a 2D memory area to a texture</summary>
        /// <param name="offset">- Offset in bytes</param>
        /// <param name="texref">- Texture reference to bind</param>
        /// <param name="devPtr">- 2D memory area on device</param>
        /// <param name="desc">- Channel format</param>
        /// <param name="width">- Width in texel units</param>
        /// <param name="height">- Height in texel units</param>
        /// <param name="pitch">- Pitch in bytes</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidTexture</para>
        /// </returns>
        /// <remarks>
        /// <para>Binds the 2D memory area pointed to byto the</para>
        /// <para>texture referenceThe size of the area is constrained by</para>
        /// <para>in texel units,in texel units, andin byte</para>
        /// <para>units.describes how the memory is interpreted when fetching values</para>
        /// <para>from the texture. Any memory previously bound tois unbound.</para>
        /// <para>Since the hardware enforces an alignment requirement on texture base</para>
        /// <para>addresses, ::cudaBindTexture2D() returns ina byte offset that</para>
        /// <para>must be applied to texture fetches in order to read from the desired memory.</para>
        /// <para>This offset must be divided by the texel size and passed to kernels that</para>
        /// <para>read from the texture so they can be applied to the ::tex2D() function.</para>
        /// <para>If the device memory pointer was returned from ::cudaMalloc(), the offset is</para>
        /// <para>guaranteed to be 0 and NULL may be passed as theparameter.</para>
        /// <para>andwhich are specified in elements (or texels), cannot</para>
        /// <para>exceed ::cudaDeviceProp::maxTexture2DLinear[0] and ::cudaDeviceProp::maxTexture2DLinear[1]</para>
        /// <para>respectively.which is specified in bytes, cannot exceed</para>
        /// <para>::cudaDeviceProp::maxTexture2DLinear[2].</para>
        /// <para>The driver returns ::cudaErrorInvalidValue ifis not a multiple of</para>
        /// <para>::cudaDeviceProp::texturePitchAlignment.</para>
        /// <para>::cudaGetChannelDesc, ::cudaGetTextureReference,</para>
        /// <para>::cuTexRefSetAddress2D,</para>
        /// <para>::cuTexRefSetFormat,</para>
        /// <para>::cuTexRefSetFlags,</para>
        /// <para>::cuTexRefSetAddressMode,</para>
        /// <para>::cuTexRefSetBorderColor</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaBindTexture2D(ref ulong offset, global::CUDA.TextureReference texref, global::System.IntPtr devPtr, global::CUDA.CudaChannelFormatDesc desc, ulong width, ulong height, ulong pitch)
        {
            fixed (ulong* __refParamPtr0 = &offset)
            {
                var __arg0 = __refParamPtr0;
                var __arg1 = ReferenceEquals(texref, null) ? global::System.IntPtr.Zero : texref.__Instance;
                var __arg3 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
                var __ret = __Internal.CudaBindTexture2D(__arg0, __arg1, devPtr, __arg3, width, height, pitch);
                return __ret;
            }
        }

        /// <summary>Binds an array to a texture</summary>
        /// <param name="texref">- Texture to bind</param>
        /// <param name="array">- Memory array on device</param>
        /// <param name="desc">- Channel format</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidTexture</para>
        /// </returns>
        /// <remarks>
        /// <para>Binds the CUDA arrayto the texture referencedescribes how the memory is interpreted when fetching values from</para>
        /// <para>the texture. Any CUDA array previously bound tois unbound.</para>
        /// <para>::cudaGetChannelDesc, ::cudaGetTextureReference,</para>
        /// <para>::cuTexRefSetArray,</para>
        /// <para>::cuTexRefSetFormat,</para>
        /// <para>::cuTexRefSetFlags,</para>
        /// <para>::cuTexRefSetAddressMode,</para>
        /// <para>::cuTexRefSetFilterMode,</para>
        /// <para>::cuTexRefSetBorderColor,</para>
        /// <para>::cuTexRefSetMaxAnisotropy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaBindTextureToArray(global::CUDA.TextureReference texref, global::CUDA.CudaArray array, global::CUDA.CudaChannelFormatDesc desc)
        {
            var __arg0 = ReferenceEquals(texref, null) ? global::System.IntPtr.Zero : texref.__Instance;
            var __arg1 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg2 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __ret = __Internal.CudaBindTextureToArray(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Binds a mipmapped array to a texture</summary>
        /// <param name="texref">- Texture to bind</param>
        /// <param name="mipmappedArray">- Memory mipmapped array on device</param>
        /// <param name="desc">- Channel format</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidTexture</para>
        /// </returns>
        /// <remarks>
        /// <para>Binds the CUDA mipmapped arrayto the texture referencedescribes how the memory is interpreted when fetching values from</para>
        /// <para>the texture. Any CUDA mipmapped array previously bound tois unbound.</para>
        /// <para>::cudaGetChannelDesc, ::cudaGetTextureReference,</para>
        /// <para>::cuTexRefSetMipmappedArray,</para>
        /// <para>::cuTexRefSetMipmapFilterMode</para>
        /// <para>::cuTexRefSetMipmapLevelClamp,</para>
        /// <para>::cuTexRefSetMipmapLevelBias,</para>
        /// <para>::cuTexRefSetFormat,</para>
        /// <para>::cuTexRefSetFlags,</para>
        /// <para>::cuTexRefSetAddressMode,</para>
        /// <para>::cuTexRefSetBorderColor,</para>
        /// <para>::cuTexRefSetMaxAnisotropy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaBindTextureToMipmappedArray(global::CUDA.TextureReference texref, global::CUDA.CudaMipmappedArray mipmappedArray, global::CUDA.CudaChannelFormatDesc desc)
        {
            var __arg0 = ReferenceEquals(texref, null) ? global::System.IntPtr.Zero : texref.__Instance;
            var __arg1 = ReferenceEquals(mipmappedArray, null) ? global::System.IntPtr.Zero : mipmappedArray.__Instance;
            var __arg2 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __ret = __Internal.CudaBindTextureToMipmappedArray(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Unbinds a texture</summary>
        /// <param name="texref">- Texture to unbind</param>
        /// <returns>::cudaSuccess</returns>
        /// <remarks>
        /// <para>Unbinds the texture bound to</para>
        /// <para>::cudaGetChannelDesc, ::cudaGetTextureReference,</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaUnbindTexture(global::CUDA.TextureReference texref)
        {
            var __arg0 = ReferenceEquals(texref, null) ? global::System.IntPtr.Zero : texref.__Instance;
            var __ret = __Internal.CudaUnbindTexture(__arg0);
            return __ret;
        }

        /// <summary>Get the alignment offset of a texture</summary>
        /// <param name="offset">- Offset of texture reference in bytes</param>
        /// <param name="texref">- Texture to get offset of</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidTexture,</para>
        /// <para>::cudaErrorInvalidTextureBinding</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe offset that was returned when texture reference</para>
        /// <para>was bound.</para>
        /// <para>::cudaGetChannelDesc, ::cudaGetTextureReference,</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetTextureAlignmentOffset(ref ulong offset, global::CUDA.TextureReference texref)
        {
            fixed (ulong* __refParamPtr0 = &offset)
            {
                var __arg0 = __refParamPtr0;
                var __arg1 = ReferenceEquals(texref, null) ? global::System.IntPtr.Zero : texref.__Instance;
                var __ret = __Internal.CudaGetTextureAlignmentOffset(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Get the texture reference associated with a symbol</summary>
        /// <param name="texref">- Texture reference associated with symbol</param>
        /// <param name="symbol">- Texture to get reference for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidTexture</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe structure associated to the texture reference</para>
        /// <para>defined by symbol</para>
        /// <para>_string_api_deprecation_50</para>
        /// <para>::cudaGetChannelDesc,</para>
        /// <para>::cuModuleGetTexRef</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetTextureReference(global::CUDA.TextureReference texref, global::System.IntPtr symbol)
        {
            var __arg0 = ReferenceEquals(texref, null) ? global::System.IntPtr.Zero : texref.__Instance;
            var __ret = __Internal.CudaGetTextureReference(__arg0, symbol);
            return __ret;
        }

        /// <summary>Binds an array to a surface</summary>
        /// <param name="surfref">- Surface to bind</param>
        /// <param name="array">- Memory array on device</param>
        /// <param name="desc">- Channel format</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue,</para>
        /// <para>::cudaErrorInvalidSurface</para>
        /// </returns>
        /// <remarks>
        /// <para>Binds the CUDA arrayto the surface referencedescribes how the memory is interpreted when fetching values from</para>
        /// <para>the surface. Any CUDA array previously bound tois unbound.</para>
        /// <para>::cudaGetSurfaceReference,</para>
        /// <para>::cuSurfRefSetArray</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaBindSurfaceToArray(global::CUDA.SurfaceReference surfref, global::CUDA.CudaArray array, global::CUDA.CudaChannelFormatDesc desc)
        {
            var __arg0 = ReferenceEquals(surfref, null) ? global::System.IntPtr.Zero : surfref.__Instance;
            var __arg1 = ReferenceEquals(array, null) ? global::System.IntPtr.Zero : array.__Instance;
            var __arg2 = ReferenceEquals(desc, null) ? global::System.IntPtr.Zero : desc.__Instance;
            var __ret = __Internal.CudaBindSurfaceToArray(__arg0, __arg1, __arg2);
            return __ret;
        }

        /// <summary>Get the surface reference associated with a symbol</summary>
        /// <param name="surfref">- Surface reference associated with symbol</param>
        /// <param name="symbol">- Surface to get reference for</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidSurface</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe structure associated to the surface reference</para>
        /// <para>defined by symbol</para>
        /// <para>_string_api_deprecation_50</para>
        /// <para>::cuModuleGetSurfRef</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetSurfaceReference(global::CUDA.SurfaceReference surfref, global::System.IntPtr symbol)
        {
            var __arg0 = ReferenceEquals(surfref, null) ? global::System.IntPtr.Zero : surfref.__Instance;
            var __ret = __Internal.CudaGetSurfaceReference(__arg0, symbol);
            return __ret;
        }

        /// <summary>Creates a texture object</summary>
        /// <param name="pTexObject">- Texture object to create</param>
        /// <param name="pResDesc">- Resource descriptor</param>
        /// <param name="pTexDesc">- Texture descriptor</param>
        /// <param name="pResViewDesc">- Resource view descriptor</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates a texture object and returns it indescribes</para>
        /// <para>the data to texture from.describes how the data should be sampled.</para>
        /// <para>is an optional argument that specifies an alternate format for</para>
        /// <para>the data described byand also describes the subresource region</para>
        /// <para>to restrict access to when texturing.can only be specified if</para>
        /// <para>the type of resource is a CUDA array or a CUDA mipmapped array.</para>
        /// <para>Texture objects are only supported on devices of compute capability 3.0 or higher.</para>
        /// <para>Additionally, a texture object is an opaque value, and, as such, should only be</para>
        /// <para>accessed through CUDA API calls.</para>
        /// <para>The ::cudaResourceDesc structure is defined as:</para>
        /// <para>where:</para>
        /// <para>- ::cudaResourceDesc::resType specifies the type of resource to texture from.</para>
        /// <para>CUresourceType is defined as:</para>
        /// <para>If ::cudaResourceDesc::resType is set to ::cudaResourceTypeArray, ::cudaResourceDesc::res::array::array</para>
        /// <para>must be set to a valid CUDA array handle.</para>
        /// <para>If ::cudaResourceDesc::resType is set to ::cudaResourceTypeMipmappedArray, ::cudaResourceDesc::res::mipmap::mipmap</para>
        /// <para>must be set to a valid CUDA mipmapped array handle and ::cudaTextureDesc::normalizedCoords must be set to true.</para>
        /// <para>If ::cudaResourceDesc::resType is set to ::cudaResourceTypeLinear, ::cudaResourceDesc::res::linear::devPtr</para>
        /// <para>must be set to a valid device pointer, that is aligned to ::cudaDeviceProp::textureAlignment.</para>
        /// <para>::cudaResourceDesc::res::linear::desc describes the format and the number of components per array element. ::cudaResourceDesc::res::linear::sizeInBytes</para>
        /// <para>specifies the size of the array in bytes. The total number of elements in the linear address range cannot exceed</para>
        /// <para>::cudaDeviceProp::maxTexture1DLinear. The number of elements is computed as (sizeInBytes / sizeof(desc)).</para>
        /// <para>If ::cudaResourceDesc::resType is set to ::cudaResourceTypePitch2D, ::cudaResourceDesc::res::pitch2D::devPtr</para>
        /// <para>must be set to a valid device pointer, that is aligned to ::cudaDeviceProp::textureAlignment.</para>
        /// <para>::cudaResourceDesc::res::pitch2D::desc describes the format and the number of components per array element. ::cudaResourceDesc::res::pitch2D::width</para>
        /// <para>and ::cudaResourceDesc::res::pitch2D::height specify the width and height of the array in elements, and cannot exceed</para>
        /// <para>::cudaDeviceProp::maxTexture2DLinear[0] and ::cudaDeviceProp::maxTexture2DLinear[1] respectively.</para>
        /// <para>::cudaResourceDesc::res::pitch2D::pitchInBytes specifies the pitch between two rows in bytes and has to be aligned to</para>
        /// <para>::cudaDeviceProp::texturePitchAlignment. Pitch cannot exceed ::cudaDeviceProp::maxTexture2DLinear[2].</para>
        /// <para>The ::cudaTextureDesc struct is defined as</para>
        /// <para>where</para>
        /// <para>- ::cudaTextureDesc::addressMode specifies the addressing mode for each dimension of the texture data. ::cudaTextureAddressMode is defined as:</para>
        /// <para>This is ignored if ::cudaResourceDesc::resType is ::cudaResourceTypeLinear. Also, if ::cudaTextureDesc::normalizedCoords</para>
        /// <para>is set to zero, ::cudaAddressModeWrap and ::cudaAddressModeMirror won't be supported and will be switched to ::cudaAddressModeClamp.</para>
        /// <para>- ::cudaTextureDesc::filterMode specifies the filtering mode to be used when fetching from the texture. ::cudaTextureFilterMode is defined as:</para>
        /// <para>This is ignored if ::cudaResourceDesc::resType is ::cudaResourceTypeLinear.</para>
        /// <para>- ::cudaTextureDesc::readMode specifies whether integer data should be converted to floating point or not. ::cudaTextureReadMode is defined as:</para>
        /// <para>Note that this applies only to 8-bit and 16-bit integer formats. 32-bit integer format would not be promoted, regardless of</para>
        /// <para>whether or not this ::cudaTextureDesc::readMode is set ::cudaReadModeNormalizedFloat is specified.</para>
        /// <para>- ::cudaTextureDesc::sRGB specifies whether sRGB to linear conversion should be performed during texture fetch.</para>
        /// <para>- ::cudaTextureDesc::borderColor specifies the float values of color. where:</para>
        /// <para>::cudaTextureDesc::borderColor[0] contains value of 'R',</para>
        /// <para>::cudaTextureDesc::borderColor[1] contains value of 'G',</para>
        /// <para>::cudaTextureDesc::borderColor[2] contains value of 'B',</para>
        /// <para>::cudaTextureDesc::borderColor[3] contains value of 'A'</para>
        /// <para>Note that application using integer border color values will need to_cast&gt; these values to float.</para>
        /// <para>The values are set only when the addressing mode specified by ::cudaTextureDesc::addressMode is cudaAddressModeBorder.</para>
        /// <para>- ::cudaTextureDesc::normalizedCoords specifies whether the texture coordinates will be normalized or not.</para>
        /// <para>- ::cudaTextureDesc::maxAnisotropy specifies the maximum anistropy ratio to be used when doing anisotropic filtering. This value will be</para>
        /// <para>clamped to the range [1,16].</para>
        /// <para>- ::cudaTextureDesc::mipmapFilterMode specifies the filter mode when the calculated mipmap level lies between two defined mipmap levels.</para>
        /// <para>- ::cudaTextureDesc::mipmapLevelBias specifies the offset to be applied to the calculated mipmap level.</para>
        /// <para>- ::cudaTextureDesc::minMipmapLevelClamp specifies the lower end of the mipmap level range to clamp access to.</para>
        /// <para>- ::cudaTextureDesc::maxMipmapLevelClamp specifies the upper end of the mipmap level range to clamp access to.</para>
        /// <para>The ::cudaResourceViewDesc struct is defined as</para>
        /// <para>where:</para>
        /// <para>- ::cudaResourceViewDesc::format specifies how the data contained in the CUDA array or CUDA mipmapped array should</para>
        /// <para>be interpreted. Note that this can incur a change in size of the texture data. If the resource view format is a block</para>
        /// <para>compressed format, then the underlying CUDA array or CUDA mipmapped array has to have a 32-bit unsigned integer format</para>
        /// <para>with 2 or 4 channels, depending on the block compressed format. For ex., BC1 and BC4 require the underlying CUDA array to have</para>
        /// <para>a 32-bit unsigned int with 2 channels. The other BC formats require the underlying resource to have the same 32-bit unsigned int</para>
        /// <para>format but with 4 channels.</para>
        /// <para>- ::cudaResourceViewDesc::width specifies the new width of the texture data. If the resource view format is a block</para>
        /// <para>compressed format, this value has to be 4 times the original width of the resource. For non block compressed formats,</para>
        /// <para>this value has to be equal to that of the original resource.</para>
        /// <para>- ::cudaResourceViewDesc::height specifies the new height of the texture data. If the resource view format is a block</para>
        /// <para>compressed format, this value has to be 4 times the original height of the resource. For non block compressed formats,</para>
        /// <para>this value has to be equal to that of the original resource.</para>
        /// <para>- ::cudaResourceViewDesc::depth specifies the new depth of the texture data. This value has to be equal to that of the</para>
        /// <para>original resource.</para>
        /// <para>- ::cudaResourceViewDesc::firstMipmapLevel specifies the most detailed mipmap level. This will be the new mipmap level zero.</para>
        /// <para>For non-mipmapped resources, this value has to be zero.::cudaTextureDesc::minMipmapLevelClamp and ::cudaTextureDesc::maxMipmapLevelClamp</para>
        /// <para>will be relative to this value. For ex., if the firstMipmapLevel is set to 2, and a minMipmapLevelClamp of 1.2 is specified,</para>
        /// <para>then the actual minimum mipmap level clamp will be 3.2.</para>
        /// <para>- ::cudaResourceViewDesc::lastMipmapLevel specifies the least detailed mipmap level. For non-mipmapped resources, this value</para>
        /// <para>has to be zero.</para>
        /// <para>- ::cudaResourceViewDesc::firstLayer specifies the first layer index for layered textures. This will be the new layer zero.</para>
        /// <para>For non-layered resources, this value has to be zero.</para>
        /// <para>- ::cudaResourceViewDesc::lastLayer specifies the last layer index for layered textures. For non-layered resources,</para>
        /// <para>this value has to be zero.</para>
        /// <para>::cudaDestroyTextureObject,</para>
        /// <para>::cuTexObjectCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaCreateTextureObject(ref ulong pTexObject, global::CUDA.CudaResourceDesc pResDesc, global::CUDA.CudaTextureDesc pTexDesc, global::CUDA.CudaResourceViewDesc pResViewDesc)
        {
            fixed (ulong* __refParamPtr0 = &pTexObject)
            {
                var __arg0 = __refParamPtr0;
                var __arg1 = ReferenceEquals(pResDesc, null) ? global::System.IntPtr.Zero : pResDesc.__Instance;
                var __arg2 = ReferenceEquals(pTexDesc, null) ? global::System.IntPtr.Zero : pTexDesc.__Instance;
                var __arg3 = ReferenceEquals(pResViewDesc, null) ? global::System.IntPtr.Zero : pResViewDesc.__Instance;
                var __ret = __Internal.CudaCreateTextureObject(__arg0, __arg1, __arg2, __arg3);
                return __ret;
            }
        }

        /// <summary>Destroys a texture object</summary>
        /// <param name="texObject">- Texture object to destroy</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Destroys the texture object specified by</para>
        /// <para>::cudaCreateTextureObject,</para>
        /// <para>::cuTexObjectDestroy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDestroyTextureObject(ulong texObject)
        {
            var __ret = __Internal.CudaDestroyTextureObject(texObject);
            return __ret;
        }

        /// <summary>Returns a texture object's resource descriptor</summary>
        /// <param name="pResDesc">- Resource descriptor</param>
        /// <param name="texObject">- Texture object</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns the resource descriptor for the texture object specified by</para>
        /// <para>::cudaCreateTextureObject,</para>
        /// <para>::cuTexObjectGetResourceDesc</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetTextureObjectResourceDesc(global::CUDA.CudaResourceDesc pResDesc, ulong texObject)
        {
            var __arg0 = ReferenceEquals(pResDesc, null) ? global::System.IntPtr.Zero : pResDesc.__Instance;
            var __ret = __Internal.CudaGetTextureObjectResourceDesc(__arg0, texObject);
            return __ret;
        }

        /// <summary>Returns a texture object's texture descriptor</summary>
        /// <param name="pTexDesc">- Texture descriptor</param>
        /// <param name="texObject">- Texture object</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns the texture descriptor for the texture object specified by</para>
        /// <para>::cudaCreateTextureObject,</para>
        /// <para>::cuTexObjectGetTextureDesc</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetTextureObjectTextureDesc(global::CUDA.CudaTextureDesc pTexDesc, ulong texObject)
        {
            var __arg0 = ReferenceEquals(pTexDesc, null) ? global::System.IntPtr.Zero : pTexDesc.__Instance;
            var __ret = __Internal.CudaGetTextureObjectTextureDesc(__arg0, texObject);
            return __ret;
        }

        /// <summary>Returns a texture object's resource view descriptor</summary>
        /// <param name="pResViewDesc">- Resource view descriptor</param>
        /// <param name="texObject">- Texture object</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns the resource view descriptor for the texture object specified byIf no resource view was specified, ::cudaErrorInvalidValue is returned.</para>
        /// <para>::cudaCreateTextureObject,</para>
        /// <para>::cuTexObjectGetResourceViewDesc</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetTextureObjectResourceViewDesc(global::CUDA.CudaResourceViewDesc pResViewDesc, ulong texObject)
        {
            var __arg0 = ReferenceEquals(pResViewDesc, null) ? global::System.IntPtr.Zero : pResViewDesc.__Instance;
            var __ret = __Internal.CudaGetTextureObjectResourceViewDesc(__arg0, texObject);
            return __ret;
        }

        /// <summary>Creates a surface object</summary>
        /// <param name="pSurfObject">- Surface object to create</param>
        /// <param name="pResDesc">- Resource descriptor</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Creates a surface object and returns it indescribes</para>
        /// <para>the data to perform surface load/stores on. ::cudaResourceDesc::resType must be</para>
        /// <para>::cudaResourceTypeArray and  ::cudaResourceDesc::res::array::array</para>
        /// <para>must be set to a valid CUDA array handle.</para>
        /// <para>Surface objects are only supported on devices of compute capability 3.0 or higher.</para>
        /// <para>Additionally, a surface object is an opaque value, and, as such, should only be</para>
        /// <para>accessed through CUDA API calls.</para>
        /// <para>::cudaDestroySurfaceObject,</para>
        /// <para>::cuSurfObjectCreate</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaCreateSurfaceObject(ref ulong pSurfObject, global::CUDA.CudaResourceDesc pResDesc)
        {
            fixed (ulong* __refParamPtr0 = &pSurfObject)
            {
                var __arg0 = __refParamPtr0;
                var __arg1 = ReferenceEquals(pResDesc, null) ? global::System.IntPtr.Zero : pResDesc.__Instance;
                var __ret = __Internal.CudaCreateSurfaceObject(__arg0, __arg1);
                return __ret;
            }
        }

        /// <summary>Destroys a surface object</summary>
        /// <param name="surfObject">- Surface object to destroy</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Destroys the surface object specified by</para>
        /// <para>::cudaCreateSurfaceObject,</para>
        /// <para>::cuSurfObjectDestroy</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDestroySurfaceObject(ulong surfObject)
        {
            var __ret = __Internal.CudaDestroySurfaceObject(surfObject);
            return __ret;
        }

        /// <summary>
        /// <para>Returns a surface object's resource descriptor</para>
        /// <para>Returns the resource descriptor for the surface object specified by</para>
        /// </summary>
        /// <param name="pResDesc">- Resource descriptor</param>
        /// <param name="surfObject">- Surface object</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>::cudaCreateSurfaceObject,</para>
        /// <para>::cuSurfObjectGetResourceDesc</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaGetSurfaceObjectResourceDesc(global::CUDA.CudaResourceDesc pResDesc, ulong surfObject)
        {
            var __arg0 = ReferenceEquals(pResDesc, null) ? global::System.IntPtr.Zero : pResDesc.__Instance;
            var __ret = __Internal.CudaGetSurfaceObjectResourceDesc(__arg0, surfObject);
            return __ret;
        }

        /// <summary>Returns the CUDA driver version</summary>
        /// <param name="driverVersion">- Returns the CUDA driver version.</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe version number of the installed CUDA</para>
        /// <para>driver. If no driver is installed, then 0 is returned as the driver</para>
        /// <para>version (viaThis function automatically returns</para>
        /// <para>::cudaErrorInvalidValue if theargument is NULL.</para>
        /// <para>::cudaRuntimeGetVersion,</para>
        /// <para>::cuDriverGetVersion</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaDriverGetVersion(ref int driverVersion)
        {
            fixed (int* __refParamPtr0 = &driverVersion)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaDriverGetVersion(__arg0);
                return __ret;
            }
        }

        /// <summary>Returns the CUDA Runtime version</summary>
        /// <param name="runtimeVersion">- Returns the CUDA Runtime version.</param>
        /// <returns>
        /// <para>::cudaSuccess,</para>
        /// <para>::cudaErrorInvalidValue</para>
        /// </returns>
        /// <remarks>
        /// <para>Returns inthe version number of the installed CUDA</para>
        /// <para>Runtime. This function automatically returns ::cudaErrorInvalidValue if</para>
        /// <para>theargument is NULL.</para>
        /// <para>::cudaDriverGetVersion,</para>
        /// <para>::cuDriverGetVersion</para>
        /// </remarks>
        public static global::CUDA.CudaError CudaRuntimeGetVersion(ref int runtimeVersion)
        {
            fixed (int* __refParamPtr0 = &runtimeVersion)
            {
                var __arg0 = __refParamPtr0;
                var __ret = __Internal.CudaRuntimeGetVersion(__arg0);
                return __ret;
            }
        }

        /// <summary>impl_private</summary>
        public static global::CUDA.CudaError CudaGetExportTable(void** ppExportTable, global::CUDA.CUuuidSt pExportTableId)
        {
            var __arg1 = ReferenceEquals(pExportTableId, null) ? global::System.IntPtr.Zero : pExportTableId.__Instance;
            var __ret = __Internal.CudaGetExportTable(ppExportTable, __arg1);
            return __ret;
        }
    }

    public unsafe partial class DriverFunctions
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_cudaPitchedPtr@@YA?AUcudaPitchedPtr@@PEAX_K11@Z")]
            internal static extern void MakeCudaPitchedPtr(global::System.IntPtr @return, global::System.IntPtr d, ulong p, ulong xsz, ulong ysz);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_cudaPos@@YA?AUcudaPos@@_K00@Z")]
            internal static extern void MakeCudaPos(global::System.IntPtr @return, ulong x, ulong y, ulong z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_cudaExtent@@YA?AUcudaExtent@@_K00@Z")]
            internal static extern void MakeCudaExtent(global::System.IntPtr @return, ulong w, ulong h, ulong d);
        }

        /// <summary>Returns a cudaPitchedPtr based on input parameters</summary>
        /// <param name="d">- Pointer to allocated memory</param>
        /// <param name="p">- Pitch of allocated memory in bytes</param>
        /// <param name="xsz">- Logical width of allocation in elements</param>
        /// <param name="ysz">- Logical height of allocation in elements</param>
        /// <returns>::cudaPitchedPtr specified byand</returns>
        /// <remarks>
        /// <para>Returns a ::cudaPitchedPtr based on the specified input parametersand</para>
        /// <para>make_cudaExtent, make_cudaPos</para>
        /// </remarks>
        public static global::CUDA.CudaPitchedPtr MakeCudaPitchedPtr(global::System.IntPtr d, ulong p, ulong xsz, ulong ysz)
        {
            var __ret = new global::CUDA.CudaPitchedPtr.__Internal();
            __Internal.MakeCudaPitchedPtr(new IntPtr(&__ret), d, p, xsz, ysz);
            return global::CUDA.CudaPitchedPtr.__CreateInstance(__ret);
        }

        /// <summary>Returns a cudaPos based on input parameters</summary>
        /// <param name="x">- X position</param>
        /// <param name="y">- Y position</param>
        /// <param name="z">- Z position</param>
        /// <returns>::cudaPos specified byand</returns>
        /// <remarks>
        /// <para>Returns a ::cudaPos based on the specified input parametersand</para>
        /// <para>make_cudaExtent, make_cudaPitchedPtr</para>
        /// </remarks>
        public static global::CUDA.CudaPos MakeCudaPos(ulong x, ulong y, ulong z)
        {
            var __ret = new global::CUDA.CudaPos.__Internal();
            __Internal.MakeCudaPos(new IntPtr(&__ret), x, y, z);
            return global::CUDA.CudaPos.__CreateInstance(__ret);
        }

        /// <summary>Returns a cudaExtent based on input parameters</summary>
        /// <param name="w">- Width in elements when referring to array memory, in bytes when referring to linear memory</param>
        /// <param name="h">- Height in elements</param>
        /// <param name="d">- Depth in elements</param>
        /// <returns>::cudaExtent specified byand</returns>
        /// <remarks>
        /// <para>Returns a ::cudaExtent based on the specified input parametersand</para>
        /// <para>make_cudaPitchedPtr, make_cudaPos</para>
        /// </remarks>
        public static global::CUDA.CudaExtent MakeCudaExtent(ulong w, ulong h, ulong d)
        {
            var __ret = new global::CUDA.CudaExtent.__Internal();
            __Internal.MakeCudaExtent(new IntPtr(&__ret), w, h, d);
            return global::CUDA.CudaExtent.__CreateInstance(__ret);
        }
    }

    public unsafe partial class VectorFunctions
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char1@@YA?AUchar1@@C@Z")]
            internal static extern global::CUDA.Char1.__Internal MakeChar1(sbyte x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar1@@YA?AUuchar1@@E@Z")]
            internal static extern global::CUDA.Uchar1.__Internal MakeUchar1(byte x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char2@@YA?AUchar2@@CC@Z")]
            internal static extern global::CUDA.Char2.__Internal MakeChar2(sbyte x, sbyte y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar2@@YA?AUuchar2@@EE@Z")]
            internal static extern global::CUDA.Uchar2.__Internal MakeUchar2(byte x, byte y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char3@@YA?AUchar3@@CCC@Z")]
            internal static extern void MakeChar3(global::System.IntPtr @return, sbyte x, sbyte y, sbyte z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar3@@YA?AUuchar3@@EEE@Z")]
            internal static extern void MakeUchar3(global::System.IntPtr @return, byte x, byte y, byte z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char4@@YA?AUchar4@@CCCC@Z")]
            internal static extern global::CUDA.Char4.__Internal MakeChar4(sbyte x, sbyte y, sbyte z, sbyte w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar4@@YA?AUuchar4@@EEEE@Z")]
            internal static extern global::CUDA.Uchar4.__Internal MakeUchar4(byte x, byte y, byte z, byte w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short1@@YA?AUshort1@@F@Z")]
            internal static extern global::CUDA.Short1.__Internal MakeShort1(short x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort1@@YA?AUushort1@@G@Z")]
            internal static extern global::CUDA.Ushort1.__Internal MakeUshort1(ushort x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short2@@YA?AUshort2@@FF@Z")]
            internal static extern global::CUDA.Short2.__Internal MakeShort2(short x, short y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort2@@YA?AUushort2@@GG@Z")]
            internal static extern global::CUDA.Ushort2.__Internal MakeUshort2(ushort x, ushort y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short3@@YA?AUshort3@@FFF@Z")]
            internal static extern void MakeShort3(global::System.IntPtr @return, short x, short y, short z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort3@@YA?AUushort3@@GGG@Z")]
            internal static extern void MakeUshort3(global::System.IntPtr @return, ushort x, ushort y, ushort z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short4@@YA?AUshort4@@FFFF@Z")]
            internal static extern global::CUDA.Short4.__Internal MakeShort4(short x, short y, short z, short w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort4@@YA?AUushort4@@GGGG@Z")]
            internal static extern global::CUDA.Ushort4.__Internal MakeUshort4(ushort x, ushort y, ushort z, ushort w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int1@@YA?AUint1@@H@Z")]
            internal static extern global::CUDA.Int1.__Internal MakeInt1(int x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint1@@YA?AUuint1@@I@Z")]
            internal static extern global::CUDA.Uint1.__Internal MakeUint1(uint x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int2@@YA?AUint2@@HH@Z")]
            internal static extern global::CUDA.Int2.__Internal MakeInt2(int x, int y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint2@@YA?AUuint2@@II@Z")]
            internal static extern global::CUDA.Uint2.__Internal MakeUint2(uint x, uint y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int3@@YA?AUint3@@HHH@Z")]
            internal static extern void MakeInt3(global::System.IntPtr @return, int x, int y, int z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint3@@YA?AUuint3@@III@Z")]
            internal static extern void MakeUint3(global::System.IntPtr @return, uint x, uint y, uint z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int4@@YA?AUint4@@HHHH@Z")]
            internal static extern void MakeInt4(global::System.IntPtr @return, int x, int y, int z, int w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint4@@YA?AUuint4@@IIII@Z")]
            internal static extern void MakeUint4(global::System.IntPtr @return, uint x, uint y, uint z, uint w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long1@@YA?AUlong1@@J@Z")]
            internal static extern global::CUDA.Long1.__Internal MakeLong1(int x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong1@@YA?AUulong1@@K@Z")]
            internal static extern global::CUDA.Ulong1.__Internal MakeUlong1(uint x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long2@@YA?AUlong2@@JJ@Z")]
            internal static extern global::CUDA.Long2.__Internal MakeLong2(int x, int y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong2@@YA?AUulong2@@KK@Z")]
            internal static extern global::CUDA.Ulong2.__Internal MakeUlong2(uint x, uint y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long3@@YA?AUlong3@@JJJ@Z")]
            internal static extern void MakeLong3(global::System.IntPtr @return, int x, int y, int z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong3@@YA?AUulong3@@KKK@Z")]
            internal static extern void MakeUlong3(global::System.IntPtr @return, uint x, uint y, uint z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long4@@YA?AUlong4@@JJJJ@Z")]
            internal static extern void MakeLong4(global::System.IntPtr @return, int x, int y, int z, int w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong4@@YA?AUulong4@@KKKK@Z")]
            internal static extern void MakeUlong4(global::System.IntPtr @return, uint x, uint y, uint z, uint w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float1@@YA?AUfloat1@@M@Z")]
            internal static extern global::CUDA.Float1.__Internal MakeFloat1(float x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float2@@YA?AUfloat2@@MM@Z")]
            internal static extern global::CUDA.Float2.__Internal MakeFloat2(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float3@@YA?AUfloat3@@MMM@Z")]
            internal static extern void MakeFloat3(global::System.IntPtr @return, float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float4@@YA?AUfloat4@@MMMM@Z")]
            internal static extern void MakeFloat4(global::System.IntPtr @return, float x, float y, float z, float w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong1@@YA?AUlonglong1@@_J@Z")]
            internal static extern global::CUDA.Longlong1.__Internal MakeLonglong1(long x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong1@@YA?AUulonglong1@@_K@Z")]
            internal static extern global::CUDA.Ulonglong1.__Internal MakeUlonglong1(ulong x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong2@@YA?AUlonglong2@@_J0@Z")]
            internal static extern void MakeLonglong2(global::System.IntPtr @return, long x, long y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong2@@YA?AUulonglong2@@_K0@Z")]
            internal static extern void MakeUlonglong2(global::System.IntPtr @return, ulong x, ulong y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong3@@YA?AUlonglong3@@_J00@Z")]
            internal static extern void MakeLonglong3(global::System.IntPtr @return, long x, long y, long z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong3@@YA?AUulonglong3@@_K00@Z")]
            internal static extern void MakeUlonglong3(global::System.IntPtr @return, ulong x, ulong y, ulong z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong4@@YA?AUlonglong4@@_J000@Z")]
            internal static extern void MakeLonglong4(global::System.IntPtr @return, long x, long y, long z, long w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong4@@YA?AUulonglong4@@_K000@Z")]
            internal static extern void MakeUlonglong4(global::System.IntPtr @return, ulong x, ulong y, ulong z, ulong w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double1@@YA?AUdouble1@@N@Z")]
            internal static extern global::CUDA.Double1.__Internal MakeDouble1(double x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double2@@YA?AUdouble2@@NN@Z")]
            internal static extern void MakeDouble2(global::System.IntPtr @return, double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double3@@YA?AUdouble3@@NNN@Z")]
            internal static extern void MakeDouble3(global::System.IntPtr @return, double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double4@@YA?AUdouble4@@NNNN@Z")]
            internal static extern void MakeDouble4(global::System.IntPtr @return, double x, double y, double z, double w);
        }

        /// <summary>
        /// <para>*****************************************************************************</para>
        /// <para>*</para>
        /// <para>*</para>
        /// <para>*</para>
        /// <para>*****************************************************************************</para>
        /// </summary>
        public static global::CUDA.Char1 MakeChar1(sbyte x)
        {
            var __ret = __Internal.MakeChar1(x);
            return global::CUDA.Char1.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar1 MakeUchar1(byte x)
        {
            var __ret = __Internal.MakeUchar1(x);
            return global::CUDA.Uchar1.__CreateInstance(__ret);
        }

        public static global::CUDA.Char2 MakeChar2(sbyte x, sbyte y)
        {
            var __ret = __Internal.MakeChar2(x, y);
            return global::CUDA.Char2.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar2 MakeUchar2(byte x, byte y)
        {
            var __ret = __Internal.MakeUchar2(x, y);
            return global::CUDA.Uchar2.__CreateInstance(__ret);
        }

        public static global::CUDA.Char3 MakeChar3(sbyte x, sbyte y, sbyte z)
        {
            var __ret = new global::CUDA.Char3.__Internal();
            __Internal.MakeChar3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Char3.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar3 MakeUchar3(byte x, byte y, byte z)
        {
            var __ret = new global::CUDA.Uchar3.__Internal();
            __Internal.MakeUchar3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Uchar3.__CreateInstance(__ret);
        }

        public static global::CUDA.Char4 MakeChar4(sbyte x, sbyte y, sbyte z, sbyte w)
        {
            var __ret = __Internal.MakeChar4(x, y, z, w);
            return global::CUDA.Char4.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar4 MakeUchar4(byte x, byte y, byte z, byte w)
        {
            var __ret = __Internal.MakeUchar4(x, y, z, w);
            return global::CUDA.Uchar4.__CreateInstance(__ret);
        }

        public static global::CUDA.Short1 MakeShort1(short x)
        {
            var __ret = __Internal.MakeShort1(x);
            return global::CUDA.Short1.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort1 MakeUshort1(ushort x)
        {
            var __ret = __Internal.MakeUshort1(x);
            return global::CUDA.Ushort1.__CreateInstance(__ret);
        }

        public static global::CUDA.Short2 MakeShort2(short x, short y)
        {
            var __ret = __Internal.MakeShort2(x, y);
            return global::CUDA.Short2.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort2 MakeUshort2(ushort x, ushort y)
        {
            var __ret = __Internal.MakeUshort2(x, y);
            return global::CUDA.Ushort2.__CreateInstance(__ret);
        }

        public static global::CUDA.Short3 MakeShort3(short x, short y, short z)
        {
            var __ret = new global::CUDA.Short3.__Internal();
            __Internal.MakeShort3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Short3.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort3 MakeUshort3(ushort x, ushort y, ushort z)
        {
            var __ret = new global::CUDA.Ushort3.__Internal();
            __Internal.MakeUshort3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Ushort3.__CreateInstance(__ret);
        }

        public static global::CUDA.Short4 MakeShort4(short x, short y, short z, short w)
        {
            var __ret = __Internal.MakeShort4(x, y, z, w);
            return global::CUDA.Short4.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort4 MakeUshort4(ushort x, ushort y, ushort z, ushort w)
        {
            var __ret = __Internal.MakeUshort4(x, y, z, w);
            return global::CUDA.Ushort4.__CreateInstance(__ret);
        }

        public static global::CUDA.Int1 MakeInt1(int x)
        {
            var __ret = __Internal.MakeInt1(x);
            return global::CUDA.Int1.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint1 MakeUint1(uint x)
        {
            var __ret = __Internal.MakeUint1(x);
            return global::CUDA.Uint1.__CreateInstance(__ret);
        }

        public static global::CUDA.Int2 MakeInt2(int x, int y)
        {
            var __ret = __Internal.MakeInt2(x, y);
            return global::CUDA.Int2.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint2 MakeUint2(uint x, uint y)
        {
            var __ret = __Internal.MakeUint2(x, y);
            return global::CUDA.Uint2.__CreateInstance(__ret);
        }

        public static global::CUDA.Int3 MakeInt3(int x, int y, int z)
        {
            var __ret = new global::CUDA.Int3.__Internal();
            __Internal.MakeInt3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Int3.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint3 MakeUint3(uint x, uint y, uint z)
        {
            var __ret = new global::CUDA.Uint3.__Internal();
            __Internal.MakeUint3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Uint3.__CreateInstance(__ret);
        }

        public static global::CUDA.Int4 MakeInt4(int x, int y, int z, int w)
        {
            var __ret = new global::CUDA.Int4.__Internal();
            __Internal.MakeInt4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Int4.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint4 MakeUint4(uint x, uint y, uint z, uint w)
        {
            var __ret = new global::CUDA.Uint4.__Internal();
            __Internal.MakeUint4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Uint4.__CreateInstance(__ret);
        }

        public static global::CUDA.Long1 MakeLong1(int x)
        {
            var __ret = __Internal.MakeLong1(x);
            return global::CUDA.Long1.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong1 MakeUlong1(uint x)
        {
            var __ret = __Internal.MakeUlong1(x);
            return global::CUDA.Ulong1.__CreateInstance(__ret);
        }

        public static global::CUDA.Long2 MakeLong2(int x, int y)
        {
            var __ret = __Internal.MakeLong2(x, y);
            return global::CUDA.Long2.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong2 MakeUlong2(uint x, uint y)
        {
            var __ret = __Internal.MakeUlong2(x, y);
            return global::CUDA.Ulong2.__CreateInstance(__ret);
        }

        public static global::CUDA.Long3 MakeLong3(int x, int y, int z)
        {
            var __ret = new global::CUDA.Long3.__Internal();
            __Internal.MakeLong3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Long3.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong3 MakeUlong3(uint x, uint y, uint z)
        {
            var __ret = new global::CUDA.Ulong3.__Internal();
            __Internal.MakeUlong3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Ulong3.__CreateInstance(__ret);
        }

        public static global::CUDA.Long4 MakeLong4(int x, int y, int z, int w)
        {
            var __ret = new global::CUDA.Long4.__Internal();
            __Internal.MakeLong4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Long4.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong4 MakeUlong4(uint x, uint y, uint z, uint w)
        {
            var __ret = new global::CUDA.Ulong4.__Internal();
            __Internal.MakeUlong4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Ulong4.__CreateInstance(__ret);
        }

        public static global::CUDA.Float1 MakeFloat1(float x)
        {
            var __ret = __Internal.MakeFloat1(x);
            return global::CUDA.Float1.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 MakeFloat2(float x, float y)
        {
            var __ret = __Internal.MakeFloat2(x, y);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float3 MakeFloat3(float x, float y, float z)
        {
            var __ret = new global::CUDA.Float3.__Internal();
            __Internal.MakeFloat3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Float3.__CreateInstance(__ret);
        }

        public static global::CUDA.Float4 MakeFloat4(float x, float y, float z, float w)
        {
            var __ret = new global::CUDA.Float4.__Internal();
            __Internal.MakeFloat4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Float4.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong1 MakeLonglong1(long x)
        {
            var __ret = __Internal.MakeLonglong1(x);
            return global::CUDA.Longlong1.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong1 MakeUlonglong1(ulong x)
        {
            var __ret = __Internal.MakeUlonglong1(x);
            return global::CUDA.Ulonglong1.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong2 MakeLonglong2(long x, long y)
        {
            var __ret = new global::CUDA.Longlong2.__Internal();
            __Internal.MakeLonglong2(new IntPtr(&__ret), x, y);
            return global::CUDA.Longlong2.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong2 MakeUlonglong2(ulong x, ulong y)
        {
            var __ret = new global::CUDA.Ulonglong2.__Internal();
            __Internal.MakeUlonglong2(new IntPtr(&__ret), x, y);
            return global::CUDA.Ulonglong2.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong3 MakeLonglong3(long x, long y, long z)
        {
            var __ret = new global::CUDA.Longlong3.__Internal();
            __Internal.MakeLonglong3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Longlong3.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong3 MakeUlonglong3(ulong x, ulong y, ulong z)
        {
            var __ret = new global::CUDA.Ulonglong3.__Internal();
            __Internal.MakeUlonglong3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Ulonglong3.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong4 MakeLonglong4(long x, long y, long z, long w)
        {
            var __ret = new global::CUDA.Longlong4.__Internal();
            __Internal.MakeLonglong4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Longlong4.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong4 MakeUlonglong4(ulong x, ulong y, ulong z, ulong w)
        {
            var __ret = new global::CUDA.Ulonglong4.__Internal();
            __Internal.MakeUlonglong4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Ulonglong4.__CreateInstance(__ret);
        }

        public static global::CUDA.Double1 MakeDouble1(double x)
        {
            var __ret = __Internal.MakeDouble1(x);
            return global::CUDA.Double1.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 MakeDouble2(double x, double y)
        {
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.MakeDouble2(new IntPtr(&__ret), x, y);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double3 MakeDouble3(double x, double y, double z)
        {
            var __ret = new global::CUDA.Double3.__Internal();
            __Internal.MakeDouble3(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Double3.__CreateInstance(__ret);
        }

        public static global::CUDA.Double4 MakeDouble4(double x, double y, double z, double w)
        {
            var __ret = new global::CUDA.Double4.__Internal();
            __Internal.MakeDouble4(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Double4.__CreateInstance(__ret);
        }
    }

    public unsafe partial class VectorFunctions
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char1@@YA?AUchar1@@C@Z")]
            internal static extern global::CUDA.Char1.__Internal MakeChar11(sbyte x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar1@@YA?AUuchar1@@E@Z")]
            internal static extern global::CUDA.Uchar1.__Internal MakeUchar11(byte x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char2@@YA?AUchar2@@CC@Z")]
            internal static extern global::CUDA.Char2.__Internal MakeChar21(sbyte x, sbyte y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar2@@YA?AUuchar2@@EE@Z")]
            internal static extern global::CUDA.Uchar2.__Internal MakeUchar21(byte x, byte y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char3@@YA?AUchar3@@CCC@Z")]
            internal static extern void MakeChar31(global::System.IntPtr @return, sbyte x, sbyte y, sbyte z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar3@@YA?AUuchar3@@EEE@Z")]
            internal static extern void MakeUchar31(global::System.IntPtr @return, byte x, byte y, byte z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_char4@@YA?AUchar4@@CCCC@Z")]
            internal static extern global::CUDA.Char4.__Internal MakeChar41(sbyte x, sbyte y, sbyte z, sbyte w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uchar4@@YA?AUuchar4@@EEEE@Z")]
            internal static extern global::CUDA.Uchar4.__Internal MakeUchar41(byte x, byte y, byte z, byte w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short1@@YA?AUshort1@@F@Z")]
            internal static extern global::CUDA.Short1.__Internal MakeShort11(short x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort1@@YA?AUushort1@@G@Z")]
            internal static extern global::CUDA.Ushort1.__Internal MakeUshort11(ushort x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short2@@YA?AUshort2@@FF@Z")]
            internal static extern global::CUDA.Short2.__Internal MakeShort21(short x, short y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort2@@YA?AUushort2@@GG@Z")]
            internal static extern global::CUDA.Ushort2.__Internal MakeUshort21(ushort x, ushort y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short3@@YA?AUshort3@@FFF@Z")]
            internal static extern void MakeShort31(global::System.IntPtr @return, short x, short y, short z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort3@@YA?AUushort3@@GGG@Z")]
            internal static extern void MakeUshort31(global::System.IntPtr @return, ushort x, ushort y, ushort z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_short4@@YA?AUshort4@@FFFF@Z")]
            internal static extern global::CUDA.Short4.__Internal MakeShort41(short x, short y, short z, short w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ushort4@@YA?AUushort4@@GGGG@Z")]
            internal static extern global::CUDA.Ushort4.__Internal MakeUshort41(ushort x, ushort y, ushort z, ushort w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int1@@YA?AUint1@@H@Z")]
            internal static extern global::CUDA.Int1.__Internal MakeInt11(int x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint1@@YA?AUuint1@@I@Z")]
            internal static extern global::CUDA.Uint1.__Internal MakeUint11(uint x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int2@@YA?AUint2@@HH@Z")]
            internal static extern global::CUDA.Int2.__Internal MakeInt21(int x, int y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint2@@YA?AUuint2@@II@Z")]
            internal static extern global::CUDA.Uint2.__Internal MakeUint21(uint x, uint y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int3@@YA?AUint3@@HHH@Z")]
            internal static extern void MakeInt31(global::System.IntPtr @return, int x, int y, int z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint3@@YA?AUuint3@@III@Z")]
            internal static extern void MakeUint31(global::System.IntPtr @return, uint x, uint y, uint z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_int4@@YA?AUint4@@HHHH@Z")]
            internal static extern void MakeInt41(global::System.IntPtr @return, int x, int y, int z, int w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_uint4@@YA?AUuint4@@IIII@Z")]
            internal static extern void MakeUint41(global::System.IntPtr @return, uint x, uint y, uint z, uint w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long1@@YA?AUlong1@@J@Z")]
            internal static extern global::CUDA.Long1.__Internal MakeLong11(int x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong1@@YA?AUulong1@@K@Z")]
            internal static extern global::CUDA.Ulong1.__Internal MakeUlong11(uint x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long2@@YA?AUlong2@@JJ@Z")]
            internal static extern global::CUDA.Long2.__Internal MakeLong21(int x, int y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong2@@YA?AUulong2@@KK@Z")]
            internal static extern global::CUDA.Ulong2.__Internal MakeUlong21(uint x, uint y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long3@@YA?AUlong3@@JJJ@Z")]
            internal static extern void MakeLong31(global::System.IntPtr @return, int x, int y, int z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong3@@YA?AUulong3@@KKK@Z")]
            internal static extern void MakeUlong31(global::System.IntPtr @return, uint x, uint y, uint z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_long4@@YA?AUlong4@@JJJJ@Z")]
            internal static extern void MakeLong41(global::System.IntPtr @return, int x, int y, int z, int w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulong4@@YA?AUulong4@@KKKK@Z")]
            internal static extern void MakeUlong41(global::System.IntPtr @return, uint x, uint y, uint z, uint w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float1@@YA?AUfloat1@@M@Z")]
            internal static extern global::CUDA.Float1.__Internal MakeFloat11(float x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float2@@YA?AUfloat2@@MM@Z")]
            internal static extern global::CUDA.Float2.__Internal MakeFloat21(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float3@@YA?AUfloat3@@MMM@Z")]
            internal static extern void MakeFloat31(global::System.IntPtr @return, float x, float y, float z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_float4@@YA?AUfloat4@@MMMM@Z")]
            internal static extern void MakeFloat41(global::System.IntPtr @return, float x, float y, float z, float w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong1@@YA?AUlonglong1@@_J@Z")]
            internal static extern global::CUDA.Longlong1.__Internal MakeLonglong11(long x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong1@@YA?AUulonglong1@@_K@Z")]
            internal static extern global::CUDA.Ulonglong1.__Internal MakeUlonglong11(ulong x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong2@@YA?AUlonglong2@@_J0@Z")]
            internal static extern void MakeLonglong21(global::System.IntPtr @return, long x, long y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong2@@YA?AUulonglong2@@_K0@Z")]
            internal static extern void MakeUlonglong21(global::System.IntPtr @return, ulong x, ulong y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong3@@YA?AUlonglong3@@_J00@Z")]
            internal static extern void MakeLonglong31(global::System.IntPtr @return, long x, long y, long z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong3@@YA?AUulonglong3@@_K00@Z")]
            internal static extern void MakeUlonglong31(global::System.IntPtr @return, ulong x, ulong y, ulong z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_longlong4@@YA?AUlonglong4@@_J000@Z")]
            internal static extern void MakeLonglong41(global::System.IntPtr @return, long x, long y, long z, long w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_ulonglong4@@YA?AUulonglong4@@_K000@Z")]
            internal static extern void MakeUlonglong41(global::System.IntPtr @return, ulong x, ulong y, ulong z, ulong w);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double1@@YA?AUdouble1@@N@Z")]
            internal static extern global::CUDA.Double1.__Internal MakeDouble11(double x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double2@@YA?AUdouble2@@NN@Z")]
            internal static extern void MakeDouble21(global::System.IntPtr @return, double x, double y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double3@@YA?AUdouble3@@NNN@Z")]
            internal static extern void MakeDouble31(global::System.IntPtr @return, double x, double y, double z);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_double4@@YA?AUdouble4@@NNNN@Z")]
            internal static extern void MakeDouble41(global::System.IntPtr @return, double x, double y, double z, double w);
        }

        /// <summary>
        /// <para>*****************************************************************************</para>
        /// <para>*</para>
        /// <para>*</para>
        /// <para>*</para>
        /// <para>*****************************************************************************</para>
        /// </summary>
        public static global::CUDA.Char1 MakeChar11(sbyte x)
        {
            var __ret = __Internal.MakeChar11(x);
            return global::CUDA.Char1.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar1 MakeUchar11(byte x)
        {
            var __ret = __Internal.MakeUchar11(x);
            return global::CUDA.Uchar1.__CreateInstance(__ret);
        }

        public static global::CUDA.Char2 MakeChar21(sbyte x, sbyte y)
        {
            var __ret = __Internal.MakeChar21(x, y);
            return global::CUDA.Char2.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar2 MakeUchar21(byte x, byte y)
        {
            var __ret = __Internal.MakeUchar21(x, y);
            return global::CUDA.Uchar2.__CreateInstance(__ret);
        }

        public static global::CUDA.Char3 MakeChar31(sbyte x, sbyte y, sbyte z)
        {
            var __ret = new global::CUDA.Char3.__Internal();
            __Internal.MakeChar31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Char3.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar3 MakeUchar31(byte x, byte y, byte z)
        {
            var __ret = new global::CUDA.Uchar3.__Internal();
            __Internal.MakeUchar31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Uchar3.__CreateInstance(__ret);
        }

        public static global::CUDA.Char4 MakeChar41(sbyte x, sbyte y, sbyte z, sbyte w)
        {
            var __ret = __Internal.MakeChar41(x, y, z, w);
            return global::CUDA.Char4.__CreateInstance(__ret);
        }

        public static global::CUDA.Uchar4 MakeUchar41(byte x, byte y, byte z, byte w)
        {
            var __ret = __Internal.MakeUchar41(x, y, z, w);
            return global::CUDA.Uchar4.__CreateInstance(__ret);
        }

        public static global::CUDA.Short1 MakeShort11(short x)
        {
            var __ret = __Internal.MakeShort11(x);
            return global::CUDA.Short1.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort1 MakeUshort11(ushort x)
        {
            var __ret = __Internal.MakeUshort11(x);
            return global::CUDA.Ushort1.__CreateInstance(__ret);
        }

        public static global::CUDA.Short2 MakeShort21(short x, short y)
        {
            var __ret = __Internal.MakeShort21(x, y);
            return global::CUDA.Short2.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort2 MakeUshort21(ushort x, ushort y)
        {
            var __ret = __Internal.MakeUshort21(x, y);
            return global::CUDA.Ushort2.__CreateInstance(__ret);
        }

        public static global::CUDA.Short3 MakeShort31(short x, short y, short z)
        {
            var __ret = new global::CUDA.Short3.__Internal();
            __Internal.MakeShort31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Short3.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort3 MakeUshort31(ushort x, ushort y, ushort z)
        {
            var __ret = new global::CUDA.Ushort3.__Internal();
            __Internal.MakeUshort31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Ushort3.__CreateInstance(__ret);
        }

        public static global::CUDA.Short4 MakeShort41(short x, short y, short z, short w)
        {
            var __ret = __Internal.MakeShort41(x, y, z, w);
            return global::CUDA.Short4.__CreateInstance(__ret);
        }

        public static global::CUDA.Ushort4 MakeUshort41(ushort x, ushort y, ushort z, ushort w)
        {
            var __ret = __Internal.MakeUshort41(x, y, z, w);
            return global::CUDA.Ushort4.__CreateInstance(__ret);
        }

        public static global::CUDA.Int1 MakeInt11(int x)
        {
            var __ret = __Internal.MakeInt11(x);
            return global::CUDA.Int1.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint1 MakeUint11(uint x)
        {
            var __ret = __Internal.MakeUint11(x);
            return global::CUDA.Uint1.__CreateInstance(__ret);
        }

        public static global::CUDA.Int2 MakeInt21(int x, int y)
        {
            var __ret = __Internal.MakeInt21(x, y);
            return global::CUDA.Int2.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint2 MakeUint21(uint x, uint y)
        {
            var __ret = __Internal.MakeUint21(x, y);
            return global::CUDA.Uint2.__CreateInstance(__ret);
        }

        public static global::CUDA.Int3 MakeInt31(int x, int y, int z)
        {
            var __ret = new global::CUDA.Int3.__Internal();
            __Internal.MakeInt31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Int3.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint3 MakeUint31(uint x, uint y, uint z)
        {
            var __ret = new global::CUDA.Uint3.__Internal();
            __Internal.MakeUint31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Uint3.__CreateInstance(__ret);
        }

        public static global::CUDA.Int4 MakeInt41(int x, int y, int z, int w)
        {
            var __ret = new global::CUDA.Int4.__Internal();
            __Internal.MakeInt41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Int4.__CreateInstance(__ret);
        }

        public static global::CUDA.Uint4 MakeUint41(uint x, uint y, uint z, uint w)
        {
            var __ret = new global::CUDA.Uint4.__Internal();
            __Internal.MakeUint41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Uint4.__CreateInstance(__ret);
        }

        public static global::CUDA.Long1 MakeLong11(int x)
        {
            var __ret = __Internal.MakeLong11(x);
            return global::CUDA.Long1.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong1 MakeUlong11(uint x)
        {
            var __ret = __Internal.MakeUlong11(x);
            return global::CUDA.Ulong1.__CreateInstance(__ret);
        }

        public static global::CUDA.Long2 MakeLong21(int x, int y)
        {
            var __ret = __Internal.MakeLong21(x, y);
            return global::CUDA.Long2.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong2 MakeUlong21(uint x, uint y)
        {
            var __ret = __Internal.MakeUlong21(x, y);
            return global::CUDA.Ulong2.__CreateInstance(__ret);
        }

        public static global::CUDA.Long3 MakeLong31(int x, int y, int z)
        {
            var __ret = new global::CUDA.Long3.__Internal();
            __Internal.MakeLong31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Long3.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong3 MakeUlong31(uint x, uint y, uint z)
        {
            var __ret = new global::CUDA.Ulong3.__Internal();
            __Internal.MakeUlong31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Ulong3.__CreateInstance(__ret);
        }

        public static global::CUDA.Long4 MakeLong41(int x, int y, int z, int w)
        {
            var __ret = new global::CUDA.Long4.__Internal();
            __Internal.MakeLong41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Long4.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulong4 MakeUlong41(uint x, uint y, uint z, uint w)
        {
            var __ret = new global::CUDA.Ulong4.__Internal();
            __Internal.MakeUlong41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Ulong4.__CreateInstance(__ret);
        }

        public static global::CUDA.Float1 MakeFloat11(float x)
        {
            var __ret = __Internal.MakeFloat11(x);
            return global::CUDA.Float1.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 MakeFloat21(float x, float y)
        {
            var __ret = __Internal.MakeFloat21(x, y);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float3 MakeFloat31(float x, float y, float z)
        {
            var __ret = new global::CUDA.Float3.__Internal();
            __Internal.MakeFloat31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Float3.__CreateInstance(__ret);
        }

        public static global::CUDA.Float4 MakeFloat41(float x, float y, float z, float w)
        {
            var __ret = new global::CUDA.Float4.__Internal();
            __Internal.MakeFloat41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Float4.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong1 MakeLonglong11(long x)
        {
            var __ret = __Internal.MakeLonglong11(x);
            return global::CUDA.Longlong1.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong1 MakeUlonglong11(ulong x)
        {
            var __ret = __Internal.MakeUlonglong11(x);
            return global::CUDA.Ulonglong1.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong2 MakeLonglong21(long x, long y)
        {
            var __ret = new global::CUDA.Longlong2.__Internal();
            __Internal.MakeLonglong21(new IntPtr(&__ret), x, y);
            return global::CUDA.Longlong2.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong2 MakeUlonglong21(ulong x, ulong y)
        {
            var __ret = new global::CUDA.Ulonglong2.__Internal();
            __Internal.MakeUlonglong21(new IntPtr(&__ret), x, y);
            return global::CUDA.Ulonglong2.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong3 MakeLonglong31(long x, long y, long z)
        {
            var __ret = new global::CUDA.Longlong3.__Internal();
            __Internal.MakeLonglong31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Longlong3.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong3 MakeUlonglong31(ulong x, ulong y, ulong z)
        {
            var __ret = new global::CUDA.Ulonglong3.__Internal();
            __Internal.MakeUlonglong31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Ulonglong3.__CreateInstance(__ret);
        }

        public static global::CUDA.Longlong4 MakeLonglong41(long x, long y, long z, long w)
        {
            var __ret = new global::CUDA.Longlong4.__Internal();
            __Internal.MakeLonglong41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Longlong4.__CreateInstance(__ret);
        }

        public static global::CUDA.Ulonglong4 MakeUlonglong41(ulong x, ulong y, ulong z, ulong w)
        {
            var __ret = new global::CUDA.Ulonglong4.__Internal();
            __Internal.MakeUlonglong41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Ulonglong4.__CreateInstance(__ret);
        }

        public static global::CUDA.Double1 MakeDouble11(double x)
        {
            var __ret = __Internal.MakeDouble11(x);
            return global::CUDA.Double1.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 MakeDouble21(double x, double y)
        {
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.MakeDouble21(new IntPtr(&__ret), x, y);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double3 MakeDouble31(double x, double y, double z)
        {
            var __ret = new global::CUDA.Double3.__Internal();
            __Internal.MakeDouble31(new IntPtr(&__ret), x, y, z);
            return global::CUDA.Double3.__CreateInstance(__ret);
        }

        public static global::CUDA.Double4 MakeDouble41(double x, double y, double z, double w)
        {
            var __ret = new global::CUDA.Double4.__Internal();
            __Internal.MakeDouble41(new IntPtr(&__ret), x, y, z, w);
            return global::CUDA.Double4.__CreateInstance(__ret);
        }
    }

    public enum CublasStatusT
    {
        CUBLAS_STATUS_SUCCESS = 0,
        CUBLAS_STATUS_NOT_INITIALIZED = 1,
        CUBLAS_STATUS_ALLOC_FAILED = 3,
        CUBLAS_STATUS_INVALID_VALUE = 7,
        CUBLAS_STATUS_ARCH_MISMATCH = 8,
        CUBLAS_STATUS_MAPPING_ERROR = 11,
        CUBLAS_STATUS_EXECUTION_FAILED = 13,
        CUBLAS_STATUS_INTERNAL_ERROR = 14,
        CUBLAS_STATUS_NOT_SUPPORTED = 15,
        CUBLAS_STATUS_LICENSE_ERROR = 16
    }

    public enum CublasFillModeT
    {
        CUBLAS_FILL_MODE_LOWER = 0,
        CUBLAS_FILL_MODE_UPPER = 1
    }

    public enum CublasDiagTypeT
    {
        CUBLAS_DIAG_NON_UNIT = 0,
        CUBLAS_DIAG_UNIT = 1
    }

    public enum CublasSideModeT
    {
        CUBLAS_SIDE_LEFT = 0,
        CUBLAS_SIDE_RIGHT = 1
    }

    public enum CublasOperationT
    {
        CUBLAS_OP_N = 0,
        CUBLAS_OP_T = 1,
        CUBLAS_OP_C = 2
    }

    public enum CublasPointerModeT
    {
        CUBLAS_POINTER_MODE_HOST = 0,
        CUBLAS_POINTER_MODE_DEVICE = 1
    }

    public enum CublasAtomicsModeT
    {
        CUBLAS_ATOMICS_NOT_ALLOWED = 0,
        CUBLAS_ATOMICS_ALLOWED = 1
    }

    public enum CublasGemmAlgoT
    {
        CUBLAS_GEMM_DFALT = -1,
        CUBLAS_GEMM_DEFAULT = -1,
        CUBLAS_GEMM_ALGO0 = 0,
        CUBLAS_GEMM_ALGO1 = 1,
        CUBLAS_GEMM_ALGO2 = 2,
        CUBLAS_GEMM_ALGO3 = 3,
        CUBLAS_GEMM_ALGO4 = 4,
        CUBLAS_GEMM_ALGO5 = 5,
        CUBLAS_GEMM_ALGO6 = 6,
        CUBLAS_GEMM_ALGO7 = 7,
        CUBLAS_GEMM_ALGO8 = 8,
        CUBLAS_GEMM_ALGO9 = 9,
        CUBLAS_GEMM_ALGO10 = 10,
        CUBLAS_GEMM_ALGO11 = 11,
        CUBLAS_GEMM_ALGO12 = 12,
        CUBLAS_GEMM_ALGO13 = 13,
        CUBLAS_GEMM_ALGO14 = 14,
        CUBLAS_GEMM_ALGO15 = 15,
        CUBLAS_GEMM_ALGO16 = 16,
        CUBLAS_GEMM_ALGO17 = 17,
        CUBLAS_GEMM_DEFAULT_TENSOR_OP = 99,
        CUBLAS_GEMM_DFALT_TENSOR_OP = 99,
        CUBLAS_GEMM_ALGO0TENSOR_OP = 100,
        CUBLAS_GEMM_ALGO1TENSOR_OP = 101,
        CUBLAS_GEMM_ALGO2TENSOR_OP = 102,
        CUBLAS_GEMM_ALGO3TENSOR_OP = 103,
        CUBLAS_GEMM_ALGO4TENSOR_OP = 104
    }

    public enum CublasMathT
    {
        CUBLAS_DEFAULT_MATH = 0,
        CUBLAS_TENSOR_OP_MATH = 1
    }

    public unsafe partial class CublasContext
    {
        [StructLayout(LayoutKind.Explicit, Size = 0)]
        public partial struct __Internal
        {
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CublasContext> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.CublasContext>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.CublasContext __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.CublasContext(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.CublasContext __CreateInstance(global::CUDA.CublasContext.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.CublasContext(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.CublasContext.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.CublasContext.__Internal));
            *(global::CUDA.CublasContext.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private CublasContext(global::CUDA.CublasContext.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected CublasContext(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }
    }

    public unsafe partial class cuComplex
    {
        public partial struct __Internal
        {
            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCrealf@@YAMUfloat2@@@Z")]
            internal static extern float CuCrealf(global::CUDA.Float2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCimagf@@YAMUfloat2@@@Z")]
            internal static extern float CuCimagf(global::CUDA.Float2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_cuFloatComplex@@YA?AUfloat2@@MM@Z")]
            internal static extern global::CUDA.Float2.__Internal MakeCuFloatComplex(float r, float i);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuConjf@@YA?AUfloat2@@U1@@Z")]
            internal static extern global::CUDA.Float2.__Internal CuConjf(global::CUDA.Float2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCaddf@@YA?AUfloat2@@U1@0@Z")]
            internal static extern global::CUDA.Float2.__Internal CuCaddf(global::CUDA.Float2.__Internal x, global::CUDA.Float2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCsubf@@YA?AUfloat2@@U1@0@Z")]
            internal static extern global::CUDA.Float2.__Internal CuCsubf(global::CUDA.Float2.__Internal x, global::CUDA.Float2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCmulf@@YA?AUfloat2@@U1@0@Z")]
            internal static extern global::CUDA.Float2.__Internal CuCmulf(global::CUDA.Float2.__Internal x, global::CUDA.Float2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCdivf@@YA?AUfloat2@@U1@0@Z")]
            internal static extern global::CUDA.Float2.__Internal CuCdivf(global::CUDA.Float2.__Internal x, global::CUDA.Float2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCabsf@@YAMUfloat2@@@Z")]
            internal static extern float CuCabsf(global::CUDA.Float2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCreal@@YANUdouble2@@@Z")]
            internal static extern double CuCreal(global::CUDA.Double2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCimag@@YANUdouble2@@@Z")]
            internal static extern double CuCimag(global::CUDA.Double2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_cuDoubleComplex@@YA?AUdouble2@@NN@Z")]
            internal static extern void MakeCuDoubleComplex(global::System.IntPtr @return, double r, double i);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuConj@@YA?AUdouble2@@U1@@Z")]
            internal static extern void CuConj(global::System.IntPtr @return, global::CUDA.Double2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCadd@@YA?AUdouble2@@U1@0@Z")]
            internal static extern void CuCadd(global::System.IntPtr @return, global::CUDA.Double2.__Internal x, global::CUDA.Double2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCsub@@YA?AUdouble2@@U1@0@Z")]
            internal static extern void CuCsub(global::System.IntPtr @return, global::CUDA.Double2.__Internal x, global::CUDA.Double2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCmul@@YA?AUdouble2@@U1@0@Z")]
            internal static extern void CuCmul(global::System.IntPtr @return, global::CUDA.Double2.__Internal x, global::CUDA.Double2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCdiv@@YA?AUdouble2@@U1@0@Z")]
            internal static extern void CuCdiv(global::System.IntPtr @return, global::CUDA.Double2.__Internal x, global::CUDA.Double2.__Internal y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCabs@@YANUdouble2@@@Z")]
            internal static extern double CuCabs(global::CUDA.Double2.__Internal x);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?make_cuComplex@@YA?AUfloat2@@MM@Z")]
            internal static extern global::CUDA.Float2.__Internal MakeCuComplex(float x, float y);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuComplexFloatToDouble@@YA?AUdouble2@@Ufloat2@@@Z")]
            internal static extern void CuComplexFloatToDouble(global::System.IntPtr @return, global::CUDA.Float2.__Internal c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuComplexDoubleToFloat@@YA?AUfloat2@@Udouble2@@@Z")]
            internal static extern global::CUDA.Float2.__Internal CuComplexDoubleToFloat(global::CUDA.Double2.__Internal c);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCfmaf@@YA?AUfloat2@@U1@00@Z")]
            internal static extern global::CUDA.Float2.__Internal CuCfmaf(global::CUDA.Float2.__Internal x, global::CUDA.Float2.__Internal y, global::CUDA.Float2.__Internal d);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "?cuCfma@@YA?AUdouble2@@U1@00@Z")]
            internal static extern void CuCfma(global::System.IntPtr @return, global::CUDA.Double2.__Internal x, global::CUDA.Double2.__Internal y, global::CUDA.Double2.__Internal d);
        }

        public static float CuCrealf(global::CUDA.Float2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __ret = __Internal.CuCrealf(__arg0);
            return __ret;
        }

        public static float CuCimagf(global::CUDA.Float2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __ret = __Internal.CuCimagf(__arg0);
            return __ret;
        }

        public static global::CUDA.Float2 MakeCuFloatComplex(float r, float i)
        {
            var __ret = __Internal.MakeCuFloatComplex(r, i);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 CuConjf(global::CUDA.Float2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __ret = __Internal.CuConjf(__arg0);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 CuCaddf(global::CUDA.Float2 x, global::CUDA.Float2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)y.__Instance;
            var __ret = __Internal.CuCaddf(__arg0, __arg1);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 CuCsubf(global::CUDA.Float2 x, global::CUDA.Float2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)y.__Instance;
            var __ret = __Internal.CuCsubf(__arg0, __arg1);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 CuCmulf(global::CUDA.Float2 x, global::CUDA.Float2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)y.__Instance;
            var __ret = __Internal.CuCmulf(__arg0, __arg1);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 CuCdivf(global::CUDA.Float2 x, global::CUDA.Float2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)y.__Instance;
            var __ret = __Internal.CuCdivf(__arg0, __arg1);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static float CuCabsf(global::CUDA.Float2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __ret = __Internal.CuCabsf(__arg0);
            return __ret;
        }

        public static double CuCreal(global::CUDA.Double2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __ret = __Internal.CuCreal(__arg0);
            return __ret;
        }

        public static double CuCimag(global::CUDA.Double2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __ret = __Internal.CuCimag(__arg0);
            return __ret;
        }

        public static global::CUDA.Double2 MakeCuDoubleComplex(double r, double i)
        {
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.MakeCuDoubleComplex(new IntPtr(&__ret), r, i);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 CuConj(global::CUDA.Double2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.CuConj(new IntPtr(&__ret), __arg0);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 CuCadd(global::CUDA.Double2 x, global::CUDA.Double2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)y.__Instance;
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.CuCadd(new IntPtr(&__ret), __arg0, __arg1);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 CuCsub(global::CUDA.Double2 x, global::CUDA.Double2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)y.__Instance;
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.CuCsub(new IntPtr(&__ret), __arg0, __arg1);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 CuCmul(global::CUDA.Double2 x, global::CUDA.Double2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)y.__Instance;
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.CuCmul(new IntPtr(&__ret), __arg0, __arg1);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 CuCdiv(global::CUDA.Double2 x, global::CUDA.Double2 y)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)y.__Instance;
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.CuCdiv(new IntPtr(&__ret), __arg0, __arg1);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static double CuCabs(global::CUDA.Double2 x)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __ret = __Internal.CuCabs(__arg0);
            return __ret;
        }

        public static global::CUDA.Float2 MakeCuComplex(float x, float y)
        {
            var __ret = __Internal.MakeCuComplex(x, y);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 CuComplexFloatToDouble(global::CUDA.Float2 c)
        {
            var __arg0 = ReferenceEquals(c, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)c.__Instance;
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.CuComplexFloatToDouble(new IntPtr(&__ret), __arg0);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 CuComplexDoubleToFloat(global::CUDA.Double2 c)
        {
            var __arg0 = ReferenceEquals(c, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)c.__Instance;
            var __ret = __Internal.CuComplexDoubleToFloat(__arg0);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Float2 CuCfmaf(global::CUDA.Float2 x, global::CUDA.Float2 y, global::CUDA.Float2 d)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)y.__Instance;
            var __arg2 = ReferenceEquals(d, null) ? new global::CUDA.Float2.__Internal() : *(global::CUDA.Float2.__Internal*)d.__Instance;
            var __ret = __Internal.CuCfmaf(__arg0, __arg1, __arg2);
            return global::CUDA.Float2.__CreateInstance(__ret);
        }

        public static global::CUDA.Double2 CuCfma(global::CUDA.Double2 x, global::CUDA.Double2 y, global::CUDA.Double2 d)
        {
            var __arg0 = ReferenceEquals(x, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)x.__Instance;
            var __arg1 = ReferenceEquals(y, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)y.__Instance;
            var __arg2 = ReferenceEquals(d, null) ? new global::CUDA.Double2.__Internal() : *(global::CUDA.Double2.__Internal*)d.__Instance;
            var __ret = new global::CUDA.Double2.__Internal();
            __Internal.CuCfma(new IntPtr(&__ret), __arg0, __arg1, __arg2);
            return global::CUDA.Double2.__CreateInstance(__ret);
        }
    }

    /// <summary>
    /// <para>Types which allow static initialization of &quot;half&quot; and &quot;half2&quot; until</para>
    /// <para>these become an actual builtin. Note this initialization is as a</para>
    /// <para>bitfield representation of &quot;half&quot;, and not a conversion from short-&gt;half.</para>
    /// <para>Such a representation will be deprecated in a future version of CUDA.</para>
    /// <para>(Note these are visible to non-nvcc compilers, including C-only compilation)</para>
    /// </summary>
    public unsafe partial class HalfRaw : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ushort x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0__half_raw@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.HalfRaw> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.HalfRaw>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.HalfRaw __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.HalfRaw(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.HalfRaw __CreateInstance(global::CUDA.HalfRaw.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.HalfRaw(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.HalfRaw.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.HalfRaw.__Internal));
            *(global::CUDA.HalfRaw.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private HalfRaw(global::CUDA.HalfRaw.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected HalfRaw(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public HalfRaw()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.HalfRaw.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public HalfRaw(global::CUDA.HalfRaw _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.HalfRaw.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.HalfRaw.__Internal*)__Instance) = *((global::CUDA.HalfRaw.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.HalfRaw __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ushort X
        {
            get
            {
                return ((global::CUDA.HalfRaw.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.HalfRaw.__Internal*)__Instance)->x = value;
            }
        }
    }

    public unsafe partial class Half2Raw : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ushort x;

            [FieldOffset(2)]
            internal ushort y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0__half2_raw@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr _0);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Half2Raw> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Half2Raw>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Half2Raw __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Half2Raw(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Half2Raw __CreateInstance(global::CUDA.Half2Raw.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Half2Raw(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Half2Raw.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2Raw.__Internal));
            *(global::CUDA.Half2Raw.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Half2Raw(global::CUDA.Half2Raw.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Half2Raw(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Half2Raw()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2Raw.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Half2Raw(global::CUDA.Half2Raw _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2Raw.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Half2Raw.__Internal*)__Instance) = *((global::CUDA.Half2Raw.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Half2Raw __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public ushort X
        {
            get
            {
                return ((global::CUDA.Half2Raw.__Internal*)__Instance)->x;
            }

            set
            {
                ((global::CUDA.Half2Raw.__Internal*)__Instance)->x = value;
            }
        }

        public ushort Y
        {
            get
            {
                return ((global::CUDA.Half2Raw.__Internal*)__Instance)->y;
            }

            set
            {
                ((global::CUDA.Half2Raw.__Internal*)__Instance)->y = value;
            }
        }
    }

    public unsafe partial class Half : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 2)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal ushort __x;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0__half@@QEAA@AEBU__half_raw@@@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, global::System.IntPtr hr);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0__half@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor_1(global::System.IntPtr instance, global::System.IntPtr _0);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??B__half@@QEBA?AU__half_raw@@XZ")]
            internal static extern void OperatorConversion(global::System.IntPtr instance, global::System.IntPtr @return);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Half> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Half>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Half __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Half(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Half __CreateInstance(global::CUDA.Half.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Half(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Half.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Half.__Internal));
            *(global::CUDA.Half.__Internal*)ret = native;
            return ret.ToPointer();
        }

        private Half(global::CUDA.Half.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Half(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Half()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Half(global::CUDA.HalfRaw hr)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(hr, null))
                throw new global::System.ArgumentNullException("hr", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = hr.__Instance;
            __Internal.ctor((__Instance + __PointerAdjustment), __arg0);
        }

        public Half(global::CUDA.Half _0)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            *((global::CUDA.Half.__Internal*)__Instance) = *((global::CUDA.Half.__Internal*)_0.__Instance);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Half __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static implicit operator global::CUDA.HalfRaw(global::CUDA.Half __op)
        {
            if (ReferenceEquals(__op, null))
                throw new global::System.ArgumentNullException("__op", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = __op.__Instance;
            var __ret = new global::CUDA.HalfRaw.__Internal();
            __Internal.OperatorConversion(__arg0, new IntPtr(&__ret));
            return global::CUDA.HalfRaw.__CreateInstance(__ret);
        }

        public static implicit operator global::CUDA.Half(global::CUDA.HalfRaw hr)
        {
            return new global::CUDA.Half(hr);
        }

        protected ushort X
        {
            get
            {
                return ((global::CUDA.Half.__Internal*)__Instance)->__x;
            }

            set
            {
                ((global::CUDA.Half.__Internal*)__Instance)->__x = value;
            }
        }
    }

    public unsafe partial class Half2 : IDisposable
    {
        [StructLayout(LayoutKind.Explicit, Size = 4)]
        public partial struct __Internal
        {
            [FieldOffset(0)]
            internal global::CUDA.Half.__Internal x;

            [FieldOffset(2)]
            internal global::CUDA.Half.__Internal y;

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0__half2@@QEAA@AEBU__half@@0@Z")]
            internal static extern global::System.IntPtr ctor(global::System.IntPtr instance, global::System.IntPtr a, global::System.IntPtr b);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0__half2@@QEAA@AEBU0@@Z")]
            internal static extern global::System.IntPtr cctor(global::System.IntPtr instance, global::System.IntPtr src);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??0__half2@@QEAA@AEBU__half2_raw@@@Z")]
            internal static extern global::System.IntPtr ctor_1(global::System.IntPtr instance, global::System.IntPtr h2r);

            [SuppressUnmanagedCodeSecurity]
            [DllImport("cudart64_91", CallingConvention = global::System.Runtime.InteropServices.CallingConvention.Cdecl,
                EntryPoint = "??B__half2@@QEBA?AU__half2_raw@@XZ")]
            internal static extern void OperatorConversion(global::System.IntPtr instance, global::System.IntPtr @return);
        }

        public global::System.IntPtr __Instance { get; protected set; }

        protected int __PointerAdjustment;
        internal static readonly global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Half2> NativeToManagedMap = new global::System.Collections.Concurrent.ConcurrentDictionary<IntPtr, global::CUDA.Half2>();
        protected void*[] __OriginalVTables;

        protected bool __ownsNativeInstance;

        internal static global::CUDA.Half2 __CreateInstance(global::System.IntPtr native, bool skipVTables = false)
        {
            return new global::CUDA.Half2(native.ToPointer(), skipVTables);
        }

        internal static global::CUDA.Half2 __CreateInstance(global::CUDA.Half2.__Internal native, bool skipVTables = false)
        {
            return new global::CUDA.Half2(native, skipVTables);
        }

        private static void* __CopyValue(global::CUDA.Half2.__Internal native)
        {
            var ret = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2.__Internal));
            global::CUDA.Half2.__Internal.cctor(ret, new global::System.IntPtr(&native));
            return ret.ToPointer();
        }

        private Half2(global::CUDA.Half2.__Internal native, bool skipVTables = false)
            : this(__CopyValue(native), skipVTables)
        {
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        protected Half2(void* native, bool skipVTables = false)
        {
            if (native == null)
                return;
            __Instance = new global::System.IntPtr(native);
        }

        public Half2()
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
        }

        public Half2(global::CUDA.Half a, global::CUDA.Half b)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(a, null))
                throw new global::System.ArgumentNullException("a", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = a.__Instance;
            if (ReferenceEquals(b, null))
                throw new global::System.ArgumentNullException("b", "Cannot be null because it is a C++ reference (&).");
            var __arg1 = b.__Instance;
            __Internal.ctor((__Instance + __PointerAdjustment), __arg0, __arg1);
        }

        public Half2(global::CUDA.Half2 src)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(src, null))
                throw new global::System.ArgumentNullException("src", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = src.__Instance;
            __Internal.cctor((__Instance + __PointerAdjustment), __arg0);
        }

        public Half2(global::CUDA.Half2Raw h2r)
        {
            __Instance = Marshal.AllocHGlobal(sizeof(global::CUDA.Half2.__Internal));
            __ownsNativeInstance = true;
            NativeToManagedMap[__Instance] = this;
            if (ReferenceEquals(h2r, null))
                throw new global::System.ArgumentNullException("h2r", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = h2r.__Instance;
            __Internal.ctor_1((__Instance + __PointerAdjustment), __arg0);
        }

        public void Dispose()
        {
            Dispose(disposing: true);
        }

        public virtual void Dispose(bool disposing)
        {
            if (__Instance == IntPtr.Zero)
                return;
            global::CUDA.Half2 __dummy;
            NativeToManagedMap.TryRemove(__Instance, out __dummy);
            if (__ownsNativeInstance)
                Marshal.FreeHGlobal(__Instance);
            __Instance = IntPtr.Zero;
        }

        public static implicit operator global::CUDA.Half2Raw(global::CUDA.Half2 __op)
        {
            if (ReferenceEquals(__op, null))
                throw new global::System.ArgumentNullException("__op", "Cannot be null because it is a C++ reference (&).");
            var __arg0 = __op.__Instance;
            var __ret = new global::CUDA.Half2Raw.__Internal();
            __Internal.OperatorConversion(__arg0, new IntPtr(&__ret));
            return global::CUDA.Half2Raw.__CreateInstance(__ret);
        }

        public static implicit operator global::CUDA.Half2(global::CUDA.Half2Raw h2r)
        {
            return new global::CUDA.Half2(h2r);
        }

        public global::CUDA.Half X
        {
            get
            {
                return global::CUDA.Half.__CreateInstance(((global::CUDA.Half2.__Internal*)__Instance)->x);
            }

            set
            {
                ((global::CUDA.Half2.__Internal*)__Instance)->x = ReferenceEquals(value, null) ? new global::CUDA.Half.__Internal() : *(global::CUDA.Half.__Internal*)value.__Instance;
            }
        }

        public global::CUDA.Half Y
        {
            get
            {
                return global::CUDA.Half.__CreateInstance(((global::CUDA.Half2.__Internal*)__Instance)->y);
            }

            set
            {
                ((global::CUDA.Half2.__Internal*)__Instance)->y = ReferenceEquals(value, null) ? new global::CUDA.Half.__Internal() : *(global::CUDA.Half.__Internal*)value.__Instance;
            }
        }
    }

    public enum CudaDataTypeT
    {
        CUDA_R_16F = 2,
        CUDA_C_16F = 6,
        CUDA_R_32F = 0,
        CUDA_C_32F = 4,
        CUDA_R_64F = 1,
        CUDA_C_64F = 5,
        CUDA_R_8I = 3,
        CUDA_C_8I = 7,
        CUDA_R_8U = 8,
        CUDA_C_8U = 9,
        CUDA_R_32I = 10,
        CUDA_C_32I = 11,
        CUDA_R_32U = 12,
        CUDA_C_32U = 13
    }

    public enum LibraryPropertyTypeT
    {
        MAJOR_VERSION = 0,
        MINOR_VERSION = 1,
        PATCH_LEVEL = 2
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

public class SSE
{

    /// <summary>
    /// ConvertToInt64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long _mm_cvtss_si64 (Vector128<float> value)
    {
        return Sse.X64.ConvertToInt64(value);
    }
    /// <summary>
    /// ConvertScalarToVector128Single
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cvtsi64_ss (Vector128<float> upper, long value)
    {
        return Sse.X64.ConvertScalarToVector128Single(upper, value);
    }
    /// <summary>
    /// ConvertToInt64WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long _mm_cvttss_si64 (Vector128<float> value)
    {
        return Sse.X64.ConvertToInt64WithTruncation(value);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_add_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Add(left, right);
    }
    /// <summary>
    /// AddScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_add_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.AddScalar(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_and_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.And(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_andnot_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.AndNot(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpeq_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comieq_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarOrderedEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomieq_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarUnorderedEqual(left, right);
    }
    /// <summary>
    /// CompareScalarEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpeq_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarEqual(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpgt_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comigt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarOrderedGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomigt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarUnorderedGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpgt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpge_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comige_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarOrderedGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomige_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarUnorderedGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpge_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmplt_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comilt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarOrderedLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomilt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarUnorderedLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmplt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarLessThan(left, right);
    }
    /// <summary>
    /// CompareLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmple_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comile_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarOrderedLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomile_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarUnorderedLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmple_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpneq_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareNotEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comineq_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarOrderedNotEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomineq_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarUnorderedNotEqual(left, right);
    }
    /// <summary>
    /// CompareScalarNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpneq_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarNotEqual(left, right);
    }
    /// <summary>
    /// CompareNotGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpngt_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareNotGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarNotGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpngt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarNotGreaterThan(left, right);
    }
    /// <summary>
    /// CompareNotGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpnge_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareNotGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarNotGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpnge_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarNotGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareNotLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpnlt_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareNotLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarNotLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpnlt_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarNotLessThan(left, right);
    }
    /// <summary>
    /// CompareNotLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpnle_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareNotLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarNotLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpnle_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarNotLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareOrdered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpord_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareOrdered(left, right);
    }
    /// <summary>
    /// CompareScalarOrdered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpord_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarOrdered(left, right);
    }
    /// <summary>
    /// CompareUnordered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpunord_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareUnordered(left, right);
    }
    /// <summary>
    /// CompareScalarUnordered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmpunord_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.CompareScalarUnordered(left, right);
    }
    /// <summary>
    /// ConvertToInt32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_cvtss_si32 (Vector128<float> value)
    {
        return Sse.ConvertToInt32(value);
    }
    /// <summary>
    /// ConvertScalarToVector128Single
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cvtsi32_ss (Vector128<float> upper, int value)
    {
        return Sse.ConvertScalarToVector128Single(upper, value);
    }
    /// <summary>
    /// ConvertToInt32WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_cvttss_si32 (Vector128<float> value)
    {
        return Sse.ConvertToInt32WithTruncation(value);
    }
    /// <summary>
    /// Divide
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_div_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Divide(left, right);
    }
    /// <summary>
    /// DivideScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_div_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.DivideScalar(left, right);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_loadu_ps (float* address)
    {
        return Sse.LoadVector128(address);
    }
    /// <summary>
    /// LoadScalarVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_load_ss (float* address)
    {
        return Sse.LoadScalarVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_load_ps (float* address)
    {
        return Sse.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_loadh_pi (Vector128<float> lower, float* address)
    {
        return Sse.LoadHigh(lower, address);
    }
    /// <summary>
    /// LoadLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_loadl_pi (Vector128<float> upper, float* address)
    {
        return Sse.LoadLow(upper, address);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_max_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Max(left, right);
    }
    /// <summary>
    /// MaxScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_max_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.MaxScalar(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_min_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Min(left, right);
    }
    /// <summary>
    /// MinScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_min_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.MinScalar(left, right);
    }
    /// <summary>
    /// MoveScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_move_ss (Vector128<float> upper, Vector128<float> value)
    {
        return Sse.MoveScalar(upper, value);
    }
    /// <summary>
    /// MoveHighToLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_movehl_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.MoveHighToLow(left, right);
    }
    /// <summary>
    /// MoveLowToHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_movelh_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.MoveLowToHigh(left, right);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_movemask_ps (Vector128<float> value)
    {
        return Sse.MoveMask(value);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_mul_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Multiply(left, right);
    }
    /// <summary>
    /// MultiplyScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_mul_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.MultiplyScalar(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_or_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Or(left, right);
    }
    /// <summary>
    /// Prefetch0
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_prefetch (void* address)
    {
         Sse.Prefetch0(address);
    }
    /// <summary>
    /// Prefetch1
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_prefetch__1 (void* address)
    {
         Sse.Prefetch1(address);
    }
    /// <summary>
    /// Prefetch2
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_prefetch__2 (void* address)
    {
         Sse.Prefetch2(address);
    }
    /// <summary>
    /// PrefetchNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_prefetch__3 (void* address)
    {
         Sse.PrefetchNonTemporal(address);
    }
    /// <summary>
    /// Reciprocal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_rcp_ps (Vector128<float> value)
    {
        return Sse.Reciprocal(value);
    }
    /// <summary>
    /// ReciprocalScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_rcp_ss (Vector128<float> value)
    {
        return Sse.ReciprocalScalar(value);
    }
    /// <summary>
    /// ReciprocalScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_rcp_ss (Vector128<float> upper, Vector128<float> value)
    {
        return Sse.ReciprocalScalar(upper, value);
    }
    /// <summary>
    /// ReciprocalSqrt
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_rsqrt_ps (Vector128<float> value)
    {
        return Sse.ReciprocalSqrt(value);
    }
    /// <summary>
    /// ReciprocalSqrtScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_rsqrt_ss (Vector128<float> value)
    {
        return Sse.ReciprocalSqrtScalar(value);
    }
    /// <summary>
    /// ReciprocalSqrtScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_rsqrt_ss (Vector128<float> upper, Vector128<float> value)
    {
        return Sse.ReciprocalSqrtScalar(upper, value);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_shuffle_ps (Vector128<float> left, Vector128<float> right, byte control)
    {
        return Sse.Shuffle(left, right, control);
    }
    /// <summary>
    /// Sqrt
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_sqrt_ps (Vector128<float> value)
    {
        return Sse.Sqrt(value);
    }
    /// <summary>
    /// SqrtScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_sqrt_ss (Vector128<float> value)
    {
        return Sse.SqrtScalar(value);
    }
    /// <summary>
    /// SqrtScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_sqrt_ss (Vector128<float> upper, Vector128<float> value)
    {
        return Sse.SqrtScalar(upper, value);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_ps (float* address, Vector128<float> source)
    {
         Sse.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_ps (float* address, Vector128<float> source)
    {
         Sse.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_ps (float* address, Vector128<float> source)
    {
         Sse.Store(address, source);
    }
    /// <summary>
    /// StoreFence
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void _mm_sfence ()
    {
         Sse.StoreFence();
    }
    /// <summary>
    /// StoreScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_ss (float* address, Vector128<float> source)
    {
         Sse.StoreScalar(address, source);
    }
    /// <summary>
    /// StoreHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeh_pi (float* address, Vector128<float> source)
    {
         Sse.StoreHigh(address, source);
    }
    /// <summary>
    /// StoreLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storel_pi (float* address, Vector128<float> source)
    {
         Sse.StoreLow(address, source);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_sub_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Subtract(left, right);
    }
    /// <summary>
    /// SubtractScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_sub_ss (Vector128<float> left, Vector128<float> right)
    {
        return Sse.SubtractScalar(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_unpackhi_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_unpacklo_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.UnpackLow(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_xor_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse.Xor(left, right);
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

public class SSE2
{

    /// <summary>
    /// ConvertToInt64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long _mm_cvtsd_si64 (Vector128<double> value)
    {
        return Sse2.X64.ConvertToInt64(value);
    }
    /// <summary>
    /// ConvertToInt64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long _mm_cvtsi128_si64 (Vector128<long> value)
    {
        return Sse2.X64.ConvertToInt64(value);
    }
    /// <summary>
    /// ConvertToUInt64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong _mm_cvtsi128_si64 (Vector128<ulong> value)
    {
        return Sse2.X64.ConvertToUInt64(value);
    }
    /// <summary>
    /// ConvertScalarToVector128Double
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cvtsi64_sd (Vector128<double> upper, long value)
    {
        return Sse2.X64.ConvertScalarToVector128Double(upper, value);
    }
    /// <summary>
    /// ConvertScalarToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cvtsi64_si128 (long value)
    {
        return Sse2.X64.ConvertScalarToVector128Int64(value);
    }
    /// <summary>
    /// ConvertScalarToVector128UInt64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_cvtsi64_si128 (ulong value)
    {
        return Sse2.X64.ConvertScalarToVector128UInt64(value);
    }
    /// <summary>
    /// ConvertToInt64WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long _mm_cvttsd_si64 (Vector128<double> value)
    {
        return Sse2.X64.ConvertToInt64WithTruncation(value);
    }
    /// <summary>
    /// StoreNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si64 (long* address, long value)
    {
         Sse2.X64.StoreNonTemporal(address, value);
    }
    /// <summary>
    /// StoreNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si64 (ulong* address, ulong value)
    {
         Sse2.X64.StoreNonTemporal(address, value);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_add_epi8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_add_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_add_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_add_epi16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_add_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_add_epi32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_add_epi64 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_add_epi64 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_add_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Add(left, right);
    }
    /// <summary>
    /// AddScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_add_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.AddScalar(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_adds_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.AddSaturate(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_adds_epu8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.AddSaturate(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_adds_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.AddSaturate(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_adds_epu16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.AddSaturate(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_and_si128 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_and_si128 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_and_si128 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_and_si128 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_and_si128 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_and_si128 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_and_si128 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_and_si128 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_and_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.And(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_andnot_si128 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_andnot_si128 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_andnot_si128 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_andnot_si128 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_andnot_si128 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_andnot_si128 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_andnot_si128 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_andnot_si128 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_andnot_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.AndNot(left, right);
    }
    /// <summary>
    /// Average
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_avg_epu8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.Average(left, right);
    }
    /// <summary>
    /// Average
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_avg_epu16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.Average(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_cmpeq_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_cmpeq_epi8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_cmpeq_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_cmpeq_epi16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cmpeq_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_cmpeq_epi32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpeq_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comieq_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarOrderedEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomieq_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarUnorderedEqual(left, right);
    }
    /// <summary>
    /// CompareScalarEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpeq_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarEqual(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_cmpgt_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_cmpgt_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cmpgt_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpgt_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comigt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarOrderedGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomigt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarUnorderedGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpgt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpge_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comige_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarOrderedGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomige_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarUnorderedGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpge_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_cmplt_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.CompareLessThan(left, right);
    }
    /// <summary>
    /// CompareLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_cmplt_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.CompareLessThan(left, right);
    }
    /// <summary>
    /// CompareLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cmplt_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.CompareLessThan(left, right);
    }
    /// <summary>
    /// CompareLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmplt_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comilt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarOrderedLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomilt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarUnorderedLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmplt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarLessThan(left, right);
    }
    /// <summary>
    /// CompareLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmple_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comile_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarOrderedLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomile_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarUnorderedLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmple_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpneq_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareNotEqual(left, right);
    }
    /// <summary>
    /// CompareScalarOrderedNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_comineq_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarOrderedNotEqual(left, right);
    }
    /// <summary>
    /// CompareScalarUnorderedNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_ucomineq_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarUnorderedNotEqual(left, right);
    }
    /// <summary>
    /// CompareScalarNotEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpneq_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarNotEqual(left, right);
    }
    /// <summary>
    /// CompareNotGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpngt_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareNotGreaterThan(left, right);
    }
    /// <summary>
    /// CompareScalarNotGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpngt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarNotGreaterThan(left, right);
    }
    /// <summary>
    /// CompareNotGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpnge_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareNotGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarNotGreaterThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpnge_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarNotGreaterThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareNotLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpnlt_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareNotLessThan(left, right);
    }
    /// <summary>
    /// CompareScalarNotLessThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpnlt_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarNotLessThan(left, right);
    }
    /// <summary>
    /// CompareNotLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpnle_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareNotLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareScalarNotLessThanOrEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpnle_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarNotLessThanOrEqual(left, right);
    }
    /// <summary>
    /// CompareOrdered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpord_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareOrdered(left, right);
    }
    /// <summary>
    /// CompareScalarOrdered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpord_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarOrdered(left, right);
    }
    /// <summary>
    /// CompareUnordered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpunord_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareUnordered(left, right);
    }
    /// <summary>
    /// CompareScalarUnordered
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmpunord_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.CompareScalarUnordered(left, right);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvtps_epi32 (Vector128<float> value)
    {
        return Sse2.ConvertToVector128Int32(value);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvtpd_epi32 (Vector128<double> value)
    {
        return Sse2.ConvertToVector128Int32(value);
    }
    /// <summary>
    /// ConvertToVector128Single
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cvtepi32_ps (Vector128<int> value)
    {
        return Sse2.ConvertToVector128Single(value);
    }
    /// <summary>
    /// ConvertToVector128Single
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cvtpd_ps (Vector128<double> value)
    {
        return Sse2.ConvertToVector128Single(value);
    }
    /// <summary>
    /// ConvertToVector128Double
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cvtepi32_pd (Vector128<int> value)
    {
        return Sse2.ConvertToVector128Double(value);
    }
    /// <summary>
    /// ConvertToVector128Double
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cvtps_pd (Vector128<float> value)
    {
        return Sse2.ConvertToVector128Double(value);
    }
    /// <summary>
    /// ConvertToInt32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_cvtsd_si32 (Vector128<double> value)
    {
        return Sse2.ConvertToInt32(value);
    }
    /// <summary>
    /// ConvertToInt32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_cvtsi128_si32 (Vector128<int> value)
    {
        return Sse2.ConvertToInt32(value);
    }
    /// <summary>
    /// ConvertToUInt32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint _mm_cvtsi128_si32 (Vector128<uint> value)
    {
        return Sse2.ConvertToUInt32(value);
    }
    /// <summary>
    /// ConvertScalarToVector128Double
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cvtsi32_sd (Vector128<double> upper, int value)
    {
        return Sse2.ConvertScalarToVector128Double(upper, value);
    }
    /// <summary>
    /// ConvertScalarToVector128Double
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cvtss_sd (Vector128<double> upper, Vector128<float> value)
    {
        return Sse2.ConvertScalarToVector128Double(upper, value);
    }
    /// <summary>
    /// ConvertScalarToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvtsi32_si128 (int value)
    {
        return Sse2.ConvertScalarToVector128Int32(value);
    }
    /// <summary>
    /// ConvertScalarToVector128Single
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cvtsd_ss (Vector128<float> upper, Vector128<double> value)
    {
        return Sse2.ConvertScalarToVector128Single(upper, value);
    }
    /// <summary>
    /// ConvertScalarToVector128UInt32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_cvtsi32_si128 (uint value)
    {
        return Sse2.ConvertScalarToVector128UInt32(value);
    }
    /// <summary>
    /// ConvertToVector128Int32WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvttps_epi32 (Vector128<float> value)
    {
        return Sse2.ConvertToVector128Int32WithTruncation(value);
    }
    /// <summary>
    /// ConvertToVector128Int32WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvttpd_epi32 (Vector128<double> value)
    {
        return Sse2.ConvertToVector128Int32WithTruncation(value);
    }
    /// <summary>
    /// ConvertToInt32WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_cvttsd_si32 (Vector128<double> value)
    {
        return Sse2.ConvertToInt32WithTruncation(value);
    }
    /// <summary>
    /// Divide
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_div_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Divide(left, right);
    }
    /// <summary>
    /// DivideScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_div_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.DivideScalar(left, right);
    }
    /// <summary>
    /// Extract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ushort _mm_extract_epi16 (Vector128<ushort> value, byte index)
    {
        return Sse2.Extract(value, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_insert_epi16 (Vector128<short> value, short data, byte index)
    {
        return Sse2.Insert(value, data, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_insert_epi16 (Vector128<ushort> value, ushort data, byte index)
    {
        return Sse2.Insert(value, data, index);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<sbyte> _mm_loadu_si128 (sbyte* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<byte> _mm_loadu_si128 (byte* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<short> _mm_loadu_si128 (short* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ushort> _mm_loadu_si128 (ushort* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_loadu_si128 (int* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_loadu_si128 (uint* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_loadu_si128 (long* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_loadu_si128 (ulong* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_loadu_pd (double* address)
    {
        return Sse2.LoadVector128(address);
    }
    /// <summary>
    /// LoadScalarVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_load_sd (double* address)
    {
        return Sse2.LoadScalarVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<sbyte> _mm_load_si128 (sbyte* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<byte> _mm_load_si128 (byte* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<short> _mm_load_si128 (short* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ushort> _mm_load_si128 (ushort* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_load_si128 (int* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_load_si128 (uint* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_load_si128 (long* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_load_si128 (ulong* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadAlignedVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_load_pd (double* address)
    {
        return Sse2.LoadAlignedVector128(address);
    }
    /// <summary>
    /// LoadFence
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void _mm_lfence ()
    {
         Sse2.LoadFence();
    }
    /// <summary>
    /// LoadHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_loadh_pd (Vector128<double> lower, double* address)
    {
        return Sse2.LoadHigh(lower, address);
    }
    /// <summary>
    /// LoadLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_loadl_pd (Vector128<double> upper, double* address)
    {
        return Sse2.LoadLow(upper, address);
    }
    /// <summary>
    /// LoadScalarVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_loadu_si32 (int* address)
    {
        return Sse2.LoadScalarVector128(address);
    }
    /// <summary>
    /// LoadScalarVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_loadu_si32 (uint* address)
    {
        return Sse2.LoadScalarVector128(address);
    }
    /// <summary>
    /// LoadScalarVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_loadl_epi64 (long* address)
    {
        return Sse2.LoadScalarVector128(address);
    }
    /// <summary>
    /// LoadScalarVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_loadl_epi64 (ulong* address)
    {
        return Sse2.LoadScalarVector128(address);
    }
    /// <summary>
    /// MaskMove
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskmoveu_si128 (Vector128<sbyte> source, Vector128<sbyte> mask, sbyte* address)
    {
         Sse2.MaskMove(source, mask, address);
    }
    /// <summary>
    /// MaskMove
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskmoveu_si128 (Vector128<byte> source, Vector128<byte> mask, byte* address)
    {
         Sse2.MaskMove(source, mask, address);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_max_epu8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_max_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_max_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Max(left, right);
    }
    /// <summary>
    /// MaxScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_max_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.MaxScalar(left, right);
    }
    /// <summary>
    /// MemoryFence
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static void _mm_mfence ()
    {
         Sse2.MemoryFence();
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_min_epu8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_min_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_min_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Min(left, right);
    }
    /// <summary>
    /// MinScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_min_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.MinScalar(left, right);
    }
    /// <summary>
    /// MoveScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_move_sd (Vector128<double> upper, Vector128<double> value)
    {
        return Sse2.MoveScalar(upper, value);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_movemask_epi8 (Vector128<sbyte> value)
    {
        return Sse2.MoveMask(value);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_movemask_epi8 (Vector128<byte> value)
    {
        return Sse2.MoveMask(value);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_movemask_pd (Vector128<double> value)
    {
        return Sse2.MoveMask(value);
    }
    /// <summary>
    /// MoveScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_move_epi64 (Vector128<long> value)
    {
        return Sse2.MoveScalar(value);
    }
    /// <summary>
    /// MoveScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_move_epi64 (Vector128<ulong> value)
    {
        return Sse2.MoveScalar(value);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_mul_epu32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.Multiply(left, right);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_mul_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Multiply(left, right);
    }
    /// <summary>
    /// MultiplyScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_mul_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.MultiplyScalar(left, right);
    }
    /// <summary>
    /// MultiplyHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_mulhi_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.MultiplyHigh(left, right);
    }
    /// <summary>
    /// MultiplyHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_mulhi_epu16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.MultiplyHigh(left, right);
    }
    /// <summary>
    /// MultiplyAddAdjacent
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_madd_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.MultiplyAddAdjacent(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_mullo_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.MultiplyLow(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_mullo_epi16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.MultiplyLow(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_or_si128 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_or_si128 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_or_si128 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_or_si128 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_or_si128 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_or_si128 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_or_si128 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_or_si128 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_or_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Or(left, right);
    }
    /// <summary>
    /// PackSignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_packs_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.PackSignedSaturate(left, right);
    }
    /// <summary>
    /// PackSignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_packs_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.PackSignedSaturate(left, right);
    }
    /// <summary>
    /// PackUnsignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_packus_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.PackUnsignedSaturate(left, right);
    }
    /// <summary>
    /// SumAbsoluteDifferences
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_sad_epu8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.SumAbsoluteDifferences(left, right);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_shuffle_epi32 (Vector128<int> value, byte control)
    {
        return Sse2.Shuffle(value, control);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_shuffle_epi32 (Vector128<uint> value, byte control)
    {
        return Sse2.Shuffle(value, control);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_shuffle_pd (Vector128<double> left, Vector128<double> right, byte control)
    {
        return Sse2.Shuffle(left, right, control);
    }
    /// <summary>
    /// ShuffleHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_shufflehi_epi16 (Vector128<short> value, byte control)
    {
        return Sse2.ShuffleHigh(value, control);
    }
    /// <summary>
    /// ShuffleHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_shufflehi_epi16 (Vector128<ushort> value, byte control)
    {
        return Sse2.ShuffleHigh(value, control);
    }
    /// <summary>
    /// ShuffleLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_shufflelo_epi16 (Vector128<short> value, byte control)
    {
        return Sse2.ShuffleLow(value, control);
    }
    /// <summary>
    /// ShuffleLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_shufflelo_epi16 (Vector128<ushort> value, byte control)
    {
        return Sse2.ShuffleLow(value, control);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_sll_epi16 (Vector128<short> value, Vector128<short> count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_sll_epi16 (Vector128<ushort> value, Vector128<ushort> count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_sll_epi32 (Vector128<int> value, Vector128<int> count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_sll_epi32 (Vector128<uint> value, Vector128<uint> count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_sll_epi64 (Vector128<long> value, Vector128<long> count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_sll_epi64 (Vector128<ulong> value, Vector128<ulong> count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_slli_epi16 (Vector128<short> value, byte count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_slli_epi16 (Vector128<ushort> value, byte count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_slli_epi32 (Vector128<int> value, byte count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_slli_epi32 (Vector128<uint> value, byte count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_slli_epi64 (Vector128<long> value, byte count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_slli_epi64 (Vector128<ulong> value, byte count)
    {
        return Sse2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_bslli_si128 (Vector128<sbyte> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_bslli_si128 (Vector128<byte> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_bslli_si128 (Vector128<short> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_bslli_si128 (Vector128<ushort> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_bslli_si128 (Vector128<int> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_bslli_si128 (Vector128<uint> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_bslli_si128 (Vector128<long> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_bslli_si128 (Vector128<ulong> value, byte numBytes)
    {
        return Sse2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_sra_epi16 (Vector128<short> value, Vector128<short> count)
    {
        return Sse2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_sra_epi32 (Vector128<int> value, Vector128<int> count)
    {
        return Sse2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_srai_epi16 (Vector128<short> value, byte count)
    {
        return Sse2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_srai_epi32 (Vector128<int> value, byte count)
    {
        return Sse2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_srl_epi16 (Vector128<short> value, Vector128<short> count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_srl_epi16 (Vector128<ushort> value, Vector128<ushort> count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_srl_epi32 (Vector128<int> value, Vector128<int> count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_srl_epi32 (Vector128<uint> value, Vector128<uint> count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_srl_epi64 (Vector128<long> value, Vector128<long> count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_srl_epi64 (Vector128<ulong> value, Vector128<ulong> count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_srli_epi16 (Vector128<short> value, byte count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_srli_epi16 (Vector128<ushort> value, byte count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_srli_epi32 (Vector128<int> value, byte count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_srli_epi32 (Vector128<uint> value, byte count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_srli_epi64 (Vector128<long> value, byte count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_srli_epi64 (Vector128<ulong> value, byte count)
    {
        return Sse2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_bsrli_si128 (Vector128<sbyte> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_bsrli_si128 (Vector128<byte> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_bsrli_si128 (Vector128<short> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_bsrli_si128 (Vector128<ushort> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_bsrli_si128 (Vector128<int> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_bsrli_si128 (Vector128<uint> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_bsrli_si128 (Vector128<long> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_bsrli_si128 (Vector128<ulong> value, byte numBytes)
    {
        return Sse2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// Sqrt
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_sqrt_pd (Vector128<double> value)
    {
        return Sse2.Sqrt(value);
    }
    /// <summary>
    /// SqrtScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_sqrt_sd (Vector128<double> value)
    {
        return Sse2.SqrtScalar(value);
    }
    /// <summary>
    /// SqrtScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_sqrt_sd (Vector128<double> upper, Vector128<double> value)
    {
        return Sse2.SqrtScalar(upper, value);
    }
    /// <summary>
    /// StoreScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_sd (double* address, Vector128<double> source)
    {
         Sse2.StoreScalar(address, source);
    }
    /// <summary>
    /// StoreScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storel_epi64 (long* address, Vector128<long> source)
    {
         Sse2.StoreScalar(address, source);
    }
    /// <summary>
    /// StoreScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storel_epi64 (ulong* address, Vector128<ulong> source)
    {
         Sse2.StoreScalar(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (sbyte* address, Vector128<sbyte> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (byte* address, Vector128<byte> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (short* address, Vector128<short> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (ushort* address, Vector128<ushort> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (int* address, Vector128<int> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (uint* address, Vector128<uint> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (long* address, Vector128<long> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_si128 (ulong* address, Vector128<ulong> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_store_pd (double* address, Vector128<double> source)
    {
         Sse2.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (sbyte* address, Vector128<sbyte> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (byte* address, Vector128<byte> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (short* address, Vector128<short> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (ushort* address, Vector128<ushort> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (int* address, Vector128<int> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (uint* address, Vector128<uint> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (long* address, Vector128<long> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si128 (ulong* address, Vector128<ulong> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_pd (double* address, Vector128<double> source)
    {
         Sse2.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (sbyte* address, Vector128<sbyte> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (byte* address, Vector128<byte> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (short* address, Vector128<short> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (ushort* address, Vector128<ushort> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (int* address, Vector128<int> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (uint* address, Vector128<uint> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (long* address, Vector128<long> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_si128 (ulong* address, Vector128<ulong> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeu_pd (double* address, Vector128<double> source)
    {
         Sse2.Store(address, source);
    }
    /// <summary>
    /// StoreHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storeh_pd (double* address, Vector128<double> source)
    {
         Sse2.StoreHigh(address, source);
    }
    /// <summary>
    /// StoreLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_storel_pd (double* address, Vector128<double> source)
    {
         Sse2.StoreLow(address, source);
    }
    /// <summary>
    /// StoreNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si32 (int* address, int value)
    {
         Sse2.StoreNonTemporal(address, value);
    }
    /// <summary>
    /// StoreNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_stream_si32 (uint* address, uint value)
    {
         Sse2.StoreNonTemporal(address, value);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_sub_epi8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_sub_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_sub_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_sub_epi16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_sub_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_sub_epi32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_sub_epi64 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_sub_epi64 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_sub_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Subtract(left, right);
    }
    /// <summary>
    /// SubtractScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_sub_sd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.SubtractScalar(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_subs_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_subs_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_subs_epu8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_subs_epu16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_unpackhi_epi8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_unpackhi_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_unpackhi_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_unpackhi_epi16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_unpackhi_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_unpackhi_epi32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_unpackhi_epi64 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_unpackhi_epi64 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_unpackhi_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_unpacklo_epi8 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_unpacklo_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_unpacklo_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_unpacklo_epi16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_unpacklo_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_unpacklo_epi32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_unpacklo_epi64 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_unpacklo_epi64 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_unpacklo_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.UnpackLow(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_xor_si128 (Vector128<byte> left, Vector128<byte> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_xor_si128 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_xor_si128 (Vector128<short> left, Vector128<short> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_xor_si128 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_xor_si128 (Vector128<int> left, Vector128<int> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_xor_si128 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_xor_si128 (Vector128<long> left, Vector128<long> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_xor_si128 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_xor_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse2.Xor(left, right);
    }
}

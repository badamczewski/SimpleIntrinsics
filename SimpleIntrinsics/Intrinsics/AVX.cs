using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

public class AVX
{

    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_add_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_add_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Add(left, right);
    }
    /// <summary>
    /// AddSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_addsub_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.AddSubtract(left, right);
    }
    /// <summary>
    /// AddSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_addsub_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.AddSubtract(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_and_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_and_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.And(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_andnot_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_andnot_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.AndNot(left, right);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_blend_ps (Vector256<float> left, Vector256<float> right, byte control)
    {
        return Avx.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_blend_pd (Vector256<double> left, Vector256<double> right, byte control)
    {
        return Avx.Blend(left, right, control);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_blendv_ps (Vector256<float> left, Vector256<float> right, Vector256<float> mask)
    {
        return Avx.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_blendv_pd (Vector256<double> left, Vector256<double> right, Vector256<double> mask)
    {
        return Avx.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_broadcast_ss (float* source)
    {
        return Avx.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<float> _mm256_broadcast_ss (float* source)
    {
        return Avx.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_broadcast_sd (double* source)
    {
        return Avx.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<float> _mm256_broadcast_ps (float* address)
    {
        return Avx.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_broadcast_pd (double* address)
    {
        return Avx.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// Ceiling
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_ceil_ps (Vector256<float> value)
    {
        return Avx.Ceiling(value);
    }
    /// <summary>
    /// Ceiling
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_ceil_pd (Vector256<double> value)
    {
        return Avx.Ceiling(value);
    }
    /// <summary>
    /// Compare
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmp_ps (Vector128<float> left, Vector128<float> right, FloatComparisonMode mode)
    {
        return Avx.Compare(left, right, mode);
    }
    /// <summary>
    /// Compare
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmp_pd (Vector128<double> left, Vector128<double> right, FloatComparisonMode mode)
    {
        return Avx.Compare(left, right, mode);
    }
    /// <summary>
    /// Compare
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_cmp_ps (Vector256<float> left, Vector256<float> right, FloatComparisonMode mode)
    {
        return Avx.Compare(left, right, mode);
    }
    /// <summary>
    /// Compare
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_cmp_pd (Vector256<double> left, Vector256<double> right, FloatComparisonMode mode)
    {
        return Avx.Compare(left, right, mode);
    }
    /// <summary>
    /// CompareScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_cmp_sd (Vector128<double> left, Vector128<double> right, FloatComparisonMode mode)
    {
        return Avx.CompareScalar(left, right, mode);
    }
    /// <summary>
    /// CompareScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_cmp_ss (Vector128<float> left, Vector128<float> right, FloatComparisonMode mode)
    {
        return Avx.CompareScalar(left, right, mode);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm256_cvtpd_epi32 (Vector256<double> value)
    {
        return Avx.ConvertToVector128Int32(value);
    }
    /// <summary>
    /// ConvertToVector128Single
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm256_cvtpd_ps (Vector256<double> value)
    {
        return Avx.ConvertToVector128Single(value);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cvtps_epi32 (Vector256<float> value)
    {
        return Avx.ConvertToVector256Int32(value);
    }
    /// <summary>
    /// ConvertToVector256Single
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_cvtepi32_ps (Vector256<int> value)
    {
        return Avx.ConvertToVector256Single(value);
    }
    /// <summary>
    /// ConvertToVector256Double
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_cvtps_pd (Vector128<float> value)
    {
        return Avx.ConvertToVector256Double(value);
    }
    /// <summary>
    /// ConvertToVector256Double
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_cvtepi32_pd (Vector128<int> value)
    {
        return Avx.ConvertToVector256Double(value);
    }
    /// <summary>
    /// ConvertToVector128Int32WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm256_cvttpd_epi32 (Vector256<double> value)
    {
        return Avx.ConvertToVector128Int32WithTruncation(value);
    }
    /// <summary>
    /// ConvertToVector256Int32WithTruncation
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cvttps_epi32 (Vector256<float> value)
    {
        return Avx.ConvertToVector256Int32WithTruncation(value);
    }
    /// <summary>
    /// Divide
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_div_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Divide(left, right);
    }
    /// <summary>
    /// Divide
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_div_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Divide(left, right);
    }
    /// <summary>
    /// DotProduct
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_dp_ps (Vector256<float> left, Vector256<float> right, byte control)
    {
        return Avx.DotProduct(left, right, control);
    }
    /// <summary>
    /// DuplicateEvenIndexed
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_moveldup_ps (Vector256<float> value)
    {
        return Avx.DuplicateEvenIndexed(value);
    }
    /// <summary>
    /// DuplicateEvenIndexed
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_movedup_pd (Vector256<double> value)
    {
        return Avx.DuplicateEvenIndexed(value);
    }
    /// <summary>
    /// DuplicateOddIndexed
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_movehdup_ps (Vector256<float> value)
    {
        return Avx.DuplicateOddIndexed(value);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm256_extractf128_si256 (Vector256<byte> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm256_extractf128_si256 (Vector256<sbyte> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm256_extractf128_si256 (Vector256<short> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm256_extractf128_si256 (Vector256<ushort> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm256_extractf128_si256 (Vector256<int> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm256_extractf128_si256 (Vector256<uint> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm256_extractf128_si256 (Vector256<long> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm256_extractf128_si256 (Vector256<ulong> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm256_extractf128_ps (Vector256<float> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm256_extractf128_pd (Vector256<double> value, byte index)
    {
        return Avx.ExtractVector128(value, index);
    }
    /// <summary>
    /// Floor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_floor_ps (Vector256<float> value)
    {
        return Avx.Floor(value);
    }
    /// <summary>
    /// Floor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_floor_pd (Vector256<double> value)
    {
        return Avx.Floor(value);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_hadd_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_hadd_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_hsub_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_hsub_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_insertf128_si256 (Vector256<byte> value, Vector128<byte> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_insertf128_si256 (Vector256<sbyte> value, Vector128<sbyte> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_insertf128_si256 (Vector256<short> value, Vector128<short> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_insertf128_si256 (Vector256<ushort> value, Vector128<ushort> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_insertf128_si256 (Vector256<int> value, Vector128<int> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_insertf128_si256 (Vector256<uint> value, Vector128<uint> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_insertf128_si256 (Vector256<long> value, Vector128<long> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_insertf128_si256 (Vector256<ulong> value, Vector128<ulong> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_insertf128_ps (Vector256<float> value, Vector128<float> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_insertf128_pd (Vector256<double> value, Vector128<double> data, byte index)
    {
        return Avx.InsertVector128(value, data, index);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<sbyte> _mm256_loadu_si256 (sbyte* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<byte> _mm256_loadu_si256 (byte* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> _mm256_loadu_si256 (short* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ushort> _mm256_loadu_si256 (ushort* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_loadu_si256 (int* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_loadu_si256 (uint* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_loadu_si256 (long* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_loadu_si256 (ulong* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<float> _mm256_loadu_ps (float* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_loadu_pd (double* address)
    {
        return Avx.LoadVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<sbyte> _mm256_load_si256 (sbyte* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<byte> _mm256_load_si256 (byte* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> _mm256_load_si256 (short* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ushort> _mm256_load_si256 (ushort* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_load_si256 (int* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_load_si256 (uint* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_load_si256 (long* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_load_si256 (ulong* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<float> _mm256_load_ps (float* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadAlignedVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_load_pd (double* address)
    {
        return Avx.LoadAlignedVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<sbyte> _mm256_lddqu_si256 (sbyte* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<byte> _mm256_lddqu_si256 (byte* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> _mm256_lddqu_si256 (short* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ushort> _mm256_lddqu_si256 (ushort* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_lddqu_si256 (int* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_lddqu_si256 (uint* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_lddqu_si256 (long* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// LoadDquVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_lddqu_si256 (ulong* address)
    {
        return Avx.LoadDquVector256(address);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_maskload_ps (float* address, Vector128<float> mask)
    {
        return Avx.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_maskload_pd (double* address, Vector128<double> mask)
    {
        return Avx.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<float> _mm256_maskload_ps (float* address, Vector256<float> mask)
    {
        return Avx.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_maskload_pd (double* address, Vector256<double> mask)
    {
        return Avx.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskstore_ps (float* address, Vector128<float> mask, Vector128<float> source)
    {
         Avx.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskstore_pd (double* address, Vector128<double> mask, Vector128<double> source)
    {
         Avx.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_maskstore_ps (float* address, Vector256<float> mask, Vector256<float> source)
    {
         Avx.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_maskstore_pd (double* address, Vector256<double> mask, Vector256<double> source)
    {
         Avx.MaskStore(address, mask, source);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_max_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_max_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Max(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_min_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_min_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Min(left, right);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm256_movemask_ps (Vector256<float> value)
    {
        return Avx.MoveMask(value);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm256_movemask_pd (Vector256<double> value)
    {
        return Avx.MoveMask(value);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_mul_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Multiply(left, right);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_mul_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Multiply(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_or_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_or_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Or(left, right);
    }
    /// <summary>
    /// Permute
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_permute_ps (Vector128<float> value, byte control)
    {
        return Avx.Permute(value, control);
    }
    /// <summary>
    /// Permute
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_permute_pd (Vector128<double> value, byte control)
    {
        return Avx.Permute(value, control);
    }
    /// <summary>
    /// Permute
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_permute_ps (Vector256<float> value, byte control)
    {
        return Avx.Permute(value, control);
    }
    /// <summary>
    /// Permute
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_permute_pd (Vector256<double> value, byte control)
    {
        return Avx.Permute(value, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_permute2f128_si256 (Vector256<byte> left, Vector256<byte> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_permute2f128_si256 (Vector256<sbyte> left, Vector256<sbyte> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_permute2f128_si256 (Vector256<short> left, Vector256<short> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_permute2f128_si256 (Vector256<ushort> left, Vector256<ushort> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_permute2f128_si256 (Vector256<int> left, Vector256<int> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_permute2f128_si256 (Vector256<uint> left, Vector256<uint> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_permute2f128_si256 (Vector256<long> left, Vector256<long> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_permute2f128_si256 (Vector256<ulong> left, Vector256<ulong> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_permute2f128_ps (Vector256<float> left, Vector256<float> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_permute2f128_pd (Vector256<double> left, Vector256<double> right, byte control)
    {
        return Avx.Permute2x128(left, right, control);
    }
    /// <summary>
    /// PermuteVar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_permutevar_ps (Vector128<float> left, Vector128<int> control)
    {
        return Avx.PermuteVar(left, control);
    }
    /// <summary>
    /// PermuteVar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_permutevar_pd (Vector128<double> left, Vector128<long> control)
    {
        return Avx.PermuteVar(left, control);
    }
    /// <summary>
    /// PermuteVar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_permutevar_ps (Vector256<float> left, Vector256<int> control)
    {
        return Avx.PermuteVar(left, control);
    }
    /// <summary>
    /// PermuteVar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_permutevar_pd (Vector256<double> left, Vector256<long> control)
    {
        return Avx.PermuteVar(left, control);
    }
    /// <summary>
    /// Reciprocal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_rcp_ps (Vector256<float> value)
    {
        return Avx.Reciprocal(value);
    }
    /// <summary>
    /// ReciprocalSqrt
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_rsqrt_ps (Vector256<float> value)
    {
        return Avx.ReciprocalSqrt(value);
    }
    /// <summary>
    /// RoundToNearestInteger
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_round_ps (Vector256<float> value)
    {
        return Avx.RoundToNearestInteger(value);
    }
    /// <summary>
    /// RoundToNegativeInfinity
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_round_ps__1 (Vector256<float> value)
    {
        return Avx.RoundToNegativeInfinity(value);
    }
    /// <summary>
    /// RoundToPositiveInfinity
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_round_ps__2 (Vector256<float> value)
    {
        return Avx.RoundToPositiveInfinity(value);
    }
    /// <summary>
    /// RoundToZero
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_round_ps__3 (Vector256<float> value)
    {
        return Avx.RoundToZero(value);
    }
    /// <summary>
    /// RoundCurrentDirection
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_round_ps__4 (Vector256<float> value)
    {
        return Avx.RoundCurrentDirection(value);
    }
    /// <summary>
    /// RoundToNearestInteger
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_round_pd (Vector256<double> value)
    {
        return Avx.RoundToNearestInteger(value);
    }
    /// <summary>
    /// RoundToNegativeInfinity
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_round_pd__1 (Vector256<double> value)
    {
        return Avx.RoundToNegativeInfinity(value);
    }
    /// <summary>
    /// RoundToPositiveInfinity
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_round_pd__2 (Vector256<double> value)
    {
        return Avx.RoundToPositiveInfinity(value);
    }
    /// <summary>
    /// RoundToZero
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_round_pd__3 (Vector256<double> value)
    {
        return Avx.RoundToZero(value);
    }
    /// <summary>
    /// RoundCurrentDirection
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_round_pd__4 (Vector256<double> value)
    {
        return Avx.RoundCurrentDirection(value);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_shuffle_ps (Vector256<float> value, Vector256<float> right, byte control)
    {
        return Avx.Shuffle(value, right, control);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_shuffle_pd (Vector256<double> value, Vector256<double> right, byte control)
    {
        return Avx.Shuffle(value, right, control);
    }
    /// <summary>
    /// Sqrt
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_sqrt_ps (Vector256<float> value)
    {
        return Avx.Sqrt(value);
    }
    /// <summary>
    /// Sqrt
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_sqrt_pd (Vector256<double> value)
    {
        return Avx.Sqrt(value);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (sbyte* address, Vector256<sbyte> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (byte* address, Vector256<byte> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (short* address, Vector256<short> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (ushort* address, Vector256<ushort> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (int* address, Vector256<int> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (uint* address, Vector256<uint> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (long* address, Vector256<long> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_si256 (ulong* address, Vector256<ulong> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_ps (float* address, Vector256<float> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAligned
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_store_pd (double* address, Vector256<double> source)
    {
         Avx.StoreAligned(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (sbyte* address, Vector256<sbyte> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (byte* address, Vector256<byte> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (short* address, Vector256<short> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (ushort* address, Vector256<ushort> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (int* address, Vector256<int> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (uint* address, Vector256<uint> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (long* address, Vector256<long> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_si256 (ulong* address, Vector256<ulong> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_ps (float* address, Vector256<float> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// StoreAlignedNonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_stream_pd (double* address, Vector256<double> source)
    {
         Avx.StoreAlignedNonTemporal(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (sbyte* address, Vector256<sbyte> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (byte* address, Vector256<byte> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (short* address, Vector256<short> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (ushort* address, Vector256<ushort> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (int* address, Vector256<int> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (uint* address, Vector256<uint> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (long* address, Vector256<long> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_si256 (ulong* address, Vector256<ulong> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_ps (float* address, Vector256<float> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Store
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_storeu_pd (double* address, Vector256<double> source)
    {
         Avx.Store(address, source);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_sub_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_sub_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Subtract(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testc_ps (Vector128<float> left, Vector128<float> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testc_pd (Vector128<double> left, Vector128<double> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<short> left, Vector256<short> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<int> left, Vector256<int> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<long> left, Vector256<long> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_si256 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testc_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.TestC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testnzc_ps (Vector128<float> left, Vector128<float> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testnzc_pd (Vector128<double> left, Vector128<double> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<short> left, Vector256<short> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<int> left, Vector256<int> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<long> left, Vector256<long> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_si256 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testnzc_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testz_ps (Vector128<float> left, Vector128<float> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testz_pd (Vector128<double> left, Vector128<double> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<short> left, Vector256<short> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<int> left, Vector256<int> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<long> left, Vector256<long> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_si256 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm256_testz_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.TestZ(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_unpackhi_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_unpackhi_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_unpacklo_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_unpacklo_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.UnpackLow(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_xor_ps (Vector256<float> left, Vector256<float> right)
    {
        return Avx.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_xor_pd (Vector256<double> left, Vector256<double> right)
    {
        return Avx.Xor(left, right);
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

public class AVX2
{

    /// <summary>
    /// Abs
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_abs_epi8 (Vector256<sbyte> value)
    {
        return Avx2.Abs(value);
    }
    /// <summary>
    /// Abs
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_abs_epi16 (Vector256<short> value)
    {
        return Avx2.Abs(value);
    }
    /// <summary>
    /// Abs
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_abs_epi32 (Vector256<int> value)
    {
        return Avx2.Abs(value);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_add_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_add_epi8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_add_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_add_epi16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_add_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_add_epi32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_add_epi64 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// Add
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_add_epi64 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.Add(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_adds_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.AddSaturate(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_adds_epu8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.AddSaturate(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_adds_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.AddSaturate(left, right);
    }
    /// <summary>
    /// AddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_adds_epu16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.AddSaturate(left, right);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_alignr_epi8 (Vector256<sbyte> left, Vector256<sbyte> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_alignr_epi8 (Vector256<byte> left, Vector256<byte> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_alignr_epi8 (Vector256<short> left, Vector256<short> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_alignr_epi8 (Vector256<ushort> left, Vector256<ushort> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_alignr_epi8 (Vector256<int> left, Vector256<int> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_alignr_epi8 (Vector256<uint> left, Vector256<uint> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_alignr_epi8 (Vector256<long> left, Vector256<long> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_alignr_epi8 (Vector256<ulong> left, Vector256<ulong> right, byte mask)
    {
        return Avx2.AlignRight(left, right, mask);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_and_si256 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_and_si256 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_and_si256 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_and_si256 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_and_si256 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_and_si256 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_and_si256 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// And
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_and_si256 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.And(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_andnot_si256 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_andnot_si256 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_andnot_si256 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_andnot_si256 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_andnot_si256 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_andnot_si256 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_andnot_si256 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// AndNot
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_andnot_si256 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.AndNot(left, right);
    }
    /// <summary>
    /// Average
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_avg_epu8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.Average(left, right);
    }
    /// <summary>
    /// Average
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_avg_epu16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.Average(left, right);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_blend_epi32 (Vector128<int> left, Vector128<int> right, byte control)
    {
        return Avx2.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_blend_epi32 (Vector128<uint> left, Vector128<uint> right, byte control)
    {
        return Avx2.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_blend_epi16 (Vector256<short> left, Vector256<short> right, byte control)
    {
        return Avx2.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_blend_epi16 (Vector256<ushort> left, Vector256<ushort> right, byte control)
    {
        return Avx2.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_blend_epi32 (Vector256<int> left, Vector256<int> right, byte control)
    {
        return Avx2.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_blend_epi32 (Vector256<uint> left, Vector256<uint> right, byte control)
    {
        return Avx2.Blend(left, right, control);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_blendv_epi8 (Vector256<sbyte> left, Vector256<sbyte> right, Vector256<sbyte> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_blendv_epi8 (Vector256<byte> left, Vector256<byte> right, Vector256<byte> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_blendv_epi8 (Vector256<short> left, Vector256<short> right, Vector256<short> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_blendv_epi8 (Vector256<ushort> left, Vector256<ushort> right, Vector256<ushort> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_blendv_epi8 (Vector256<int> left, Vector256<int> right, Vector256<int> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_blendv_epi8 (Vector256<uint> left, Vector256<uint> right, Vector256<uint> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_blendv_epi8 (Vector256<long> left, Vector256<long> right, Vector256<long> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_blendv_epi8 (Vector256<ulong> left, Vector256<ulong> right, Vector256<ulong> mask)
    {
        return Avx2.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_broadcastb_epi8 (Vector128<byte> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_broadcastb_epi8 (Vector128<sbyte> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_broadcastw_epi16 (Vector128<short> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_broadcastw_epi16 (Vector128<ushort> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_broadcastd_epi32 (Vector128<int> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_broadcastd_epi32 (Vector128<uint> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_broadcastq_epi64 (Vector128<long> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_broadcastq_epi64 (Vector128<ulong> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_broadcastss_ps (Vector128<float> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_broadcastsd_pd (Vector128<double> value)
    {
        return Avx2.BroadcastScalarToVector128(value);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<byte> _mm_broadcastb_epi8 (byte* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<sbyte> _mm_broadcastb_epi8 (sbyte* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<short> _mm_broadcastw_epi16 (short* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ushort> _mm_broadcastw_epi16 (ushort* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_broadcastd_epi32 (int* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_broadcastd_epi32 (uint* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_broadcastq_epi64 (long* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_broadcastq_epi64 (ulong* source)
    {
        return Avx2.BroadcastScalarToVector128(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_broadcastb_epi8 (Vector128<byte> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_broadcastb_epi8 (Vector128<sbyte> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_broadcastw_epi16 (Vector128<short> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_broadcastw_epi16 (Vector128<ushort> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_broadcastd_epi32 (Vector128<int> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_broadcastd_epi32 (Vector128<uint> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_broadcastq_epi64 (Vector128<long> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_broadcastq_epi64 (Vector128<ulong> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_broadcastss_ps (Vector128<float> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_broadcastsd_pd (Vector128<double> value)
    {
        return Avx2.BroadcastScalarToVector256(value);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<byte> _mm256_broadcastb_epi8 (byte* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<sbyte> _mm256_broadcastb_epi8 (sbyte* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> _mm256_broadcastw_epi16 (short* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ushort> _mm256_broadcastw_epi16 (ushort* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_broadcastd_epi32 (int* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_broadcastd_epi32 (uint* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_broadcastq_epi64 (long* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastScalarToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_broadcastq_epi64 (ulong* source)
    {
        return Avx2.BroadcastScalarToVector256(source);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<sbyte> _mm256_broadcastsi128_si256 (sbyte* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<byte> _mm256_broadcastsi128_si256 (byte* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> _mm256_broadcastsi128_si256 (short* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ushort> _mm256_broadcastsi128_si256 (ushort* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_broadcastsi128_si256 (int* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_broadcastsi128_si256 (uint* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_broadcastsi128_si256 (long* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// BroadcastVector128ToVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_broadcastsi128_si256 (ulong* address)
    {
        return Avx2.BroadcastVector128ToVector256(address);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_cmpeq_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_cmpeq_epi8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_cmpeq_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_cmpeq_epi16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cmpeq_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_cmpeq_epi32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cmpeq_epi64 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_cmpeq_epi64 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_cmpgt_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_cmpgt_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cmpgt_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// CompareGreaterThan
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cmpgt_epi64 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.CompareGreaterThan(left, right);
    }
    /// <summary>
    /// ConvertToInt32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm256_cvtsi256_si32 (Vector256<int> value)
    {
        return Avx2.ConvertToInt32(value);
    }
    /// <summary>
    /// ConvertToUInt32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint _mm256_cvtsi256_si32 (Vector256<uint> value)
    {
        return Avx2.ConvertToUInt32(value);
    }
    /// <summary>
    /// ConvertToVector256Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_cvtepi8_epi16 (Vector128<sbyte> value)
    {
        return Avx2.ConvertToVector256Int16(value);
    }
    /// <summary>
    /// ConvertToVector256Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_cvtepu8_epi16 (Vector128<byte> value)
    {
        return Avx2.ConvertToVector256Int16(value);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cvtepi8_epi32 (Vector128<sbyte> value)
    {
        return Avx2.ConvertToVector256Int32(value);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cvtepu8_epi32 (Vector128<byte> value)
    {
        return Avx2.ConvertToVector256Int32(value);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cvtepi16_epi32 (Vector128<short> value)
    {
        return Avx2.ConvertToVector256Int32(value);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_cvtepu16_epi32 (Vector128<ushort> value)
    {
        return Avx2.ConvertToVector256Int32(value);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cvtepi8_epi64 (Vector128<sbyte> value)
    {
        return Avx2.ConvertToVector256Int64(value);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cvtepu8_epi64 (Vector128<byte> value)
    {
        return Avx2.ConvertToVector256Int64(value);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cvtepi16_epi64 (Vector128<short> value)
    {
        return Avx2.ConvertToVector256Int64(value);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cvtepu16_epi64 (Vector128<ushort> value)
    {
        return Avx2.ConvertToVector256Int64(value);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cvtepi32_epi64 (Vector128<int> value)
    {
        return Avx2.ConvertToVector256Int64(value);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_cvtepu32_epi64 (Vector128<uint> value)
    {
        return Avx2.ConvertToVector256Int64(value);
    }
    /// <summary>
    /// ConvertToVector256Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> ymm (sbyte* address)
    {
        return Avx2.ConvertToVector256Int16(address);
    }
    /// <summary>
    /// ConvertToVector256Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> ymm (byte* address)
    {
        return Avx2.ConvertToVector256Int16(address);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> ymm__1 (sbyte* address)
    {
        return Avx2.ConvertToVector256Int32(address);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> ymm__1 (byte* address)
    {
        return Avx2.ConvertToVector256Int32(address);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> ymm (short* address)
    {
        return Avx2.ConvertToVector256Int32(address);
    }
    /// <summary>
    /// ConvertToVector256Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> ymm (ushort* address)
    {
        return Avx2.ConvertToVector256Int32(address);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> ymm__2 (sbyte* address)
    {
        return Avx2.ConvertToVector256Int64(address);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> ymm__2 (byte* address)
    {
        return Avx2.ConvertToVector256Int64(address);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> ymm__1 (short* address)
    {
        return Avx2.ConvertToVector256Int64(address);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> ymm__1 (ushort* address)
    {
        return Avx2.ConvertToVector256Int64(address);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> ymm (int* address)
    {
        return Avx2.ConvertToVector256Int64(address);
    }
    /// <summary>
    /// ConvertToVector256Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> ymm (uint* address)
    {
        return Avx2.ConvertToVector256Int64(address);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm256_extracti128_si256 (Vector256<sbyte> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm256_extracti128_si256 (Vector256<byte> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm256_extracti128_si256 (Vector256<short> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm256_extracti128_si256 (Vector256<ushort> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm256_extracti128_si256 (Vector256<int> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm256_extracti128_si256 (Vector256<uint> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm256_extracti128_si256 (Vector256<long> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// ExtractVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm256_extracti128_si256 (Vector256<ulong> value, byte index)
    {
        return Avx2.ExtractVector128(value, index);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_i32gather_epi32 (int* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_i32gather_epi32 (uint* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_i32gather_epi64 (long* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_i32gather_epi64 (ulong* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_i32gather_ps (float* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_i32gather_pd (double* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_i64gather_epi32 (int* baseAddress, Vector128<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_i64gather_epi32 (uint* baseAddress, Vector128<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_i64gather_epi64 (long* baseAddress, Vector128<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_i64gather_epi64 (ulong* baseAddress, Vector128<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_i64gather_ps (float* baseAddress, Vector128<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_i64gather_pd (double* baseAddress, Vector128<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_i32gather_epi32 (int* baseAddress, Vector256<int> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_i32gather_epi32 (uint* baseAddress, Vector256<int> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_i32gather_epi64 (long* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_i32gather_epi64 (ulong* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<float> _mm256_i32gather_ps (float* baseAddress, Vector256<int> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_i32gather_pd (double* baseAddress, Vector128<int> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm256_i64gather_epi32 (int* baseAddress, Vector256<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm256_i64gather_epi32 (uint* baseAddress, Vector256<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_i64gather_epi64 (long* baseAddress, Vector256<long> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_i64gather_epi64 (ulong* baseAddress, Vector256<long> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm256_i64gather_ps (float* baseAddress, Vector256<long> index, byte scale)
    {
        return Avx2.GatherVector128(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_i64gather_pd (double* baseAddress, Vector256<long> index, byte scale)
    {
        return Avx2.GatherVector256(baseAddress, index, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_mask_i32gather_epi32 (Vector128<int> source, int* baseAddress, Vector128<int> index, Vector128<int> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_mask_i32gather_epi32 (Vector128<uint> source, uint* baseAddress, Vector128<int> index, Vector128<uint> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_mask_i32gather_epi64 (Vector128<long> source, long* baseAddress, Vector128<int> index, Vector128<long> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_mask_i32gather_epi64 (Vector128<ulong> source, ulong* baseAddress, Vector128<int> index, Vector128<ulong> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_mask_i32gather_ps (Vector128<float> source, float* baseAddress, Vector128<int> index, Vector128<float> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_mask_i32gather_pd (Vector128<double> source, double* baseAddress, Vector128<int> index, Vector128<double> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_mask_i64gather_epi32 (Vector128<int> source, int* baseAddress, Vector128<long> index, Vector128<int> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_mask_i64gather_epi32 (Vector128<uint> source, uint* baseAddress, Vector128<long> index, Vector128<uint> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_mask_i64gather_epi64 (Vector128<long> source, long* baseAddress, Vector128<long> index, Vector128<long> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_mask_i64gather_epi64 (Vector128<ulong> source, ulong* baseAddress, Vector128<long> index, Vector128<ulong> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm_mask_i64gather_ps (Vector128<float> source, float* baseAddress, Vector128<long> index, Vector128<float> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_mask_i64gather_pd (Vector128<double> source, double* baseAddress, Vector128<long> index, Vector128<double> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_mask_i32gather_epi32 (Vector256<int> source, int* baseAddress, Vector256<int> index, Vector256<int> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_mask_i32gather_epi32 (Vector256<uint> source, uint* baseAddress, Vector256<int> index, Vector256<uint> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_mask_i32gather_epi64 (Vector256<long> source, long* baseAddress, Vector128<int> index, Vector256<long> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_mask_i32gather_epi64 (Vector256<ulong> source, ulong* baseAddress, Vector128<int> index, Vector256<ulong> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<float> _mm256_mask_i32gather_ps (Vector256<float> source, float* baseAddress, Vector256<int> index, Vector256<float> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_mask_i32gather_pd (Vector256<double> source, double* baseAddress, Vector128<int> index, Vector256<double> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm256_mask_i64gather_epi32 (Vector128<int> source, int* baseAddress, Vector256<long> index, Vector128<int> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm256_mask_i64gather_epi32 (Vector128<uint> source, uint* baseAddress, Vector256<long> index, Vector128<uint> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_mask_i64gather_epi64 (Vector256<long> source, long* baseAddress, Vector256<long> index, Vector256<long> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_mask_i64gather_epi64 (Vector256<ulong> source, ulong* baseAddress, Vector256<long> index, Vector256<ulong> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<float> _mm256_mask_i64gather_ps (Vector128<float> source, float* baseAddress, Vector256<long> index, Vector128<float> mask, byte scale)
    {
        return Avx2.GatherMaskVector128(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// GatherMaskVector256
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<double> _mm256_mask_i64gather_pd (Vector256<double> source, double* baseAddress, Vector256<long> index, Vector256<double> mask, byte scale)
    {
        return Avx2.GatherMaskVector256(source, baseAddress, index, mask, scale);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_hadd_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_hadd_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalAddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_hadds_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.HorizontalAddSaturate(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_hsub_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_hsub_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// HorizontalSubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_hsubs_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.HorizontalSubtractSaturate(left, right);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_inserti128_si256 (Vector256<sbyte> value, Vector128<sbyte> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_inserti128_si256 (Vector256<byte> value, Vector128<byte> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_inserti128_si256 (Vector256<short> value, Vector128<short> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_inserti128_si256 (Vector256<ushort> value, Vector128<ushort> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_inserti128_si256 (Vector256<int> value, Vector128<int> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_inserti128_si256 (Vector256<uint> value, Vector128<uint> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_inserti128_si256 (Vector256<long> value, Vector128<long> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// InsertVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_inserti128_si256 (Vector256<ulong> value, Vector128<ulong> data, byte index)
    {
        return Avx2.InsertVector128(value, data, index);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<sbyte> _mm256_stream_load_si256 (sbyte* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<byte> _mm256_stream_load_si256 (byte* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<short> _mm256_stream_load_si256 (short* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ushort> _mm256_stream_load_si256 (ushort* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_stream_load_si256 (int* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_stream_load_si256 (uint* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_stream_load_si256 (long* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector256NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_stream_load_si256 (ulong* address)
    {
        return Avx2.LoadAlignedVector256NonTemporal(address);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_maskload_epi32 (int* address, Vector128<int> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_maskload_epi32 (uint* address, Vector128<uint> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_maskload_epi64 (long* address, Vector128<long> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_maskload_epi64 (ulong* address, Vector128<ulong> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<int> _mm256_maskload_epi32 (int* address, Vector256<int> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<uint> _mm256_maskload_epi32 (uint* address, Vector256<uint> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<long> _mm256_maskload_epi64 (long* address, Vector256<long> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskLoad
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector256<ulong> _mm256_maskload_epi64 (ulong* address, Vector256<ulong> mask)
    {
        return Avx2.MaskLoad(address, mask);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskstore_epi32 (int* address, Vector128<int> mask, Vector128<int> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskstore_epi32 (uint* address, Vector128<uint> mask, Vector128<uint> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskstore_epi64 (long* address, Vector128<long> mask, Vector128<long> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm_maskstore_epi64 (ulong* address, Vector128<ulong> mask, Vector128<ulong> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_maskstore_epi32 (int* address, Vector256<int> mask, Vector256<int> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_maskstore_epi32 (uint* address, Vector256<uint> mask, Vector256<uint> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_maskstore_epi64 (long* address, Vector256<long> mask, Vector256<long> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MaskStore
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe void _mm256_maskstore_epi64 (ulong* address, Vector256<ulong> mask, Vector256<ulong> source)
    {
         Avx2.MaskStore(address, mask, source);
    }
    /// <summary>
    /// MultiplyAddAdjacent
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_madd_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.MultiplyAddAdjacent(left, right);
    }
    /// <summary>
    /// MultiplyAddAdjacent
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_maddubs_epi16 (Vector256<byte> left, Vector256<sbyte> right)
    {
        return Avx2.MultiplyAddAdjacent(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_max_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_max_epu8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_max_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_max_epu16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_max_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_max_epu32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.Max(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_min_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_min_epu8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_min_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_min_epu16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_min_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_min_epu32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.Min(left, right);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm256_movemask_epi8 (Vector256<sbyte> value)
    {
        return Avx2.MoveMask(value);
    }
    /// <summary>
    /// MoveMask
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm256_movemask_epi8 (Vector256<byte> value)
    {
        return Avx2.MoveMask(value);
    }
    /// <summary>
    /// MultipleSumAbsoluteDifferences
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_mpsadbw_epu8 (Vector256<byte> left, Vector256<byte> right, byte mask)
    {
        return Avx2.MultipleSumAbsoluteDifferences(left, right, mask);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_mul_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Multiply(left, right);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_mul_epu32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.Multiply(left, right);
    }
    /// <summary>
    /// MultiplyHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_mulhi_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.MultiplyHigh(left, right);
    }
    /// <summary>
    /// MultiplyHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_mulhi_epu16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.MultiplyHigh(left, right);
    }
    /// <summary>
    /// MultiplyHighRoundScale
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_mulhrs_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.MultiplyHighRoundScale(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_mullo_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.MultiplyLow(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_mullo_epi16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.MultiplyLow(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_mullo_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.MultiplyLow(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_mullo_epi32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.MultiplyLow(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_or_si256 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_or_si256 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_or_si256 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_or_si256 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_or_si256 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_or_si256 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_or_si256 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// Or
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_or_si256 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.Or(left, right);
    }
    /// <summary>
    /// PackSignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_packs_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.PackSignedSaturate(left, right);
    }
    /// <summary>
    /// PackSignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_packs_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.PackSignedSaturate(left, right);
    }
    /// <summary>
    /// PackUnsignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_packus_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.PackUnsignedSaturate(left, right);
    }
    /// <summary>
    /// PackUnsignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_packus_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.PackUnsignedSaturate(left, right);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_permute2x128_si256 (Vector256<sbyte> left, Vector256<sbyte> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_permute2x128_si256 (Vector256<byte> left, Vector256<byte> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_permute2x128_si256 (Vector256<short> left, Vector256<short> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_permute2x128_si256 (Vector256<ushort> left, Vector256<ushort> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_permute2x128_si256 (Vector256<int> left, Vector256<int> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_permute2x128_si256 (Vector256<uint> left, Vector256<uint> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_permute2x128_si256 (Vector256<long> left, Vector256<long> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute2x128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_permute2x128_si256 (Vector256<ulong> left, Vector256<ulong> right, byte control)
    {
        return Avx2.Permute2x128(left, right, control);
    }
    /// <summary>
    /// Permute4x64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_permute4x64_epi64 (Vector256<long> value, byte control)
    {
        return Avx2.Permute4x64(value, control);
    }
    /// <summary>
    /// Permute4x64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_permute4x64_epi64 (Vector256<ulong> value, byte control)
    {
        return Avx2.Permute4x64(value, control);
    }
    /// <summary>
    /// Permute4x64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<double> _mm256_permute4x64_pd (Vector256<double> value, byte control)
    {
        return Avx2.Permute4x64(value, control);
    }
    /// <summary>
    /// PermuteVar8x32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_permutevar8x32_epi32 (Vector256<int> left, Vector256<int> control)
    {
        return Avx2.PermuteVar8x32(left, control);
    }
    /// <summary>
    /// PermuteVar8x32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_permutevar8x32_epi32 (Vector256<uint> left, Vector256<uint> control)
    {
        return Avx2.PermuteVar8x32(left, control);
    }
    /// <summary>
    /// PermuteVar8x32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<float> _mm256_permutevar8x32_ps (Vector256<float> left, Vector256<int> control)
    {
        return Avx2.PermuteVar8x32(left, control);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_sll_epi16 (Vector256<short> value, Vector128<short> count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_sll_epi16 (Vector256<ushort> value, Vector128<ushort> count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_sll_epi32 (Vector256<int> value, Vector128<int> count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_sll_epi32 (Vector256<uint> value, Vector128<uint> count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_sll_epi64 (Vector256<long> value, Vector128<long> count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_sll_epi64 (Vector256<ulong> value, Vector128<ulong> count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_slli_epi16 (Vector256<short> value, byte count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_slli_epi16 (Vector256<ushort> value, byte count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_slli_epi32 (Vector256<int> value, byte count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_slli_epi32 (Vector256<uint> value, byte count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_slli_epi64 (Vector256<long> value, byte count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_slli_epi64 (Vector256<ulong> value, byte count)
    {
        return Avx2.ShiftLeftLogical(value, count);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_bslli_epi128 (Vector256<sbyte> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_bslli_epi128 (Vector256<byte> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_bslli_epi128 (Vector256<short> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_bslli_epi128 (Vector256<ushort> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_bslli_epi128 (Vector256<int> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_bslli_epi128 (Vector256<uint> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_bslli_epi128 (Vector256<long> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_bslli_epi128 (Vector256<ulong> value, byte numBytes)
    {
        return Avx2.ShiftLeftLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_sllv_epi32 (Vector256<int> value, Vector256<uint> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_sllv_epi32 (Vector256<uint> value, Vector256<uint> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_sllv_epi64 (Vector256<long> value, Vector256<ulong> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_sllv_epi64 (Vector256<ulong> value, Vector256<ulong> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_sllv_epi32 (Vector128<int> value, Vector128<uint> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_sllv_epi32 (Vector128<uint> value, Vector128<uint> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_sllv_epi64 (Vector128<long> value, Vector128<ulong> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftLeftLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_sllv_epi64 (Vector128<ulong> value, Vector128<ulong> count)
    {
        return Avx2.ShiftLeftLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> __m256i (Vector256<short> value, Vector128<short> count)
    {
        return Avx2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> __m256i (Vector256<int> value, Vector128<int> count)
    {
        return Avx2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_srai_epi16 (Vector256<short> value, byte count)
    {
        return Avx2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightArithmetic
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_srai_epi32 (Vector256<int> value, byte count)
    {
        return Avx2.ShiftRightArithmetic(value, count);
    }
    /// <summary>
    /// ShiftRightArithmeticVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_srav_epi32 (Vector256<int> value, Vector256<uint> count)
    {
        return Avx2.ShiftRightArithmeticVariable(value, count);
    }
    /// <summary>
    /// ShiftRightArithmeticVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_srav_epi32 (Vector128<int> value, Vector128<uint> count)
    {
        return Avx2.ShiftRightArithmeticVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_srl_epi16 (Vector256<short> value, Vector128<short> count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_srl_epi16 (Vector256<ushort> value, Vector128<ushort> count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_srl_epi32 (Vector256<int> value, Vector128<int> count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_srl_epi32 (Vector256<uint> value, Vector128<uint> count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_srl_epi64 (Vector256<long> value, Vector128<long> count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_srl_epi64 (Vector256<ulong> value, Vector128<ulong> count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_srli_epi16 (Vector256<short> value, byte count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_srli_epi16 (Vector256<ushort> value, byte count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_srli_epi32 (Vector256<int> value, byte count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_srli_epi32 (Vector256<uint> value, byte count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_srli_epi64 (Vector256<long> value, byte count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_srli_epi64 (Vector256<ulong> value, byte count)
    {
        return Avx2.ShiftRightLogical(value, count);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_bsrli_epi128 (Vector256<sbyte> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_bsrli_epi128 (Vector256<byte> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_bsrli_epi128 (Vector256<short> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_bsrli_epi128 (Vector256<ushort> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_bsrli_epi128 (Vector256<int> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_bsrli_epi128 (Vector256<uint> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_bsrli_epi128 (Vector256<long> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogical128BitLane
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_bsrli_epi128 (Vector256<ulong> value, byte numBytes)
    {
        return Avx2.ShiftRightLogical128BitLane(value, numBytes);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_srlv_epi32 (Vector256<int> value, Vector256<uint> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_srlv_epi32 (Vector256<uint> value, Vector256<uint> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_srlv_epi64 (Vector256<long> value, Vector256<ulong> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_srlv_epi64 (Vector256<ulong> value, Vector256<ulong> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_srlv_epi32 (Vector128<int> value, Vector128<uint> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_srlv_epi32 (Vector128<uint> value, Vector128<uint> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_srlv_epi64 (Vector128<long> value, Vector128<ulong> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// ShiftRightLogicalVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_srlv_epi64 (Vector128<ulong> value, Vector128<ulong> count)
    {
        return Avx2.ShiftRightLogicalVariable(value, count);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_shuffle_epi8 (Vector256<sbyte> value, Vector256<sbyte> mask)
    {
        return Avx2.Shuffle(value, mask);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_shuffle_epi8 (Vector256<byte> value, Vector256<byte> mask)
    {
        return Avx2.Shuffle(value, mask);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_shuffle_epi32 (Vector256<int> value, byte control)
    {
        return Avx2.Shuffle(value, control);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_shuffle_epi32 (Vector256<uint> value, byte control)
    {
        return Avx2.Shuffle(value, control);
    }
    /// <summary>
    /// ShuffleHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_shufflehi_epi16 (Vector256<short> value, byte control)
    {
        return Avx2.ShuffleHigh(value, control);
    }
    /// <summary>
    /// ShuffleHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_shufflehi_epi16 (Vector256<ushort> value, byte control)
    {
        return Avx2.ShuffleHigh(value, control);
    }
    /// <summary>
    /// ShuffleLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_shufflelo_epi16 (Vector256<short> value, byte control)
    {
        return Avx2.ShuffleLow(value, control);
    }
    /// <summary>
    /// ShuffleLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_shufflelo_epi16 (Vector256<ushort> value, byte control)
    {
        return Avx2.ShuffleLow(value, control);
    }
    /// <summary>
    /// Sign
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_sign_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.Sign(left, right);
    }
    /// <summary>
    /// Sign
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_sign_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.Sign(left, right);
    }
    /// <summary>
    /// Sign
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_sign_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Sign(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_sub_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_sub_epi8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_sub_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_sub_epi16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_sub_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_sub_epi32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_sub_epi64 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// Subtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_sub_epi64 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.Subtract(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_subs_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_subs_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_subs_epu8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// SubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_subs_epu16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.SubtractSaturate(left, right);
    }
    /// <summary>
    /// SumAbsoluteDifferences
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_sad_epu8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.SumAbsoluteDifferences(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_unpackhi_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_unpackhi_epi8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_unpackhi_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_unpackhi_epi16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_unpackhi_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_unpackhi_epi32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_unpackhi_epi64 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackHigh
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_unpackhi_epi64 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.UnpackHigh(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_unpacklo_epi8 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_unpacklo_epi8 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_unpacklo_epi16 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_unpacklo_epi16 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_unpacklo_epi32 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_unpacklo_epi32 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_unpacklo_epi64 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// UnpackLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_unpacklo_epi64 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.UnpackLow(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<sbyte> _mm256_xor_si256 (Vector256<sbyte> left, Vector256<sbyte> right)
    {
        return Avx2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<byte> _mm256_xor_si256 (Vector256<byte> left, Vector256<byte> right)
    {
        return Avx2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<short> _mm256_xor_si256 (Vector256<short> left, Vector256<short> right)
    {
        return Avx2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ushort> _mm256_xor_si256 (Vector256<ushort> left, Vector256<ushort> right)
    {
        return Avx2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<int> _mm256_xor_si256 (Vector256<int> left, Vector256<int> right)
    {
        return Avx2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<uint> _mm256_xor_si256 (Vector256<uint> left, Vector256<uint> right)
    {
        return Avx2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<long> _mm256_xor_si256 (Vector256<long> left, Vector256<long> right)
    {
        return Avx2.Xor(left, right);
    }
    /// <summary>
    /// Xor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector256<ulong> _mm256_xor_si256 (Vector256<ulong> left, Vector256<ulong> right)
    {
        return Avx2.Xor(left, right);
    }
}

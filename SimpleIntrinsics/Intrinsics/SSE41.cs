using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

public class SSE41
{

    /// <summary>
    /// Extract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static long _mm_extract_epi64 (Vector128<long> value, byte index)
    {
        return Sse41.X64.Extract(value, index);
    }
    /// <summary>
    /// Extract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static ulong _mm_extract_epi64 (Vector128<ulong> value, byte index)
    {
        return Sse41.X64.Extract(value, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_insert_epi64 (Vector128<long> value, long data, byte index)
    {
        return Sse41.X64.Insert(value, data, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_insert_epi64 (Vector128<ulong> value, ulong data, byte index)
    {
        return Sse41.X64.Insert(value, data, index);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_blend_epi16 (Vector128<short> left, Vector128<short> right, byte control)
    {
        return Sse41.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_blend_epi16 (Vector128<ushort> left, Vector128<ushort> right, byte control)
    {
        return Sse41.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_blend_ps (Vector128<float> left, Vector128<float> right, byte control)
    {
        return Sse41.Blend(left, right, control);
    }
    /// <summary>
    /// Blend
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_blend_pd (Vector128<double> left, Vector128<double> right, byte control)
    {
        return Sse41.Blend(left, right, control);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_blendv_epi8 (Vector128<sbyte> left, Vector128<sbyte> right, Vector128<sbyte> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_blendv_epi8 (Vector128<byte> left, Vector128<byte> right, Vector128<byte> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_blendv_epi8 (Vector128<short> left, Vector128<short> right, Vector128<short> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_blendv_epi8 (Vector128<ushort> left, Vector128<ushort> right, Vector128<ushort> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_blendv_epi8 (Vector128<int> left, Vector128<int> right, Vector128<int> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_blendv_epi8 (Vector128<uint> left, Vector128<uint> right, Vector128<uint> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_blendv_epi8 (Vector128<long> left, Vector128<long> right, Vector128<long> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_blendv_epi8 (Vector128<ulong> left, Vector128<ulong> right, Vector128<ulong> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_blendv_ps (Vector128<float> left, Vector128<float> right, Vector128<float> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// BlendVariable
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_blendv_pd (Vector128<double> left, Vector128<double> right, Vector128<double> mask)
    {
        return Sse41.BlendVariable(left, right, mask);
    }
    /// <summary>
    /// Ceiling
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_ceil_ps (Vector128<float> value)
    {
        return Sse41.Ceiling(value);
    }
    /// <summary>
    /// Ceiling
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_ceil_pd (Vector128<double> value)
    {
        return Sse41.Ceiling(value);
    }
    /// <summary>
    /// CeilingScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_ceil_sd (Vector128<double> value)
    {
        return Sse41.CeilingScalar(value);
    }
    /// <summary>
    /// CeilingScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_ceil_ss (Vector128<float> value)
    {
        return Sse41.CeilingScalar(value);
    }
    /// <summary>
    /// CeilingScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_ceil_sd (Vector128<double> upper, Vector128<double> value)
    {
        return Sse41.CeilingScalar(upper, value);
    }
    /// <summary>
    /// CeilingScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_ceil_ss (Vector128<float> upper, Vector128<float> value)
    {
        return Sse41.CeilingScalar(upper, value);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cmpeq_epi64 (Vector128<long> left, Vector128<long> right)
    {
        return Sse41.CompareEqual(left, right);
    }
    /// <summary>
    /// CompareEqual
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_cmpeq_epi64 (Vector128<ulong> left, Vector128<ulong> right)
    {
        return Sse41.CompareEqual(left, right);
    }
    /// <summary>
    /// ConvertToVector128Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_cvtepi8_epi16 (Vector128<sbyte> value)
    {
        return Sse41.ConvertToVector128Int16(value);
    }
    /// <summary>
    /// ConvertToVector128Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_cvtepu8_epi16 (Vector128<byte> value)
    {
        return Sse41.ConvertToVector128Int16(value);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvtepi8_epi32 (Vector128<sbyte> value)
    {
        return Sse41.ConvertToVector128Int32(value);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvtepu8_epi32 (Vector128<byte> value)
    {
        return Sse41.ConvertToVector128Int32(value);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvtepi16_epi32 (Vector128<short> value)
    {
        return Sse41.ConvertToVector128Int32(value);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_cvtepu16_epi32 (Vector128<ushort> value)
    {
        return Sse41.ConvertToVector128Int32(value);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cvtepi8_epi64 (Vector128<sbyte> value)
    {
        return Sse41.ConvertToVector128Int64(value);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cvtepu8_epi64 (Vector128<byte> value)
    {
        return Sse41.ConvertToVector128Int64(value);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cvtepi16_epi64 (Vector128<short> value)
    {
        return Sse41.ConvertToVector128Int64(value);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cvtepu16_epi64 (Vector128<ushort> value)
    {
        return Sse41.ConvertToVector128Int64(value);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cvtepi32_epi64 (Vector128<int> value)
    {
        return Sse41.ConvertToVector128Int64(value);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_cvtepu32_epi64 (Vector128<uint> value)
    {
        return Sse41.ConvertToVector128Int64(value);
    }
    /// <summary>
    /// ConvertToVector128Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<short> xmm (sbyte* address)
    {
        return Sse41.ConvertToVector128Int16(address);
    }
    /// <summary>
    /// ConvertToVector128Int16
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<short> xmm (byte* address)
    {
        return Sse41.ConvertToVector128Int16(address);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> xmm__1 (sbyte* address)
    {
        return Sse41.ConvertToVector128Int32(address);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> xmm__1 (byte* address)
    {
        return Sse41.ConvertToVector128Int32(address);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> xmm (short* address)
    {
        return Sse41.ConvertToVector128Int32(address);
    }
    /// <summary>
    /// ConvertToVector128Int32
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> xmm (ushort* address)
    {
        return Sse41.ConvertToVector128Int32(address);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> xmm__2 (sbyte* address)
    {
        return Sse41.ConvertToVector128Int64(address);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> xmm__2 (byte* address)
    {
        return Sse41.ConvertToVector128Int64(address);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> xmm__1 (short* address)
    {
        return Sse41.ConvertToVector128Int64(address);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> xmm__1 (ushort* address)
    {
        return Sse41.ConvertToVector128Int64(address);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> xmm (int* address)
    {
        return Sse41.ConvertToVector128Int64(address);
    }
    /// <summary>
    /// ConvertToVector128Int64
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> xmm (uint* address)
    {
        return Sse41.ConvertToVector128Int64(address);
    }
    /// <summary>
    /// DotProduct
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_dp_ps (Vector128<float> left, Vector128<float> right, byte control)
    {
        return Sse41.DotProduct(left, right, control);
    }
    /// <summary>
    /// DotProduct
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_dp_pd (Vector128<double> left, Vector128<double> right, byte control)
    {
        return Sse41.DotProduct(left, right, control);
    }
    /// <summary>
    /// Extract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static byte _mm_extract_epi8 (Vector128<byte> value, byte index)
    {
        return Sse41.Extract(value, index);
    }
    /// <summary>
    /// Extract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static int _mm_extract_epi32 (Vector128<int> value, byte index)
    {
        return Sse41.Extract(value, index);
    }
    /// <summary>
    /// Extract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint _mm_extract_epi32 (Vector128<uint> value, byte index)
    {
        return Sse41.Extract(value, index);
    }
    /// <summary>
    /// Extract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static float _mm_extract_ps (Vector128<float> value, byte index)
    {
        return Sse41.Extract(value, index);
    }
    /// <summary>
    /// Floor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_floor_ps (Vector128<float> value)
    {
        return Sse41.Floor(value);
    }
    /// <summary>
    /// Floor
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_floor_pd (Vector128<double> value)
    {
        return Sse41.Floor(value);
    }
    /// <summary>
    /// FloorScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_floor_sd (Vector128<double> value)
    {
        return Sse41.FloorScalar(value);
    }
    /// <summary>
    /// FloorScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_floor_ss (Vector128<float> value)
    {
        return Sse41.FloorScalar(value);
    }
    /// <summary>
    /// FloorScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_floor_sd (Vector128<double> upper, Vector128<double> value)
    {
        return Sse41.FloorScalar(upper, value);
    }
    /// <summary>
    /// FloorScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_floor_ss (Vector128<float> upper, Vector128<float> value)
    {
        return Sse41.FloorScalar(upper, value);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_insert_epi8 (Vector128<sbyte> value, sbyte data, byte index)
    {
        return Sse41.Insert(value, data, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_insert_epi8 (Vector128<byte> value, byte data, byte index)
    {
        return Sse41.Insert(value, data, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_insert_epi32 (Vector128<int> value, int data, byte index)
    {
        return Sse41.Insert(value, data, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_insert_epi32 (Vector128<uint> value, uint data, byte index)
    {
        return Sse41.Insert(value, data, index);
    }
    /// <summary>
    /// Insert
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_insert_ps (Vector128<float> value, Vector128<float> data, byte index)
    {
        return Sse41.Insert(value, data, index);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_max_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse41.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_max_epu16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse41.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_max_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse41.Max(left, right);
    }
    /// <summary>
    /// Max
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_max_epu32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse41.Max(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_min_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse41.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_min_epu16 (Vector128<ushort> left, Vector128<ushort> right)
    {
        return Sse41.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_min_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse41.Min(left, right);
    }
    /// <summary>
    /// Min
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_min_epu32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse41.Min(left, right);
    }
    /// <summary>
    /// MinHorizontal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_minpos_epu16 (Vector128<ushort> value)
    {
        return Sse41.MinHorizontal(value);
    }
    /// <summary>
    /// MultipleSumAbsoluteDifferences
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_mpsadbw_epu8 (Vector128<byte> left, Vector128<byte> right, byte mask)
    {
        return Sse41.MultipleSumAbsoluteDifferences(left, right, mask);
    }
    /// <summary>
    /// Multiply
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_mul_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse41.Multiply(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_mullo_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse41.MultiplyLow(left, right);
    }
    /// <summary>
    /// MultiplyLow
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_mullo_epi32 (Vector128<uint> left, Vector128<uint> right)
    {
        return Sse41.MultiplyLow(left, right);
    }
    /// <summary>
    /// PackUnsignedSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_packus_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Sse41.PackUnsignedSaturate(left, right);
    }
    /// <summary>
    /// RoundToNearestInteger
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ps (Vector128<float> value)
    {
        return Sse41.RoundToNearestInteger(value);
    }
    /// <summary>
    /// RoundCurrentDirection
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> ROUNDPS (Vector128<float> value)
    {
        return Sse41.RoundCurrentDirection(value);
    }
    /// <summary>
    /// RoundToNearestInteger
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_pd (Vector128<double> value)
    {
        return Sse41.RoundToNearestInteger(value);
    }
    /// <summary>
    /// RoundCurrentDirection
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> ROUNDPD (Vector128<double> value)
    {
        return Sse41.RoundCurrentDirection(value);
    }
    /// <summary>
    /// RoundCurrentDirectionScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd (Vector128<double> value)
    {
        return Sse41.RoundCurrentDirectionScalar(value);
    }
    /// <summary>
    /// RoundToNearestIntegerScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__1 (Vector128<double> value)
    {
        return Sse41.RoundToNearestIntegerScalar(value);
    }
    /// <summary>
    /// RoundToNegativeInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__2 (Vector128<double> value)
    {
        return Sse41.RoundToNegativeInfinityScalar(value);
    }
    /// <summary>
    /// RoundToPositiveInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__3 (Vector128<double> value)
    {
        return Sse41.RoundToPositiveInfinityScalar(value);
    }
    /// <summary>
    /// RoundToZeroScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__4 (Vector128<double> value)
    {
        return Sse41.RoundToZeroScalar(value);
    }
    /// <summary>
    /// RoundCurrentDirectionScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd (Vector128<double> upper, Vector128<double> value)
    {
        return Sse41.RoundCurrentDirectionScalar(upper, value);
    }
    /// <summary>
    /// RoundToNearestIntegerScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__1 (Vector128<double> upper, Vector128<double> value)
    {
        return Sse41.RoundToNearestIntegerScalar(upper, value);
    }
    /// <summary>
    /// RoundToNegativeInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__2 (Vector128<double> upper, Vector128<double> value)
    {
        return Sse41.RoundToNegativeInfinityScalar(upper, value);
    }
    /// <summary>
    /// RoundToPositiveInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__3 (Vector128<double> upper, Vector128<double> value)
    {
        return Sse41.RoundToPositiveInfinityScalar(upper, value);
    }
    /// <summary>
    /// RoundToZeroScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_round_sd__4 (Vector128<double> upper, Vector128<double> value)
    {
        return Sse41.RoundToZeroScalar(upper, value);
    }
    /// <summary>
    /// RoundCurrentDirectionScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss (Vector128<float> value)
    {
        return Sse41.RoundCurrentDirectionScalar(value);
    }
    /// <summary>
    /// RoundToNearestIntegerScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__1 (Vector128<float> value)
    {
        return Sse41.RoundToNearestIntegerScalar(value);
    }
    /// <summary>
    /// RoundToNegativeInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__2 (Vector128<float> value)
    {
        return Sse41.RoundToNegativeInfinityScalar(value);
    }
    /// <summary>
    /// RoundToPositiveInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__3 (Vector128<float> value)
    {
        return Sse41.RoundToPositiveInfinityScalar(value);
    }
    /// <summary>
    /// RoundToZeroScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__4 (Vector128<float> value)
    {
        return Sse41.RoundToZeroScalar(value);
    }
    /// <summary>
    /// RoundCurrentDirectionScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss (Vector128<float> upper, Vector128<float> value)
    {
        return Sse41.RoundCurrentDirectionScalar(upper, value);
    }
    /// <summary>
    /// RoundToNearestIntegerScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__1 (Vector128<float> upper, Vector128<float> value)
    {
        return Sse41.RoundToNearestIntegerScalar(upper, value);
    }
    /// <summary>
    /// RoundToNegativeInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__2 (Vector128<float> upper, Vector128<float> value)
    {
        return Sse41.RoundToNegativeInfinityScalar(upper, value);
    }
    /// <summary>
    /// RoundToPositiveInfinityScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__3 (Vector128<float> upper, Vector128<float> value)
    {
        return Sse41.RoundToPositiveInfinityScalar(upper, value);
    }
    /// <summary>
    /// RoundToZeroScalar
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_round_ss__4 (Vector128<float> upper, Vector128<float> value)
    {
        return Sse41.RoundToZeroScalar(upper, value);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<sbyte> _mm_stream_load_si128 (sbyte* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<byte> _mm_stream_load_si128 (byte* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<short> _mm_stream_load_si128 (short* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ushort> _mm_stream_load_si128 (ushort* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<int> _mm_stream_load_si128 (int* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<uint> _mm_stream_load_si128 (uint* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<long> _mm_stream_load_si128 (long* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// LoadAlignedVector128NonTemporal
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<ulong> _mm_stream_load_si128 (ulong* address)
    {
        return Sse41.LoadAlignedVector128NonTemporal(address);
    }
    /// <summary>
    /// TestC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testc_si128 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse41.TestC(left, right);
    }
    /// <summary>
    /// TestNotZAndNotC
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testnzc_si128 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse41.TestNotZAndNotC(left, right);
    }
    /// <summary>
    /// TestZ
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static bool _mm_testz_si128 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Sse41.TestZ(left, right);
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

public class SSSE3
{

    /// <summary>
    /// Abs
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_abs_epi8 (Vector128<sbyte> value)
    {
        return Ssse3.Abs(value);
    }
    /// <summary>
    /// Abs
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_abs_epi16 (Vector128<short> value)
    {
        return Ssse3.Abs(value);
    }
    /// <summary>
    /// Abs
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_abs_epi32 (Vector128<int> value)
    {
        return Ssse3.Abs(value);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_alignr_epi8 (Vector128<sbyte> left, Vector128<sbyte> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_alignr_epi8 (Vector128<byte> left, Vector128<byte> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_alignr_epi8 (Vector128<short> left, Vector128<short> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ushort> _mm_alignr_epi8 (Vector128<ushort> left, Vector128<ushort> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_alignr_epi8 (Vector128<int> left, Vector128<int> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<uint> _mm_alignr_epi8 (Vector128<uint> left, Vector128<uint> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<long> _mm_alignr_epi8 (Vector128<long> left, Vector128<long> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// AlignRight
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<ulong> _mm_alignr_epi8 (Vector128<ulong> left, Vector128<ulong> right, byte mask)
    {
        return Ssse3.AlignRight(left, right, mask);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_hadd_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Ssse3.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_hadd_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Ssse3.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalAddSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_hadds_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Ssse3.HorizontalAddSaturate(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_hsub_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Ssse3.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_hsub_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Ssse3.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// HorizontalSubtractSaturate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_hsubs_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Ssse3.HorizontalSubtractSaturate(left, right);
    }
    /// <summary>
    /// MultiplyAddAdjacent
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_maddubs_epi16 (Vector128<byte> left, Vector128<sbyte> right)
    {
        return Ssse3.MultiplyAddAdjacent(left, right);
    }
    /// <summary>
    /// MultiplyHighRoundScale
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_mulhrs_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Ssse3.MultiplyHighRoundScale(left, right);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_shuffle_epi8 (Vector128<sbyte> value, Vector128<sbyte> mask)
    {
        return Ssse3.Shuffle(value, mask);
    }
    /// <summary>
    /// Shuffle
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<byte> _mm_shuffle_epi8 (Vector128<byte> value, Vector128<byte> mask)
    {
        return Ssse3.Shuffle(value, mask);
    }
    /// <summary>
    /// Sign
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<sbyte> _mm_sign_epi8 (Vector128<sbyte> left, Vector128<sbyte> right)
    {
        return Ssse3.Sign(left, right);
    }
    /// <summary>
    /// Sign
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<short> _mm_sign_epi16 (Vector128<short> left, Vector128<short> right)
    {
        return Ssse3.Sign(left, right);
    }
    /// <summary>
    /// Sign
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<int> _mm_sign_epi32 (Vector128<int> left, Vector128<int> right)
    {
        return Ssse3.Sign(left, right);
    }
}

using System.Runtime.CompilerServices;
using System.Runtime.Intrinsics;
using System.Runtime.Intrinsics.X86;

public class SSE3
{

    /// <summary>
    /// AddSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_addsub_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse3.AddSubtract(left, right);
    }
    /// <summary>
    /// AddSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_addsub_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse3.AddSubtract(left, right);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_hadd_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse3.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalAdd
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_hadd_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse3.HorizontalAdd(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_hsub_ps (Vector128<float> left, Vector128<float> right)
    {
        return Sse3.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// HorizontalSubtract
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_hsub_pd (Vector128<double> left, Vector128<double> right)
    {
        return Sse3.HorizontalSubtract(left, right);
    }
    /// <summary>
    /// LoadAndDuplicateToVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<double> _mm_loaddup_pd (double* address)
    {
        return Sse3.LoadAndDuplicateToVector128(address);
    }
    /// <summary>
    /// LoadDquVector128
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static unsafe Vector128<sbyte> _mm_lddqu_si128 (sbyte* address)
    {
        return Sse3.LoadDquVector128(address);
    }
    /// <summary>
    /// MoveAndDuplicate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<double> _mm_movedup_pd (Vector128<double> source)
    {
        return Sse3.MoveAndDuplicate(source);
    }
    /// <summary>
    /// MoveHighAndDuplicate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_movehdup_ps (Vector128<float> source)
    {
        return Sse3.MoveHighAndDuplicate(source);
    }
    /// <summary>
    /// MoveLowAndDuplicate
    /// </summary>

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static Vector128<float> _mm_moveldup_ps (Vector128<float> source)
    {
        return Sse3.MoveLowAndDuplicate(source);
    }
}

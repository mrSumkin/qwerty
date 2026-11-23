using System;
using Microsoft.Xna.Framework;

// Token: 0x020000B1 RID: 177
public static class d05
{
	// Token: 0x060003FE RID: 1022 RVA: 0x000133B0 File Offset: 0x000115B0
	public static Point a(Point A_0, Point A_1, bool A_2 = false)
	{
		return new Point(A_0.X + (A_2 ? -1 : 1) * A_1.X, A_0.Y + (A_2 ? -1 : 1) * A_1.Y);
	}

	// Token: 0x060003FF RID: 1023 RVA: 0x000133F0 File Offset: 0x000115F0
	public static Point a(Point A_0, Point A_1, float A_2, float A_3, bool A_4 = false)
	{
		return new Point((int)((float)A_0.X * A_2 + (float)((A_4 ? -1 : 1) * A_1.X) * A_3), (int)((float)A_0.Y * A_2 + (float)((A_4 ? -1 : 1) * A_1.Y) * A_3));
	}

	// Token: 0x06000400 RID: 1024 RVA: 0x00013448 File Offset: 0x00011648
	public static bool a(string A_0, string A_1, StringComparison A_2)
	{
		return (A_0 == null && A_1 == null) || (A_0 != null && A_1 != null && A_0.Equals(A_1, A_2));
	}

	// Token: 0x06000401 RID: 1025 RVA: 0x00013470 File Offset: 0x00011670
	public static int a(int A_0, int A_1, int A_2)
	{
		if (A_1 < A_0)
		{
			return A_0;
		}
		if (A_1 > A_2)
		{
			return A_2;
		}
		return A_1;
	}

	// Token: 0x06000402 RID: 1026 RVA: 0x00013488 File Offset: 0x00011688
	public static double c(double A_0, double A_1)
	{
		int num = Convert.ToInt32(A_0 / A_1);
		return A_1 * (double)num;
	}

	// Token: 0x06000403 RID: 1027 RVA: 0x000134A4 File Offset: 0x000116A4
	public static float b(float A_0, float A_1, float A_2)
	{
		if (A_1 < A_0)
		{
			return A_0;
		}
		if (A_1 > A_2)
		{
			return A_2;
		}
		return A_1;
	}

	// Token: 0x06000404 RID: 1028 RVA: 0x000134BC File Offset: 0x000116BC
	public static double b(double A_0, double A_1, double A_2)
	{
		if (A_1 < A_0)
		{
			return A_0;
		}
		if (A_1 > A_2)
		{
			return A_2;
		}
		return A_1;
	}

	// Token: 0x06000405 RID: 1029 RVA: 0x000134D4 File Offset: 0x000116D4
	public static float? a(float A_0, float? A_1, float A_2)
	{
		if (A_1 == null)
		{
			return A_1;
		}
		float? num = A_1;
		if (num.GetValueOrDefault() < A_0 & num != null)
		{
			return new float?(A_0);
		}
		num = A_1;
		if (num.GetValueOrDefault() > A_2 & num != null)
		{
			return new float?(A_2);
		}
		return A_1;
	}

	// Token: 0x06000406 RID: 1030 RVA: 0x00013534 File Offset: 0x00011734
	public static double a(double A_0, double A_1, double A_2, double A_3, double A_4)
	{
		return A_3 + (A_4 - A_3) * ((A_0 - A_1) / (A_2 - A_1));
	}

	// Token: 0x06000407 RID: 1031 RVA: 0x00013544 File Offset: 0x00011744
	public static double a(double A_0, double A_1, double A_2)
	{
		return A_1 + (A_2 - A_1) * A_0;
	}

	// Token: 0x06000408 RID: 1032 RVA: 0x00013550 File Offset: 0x00011750
	public static float a(float A_0, float A_1, float A_2, float A_3, float A_4)
	{
		return A_3 + (A_4 - A_3) * ((A_0 - A_1) / (A_2 - A_1));
	}

	// Token: 0x06000409 RID: 1033 RVA: 0x00013560 File Offset: 0x00011760
	public static float a(float A_0, float A_1, float A_2)
	{
		return A_1 + (A_2 - A_1) * A_0;
	}

	// Token: 0x0600040A RID: 1034 RVA: 0x0001356C File Offset: 0x0001176C
	public static int b(int A_0, int A_1)
	{
		if (A_1 >= A_0)
		{
			return A_1;
		}
		return A_0;
	}

	// Token: 0x0600040B RID: 1035 RVA: 0x00013578 File Offset: 0x00011778
	public static float b(float A_0, float A_1)
	{
		if (A_1 >= A_0)
		{
			return A_1;
		}
		return A_0;
	}

	// Token: 0x0600040C RID: 1036 RVA: 0x00013584 File Offset: 0x00011784
	public static double b(double A_0, double A_1)
	{
		if (A_1 >= A_0)
		{
			return A_1;
		}
		return A_0;
	}

	// Token: 0x0600040D RID: 1037 RVA: 0x00013590 File Offset: 0x00011790
	public static int a(int A_0, int A_1)
	{
		if (A_1 <= A_0)
		{
			return A_1;
		}
		return A_0;
	}

	// Token: 0x0600040E RID: 1038 RVA: 0x0001359C File Offset: 0x0001179C
	public static float a(float A_0, float A_1)
	{
		if (A_1 <= A_0)
		{
			return A_1;
		}
		return A_0;
	}

	// Token: 0x0600040F RID: 1039 RVA: 0x000135A8 File Offset: 0x000117A8
	public static double a(double A_0, double A_1)
	{
		if (A_1 <= A_0)
		{
			return A_1;
		}
		return A_0;
	}

	// Token: 0x06000410 RID: 1040 RVA: 0x000135B8 File Offset: 0x000117B8
	public static int a(float A_0)
	{
		int num = (int)A_0;
		if (A_0 > (float)num)
		{
			return num + 1;
		}
		return num;
	}

	// Token: 0x06000411 RID: 1041 RVA: 0x000135D8 File Offset: 0x000117D8
	public static string a(Color A_0)
	{
		return string.Format("{0}, {1}, {2}, {3}", new object[]
		{
			A_0.R,
			A_0.G,
			A_0.B,
			A_0.A
		});
	}

	// Token: 0x06000412 RID: 1042 RVA: 0x00013634 File Offset: 0x00011834
	public static int a(int A_0)
	{
		if (A_0 > 1)
		{
			return A_0 * d05.a(A_0 - 1);
		}
		return A_0;
	}

	// Token: 0x06000413 RID: 1043 RVA: 0x0001364C File Offset: 0x0001184C
	public static double a(Point A_0, Point A_1)
	{
		return Math.Sqrt(Math.Pow((double)(A_0.X - A_1.X), 2.0) + Math.Pow((double)(A_0.Y - A_1.Y), 2.0));
	}

	// Token: 0x06000414 RID: 1044 RVA: 0x00013690 File Offset: 0x00011890
	public static T SafeClone<T>(T obj) where T : class
	{
		if (obj == null)
		{
			return default(T);
		}
		ICloneable cloneable = obj as ICloneable;
		if (cloneable != null)
		{
			return cloneable.Clone() as T;
		}
		return eoq.Clone<T>(obj);
	}

	// Token: 0x06000415 RID: 1045 RVA: 0x000136DC File Offset: 0x000118DC
	public static string[] a(string A_0)
	{
		if (!string.IsNullOrEmpty(A_0))
		{
			return A_0.Split(new string[]
			{
				"\r\n"
			}, StringSplitOptions.None);
		}
		return new string[]
		{
			""
		};
	}
}

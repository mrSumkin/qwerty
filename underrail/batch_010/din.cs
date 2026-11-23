using System;
using Microsoft.Xna.Framework;

// Token: 0x02000096 RID: 150
public static class din
{
	// Token: 0x0600037F RID: 895 RVA: 0x000101BC File Offset: 0x0000E3BC
	public static Quaternion b(Vector3 A_0)
	{
		float num = (float)Math.Cos((double)(A_0.X / 2f));
		float num2 = (float)Math.Sin((double)(A_0.X / 2f));
		float num3 = (float)Math.Cos((double)(A_0.Y / 2f));
		float num4 = (float)Math.Sin((double)(A_0.Y / 2f));
		float num5 = (float)Math.Cos((double)(A_0.Z / 2f));
		float num6 = (float)Math.Sin((double)(A_0.Z / 2f));
		return new Quaternion(num2 * num3 * num5 - num * num4 * num6, num * num4 * num5 + num2 * num3 * num6, num * num3 * num6 - num2 * num4 * num5, num * num3 * num5 + num2 * num4 * num6);
	}

	// Token: 0x06000380 RID: 896 RVA: 0x0001027C File Offset: 0x0000E47C
	public static Quaternion a(Vector3 A_0)
	{
		float num = (float)Math.Cos((double)(A_0.X / 2f));
		float num2 = (float)Math.Sin((double)(A_0.X / 2f));
		float num3 = (float)Math.Cos((double)(A_0.Y / 2f));
		float num4 = (float)Math.Sin((double)(A_0.Y / 2f));
		float num5 = (float)Math.Cos((double)(A_0.Z / 2f));
		float num6 = (float)Math.Sin((double)(A_0.Z / 2f));
		return new Quaternion(num3 * num2 * num5 - num4 * num * num6, num4 * num * num5 + num3 * num2 * num6, num3 * num * num6 + num4 * num2 * num5, num3 * num * num5 - num4 * num2 * num6);
	}

	// Token: 0x06000381 RID: 897 RVA: 0x0001033C File Offset: 0x0000E53C
	public static Vector3 b(Quaternion A_0)
	{
		double num = (double)(2f * (A_0.W * A_0.Y - A_0.X * A_0.Z));
		float y;
		if (num <= -0.99999)
		{
			float x = 2f * (float)Math.Atan2((double)A_0.X, (double)A_0.W);
			y = -1.5707964f;
			return new Vector3(x, y, 0f);
		}
		if (num >= 0.99999)
		{
			float x2 = 2f * (float)Math.Atan2((double)A_0.X, (double)A_0.W);
			y = 1.5707964f;
			return new Vector3(x2, y, 0f);
		}
		y = (float)Math.Asin(num);
		return new Vector3((float)Math.Atan2((double)(2f * (A_0.W * A_0.X + A_0.Y * A_0.Z)), (double)(1f - 2f * (A_0.X * A_0.X + A_0.Y * A_0.Y))), y, (float)Math.Atan2((double)(2f * (A_0.W * A_0.Z + A_0.X * A_0.Y)), (double)(1f - 2f * (A_0.Y * A_0.Y + A_0.Z * A_0.Z))));
	}

	// Token: 0x06000382 RID: 898 RVA: 0x00010490 File Offset: 0x0000E690
	public static Vector3 a(Quaternion A_0)
	{
		double num = (double)(2f * (A_0.W * A_0.X + A_0.Y * A_0.Z));
		float x;
		if (num <= -0.99999)
		{
			float y = 2f * (float)Math.Atan2((double)A_0.Y, (double)A_0.W);
			x = -1.5707964f;
			return new Vector3(x, y, 0f);
		}
		if (num >= 0.99999)
		{
			float y = 2f * (float)Math.Atan2((double)A_0.Y, (double)A_0.W);
			x = 1.5707964f;
			return new Vector3(x, y, 0f);
		}
		x = (float)Math.Asin(num);
		return new Vector3(x, (float)Math.Atan2((double)(2f * (A_0.W * A_0.Y - A_0.X * A_0.Z)), (double)(1f - 2f * (A_0.Y * A_0.Y + A_0.X * A_0.X))), (float)Math.Atan2((double)(2f * (A_0.W * A_0.Z - A_0.Y * A_0.X)), (double)(1f - 2f * (A_0.X * A_0.X + A_0.Z * A_0.Z))));
	}
}

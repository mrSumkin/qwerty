using System;
using Microsoft.Xna.Framework;

// Token: 0x02000736 RID: 1846
public sealed class diq : km
{
	// Token: 0x06002F9F RID: 12191 RVA: 0x00120480 File Offset: 0x0011E680
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int x = A_0.d() % 11;
		int num = 33;
		int num2 = A_0.d() / num;
		int num3 = A_0.d() % num;
		int num4 = A_0.d() / num + ((A_3 != null) ? A_3.GetHashCode() : 0);
		int seed = num4 + 1;
		a2f a2f = A_1.b(A_0, "Effects\\LaserDesignationCrosshair", new Point(x, 0), null, true);
		float num5 = Math.Abs(-1f + (float)(A_0.d() % 12) * 0.166f);
		num5 *= 0.75f;
		if (a2f != null && a2f.d != null)
		{
			Random random = new Random(num4);
			Random random2 = new Random(seed);
			Vector2 value = new Vector2((float)(-5 + random.Next(10)), (float)(-15 + random.Next(30)));
			Vector2 value2 = new Vector2((float)(-5 + random2.Next(10)), (float)(-15 + random2.Next(30)));
			Vector2 value3 = Vector2.Lerp(value, value2, (float)num3 / Convert.ToSingle(num));
			a2f.j += value3;
			a2f.e = new Color?(Color.Red);
			a2f.h = new float?(num5);
			a2f.f = 1f;
			eyc.a(a2f, A_2, 0.5);
			A_2.b.a(a2f);
		}
	}
}

using System;
using Microsoft.Xna.Framework;

// Token: 0x02000754 RID: 1876
public sealed class ack : km
{
	// Token: 0x06002FE0 RID: 12256 RVA: 0x00122598 File Offset: 0x00120798
	public override void b7(mv A_0, eg0 A_1, b3u A_2, object A_3)
	{
		int num = A_0.d() % 12;
		int num2 = num - 6;
		if (num2 < 0)
		{
			num2 += 12;
		}
		int num3 = 0;
		for (int i = 0; i < A_2.b.a.Count; i++)
		{
			if (A_2.b.a[i].a == "b")
			{
				num3 = i;
				Vector2 j = A_2.b.a[i].j;
				break;
			}
		}
		int[] array = new int[]
		{
			num,
			num2
		};
		for (int k = 0; k < 2; k++)
		{
			int x = array[k];
			a2f a2f = A_1.b(A_0, "Effects\\DisruptiveField", new Point(x, 0), null, true);
			a2f.h = new float?(ack.a[k]);
			a2f a2f2 = A_1.b(A_0, "Effects\\DisruptiveField", new Point(x, 2), null, true);
			a2f2.h = new float?(0.7f * ack.a[k]);
			a2f a2f3 = A_1.b(A_0, "Effects\\DisruptiveField", new Point(x, 1), null, true);
			a2f3.h = new float?(ack.a[k]);
			a2f a2f4 = A_1.b(A_0, "Effects\\DisruptiveField", new Point(x, 3), null, true);
			a2f4.h = new float?(0.7f * ack.a[k]);
			A_2.b.a(num3 + 1, a2f);
			A_2.b.a(num3 + 1, a2f2);
			A_2.b.a(num3, a2f4);
			A_2.b.a(num3, a2f3);
			num3 += 2;
		}
	}

	// Token: 0x04001A3F RID: 6719
	private static float[] a = new float[]
	{
		1f,
		0.5f
	};
}

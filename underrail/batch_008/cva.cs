using System;
using System.Linq;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013DE RID: 5086
public sealed class cva : ajr
{
	// Token: 0x06007295 RID: 29333 RVA: 0x003022F0 File Offset: 0x003004F0
	public override bool pf(amc A_0)
	{
		return true;
	}

	// Token: 0x06007296 RID: 29334 RVA: 0x003022F4 File Offset: 0x003004F4
	public override bool pg(amc A_0)
	{
		return true;
	}

	// Token: 0x06007297 RID: 29335 RVA: 0x003022FC File Offset: 0x003004FC
	public override void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		c5x c5x = A_0.a8();
		c5x c5x2 = A_1.a8();
		c5x2.c().a("CyrokinesisHit");
		c5x a_ = c5x2;
		string a_2 = "ColdHit";
		int a_3 = 1;
		double maxValue = double.MaxValue;
		bool a_4 = true;
		bool a_5 = true;
		float? a_6 = dz6.b();
		c5x c5x3 = boj.a(a_, a_2, a_3, maxValue, a_4, a_5, null, null, null, a_6, false);
		Vector3 vector = c5x.aj() + new Vector3(0f, 0f, c5x.Size.Z / 2f);
		Vector3 value;
		if (c5x3 != null)
		{
			value = c5x3.Location;
		}
		else
		{
			value = c5x2.aj();
		}
		int num = (int)((value - vector).Length() / 0.2f);
		Vector3 value2 = (value - vector) / (float)num;
		c5x.c().a("Cryokinesis");
		for (int i = 0; i < num; i++)
		{
			Vector3 a_7 = vector + value2 * (float)i;
			c5x c5x4 = boj.a(c5x2.Area, a_7, null, "xphw_icedust", 1, double.MaxValue, null, null, null, null);
			if (c5x4 != null && c5x4.o.b != null)
			{
				c5x4.o.b.b = new Point(0, cuo.a.Next(4));
			}
		}
		awq.a(A_0, A_1, A_3, A_2, A_5, false, null, "no_projectile", null, false, false, true, "no_sound", null);
		bd9 bd = Enumerable.FirstOrDefault<bd9>(A_0.aa().StatusEffects.Get<bd9>());
		if (bd != null)
		{
			bd.b = A_0.a8().Zone.ElapsedZoneTime;
		}
	}
}

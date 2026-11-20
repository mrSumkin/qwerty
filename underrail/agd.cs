using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Microsoft.Xna.Framework;
using Ouroboros.Playfield.Lightning;

// Token: 0x02001839 RID: 6201
[euj]
public sealed class agd
{
	// Token: 0x06008441 RID: 33857 RVA: 0x003715C8 File Offset: 0x0036F7C8
	[ayh("INEXAA")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			amc b = A_1.h.b;
			if (b == null || b.aa().Gear.l().Item == null)
			{
				return;
			}
			new eoj(b.aa(), b.aa().Gear.l().Item, null);
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(agd.a.a.c)));
			bool flag = false;
			ah7 ah;
			if (bsf == null || bsf.Definition == null)
			{
				flag = true;
				ah = new ah7("industrialExoskeletonLantern", null);
				ah.Layer = aju.x;
			}
			else
			{
				ah = bsf.Definition;
			}
			agd.a(b, ah);
			if (flag)
			{
				ah.g().be(A_1);
			}
			else
			{
				ah.d();
			}
			bfq bfq = new bfq("industrialExoskeletonActive", "IndustrialExoskeletonActive");
			bfq.d(true);
			A_1.Zone.ActionManager.g9(new a4s(bfq, null, new ar7(A_1), null), atp.a);
		}
	}

	// Token: 0x06008442 RID: 33858 RVA: 0x003716FC File Offset: 0x0036F8FC
	[ayh("INEXAR")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null)
		{
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_1.RaysEmitters), new Func<bsf, bool>(agd.a.a.b)));
			if (bsf != null)
			{
				bsf.ig();
			}
			A_1.c().a("industrialExoskeletonActive", false);
		}
	}

	// Token: 0x06008443 RID: 33859 RVA: 0x00371768 File Offset: 0x0036F968
	[ayh("INEXAT")]
	public void d(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.IsPlayer)
		{
			amc aspect = A_1.GetAspect<amc>();
			if (aspect != null && aspect.aa().Gear.l().Item != null)
			{
				aspect.aa().Gear.l().Item.a((double)e6v.f, true);
				agd.a(A_1);
			}
		}
	}

	// Token: 0x06008444 RID: 33860 RVA: 0x003717D8 File Offset: 0x0036F9D8
	public static void a(c5x A_0)
	{
		if (A_0 != null)
		{
			bsf bsf = Enumerable.FirstOrDefault<bsf>(Enumerable.Where<bsf>(Enumerable.OfType<bsf>(A_0.RaysEmitters), new Func<bsf, bool>(agd.a.a.a)));
			if (bsf != null && A_0.h.b != null)
			{
				agd.a(A_0.h.b, bsf.Definition);
				bsf.Definition.d();
			}
		}
	}

	// Token: 0x06008445 RID: 33861 RVA: 0x0037185C File Offset: 0x0036FA5C
	public static void a(amc A_0, ah7 A_1)
	{
		float num3;
		if (A_0.aa().Gear.l().Item != null)
		{
			int? num = A_0.aa().Gear.l().Item.Definition.ba();
			int num2 = 0;
			if (num.GetValueOrDefault() > num2 & num != null)
			{
				num3 = Convert.ToSingle(A_0.aa().Gear.l().Item.Battery / (double)A_0.aa().Gear.l().Item.Definition.ba().Value);
				if (num3 < 0.5f)
				{
					num3 *= 2f;
					goto IL_C5;
				}
				num3 = 1f;
				goto IL_C5;
			}
		}
		num3 = 1f;
		IL_C5:
		A_1.Light = new ae8(new Color(255, (int)((byte)(200f * num3)), (int)((byte)(200f * num3)), 255), 0.5f * num3, LightType.Increment);
		A_1.Range = 3f;
		A_1.LightFadeRate = 0.15f * num3;
	}

	// Token: 0x06008446 RID: 33862 RVA: 0x00371978 File Offset: 0x0036FB78
	[ayh("INEXAM")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 != null && A_1.IsPlayer)
		{
			amc aspect = A_1.GetAspect<amc>();
			if (aspect != null && aspect.aa().Gear.l().Item != null && aspect.aa().Gear.l().Item.Battery > 0.0)
			{
				float num = 0f;
				object obj;
				if (A_2 != null && A_2.TryGetValue("distance", out obj) && obj is float)
				{
					float num2 = (float)obj;
					num = num2;
				}
				double num3 = (double)((float)e6v.g * num);
				if (num3 > 0.0)
				{
					aspect.aa().Gear.l().Item.a(num3, true);
				}
			}
		}
	}

	// Token: 0x0200183A RID: 6202
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x0600844A RID: 33866 RVA: 0x00371A6C File Offset: 0x0036FC6C
		internal bool c(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "industrialExoskeletonLantern";
		}

		// Token: 0x0600844B RID: 33867 RVA: 0x00371A90 File Offset: 0x0036FC90
		internal bool b(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "industrialExoskeletonLantern";
		}

		// Token: 0x0600844C RID: 33868 RVA: 0x00371AB4 File Offset: 0x0036FCB4
		internal bool a(bsf A_0)
		{
			return A_0.Definition != null && A_0.Definition.Name == "industrialExoskeletonLantern";
		}

		// Token: 0x040032B6 RID: 12982
		public static readonly agd.a a = new agd.a();

		// Token: 0x040032B7 RID: 12983
		public static Func<bsf, bool> b;

		// Token: 0x040032B8 RID: 12984
		public static Func<bsf, bool> c;

		// Token: 0x040032B9 RID: 12985
		public static Func<bsf, bool> d;
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001029 RID: 4137
[eiz("ACX0")]
[Serializable]
public sealed class dxl : cze
{
	// Token: 0x06005566 RID: 21862 RVA: 0x0025B4CC File Offset: 0x002596CC
	private dxl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06005567 RID: 21863 RVA: 0x0025B4D8 File Offset: 0x002596D8
	public dxl()
	{
	}

	// Token: 0x06005568 RID: 21864 RVA: 0x0025B4E4 File Offset: 0x002596E4
	public override void ym(b0b A_0, b0b A_1, Dictionary<string, object> A_2)
	{
		c5x c5x = A_1 as c5x;
		List<csk> list = A_2["damage"] as List<csk>;
		cwt cwt = A_2["attackResult"] as cwt;
		if (c5x != null && c5x.Zone != null && list != null && cwt != null && !cwt.w)
		{
			if (Enumerable.Sum<csk>(Enumerable.Where<csk>(list, new Func<csk, bool>(dxl.a.a.a)), new Func<csk, int>(dxl.a.a.b)) > 0)
			{
				bool flag = c5x.h.b != null && c5x.h.b.aa().b(d8o.t) && c5x.h.b.aa().StatusEffects.a(dnq.a);
				ak1 ak = c5x.Area.a(c5x.aj().a());
				dtb dtb = new dtb();
				bfq bfq = new bfq("AcidFizz");
				bfq.a(0.5f);
				bfq a_ = bfq;
				dtb.ad().Add(new a4s(a_, null, new ar7(c5x), null));
				if (flag)
				{
					List<auv> list2 = dtb.ad();
					c5x a_2 = c5x;
					string a_3 = "RustingAcidSplash";
					int a_4 = 1;
					double maxValue = double.MaxValue;
					bool a_5 = true;
					bool a_6 = true;
					float? a_7 = dz6.b();
					list2.Add(new a7j(a_2, a_3, a_4, maxValue, a_5, a_6, null, null, null, a_7, false, null));
				}
				else
				{
					List<auv> list3 = dtb.ad();
					c5x a_8 = c5x;
					string a_9 = "AcidSplash";
					int a_10 = 1;
					double maxValue2 = double.MaxValue;
					bool a_11 = true;
					bool a_12 = true;
					float? a_7 = dz6.b();
					list3.Add(new a7j(a_8, a_9, a_10, maxValue2, a_11, a_12, null, null, null, a_7, false, null));
				}
				if (ak != null)
				{
					if (flag)
					{
						dtb.ad().Add(new a4s(new amg(new edx(ak), new EntityAspectReference<amc, amc>(c5x.h.b)), null, null, null));
					}
					else
					{
						dtb.ad().Add(new a4s(new dku(new edx(ak), new EntityAspectReference<amc, amc>(c5x.h.b), false, true, false), null, null, null));
					}
				}
				c5x.Zone.ActionManager.g9(dtb, atp.a);
				dz6.a(dtb);
			}
		}
	}

	// Token: 0x0200102A RID: 4138
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600556B RID: 21867 RVA: 0x0025B798 File Offset: 0x00259998
		internal bool a(csk A_0)
		{
			return A_0.DamageType != DamageType.Acid;
		}

		// Token: 0x0600556C RID: 21868 RVA: 0x0025B7A8 File Offset: 0x002599A8
		internal int b(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x040022C5 RID: 8901
		public static readonly dxl.a a = new dxl.a();

		// Token: 0x040022C6 RID: 8902
		public static Func<csk, bool> b;

		// Token: 0x040022C7 RID: 8903
		public static Func<csk, int> c;
	}
}

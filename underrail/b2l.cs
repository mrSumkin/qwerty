using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

// Token: 0x02000BAE RID: 2990
[euj]
public sealed class b2l
{
	// Token: 0x06004403 RID: 17411 RVA: 0x001AD894 File Offset: 0x001ABA94
	[ayh("exo_attacked")]
	public void b(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null || A_1.h.b == null || A_2 == null)
		{
			return;
		}
		object obj;
		if (A_2.TryGetValue("stats", out obj))
		{
			cru cru = obj as cru;
			object obj2;
			if (cru != null && A_2.TryGetValue("attackResult", out obj2))
			{
				cwt cwt = obj2 as cwt;
				if (cwt != null && cwt.b && cwt.ad != null && cwt.ad.GetPrimitivePropertyValue<bool>("IsMindDisrupting", new bool?(false)).Value && cru.a != null && cru.a.Count > 0)
				{
					int num = Enumerable.Sum<csk>(cru.a, new Func<csk, int>(b2l.a.a.a));
					if (num > 0)
					{
						int a_;
						if (num >= 33 && cwt.e)
						{
							a_ = 2;
						}
						else
						{
							a_ = 1;
						}
						dm3 dm = new dm3(5 * d0u.b);
						dm.Stacks = a_;
						A_1.h.b.aa().StatusEffects.a(dm, false, false, false);
					}
				}
			}
		}
	}

	// Token: 0x06004404 RID: 17412 RVA: 0x001AD9E0 File Offset: 0x001ABBE0
	[ayh("exo_hb")]
	public void c(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null || A_1.h.b == null)
		{
			return;
		}
		amc b = A_1.h.b;
		int num = 0;
		int num2 = 0;
		if (!b.aa().SpecialStates.d)
		{
			cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
			if (serviceOrThrow.aqu() != null && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_psiCommander_dead", new bool?(false)).Value)
			{
				num += 2;
			}
			d02 service = bpo.GetService<d02>();
			if (service != null)
			{
				foreach (d4n d4n in service.ahl())
				{
					if (d4n.b != b && d4n.b.aa().StatusEffects.a(e10.a))
					{
						d3l d3l = Enumerable.FirstOrDefault<d3l>(d4n.b.aa().StatusEffects.Get<d3l>());
						if (d3l != null)
						{
							num2 = Math.Max(num2, Math.Min(2, d3l.Stacks));
						}
					}
				}
			}
		}
		num += num2;
		dm3 dm = Enumerable.FirstOrDefault<dm3>(b.aa().StatusEffects.Get<dm3>());
		if (dm != null)
		{
			num = Math.Max(0, num - dm.Stacks);
		}
		d3l d3l2 = Enumerable.FirstOrDefault<d3l>(b.aa().StatusEffects.Get<d3l>());
		if (num <= 0)
		{
			if (d3l2 != null)
			{
				b.aa().StatusEffects.d(d3l2);
			}
			return;
		}
		if (d3l2 != null)
		{
			d3l2.Stacks = num;
			return;
		}
		d3l2 = new d3l();
		d3l2.Stacks = num;
		b.aa().StatusEffects.a(d3l2, false, false, false);
	}

	// Token: 0x06004405 RID: 17413 RVA: 0x001ADBC4 File Offset: 0x001ABDC4
	[ayh("exoint_hb")]
	public void a(c5x A_0, c5x A_1, Dictionary<string, object> A_2)
	{
		if (A_1 == null || A_1.h.b == null)
		{
			return;
		}
		bool flag = true;
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("npc_xphw_psiCommander_dead", new bool?(false)).Value)
		{
			flag = false;
		}
		amc b = A_1.h.b;
		bool flag2 = flag && !b.aa().SpecialStates.c && !b.aa().SpecialStates.d;
		e10 e = Enumerable.FirstOrDefault<e10>(b.aa().StatusEffects.Get<e10>());
		if (flag2)
		{
			if (e == null)
			{
				e = new e10();
				b.aa().StatusEffects.a(e, false, false, false);
				return;
			}
		}
		else if (e != null)
		{
			b.aa().StatusEffects.d(e);
		}
	}

	// Token: 0x02000BAF RID: 2991
	[CompilerGenerated]
	[Serializable]
	private sealed class a
	{
		// Token: 0x06004409 RID: 17417 RVA: 0x001ADCDC File Offset: 0x001ABEDC
		internal int a(csk A_0)
		{
			return A_0.Amount;
		}

		// Token: 0x04001C4C RID: 7244
		public static readonly b2l.a a = new b2l.a();

		// Token: 0x04001C4D RID: 7245
		public static Func<csk, int> b;
	}
}

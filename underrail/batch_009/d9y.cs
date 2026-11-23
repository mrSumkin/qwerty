using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001821 RID: 6177
[eiz("YUCA")]
[Serializable]
public sealed class d9y : a6k, ISerializable
{
	// Token: 0x06008380 RID: 33664 RVA: 0x0036E7D4 File Offset: 0x0036C9D4
	private d9y(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008381 RID: 33665 RVA: 0x0036E7E0 File Offset: 0x0036C9E0
	public d9y()
	{
	}

	// Token: 0x06008382 RID: 33666 RVA: 0x0036E7EC File Offset: 0x0036C9EC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg().q() == null || base.vg().q().h == null || base.vg().q().h.b == null)
		{
			return dc4.e;
		}
		c5x c5x = base.vg().h() as c5x;
		if (c5x == null || c5x.h == null || c5x.h.b == null)
		{
			return dc4.e;
		}
		coh coh = base.vg().e().b9() as coh;
		efk efk = c5x.h.b.aa();
		if (c5x.u.b != null)
		{
			cnk service = bpo.GetService<cnk>();
			if (service != null && service.aqu() != null)
			{
				List<string> list = new List<string>();
				if (service.aqu().r().GetPrimitivePropertyValue<float>("gp_sm", new float?(0f)).Value < 0.5f)
				{
					list.Add("Надеюсь, это сработает.");
					list.Add("Давай-давай, делай своё дело.");
					list.Add("Ничего не произошло...");
				}
				else
				{
					list.Add("Давай.");
					list.Add("Настало время блистать.");
					list.Add("Не подведи меня.");
				}
				c5x.u.b.a(list[cuo.a.Next(0, list.Count)], true, null, null);
			}
		}
		c5x.c().a("kissCharm", "KissCharm", 1f, c9z.a, false, false);
		if (coh != null && coh.Definition.a5() != null && coh.Definition.a5().Length > 6)
		{
			string text = coh.Definition.a5().Substring(6);
			c32 c = Enumerable.FirstOrDefault<c32>(efk.StatusEffects.Get<c32>());
			if (c != null)
			{
				if (c.b == text)
				{
					c.ad();
				}
			}
			else
			{
				c = new c32(exe.a * d0u.b, text);
				efk.StatusEffects.a(c, false, false, true);
			}
		}
		return dc4.c;
	}
}

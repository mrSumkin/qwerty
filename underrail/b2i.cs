using System;
using System.Collections.Generic;
using System.Linq;

// Token: 0x020007FC RID: 2044
public sealed class b2i : el4
{
	// Token: 0x06003383 RID: 13187 RVA: 0x00140B1C File Offset: 0x0013ED1C
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x06003384 RID: 13188 RVA: 0x00140B28 File Offset: 0x0013ED28
	public override string a4()
	{
		return "PRO_DREAD1";
	}

	// Token: 0x06003385 RID: 13189 RVA: 0x00140B30 File Offset: 0x0013ED30
	public override string a5()
	{
		return "Protectorate Dreadnought Attack 1";
	}

	// Token: 0x06003386 RID: 13190 RVA: 0x00140B3C File Offset: 0x0013ED3C
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value || (!A_2.g().Contains("tchortistPatrolX") && !A_2.g().Contains("tchortistPatrolY"))) && base.e2(A_0, A_1, A_2);
	}

	// Token: 0x06003387 RID: 13191 RVA: 0x00140BA4 File Offset: 0x0013EDA4
	protected override bool a6()
	{
		return true;
	}

	// Token: 0x06003388 RID: 13192 RVA: 0x00140BA8 File Offset: 0x0013EDA8
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003389 RID: 13193 RVA: 0x00140BAC File Offset: 0x0013EDAC
	public override bool fl()
	{
		return true;
	}

	// Token: 0x0600338A RID: 13194 RVA: 0x00140BB0 File Offset: 0x0013EDB0
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(15.0));
	}

	// Token: 0x0600338B RID: 13195 RVA: 0x00140BC8 File Offset: 0x0013EDC8
	public b2i() : base(new string[]
	{
		ega.o,
		ega.n,
		ega.s,
		ega.r
	})
	{
	}

	// Token: 0x0600338C RID: 13196 RVA: 0x00140BFC File Offset: 0x0013EDFC
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		List<csd> list = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null && csd.Name.StartsWith("randomEvent_pro-dread1", StringComparison.OrdinalIgnoreCase))
			{
				list.Add(csd);
			}
		}
		gx gx = new gx();
		Random random = new Random();
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null && list[i].Name.StartsWith("randomEvent_pro-dread1_guard"))
			{
				c5x a_;
				if (A_2.g().Contains("tchortistPatrolX") || A_2.g().Contains("tchortistPatrolY"))
				{
					a_ = gx.a(list[i], new int?(20), "Lunatics", null, null, null, null, false, null, false);
				}
				else if (random.Next(0, 101) > 50)
				{
					a_ = gx.a(list[i], new int?(20), "Lurkers", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
				else
				{
					a_ = gx.a(list[i], new int?(20), "Ironheads", "Bandit", "up_bandit_agr", "", null, true, null, false);
				}
				this.iy(a_);
			}
		}
	}
}

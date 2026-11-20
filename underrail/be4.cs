using System;
using System.Collections.Generic;
using System.Linq;
using TimelapseVertigo.Rules;

// Token: 0x020008B0 RID: 2224
public sealed class be4 : el4
{
	// Token: 0x06003749 RID: 14153 RVA: 0x0014BDE8 File Offset: 0x00149FE8
	protected override esj a3()
	{
		return new esj(5, 5);
	}

	// Token: 0x0600374A RID: 14154 RVA: 0x0014BDF4 File Offset: 0x00149FF4
	public override string a4()
	{
		return "Xpbl_SOR_WS1";
	}

	// Token: 0x0600374B RID: 14155 RVA: 0x0014BDFC File Offset: 0x00149FFC
	public override string a5()
	{
		return "Global Event - Sørmirbæren Worship 1";
	}

	// Token: 0x0600374C RID: 14156 RVA: 0x0014BE04 File Offset: 0x0014A004
	public override string ix()
	{
		return "xpbl";
	}

	// Token: 0x0600374D RID: 14157 RVA: 0x0014BE10 File Offset: 0x0014A010
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("faction_xpbl_sormirbaren_defeated", new bool?(false)).Value && !A_0.r().GetPrimitivePropertyValue<bool>("loc_xpbl_camp_underAttack", new bool?(false)).Value;
	}

	// Token: 0x0600374E RID: 14158 RVA: 0x0014BE74 File Offset: 0x0014A074
	public override double ke()
	{
		return 0.07;
	}

	// Token: 0x0600374F RID: 14159 RVA: 0x0014BE80 File Offset: 0x0014A080
	public override bool fk()
	{
		return true;
	}

	// Token: 0x06003750 RID: 14160 RVA: 0x0014BE84 File Offset: 0x0014A084
	public override bool fl()
	{
		return true;
	}

	// Token: 0x06003751 RID: 14161 RVA: 0x0014BE88 File Offset: 0x0014A088
	protected override TimeSpan? a8()
	{
		return new TimeSpan?(TimeSpan.FromMinutes(60.0));
	}

	// Token: 0x06003752 RID: 14162 RVA: 0x0014BEA0 File Offset: 0x0014A0A0
	public be4() : base(new string[]
	{
		ega.a6
	})
	{
	}

	// Token: 0x06003753 RID: 14163 RVA: 0x0014BEB8 File Offset: 0x0014A0B8
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		gx gx = new gx();
		List<csd> list = new List<csd>();
		List<csd> list2 = new List<csd>();
		foreach (csd csd in Enumerable.ToList<csd>(A_1.Waypoints))
		{
			if (csd != null)
			{
				if (csd.Name.StartsWith("randomEvent_xpbl_sor_ws1_guard", StringComparison.OrdinalIgnoreCase))
				{
					list.Add(csd);
				}
				else if (csd.Name.StartsWith("randomEvent_xpbl_sor_ws1_skaerder", StringComparison.OrdinalIgnoreCase))
				{
					list2.Add(csd);
				}
			}
		}
		for (int i = 0; i < list.Count; i++)
		{
			if (list[i] != null)
			{
				c5x a_ = gx.a(list[i], new int?(10), "Sormirbaren", null, null, null, null, false, null, false);
				this.iy(a_);
			}
		}
		bu6 service = bpo.GetService<bu6>();
		if (service != null)
		{
			int num;
			if (service.aq2() >= GameDifficulty.Dominating)
			{
				num = 4;
			}
			else if (service.aq2() >= GameDifficulty.Hard)
			{
				num = 2;
			}
			else
			{
				num = 0;
			}
			if (num > 0)
			{
				List<string> list3 = @is.a(true);
				for (int j = 0; j < num; j++)
				{
					if (list2[j] != null)
					{
						c5x c5x = vq.a(list3[j], list2[j], false);
						if (c5x != null && c5x.t.b != null)
						{
							c5x.t.b.y6()[ddq.ay] = new bt4(list2[j].Name);
						}
						this.iy(c5x);
					}
				}
			}
		}
	}
}

using System;
using System.Linq;

// Token: 0x020008C9 RID: 2249
public sealed class euc : el4
{
	// Token: 0x060037F7 RID: 14327 RVA: 0x0014D8A4 File Offset: 0x0014BAA4
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060037F8 RID: 14328 RVA: 0x0014D8B0 File Offset: 0x0014BAB0
	public override string a4()
	{
		return "CC_PH_DB2";
	}

	// Token: 0x060037F9 RID: 14329 RVA: 0x0014D8B8 File Offset: 0x0014BAB8
	public override string a5()
	{
		return "Core City Player House Dead Burglar 2";
	}

	// Token: 0x060037FA RID: 14330 RVA: 0x0014D8C0 File Offset: 0x0014BAC0
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_deadBurglars_happened", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_security_turrets_gunEntry", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_security_turrets_plasmaEntry", new bool?(false)).Value);
	}

	// Token: 0x060037FB RID: 14331 RVA: 0x0014D94C File Offset: 0x0014BB4C
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x060037FC RID: 14332 RVA: 0x0014D950 File Offset: 0x0014BB50
	public euc() : base(new string[]
	{
		ega.@as
	})
	{
	}

	// Token: 0x060037FD RID: 14333 RVA: 0x0014D968 File Offset: 0x0014BB68
	public override void ov(cyt A_0, c1a A_1, bop A_2)
	{
		base.ov(A_0, A_1, A_2);
		A_0.r()["loc_ph_deadBurglars_happened"] = true;
		d60 d = A_1.a();
		if (d != null)
		{
			c5x c5x = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"deadBody",
				base.c()
			})) as c5x;
			c5x c5x2 = Enumerable.FirstOrDefault<b0b>(d.ab6(new string[]
			{
				"blood",
				base.c()
			})) as c5x;
			if (c5x != null)
			{
				cd0 aspect = c5x.GetAspect<cd0>();
				if (aspect != null)
				{
					Random random = new Random();
					switch (random.Next(1, 5))
					{
					case 1:
						aspect.a = "Creatures\\rg1\\di";
						break;
					case 2:
						aspect.a = "Creatures\\rg2\\di";
						break;
					case 3:
						aspect.a = "Creatures\\rg_f1\\di";
						c5x.q("Тело женщины");
						break;
					case 4:
						aspect.a = "Creatures\\rg_f2\\di";
						c5x.q("Тело женщины");
						break;
					default:
						aspect.a = "Creatures\\rg1\\di";
						break;
					}
					if (c5x2 != null)
					{
						int x = random.Next(0, 3);
						c5x2.o.b.b.X = x;
					}
				}
			}
		}
	}
}

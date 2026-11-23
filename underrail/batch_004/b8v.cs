using System;
using System.Linq;

// Token: 0x020008C8 RID: 2248
public sealed class b8v : el4
{
	// Token: 0x060037F0 RID: 14320 RVA: 0x0014D6B4 File Offset: 0x0014B8B4
	protected override esj a3()
	{
		return new esj(3, 3);
	}

	// Token: 0x060037F1 RID: 14321 RVA: 0x0014D6C0 File Offset: 0x0014B8C0
	public override string a4()
	{
		return "CC_PH_DB1";
	}

	// Token: 0x060037F2 RID: 14322 RVA: 0x0014D6C8 File Offset: 0x0014B8C8
	public override string a5()
	{
		return "Core City Player House Dead Burglar 1";
	}

	// Token: 0x060037F3 RID: 14323 RVA: 0x0014D6D0 File Offset: 0x0014B8D0
	protected override bool a6()
	{
		return false;
	}

	// Token: 0x060037F4 RID: 14324 RVA: 0x0014D6D8 File Offset: 0x0014B8D8
	public override bool e2(cyt A_0, c1a A_1, bop A_2)
	{
		return base.e2(A_0, A_1, A_2) && !A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_deadBurglars_happened", new bool?(false)).Value && (A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_security_turrets_gunEntry", new bool?(false)).Value || A_0.r().GetPrimitivePropertyValue<bool>("loc_ph_security_turrets_plasmaEntry", new bool?(false)).Value);
	}

	// Token: 0x060037F5 RID: 14325 RVA: 0x0014D764 File Offset: 0x0014B964
	public b8v() : base(new string[]
	{
		ega.@as
	})
	{
	}

	// Token: 0x060037F6 RID: 14326 RVA: 0x0014D780 File Offset: 0x0014B980
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
					int num = random.Next(1, 3);
					if (num != 1)
					{
						if (num != 2)
						{
							aspect.a = "Creatures\\hu1\\di";
						}
						else
						{
							aspect.a = "Creatures\\hu_f1\\di";
							c5x.q("Тело женщины");
						}
					}
					else
					{
						aspect.a = "Creatures\\hu1\\di";
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

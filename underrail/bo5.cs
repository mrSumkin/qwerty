using System;
using Ouroboros.Playfield.References;
using TimelapseVertigo.Rules.Items;

// Token: 0x020013EA RID: 5098
public class bo5 : ajr, e4
{
	// Token: 0x060072C6 RID: 29382 RVA: 0x0030476C File Offset: 0x0030296C
	public override bool o9()
	{
		return true;
	}

	// Token: 0x060072C7 RID: 29383 RVA: 0x00304770 File Offset: 0x00302970
	public override bool pa()
	{
		return true;
	}

	// Token: 0x060072C8 RID: 29384 RVA: 0x00304774 File Offset: 0x00302974
	public bg3 zj(efk A_0, efk A_1, double A_2, bool A_3, double A_4, AmmoType A_5, cmn A_6)
	{
		double num = c91.a(A_2, A_0.Offense.u().TypedDefinition);
		return euf.a(A_0, A_1, Math.Min(A_2, (double)A_0.Offense.u().TypedDefinition.ad()), A_4, A_0.Darkvision, A_0.Offense.u().CurrentBullet, A_3, 1.0 - num, A_6, null, null);
	}

	// Token: 0x060072C9 RID: 29385 RVA: 0x003047EC File Offset: 0x003029EC
	public override void pe(amc A_0, amc A_1, cd1 A_2, cwt A_3, AmmoType A_4, enp A_5 = null, Action<cwt, amc> A_6 = null)
	{
		if (A_0 == null)
		{
			return;
		}
		c91 c = dgk.Get<c91>();
		if (c != null)
		{
			eu7 eu = ecf.a(c, new eru(new EntityAspectReference<amc, amc>(A_0)), null) as eu7;
			if (eu != null)
			{
				if (eu.yw())
				{
					cp.b(eu, A_0.a8(), A_1.a8());
					return;
				}
				d02 service = bpo.GetService<d02>();
				if (service != null && service.ahg())
				{
					d4n d4n = service.ahu(A_0.aa());
					if (d4n != null && (double)eu.d(A_1) > d4n.c)
					{
						if (A_0.aa() is e3q)
						{
							bmj.a(A_0.a8(), new cwl());
						}
						return;
					}
				}
				if (A_0.aa().Offense.u().LoadedAmmo.Count == 0)
				{
					bmj.a(A_0.a8(), new e5x("Нет боеприпасов!", adi.m, A_0.aa().Offense.u().TypedDefinition.a3(), false));
					awq.a(A_0.a8(), A_0.aa().Offense.u());
				}
			}
		}
	}

	// Token: 0x060072CA RID: 29386 RVA: 0x00304918 File Offset: 0x00302B18
	public override int? pb(amc A_0)
	{
		if (A_0 != null)
		{
			c91 c = dgk.Get<c91>();
			if (c != null)
			{
				eu7 eu = ecf.a(c, new eru(new EntityAspectReference<amc, amc>(A_0)), null) as eu7;
				if (eu != null)
				{
					return new int?(eu.d(null));
				}
			}
		}
		return null;
	}

	// Token: 0x060072CB RID: 29387 RVA: 0x0030496C File Offset: 0x00302B6C
	public override bool pf(amc A_0)
	{
		c91 c = dgk.Get<c91>();
		if (c != null)
		{
			eu7 eu = ecf.a(c, new eru(new EntityAspectReference<amc, amc>(A_0)), null) as eu7;
			if (eu != null && eu.yw())
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x060072CC RID: 29388 RVA: 0x003049B4 File Offset: 0x00302BB4
	public override string pc(cd1 A_0)
	{
		return "Одиночные выстрелы невозможны, только стрельба очередями.";
	}
}

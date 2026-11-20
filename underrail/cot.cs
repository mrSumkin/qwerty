using System;
using System.Linq;
using Ouroboros.Playfield.References;

// Token: 0x02000373 RID: 883
public static class cot
{
	// Token: 0x06001890 RID: 6288 RVA: 0x0007E21C File Offset: 0x0007C41C
	public static bool b(amc A_0)
	{
		if (!bpo.GetServiceOrThrow<d02>().ahg() && A_0.aa().Defense.q().zo() < A_0.aa().Defense.q().zm() * 0.8f && (A_0.aa().Defense.q().zo() > A_0.aa().Defense.q().zm() * 0.4f || A_0.aa().Feats.Contains<yn>()))
		{
			coh coh = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.bandage"));
			if (coh != null)
			{
				ec3 ec = dgk.Get<ec3>();
				if (ec != null)
				{
					eu7 eu = ecf.a(ec, new eru(new EntityAspectReference<amc, amc>(A_0)), coh) as eu7;
					return eu != null && eu.yw();
				}
			}
		}
		if (A_0.aa().Defense.q().zo() < A_0.aa().Defense.q().zm() * 0.66f)
		{
			coh coh2 = Enumerable.FirstOrDefault<coh>(Enumerable.Union<coh>(Enumerable.Union<coh>(Enumerable.Union<coh>(Enumerable.Union<coh>(Enumerable.Union<coh>(A_0.aa().Bag.b("med.healthHypo"), A_0.aa().Bag.b("med.advancedHealthHypo")), A_0.aa().Bag.b("med.superHealthHypo")), A_0.aa().Bag.b("med.healthHypoEnriched")), A_0.aa().Bag.b("med.advancedHealthHypoEnriched")), A_0.aa().Bag.b("med.superHealthHypoEnriched")));
			if (coh2 != null)
			{
				cwn cwn = dgk.Get<cwn>();
				if (cwn != null)
				{
					eu7 eu2 = ecf.a(cwn, new eru(new EntityAspectReference<amc, amc>(A_0)), coh2) as eu7;
					return eu2 != null && eu2.yw();
				}
			}
			else
			{
				coh coh3 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.healingSalve"));
				if (coh3 != null)
				{
					ezp ezp = dgk.Get<ezp>();
					if (ezp != null)
					{
						eu7 eu3 = ecf.a(ezp, new eru(new EntityAspectReference<amc, amc>(A_0)), coh3) as eu7;
						return eu3 != null && eu3.yw();
					}
				}
			}
		}
		return false;
	}

	// Token: 0x06001891 RID: 6289 RVA: 0x0007E47C File Offset: 0x0007C67C
	public static cst a(amc A_0)
	{
		if (!bpo.GetServiceOrThrow<d02>().ahg() && A_0.aa().Defense.q().zo() < A_0.aa().Defense.q().zm() * 0.8f && (A_0.aa().Defense.q().zo() > A_0.aa().Defense.q().zm() * 0.4f || A_0.aa().Feats.Contains<yn>()))
		{
			coh coh = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.bandage"));
			if (coh != null)
			{
				ec3 ec = dgk.Get<ec3>();
				if (ec != null)
				{
					eu7 eu = ecf.a(ec, new eru(new EntityAspectReference<amc, amc>(A_0)), coh) as eu7;
					if (eu != null && eu.yw())
					{
						return cp.b(eu, A_0.a8(), A_0.a8());
					}
				}
			}
		}
		if (A_0.aa().Defense.q().zo() < A_0.aa().Defense.q().zm() * 0.66f)
		{
			int num = (int)(A_0.aa().Defense.q().zm() - A_0.aa().Defense.q().zo());
			coh coh2 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.healthHypoEnriched"));
			coh coh3 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.advancedHealthHypoEnriched"));
			coh coh4 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.superHealthHypoEnriched"));
			coh coh5;
			if (coh2 != null || coh3 != null || coh4 != null)
			{
				if (num >= 300 && coh4 != null)
				{
					coh5 = coh4;
				}
				else if (num >= 100 && coh3 != null)
				{
					coh5 = coh3;
				}
				else if (coh2 != null)
				{
					coh5 = coh2;
				}
				else if (coh3 != null)
				{
					coh5 = coh3;
				}
				else
				{
					coh5 = coh4;
				}
			}
			else
			{
				coh coh6 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.healthHypo"));
				coh coh7 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.advancedHealthHypo"));
				coh coh8 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.superHealthHypo"));
				if (num >= 300 && coh8 != null)
				{
					coh5 = coh8;
				}
				else if (num >= 100 && coh7 != null)
				{
					coh5 = coh7;
				}
				else if (coh6 != null)
				{
					coh5 = coh6;
				}
				else if (coh7 != null)
				{
					coh5 = coh7;
				}
				else
				{
					coh5 = coh8;
				}
			}
			if (coh5 != null)
			{
				cwn cwn = dgk.Get<cwn>();
				if (cwn != null)
				{
					eu7 eu2 = ecf.a(cwn, new eru(new EntityAspectReference<amc, amc>(A_0)), coh5) as eu7;
					if (eu2 != null && eu2.yw())
					{
						return cp.b(eu2, A_0.a8(), A_0.a8());
					}
				}
			}
			else
			{
				coh coh9 = Enumerable.FirstOrDefault<coh>(A_0.aa().Bag.b("med.healingSalve"));
				if (coh9 != null)
				{
					ezp ezp = dgk.Get<ezp>();
					if (ezp != null)
					{
						eu7 eu3 = ecf.a(ezp, new eru(new EntityAspectReference<amc, amc>(A_0)), coh9) as eu7;
						if (eu3 != null && eu3.yw())
						{
							return cp.b(eu3, A_0.a8(), A_0.a8());
						}
					}
				}
			}
		}
		return null;
	}
}

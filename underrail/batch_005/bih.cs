using System;
using System.Diagnostics;
using System.Linq;

// Token: 0x02002119 RID: 8473
[s3("1.1.3.0_PlayerMutant", "1.1.3.0")]
public sealed class bih : cwo, mx
{
	// Token: 0x0600C87F RID: 51327 RVA: 0x0046AE8C File Offset: 0x0046908C
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.v() != null && A_0.v().CustomProperties.GetClassPropertyValue<string>(ddm.a) != null)
			{
				A_0.v().AttributesBase |= d8o.t;
				A_0.v().Portrait = "plmut";
				A_0.v().CustomProperties[ddm.a] = "plmut";
				foreach (ai8 ai in Enumerable.ToList<ai8>(A_0.v().Feats))
				{
					if (!ai.IsAvailableToMutant)
					{
						A_0.v().Feats.b(ai.GetType());
					}
				}
				a9l.a(A_0.v());
				a9l.b(A_0.v());
				if (A_0.v().Feats.Contains<er5>())
				{
					A_0.v().Feats.d(typeof(er5));
				}
				A_0.v().bl();
				bv9 bv = A_0.ac() as bv9;
				if (bv != null)
				{
					bv.a(asp.d5, asp.a, h.c, null, true, false, false);
					bv.a(asp.du, asp.a, h.b, null, true, false, false);
				}
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				if (serviceOrThrow.aqu() != null)
				{
					foreach (eza eza in Enumerable.ToList<eza>(A_0.t().c()))
					{
						serviceOrThrow.aqz().atd(eza.Value.Name, true);
					}
					if (dk2.f())
					{
						serviceOrThrow.aqz().atb("xpbl_playerMutated", true);
					}
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}

	// Token: 0x0600C880 RID: 51328 RVA: 0x0046B0F4 File Offset: 0x004692F4
	public bool x5(cyt A_0, c1a A_1)
	{
		try
		{
			c5x c5x = A_0.v().b() as c5x;
			if (c5x != null && A_0.v().CustomProperties.GetClassPropertyValue<string>(ddm.a) != null)
			{
				amc aspect = c5x.GetAspect<amc>();
				if (aspect != null)
				{
					aspect.a("plmut");
				}
			}
			return true;
		}
		catch (Exception ex)
		{
			Trace.WriteLine(ex.ToString());
		}
		return false;
	}
}

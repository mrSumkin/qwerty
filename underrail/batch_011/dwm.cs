using System;
using System.Collections.Generic;
using System.Diagnostics;

// Token: 0x02002144 RID: 8516
[s3("1.1.2.0_MajorPsiChanges", "1.1.2.0")]
public sealed class dwm : cwo
{
	// Token: 0x0600C8CD RID: 51405 RVA: 0x0046DB3C File Offset: 0x0046BD3C
	public bool ee(cyt A_0)
	{
		try
		{
			if (A_0.v() != null && A_0.v().Feats.Contains<c3v>())
			{
				int num = A_0.v().BaseAbilities.Get<av8>().f();
				if (A_0.v().BaseAbilities.Get<axr>().f() > num)
				{
					A_0.v().Feats.d(typeof(ck5));
					d48 a_ = new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Medicine\\PsychoNeuralReconstructiveAgent"));
					A_0.v().Bag.z3(a_, true);
				}
				if (A_0.v().PsiAbilities.a() > 0)
				{
					int num2 = c2h.b(A_0.v());
					if (num2 > 0)
					{
						List<string> list = new List<string>();
						foreach (aia aia in A_0.v().PsiAbilities)
						{
							c3n c3n = dgk.a(aia.CapabilityFullTypeName);
							if (c3n != null)
							{
								list.Add(c3n.TechnicalName);
							}
						}
						for (int i = 0; i < num2; i++)
						{
							int index = cuo.a.Next(list.Count);
							A_0.v().Offense.ai[i] = list[index];
							list.RemoveAt(index);
							if (list.Count == 0)
							{
								break;
							}
						}
					}
				}
				int a_2 = 10;
				if (A_0.r().GetPrimitivePropertyValue<bool>("loc_tch_tremorsStarted", new bool?(false)).Value && !am9.a())
				{
					a_2 = 80;
				}
				else if (am9.c())
				{
					a_2 = 30;
				}
				else if (am9.d())
				{
					a_2 = 20;
				}
				coh coh = new d48(ez2.CreateDefinitonProvider<cv9>("Consumables\\Medicine\\PsiInhalant"))
				{
					Stacks = a_2
				};
				if (coh != null)
				{
					A_0.v().Bag.z3(coh, true);
				}
				A_0.v().bl();
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

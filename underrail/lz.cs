using System;
using System.Runtime.Serialization;

// Token: 0x020016E6 RID: 5862
[eiz("ESA")]
[Serializable]
public sealed class lz : cvd
{
	// Token: 0x06007F75 RID: 32629 RVA: 0x0035F8D4 File Offset: 0x0035DAD4
	private lz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F76 RID: 32630 RVA: 0x0035F8E0 File Offset: 0x0035DAE0
	public lz()
	{
	}

	// Token: 0x06007F77 RID: 32631 RVA: 0x0035F8EC File Offset: 0x0035DAEC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null)
		{
			d02 service = bpo.GetService<d02>();
			if (service != null && service.ahg())
			{
				d4n d4n = service.ahu(base.aig().f().h.b.aa());
				if (d4n != null || d4n == service.ahe())
				{
					coh coh = base.aig().e().b9() as coh;
					if (coh == null || coh.Definition == null || coh.Definition.a5() != "vanishingPowder")
					{
						d4n.a(false);
					}
					if (base.aig().f().IsPlayer && base.aig().f().h.b.aa().IsInCombat)
					{
						bool flag = true;
						foreach (d4n d4n2 in service.ahl())
						{
							if (d4n2 != d4n && d4n2.b != null && !d4n2.b.aa().Passive && d4n2.b.a8() != null && d4n2.b.a(base.aig().f().h.b) == h.a)
							{
								bm6 b = d4n2.b.a8().t.b;
								if (b != null)
								{
									erl erl = b.c(base.aig().f().h.b);
									if (erl != null && erl.f() == cem.d)
									{
										flag = false;
										break;
									}
								}
							}
						}
						if (flag)
						{
							cxc.c(eyy.at);
						}
					}
				}
			}
			if (base.aig().f().IsPlayer || base.aig().f().c(dm9.b))
			{
				bfq bfq = new bfq();
				bfq.b("enterStealth");
				bfq.c("EnterStealth");
				base.aig().f().Zone.ActionManager.g9(new a4s(bfq, null, new ar7(base.aig().f()), null), atp.a);
			}
			return dc4.c;
		}
		return dc4.e;
	}
}

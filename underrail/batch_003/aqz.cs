using System;

// Token: 0x02001231 RID: 4657
[eiz("P14c")]
public sealed class aqz : cf9
{
	// Token: 0x0600645F RID: 25695 RVA: 0x002B19CC File Offset: 0x002AFBCC
	public void rx(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			bfq bfq = new bfq("personalCloaking", "PersonalCloakingLoop");
			bfq.d(true);
			A_1.a8().Zone.ActionManager.g9(new a4s(bfq, null, new ar7(A_1.a8()), null), atp.a);
		}
	}

	// Token: 0x06006460 RID: 25696 RVA: 0x002B1A2C File Offset: 0x002AFC2C
	public void ry(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a("personalCloaking", false);
		}
	}

	// Token: 0x06006461 RID: 25697 RVA: 0x002B1A58 File Offset: 0x002AFC58
	public void rz(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a(Guid.NewGuid().ToString(), "PersonalCloakingActivate", 1f, c9z.a, false, false);
			A_1.a8().c().a("personalCloaking", "PersonalCloakingLoop", 1f, c9z.a, true, false);
		}
	}

	// Token: 0x06006462 RID: 25698 RVA: 0x002B1ACC File Offset: 0x002AFCCC
	public void r0(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a("personalCloaking", false);
		}
	}

	// Token: 0x06006463 RID: 25699 RVA: 0x002B1AF8 File Offset: 0x002AFCF8
	public void r1(els A_0, amc A_1)
	{
	}

	// Token: 0x06006464 RID: 25700 RVA: 0x002B1AFC File Offset: 0x002AFCFC
	public void r2(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a("personalCloaking", false);
		}
	}
}

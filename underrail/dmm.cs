using System;

// Token: 0x02001230 RID: 4656
[eiz("P15c")]
public sealed class dmm : cf9
{
	// Token: 0x06006458 RID: 25688 RVA: 0x002B1894 File Offset: 0x002AFA94
	public void rx(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			bfq bfq = new bfq("nightvisionBuzzing", "NightvisionBuzzing");
			bfq.d(true);
			A_1.a8().Zone.ActionManager.g9(new a4s(bfq, null, new ar7(A_1.a8()), null), atp.a);
		}
	}

	// Token: 0x06006459 RID: 25689 RVA: 0x002B18F4 File Offset: 0x002AFAF4
	public void ry(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a("nightvisionBuzzing", false);
		}
	}

	// Token: 0x0600645A RID: 25690 RVA: 0x002B1920 File Offset: 0x002AFB20
	public void rz(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a("nightvisionBuzzing", "NightvisionBuzzing", 1f, c9z.a, true, false);
		}
	}

	// Token: 0x0600645B RID: 25691 RVA: 0x002B1964 File Offset: 0x002AFB64
	public void r0(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a("nightvisionBuzzing", false);
		}
	}

	// Token: 0x0600645C RID: 25692 RVA: 0x002B1990 File Offset: 0x002AFB90
	public void r1(els A_0, amc A_1)
	{
	}

	// Token: 0x0600645D RID: 25693 RVA: 0x002B1994 File Offset: 0x002AFB94
	public void r2(els A_0, amc A_1)
	{
		if (A_1 != null && A_1.a8() != null)
		{
			A_1.a8().c().a("nightvisionBuzzing", false);
		}
	}
}

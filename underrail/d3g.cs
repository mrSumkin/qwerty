using System;
using Ouroboros.Events;

// Token: 0x02000345 RID: 837
[ajo("PriTarAct")]
public sealed class d3g : dj4
{
	// Token: 0x060017A9 RID: 6057 RVA: 0x0007860C File Offset: 0x0007680C
	public override bool abf()
	{
		return false;
	}

	// Token: 0x060017AA RID: 6058 RVA: 0x00078610 File Offset: 0x00076810
	public override bool abg()
	{
		return false;
	}

	// Token: 0x060017AB RID: 6059 RVA: 0x00078618 File Offset: 0x00076818
	public override void abi(cte A_0, TimeSpan A_1, TimeSpan A_2)
	{
		if (new bzv(A_0.y6()).g() == null)
		{
			return;
		}
		TimeSpan? primitivePropertyValue = A_0.y6().GetPrimitivePropertyValue<TimeSpan>(cy1.d, null);
		if (primitivePropertyValue == null)
		{
			A_0.y6()[cy1.d] = A_1;
			A_0.y6()[cy1.c] = null;
			return;
		}
		A_0.y6()[cy1.c] = (A_1 - primitivePropertyValue.Value).TotalMilliseconds;
	}

	// Token: 0x060017AC RID: 6060 RVA: 0x000786B4 File Offset: 0x000768B4
	public override void aks(cte A_0)
	{
		bm6 bm = A_0 as bm6;
		if (bm == null || bm.a8().h.b == null)
		{
			return;
		}
		this.a = new d3g.a(bm, bm.a8().h.b.aa().Uid);
		eta service = bpo.GetService<eta>();
		if (service != null)
		{
			service.RegisterHandler<bjs>(this.a);
		}
	}

	// Token: 0x060017AD RID: 6061 RVA: 0x00078724 File Offset: 0x00076924
	public override void akt(cte A_0)
	{
		if (this.a != null)
		{
			eta service = bpo.GetService<eta>();
			if (service != null)
			{
				service.UnregisterHandler<bjs>(this.a);
			}
		}
	}

	// Token: 0x04000E0A RID: 3594
	private new d3g.a a;

	// Token: 0x02000346 RID: 838
	private new class a : GlobalEventHandler<bjs>
	{
		// Token: 0x060017AF RID: 6063 RVA: 0x0007875C File Offset: 0x0007695C
		public a(bm6 A_0, Guid A_1)
		{
			this.b = A_1;
			this.a = A_0;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x00078774 File Offset: 0x00076974
		public override void cr(bjs A_0)
		{
			amc amc = new bzv(this.a.y6()).g();
			if (amc == null)
			{
				return;
			}
			if (A_0.f() != null && A_0.f().d == this.b && A_0.h() != null && A_0.h().d == amc.aa().Uid)
			{
				this.a.y6()[cy1.c] = null;
				this.a.y6()[cy1.d] = null;
			}
		}

		// Token: 0x04000E0B RID: 3595
		private bm6 a;

		// Token: 0x04000E0C RID: 3596
		private Guid b;
	}
}

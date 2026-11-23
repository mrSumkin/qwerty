using System;
using System.Collections.Generic;
using Ouroboros.Playfield.References;

// Token: 0x02000477 RID: 1143
public sealed class chi : adt
{
	// Token: 0x06001D8D RID: 7565 RVA: 0x000A3AEC File Offset: 0x000A1CEC
	public chi(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001D8E RID: 7566 RVA: 0x000A3AF8 File Offset: 0x000A1CF8
	public override ej1 aci(TimeSpan A_0, double A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		bzv bzv = new bzv(this.Subject.y6());
		bzv.h();
		int num = bzv.f();
		Dictionary<Guid, blk> dictionary = bzv.a();
		if (num > 0)
		{
			amc amc = null;
			double num2 = double.MaxValue;
			bool flag = false;
			foreach (blk blk in dictionary.Values)
			{
				if (blk != null && blk.e() != null && blk.a().f() == cem.d && !blk.e().aa().Passive && (this.Subject.a8().h.b.aa().a(serviceOrThrow.aqu().ac(), blk.e().aa().FactionId) == global::h.a || this.Subject.a8().h.b.aa().FactionId == asp.e))
				{
					double num3 = aw1.b(blk.e().a8(), this.Subject.a8());
					if (amc == null || num2 > num3 || (!flag && blk.b()))
					{
						amc = blk.e();
						num2 = num3;
						flag = blk.b();
					}
				}
			}
			if (amc != null)
			{
				this.Subject.y6()[cy1.b] = new EntityAspectReference<amc, amc>(amc);
				return ej1.b;
			}
		}
		return ej1.c;
	}

	// Token: 0x06001D8F RID: 7567 RVA: 0x000A3CC0 File Offset: 0x000A1EC0
	public override float km(bool A_0)
	{
		return 0.5f;
	}

	// Token: 0x06001D90 RID: 7568 RVA: 0x000A3CC8 File Offset: 0x000A1EC8
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return this.Subject.a8().h.b.aa().IsInControl;
	}
}

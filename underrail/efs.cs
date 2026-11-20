using System;
using System.Collections.Generic;

// Token: 0x02000455 RID: 1109
public sealed class efs : pd
{
	// Token: 0x06001CEC RID: 7404 RVA: 0x000A0B64 File Offset: 0x0009ED64
	public efs(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001CED RID: 7405 RVA: 0x000A0B70 File Offset: 0x0009ED70
	public efs(string A_0, IEnumerable<c96> A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06001CEE RID: 7406 RVA: 0x000A0B80 File Offset: 0x0009ED80
	public override float km(bool A_0)
	{
		if (this.Subject == null)
		{
			return float.MinValue;
		}
		bzv bzv = new bzv(this.Subject.y6());
		amc amc = base.h();
		if (amc != null && amc.aa().FactionId != asp.e && amc.aa().SpecialStates.l)
		{
			this.Subject.y6()[ddq.bp] = amc.aa().FactionId;
			this.Subject.y6()[ddq.bq] = new Dictionary<string, h>(amc.aa().PersonalAttitudes);
			amc.aa().FactionId = asp.e;
			bzv.h();
		}
		int num = bzv.f();
		amc amc2 = bzv.g();
		base.h();
		if (num > 0 || amc2 != null)
		{
			return 1f;
		}
		return 0f;
	}

	// Token: 0x06001CEF RID: 7407 RVA: 0x000A0C74 File Offset: 0x0009EE74
	public override bool acj(TimeSpan A_0, double A_1)
	{
		return true;
	}

	// Token: 0x06001CF0 RID: 7408 RVA: 0x000A0C7C File Offset: 0x0009EE7C
	public override void ack()
	{
		base.ack();
		this.Subject.y6()[cy1.b] = null;
	}
}

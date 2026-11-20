using System;
using System.Collections.Generic;

// Token: 0x02000454 RID: 1108
public sealed class e8n : pd, cqc
{
	// Token: 0x06001CE7 RID: 7399 RVA: 0x000A0AD4 File Offset: 0x0009ECD4
	public e8n(string A_0, IEnumerable<c96> A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06001CE8 RID: 7400 RVA: 0x000A0AE0 File Offset: 0x0009ECE0
	public e8n(string A_0) : base(A_0)
	{
	}

	// Token: 0x06001CE9 RID: 7401 RVA: 0x000A0AEC File Offset: 0x0009ECEC
	public override float km(bool A_0)
	{
		return 1f;
	}

	// Token: 0x06001CEA RID: 7402 RVA: 0x000A0AF8 File Offset: 0x0009ECF8
	public override bool acj(TimeSpan A_0, double A_1)
	{
		efk efk = this.Subject.a8().h.b.aa();
		amc a_ = this.adh();
		return !efk.Dead && efk.IsInControl && cgh.a(a_, this.Subject);
	}

	// Token: 0x06001CEB RID: 7403 RVA: 0x000A0B4C File Offset: 0x0009ED4C
	public amc adh()
	{
		return new bzv(this.Subject.y6()).g();
	}
}

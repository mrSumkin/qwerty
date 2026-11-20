using System;
using System.Runtime.Serialization;

// Token: 0x020016D9 RID: 5849
[eiz("EXSA")]
[Serializable]
public sealed class dsb : cvd
{
	// Token: 0x06007F46 RID: 32582 RVA: 0x0035E290 File Offset: 0x0035C490
	private dsb(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007F47 RID: 32583 RVA: 0x0035E29C File Offset: 0x0035C49C
	public dsb()
	{
	}

	// Token: 0x06007F48 RID: 32584 RVA: 0x0035E2A8 File Offset: 0x0035C4A8
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.aig().f() != null && base.aig().f().Zone != null && base.aig().f().h.b != null && base.aig().f().h.b.aa() is e3q)
		{
			dz6.a(base.aig().f().h.b.aa(), 1000, true, 500, true, true);
		}
		return dc4.c;
	}
}

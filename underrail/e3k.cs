using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000606 RID: 1542
[e7l(SpellTargetType.RepairableVehicle)]
public sealed class e3k : emk
{
	// Token: 0x0600282C RID: 10284 RVA: 0x000E7CE8 File Offset: 0x000E5EE8
	public e3k(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600282D RID: 10285 RVA: 0x000E7CF4 File Offset: 0x000E5EF4
	public override bool f8(b0b A_0)
	{
		wv wv = A_0.GetAspect<bim>() as wv;
		return wv != null && wv.b();
	}
}

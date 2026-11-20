using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000601 RID: 1537
[e7l(SpellTargetType.SkerderGraveMechanism)]
public sealed class dyr : lu
{
	// Token: 0x06002820 RID: 10272 RVA: 0x000E7B80 File Offset: 0x000E5D80
	public override bcw c5()
	{
		return bcw.b;
	}

	// Token: 0x06002821 RID: 10273 RVA: 0x000E7B84 File Offset: 0x000E5D84
	public dyr(av A_0)
	{
	}

	// Token: 0x06002822 RID: 10274 RVA: 0x000E7B90 File Offset: 0x000E5D90
	public override bool cg(object A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		b0b b0b = A_0 as b0b;
		if (b0b != null)
		{
			bli bli = b0b.GetAspect<bim>() as bli;
			return bli != null && !bli.i();
		}
		return false;
	}
}

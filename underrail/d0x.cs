using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000614 RID: 1556
[e7l(SpellTargetType.PureUsableObject)]
public sealed class d0x : emk
{
	// Token: 0x0600284C RID: 10316 RVA: 0x000E822C File Offset: 0x000E642C
	public d0x(av A_0) : base(A_0)
	{
	}

	// Token: 0x0600284D RID: 10317 RVA: 0x000E8238 File Offset: 0x000E6438
	public override bool f8(b0b A_0)
	{
		bim aspect = A_0.GetAspect<bim>();
		return aspect != null && aspect.GetType() == typeof(bim);
	}
}

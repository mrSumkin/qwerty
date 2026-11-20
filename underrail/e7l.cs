using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x020006CC RID: 1740
[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class e7l : Attribute
{
	// Token: 0x06002CE3 RID: 11491 RVA: 0x00100700 File Offset: 0x000FE900
	public SpellTargetType a()
	{
		return this.a;
	}

	// Token: 0x06002CE4 RID: 11492 RVA: 0x00100708 File Offset: 0x000FE908
	public e7l(SpellTargetType A_0)
	{
		this.a = A_0;
	}

	// Token: 0x0400198C RID: 6540
	private SpellTargetType a;
}

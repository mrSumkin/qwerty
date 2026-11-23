using System;
using TimelapseVertigo.Rules.Capabilities;

// Token: 0x02000611 RID: 1553
[e7l(SpellTargetType.LoadBearingColumn)]
public sealed class cb8 : lu
{
	// Token: 0x06002844 RID: 10308 RVA: 0x000E80A0 File Offset: 0x000E62A0
	public override bcw c5()
	{
		return bcw.b;
	}

	// Token: 0x06002845 RID: 10309 RVA: 0x000E80A4 File Offset: 0x000E62A4
	public cb8(av A_0)
	{
	}

	// Token: 0x06002846 RID: 10310 RVA: 0x000E80AC File Offset: 0x000E62AC
	public override bool cg(object A_0)
	{
		if (A_0 == null)
		{
			return false;
		}
		b0b b0b = A_0 as b0b;
		if (b0b != null && b0b.Layer == aju.x)
		{
			a3f aspect = b0b.GetAspect<a3f>();
			if (aspect != null && aspect.a().GetPrimitivePropertyValue<bool>("isLoadBearingColumn", new bool?(false)).Value && !aspect.a().GetPrimitivePropertyValue<bool>("rigged", new bool?(false)).Value)
			{
				return true;
			}
		}
		return false;
	}
}

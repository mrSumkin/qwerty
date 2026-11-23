using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x0200191A RID: 6426
[eiz("NEII")]
[Serializable]
public class d48 : coh, IItemInstance<dj3>, ISerializable
{
	// Token: 0x06008885 RID: 34949 RVA: 0x00387D48 File Offset: 0x00385F48
	protected d48(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008886 RID: 34950 RVA: 0x00387D54 File Offset: 0x00385F54
	public dj3 fu()
	{
		return base.Definition as dj3;
	}

	// Token: 0x06008887 RID: 34951 RVA: 0x00387D64 File Offset: 0x00385F64
	public d48(bit A_0) : base(A_0)
	{
	}

	// Token: 0x06008888 RID: 34952 RVA: 0x00387D70 File Offset: 0x00385F70
	public override coh fy()
	{
		d48 d = new d48(base.DefinitionProvider.wm());
		this.fz(d);
		return d;
	}

	// Token: 0x06008889 RID: 34953 RVA: 0x00387D98 File Offset: 0x00385F98
	public override bool anx(efk A_0)
	{
		if (base.Definition != null && base.Definition.v)
		{
			return A_0 != null && A_0.Gear.a(this);
		}
		return A_0 != null && A_0.Bag.h(this) && ((this.fu() != null && this.fu().m()) || !A_0.IsInCombat);
	}
}

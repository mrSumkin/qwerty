using System;
using System.Runtime.Serialization;

// Token: 0x0200160B RID: 5643
[eiz("XS9")]
[Serializable]
public sealed class epn : a6k, ISerializable
{
	// Token: 0x06007C21 RID: 31777 RVA: 0x003420E4 File Offset: 0x003402E4
	private epn(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06007C22 RID: 31778 RVA: 0x003420F0 File Offset: 0x003402F0
	public epn()
	{
	}

	// Token: 0x06007C23 RID: 31779 RVA: 0x003420FC File Offset: 0x003402FC
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		c5x c5x = base.vg().h() as c5x;
		if (c5x != null && c5x.h.b != null && c5x.Zone != null)
		{
			c5x.c().a("MirrorImage");
			alf alf = new alf(d97.g * d0u.b);
			alf.Stacks = d97.a(base.vg().e());
			c5x.h.b.aa().StatusEffects.a(alf, false, false, false);
			return dc4.c;
		}
		return dc4.e;
	}
}

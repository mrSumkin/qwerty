using System;
using System.Runtime.Serialization;

// Token: 0x020015E1 RID: 5601
[eiz("ATDA")]
[Serializable]
public sealed class bn0 : a6k, ISerializable
{
	// Token: 0x06007B7F RID: 31615 RVA: 0x0033A604 File Offset: 0x00338804
	private bn0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (wm)A_0.GetValue("ATDA:S", typeof(wm));
	}

	// Token: 0x06007B80 RID: 31616 RVA: 0x0033A630 File Offset: 0x00338830
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("ATDA:S", this.a);
	}

	// Token: 0x06007B81 RID: 31617 RVA: 0x0033A650 File Offset: 0x00338850
	public bn0(wm A_0 = wm.a)
	{
		this.a = A_0;
	}

	// Token: 0x06007B82 RID: 31618 RVA: 0x0033A664 File Offset: 0x00338864
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (base.vg() != null && base.vg().q() != null && base.vg().q().h.b != null && base.vg().q().Zone != null && base.vg().q().h.b.aa().Feats.Contains<dyi>())
		{
			u6.a(base.vg().q().h.b);
			u6.a(base.vg().q().h.b, this.a == wm.b);
		}
		return dc4.c;
	}

	// Token: 0x0400311F RID: 12575
	public new wm a;
}

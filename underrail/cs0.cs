using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Items;

// Token: 0x02000712 RID: 1810
[eiz("PIG")]
[Serializable]
public sealed class cs0 : y8
{
	// Token: 0x06002EF4 RID: 12020 RVA: 0x00109440 File Offset: 0x00107640
	public cs0(string A_0)
	{
		this.a = A_0;
	}

	// Token: 0x06002EF5 RID: 12021 RVA: 0x00109450 File Offset: 0x00107650
	private cs0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = A_0.GetString("PIG:PIN");
	}

	// Token: 0x06002EF6 RID: 12022 RVA: 0x0010946C File Offset: 0x0010766C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PIG:PIN", this.a);
	}

	// Token: 0x06002EF7 RID: 12023 RVA: 0x00109488 File Offset: 0x00107688
	protected override List<coh> a2()
	{
		dj3 dj = new dj3();
		dj.g("GenItemPlaceholder: " + this.a);
		dj.k(dj.az());
		dj.f(5);
		dj.f("Misc.1");
		d48 item = new d48(new IndependentItemDefinitionProvider<dj3>(dj));
		return new List<coh>
		{
			item
		};
	}

	// Token: 0x06002EF8 RID: 12024 RVA: 0x001094E8 File Offset: 0x001076E8
	public override aw4 a1()
	{
		return new cs0(this.a);
	}

	// Token: 0x04001A14 RID: 6676
	private new string a;
}

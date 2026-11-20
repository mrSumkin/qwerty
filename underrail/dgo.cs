using System;
using System.Runtime.Serialization;

// Token: 0x020006D4 RID: 1748
[eiz("APG")]
[Serializable]
public sealed class dgo : drj, ISerializable
{
	// Token: 0x06002CFB RID: 11515 RVA: 0x00100AC8 File Offset: 0x000FECC8
	private dgo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002CFC RID: 11516 RVA: 0x00100AD4 File Offset: 0x000FECD4
	public dgo()
	{
	}

	// Token: 0x06002CFD RID: 11517 RVA: 0x00100AE0 File Offset: 0x000FECE0
	public override bcx x4()
	{
		bcx bcx = new bcx();
		bcx.a(new b5o("xpbl_AegisPatroller"));
		agt value = new agt(ez2.CreateDefinitonProvider<eqg>(c8x.f));
		agt value2 = new agt(ez2.CreateDefinitonProvider<esd>(c8x.s));
		agt value3 = new agt(ez2.CreateDefinitonProvider<eu0>(c8x.ah));
		bcx.o()["engine"] = value;
		bcx.o()["battery"] = value2;
		bcx.o()["suspension"] = value3;
		bcx.k();
		bcx.b((double)bcx.v());
		bcx.a(double.MaxValue);
		bcx.k();
		return bcx;
	}
}

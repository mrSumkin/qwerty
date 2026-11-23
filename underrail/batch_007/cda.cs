using System;
using System.Runtime.Serialization;

// Token: 0x020006D6 RID: 1750
[eiz("PCG")]
[Serializable]
public sealed class cda : drj, ISerializable
{
	// Token: 0x06002D02 RID: 11522 RVA: 0x00100BA4 File Offset: 0x000FEDA4
	private cda(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06002D03 RID: 11523 RVA: 0x00100BB0 File Offset: 0x000FEDB0
	public cda()
	{
	}

	// Token: 0x06002D04 RID: 11524 RVA: 0x00100BBC File Offset: 0x000FEDBC
	public override bcx x4()
	{
		bcx bcx = new bcx();
		bcx.a(new b5o("xpbl_ProtectorateCruiser"));
		agt value = new agt(ez2.CreateDefinitonProvider<eqg>(c8x.k));
		agt value2 = new agt(ez2.CreateDefinitonProvider<esd>(c8x.t));
		agt value3 = new agt(ez2.CreateDefinitonProvider<eu0>(c8x.ai));
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

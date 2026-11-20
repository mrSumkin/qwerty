using System;
using System.Runtime.Serialization;

// Token: 0x02001A46 RID: 6726
[eiz("FE1")]
[Serializable]
public sealed class cz9 : d3e, ISerializable
{
	// Token: 0x060091F4 RID: 37364 RVA: 0x0039E24C File Offset: 0x0039C44C
	private cz9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060091F5 RID: 37365 RVA: 0x0039E25C File Offset: 0x0039C45C
	protected override void @in(ll A_0)
	{
		A_0.a().SpecialStates.h = true;
		A_0.a().Defense.a(0);
		A_0.a().Defense.c(0);
	}

	// Token: 0x060091F6 RID: 37366 RVA: 0x0039E29C File Offset: 0x0039C49C
	public cz9()
	{
		base.Priority = int.MaxValue;
	}

	// Token: 0x060091F7 RID: 37367 RVA: 0x0039E2B0 File Offset: 0x0039C4B0
	public override d3e b3()
	{
		cz9 cz = new cz9();
		this.xx(cz);
		return cz;
	}
}

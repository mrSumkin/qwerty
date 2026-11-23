using System;
using System.Runtime.Serialization;

// Token: 0x02001A49 RID: 6729
[eiz("DE1")]
[Serializable]
public sealed class ar9 : d3e, ISerializable
{
	// Token: 0x0600920A RID: 37386 RVA: 0x0039E6B0 File Offset: 0x0039C8B0
	private ar9(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600920B RID: 37387 RVA: 0x0039E6BC File Offset: 0x0039C8BC
	public ar9()
	{
	}

	// Token: 0x0600920C RID: 37388 RVA: 0x0039E6C4 File Offset: 0x0039C8C4
	public override string b2()
	{
		return qv.b("StaticEffects/nightVision");
	}

	// Token: 0x0600920D RID: 37389 RVA: 0x0039E6D4 File Offset: 0x0039C8D4
	public override d3e b3()
	{
		ar9 ar = new ar9();
		this.xx(ar);
		return ar;
	}

	// Token: 0x0600920E RID: 37390 RVA: 0x0039E6F0 File Offset: 0x0039C8F0
	protected override void @in(ll A_0)
	{
		A_0.a().Darkvision = true;
	}
}

using System;
using System.Runtime.Serialization;

// Token: 0x02001A27 RID: 6695
[eiz("D05")]
[Serializable]
public sealed class eyz : d3e, ISerializable
{
	// Token: 0x060090EC RID: 37100 RVA: 0x0039BBD4 File Offset: 0x00399DD4
	private eyz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060090ED RID: 37101 RVA: 0x0039BBE0 File Offset: 0x00399DE0
	public eyz()
	{
	}

	// Token: 0x060090EE RID: 37102 RVA: 0x0039BBEC File Offset: 0x00399DEC
	protected override void @in(ll A_0)
	{
		if (euf.d(A_0.a().Offense.u().TypedDefinition.ak()))
		{
			nw nw = A_0.a().Defense;
			nw.c(nw.v() + (int)((double)A_0.a().Skills.Get<jk>().g() * (bw8.a + (double)A_0.a().GetSpecializationValue<cni>(true) * cni.a)));
		}
	}

	// Token: 0x060090EF RID: 37103 RVA: 0x0039BC68 File Offset: 0x00399E68
	public override d3e b3()
	{
		eyz eyz = new eyz();
		this.xx(eyz);
		return eyz;
	}
}

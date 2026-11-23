using System;
using System.Runtime.Serialization;

// Token: 0x0200077F RID: 1919
[eiz("CCStratfordRF")]
[Serializable]
public sealed class aei : egv, ISerializable
{
	// Token: 0x06003095 RID: 12437 RVA: 0x0012BBA8 File Offset: 0x00129DA8
	private aei(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003096 RID: 12438 RVA: 0x0012BBB0 File Offset: 0x00129DB0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06003097 RID: 12439 RVA: 0x0012BBB4 File Offset: 0x00129DB4
	public aei()
	{
	}

	// Token: 0x06003098 RID: 12440 RVA: 0x0012BBBC File Offset: 0x00129DBC
	public float a0(eg A_0, efk A_1)
	{
		if (A_0 == null || A_0.ap9() == null || bpo.GetServiceOrThrow<cnk>().aqu() == null)
		{
			return bhm.a;
		}
		if (am9.c())
		{
			return 2.2f;
		}
		return 2.7f;
	}
}

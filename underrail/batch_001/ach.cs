using System;
using System.Runtime.Serialization;

// Token: 0x02000783 RID: 1923
[eiz("CCHarlanRF")]
[Serializable]
public sealed class ach : egv, ISerializable
{
	// Token: 0x060030A5 RID: 12453 RVA: 0x0012BDD0 File Offset: 0x00129FD0
	private ach(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x060030A6 RID: 12454 RVA: 0x0012BDD8 File Offset: 0x00129FD8
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x060030A7 RID: 12455 RVA: 0x0012BDDC File Offset: 0x00129FDC
	public ach()
	{
	}

	// Token: 0x060030A8 RID: 12456 RVA: 0x0012BDE4 File Offset: 0x00129FE4
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

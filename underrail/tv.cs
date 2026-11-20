using System;
using System.Runtime.Serialization;

// Token: 0x02000780 RID: 1920
[eiz("CCOlaRF")]
[Serializable]
public sealed class tv : egv, ISerializable
{
	// Token: 0x06003099 RID: 12441 RVA: 0x0012BBFC File Offset: 0x00129DFC
	private tv(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x0600309A RID: 12442 RVA: 0x0012BC04 File Offset: 0x00129E04
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x0600309B RID: 12443 RVA: 0x0012BC08 File Offset: 0x00129E08
	public tv()
	{
	}

	// Token: 0x0600309C RID: 12444 RVA: 0x0012BC10 File Offset: 0x00129E10
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

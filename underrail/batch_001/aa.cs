using System;
using System.Runtime.Serialization;

// Token: 0x02000A3D RID: 2621
[eiz("XPBLE3L")]
[Serializable]
public sealed class aa : bdw, ISerializable
{
	// Token: 0x06003E27 RID: 15911 RVA: 0x001766AC File Offset: 0x001748AC
	private aa(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003E28 RID: 15912 RVA: 0x001766B4 File Offset: 0x001748B4
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003E29 RID: 15913 RVA: 0x001766B8 File Offset: 0x001748B8
	public aa()
	{
	}

	// Token: 0x06003E2A RID: 15914 RVA: 0x001766C4 File Offset: 0x001748C4
	public void av(c1a A_0, cyt A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			bv9 bv = serviceOrThrow.aqu().ac() as bv9;
			if (bv != null)
			{
				bv.a(asp.fr, asp.a, h.a, null, true, false, false);
				bv.a(asp.fv, asp.a, h.a, null, true, false, false);
				bv.a(asp.ft, asp.a, h.a, null, true, false, false);
				bv.a(asp.fr, asp.f8, h.a, null, true, false, false);
				bv.a(asp.fr, asp.f6, h.a, null, true, false, false);
				bv.a(asp.fr, asp.f5, h.a, null, true, false, false);
			}
		}
	}
}

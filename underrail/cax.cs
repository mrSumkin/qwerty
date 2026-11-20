using System;
using System.IO;
using System.Runtime.Serialization;

// Token: 0x020009D8 RID: 2520
[eiz("SGSAMT0")]
[Serializable]
public sealed class cax : bdw, ISerializable
{
	// Token: 0x06003C5B RID: 15451 RVA: 0x00165D4C File Offset: 0x00163F4C
	private cax(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06003C5C RID: 15452 RVA: 0x00165D54 File Offset: 0x00163F54
	public void GetObjectData(SerializationInfo info, StreamingContext context)
	{
	}

	// Token: 0x06003C5D RID: 15453 RVA: 0x00165D58 File Offset: 0x00163F58
	public cax()
	{
	}

	// Token: 0x06003C5E RID: 15454 RVA: 0x00165D64 File Offset: 0x00163F64
	public void av(c1a A_0, cyt A_1)
	{
		if (A_0 != null)
		{
			aud aud = A_0.n("LU-SouthGateStation");
			if (aud != null)
			{
				doq a_ = doq.a(Path.Combine(d5x.q(), "lu-southgatestation_l2") + ".uzl");
				aud.Zone.a(a_, 1, null);
				cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
				aud.Divinations.a("train").b(serviceOrThrow.aqu().v().c());
			}
		}
	}
}

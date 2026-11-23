using System;
using System.Runtime.Serialization;

// Token: 0x020007B5 RID: 1973
[eiz("DCCMC")]
[Serializable]
public sealed class ahz : esc, ISerializable
{
	// Token: 0x0600316E RID: 12654 RVA: 0x0012F298 File Offset: 0x0012D498
	private ahz(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600316F RID: 12655 RVA: 0x0012F2A4 File Offset: 0x0012D4A4
	public ahz()
	{
	}

	// Token: 0x06003170 RID: 12656 RVA: 0x0012F2B0 File Offset: 0x0012D4B0
	public override int d5(bq8 A_0, bq8 A_1)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null)
		{
			serviceOrThrow.aqu().r()["dc_mutagenCompound"] = null;
			serviceOrThrow.aqu().r()["dc_mutagenCompoundText"] = "";
		}
		return 0;
	}
}

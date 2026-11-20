using System;
using System.Runtime.Serialization;

// Token: 0x02000F5D RID: 3933
[eiz("IGSOC")]
[Serializable]
public sealed class cuy : dth, ISerializable
{
	// Token: 0x06004FB6 RID: 20406 RVA: 0x0023D794 File Offset: 0x0023B994
	private cuy(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004FB7 RID: 20407 RVA: 0x0023D79C File Offset: 0x0023B99C
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004FB8 RID: 20408 RVA: 0x0023D7A0 File Offset: 0x0023B9A0
	public cuy()
	{
	}

	// Token: 0x06004FB9 RID: 20409 RVA: 0x0023D7A8 File Offset: 0x0023B9A8
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_allowedPassage", new bool?(false)).Value && !serviceOrThrow.aqu().r().GetPrimitivePropertyValue<bool>("loc_tch_descended", new bool?(false)).Value;
	}

	// Token: 0x06004FBA RID: 20410 RVA: 0x0023D81C File Offset: 0x0023BA1C
	public string ji()
	{
		return "Tch_InstituteGateShouldOpenCondition";
	}
}

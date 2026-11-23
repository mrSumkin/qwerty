using System;
using System.Runtime.Serialization;

// Token: 0x02000F5F RID: 3935
[eiz("PIWCAUAC")]
[Serializable]
public sealed class cb2 : dth, ISerializable
{
	// Token: 0x06004FC0 RID: 20416 RVA: 0x0023D8C8 File Offset: 0x0023BAC8
	private cb2(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004FC1 RID: 20417 RVA: 0x0023D8D0 File Offset: 0x0023BAD0
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004FC2 RID: 20418 RVA: 0x0023D8D4 File Offset: 0x0023BAD4
	public cb2()
	{
	}

	// Token: 0x06004FC3 RID: 20419 RVA: 0x0023D8DC File Offset: 0x0023BADC
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		return serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Gear.l().Item != null && serviceOrThrow.aqu().v().Gear.l().Item.fu().e() == "prbio";
	}

	// Token: 0x06004FC4 RID: 20420 RVA: 0x0023D960 File Offset: 0x0023BB60
	public string ji()
	{
		return "Player is wearing CAU armor";
	}
}

using System;
using System.Runtime.Serialization;

// Token: 0x02000F5C RID: 3932
[eiz("PINWGAU")]
[Serializable]
public sealed class e7c : dth, ISerializable
{
	// Token: 0x06004FB1 RID: 20401 RVA: 0x0023D6C4 File Offset: 0x0023B8C4
	private e7c(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004FB2 RID: 20402 RVA: 0x0023D6CC File Offset: 0x0023B8CC
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004FB3 RID: 20403 RVA: 0x0023D6D0 File Offset: 0x0023B8D0
	public e7c()
	{
	}

	// Token: 0x06004FB4 RID: 20404 RVA: 0x0023D6DC File Offset: 0x0023B8DC
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Gear.l().Item != null)
		{
			string a = serviceOrThrow.aqu().v().Gear.l().Item.fu().e();
			if (!serviceOrThrow.aqu().v().SpecialStates.g && (a == "xpbl_ras" || a == "xpbl_rao"))
			{
				return false;
			}
		}
		return true;
	}

	// Token: 0x06004FB5 RID: 20405 RVA: 0x0023D78C File Offset: 0x0023B98C
	public string ji()
	{
		return "Player is not wearing Gray Army uniform.";
	}
}

using System;
using System.Runtime.Serialization;

// Token: 0x02000F60 RID: 3936
[eiz("PIWTAC")]
[Serializable]
public sealed class enj : dth, ISerializable
{
	// Token: 0x06004FC5 RID: 20421 RVA: 0x0023D968 File Offset: 0x0023BB68
	private enj(SerializationInfo A_0, StreamingContext A_1)
	{
	}

	// Token: 0x06004FC6 RID: 20422 RVA: 0x0023D970 File Offset: 0x0023BB70
	public void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
	}

	// Token: 0x06004FC7 RID: 20423 RVA: 0x0023D974 File Offset: 0x0023BB74
	public enj()
	{
	}

	// Token: 0x06004FC8 RID: 20424 RVA: 0x0023D97C File Offset: 0x0023BB7C
	public bool jh(object A_0)
	{
		cnk serviceOrThrow = bpo.GetServiceOrThrow<cnk>();
		if (serviceOrThrow.aqu() != null && serviceOrThrow.aqu().v() != null && serviceOrThrow.aqu().v().Gear.l().Item != null)
		{
			string a = serviceOrThrow.aqu().v().Gear.l().Item.fu().e();
			if (a == "tchnob" || a == "tch" || a == "tchsol" || a == "tchvathos")
			{
				return true;
			}
		}
		return false;
	}

	// Token: 0x06004FC9 RID: 20425 RVA: 0x0023DA34 File Offset: 0x0023BC34
	public string ji()
	{
		return "Игрок носит броню чортистов.";
	}
}

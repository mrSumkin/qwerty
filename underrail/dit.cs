using System;
using System.Runtime.Serialization;

// Token: 0x020019A4 RID: 6564
[dn2("destroyDestructableRocks")]
[eiz("AEX5")]
[Serializable]
public sealed class dit : buu, ISerializable
{
	// Token: 0x06008C24 RID: 35876 RVA: 0x00390C30 File Offset: 0x0038EE30
	private dit(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06008C25 RID: 35877 RVA: 0x00390C3C File Offset: 0x0038EE3C
	public override string e1(edm A_0)
	{
		return "Разрушает каменные завалы.";
	}

	// Token: 0x06008C26 RID: 35878 RVA: 0x00390C44 File Offset: 0x0038EE44
	public dit()
	{
	}
}

using System;
using System.Runtime.Serialization;

// Token: 0x02001E1A RID: 7706
[eiz("WBA1")]
[Serializable]
public sealed class ac : to, ISerializable
{
	// Token: 0x0600AAA5 RID: 43685 RVA: 0x003F42EC File Offset: 0x003F24EC
	private ac(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AAA6 RID: 43686 RVA: 0x003F42F8 File Offset: 0x003F24F8
	public ac() : base("Wisdom")
	{
	}

	// Token: 0x0600AAA7 RID: 43687 RVA: 0x003F4308 File Offset: 0x003F2508
	public ac(int A_0) : base("Wisdom", A_0)
	{
	}

	// Token: 0x0600AAA8 RID: 43688 RVA: 0x003F4318 File Offset: 0x003F2518
	public ac(bn2 A_0) : base(A_0, "Wisdom")
	{
	}

	// Token: 0x0600AAA9 RID: 43689 RVA: 0x003F4328 File Offset: 0x003F2528
	public ac(bn2 A_0, int A_1) : base(A_0, "Wisdom", A_1)
	{
	}

	// Token: 0x04003FC9 RID: 16329
	private new const string a = "Wisdom";
}

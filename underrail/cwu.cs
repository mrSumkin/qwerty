using System;
using System.Runtime.Serialization;

// Token: 0x02001E15 RID: 7701
[eiz("DBA")]
[Serializable]
public sealed class cwu : to, ISerializable
{
	// Token: 0x0600AA88 RID: 43656 RVA: 0x003F40C0 File Offset: 0x003F22C0
	private cwu(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(cwu);
		}
	}

	// Token: 0x0600AA89 RID: 43657 RVA: 0x003F40EC File Offset: 0x003F22EC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA8A RID: 43658 RVA: 0x003F40F8 File Offset: 0x003F22F8
	public cwu() : base("Dexterity")
	{
	}

	// Token: 0x0600AA8B RID: 43659 RVA: 0x003F4108 File Offset: 0x003F2308
	public cwu(int A_0) : base("Dexterity", A_0)
	{
	}

	// Token: 0x0600AA8C RID: 43660 RVA: 0x003F4118 File Offset: 0x003F2318
	public cwu(bn2 A_0) : base(A_0, "Dexterity")
	{
	}

	// Token: 0x0600AA8D RID: 43661 RVA: 0x003F4128 File Offset: 0x003F2328
	public cwu(bn2 A_0, int A_1) : base(A_0, "Dexterity", A_1)
	{
	}

	// Token: 0x04003FC4 RID: 16324
	private const string BaseAbilityName = "Dexterity";
}

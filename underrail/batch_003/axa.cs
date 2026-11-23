using System;
using System.Runtime.Serialization;

// Token: 0x02001E14 RID: 7700
[eiz("CBA")]
[Serializable]
public sealed class axa : to, ISerializable
{
	// Token: 0x0600AA82 RID: 43650 RVA: 0x003F4068 File Offset: 0x003F2268
	private axa(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600AA83 RID: 43651 RVA: 0x003F4074 File Offset: 0x003F2274
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA84 RID: 43652 RVA: 0x003F4080 File Offset: 0x003F2280
	public axa() : base("Constitution")
	{
	}

	// Token: 0x0600AA85 RID: 43653 RVA: 0x003F4090 File Offset: 0x003F2290
	public axa(int A_0) : base("Constitution", A_0)
	{
	}

	// Token: 0x0600AA86 RID: 43654 RVA: 0x003F40A0 File Offset: 0x003F22A0
	public axa(bn2 A_0) : base(A_0, "Constitution")
	{
	}

	// Token: 0x0600AA87 RID: 43655 RVA: 0x003F40B0 File Offset: 0x003F22B0
	public axa(bn2 A_0, int A_1) : base(A_0, "Constitution", A_1)
	{
	}

	// Token: 0x04003FC3 RID: 16323
	private const string BaseAbilityName = "Constitution";
}

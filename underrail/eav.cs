using System;
using System.Runtime.Serialization;

// Token: 0x02001E17 RID: 7703
[eiz("PBA")]
[Serializable]
public sealed class eav : to, ISerializable
{
	// Token: 0x0600AA94 RID: 43668 RVA: 0x003F41B0 File Offset: 0x003F23B0
	private eav(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(eav);
		}
	}

	// Token: 0x0600AA95 RID: 43669 RVA: 0x003F41DC File Offset: 0x003F23DC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA96 RID: 43670 RVA: 0x003F41E8 File Offset: 0x003F23E8
	public eav() : base("Perception")
	{
	}

	// Token: 0x0600AA97 RID: 43671 RVA: 0x003F41F8 File Offset: 0x003F23F8
	public eav(int A_0) : base("Perception", A_0)
	{
	}

	// Token: 0x0600AA98 RID: 43672 RVA: 0x003F4208 File Offset: 0x003F2408
	public eav(bn2 A_0) : base(A_0, "Perception")
	{
	}

	// Token: 0x0600AA99 RID: 43673 RVA: 0x003F4218 File Offset: 0x003F2418
	public eav(bn2 A_0, int A_1) : base(A_0, "Perception", A_1)
	{
	}

	// Token: 0x04003FC6 RID: 16326
	private const string BaseAbilityName = "Perception";
}

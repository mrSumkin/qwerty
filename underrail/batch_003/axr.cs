using System;
using System.Runtime.Serialization;

// Token: 0x02001E19 RID: 7705
[eiz("WBA")]
[Serializable]
public sealed class axr : to, ISerializable
{
	// Token: 0x0600AA9F RID: 43679 RVA: 0x003F4274 File Offset: 0x003F2474
	private axr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(axr);
		}
	}

	// Token: 0x0600AAA0 RID: 43680 RVA: 0x003F42A0 File Offset: 0x003F24A0
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AAA1 RID: 43681 RVA: 0x003F42AC File Offset: 0x003F24AC
	public axr() : base("Will")
	{
	}

	// Token: 0x0600AAA2 RID: 43682 RVA: 0x003F42BC File Offset: 0x003F24BC
	public axr(int A_0) : base("Will", A_0)
	{
	}

	// Token: 0x0600AAA3 RID: 43683 RVA: 0x003F42CC File Offset: 0x003F24CC
	public axr(bn2 A_0) : base(A_0, "Will")
	{
	}

	// Token: 0x0600AAA4 RID: 43684 RVA: 0x003F42DC File Offset: 0x003F24DC
	public axr(bn2 A_0, int A_1) : base(A_0, "Will", A_1)
	{
	}

	// Token: 0x04003FC8 RID: 16328
	private const string BaseAbilityName = "Will";
}

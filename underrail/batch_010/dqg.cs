using System;
using System.Runtime.Serialization;

// Token: 0x02001E12 RID: 7698
[eiz("ABA")]
[Serializable]
public sealed class dqg : to, ISerializable
{
	// Token: 0x0600AA6E RID: 43630 RVA: 0x003F3D90 File Offset: 0x003F1F90
	private dqg(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() == 0)
		{
			base.GetType() == typeof(dqg);
		}
	}

	// Token: 0x0600AA6F RID: 43631 RVA: 0x003F3DBC File Offset: 0x003F1FBC
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600AA70 RID: 43632 RVA: 0x003F3DC8 File Offset: 0x003F1FC8
	public dqg() : base("Agility")
	{
	}

	// Token: 0x0600AA71 RID: 43633 RVA: 0x003F3DD8 File Offset: 0x003F1FD8
	public dqg(int A_0) : base("Agility", A_0)
	{
	}

	// Token: 0x0600AA72 RID: 43634 RVA: 0x003F3DE8 File Offset: 0x003F1FE8
	public dqg(bn2 A_0) : base(A_0, "Agility")
	{
	}

	// Token: 0x0600AA73 RID: 43635 RVA: 0x003F3DF8 File Offset: 0x003F1FF8
	public dqg(bn2 A_0, int A_1) : base(A_0, "Agility", A_1)
	{
	}

	// Token: 0x04003FC1 RID: 16321
	private const string BaseAbilityName = "Agility";
}

using System;
using System.Runtime.Serialization;

// Token: 0x02000C86 RID: 3206
[eiz("SICBDE")]
[Serializable]
public sealed class gl : cd2
{
	// Token: 0x06004892 RID: 18578 RVA: 0x001DA604 File Offset: 0x001D8804
	private gl(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06004893 RID: 18579 RVA: 0x001DA610 File Offset: 0x001D8810
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x06004894 RID: 18580 RVA: 0x001DA61C File Offset: 0x001D881C
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x06004895 RID: 18581 RVA: 0x001DA62C File Offset: 0x001D882C
	public override TimeSpan gf()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004896 RID: 18582 RVA: 0x001DA63C File Offset: 0x001D883C
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004897 RID: 18583 RVA: 0x001DA64C File Offset: 0x001D884C
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004898 RID: 18584 RVA: 0x001DA65C File Offset: 0x001D885C
	public gl() : base(gl.a)
	{
	}

	// Token: 0x06004899 RID: 18585 RVA: 0x001DA66C File Offset: 0x001D886C
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x0600489A RID: 18586 RVA: 0x001DA680 File Offset: 0x001D8880
	protected override void gg(cyt A_0)
	{
		A_0.r()["loc_xpbl_d6_canSleep"] = true;
	}

	// Token: 0x04001CBC RID: 7356
	public new static readonly string a = "sleepingInCampBed";
}

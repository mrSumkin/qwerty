using System;
using System.Runtime.Serialization;

// Token: 0x02000C79 RID: 3193
[eiz("EAAOPC")]
[Serializable]
public sealed class eww : cd2
{
	// Token: 0x0600480D RID: 18445 RVA: 0x001D928C File Offset: 0x001D748C
	private eww(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600480E RID: 18446 RVA: 0x001D9298 File Offset: 0x001D7498
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
	}

	// Token: 0x0600480F RID: 18447 RVA: 0x001D92A4 File Offset: 0x001D74A4
	public override TimeSpan ge()
	{
		return TimeSpan.FromMinutes(30.0);
	}

	// Token: 0x06004810 RID: 18448 RVA: 0x001D92B4 File Offset: 0x001D74B4
	public override TimeSpan gf()
	{
		return TimeSpan.FromSeconds(0.0);
	}

	// Token: 0x06004811 RID: 18449 RVA: 0x001D92C4 File Offset: 0x001D74C4
	public override TimeSpan ew()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004812 RID: 18450 RVA: 0x001D92D4 File Offset: 0x001D74D4
	public override TimeSpan ex()
	{
		return TimeSpan.FromMinutes(0.0);
	}

	// Token: 0x06004813 RID: 18451 RVA: 0x001D92E4 File Offset: 0x001D74E4
	public eww() : base(eww.a)
	{
	}

	// Token: 0x06004814 RID: 18452 RVA: 0x001D92F4 File Offset: 0x001D74F4
	protected override bool ez(cyt A_0)
	{
		return base.ez(A_0);
	}

	// Token: 0x06004815 RID: 18453 RVA: 0x001D9308 File Offset: 0x001D7508
	protected override void gg(cyt A_0)
	{
		new bgm().ym(null, null, null);
	}

	// Token: 0x04001CAB RID: 7339
	public new static readonly string a = "endAegisAttackOnPortCeto";
}

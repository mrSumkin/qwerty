using System;
using System.Runtime.Serialization;

// Token: 0x02001A75 RID: 6773
[eiz("DTSE")]
[Serializable]
public sealed class apk : els, ISerializable
{
	// Token: 0x06009315 RID: 37653 RVA: 0x003A1250 File Offset: 0x0039F450
	private apk(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = (A_0.GetValue("DTSE:D", typeof(a3s)) as a3s);
	}

	// Token: 0x06009316 RID: 37654 RVA: 0x003A127C File Offset: 0x0039F47C
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("DTSE:D", this.b);
	}

	// Token: 0x06009317 RID: 37655 RVA: 0x003A129C File Offset: 0x0039F49C
	public apk(a3s A_0) : base(apk.a, "Лазерное наведение на цель", ci8.c)
	{
		this.b = A_0;
		base.Duration = 2 * d0u.b;
		base.Icon = "Status.131";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "LaserDesignatedTarget"));
		this.z = "XPHWLDTSET";
		base.StaticEffects.Add(new l5(this.a()));
	}

	// Token: 0x06009318 RID: 37656 RVA: 0x003A1318 File Offset: 0x0039F518
	private double a()
	{
		return 0.5;
	}

	// Token: 0x06009319 RID: 37657 RVA: 0x003A1328 File Offset: 0x0039F528
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/LaserDesignatedTarget", new object[]
		{
			this.a().ToString("P0")
		});
	}

	// Token: 0x04003879 RID: 14457
	public new static readonly string a = "laserDesignatedTarget";

	// Token: 0x0400387A RID: 14458
	public a3s b;
}

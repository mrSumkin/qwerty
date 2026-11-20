using System;
using System.Linq;
using System.Runtime.Serialization;

// Token: 0x02001A7C RID: 6780
[eiz("BWUSE")]
[Serializable]
public sealed class ajy : els, ISerializable
{
	// Token: 0x0600933B RID: 37691 RVA: 0x003A1A40 File Offset: 0x0039FC40
	private ajy(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.b = A_0.GetDouble("BWUSE:R");
		this.c = (Guid)A_0.GetValue("BWUSE:W", typeof(Guid));
	}

	// Token: 0x0600933C RID: 37692 RVA: 0x003A1A88 File Offset: 0x0039FC88
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("BWUSE:R", this.b);
		info.AddValue("BWUSE:W", this.c);
	}

	// Token: 0x0600933D RID: 37693 RVA: 0x003A1ABC File Offset: 0x0039FCBC
	public ajy(cd1 A_0, double A_1, int A_2) : base("BurstWindUp:" + A_0.Id.ToString(), "Порыв очереди: " + A_0.TypedDefinition.az(), ci8.b)
	{
		this.b = A_1;
		this.c = A_0.Id;
		base.Duration = d0u.b * 2;
		base.Icon = "Status.138";
		base.MaxStacks = A_2;
		base.Stacking = axm.b;
		this.a();
	}

	// Token: 0x0600933E RID: 37694 RVA: 0x003A1B44 File Offset: 0x0039FD44
	public int b()
	{
		return (int)(this.b * (double)base.Stacks);
	}

	// Token: 0x0600933F RID: 37695 RVA: 0x003A1B58 File Offset: 0x0039FD58
	public int c()
	{
		return this.b() * 2;
	}

	// Token: 0x06009340 RID: 37696 RVA: 0x003A1B68 File Offset: 0x0039FD68
	public override string cb(ll A_0)
	{
		int num = this.b();
		int num2 = this.c();
		return qv.a("StatusEffects/BurstWindUp", new object[]
		{
			num,
			(num > 1) ? "" : "",
			num2,
			(num2 > 1) ? "" : ""
		});
	}

	// Token: 0x06009341 RID: 37697 RVA: 0x003A1BD8 File Offset: 0x0039FDD8
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x06009342 RID: 37698 RVA: 0x003A1BEC File Offset: 0x0039FDEC
	private void a()
	{
		int num = this.c();
		bjo bjo = Enumerable.FirstOrDefault<bjo>(Enumerable.OfType<bjo>(base.StaticEffects));
		if (bjo == null)
		{
			bjo = new bjo((float)(-(float)num) * d0u.c, -num, null);
			bjo.d = new Guid?(this.c);
			base.StaticEffects.Add(bjo);
			return;
		}
		bjo.d = new Guid?(this.c);
		bjo.ActionPointCostModification = -num;
		bjo.WeaponSpeedModification = (float)(-(float)num) * d0u.c;
	}

	// Token: 0x04003881 RID: 14465
	public new static readonly string a = "spearGuard";

	// Token: 0x04003882 RID: 14466
	public double b;

	// Token: 0x04003883 RID: 14467
	public new Guid c;
}

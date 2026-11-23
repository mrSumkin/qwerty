using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A84 RID: 6788
[eiz("MWSE")]
[Serializable]
public sealed class byf : els, ISerializable
{
	// Token: 0x06009362 RID: 37730 RVA: 0x003A2214 File Offset: 0x003A0414
	private byf(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.f = A_0.GetString("MSEX:S");
		this.g = (Vector3)A_0.GetValue("MSEX:C", typeof(Vector3));
		this.h = A_0.GetDouble("MSEX:R");
	}

	// Token: 0x06009363 RID: 37731 RVA: 0x003A2278 File Offset: 0x003A0478
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSEX:S", this.f);
		info.AddValue("MSEX:C", this.g);
		info.AddValue("MSEX:R", this.h);
	}

	// Token: 0x06009364 RID: 37732 RVA: 0x003A22C8 File Offset: 0x003A04C8
	public byf() : base(byf.i, "Вне движения", ci8.c)
	{
		base.Stacking = axm.b;
		base.Duration = 120000;
		base.Icon = "Status.129";
		base.MaxStacks = 20;
		this.p = true;
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Intelligence.ToString(), -byf.a));
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Perception.ToString(), -byf.a));
		base.StaticEffects.Add(new d72(-byf.b - byf.c));
		base.StaticEffects.Add(new emn(-byf.d));
		base.StaticEffects.Add(new cly(-byf.e)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x06009365 RID: 37733 RVA: 0x003A23BC File Offset: 0x003A05BC
	protected override void c8()
	{
		Enumerable.FirstOrDefault<d72>(Enumerable.OfType<d72>(base.StaticEffects)).a(-byf.b - byf.c * base.Stacks);
		Enumerable.FirstOrDefault<emn>(Enumerable.OfType<emn>(base.StaticEffects)).a(-byf.d * base.Stacks);
	}

	// Token: 0x06009366 RID: 37734 RVA: 0x003A2414 File Offset: 0x003A0614
	public override string cb(ll A_0)
	{
		int num = Math.Abs(Enumerable.FirstOrDefault<d72>(Enumerable.OfType<d72>(base.StaticEffects)).c());
		int num2 = Math.Abs(Enumerable.FirstOrDefault<emn>(Enumerable.OfType<emn>(base.StaticEffects)).c());
		return qv.a("StatusEffects/MotionWithdrawal", new object[]
		{
			byf.a,
			num,
			num2,
			Convert.ToInt32(byf.e * 100f)
		});
	}

	// Token: 0x04003890 RID: 14480
	private new static readonly int a = 4;

	// Token: 0x04003891 RID: 14481
	private static readonly int b = 0;

	// Token: 0x04003892 RID: 14482
	private new static readonly int c = 7;

	// Token: 0x04003893 RID: 14483
	private new static readonly int d = 1;

	// Token: 0x04003894 RID: 14484
	private new static readonly float e = 1f;

	// Token: 0x04003895 RID: 14485
	public string f;

	// Token: 0x04003896 RID: 14486
	public Vector3 g = Vector3.One;

	// Token: 0x04003897 RID: 14487
	public double h;

	// Token: 0x04003898 RID: 14488
	public new static readonly string i = "motionWithdrawal";
}

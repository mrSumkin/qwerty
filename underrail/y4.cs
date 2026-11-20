using System;
using System.Linq;
using System.Runtime.Serialization;
using Microsoft.Xna.Framework;
using TimelapseVertigo.Rules.Characters;

// Token: 0x02001A86 RID: 6790
[eiz("MSEX")]
[Serializable]
public sealed class y4 : els, ISerializable
{
	// Token: 0x0600936E RID: 37742 RVA: 0x003A2574 File Offset: 0x003A0774
	private y4(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.e = A_0.GetString("MSEX:S");
		this.f = (Vector3)A_0.GetValue("MSEX:C", typeof(Vector3));
		this.g = A_0.GetDouble("MSEX:R");
	}

	// Token: 0x0600936F RID: 37743 RVA: 0x003A25D8 File Offset: 0x003A07D8
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("MSEX:S", this.e);
		info.AddValue("MSEX:C", this.f);
		info.AddValue("MSEX:R", this.g);
	}

	// Token: 0x06009370 RID: 37744 RVA: 0x003A2628 File Offset: 0x003A0828
	public y4(int A_0) : base(y4.h, "В движении", ci8.a)
	{
		base.Duration = A_0;
		base.Icon = "Status.128";
		this.y = "Vfx_LimeGreenExpiration";
		this.aa = "Vfx_LimeGreenExpiration";
		base.MaxStacks = 30;
		base.Stacking = axm.b;
		this.p = true;
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Intelligence.ToString(), -y4.a));
		base.StaticEffects.Add(new ax6(BaseAbilityEnum.Perception.ToString(), -y4.a));
		base.StaticEffects.Add(new d72(y4.b));
		base.StaticEffects.Add(new emn(1));
		base.StaticEffects.Add(new cly(-y4.d)
		{
			Priority = int.MaxValue
		});
	}

	// Token: 0x06009371 RID: 37745 RVA: 0x003A2720 File Offset: 0x003A0920
	protected override void c8()
	{
		Enumerable.FirstOrDefault<d72>(Enumerable.OfType<d72>(base.StaticEffects)).a(y4.b * base.Stacks);
		Enumerable.FirstOrDefault<emn>(Enumerable.OfType<emn>(base.StaticEffects)).a(Math.Max(1, Convert.ToInt32(y4.c * (double)base.Stacks)));
	}

	// Token: 0x06009372 RID: 37746 RVA: 0x003A277C File Offset: 0x003A097C
	public override string cb(ll A_0)
	{
		int num = Enumerable.FirstOrDefault<d72>(Enumerable.OfType<d72>(base.StaticEffects)).c();
		int num2 = Enumerable.FirstOrDefault<emn>(Enumerable.OfType<emn>(base.StaticEffects)).c();
		return qv.a("StatusEffects/Motion", new object[]
		{
			y4.a,
			num,
			num2,
			Convert.ToInt32(y4.d * 100f)
		});
	}

	// Token: 0x0400389B RID: 14491
	private new static readonly int a = 2;

	// Token: 0x0400389C RID: 14492
	private static readonly int b = 1;

	// Token: 0x0400389D RID: 14493
	private new static readonly double c = 0.16;

	// Token: 0x0400389E RID: 14494
	private new static readonly float d = 1f;

	// Token: 0x0400389F RID: 14495
	public new string e;

	// Token: 0x040038A0 RID: 14496
	public Vector3 f = Vector3.One;

	// Token: 0x040038A1 RID: 14497
	public double g;

	// Token: 0x040038A2 RID: 14498
	public static readonly string h = "motion";
}

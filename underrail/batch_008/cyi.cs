using System;
using System.Runtime.Serialization;

// Token: 0x02001AEC RID: 6892
[eiz("PSEL")]
[Serializable]
public sealed class cyi : els, ISerializable
{
	// Token: 0x06009550 RID: 38224 RVA: 0x003A9780 File Offset: 0x003A7980
	private cyi(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.e = (A_0.GetValue("PSEL:S", typeof(l5)) as l5);
		if (ell.a() >= 397)
		{
			this.g = A_0.GetDouble("PSEL:C");
		}
		else
		{
			this.g = cyi.c;
		}
		if (ell.a() >= 450)
		{
			this.f = (A_0.GetValue("PSEL:P", typeof(e2e)) as e2e);
			return;
		}
		this.f = new e2e((double)base.Stacks * this.g);
	}

	// Token: 0x06009551 RID: 38225 RVA: 0x003A9830 File Offset: 0x003A7A30
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("PSEL:S", this.e);
		info.AddValue("PSEL:P", this.f);
		info.AddValue("PSEL:C", this.g);
	}

	// Token: 0x06009552 RID: 38226 RVA: 0x003A9878 File Offset: 0x003A7A78
	public cyi(efk A_0) : base(cyi.a, "Психостатическое электричество", ci8.c)
	{
		int num = cyi.b;
		this.g = cyi.c;
		if (A_0 != null)
		{
			this.g += (double)A_0.GetSpecializationValue<ede>(true) * ede.a;
			num += A_0.GetSpecializationValue<es9>(true) * es9.a;
		}
		base.Duration = num * d0u.b;
		base.Icon = "Status.PsychostaticElectricity";
		base.MaxStacks = cyi.d;
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "StaticElectricity"));
		base.Power = (int)(this.g * 100.0);
		this.e = new l5(0.0);
		this.f = new e2e(0.0);
		base.StaticEffects.Add(this.e);
		base.StaticEffects.Add(this.f);
		this.a();
	}

	// Token: 0x06009553 RID: 38227 RVA: 0x003A9980 File Offset: 0x003A7B80
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/PsychostaticElectricity", new object[]
		{
			Convert.ToInt32(this.e.Modifier * 100.0)
		});
	}

	// Token: 0x06009554 RID: 38228 RVA: 0x003A99B4 File Offset: 0x003A7BB4
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x06009555 RID: 38229 RVA: 0x003A99C4 File Offset: 0x003A7BC4
	protected override void dp()
	{
		base.dp();
		this.a();
	}

	// Token: 0x06009556 RID: 38230 RVA: 0x003A99D4 File Offset: 0x003A7BD4
	private void a()
	{
		this.e.Modifier = (double)base.Stacks * this.g;
		this.f.a((double)base.Stacks * this.g);
	}

	// Token: 0x0400397B RID: 14715
	public new static readonly string a = "psychostaticElectricity";

	// Token: 0x0400397C RID: 14716
	public static readonly int b = 2;

	// Token: 0x0400397D RID: 14717
	public new static readonly double c = 0.05;

	// Token: 0x0400397E RID: 14718
	public new static readonly int d = 5;

	// Token: 0x0400397F RID: 14719
	private new l5 e;

	// Token: 0x04003980 RID: 14720
	private e2e f;

	// Token: 0x04003981 RID: 14721
	private double g;
}

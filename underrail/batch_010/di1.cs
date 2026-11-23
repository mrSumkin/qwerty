using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AC2 RID: 6850
[eiz("PXSE")]
[Serializable]
public sealed class di1 : els, ISerializable
{
	// Token: 0x06009481 RID: 38017 RVA: 0x003A66C0 File Offset: 0x003A48C0
	private di1(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009482 RID: 38018 RVA: 0x003A66CC File Offset: 0x003A48CC
	public di1() : this(di1.a * d0u.b)
	{
	}

	// Token: 0x06009483 RID: 38019 RVA: 0x003A66E4 File Offset: 0x003A48E4
	public di1(int A_0) : base(di1.b, "Поляризованный", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "Status.Polarized";
		base.MaxStacks = di1.c;
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "Polarized"));
		this.ab = "PIJ1";
		this.y = "PIJ0";
		this.aa = "PIJ0";
		this.w = "PIJ1";
		this.x = "PIJ0";
		base.StaticEffects.Add(new ah(DamageType.Energy, 1.0, true, true, false)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new ah(DamageType.Electricity, 1.0, true, true, false)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new l5(0.0));
		this.a();
	}

	// Token: 0x06009484 RID: 38020 RVA: 0x003A67E4 File Offset: 0x003A49E4
	public double b()
	{
		ah ah = base.StaticEffects[0] as ah;
		return 1.0 - ah.Value;
	}

	// Token: 0x06009485 RID: 38021 RVA: 0x003A6814 File Offset: 0x003A4A14
	public override string cb(ll A_0)
	{
		ah ah = Enumerable.First<ah>(Enumerable.Where<ah>(Enumerable.OfType<ah>(base.StaticEffects), new Func<ah, bool>(di1.a.a.b)));
		ah ah2 = Enumerable.First<ah>(Enumerable.Where<ah>(Enumerable.OfType<ah>(base.StaticEffects), new Func<ah, bool>(di1.a.a.c)));
		l5 l = Enumerable.First<l5>(Enumerable.OfType<l5>(base.StaticEffects));
		return qv.a("StatusEffects/Polarized", new object[]
		{
			Convert.ToInt32((1.0 - ah.Value) * 100.0),
			Convert.ToInt32((1.0 - ah2.Value) * 100.0),
			Convert.ToInt32(l.Modifier * 100.0)
		});
	}

	// Token: 0x06009486 RID: 38022 RVA: 0x003A6920 File Offset: 0x003A4B20
	protected override void c8()
	{
		base.c8();
		this.a();
	}

	// Token: 0x06009487 RID: 38023 RVA: 0x003A6930 File Offset: 0x003A4B30
	private void a()
	{
		ah ah = Enumerable.First<ah>(Enumerable.Where<ah>(Enumerable.OfType<ah>(base.StaticEffects), new Func<ah, bool>(di1.a.a.a)));
		ah ah2 = Enumerable.First<ah>(Enumerable.Where<ah>(Enumerable.OfType<ah>(base.StaticEffects), new Func<ah, bool>(di1.a.a.d)));
		l5 l = Enumerable.First<l5>(Enumerable.OfType<l5>(base.StaticEffects));
		ah.Value = 1.0 - di1.d * (double)base.Stacks;
		ah2.Value = 1.0 - di1.e * (double)base.Stacks;
		l.Modifier = di1.f * (double)base.Stacks;
	}

	// Token: 0x0400391D RID: 14621
	public new static readonly int a = 2;

	// Token: 0x0400391E RID: 14622
	public static readonly string b = "polarized";

	// Token: 0x0400391F RID: 14623
	public new static readonly int c = 5;

	// Token: 0x04003920 RID: 14624
	public new static readonly double d = 0.1;

	// Token: 0x04003921 RID: 14625
	public new static readonly double e = 0.07;

	// Token: 0x04003922 RID: 14626
	public static readonly double f = 0.03;

	// Token: 0x02001AC3 RID: 6851
	[CompilerGenerated]
	[Serializable]
	private new sealed class a
	{
		// Token: 0x0600948B RID: 38027 RVA: 0x003A6A70 File Offset: 0x003A4C70
		internal bool b(ah A_0)
		{
			return A_0.DamageType == DamageType.Energy;
		}

		// Token: 0x0600948C RID: 38028 RVA: 0x003A6A7C File Offset: 0x003A4C7C
		internal bool c(ah A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x0600948D RID: 38029 RVA: 0x003A6A88 File Offset: 0x003A4C88
		internal bool a(ah A_0)
		{
			return A_0.DamageType == DamageType.Energy;
		}

		// Token: 0x0600948E RID: 38030 RVA: 0x003A6A94 File Offset: 0x003A4C94
		internal bool d(ah A_0)
		{
			return A_0.DamageType == DamageType.Electricity;
		}

		// Token: 0x04003923 RID: 14627
		public static readonly di1.a a = new di1.a();

		// Token: 0x04003924 RID: 14628
		public static Func<ah, bool> b;

		// Token: 0x04003925 RID: 14629
		public static Func<ah, bool> c;

		// Token: 0x04003926 RID: 14630
		public static Func<ah, bool> d;

		// Token: 0x04003927 RID: 14631
		public static Func<ah, bool> e;
	}
}

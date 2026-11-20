using System;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A90 RID: 6800
[eiz("WUSE")]
[Serializable]
public sealed class a0s : els, ISerializable
{
	// Token: 0x0600939C RID: 37788 RVA: 0x003A31FC File Offset: 0x003A13FC
	private a0s(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x0600939D RID: 37789 RVA: 0x003A3208 File Offset: 0x003A1408
	public a0s() : this(a0s.b)
	{
	}

	// Token: 0x0600939E RID: 37790 RVA: 0x003A3218 File Offset: 0x003A1418
	public a0s(int A_0) : base(a0s.i, "Разогретый", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.WarmedUp";
		base.MaxStacks = a0s.a;
		base.Stacking = axm.b;
		this.p = true;
		this.c8();
	}

	// Token: 0x0600939F RID: 37791 RVA: 0x003A3268 File Offset: 0x003A1468
	public override string cb(ll A_0)
	{
		cgv a_ = Enumerable.FirstOrDefault<cgv>(Enumerable.OfType<cgv>(base.StaticEffects));
		yd yd = Enumerable.FirstOrDefault<yd>(Enumerable.OfType<yd>(base.StaticEffects));
		b2g b2g = Enumerable.FirstOrDefault<b2g>(Enumerable.OfType<b2g>(base.StaticEffects));
		awe awe = Enumerable.FirstOrDefault<awe>(Enumerable.OfType<awe>(base.StaticEffects));
		string result = "";
		this.a(ref result, a_);
		if (awe.Immunity != CharacterImmunities.None)
		{
			this.a(ref result, awe);
		}
		if (yd.MovementSpeed != 0f)
		{
			this.a(ref result, yd);
		}
		if (b2g.Value != 0.0)
		{
			this.a(ref result, b2g);
		}
		return result;
	}

	// Token: 0x060093A0 RID: 37792 RVA: 0x003A3318 File Offset: 0x003A1518
	private void a(ref string A_0, d3e A_1)
	{
		if (A_1 != null)
		{
			if (A_0 != string.Empty)
			{
				if (A_0.EndsWith("."))
				{
					A_0 += " ";
				}
				else
				{
					A_0 += ". ";
				}
			}
			A_0 += A_1.ToString();
			if (!A_0.EndsWith("."))
			{
				A_0 += ".";
			}
		}
	}

	// Token: 0x060093A1 RID: 37793 RVA: 0x003A339C File Offset: 0x003A159C
	protected override void c8()
	{
		cgv cgv = Enumerable.FirstOrDefault<cgv>(Enumerable.OfType<cgv>(base.StaticEffects));
		yd yd = Enumerable.FirstOrDefault<yd>(Enumerable.OfType<yd>(base.StaticEffects));
		b2g b2g = Enumerable.FirstOrDefault<b2g>(Enumerable.OfType<b2g>(base.StaticEffects));
		awe awe = Enumerable.FirstOrDefault<awe>(Enumerable.OfType<awe>(base.StaticEffects));
		if (cgv == null)
		{
			cgv = new cgv(DamageType.Cold, 0.0, 0);
			base.StaticEffects.Add(cgv);
		}
		cgv.Resistance = a0s.c + (double)base.Stacks * a0s.d;
		cgv.Threshold = a0s.e + base.Stacks * a0s.f;
		if (yd == null)
		{
			yd = new yd(0f, 0, true, false, false);
			base.StaticEffects.Add(yd);
		}
		if (awe == null)
		{
			awe = new awe(CharacterImmunities.Chill | CharacterImmunities.Freeze);
			base.StaticEffects.Add(awe);
		}
		if (b2g == null)
		{
			b2g = new b2g(0.15);
			base.StaticEffects.Add(b2g);
		}
		if (base.Stacks >= base.MaxStacks - 1)
		{
			yd.MovementSpeed = a0s.h;
			yd.MovementPoints = a0s.g;
			awe.Immunity = (CharacterImmunities.Chill | CharacterImmunities.Freeze);
		}
		else
		{
			yd.MovementSpeed = 0f;
			yd.MovementPoints = 0;
			awe.Immunity = CharacterImmunities.None;
		}
		if (base.Stacks == base.MaxStacks)
		{
			b2g.Value = 0.15;
			return;
		}
		b2g.Value = 0.0;
	}

	// Token: 0x040038B3 RID: 14515
	public new static readonly int a = 4;

	// Token: 0x040038B4 RID: 14516
	public static readonly int b = 2 * d0u.b;

	// Token: 0x040038B5 RID: 14517
	public new static readonly double c = 0.1;

	// Token: 0x040038B6 RID: 14518
	public new static readonly double d = 0.05;

	// Token: 0x040038B7 RID: 14519
	public new static readonly int e = 2;

	// Token: 0x040038B8 RID: 14520
	public static readonly int f = 2;

	// Token: 0x040038B9 RID: 14521
	public static readonly int g = 5;

	// Token: 0x040038BA RID: 14522
	public static readonly float h = 0.2f;

	// Token: 0x040038BB RID: 14523
	public new static readonly string i = "warmedUp";
}

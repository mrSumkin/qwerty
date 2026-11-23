using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001C06 RID: 7174
[eiz("CPO")]
[Serializable]
public sealed class bas : dzz, ISerializable
{
	// Token: 0x06009CEA RID: 40170 RVA: 0x003DA3A8 File Offset: 0x003D85A8
	private bas(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() != 0)
		{
			this.a = A_0.GetInt32("CPO:SL");
			this.b = A_0.GetSingle("CPO:CDB");
			this.c = A_0.GetSingle("CPO:CC");
			this.d = (PsiSchool)A_0.GetValue("CPO:S", typeof(PsiSchool));
			this.e = (ahx)A_0.GetValue("CPO:II", typeof(ahx));
			if (ell.a() >= 162)
			{
				this.f = A_0.GetDouble("CPO:C");
				return;
			}
			this.f = 1.0;
			return;
		}
		else
		{
			if (base.GetType() == typeof(bas))
			{
				this.a = A_0.GetInt32("_SkillLevel");
				this.b = A_0.GetSingle("_CriticalDamageBonus");
				this.c = A_0.GetSingle("_CriticalChance");
				this.d = (PsiSchool)A_0.GetValue("_School", typeof(PsiSchool));
				this.e = (ahx)A_0.GetValue("_InterruptionInfo", typeof(ahx));
				return;
			}
			this.a = A_0.GetInt32("CharacterPsiOffense+_SkillLevel");
			this.b = A_0.GetSingle("CharacterPsiOffense+_CriticalDamageBonus");
			this.c = A_0.GetSingle("CharacterPsiOffense+_CriticalChance");
			this.d = (PsiSchool)A_0.GetValue("CharacterPsiOffense+_School", typeof(PsiSchool));
			this.e = (ahx)A_0.GetValue("CharacterPsiOffense+_InterruptionInfo", typeof(ahx));
			return;
		}
	}

	// Token: 0x06009CEB RID: 40171 RVA: 0x003DA588 File Offset: 0x003D8788
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("CPO:SL", this.a);
		info.AddValue("CPO:CDB", this.b);
		info.AddValue("CPO:CC", this.c);
		info.AddValue("CPO:S", this.d);
		info.AddValue("CPO:II", this.e);
		info.AddValue("CPO:C", this.f);
	}

	// Token: 0x06009CEC RID: 40172 RVA: 0x003DA608 File Offset: 0x003D8808
	public bas(efk A_0, PsiSchool A_1) : base(A_0)
	{
		this.d = A_1;
	}

	// Token: 0x06009CED RID: 40173 RVA: 0x003DA634 File Offset: 0x003D8834
	public PsiSchool a()
	{
		return this.d;
	}

	// Token: 0x06009CEE RID: 40174 RVA: 0x003DA63C File Offset: 0x003D883C
	public float e()
	{
		return this.c;
	}

	// Token: 0x06009CEF RID: 40175 RVA: 0x003DA644 File Offset: 0x003D8844
	public void a(float A_0)
	{
		this.c = A_0;
	}

	// Token: 0x06009CF0 RID: 40176 RVA: 0x003DA650 File Offset: 0x003D8850
	public float g()
	{
		return this.b;
	}

	// Token: 0x06009CF1 RID: 40177 RVA: 0x003DA658 File Offset: 0x003D8858
	public void b(float A_0)
	{
		this.b = A_0;
	}

	// Token: 0x06009CF2 RID: 40178 RVA: 0x003DA664 File Offset: 0x003D8864
	public int b()
	{
		return this.a;
	}

	// Token: 0x06009CF3 RID: 40179 RVA: 0x003DA66C File Offset: 0x003D886C
	public ahx c()
	{
		return this.e;
	}

	// Token: 0x06009CF4 RID: 40180 RVA: 0x003DA674 File Offset: 0x003D8874
	public double f()
	{
		return this.f;
	}

	// Token: 0x06009CF5 RID: 40181 RVA: 0x003DA67C File Offset: 0x003D887C
	public void a(double A_0)
	{
		this.f = Math.Max(0.1, A_0);
	}

	// Token: 0x06009CF6 RID: 40182 RVA: 0x003DA694 File Offset: 0x003D8894
	public void d()
	{
		csn csn;
		if (this.d == PsiSchool.ThoughtControl)
		{
			csn = base.a1().Skills.Get<dql>();
		}
		else if (this.d == PsiSchool.Psychokinesis)
		{
			csn = base.a1().Skills.Get<fd>();
		}
		else if (this.d == PsiSchool.Metathermics)
		{
			csn = base.a1().Skills.Get<rs>();
		}
		else
		{
			csn = base.a1().Skills.Get<p5>();
		}
		if (csn != null)
		{
			this.a = csn.g();
		}
		else
		{
			this.a = 0;
		}
		this.c = 0.05f;
		this.b = 1f;
		this.f = 1.0;
		if (base.a1() != null && !(base.a1() is e3q))
		{
			this.c += euf.b().NpcCritChanceBonus;
		}
		this.e.a();
		this.e.b = (double)base.a1().BaseAbilities.Will / 100.0;
	}

	// Token: 0x06009CF7 RID: 40183 RVA: 0x003DA7C0 File Offset: 0x003D89C0
	[OnDeserialized]
	private void a(StreamingContext A_0)
	{
		if (this.e == null)
		{
			this.e = new ahx();
		}
	}

	// Token: 0x04003CB7 RID: 15543
	private int a;

	// Token: 0x04003CB8 RID: 15544
	private float b;

	// Token: 0x04003CB9 RID: 15545
	private float c;

	// Token: 0x04003CBA RID: 15546
	private PsiSchool d;

	// Token: 0x04003CBB RID: 15547
	private ahx e = new ahx();

	// Token: 0x04003CBC RID: 15548
	private double f = 1.0;
}

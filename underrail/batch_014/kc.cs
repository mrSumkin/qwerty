using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A71 RID: 6769
[eiz("WPISE")]
[Serializable]
public sealed class kc : els, ISerializable
{
	// Token: 0x06009304 RID: 37636 RVA: 0x003A0CA0 File Offset: 0x0039EEA0
	private kc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009305 RID: 37637 RVA: 0x003A0CAC File Offset: 0x0039EEAC
	public PsiSchool a()
	{
		return this.b;
	}

	// Token: 0x06009306 RID: 37638 RVA: 0x003A0CB8 File Offset: 0x0039EEB8
	public kc(PsiSchool A_0, int A_1, float A_2, float A_3, float A_4) : base(kc.a, "Эскалация псионической иннервации", ci8.b)
	{
		this.b = A_0;
		this.c = A_1;
		this.d = A_2;
		this.e = A_3;
		this.f = A_4;
		base.Duration = zw.c * d0u.b;
		base.Icon = "Abilities.110";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new dpw(this.b.ToString().a(), this.c));
		base.StaticEffects.Add(new ato(new PsiSchool?(this.b), -this.d));
		base.StaticEffects.Add(new bi0(new PsiSchool?(this.b), this.e));
		base.StaticEffects.Add(new db(new PsiSchool?(this.b), this.f));
		foreach (object obj in Enum.GetValues(typeof(PsiSchool)))
		{
			PsiSchool psiSchool = (PsiSchool)obj;
			if (psiSchool != this.b)
			{
				base.StaticEffects.Add(new ato(new PsiSchool?(psiSchool), zw.i));
			}
		}
	}

	// Token: 0x06009307 RID: 37639 RVA: 0x003A0E2C File Offset: 0x0039F02C
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/WildPsionicInnervation", new object[]
		{
			this.c,
			this.e.ToString("P0"),
			this.f.ToString("P0"),
			this.d.ToString("P0"),
			this.b.ToString().a(),
			zw.i.ToString("P0")
		});
	}

	// Token: 0x0400386F RID: 14447
	public new static readonly string a = "wildPsionicInnervation";

	// Token: 0x04003870 RID: 14448
	private PsiSchool b;

	// Token: 0x04003871 RID: 14449
	private new int c;

	// Token: 0x04003872 RID: 14450
	private new float d;

	// Token: 0x04003873 RID: 14451
	private new float e;

	// Token: 0x04003874 RID: 14452
	private float f;
}

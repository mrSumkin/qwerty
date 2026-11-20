using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A1A RID: 6682
[eiz("M27")]
[Serializable]
public sealed class ato : dh6, ISerializable
{
	// Token: 0x06009093 RID: 37011 RVA: 0x0039AB84 File Offset: 0x00398D84
	private ato(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("M26:S", typeof(PsiSchool?)) as PsiSchool?);
	}

	// Token: 0x06009094 RID: 37012 RVA: 0x0039ABB4 File Offset: 0x00398DB4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M26:S", this.a);
	}

	// Token: 0x17000244 RID: 580
	// (get) Token: 0x06009095 RID: 37013 RVA: 0x0039ABD4 File Offset: 0x00398DD4
	// (set) Token: 0x06009096 RID: 37014 RVA: 0x0039ABDC File Offset: 0x00398DDC
	public PsiSchool? PsiSchool
	{
		get
		{
			return this.a;
		}
		set
		{
			this.a = value;
		}
	}

	// Token: 0x17000245 RID: 581
	// (get) Token: 0x06009097 RID: 37015 RVA: 0x0039ABE8 File Offset: 0x00398DE8
	public override bool Negative
	{
		get
		{
			return base.c() > 0f;
		}
	}

	// Token: 0x06009098 RID: 37016 RVA: 0x0039ABF8 File Offset: 0x00398DF8
	public ato()
	{
	}

	// Token: 0x06009099 RID: 37017 RVA: 0x0039AC00 File Offset: 0x00398E00
	public ato(PsiSchool? A_0, float A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x0600909A RID: 37018 RVA: 0x0039AC14 File Offset: 0x00398E14
	protected override void @in(ll A_0)
	{
		czh.a(A_0, "context");
		if (A_0.a() != null)
		{
			if (this.a == null)
			{
				using (Dictionary<PsiSchool, bas>.Enumerator enumerator = A_0.a().Offense.ag().GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						KeyValuePair<PsiSchool, bas> keyValuePair = enumerator.Current;
						bas value = keyValuePair.Value;
						value.a(value.f() + Math.Round((double)base.c(), 2));
					}
					return;
				}
			}
			bas bas = A_0.a().Offense.ag()[this.a.Value];
			bas.a(bas.f() + Math.Round((double)base.c(), 2));
		}
	}

	// Token: 0x0600909B RID: 37019 RVA: 0x0039ACF4 File Offset: 0x00398EF4
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((ato)A_0).a = this.a;
	}

	// Token: 0x0600909C RID: 37020 RVA: 0x0039AD10 File Offset: 0x00398F10
	public override string b2()
	{
		string text;
		if (this.a != null)
		{
			text = dh9.a(this.a.Value);
		}
		else
		{
			text = dh9.a("PsiSchool.PsiAbility");
			if (string.IsNullOrEmpty(text))
			{
				text = "пси-способности";
			}
		}
		if (base.c() > 0f)
		{
			return qv.a("StaticEffects/ModifyPsiCostModifier_Increased", new object[]
			{
				text,
				(int)(Math.Abs(base.c()) * 100f)
			});
		}
		return qv.a("StaticEffects/ModifyPsiCostModifier_Decreased", new object[]
		{
			text,
			(int)(Math.Abs(base.c()) * 100f)
		});
	}

	// Token: 0x0600909D RID: 37021 RVA: 0x0039ADD4 File Offset: 0x00398FD4
	public override d3e b3()
	{
		ato ato = new ato();
		this.xx(ato);
		return ato;
	}

	// Token: 0x04003812 RID: 14354
	private new PsiSchool? a;
}

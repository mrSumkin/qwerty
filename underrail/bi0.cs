using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A28 RID: 6696
[eiz("M25")]
[Serializable]
public sealed class bi0 : dh6, ISerializable
{
	// Token: 0x060090F0 RID: 37104 RVA: 0x0039BC84 File Offset: 0x00399E84
	private bi0(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		if (ell.a() >= 161)
		{
			this.a = (A_0.GetValue("M25:S", typeof(PsiSchool?)) as PsiSchool?);
			return;
		}
		this.a = new PsiSchool?((PsiSchool)A_0.GetValue("M25:S", typeof(PsiSchool)));
	}

	// Token: 0x060090F1 RID: 37105 RVA: 0x0039BCF4 File Offset: 0x00399EF4
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M25:S", this.a);
	}

	// Token: 0x17000249 RID: 585
	// (get) Token: 0x060090F2 RID: 37106 RVA: 0x0039BD14 File Offset: 0x00399F14
	// (set) Token: 0x060090F3 RID: 37107 RVA: 0x0039BD1C File Offset: 0x00399F1C
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

	// Token: 0x060090F4 RID: 37108 RVA: 0x0039BD28 File Offset: 0x00399F28
	public bi0()
	{
	}

	// Token: 0x060090F5 RID: 37109 RVA: 0x0039BD30 File Offset: 0x00399F30
	public bi0(PsiSchool? A_0, float A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x060090F6 RID: 37110 RVA: 0x0039BD40 File Offset: 0x00399F40
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
						value.a(value.e() + base.c());
					}
					return;
				}
			}
			bas bas = A_0.a().Offense.ag()[this.a.Value];
			bas.a(bas.e() + base.c());
		}
	}

	// Token: 0x060090F7 RID: 37111 RVA: 0x0039BE10 File Offset: 0x0039A010
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((bi0)A_0).a = this.a;
	}

	// Token: 0x060090F8 RID: 37112 RVA: 0x0039BE2C File Offset: 0x0039A02C
	public override d3e b3()
	{
		bi0 bi = new bi0();
		this.xx(bi);
		return bi;
	}

	// Token: 0x060090F9 RID: 37113 RVA: 0x0039BE48 File Offset: 0x0039A048
	public override string b2()
	{
		string text;
		if (this.a != null)
		{
			text = dh9.a(this.a.Value);
		}
		else
		{
			text = dh9.a("PsiSchool.Psionic");
			if (string.IsNullOrEmpty(text))
			{
				text = "Псионическ.";
			}
		}
		if (base.c() >= 0f)
		{
			return qv.a("StaticEffects/ModifyPsiCriticalChance_Increased", new object[]
			{
				text,
				Convert.ToInt32(Math.Abs(base.c()) * 100f)
			});
		}
		return qv.a("StaticEffects/ModifyPsiCriticalChance_Decreased", new object[]
		{
			text,
			Convert.ToInt32(Math.Abs(base.c()) * 100f)
		});
	}

	// Token: 0x0400381C RID: 14364
	private new PsiSchool? a;
}

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001A1B RID: 6683
[eiz("M26")]
[Serializable]
public sealed class db : dh6, ISerializable
{
	// Token: 0x0600909E RID: 37022 RVA: 0x0039ADF0 File Offset: 0x00398FF0
	private db(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
		this.a = (A_0.GetValue("M26:S", typeof(PsiSchool?)) as PsiSchool?);
	}

	// Token: 0x0600909F RID: 37023 RVA: 0x0039AE20 File Offset: 0x00399020
	public override void GetObjectData(SerializationInfo info, StreamingContext ctx)
	{
		base.GetObjectData(info, ctx);
		info.AddValue("M26:S", this.a);
	}

	// Token: 0x17000246 RID: 582
	// (get) Token: 0x060090A0 RID: 37024 RVA: 0x0039AE40 File Offset: 0x00399040
	// (set) Token: 0x060090A1 RID: 37025 RVA: 0x0039AE48 File Offset: 0x00399048
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

	// Token: 0x060090A2 RID: 37026 RVA: 0x0039AE54 File Offset: 0x00399054
	public db()
	{
	}

	// Token: 0x060090A3 RID: 37027 RVA: 0x0039AE5C File Offset: 0x0039905C
	public db(PsiSchool? A_0, float A_1) : base(A_1)
	{
		this.a = A_0;
	}

	// Token: 0x060090A4 RID: 37028 RVA: 0x0039AE70 File Offset: 0x00399070
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
						value.b(value.g() + base.c());
					}
					return;
				}
			}
			bas bas = A_0.a().Offense.ag()[this.a.Value];
			bas.b(bas.g() + base.c());
		}
	}

	// Token: 0x060090A5 RID: 37029 RVA: 0x0039AF40 File Offset: 0x00399140
	protected override void xx(d3e A_0)
	{
		base.xx(A_0);
		((db)A_0).a = this.a;
	}

	// Token: 0x060090A6 RID: 37030 RVA: 0x0039AF5C File Offset: 0x0039915C
	public override string b2()
	{
		string text;
		if (this.a != null)
		{
			text = dh9.a(this.a.Value);
		}
		else
		{
			text = (dh9.a("PsiSchool.Psionic") ?? "Псионика");
			if (string.IsNullOrEmpty(text))
			{
				text = "Псионика";
			}
		}
		if (base.c() > 0f)
		{
			return qv.a("StaticEffects/ModifyPsiCriticalModifier_Increased", new object[]
			{
				text,
				Convert.ToInt32(Math.Abs(base.c()) * 100f)
			});
		}
		return qv.a("StaticEffects/ModifyPsiCriticalModifier_Decreased", new object[]
		{
			text,
			Convert.ToInt32(Math.Abs(base.c()) * 100f)
		});
	}

	// Token: 0x060090A7 RID: 37031 RVA: 0x0039B034 File Offset: 0x00399234
	public override d3e b3()
	{
		db db = new db();
		this.xx(db);
		return db;
	}

	// Token: 0x04003813 RID: 14355
	private new PsiSchool? a;
}

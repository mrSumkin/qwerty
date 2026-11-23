using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AE7 RID: 6887
[eiz("ERSE")]
[Serializable]
public sealed class aj8 : els, ISerializable
{
	// Token: 0x06009533 RID: 38195 RVA: 0x003A9058 File Offset: 0x003A7258
	private aj8(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009534 RID: 38196 RVA: 0x003A9064 File Offset: 0x003A7264
	public aj8(int A_0, efk A_1, List<csk> A_2) : base(aj8.a, "Энтропийный повтор", ci8.c)
	{
		base.Duration = A_0;
		base.TickPeriod = d0u.b;
		base.Icon = "Psi.EntropicRecurrence";
		base.VisualEffects.Add(new ud(this, "EntropicRecurrence"));
		base.MaxStacks = 1;
		base.Stacking = axm.c;
		cwt cwt = new cwt();
		if (A_1 != null)
		{
			cwt.i = new ap9(A_1);
		}
		cwt.e = false;
		cwt.r = true;
		cwt.f = new List<csk>(A_2);
		cwt.q = false;
		cwt.b = true;
		cwt.p = true;
		cwt.l = true;
		cwt.v = "энтропийный повтор";
		cwt.ad["PsionicSource"] = PsiSchool.TemporalManipulation;
		base.DynamicEffects.Add(new vf(cwt, cwt, null));
	}

	// Token: 0x06009535 RID: 38197 RVA: 0x003A9148 File Offset: 0x003A7348
	public override string cb(ll A_0)
	{
		string text = "";
		vf vf = Enumerable.FirstOrDefault<wq>(base.DynamicEffects) as vf;
		if (vf != null)
		{
			for (int i = 0; i < vf.TurnTickAttack.f.Count; i++)
			{
				if (i != 0)
				{
					if (i == vf.TurnTickAttack.f.Count - 1)
					{
						text += " и ";
					}
					else
					{
						text += ", ";
					}
				}
				text += vf.TurnTickAttack.f[i].a(true);
			}
		}
		return qv.a("StatusEffects/EntropicRecurrence", new object[]
		{
			text
		});
	}

	// Token: 0x0400396D RID: 14701
	public new static readonly string a = "entropicRecurrence";
}

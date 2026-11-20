using System;
using System.Runtime.Serialization;

// Token: 0x02001B22 RID: 6946
[eiz("P19")]
[Serializable]
public sealed class dlo : els, ISerializable
{
	// Token: 0x06009645 RID: 38469 RVA: 0x003AD248 File Offset: 0x003AB448
	private dlo(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x06009646 RID: 38470 RVA: 0x003AD254 File Offset: 0x003AB454
	public dlo(int A_0) : base(dlo.a, "Псионическое привидение", ci8.a)
	{
		base.Duration = A_0;
		base.Icon = "Status.PsiBoost";
		base.Stacking = axm.b;
		base.VisualEffects.Add(new ud(this, "Displacement"));
		base.VisualEffects.Add(new ud(this, "Stealth"));
	}

	// Token: 0x06009647 RID: 38471 RVA: 0x003AD2B8 File Offset: 0x003AB4B8
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/PsionicApparition");
	}

	// Token: 0x040039D7 RID: 14807
	public new static readonly string a = "psionicApparition";
}

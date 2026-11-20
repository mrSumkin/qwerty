using System;
using System.Runtime.Serialization;
using TimelapseVertigo.Rules.Characters;
using TimelapseVertigo.Rules.Combat;

// Token: 0x02001AD8 RID: 6872
[eiz("SSS1")]
[Serializable]
public sealed class ewc : els, ISerializable
{
	// Token: 0x060094F1 RID: 38129 RVA: 0x003A80F4 File Offset: 0x003A62F4
	private ewc(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060094F2 RID: 38130 RVA: 0x003A8100 File Offset: 0x003A6300
	public ewc(int A_0) : base(ewc.a, "Погружение", ci8.b)
	{
		base.Icon = "Status.Submerged";
		base.Silent = true;
		base.Duration = A_0;
		base.StaticEffects.Add(new a6z(300));
		base.StaticEffects.Add(new bel(100));
		base.StaticEffects.Add(new awe(CharacterImmunities.Burning));
		foreach (object obj in Enum.GetValues(typeof(DamageType)))
		{
			DamageType a_ = (DamageType)obj;
			base.StaticEffects.Add(new cgv(a_, 0.5, 0));
		}
	}

	// Token: 0x060094F3 RID: 38131 RVA: 0x003A81E8 File Offset: 0x003A63E8
	public override string cb(ll A_0)
	{
		int num = ((a6z)base.StaticEffects[0]).c();
		int num2 = ((bel)base.StaticEffects[1]).c();
		double num3 = ((cgv)base.StaticEffects[3]).Resistance;
		return qv.a("StatusEffects/Submerged", new object[]
		{
			num,
			num2,
			(int)(num3 * 100.0)
		});
	}

	// Token: 0x0400395B RID: 14683
	public new static readonly string a = "submerged";
}

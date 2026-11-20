using System;
using System.Runtime.Serialization;

// Token: 0x02001B06 RID: 6918
[eiz("HMSE")]
[Serializable]
public sealed class cqr : els, ISerializable
{
	// Token: 0x060095CA RID: 38346 RVA: 0x003AB61C File Offset: 0x003A981C
	private cqr(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095CB RID: 38347 RVA: 0x003AB628 File Offset: 0x003A9828
	public cqr(int A_0) : base("herculeanMight", "Гераклова мощь", ci8.b)
	{
		base.Duration = A_0;
		base.Icon = "Status.49";
		this.y = "HEJX0";
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ax6("Strength", cqr.a));
		base.StaticEffects.Add(new ax6("Dexterity", cqr.a));
		base.StaticEffects.Add(new ax6("Constitution", cqr.a));
		base.StaticEffects.Add(new ax6("Agility", cqr.a));
	}

	// Token: 0x060095CC RID: 38348 RVA: 0x003AB6D4 File Offset: 0x003A98D4
	public override string cb(ll A_0)
	{
		return qv.a("StatusEffects/HerculeanMight", new object[]
		{
			cqr.a
		});
	}

	// Token: 0x040039A8 RID: 14760
	public new static readonly int a = 5;
}

using System;
using System.Runtime.Serialization;

// Token: 0x02001B02 RID: 6914
[eiz("DPSE")]
[Serializable]
public sealed class ex : els, ISerializable
{
	// Token: 0x060095B8 RID: 38328 RVA: 0x003AB010 File Offset: 0x003A9210
	private ex(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060095B9 RID: 38329 RVA: 0x003AB01C File Offset: 0x003A921C
	public ex() : base(ex.a, "Управление дредноутом", ci8.a)
	{
		base.Duration = 0;
		base.Icon = "Status.DreadnoughtPiloting";
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new acl());
		base.StaticEffects.Add(new i0(-0.4f, false, true, false)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new djq("Strength", 25)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new djq("Dexterity", 5)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new djq("Agility", 5)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new djq("Constitution", 20)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new dpw("Stealth", -1000)
		{
			Priority = int.MaxValue
		});
		base.StaticEffects.Add(new e1c(1000));
	}

	// Token: 0x060095BA RID: 38330 RVA: 0x003AB150 File Offset: 0x003A9350
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/DreadnoughtPiloting");
	}

	// Token: 0x040039A1 RID: 14753
	public new static readonly string a = "dreadnoughtPiloting";
}

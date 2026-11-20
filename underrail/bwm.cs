using System;
using System.Runtime.Serialization;

// Token: 0x020013BC RID: 5052
[eiz("DDRHFX")]
[bs6("HFX:destroyDestructableRocks")]
[Serializable]
public sealed class bwm : cpl, ISerializable
{
	// Token: 0x060071D5 RID: 29141 RVA: 0x002FCC50 File Offset: 0x002FAE50
	private bwm(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060071D6 RID: 29142 RVA: 0x002FCC5C File Offset: 0x002FAE5C
	public bwm()
	{
	}

	// Token: 0x060071D7 RID: 29143 RVA: 0x002FCC68 File Offset: 0x002FAE68
	protected override dc4 fr(TimeSpan A_0, TimeSpan A_1)
	{
		if (!base.agw().b)
		{
			return dc4.c;
		}
		if (base.b().aa().Passive && !base.b().aa().Dead && base.b().a8() != null && ((base.b().a8().o.b != null && base.b().a8().o.b.a == "Objects\\Destructables\\DestructableRocks") || (base.b().a8().o.b != null && base.b().a8().o.b.a == "Objects\\Natural\\CrumbledRock") || base.b().a8().TileFormationModifiers.b(32768L)))
		{
			base.b().aa().a(null, null, false);
		}
		return dc4.c;
	}
}

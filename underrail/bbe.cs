using System;
using System.Runtime.Serialization;

// Token: 0x02001A6D RID: 6765
[eiz("SBESE")]
[Serializable]
public sealed class bbe : els, ISerializable
{
	// Token: 0x060092F1 RID: 37617 RVA: 0x003A0768 File Offset: 0x0039E968
	private bbe(SerializationInfo A_0, StreamingContext A_1) : base(A_0, A_1)
	{
	}

	// Token: 0x060092F2 RID: 37618 RVA: 0x003A0774 File Offset: 0x0039E974
	public bbe(int A_0) : base("stoneBolasEntanglement", "Опутывание", ci8.c)
	{
		base.Duration = A_0;
		base.Icon = "xpbl_Weapons.207";
		base.VisualEffects.Add(new ud(this, "StoneBolasEntanglement"));
		base.MaxStacks = 1;
		base.Stacking = axm.b;
		base.StaticEffects.Add(new ap0());
	}

	// Token: 0x060092F3 RID: 37619 RVA: 0x003A07D8 File Offset: 0x0039E9D8
	public override string cb(ll A_0)
	{
		return qv.b("StatusEffects/StoneBolasEntanglement");
	}
}
